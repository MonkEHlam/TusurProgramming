using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model;
using Rectangle = Programming.Model.Rectangle;

namespace Programming.View.Panels
{
    /// <summary>
    ///     Пользовательский элемент управления, описывающий взаимодействия множества Rectangles<see cref="Rectangle" />
    /// </summary>
    public partial class RectangleCollisionControl : UserControl
    {
        /// <summary>
        ///     Список панелей, описывающих прямоугольники из списка _rectangles <see cref="_rectangles" /> на холсте.
        /// </summary>
        private readonly List<Panel> _panels = new List<Panel>();

        /// <summary>
        ///     Список прямоугольников <see cref="Rectangle" />.
        /// </summary>
        private readonly List<Rectangle> _rectangles = new List<Rectangle>();

        /// <summary>
        ///     Выбранный в списке <see cref="RectanglesListBox" /> прямоугольник <see cref="Rectangle" />.
        /// </summary>
        private Rectangle _currentRectangle;

        public RectangleCollisionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Заполняет TextBox'ы данными о прмоугольнике, под выбранным индексом.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex == -1) return;
            _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
            RectangleHeightTextBox.Text = _currentRectangle.Height.ToString();
            RectangleWidthTextBox.Text = _currentRectangle.Width.ToString();
            RectangleXTextBox.Text = _currentRectangle.LeftUPoint.X.ToString();
            RectangleYTextBox.Text = _currentRectangle.LeftUPoint.Y.ToString();
            RectangleIdTextBox.Text = _currentRectangle.Id.ToString();
            RemoveRectangleButton.Enabled = true;
        }

