using Programming.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Controls
{
    /// <summary>
    /// Пользовательский элемент управления, описывающий перечисления в ListBox'ах.
    /// </summary>
    public partial class EnumerationControl : UserControl
    {
        /// <summary>
        /// Переменная, для хранения выбранного типа перечисления.
        /// </summary>
        private Type _enumType;
        public EnumerationControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Задает значение <see cref="_enumType"/> согласного выбранному пункту в ListBox'е.
        /// Заполняет <see cref="ValuesListBox"/> значениями нужного перечисления.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="ArgumentException"></exception>
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            switch (EnumsListBox.Text)
            {
                case "Colors":
                    _enumType = typeof(Colors);
                    break;
                case "Seasons":
                    _enumType = typeof(Seasons);
                    break;
                case "SmartphoneMakers":
                    _enumType = typeof(SmartphoneMakers);
                    break;
                case "Genre":
                    _enumType = typeof(Genre);
                    break;
                case "FormsOfEducation":
                    _enumType = typeof(FormsOfEducation);
                    break;
                case "WeekDay":
                    _enumType = typeof(WeekDay);
                    break;
                default:
                    throw new ArgumentException();
            }

            ValuesListBox.Items.AddRange(Enum.GetNames(_enumType));
        }

        /// <summary>
        /// Выводит в TextBox число, соответствующее выбранному значению перечисления.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBoxForIndex.Text = $"{(int)Enum.Parse(_enumType, ValuesListBox.Text)}";
        }
    }
}
