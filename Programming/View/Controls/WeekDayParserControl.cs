using Programming.Model;
using System;
using System.Windows.Forms;

namespace Programming.View.Controls
{
    /// <summary>
    /// Пользовательский элемент кправления, описывающий взаимодействие с перечислением <see cref="WeekDay"/>.
    /// </summary>
    public partial class WeekDayParserControl : UserControl
    {
        public WeekDayParserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Проверяет, является ли введенное в TextBox значение, элементом перечисления <see cref="WeekDay"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ParseButton_Click(object sender, EventArgs e)
        {
            WeekDay weekDay;
            if (Enum.TryParse(TextBoxForParse.Text, out weekDay) &&
                Enum.IsDefined(typeof(WeekDay), TextBoxForParse.Text))
                labelForWeekdayInfo.Text = $"Это день недели ({weekDay} = {(int)weekDay})";
            else
                labelForWeekdayInfo.Text = "Нет такого дня недели";
        }

        /// <summary>
        /// Активирует кнопку, если в TextBox что-либо введено.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxForParse_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxForParse.Text != "")
                ParseButton.Enabled = true;
            else
                ParseButton.Enabled = false;
        }
    }
}
