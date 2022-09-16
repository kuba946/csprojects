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
    public partial class FloatData : UserControl
    {
        public event EventHandler TekstChanged;

        [Category("Appearance")]
        public string FloatDataTitle
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

        public int FloatDataValueValidation
        {
            get { return valueValidation; }
            set { valueValidation = value; }
        }

        [Category("Appearance")]
        public string FloatDataTextboxValue
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

        public FloatData()
        {
            InitializeComponent();
            textboxValue.TextChanged += TextboxValue_TextChanged;
        }

        private void TextboxValue_TextChanged(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                if (FloatDataValidateValue(out string msg))
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

        protected virtual bool FloatDataValidateValue(out string message)
        {
            string t = textboxValue.Text.ToLower();
            if (double.TryParse(t, out double test))
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
