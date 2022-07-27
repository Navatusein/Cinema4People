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
    public partial class Form2 : Form
    {
        List<CinemaRoom> rooms = null;
        
        public List<CinemaRoom> Rooms 
        {
            get { return rooms; } 
            set { rooms = value; } 
        }

        

        public Form2()
        {
            InitializeComponent();
            rooms = new List<CinemaRoom>();
            lbRooms.DataSource = Rooms;
            
        }

        public Form2(List<CinemaRoom> cinemaRooms)
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

        private void btAdd_Click(object sender, EventArgs e)
        {
            //Add all data in DB
            int[,] size = new int[NewRoomSettingsTable.Rows.Count - 1,2];
            string[] types = new string[NewRoomSettingsTable.Rows.Count - 1];
            for(int i = 0; i < NewRoomSettingsTable.Rows.Count - 1; i++)
            {
                size[i,0] = Convert.ToInt32(NewRoomSettingsTable.Rows[i].Cells["colAmount"].Value);
                size[i,1] = Convert.ToInt32(NewRoomSettingsTable.Rows[i].Cells["tbPrice"].Value);
            }
            for (int i = 0; i < types.Length; i++)
            {
                types[i] = (string)NewRoomSettingsTable.Rows[i].Cells["typeofSeat"].Value;
            }
            CinemaRoom room = new CinemaRoom(size, tbRoomName.Text, types);
            rooms.Add(room);
            lbRooms.DataSource = null;
            lbRooms.Items.Add(room.name);
            NewRoomSettingsTable.Rows.Clear();
        }
    }
}
