using System;
using System.Windows.Forms;
using Programming.Model;

namespace Programming.View.Controls
{
    /// <summary>
    ///     Пользовательский элемент кправления, описывающий взаимодействие с перечислением <see cref="Seasons" />.
    /// </summary>
    public partial class SeasonHandlerControl : UserControl
    {
        public SeasonHandlerControl()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Обрабатывает выбранное значение ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    BackColor = AppColor.SpringColor;
                    break;
                case "Fall":
                    BackColor = AppColor.FallColor;
                    break;
                default:
                    MessageBox.Show("Error");
                    break;
            }
        }

        /// <summary>
        ///     Заполняет ComboBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SeasonHandlerControl_Load(object sender, EventArgs e)
        {
            ComboBoxForSeasons.Items.AddRange(Enum.GetNames(typeof(Seasons)));
        }
    }
}