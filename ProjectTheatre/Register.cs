using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTheatre
{
    public class Register
    {
        public int Id { get; set; }
        
        public string Number { get; set; }
        public int CountSelectPleas { get; set; }
        public int TID { get; set; }
        public virtual Theatre Theatres { get; set; }
    }
}
