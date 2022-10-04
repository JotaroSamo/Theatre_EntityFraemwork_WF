using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTheatre
{
    public class Roli
    {
        public int Id { get; set; }
        public string Role{ get; set; }
        public string FIO { get; set; }
        public int TID { get; set; }
     public virtual Theatre Theatres { get; set; }        
    }

        
    
}
