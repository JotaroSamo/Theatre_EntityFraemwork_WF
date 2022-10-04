using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectTheatre
{
    public class Theatre
    {
        
        public int Id { get; set; }
        public string NameTheatre { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Data { get; set; }
        //public int TimeH { get; set; }
        //public int TimeM { get; set; }
        public int CountPlease { get; set; }
        public virtual ICollection<Roli> Rolis { get; set; }
        public virtual ICollection<Register> Reg { get; set; }

    }
}
