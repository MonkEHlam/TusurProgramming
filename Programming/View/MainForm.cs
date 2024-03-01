using System;
using Programming.Model;
using System.Windows.Forms;

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

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxForIndex.Text = $"{(int)Enum.Parse(enumType, ValuesListBox.Text)}";
        }
    }
}
