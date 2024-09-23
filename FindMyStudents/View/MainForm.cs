using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using FindMyStudents.Model;

namespace FindMyStudents
{
    public partial class MainForm : Form
    {
        private readonly List<Student> _students = new List<Student>();
        private Student _currentStudent;
        private bool isDataSaved;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadSavedDataIntoList();
            EducationFormComboBox_Load();
            FacultyComboBox_Load();
        }

        /// <summary>
        ///     Добавляет студентов, полученных из памяти в список студентов.
        /// </summary>
        private void LoadSavedDataIntoList()
        {
            if (IsDataFileExist())
            { 
                _students.AddRange(GetSavedStudentsArray());
                isDataSaved = true;
            }

            UpdateListBox();
        }

        /// <summary>
        ///     Проверяет существование файла с сохранением.
        /// </summary>
        /// <returns>True, если файл существует, иначе false.</returns>
        private bool IsDataFileExist()
        {
            return new FileInfo(GetDataFilePath()).Exists;
        }

        /// <summary>
        ///     Возвращает путь к файлу с сохранением
        /// </summary>
        /// <param name="directory">Если true, то возвращает путь к папке с файлом сохранения. По умолчанию false.</param>
        /// <returns></returns>
        private string GetDataFilePath(bool directory = false)
        {
            if (!directory)
                return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) +
                       @"\VoidPublishing\MyStudents\savedData\data.json";
            return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) +
                   @"\VoidPublishing\MyStudents\savedData\";
        }

        /// <summary>
        ///     Десереализирует JSONы из фалйа сохранения.
        /// </summary>
        /// <returns>Массив с экземплярами класса Student <see cref="Student" /></returns>
        private Student[] GetSavedStudentsArray()
        {
            var output = new List<Student>();
            foreach (var jsonStudent in GetJsonStudentsData().Split('\n'))
                if (jsonStudent != "")
                    output.Add(JsonSerializer.Deserialize<Student>(jsonStudent));

            return output.ToArray();
        }

        /// <summary>
        ///     Считывает json.
        /// </summary>
        /// <returns></returns>
        private string GetJsonStudentsData()
        {
            using (var reader = new StreamReader(GetDataFilePath()))
            {
                return reader.ReadToEnd();
            }
        }

        /// <summary>
        ///     Заполняет ComboBox значениями перечисления <see cref="Faculties" />.
        /// </summary>
        private void EducationFormComboBox_Load()
        {
            foreach (var value in Enum.GetNames(typeof(EducationForms)))
                if (value != "None")
                    EducationFormComboBox.Items.Add(
                        EnumParser.GetStringEducationForm((EducationForms)Enum.Parse(typeof(EducationForms), value)));
        }

        /// <summary>
        ///     Заполняет ComboBox значениями перечисления <see cref="EducationForms" />.
        /// </summary>
        private void FacultyComboBox_Load()
        {
            foreach (var value in Enum.GetNames(typeof(Faculties)))
                if (value != "None")
                    FacultyComboBox.Items.Add(
                        EnumParser.GetStringFaculty((Faculties)Enum.Parse(typeof(Faculties), value)));
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            _students.Add(new Student());
            UpdateListBox();
            isDataSaved = false;
        }

        /// <summary>
        ///     Обновляет ListBox, заполняя его отсортированным списком студентов.
        /// </summary>
        private void UpdateListBox()
        {
            StudentsListBox.Items.Clear();
            if (_students.Count > 1)
                _students.Sort();
            foreach (var student in _students) StudentsListBox.Items.Add(student);
            if (_currentStudent != null)
                StudentsListBox.SelectedItem = _currentStudent;
        }

        /// <summary>
        ///     Удаляет выбраного студента, освобождает значение его ID и очищает информацию в правом поле.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveStudentButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Вы уверены, что хотите удалить студента {_currentStudent.Id}?", "Внимание",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _students.Remove(_currentStudent);
                _currentStudent.RemoveMe();
                _currentStudent = null;
                UpdateListBox();
                ClearParamsBoxes();
                isDataSaved = false;
            }

        }

        /// <summary>
        ///     Заполняет правое поле информацией о выбранном студенте.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StudentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StudentsListBox.SelectedIndex != -1)
            {
                _currentStudent = (Student)StudentsListBox.SelectedItem;
                FillParamsBoxes();
                RemoveStudentButton.Enabled = true;
            }
            else
            {
                ClearParamsBoxes();
                _currentStudent = null;
            }
        }

        /// <summary>
        ///     Очищает правое поле.
        /// </summary>
        private void ClearParamsBoxes()
        {
            SelectedStudentGroupBox.Enabled = false;
            FullNameTextBox.Text = string.Empty;
            GroupTextBox.Text = string.Empty;
            IdTextBox.Text = string.Empty;
            FacultyComboBox.SelectedItem = null;
            EducationFormComboBox.SelectedItem = null;
        }

        /// <summary>
        ///     Заполняет правое поле информацией.
        /// </summary>
        private void FillParamsBoxes()
        {
            SelectedStudentGroupBox.Enabled = true;
            FullNameTextBox.Text = _currentStudent.FullName;
            GroupTextBox.Text = _currentStudent.Group;
            IdTextBox.Text = _currentStudent.Id.ToString();
            FacultyComboBox.Text = EnumParser.GetStringFaculty(_currentStudent.Faculty);
            EducationFormComboBox.Text = EnumParser.GetStringEducationForm(_currentStudent.EducationForm);
        }

        private void FacultyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentStudent != null)
            {
                _currentStudent.Faculty = EnumParser.GetEnumFaculty(FacultyComboBox.Text);
                UpdateListBox();
                isDataSaved = false;
            }
        }

        private void EducationFormComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentStudent != null)
            {
                _currentStudent.EducationForm = EnumParser.GetEnumEducationForm(EducationFormComboBox.Text);
                UpdateListBox();
                isDataSaved = false;
            }
        }

        private void GroupTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13 && GroupTextBox.Text != "")
            {
                _currentStudent.Group = GroupTextBox.Text;
                UpdateListBox();
                isDataSaved = false;
            }
        }

        private void FullNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == (char)13 && FullNameTextBox.Text != "")
            {
                _currentStudent.FullName = FullNameTextBox.Text;
                UpdateListBox();
                isDataSaved = false;
            }
        }

        /// <summary>
        ///     Записывает студентов в файл сохранения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            if (!IsDataFileExist())
                Directory.CreateDirectory(GetDataFilePath(true));

            using (var streamWriter = new StreamWriter(GetDataFilePath(), false))
            {
                streamWriter.Write(SerializeStudents());
            }

            isDataSaved = true;
        }
        private void SaveChangesButton_Click()
        {
            if (!IsDataFileExist())
                Directory.CreateDirectory(GetDataFilePath(true));

            using (var streamWriter = new StreamWriter(GetDataFilePath(), false))
            {
                streamWriter.Write(SerializeStudents());
            }

            isDataSaved = true;
        }

        /// <summary>
        ///     Сериализирует студентов в списке.
        /// </summary>
        /// <returns></returns>
        private string SerializeStudents()
        {
            var output = string.Empty;
            foreach (var student in _students) output += JsonSerializer.Serialize(student) + "\n";
            return output;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isDataSaved)
            {
                var dr = MessageBox.Show("Сохранить изменения?", "Внимание", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                    SaveChangesButton_Click();
                else if (dr == DialogResult.No)
                {
                    return;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}