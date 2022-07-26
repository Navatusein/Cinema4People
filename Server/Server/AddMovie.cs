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
        public AddMovie()
        {
            InitializeComponent();
            actors = new List<Actor>();
        }

        private void btAddMovie_Click(object sender, EventArgs e)
        {

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
