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
    public partial class Admins : Form
    {
       readonly TheatreDbContext db;
        public Admins()
        {
            InitializeComponent();
            db = new TheatreDbContext();
            db.Theatres.Load();

            TableT.DataSource = db.Theatres.Local.ToBindingList();
        }

        private void Admin(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddSeance open = new AddSeance();
            DialogResult result = open.ShowDialog();
            if (result == DialogResult.Cancel)
                return;
            db.Theatres.Load();
            TableT.DataSource = db.Theatres.Local.ToBindingList();

            TableT.Refresh();
        }

        private void Redact_Click(object sender, EventArgs e)
        {
            Work(1);
            MessageBox.Show("Объект обновлен");
            db.Theatres.Load();
            TableT.DataSource = db.Theatres.Local.ToBindingList();

            TableT.Refresh();



        }

        private void TableT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Remove_Click(object sender, EventArgs e)
        {

            Work(2);
            db.Theatres.Load();

            TableT.DataSource = db.Theatres.Local.ToBindingList();
            TableT.Refresh();

            
        }

        private void Addr(object sender, EventArgs e)
        {
            Work(3);
        }

        private void Search(object sender, EventArgs e)
        {
          Work(4);
            db.Theatres.Load();

            TableT.DataSource = db.Theatres.Local.ToBindingList();
            TableR.Refresh();
      
        }
        private void RedactR_Click(object sender, EventArgs e)
        {
            Work(5);
            db.Theatres.Load();

            TableT.DataSource = db.Theatres.Local.ToBindingList();
            TableR.Refresh();
        }

        private void RemoveR_Click(object sender, EventArgs e)
        {
            Work(6);

        }
        private void SerachReg(object sender, EventArgs e)
        {
            Work(7);
            db.Theatres.Load();

            TableT.DataSource = db.Theatres.Local.ToBindingList();
            TableNumber.Refresh();
        }

        private void RemoveReg_Click(object sender, EventArgs e)
        {
            Work(8);
            db.Theatres.Load();

            TableT.DataSource = db.Theatres.Local.ToBindingList();
            TableNumber.Refresh();
        }
        public void Work(byte q)
        {
            if (TableT.SelectedRows.Count > 0)
            {
                int index = TableT.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(TableT[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;
                Theatre th = db.Theatres.Find(id);
                Register rg = new Register();
                
                switch (q)
                {
                    case 1://Redact
                        AddSeance add = new AddSeance(false);
                        add.NSeans.Text = th.NameTheatre;
                        add.DataSeans.Text = Convert.ToString(th.Data);

                        DialogResult result = add.ShowDialog();

                        if (result == DialogResult.Cancel)
                            return;

                        th.CountPlease = th.CountPlease;

                        th.NameTheatre = add.NSeans.Text;
                        th.Data = Convert.ToDateTime(add.DataSeans.Text);
                        db.SaveChanges();

                        break;
                    case 2://Remove
                        
                        db.Theatres.Remove(th);
                        db.SaveChanges();
                        Roli rl = db.Rolies
                            .Where(o => o.Theatres.Id == id)
                            .FirstOrDefault();
                        try
                        {
                            db.Rolies.Remove(rl);
                        }
                        catch (Exception)
                        {

                            
                        }
                        rg = db.Registers
                          .Where(o => o.Theatres.Id == id)
                          .FirstOrDefault();
                        try
                        {

                            db.Registers.Remove(rg);
                        }
                        catch (Exception)
                        {

                            
                        }
                       
                       
                        db.SaveChanges();

                        MessageBox.Show("Объект удален");
                        break;
                    case 3://addR
                        AddActors addR = new AddActors(th.Id);
                       result = addR.ShowDialog();

                        if (result == DialogResult.Cancel)
                            return;
                        break;
                    case 4://serach addr
                       var rld = db.Rolies.Where(n=>n.TID==id).ToList();
                        TableR.Rows.Clear();
                        foreach (var item in rld)
                        {
                                TableR.Rows.Add(item.Id,item.FIO, item.Role);
                        }
                        break;
                    case 5://redact roli
                        rl = db.Rolies.Find(ReA(true));
                        addR = new AddActors(id);
                        
                        addR.FIO.Text = rl.FIO;
                        addR.Role.Text = rl.Role;
                        result = addR.ShowDialog();

                        if (result == DialogResult.Cancel)
                            return;
                        rl.FIO = addR.FIO.Text;
                        rl.Role = addR.Role.Text;
                        db.SaveChanges();
                        rld = db.Rolies.Where(n => n.TID == id).ToList();
                        TableR.Rows.Clear();
                        foreach (var item in rld)
                        {
                            TableR.Rows.Add(item.Id, item.FIO, item.Role);
                        }
                        break;
                    case 6:// remove roli
                        rl = db.Rolies.Find(ReA(true));
                        db.Rolies.Remove(rl);
                        db.SaveChanges();
                        rld = db.Rolies.Where(n => n.TID == id).ToList();
                        TableR.Rows.Clear();
                        foreach (var item in rld)
                        {
                            TableR.Rows.Add(item.Id, item.FIO, item.Role);
                        }
                        break;
                    case 7: //search numb
                        var sn = db.Registers.Where(n=>n.TID==id).ToList();
                        TableNumber.Rows.Clear();
                        foreach (var item in sn)
                        {
                                TableNumber.Rows.Add(item.Id, item.Number, item.CountSelectPleas);
                        }
                        break;
                    case 8:// remove numb
                        rg = db.Registers.Find(ReA(false));
                        th = db.Theatres.Where(n => n.Id == rg.TID).FirstOrDefault();
                        th.CountPlease += rg.CountSelectPleas;
                        db.Registers.Remove(rg);
                        db.SaveChanges();
                       var rn = db.Registers.Where(n => n.TID == id).ToList();
                        TableNumber.Rows.Clear();
                        foreach (var item in rn)
                        {
                            TableNumber.Rows.Add(item.Id, item.Number, item.CountSelectPleas);
                        }
                        break;
                        

                }
            }
        }
        public int ReA(bool d)
        {

            int index=0;
            bool converted = false ;
            int id = 0;
            switch (d)
            {
                case true:
                    index = TableR.SelectedRows[0].Index;
                    converted = Int32.TryParse(TableR[0, index].Value.ToString(), out id);
                    break;
                case false:
                    index = TableNumber.SelectedRows[0].Index;
                    converted = Int32.TryParse(TableNumber[0, index].Value.ToString(), out id);
                    break;
            }
            if (converted == false)
                return 0;
            else return id;
        }

        private void TableT_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            db.Theatres.Load();

            TableT.DataSource = db.Theatres.Local.ToBindingList();
            TableT.Refresh();
        }

        private void TableR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            db.Theatres.Load();

            TableT.DataSource = db.Theatres.Local.ToBindingList();
            TableR.Refresh();
        }

        private void TableNumber_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            db.Theatres.Load();

            TableT.DataSource = db.Theatres.Local.ToBindingList();
            TableNumber.Refresh();
        }
    }
}
