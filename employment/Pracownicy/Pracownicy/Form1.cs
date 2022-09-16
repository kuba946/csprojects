using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pracownicy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (!db.Database.Exists())
            {
                Pracownik p1 = new Pracownik();
                p1.Name = "Jan";
                p1.Surname = "Kowalski";
                p1.Contact = "jan.kowalski@gmail.com";
                p1.Status = "Zatrudniony";
                db.Pracownicy.Add(p1);

                Pracownik p2 = new Pracownik();
                p2.Name = "Andrzej";
                p2.Surname = "Nowak";
                p2.Contact = "505645789";
                p2.Status = "Urlop";
                db.Pracownicy.Add(p2);

                Pracownik p3 = new Pracownik();
                p3.Name = "Krystyna";
                p3.Surname = "Cabacka";
                p3.Contact = "846180346";
                p3.Status = "Niezatrudniony";
                db.Pracownicy.Add(p3);

                Pracownik p4 = new Pracownik();
                p4.Name = "Jędrzej";
                p4.Surname = "Szot";
                p4.Contact = "jedrek@onet.eu";
                p4.Status = "Zatrudniony";
                db.Pracownicy.Add(p4);

                Pracownik p5 = new Pracownik();
                p5.Name = "Andrzej";
                p5.Surname = "Szczaw";
                p5.Contact = "604908605";
                p5.Status = "Zatrudniony";
                db.Pracownicy.Add(p5);

                db.SaveChanges();
            }
        }

        PracownicyDB db = new PracownicyDB();

        private void Form1_Load(object sender, EventArgs e)
        {
            status.Text = "";
            pracownikBindingSource.DataSource = db.Pracownicy.ToList();
        }

        private void status1_ActualStatusChanged(object sender, int e)
        {
            switch (e)
            {
                case 0:
                    status.Text = "NIEDOSTĘPNY";
                    break;
                case 1:
                    status.Text = "NIEDOSTĘPNY";
                    break;
                case 2:
                    status.Text = "DOSTĘPNY";
                    break;
                default:
                    break;
            }
        }

        private void imieFilter_TextChanged(object sender, EventArgs e)
        {
            pracownikBindingSource.DataSource = db.Pracownicy
                .Where(p => p.Name.StartsWith(imieFilter.Text))
                .Where(p => p.Surname.StartsWith(nazwiskoFilter.Text))
                .Where(p => p.Contact.StartsWith(kontaktFilter.Text))
                .Where(p => p.Status.StartsWith(statusFilter.Text))
                .ToList();
        }

        private void nazwiskoFilter_TextChanged(object sender, EventArgs e)
        {
            pracownikBindingSource.DataSource = db.Pracownicy
                .Where(p => p.Name.StartsWith(imieFilter.Text))
                .Where(p => p.Surname.StartsWith(nazwiskoFilter.Text))
                .Where(p => p.Contact.StartsWith(kontaktFilter.Text))
                .Where(p => p.Status.StartsWith(statusFilter.Text))
                .ToList();
        }

        private void kontaktFilter_TextChanged(object sender, EventArgs e)
        {
            pracownikBindingSource.DataSource = db.Pracownicy
                .Where(p => p.Name.StartsWith(imieFilter.Text))
                .Where(p => p.Surname.StartsWith(nazwiskoFilter.Text))
                .Where(p => p.Contact.StartsWith(kontaktFilter.Text))
                .Where(p => p.Status.StartsWith(statusFilter.Text))
                .ToList();
        }

        private void statusFilter_TextChanged(object sender, EventArgs e)
        {
            pracownikBindingSource.DataSource = db.Pracownicy
                .Where(p => p.Name.StartsWith(imieFilter.Text))
                .Where(p => p.Surname.StartsWith(nazwiskoFilter.Text))
                .Where(p => p.Contact.StartsWith(kontaktFilter.Text))
                .Where(p => p.Status.StartsWith(statusFilter.Text))
                .ToList();
        }

        private void zatrudnij_Click(object sender, EventArgs e)
        {
            int.TryParse(idOperacje.Text, out int id);

            var query =
                from prac in db.Pracownicy
                where prac.Id == id
                select prac;

            foreach (Pracownik prac in query)
            {
                prac.Status = "Zatrudniony";
            }
            
            pracownikBindingSource.DataSource = db.Pracownicy
                .Where(p => p.Name.StartsWith(imieFilter.Text))
                .Where(p => p.Surname.StartsWith(nazwiskoFilter.Text))
                .Where(p => p.Contact.StartsWith(kontaktFilter.Text))
                .Where(p => p.Status.StartsWith(statusFilter.Text))
                .ToList();
        }

        private void urlop_Click(object sender, EventArgs e)
        {
            int.TryParse(idOperacje.Text, out int id);

            var query =
                from prac in db.Pracownicy
                where prac.Id == id
                select prac;

            foreach (Pracownik prac in query)
            {
                prac.Status = "Urlop";
            }

            pracownikBindingSource.DataSource = db.Pracownicy
                .Where(p => p.Name.StartsWith(imieFilter.Text))
                .Where(p => p.Surname.StartsWith(nazwiskoFilter.Text))
                .Where(p => p.Contact.StartsWith(kontaktFilter.Text))
                .Where(p => p.Status.StartsWith(statusFilter.Text))
                .ToList();
        }

        private void zwolnij_Click(object sender, EventArgs e)
        {
            int.TryParse(idOperacje.Text, out int id);

            var query =
                from prac in db.Pracownicy
                where prac.Id == id
                select prac;

            foreach (Pracownik prac in query)
            {
                prac.Status = "Niezatrudniony";
            }

            pracownikBindingSource.DataSource = db.Pracownicy
                .Where(p => p.Name.StartsWith(imieFilter.Text))
                .Where(p => p.Surname.StartsWith(nazwiskoFilter.Text))
                .Where(p => p.Contact.StartsWith(kontaktFilter.Text))
                .Where(p => p.Status.StartsWith(statusFilter.Text))
                .ToList();
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            if (imie.Text == "" || nazwisko.Text == "" ||
                kontakt.Text == "" || status.Text == "")
            {
                MessageBox.Show("Nie wypełniłeś wszystkich pól!");
            }
            else
            {
                Pracownik prac = new Pracownik();
                prac.Name = imie.Text;
                prac.Surname = nazwisko.Text;
                prac.Contact = kontakt.Text;

                switch (status1.ActualStatus)
                {
                    case 0:
                        prac.Status = "Niezatrudniony";
                        break;
                    case 1:
                        prac.Status = "Urlop";
                        break;
                    case 2:
                        prac.Status = "Zatrudniony";
                        break;
                    default:
                        break;
                }
                db.Pracownicy.Add(prac);

                db.SaveChanges();

                pracownikBindingSource.DataSource = db.Pracownicy
                .Where(p => p.Name.StartsWith(imieFilter.Text))
                .Where(p => p.Surname.StartsWith(nazwiskoFilter.Text))
                .Where(p => p.Contact.StartsWith(kontaktFilter.Text))
                .Where(p => p.Status.StartsWith(statusFilter.Text))
                .ToList();
            }
        }
    }
}
