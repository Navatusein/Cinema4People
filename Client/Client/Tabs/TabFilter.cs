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
    }
    public partial class TabFilter: Form
    {
        List<MoviesDB> movies = new List<MoviesDB>();
        List<MoviesDB> sortedMovies = new List<MoviesDB>();

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
            foreach (var m in movies)
            {
                if (sortedMovies.Count.Equals(0))
                {
                    if (m.Genres.Equals(genre))
                    {
                        sortedMovies.Add(m);
                    }
                }
            }
        }

        private void tbMovieTitleF_TextChanged(object sender, EventArgs e)
        {
            foreach(var m in movies)
            {
                if(sortedMovies.Count.Equals(0))
                {
                    if(tbMovieTitleF.Text.Equals(m.Title))//when we would know class, we should rewrite it
                                    {
                                        sortedMovies.Add(m);
                                    }
                }
                
            }
        }

        private void dateTimePickerMovieF_ValueChanged(object sender, EventArgs e)
        {

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
    }
}
