using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WypozyczalniaSamochodow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] lines = System.IO.File.ReadAllLines(@"Auta.txt");
            if (!db.Database.Exists())
            {
                List<string> elements;
                foreach (string item in lines)
                {
                    Auto a = new Auto();
                    elements = item.Split(',').ToList();
                    a.Name = elements[0];
                    a.Segment = elements[1];
                    a.PricePerDay = int.Parse(elements[2]);
                    a.NumberOfPeople = int.Parse(elements[3]);
                    a.NumberOfCars = int.Parse(elements[4]);

                    db.Auta.Add(a);
                }
                db.SaveChanges();
            }
        }
        WypozyczalniaDB db = new WypozyczalniaDB();

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime todayFull = startDate.Value;
            DateTime today = new DateTime(todayFull.Year, todayFull.Month, todayFull.Day);
            if (db.Database.Exists())
            {
                List<Wynajem> wszystkieWynajmy = db.Wynajmy.ToList();
                Auto a = new Auto();
                foreach (Wynajem item in wszystkieWynajmy)
                {
                    if ((item.EndDate < today || item.StartDate > today) && !item.isFinishedOrNotStarted)
                    {
                        a = db.Auta.Single(p => p.Id == item.IdSamochodu);
                        a.NumberOfCars++;
                        item.isFinishedOrNotStarted = true;
                        db.SaveChanges();
                    }
                    else if(item.EndDate >= today && item.StartDate <= today && item.isFinishedOrNotStarted)
                    {
                        a = db.Auta.Single(p => p.Id == item.IdSamochodu);
                        a.NumberOfCars--;
                        item.isFinishedOrNotStarted = false;
                        db.SaveChanges();
                    }
                }
            }
            int from = int.Parse(priceFrom.Text);
            int to = int.Parse(priceTo.Text);
            autoBindingSource.DataSource = db.Auta
                .Where(a => a.Id.ToString().StartsWith(id.Text))
                .Where(a => a.Name.StartsWith(name.Text))
                .Where(a => a.Segment.StartsWith(segment.Text))
                .Where(a => a.PricePerDay >= from)
                .Where(a => a.PricePerDay <= to)
                .ToList();
            wynajemBindingSource.DataSource = db.Wynajmy.ToList();
        }

        private void price_ScopeValueChanged(object sender, int e)
        {
            priceFrom.Text = price.ValueMin.ToString();
            priceTo.Text = price.ValueMax.ToString();

            if (price.ScopeValueMax < price.ScopeValueMin)
            {
                priceFrom.Text = "0";
                priceTo.Text = price.ValueMax.ToString();
            }
            int from = int.Parse(priceFrom.Text);
            int to = int.Parse(priceTo.Text);
            autoBindingSource.DataSource = db.Auta
                .Where(a => a.Id.ToString().StartsWith(id.Text))
                .Where(a => a.Name.StartsWith(name.Text))
                .Where(a => a.Segment.StartsWith(segment.Text))
                .Where(a => a.PricePerDay >= from)
                .Where(a => a.PricePerDay <= to)
                .ToList();
        }

        private void daysBar_LedbarValueChanged(object sender, int e)
        {
            days.Text = daysBar.ValueMax.ToString();
        }

        private void id_TextChanged(object sender, EventArgs e)
        {
            int from = int.Parse(priceFrom.Text);
            int to = int.Parse(priceTo.Text);
            autoBindingSource.DataSource = db.Auta
                .Where(a => a.Id.ToString().StartsWith(id.Text))
                .Where(a => a.Name.StartsWith(name.Text))
                .Where(a => a.Segment.StartsWith(segment.Text))
                .Where(a => a.PricePerDay >= from)
                .Where(a => a.PricePerDay <= to)
                .ToList();
        }

        private void rent_Click(object sender, EventArgs e)
        {
            if (int.TryParse(idRent.Text, out int test)
                && clientName.Text != ""
                && clientContact.Text != ""
                && days.Text != "0")
            {
                Wynajem w = new Wynajem();
                w.IdSamochodu = int.Parse(idRent.Text);
                w.ClientName = clientName.Text;
                w.ClientContact = clientContact.Text;
                w.NumberOfDays = int.Parse(days.Text);
                Auto a = db.Auta.Single(p => p.Id == w.IdSamochodu);
                int pricePerDay = a.PricePerDay;
                int numberOfCars = a.NumberOfCars;
                w.Payment = w.NumberOfDays * pricePerDay;

                int startYear = startDate.Value.Year;
                int startMonth = startDate.Value.Month;
                int startDay = startDate.Value.Day;
                DateTime start = new DateTime(startYear, startMonth, startDay);
                DateTime end = start.AddDays(w.NumberOfDays);
                w.StartDate = start;
                w.EndDate = end;
                w.isFinishedOrNotStarted = false;

                if (numberOfCars > 0)
                {
                    a.NumberOfCars--;
                    db.Wynajmy.Add(w);
                    db.SaveChanges();

                    wynajemBindingSource.DataSource = db.Wynajmy.ToList();
                    toPay.Text = w.Payment.ToString();

                    int from = int.Parse(priceFrom.Text);
                    int to = int.Parse(priceTo.Text);
                    autoBindingSource.DataSource = db.Auta
                        .Where(s => s.Id.ToString().StartsWith(id.Text))
                        .Where(s => s.Name.StartsWith(name.Text))
                        .Where(s => s.Segment.StartsWith(segment.Text))
                        .Where(s => s.PricePerDay >= from)
                        .Where(s => s.PricePerDay <= to)
                        .ToList();
                }
                else
                {
                    MessageBox.Show("SAMOCHÓD NIE DOSTĘPNY! Wybierz inne auto.");
                }

                
            }
            else
            {
                Color warn = Color.Red;
                Color ok = Color.White;
                if(idRent.Text == "" || !int.TryParse(idRent.Text, out test))
                {
                    idRent.BackColor = warn;
                }
                if (clientName.Text == "") { clientName.BackColor = warn; }
                if (clientContact.Text == "") { clientContact.BackColor = warn; }
                if (days.Text == "0") { days.BackColor = warn; }
                
                MessageBox.Show("Nie wypełniłeś poprawnie formularza!");

                idRent.BackColor = clientName.BackColor = clientContact.BackColor = days.BackColor = ok;
            }

            
        }
    }
}
