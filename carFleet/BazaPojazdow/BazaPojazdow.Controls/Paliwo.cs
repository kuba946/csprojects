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
    public partial class Paliwo : UserControl
    {
        public event EventHandler TekstChanged;

        [Category("Appearance")]
        public string PaliwoTitle
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

        public int PaliwoValueValidation
        {
            get { return valueValidation; }
            set { valueValidation = value; }
        }

        [Category("Appearance")]
        public string PaliwoTextboxValue
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

        public Paliwo()
        {
            InitializeComponent();
            textboxValue.TextChanged += TextboxValue_TextChanged;
        }

        private void TextboxValue_TextChanged(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                if (PaliwoValidateValue(out string msg))
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

        protected virtual bool PaliwoValidateValue(out string message)
        {
            string t = textboxValue.Text.ToLower();
            string b = "benzyna";
            string o = "olej napędowy";
            string e = "elektryczny";
            if (t == b || t == o || t == e)
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
