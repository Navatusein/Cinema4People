using Server.Models;
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
    public partial class FormMain : Form
    {
        List<CinemaRoom> rooms = null;

        public List<CinemaRoom> Rooms 
        {
            get { return rooms; } 
            set { rooms = value; } 
        }

        public FormMain()
        {
            InitializeComponent();
            rooms = new List<CinemaRoom>();
            lbRooms.DataSource = Rooms;
        }

        public FormMain(List<CinemaRoom> cinemaRooms)
        {
            InitializeComponent();
            Rooms = cinemaRooms;
            lbRooms.DataSource = cinemaRooms;
        }

        private void NewRoomSettingsTable_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            NewRoomSettingsTable.Rows[e.Row.Index].Cells["rowIndex"].Value = e.Row.Index + 1;
        }

        private void NewRoomSettingsTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if(!string.IsNullOrEmpty(tbRoomName.Text))
                btAdd.Enabled = true;
        }

        private void tbRoomName_TextChanged(object sender, EventArgs e)
        {
            if(NewRoomSettingsTable.Rows.Count > 1)
                btAdd.Enabled=true;
        }
    }
}
