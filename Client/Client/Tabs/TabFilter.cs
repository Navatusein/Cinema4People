using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Tabs
{
    
    public partial class TabFilter: Form
    {
        List<MoviesDB> movies = new List<MoviesDB>();
        List<MoviesDB> filteredMovies = new List<MoviesDB>();

        public TabFilter(ref List<MoviesDB> moviesA)
        {
            InitializeComponent();

            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            this.TopMost = true;

            movies = moviesA;
            
        }

        private void cBMovieGenres_SelectedIndexChanged(object sender, EventArgs e)
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

        private void tbMovieTitleF_TextChanged(object sender, EventArgs e)
        {

            if (filteredMovies.Count.Equals(0))
            {
                foreach (var m in movies)
                {
                
                    if(tbMovieTitleF.Text.Equals(m.Title))
                    {
                        filteredMovies.Add(m);
                    }
                }
                
            }
            else
            {
                foreach (var filteredM in filteredMovies)
                {
                    if (!tbMovieTitleF.Text.Equals(filteredM.Title))
                    {
                        filteredMovies.Remove(filteredM);
                    }
                }
            }

        }

        private void dateTimePickerMovieF_ValueChanged(object sender, EventArgs e)
        {
            
            if (filteredMovies.Count.Equals(0))
            {
                foreach (var m in movies)
                {
                    if (dateTimePickerMovieF.Equals(m.time))
                    {
                        filteredMovies.Add(m);
                    }
                }
            }
            else
            {
                foreach(var filteredM in filteredMovies)
                {
                    if(!dateTimePickerMovieF.Equals(filteredM.time))
                    {
                        filteredMovies.Remove(filteredM);
                    }
                }
            }

        }

        private void btTitleSort_Click(object sender, EventArgs e)
        {

        }

        private void btTimeSort_Click(object sender, EventArgs e)
        {

        }

        private void btRatingSort_Click(object sender, EventArgs e)
        {

        }

        private void btReset_Click(object sender, EventArgs e)
        {
            filteredMovies.Clear();
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
