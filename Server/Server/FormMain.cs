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
        List<CinemaRoom> rooms;
        int counter = 0;
        public FormMain()
        {
            InitializeComponent();
            btAdd.Enabled = false;
            lbRooms.DataSource = rooms;
            NewRoomSettingsTable.AllowUserToAddRows = true;
            NewRoomSettingsTable.DefaultValuesNeeded += NewRoomSettingsTable_DefaultValuesNeeded1;
        }

        private void NewRoomSettingsTable_DefaultValuesNeeded1(object sender, DataGridViewRowEventArgs e)
        {
            NewRoomSettingsTable.Rows[e.Row.Index].Cells["rowIndex"].Value = e.Row.Index + 1;
        }
    }
}
