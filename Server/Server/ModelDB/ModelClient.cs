using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.CinemaRoom.ModelDb
{
    public MovieClient()
    {
        MoviesToHallSizes = new HashSet<MoviesToHallSizeDb>();
        SaleSizes = new HashSet<SaleSize>();
    }

    public int Id { get; set; }
    public string Movies { get; set; }
    public string SaleSize { get; set; }
    public string TicketNameFilm { get; set; }
    public byte[] PosterMovie { get; set; }
    public virtual ICollection<MoviesToHallSizeDb> MoviesToHallSizes { get; set; }
    public virtual ICollection<SaleSize> SaleSizes { get; set; }
    public string MovieClient { get; set; }
    public int FilmId { get; set; }
}