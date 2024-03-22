using System;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model;
using Rectangle = Programming.Model.Rectangle;


namespace Programming
{
    public partial class MainForm : Form
    {
        private Movie _currentMovie;
        private Rectangle _currentRectangle;
        private Type _enumType;

        private Movie[] _movies;

        private Rectangle[] _rectangles;

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

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxForIndex.Text = $"{(int)Enum.Parse(_enumType, ValuesListBox.Text)}";
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
            if (Enum.TryParse(TextBoxForParse.Text, out weekDay) &&
                Enum.IsDefined(typeof(WeekDay), TextBoxForParse.Text))
                labelForWeekdayInfo.Text = $"Это день недели ({weekDay} = {(int)weekDay})";
            else
                labelForWeekdayInfo.Text = "Нет такого дня недели";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ComboBoxForSeasons.Items.AddRange(Enum.GetNames(typeof(Seasons)));
            ComboBoxForSeasons.SelectedText = $"{ComboBoxForSeasons.Items[0]}";

            var rand = new Random();
            _rectangles = new[]
            {
                new Rectangle(rand.Next(1, 100), rand.Next(1, 100), "", rand.Next(-50, 50), rand.Next(-50, 50)),
                new Rectangle(rand.Next(1, 100), rand.Next(1, 100), "", rand.Next(-50, 50), rand.Next(-50, 50)),
                new Rectangle(rand.Next(1, 100), rand.Next(1, 100), "", rand.Next(-50, 50), rand.Next(-50, 50)),
                new Rectangle(rand.Next(1, 100), rand.Next(1, 100), "", rand.Next(-50, 50), rand.Next(-50, 50)),
                new Rectangle(rand.Next(1, 100), rand.Next(1, 100), "", rand.Next(-50, 50), rand.Next(-50, 50))
            };

            foreach (var rectangle in _rectangles) RectanglesListBox.Items.Add($"Rectangle {rectangle.Id}");

            _movies = new[]
            {
                new Movie("Shoushenk Redemption", 142, 1994, "Drama", 9.1),
                new Movie("Intouchables", 112, 2011, "Drama", 8.8),
                new Movie(),
                new Movie(),
                new Movie()
            };

