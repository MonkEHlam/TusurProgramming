using System;
using Programming.Model;
using System.Windows.Forms;
using System.Diagnostics.Eventing.Reader;
using System.CodeDom;

namespace Programming
{
    public partial class MainForm : Form
    {
        Type enumType; 
        public MainForm()
        {
            InitializeComponent();
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            switch (EnumsListBox.Text)
            {
                case "Colors":
                    enumType = typeof(Colors);
                    break;
                case "Seasons":
                    enumType = typeof(Seasons);
                    break;
                case "SmartphoneMakers":
                    enumType = typeof(SmartphoneMakers);
                    break;
                case "Genre":
                    enumType = typeof(Genre);
                    break;
                case "FormsOfEducation":
                    enumType = typeof(FormsOfEducation);
                    break;
                case "WeekDay":
                    enumType = typeof(WeekDay);
                    break;
                default:
                    throw new ArgumentException();
            }
            
            ValuesListBox.Items.AddRange(Enum.GetNames(enumType));
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxForIndex.Text = $"{(int)Enum.Parse(enumType, ValuesListBox.Text)}";
        }

        private void TextBoxForParse_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxForParse.Text != "")
                ParseButton.Enabled = true;
            else
                ParseButton.Enabled = false;
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            WeekDay weekDay;
            if (Enum.TryParse(TextBoxForParse.Text, out weekDay) && Enum.IsDefined(typeof(WeekDay), TextBoxForParse.Text))
                labelForWeekdayInfo.Text = $"Это день недели ({weekDay} = {(int)weekDay})";
            else
                labelForWeekdayInfo.Text = "Нет такого дня недели";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ComboBoxForSeasons.Items.AddRange(Enum.GetNames(typeof(Seasons)));
            ComboBoxForSeasons.SelectedText = $"{ComboBoxForSeasons.Items[0]}";
        }

        private void SeasonsGoButton_Click(object sender, EventArgs e)
        {
            switch (ComboBoxForSeasons.Text)
            {
                case "Winter":
                    MessageBox.Show("Бррр! Холодно!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Summer":
                    MessageBox.Show("Ура! Солнце!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Spring":
                    EnumsPage.BackColor = System.Drawing.ColorTranslator.FromHtml("#559c45");
                    break;
                case "Fall":
                    EnumsPage.BackColor = System.Drawing.ColorTranslator.FromHtml("#e29c45");
                    break;
                default:
                    MessageBox.Show("Error");
                    break;
            }
        }
    }
}
