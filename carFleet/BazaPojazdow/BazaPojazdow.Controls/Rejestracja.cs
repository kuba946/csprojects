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
    public partial class Rejestracja : UserControl
    {
        public event EventHandler TekstChanged;

        [Category("Appearance")]
        public string RejestracjaTitle
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

        public int RejestracjaValueValidation
        {
            get { return valueValidation; }
            set { valueValidation = value; }
        }

        [Category("Appearance")]
        public string RejestracjaTextboxValue
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

        public Rejestracja()
        {
            InitializeComponent();
            textboxValue.TextChanged += TextboxValue_TextChanged;
        }

        private void TextboxValue_TextChanged(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                if (RejestracjaValidateValue(out string msg))
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

        protected virtual bool RejestracjaValidateValue(out string message)
        {
            int l = textboxValue.Text.Length;
            var s = textboxValue.Text;
            if (l == 8)
            {
                if (Char.IsLetter(s[0]) && Char.IsLetter(s[1]) && Char.IsLetter(s[2])
                    && Char.IsDigit(s[3]) && Char.IsLetterOrDigit(s[4]) && Char.IsLetterOrDigit(s[5])
                    && Char.IsLetterOrDigit(s[6]) && Char.IsLetterOrDigit(s[7]))
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
            else if (l == 7)
            {
                if (Char.IsLetter(s[0]) && Char.IsLetter(s[1])
                    && Char.IsDigit(s[2]) && Char.IsLetterOrDigit(s[3]) && Char.IsLetterOrDigit(s[4])
                    && Char.IsLetterOrDigit(s[5]) && Char.IsLetterOrDigit(s[6]))
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
            else
            {
                message = "nieprawidłowe dane!";
                return false;
            }
        }
    }
}
