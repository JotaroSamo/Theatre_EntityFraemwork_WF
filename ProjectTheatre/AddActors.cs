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
   
    
    public partial class AddActors : Form
    {
       readonly TheatreDbContext context = new TheatreDbContext();
        public AddActors(int d)
        {
            InitializeComponent();
            D = d;
        }
        public int D { get; set; }

        private void AddT_Click(object sender, EventArgs e)
        {
            if (Role.Text!=""&&FIO.Text!="")
            {
                Roli rl = new Roli();
                rl.TID = D;
                rl.Role = Role.Text;
                rl.FIO = FIO.Text;
                context.Rolies.Add(rl);
                context.SaveChanges();
            }
            else
            {
                MessageBox.Show("Введите все данные");
            }
           
        }
    }
}
