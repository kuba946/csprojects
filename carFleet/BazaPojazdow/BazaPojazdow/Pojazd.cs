using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaPojazdow
{
    abstract class Pojazd : IDane
    {
        private string rejestracja;
        protected string typ;
        private string paliwo;
        private double moc;
        protected double pojemnoscSilnika;
        protected double masa;
        protected double spalanie;
        private double pojemnoscZbiornika;
        private double zasieg;
        protected string czyPoprawneDane;

        public Pojazd()
        {
            /*this.rejestracja = "AA00000";
            this.typ = "(none)";
            this.paliwo = "(none)";
            this.moc = 0;
            this.pojemnoscSilnika = 0;
            this.masa = 0;
            this.spalanie = 0;
            this.pojemnoscZbiornika = 0;
            ObliczZasieg();
            CzyPoprawneDane();*/
        }
        public Pojazd(string rejestracja, string typ, string paliwo, int moc, double pojemnoscSilnika, double masa, double spalanie, double pojemnoscZbiornika)
        {
            this.rejestracja = rejestracja;
            this.typ = typ;
            this.paliwo = paliwo;
            this.moc = moc;
            this.pojemnoscSilnika = pojemnoscSilnika;
            this.masa = masa;
            this.spalanie = spalanie;
            this.pojemnoscZbiornika = pojemnoscZbiornika;
            ObliczZasieg();
            CzyPoprawneDane();
        }

        public void WprowadzRejestracje(string rejestracja)
        {
            this.rejestracja = rejestracja;
        }
        public void WprowadzTyp(string typ)
        {
            this.typ = typ;
        }
        public void WprowadzPaliwo(string paliwo)
        {
            this.paliwo = paliwo;
        }
        public void WprowadzMoc(double moc)
        {
            this.moc = moc;
        }
        public void WprowadzPojemnoscSilnika(double pojemnoscSilnika)
        {
            this.pojemnoscSilnika = pojemnoscSilnika;
        }
        public void WprowadzMasa(double masa)
        {
            this.masa = masa;
        }
        public void WprowadzSpalanie(double spalanie)
        {
            this.spalanie = spalanie;
        }
        public void WprowadzPojemnoscZbiornika(double pojemnoscZbornika)
        {
            this.pojemnoscZbiornika = pojemnoscZbornika;
        }
        protected void ObliczZasieg()
        {
            if (this.spalanie == 0) { this.zasieg = 0; }
            else { this.zasieg = this.pojemnoscZbiornika / this.spalanie * 100; }
        }
        private void CzyPoprawneDane()
        {
            string czyPoprawneDane = "";
            if (typ == "Motocykle" && masa > 0 && masa <= 400) { czyPoprawneDane = "tak"; }
            else if ((typ == "Osobowe" || typ == "Elektryczne") && masa <= 3.5) { czyPoprawneDane = "tak"; }
            else if (typ == "(none)") { czyPoprawneDane = "tak"; }
            else { czyPoprawneDane = "NIE"; }
            this.czyPoprawneDane = czyPoprawneDane;
        }

        public abstract string PodajPaliwo();
        public abstract string PodajMase();
        public virtual string PodajPojemnoscSilnika()
        {
            return pojemnoscSilnika + " l";
        }
        public virtual string PodajSpalanie()
        {
            return spalanie.ToString() + " l/100km";
        }
    }
}