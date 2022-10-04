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
    public partial class ForUser : Form
    {
        readonly TheatreDbContext db = new TheatreDbContext();
        public ForUser()
        {
            InitializeComponent();
            
            db.Theatres.Load();

            TableT.DataSource = db.Theatres.Local.ToBindingList();
        }

        private void SrarchReg(object sender, EventArgs e)
        {
            Work(true);
        }
        private void ADDRGE(object sender, EventArgs e)
        {
            Work(false);
          
        }
        public void Work(bool q)
        {
            if (TableT.SelectedRows.Count > 0)
            {
                int index = TableT.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(TableT[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;
                Register rg = new Register();
                switch (q)
                {
                    case true:
                        var rld = db.Rolies.ToList();
                        TableR.Rows.Clear();
                        foreach (var item in rld)
                        {
                            if (item.TID == id)
                            {
                                TableR.Rows.Add(item.Id, item.FIO, item.Role);
                            }
                        }
                        break;
                    case false:
                        ReginSeance numb = new ReginSeance(id);
                        DialogResult result = numb.ShowDialog();
                        if (result == DialogResult.Cancel)
                            return;
                        
                        break;
                }
            }
        }
    }
}