            for (var i = 0; i < _movies.Length; i++)
                if (_movies[i].Name != "")
                    MoviesListBox.Items.Add($"{_movies[i].Name} {_movies[i].Year}");
                else
                    MoviesListBox.Items.Add($"Movie {i}");
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
                    EnumsPage.BackColor = ColorTranslator.FromHtml("#559c45");
                    break;
                case "Fall":
                    EnumsPage.BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;
                default:
                    MessageBox.Show("Error");
                    break;
            }
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
            RectangleLengthTextBox.Text = _currentRectangle.Length.ToString();
            RectangleWidthTextBox.Text = _currentRectangle.Width.ToString();
            RectangleColorTextBox.Text = _currentRectangle.Color;
            RectangleXTextBox.Text = _currentRectangle.Center.X.ToString();
            RectangleYTextBox.Text = _currentRectangle.Center.Y.ToString();
            RectangleIdTextBox.Text = _currentRectangle.Id.ToString();
        }

        private void RectangleLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            RectangleLengthTextBox.BackColor = ColorTranslator.FromHtml("#ffffff");
            if (_currentRectangle != null)
            {
                double num;
                if (double.TryParse(RectangleLengthTextBox.Text, out num))
                    try
                    {
                        _currentRectangle.Length = num;
                    }
                    catch (ArgumentException exc)
                    {
                        RectangleLengthTextBox.BackColor = ColorTranslator.FromHtml("#F53D65");
                        RectangleLengthErrorLabel.Text = exc.Message;
                    }
                else RectangleLengthTextBox.BackColor = ColorTranslator.FromHtml("#F53D65");
            }
        }

        private void RectangleWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            RectangleWidthTextBox.BackColor = ColorTranslator.FromHtml("#ffffff");

            if (_currentRectangle != null)
            {
                double num;
                if (double.TryParse(RectangleWidthTextBox.Text, out num))
                    try
                    {
                        _currentRectangle.Width = num;
                    }
                    catch (ArgumentException exc)
                    {
                        RectangleWidthTextBox.BackColor = ColorTranslator.FromHtml("#F53D65");
                        RectangleWidthErrorLabel.Text = exc.Message;
                    }
                else RectangleWidthTextBox.BackColor = ColorTranslator.FromHtml("#F53D65");
            }
        }

        private void RectangleColorTextBox_TextChanged(object sender, EventArgs e)
        {
            RectangleColorTextBox.BackColor = ColorTranslator.FromHtml("#ffffff");
            if (_currentRectangle != null)
                try
                {
                    _currentRectangle.Color = RectangleColorTextBox.Text;
                }
                catch (ArgumentException)
                {
                    RectangleColorTextBox.BackColor = ColorTranslator.FromHtml("#F53D65");
                }
            else RectangleColorTextBox.BackColor = ColorTranslator.FromHtml("#F53D65");
        }

        private int FindRectangleWithMaxWidth()
        {
            var maxWidth = double.MinValue;
            var index = -1;
            for (var i = 0; i < _rectangles.Length; i++)
                if (_rectangles[i].Width > maxWidth)
                {
                    maxWidth = _rectangles[i].Width;
                    index = i;
                }

            return index;
        }

        private void FindRectangleBtn_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth();
        }

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentMovie = _movies[MoviesListBox.SelectedIndex];
            MovieNameTextBox.Text = _currentMovie.Name;
            MovieGenreTextBox.Text = _currentMovie.Genre;
            MovieDurationTextBox.Text = $"{_currentMovie.DurationInMinutes}";
            MovieRateTextBox.Text = _currentMovie.Rate.ToString();
            MovieYearTextBox.Text = _currentMovie.Year.ToString();
        }

        private void MovieNameTextBox_TextChanged(object sender, EventArgs e)
        {
            MovieNameTextBox.BackColor = ColorTranslator.FromHtml("#ffffff");
            if (_currentMovie != null)
                try
                {
                    _currentMovie.Name = MovieNameTextBox.Text;
                }
                catch (ArgumentException)
                {
                    MovieNameTextBox.BackColor = ColorTranslator.FromHtml("#F53D65");
                }
        }

        private void MovieGenreTextBox_TextChanged(object sender, EventArgs e)
        {
            MovieGenreTextBox.BackColor = ColorTranslator.FromHtml("#ffffff");
            if (_currentMovie != null)
                try
                {
                    _currentMovie.Name = MovieGenreTextBox.Text;
                }
                catch (ArgumentException)
                {
                    MovieGenreTextBox.BackColor = ColorTranslator.FromHtml("#F53D65");
                }
        }

        private void MovieDurationTextBox_TextChanged(object sender, EventArgs e)
        {
            MovieDurationTextBox.BackColor = ColorTranslator.FromHtml("#ffffff");

            if (_currentMovie != null)
            {
                int num;
                if (int.TryParse(MovieDurationTextBox.Text, out num))
                    try
                    {
                        _currentMovie.DurationInMinutes = num;
                    }
                    catch (ArgumentException)
                    {
                        MovieDurationTextBox.BackColor = ColorTranslator.FromHtml("#F53D65");
                    }
                else MovieDurationTextBox.BackColor = ColorTranslator.FromHtml("#F53D65");
            }
        }

        private void MovieYearTextBox_TextChanged(object sender, EventArgs e)
        {
            MovieYearTextBox.BackColor = ColorTranslator.FromHtml("#ffffff");

            if (_currentMovie != null)
            {
                int num;
                if (int.TryParse(MovieYearTextBox.Text, out num))
                    try
                    {
                        _currentMovie.Year = num;
                    }
                    catch (ArgumentException)
                    {
                        MovieYearTextBox.BackColor = ColorTranslator.FromHtml("#F53D65");
                    }
                else MovieYearTextBox.BackColor = ColorTranslator.FromHtml("#F53D65");
            }
        }

        private void MovieRateTextBox_TextChanged(object sender, EventArgs e)
        {
            MovieRateTextBox.BackColor = ColorTranslator.FromHtml("#ffffff");

            if (_currentMovie != null)
            {
                double num;
                if (double.TryParse(MovieRateTextBox.Text, out num))
                    try
                    {
                        _currentMovie.Rate = num;
                    }
                    catch (ArgumentException)
                    {
                        MovieRateTextBox.BackColor = ColorTranslator.FromHtml("#F53D65");
                    }
                else MovieRateTextBox.BackColor = ColorTranslator.FromHtml("#F53D65");
            }
        }
    }
}