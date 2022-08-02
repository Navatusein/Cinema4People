using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Client.Tabs
{
    public partial class TabFilter : Form
    {
        List<MoviesDB> movies;
        List<MoviesDB> filteredMovies;
        List<Seans> seanses;

        public List<MoviesDB> Filtred
        {
            get { return filteredMovies; }
        }


        public TabFilter(List<MoviesDB> movies, List<Seans> seanses)
        {
            InitializeComponent();

            dateTimePickerMovieF.MinDate = DateTime.Today;
            this.movies = movies;
            this.seanses = seanses;
            filteredMovies = new List<MoviesDB>();

            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            this.TopMost = true;
        }

        List<string> GetGanres()
        {
            //Supposed to get from db
            List<string> genres = new List<string>();
            genres.AddRange(new string[] 
            {
              "Action",
              "Comedy",
              "Thriller",
              "Horror",
              "Documentary",
              "Detective",
              "Criminal",
              ""
            });

            return genres;
        }


        private void btTitleSort_Click(object sender, EventArgs e)
        {
            filteredMovies = movies.OrderBy(o => o.Title).ToList();

            if (rbDesc.Checked)
                filteredMovies.Reverse();

            this.Close();
        }

        private void btTimeSort_Click(object sender, EventArgs e)
        {
            filteredMovies = movies.OrderBy(o => o.Duration).ToList();

            if (rbDesc.Checked)
                filteredMovies.Reverse();

            this.Close();
        }

        private void btRatingSort_Click(object sender, EventArgs e)
        {
            filteredMovies = movies.OrderBy(o => o.Rating).ToList();

            if (rbDesc.Checked)
                filteredMovies.Reverse();

            this.Close();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            filteredMovies.Clear();

            this.Close();
        }

        private void tbMovieTitleF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (filteredMovies.Count.Equals(0))
                {
                    foreach (var m in movies)
                    {
                        if (tbMovieTitleF.Text.Equals(m.Title) || tbMovieTitleF.Text.Contains(m.Title))
                        {
                            filteredMovies.Add(m);
                        }
                    }
                }
                else
                {
                    foreach (var filteredM in filteredMovies)
                    {
                        if (!tbMovieTitleF.Text.Equals(filteredM.Title) || !tbMovieTitleF.Text.Contains(filteredM.Title))
                        {
                            filteredMovies.Remove(filteredM);
                        }
                    }
                }
            }
            this.Close();
        }

        private void dateTimePickerMovieF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (filteredMovies.Count.Equals(0))
                {
                    foreach (var m in seanses)
                    {
                        if (m.dateTimes.Contains(dateTimePickerMovieF.Value))
                        {
                            filteredMovies.Add(m.movie);
                        }
                    }
                }
                else
                {
                    foreach (var m in seanses)
                    {
                        if (!m.dateTimes.Contains(dateTimePickerMovieF.Value))
                        {
                            filteredMovies.Remove(m.movie);
                        }
                    }
                }
            }
            this.Close();
        }

        private void cBMovieGenres_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string genre = cBMovieGenres.SelectedItem.ToString();

                if (filteredMovies.Count.Equals(0))
                {
                    foreach (var m in movies)
                    {
                        if (genre.Equals(m.Genres))
                        {
                            filteredMovies.Add(m);
                        }
                    }
                }
                else
                {
                    foreach (var filteredM in filteredMovies)
                    {
                        if (!genre.Equals(filteredM.Genres))
                        {
                            filteredMovies.Remove(filteredM);
                        }
                    }
                }
            }
            this.Close();
        }
    }

    public class MoviesDB
    {
        public int Id { get; set; }
        public string Title { set; get; }
        public string TrailerLink { set; get; }
        public string Description { set; get; }//could add actors as extra variable/field
        public int Duration { set; get; }
        public double Rating { set; get; }
        public byte[] Poster { set; get; }
        public string Genres { set; get; }
        public DateTime time { get; set; }
    }
}
