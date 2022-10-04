using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace ProjectTheatre
{
    public partial class ReginSeance : Form
    {
       readonly TheatreDbContext db = new TheatreDbContext();
        Register rg = new Register();
        Theatre th = new Theatre();
        public ReginSeance(int id)
        {
            InitializeComponent();
            
            ID = id;
        }
        public int ID { get; set; }

        private void ADDNumb_Load(object sender, EventArgs e)
        {
           Theatre th = db.Theatres.Find(ID);
           label1.Text = $"Amount place: {th.CountPlease}";
        }

        private void AddT_Click(object sender, EventArgs e)
        {
            Theatre th = db.Theatres.Find(ID);
            if (Convert.ToInt32(countplease.Text) > th.CountPlease)
            {
                MessageBox.Show("Not place");
            }
            else
            {
                th.CountPlease -= Convert.ToInt32(countplease.Text);
                rg.CountSelectPleas = Convert.ToInt32(countplease.Text);
                rg.Number = nomer.Text;
                rg.TID = ID;
                db.Registers.Add(rg);
                db.SaveChanges();

            }
        }
    }
}