        /// <summary>
        ///     Обрабатывает изменение значения и заменяет его в выбранном прямоугольнике <see cref="_currentRectangle" />.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectangleHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            RectangleHeightTextBox.BackColor = AppColor.NormalColor;
            if (_currentRectangle != null)
            {
                if (int.TryParse(RectangleHeightTextBox.Text, out var num))
                    try
                    {
                        if (_currentRectangle.Height + num < Canvas.Size.Height - 15)
                        {
                            _currentRectangle.Height = num;
                            _panels[_rectangles.IndexOf(_currentRectangle)].Height = num;
                            RectangleHeightErrorLabel.Text = "";
                            UpdateRectanglesListBox();
                        }
                        else
                        {
                            throw new ArgumentException("Can't fit in canvas");
                        }
                    }
                    catch (ArgumentException exc)
                    {
                        RectangleHeightTextBox.BackColor = AppColor.ErrorColor;
                        RectangleHeightErrorLabel.Text = exc.Message;
                    }
                else RectangleHeightTextBox.BackColor = AppColor.ErrorColor;
            }
        }

        /// <summary>
        ///     Обрабатывает изменение значения и заменяет его в выбранном прямоугольнике <see cref="_currentRectangle" />.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectangleWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            RectangleWidthTextBox.BackColor = AppColor.NormalColor;

            if (_currentRectangle != null)
            {
                if (int.TryParse(RectangleWidthTextBox.Text, out var num))
                    try
                    {
                        if (num > 0 && _currentRectangle.LeftUPoint.X + num < Canvas.Size.Width - 15)
                        {
                            _currentRectangle.Width = num;
                            _panels[_rectangles.IndexOf(_currentRectangle)].Width = num;
                            RectangleWidthErrorLabel.Text = "";
                            UpdateRectanglesListBox();
                        }
                        else
                        {
                            throw new ArgumentException("Can't fit in canvas");
                        }
                    }
                    catch (ArgumentException exc)
                    {
                        RectangleWidthTextBox.BackColor = AppColor.ErrorColor;
                        RectangleWidthErrorLabel.Text = exc.Message;
                    }
                else RectangleWidthTextBox.BackColor = AppColor.ErrorColor;
            }
        }

        /// <summary>
        ///     Обрабатывает изменение значения и заменяет его в выбранном прямоугольнике <see cref="_currentRectangle" />.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectangleXTextBox_TextChanged(object sender, EventArgs e)
        {
            RectangleXTextBox.BackColor = AppColor.NormalColor;
            if (_currentRectangle != null)
            {
                if (int.TryParse(RectangleXTextBox.Text, out var num))
                    try
                    {
                        if (num > 0 && _currentRectangle.Width + num < Canvas.Size.Width - 15)
                        {
                            _currentRectangle.LeftUPoint = new Point2D(num, _currentRectangle.LeftUPoint.Y);
                            UpdatePanelLocation(_panels[_rectangles.IndexOf(_currentRectangle)]);
                            RectangleXYErrorLabel.Text = "";
                            UpdateRectanglesListBox();
                        }
                        else
                        {
                            throw new ArgumentException("Can't fit in canvas");
                        }
                    }
                    catch (ArgumentException exc)
                    {
                        RectangleXTextBox.BackColor = AppColor.ErrorColor;
                        RectangleXYErrorLabel.Text = exc.Message;
                    }
                else RectangleXTextBox.BackColor = AppColor.ErrorColor;
            }
        }

        /// <summary>
        ///     Обрабатывает изменение значения и заменяет его в выбранном прямоугольнике <see cref="_currentRectangle" />.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectangleYTextBox_TextChanged(object sender, EventArgs e)
        {
            RectangleYTextBox.BackColor = AppColor.NormalColor;
            if (_currentRectangle != null)
            {
                if (int.TryParse(RectangleYTextBox.Text, out var num))
                    try
                    {
                        if (num > 0 && _currentRectangle.Height + num < Canvas.Size.Height - 15)
                        {
                            _currentRectangle.LeftUPoint = new Point2D(_currentRectangle.LeftUPoint.X, num);
                            UpdatePanelLocation(_panels[_rectangles.IndexOf(_currentRectangle)]);
                            RectangleXYErrorLabel.Text = "";
                            UpdateRectanglesListBox();
                        }
                        else
                        {
                            throw new ArgumentException("Can't fit in canvas");
                        }
                    }
                    catch (ArgumentException exc)
                    {
                        RectangleYTextBox.BackColor = AppColor.ErrorColor;
                        RectangleXYErrorLabel.Text = exc.Message;
                    }
                else RectangleYTextBox.BackColor = AppColor.ErrorColor;
            }
        }

        /// <summary>
        ///     Создает новый прямоугольник<see cref="Rectangle" />.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            RemoveRectangleButton.Enabled = false;
            var rectangle = RectangleFactory.Randomize(1, Canvas.Size.Width - 15, 1, Canvas.Size.Height - 15);
            _rectangles.Add(rectangle);
            CreateNewRectanglePanel(rectangle);
            RectanglesListBox.SelectedIndex = -1;
            UpdateRectanglesListBox();
            ClearRectanglesTextBoxes();
            FindCollisions();
        }

        /// <summary>
        ///     Обнавляет список прямоугльников на форме.
        /// </summary>
        private void UpdateRectanglesListBox()
        {
            var selectedIndex = RectanglesListBox.SelectedIndex;
            RectanglesListBox.Items.Clear();
            foreach (var rectangle in _rectangles)
            {
                var output =
                    $"{rectangle.Id}: X= {rectangle.LeftUPoint.X}, Y = {rectangle.LeftUPoint.Y}, W= {rectangle.Width}, H= {rectangle.Height}";
                RectanglesListBox.Items.Add(output);
            }

            RectanglesListBox.SelectedIndex = selectedIndex;
        }

        /// <summary>
        ///     Удаляет выбранный прямоугольник.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveRectangleButton_Click(object sender, EventArgs e)
        {
            Canvas.Controls.Remove(_panels[_rectangles.IndexOf(_currentRectangle)]);
            _panels.RemoveAt(_rectangles.IndexOf(_currentRectangle));
            _rectangles.Remove(_currentRectangle);
            RectanglesListBox.SelectedIndex = -1;
            UpdateRectanglesListBox();
            RemoveRectangleButton.Enabled = false;
            ClearRectanglesTextBoxes();
            FindCollisions();
        }

        /// <summary>
        ///     Создает панель, соответствующую прямоугольнику, на холсте.
        ///     Добавляет её в список панелей <see cref="_panels" />
        /// </summary>
        /// <param name="rect">Прямоуголник<see cref="Rectangle" />, на основе которого создается панель.</param>
        private void CreateNewRectanglePanel(Rectangle rect)
        {
            var panel = new Panel
            {
                Enabled = false,
                Height = rect.Height,
                Width = rect.Width,
                BackColor = AppColor.RectangleGreenColor
            };
            var x = 15 + rect.LeftUPoint.X;
            var y = 15 + rect.LeftUPoint.Y;
            panel.Location = new Point(x, y);
            _panels.Add(panel);
            Canvas.Controls.Add(panel);
        }

        /// <summary>
        ///     Очищает TextBox'ы.
        /// </summary>
        private void ClearRectanglesTextBoxes()
        {
            RectangleHeightTextBox.Text = "";
            RectangleHeightTextBox.BackColor = AppColor.NormalColor;
            RectangleIdTextBox.Text = "";
            RectangleWidthTextBox.Text = "";
            RectangleWidthTextBox.BackColor = AppColor.NormalColor;
            RectangleXTextBox.Text = "";
            RectangleXTextBox.BackColor = AppColor.NormalColor;
            RectangleYTextBox.Text = "";
            RectangleYTextBox.BackColor = AppColor.NormalColor;
        }

        /// <summary>
        ///     Изменяет положение панели из списка Panels<see cref="_panels" />, согласно координатам выбранного прямоугольника
        ///     <see cref="_currentRectangle" />.
        /// </summary>
        /// <param name="panel">Панель, расположение </param>
        private void UpdatePanelLocation(Panel panel)
        {
            panel.Location = new Point(15 + _currentRectangle.LeftUPoint.X,
                15 + _currentRectangle.LeftUPoint.Y);
            FindCollisions();
        }

        /// <summary>
        ///     Находит пересекающиеся панели в списке панелей <see cref="_panels" />.
        ///     Перекрашивает пересекающиеся панели в Красный цвет <see cref="AppColor.RectangleRedColor" />
        ///     Перекрашивает непересекающиеся панели в зеленый цвет <see cref="AppColor.RectangleGreenColor" />
        /// </summary>
        private void FindCollisions()
        {
            foreach (var panel in _panels) panel.BackColor = AppColor.RectangleGreenColor;
            for (var i = 0; i < _rectangles.Count - 1; i++)
            for (var j = i + 1; j < _rectangles.Count; j++)
                if (ColisionManager.IsColision(_rectangles[i], _rectangles[j]))
                {
                    _panels[i].BackColor = AppColor.RectangleRedColor;
                    _panels[j].BackColor = AppColor.RectangleRedColor;
                }
        }
    }
}