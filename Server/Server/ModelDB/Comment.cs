using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.ModelDB
{
    internal class Comment
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public string Text { get; set; }

        public virtual MovieDb Movies { get; set; }
    }
}
