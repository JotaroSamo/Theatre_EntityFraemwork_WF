using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;
using System.Globalization;

namespace ProjectTheatre
{
   public class Programming:TheatreDbContext
    {
        public Programming(string Nsean, string DataSen)
        {
            Nseans = Nsean;
            DataSens = DataSen;
        }
        public string Nseans { get; set; }
        public string DataSens { get; set; }


        public bool Check()

        {
            
            try
            {
                DateTime DataSenss = Convert.ToDateTime(DataSens);

            }
            catch (Exception)
            {

                MessageBox.Show($"Error Data{ MessageBoxIcon.Error}");
                return false;
            }
            return true;
        }
        public bool Relase(bool st, bool doubl)
        {
            if (true==doubl)
            {
                using (TheatreDbContext db = new TheatreDbContext())
                {

                    var status = db.Theatres.ToList();
                    if (st == true)
                    {
                        if (status.Count > 0)
                        {

                            foreach (var item in status)
                            {

                                if (Nseans == item.NameTheatre && Convert.ToDateTime(DataSens) == item.Data)
                                {

                                    MessageBox.Show("Сеанс уже существует");
                                    return false;
                                }

                            }
                            return true;

                        }
                        else
                        {
                            return true;
                        }
                    }
                    else
                    {
                        return false;

                    }


                }

            }
            else
            {
                return false;

            }



        }
 
    }
}
    

