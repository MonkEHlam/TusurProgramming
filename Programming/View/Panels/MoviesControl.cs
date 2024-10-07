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

namespace Programming.View.Panels
{
    public partial class MoviesControl : UserControl
    {
        private Movie _currentMovie;
        private Movie[] _movies;
        public MoviesControl()
        {
            InitializeComponent();
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
                if (double.TryParse(MovieRateTextBox.Text, out var num))
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

        private void MoviesControl_Load(object sender, EventArgs e)
        {
            var rand = new Random();

            _movies = new[]
            {
                new Movie("Shoushenk Redemption", 142, 1994, "Drama", 9.1),
                new Movie("Intouchables", 112, 2011, "Drama", 8.8),
                new Movie(),
                new Movie(),
                new Movie()
            };

            for (var i = 0; i < _movies.Length; i++)
                MoviesListBox.Items.Add(_movies[i].Name != "" ? $"{_movies[i].Name} {_movies[i].Year}" : $"Movie {i}");
        }
    }
}
