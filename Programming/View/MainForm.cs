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

        private Rectangle[] _rectangles;
        private Rectangle _currentRectangle;

        private Movie[] _movies;
        private Movie _currentMovie;
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

            var rand = new Random();
            _rectangles = new Rectangle[]
            { 
                new Rectangle(rand.Next(1, 100), rand.Next(1, 100), "", rand.Next(-50, 50), rand.Next(-50, 50)),
                new Rectangle(rand.Next(1, 100), rand.Next(1, 100), "", rand.Next(-50, 50), rand.Next(-50, 50)),
                new Rectangle(rand.Next(1, 100), rand.Next(1, 100), "", rand.Next(-50, 50), rand.Next(-50, 50)),
                new Rectangle(rand.Next(1, 100), rand.Next(1, 100), "", rand.Next(-50, 50), rand.Next(-50, 50)),
                new Rectangle(rand.Next(1, 100), rand.Next(1, 100), "", rand.Next(-50, 50), rand.Next(-50, 50)) 
            };
            
            for (int i = 0 ; i < _rectangles.Length; i++)
            {
                RectanglesListBox.Items.Add($"Rectangle {i + 1}");
            }

            _movies = new Movie[]
            {
                new Movie("Shoushenk Redemption", 142, 1994, "Drama", 9.1),
                new Movie("Intouchables", 112, 2011, "Drama", 8.8),
                new Movie(),
                new Movie(),
                new Movie(),
            };
            
            for (int i = 0; i < _movies.Length; i++)
            {
                if (_movies[i].Name != "")
                    MoviesListBox.Items.Add($"{_movies[i].Name} {_movies[i].Year}");
                else
                    MoviesListBox.Items.Add($"Movie {i}");
            }
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

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
            RectangleLengthTextBox.Text = _currentRectangle.Length.ToString();
            RectangleWidthTextBox.Text = _currentRectangle.Width.ToString();
            RectangleColorTextBox.Text = _currentRectangle.Color;
            RectangleXTextBox.Text = _currentRectangle.Center.X.ToString();
            RectangleYTextBox.Text = _currentRectangle.Center.Y.ToString();
        }

        private void RectangleLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            RectangleLengthTextBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
            if (_currentRectangle != null)
            {
                double num;
                if (double.TryParse(RectangleLengthTextBox.Text, out num))
                {
                    try
                    {
                        _currentRectangle.Length = num;
                    }
                    catch (ArgumentException exc) 
                    {
                        RectangleLengthTextBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#F53D65");
                        RectangleLengthErrorLabel.Text = exc.Message;
                    }
                }
                else RectangleLengthTextBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#F53D65");
            }
        }

        private void RectangleWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            RectangleWidthTextBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");

            if (_currentRectangle != null)
            {
                double num;
                if (double.TryParse(RectangleWidthTextBox.Text, out num))
                {
                    try
                    {
                        _currentRectangle.Width = num;
                    }
                    catch (ArgumentException exc)
                    {
                        RectangleWidthTextBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#F53D65");
                        RectangleWidthErrorLabel.Text = exc.Message;
                    }
                }
                else RectangleWidthTextBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#F53D65");
            }
        }

        private void RectangleColorTextBox_TextChanged(object sender, EventArgs e)
        {
            RectangleColorTextBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
            if (_currentRectangle != null)
            {
                try
                {
                    _currentRectangle.Color = RectangleColorTextBox.Text;
                }
                catch (ArgumentException)
                {
                    RectangleColorTextBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#F53D65");
                }
            }
            else RectangleColorTextBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#F53D65");
        }

        private int FindRectangleWithMaxWidth()
        {
            double maxWidth = double.MinValue;
            int index = - 1;
            for(int i = 0; i < _rectangles.Length; i++) 
            {
                if (_rectangles[i].Width > maxWidth) {
                    maxWidth = _rectangles[i].Width;
                    index = i;
                }
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
            MovieNameTextBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
            if (_currentMovie != null )
            {
                try
                {
                    _currentMovie.Name = MovieNameTextBox.Text;
                }
                catch (ArgumentException)
                {
                   MovieNameTextBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#F53D65");
                }
            }
        }

        private void MovieGenreTextBox_TextChanged(object sender, EventArgs e)
        {
            MovieGenreTextBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
            if (_currentMovie != null)
            {
                try
                {
                    _currentMovie.Name = MovieGenreTextBox.Text;
                }
                catch (ArgumentException)
                {
                    MovieGenreTextBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#F53D65");
                }
            }
        }

        private void MovieDurationTextBox_TextChanged(object sender, EventArgs e)
        {
            MovieDurationTextBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");

            if (_currentMovie != null)
            {
                int num;
                if (int.TryParse(MovieDurationTextBox.Text, out num))
                {
                    try
                    {
                        _currentMovie.DurationInMinutes = num;
                    }
                    catch (ArgumentException)
                    {
                        MovieDurationTextBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#F53D65");
                    }
                }
                else MovieDurationTextBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#F53D65");
            }
        }

        private void MovieYearTextBox_TextChanged(object sender, EventArgs e)
        {
            MovieYearTextBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");

            if (_currentMovie != null)
            {
                int num;
                if (int.TryParse(MovieYearTextBox.Text, out num))
                {
                    try
                    {
                        _currentMovie.Year = num;
                    }
                    catch (ArgumentException)
                    {
                        MovieYearTextBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#F53D65");
                    }
                }
                else MovieYearTextBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#F53D65");
            }
        }

        private void MovieRateTextBox_TextChanged(object sender, EventArgs e)
        {
            MovieRateTextBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");

            if (_currentMovie != null)
            {
                double num;
                if (double.TryParse(MovieRateTextBox.Text, out num))
                {
                    try
                    {
                        _currentMovie.Rate = num;
                    }
                    catch (ArgumentException)
                    {
                        MovieRateTextBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#F53D65");
                    }
                }
                else MovieRateTextBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#F53D65");
            }
        }
    }
}
