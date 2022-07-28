using Server.ModelDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class AddMovie : Form
    {
        Bitmap poster = null;
        Bitmap actorPhoto = null;
        List<Actor> actors = null;
        CinemaDbContext cinemaDB = null;
        public AddMovie()
        {
            InitializeComponent();
            actors = new List<Actor>();
            cinemaDB = new CinemaDbContext();
            cbDelActors.DataSource = cinemaDB.Actors.ToList();
            CbActors.DataSource = cinemaDB.Actors.ToList();
            CbMovie.DataSource = cinemaDB.Movies.ToList();
        }

        private void btAddMovie_Click(object sender, EventArgs e)
        {
            MovieDb movie = new MovieDb
            { 
            Title = tbTitle.Text,
            TrailerLink = tbTrailerLink.Text,
            Description = tbDescription.Text,
            Duration = Convert.ToInt32(tbDuration.Text),
            Genres = tbGenre.Text,
            Poster = ImageToByte(poster),
            Rating = 0
            };
            cinemaDB.Movies.Add(movie);
            cinemaDB.SaveChanges();
            CbMovie.DataSource = cinemaDB.Movies.ToList();
            this.DialogResult = DialogResult.OK;

        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofd1.ShowDialog() == DialogResult.OK)
                {
                    poster = new Bitmap(ofd1.FileName);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private void btSelectActorPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofd1.ShowDialog() == DialogResult.OK)
                {
                    actorPhoto = new Bitmap(ofd1.FileName);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private void btAddActor_Click(object sender, EventArgs e)
        {
            if (!(tbActorFirstName.Text.Length > 3 && tbActorLastName.Text.Length > 3 && actorPhoto != null)) return;
            actors.Add(new Actor {ActorName = tbActorFirstName.Text, ActorRole = tbActorLastName.Text, ActorPhoto = actorPhoto});
            //cbActors.Items.Add(tbActorName.Text+"|"+ tbActorRole.Text);
            ActorDb actor = new ActorDb
            {
                ActorFirstName = tbActorFirstName.Text, ActorLastName = tbActorLastName.Text, ActorPhoto=ImageToByte(actorPhoto)
            };

            cinemaDB.Actors.Add(actor);
            cinemaDB.SaveChanges();
            CbActors.DataSource = cinemaDB.Actors.ToList();
            cbDelActors.DataSource = cinemaDB.Actors.ToList();
            this.DialogResult = DialogResult.OK;
        }
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
    

        private void btDeleteActor_Click(object sender, EventArgs e)
        {

            string connectionString = "Server=178.151.124.250,21062; Database=Cinema4People; User Id=Cinema4PeopleUser; Password=sqQEPTC8e9wr; Trusted_Connection=false;";
            string sqlExpression = String.Format("DELETE FROM [ActorDbs] WHERE id='{0}'", Convert.ToInt32(CbActors.Text.Substring(0, 1)));
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
            }
            CbActors.DataSource = cinemaDB.Actors.ToList();
            cbDelActors.DataSource = cinemaDB.Actors.ToList();
        }

        private void btActorToMovie_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CbActors.Text) || string.IsNullOrEmpty(CbMovie.Text))
                return;

                ActorToMovieDb actorToMovieDb = new ActorToMovieDb
            {
                ActorsId = Convert.ToInt32(CbActors.Text.Substring(0, 1)),
                MoviesId = Convert.ToInt32(CbMovie.Text.Substring(0, 1))
            };
            cinemaDB.ActorsToMovies.Add(actorToMovieDb);
            cinemaDB.SaveChanges();
        }
    }
}
