using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BazaPojazdow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (!db.Database.Exists())
            {
                PojazdDB p1 = new PojazdDB();
                p1.NrRej = "WH93405";
                p1.Typ = "osobowe";
                p1.Paliwo = "benzyna";
                p1.Moc = 120;
                p1.PojSilnika = 1.4;
                p1.Masa = 1200;
                p1.Spalanie = 11.2;
                p1.PojZb = 50;
                p1.CzyWynajety = true;
                p1.Wynajmy = new List<WynajemDB>();

                WynajemDB w1 = new WynajemDB();
                w1.OdDnia = new DateTime(2020, 9, 1);
                w1.DoDnia = new DateTime(2022, 8, 31);

                WynajemDB w2 = new WynajemDB();
                w2.OdDnia = new DateTime(2022, 9, 1);
                w2.DoDnia = new DateTime(2024, 8, 31);

                p1.Wynajmy.Add(w1);
                p1.Wynajmy.Add(w2);

                db.PojazdyDB.Add(p1);

                //============================

                PojazdDB p2 = new PojazdDB();
                p2.NrRej = "KR9HT53";
                p2.Typ = "osobowe";
                p2.Paliwo = "benzyna";
                p2.Moc = 70;
                p2.PojSilnika = 1.0;
                p2.Masa = 800;
                p2.Spalanie = 7.8;
                p2.PojZb = 40;
                p2.CzyWynajety = true;
                p2.Wynajmy = new List<WynajemDB>();

                WynajemDB w3 = new WynajemDB();
                w3.OdDnia = new DateTime(2018, 12, 10);
                w3.DoDnia = new DateTime(2019, 12, 11);

                WynajemDB w4 = new WynajemDB();
                w4.OdDnia = new DateTime(2020, 12, 10);
                w4.DoDnia = new DateTime(2022, 12, 11);

                p2.Wynajmy.Add(w3);
                p2.Wynajmy.Add(w4);

                db.PojazdyDB.Add(p2);

                db.SaveChanges();
            }
            
        }

        BazaPojazdowDB db = new BazaPojazdowDB();
        private void Form1_Load(object sender, EventArgs e)
        {
            pojazdDBBindingSource.DataSource = db.PojazdyDB.ToList();
        }

        private void status1_ActualStatusChanged(object sender, int e)
        {
            if (e == 2) { rent1.Rented = false; }
            else if (e == 0) { rent1.Rented = true; }
            else if (e == 1)
            {
                rent1.Ability = false;
            }
        }

        private void rent1_RentStatusChanged(object sender, bool e)
        {
            if (e) { status1.ActualStatus = 0; }
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Dodano pojazd!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PojazdDB p = new PojazdDB();
            //p.CarId = 3;
            p.NrRej = rejestracja1.RejestracjaTextboxValue;
            p.Typ = typ1.TypTextboxValue;
            p.Paliwo = paliwo1.PaliwoTextboxValue;
            p.Moc = double.Parse(moc.FloatDataTextboxValue);
            p.PojSilnika = double.Parse(pojemnoscSilnika.FloatDataTextboxValue);
            p.Masa = double.Parse(masa.FloatDataTextboxValue);
            p.Spalanie = double.Parse(spalanie.FloatDataTextboxValue);
            p.PojZb = double.Parse(pojemnoscZbiornika.FloatDataTextboxValue);
            p.CzyWynajety = rent1.Rented;
            p.Wynajmy = new List<WynajemDB>();

            if (p.CzyWynajety)
            {
                WynajemDB w = new WynajemDB();
                w.OdDnia = new DateTime(rent1.OdDnia.Year, rent1.OdDnia.Month, rent1.OdDnia.Day);
                w.DoDnia = new DateTime(rent1.DoDnia.Year, rent1.DoDnia.Month, rent1.DoDnia.Day);
                p.Wynajmy.Add(w);
            }


            db.PojazdyDB.Add(p);

            db.SaveChanges();

            pojazdDBBindingSource.DataSource = db.PojazdyDB.ToList();
        }
    }
}
