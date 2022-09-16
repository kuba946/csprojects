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
    public partial class Rent : UserControl
    {
        public event EventHandler<bool> RentStatusChanged;

        private bool ability = true;

        public bool Ability
        {
            get { return ability; }
            set
            {
                if (value != ability)
                {
                    ability = value;
                    if (value)
                    {
                        checkBox1.Checked = !value;
                    }
                    
                    checkBox1.Enabled = value;
                    dateTimePicker1.Enabled = value;
                    dateTimePicker2.Enabled = value;
                    label1.Enabled = value;
                    label2.Enabled = value;
                }
            }
        }
        private bool rented;

        public bool Rented
        {
            get { return rented; }
            set
            {
                if (rented != value)
                {
                    rented = value;
                    //Ability = !value;
                    RentStatusChanged?.Invoke(this, rented);
                }
                Ability = !value;
            }
        }

        private DateTime odDnia;

        public DateTime OdDnia
        {
            get { return odDnia; }
            set { odDnia = value; }
        }

        private DateTime doDnia;

        public DateTime DoDnia
        {
            get { return doDnia; }
            set { doDnia = value; }
        }


        public Rent()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.Rented = checkBox1.Checked;
        }
    }
}
