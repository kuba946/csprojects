using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BazaPojazdow.Controls
{
    [DefaultProperty("TextboxValue")]
    [DefaultEvent("TekstChanged")]
    public partial class Typ : UserControl
    {
        public event EventHandler TekstChanged;

        [Category("Appearance")]
        public string TypTitle
        {
            get
            {
                return title.Text;
            }
            set
            {
                title.Text = value;
            }
        }
        private int valueValidation;

        public int TypValueValidation
        {
            get { return valueValidation; }
            set { valueValidation = value; }
        }

        [Category("Appearance")]
        public string TypTextboxValue
        {
            get
            {
                return textboxValue.Text;
            }
            set
            {
                textboxValue.Text = value;
            }
        }

        public Typ()
        {
            InitializeComponent();
            textboxValue.TextChanged += TextboxValue_TextChanged;
        }

        private void TextboxValue_TextChanged(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                if (TypValidateValue(out string msg))
                {
                    validation.Hide();
                }
                else
                {
                    validation.Text = msg;
                    validation.Show();
                }
            }
            TekstChanged?.Invoke(this, new EventArgs());
        }

        protected virtual bool TypValidateValue(out string message)
        {
            string t = textboxValue.Text.ToLower();
            string m = "motocykle";
            string o = "osobowe";
            string c = "ciężarowe";
            if (t == m || t == o || t == c)
            {
                message = "ok";
                return true;
            }
            else
            {
                message = "nieprawidłowe dane!";
                return false;
            }
        }
    }
}
