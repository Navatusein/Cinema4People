using Server.ModelDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            if (!(tbActorName.Text.Length > 3 && tbActorRole.Text.Length > 3 && actorPhoto != null)) return;
            actors.Add(new Actor {ActorName = tbActorName.Text, ActorRole = tbActorRole.Text, ActorPhoto = actorPhoto});
            cbActors.Items.Add(tbActorName.Text+"|"+ tbActorRole.Text);
            ActorDb actor = new ActorDb
            {
                ActorName = tbActorName.Text, ActorRole = tbActorRole.Text, ActorPhoto=ImageToByte(actorPhoto)
            };

            cinemaDB.Actors.Add(actor);
            cinemaDB.SaveChanges();

            this.DialogResult = DialogResult.OK;
        }
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
    

        private void btDeleteActor_Click(object sender, EventArgs e)
        {
            //if (cbActors.Items[cbActors.SelectedIndex] == null) return;
            //List<string> actors = new List<string>();
            //foreach (string actor in cbActors.Items[cbActors.SelectedIndex].ToString().Split('|'))
            //{
            //    actors.Add(actor);
            //}
            //cbActors.Items[cbActors.SelectedIndex].ToString().Split('|')[0]
            //actors.Where()
            //cbActors.Items.Remove(cbActors.SelectedIndex);
        }
    }
}
