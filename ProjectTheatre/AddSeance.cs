using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTheatre
{
    public partial class AddSeance : Form
    {
        Theatre th;
       readonly TheatreDbContext context = new TheatreDbContext();

        public AddSeance()
        {
            InitializeComponent();
            D = true;
        }
        public AddSeance(bool d)
        {
            InitializeComponent();
            D = d;
        }
        public bool D { get; set; }
        private void AddT_Click(object sender, EventArgs e)
        {
            Programming programming = new Programming(NSeans.Text,DataSeans.Text);
            
            if (true==programming.Relase(programming.Check(),D))
            {
                    th = new Theatre();
                    th.NameTheatre = NSeans.Text;
                    th.Data = Convert.ToDateTime(DataSeans.Text);
                   
                    th.CountPlease = 40;
                    context.Theatres.Add(th);
                    context.SaveChanges();
                
            }


        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
