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
    public partial class Protected : Form
    {
        readonly TheatreDbContext db = new TheatreDbContext();
        public Protected()
        {
            InitializeComponent();
        }

        private void CheckP_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var check = db.passwords.ToList();
            bool t = true;
            foreach (var item in check)
            {
                if (UserB.Text==item.user&&PasswordB.Text==item.password)
                {
                    
                    Admins open = new Admins();
                    this.Hide();
                    open.Show();
                    t = false;
                    break;
                }
            }
            if (t == true)
            {
                MessageBox.Show("Not sure Password or User");
            }
            
        }
    }
}
