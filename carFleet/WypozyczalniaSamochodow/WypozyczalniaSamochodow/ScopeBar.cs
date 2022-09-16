using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WypozyczalniaSamochodow
{
    public partial class ScopeBar : UserControl
    {
        int part = 100;

        private int test;

        public int Test
        {
            get { return test; }
            set { test = value; }
        }


        public event EventHandler<int> ScopeValueChanged;

        private int max;

        public int Max
        {
            get { return max; }
            set { max = value; }
        }

        private int valueMin;
        public int ValueMin
        {
            get { return ScopeValueMin * Max / part; }
            set { valueMin = value; }
        }

        private int valueMax;
        public int ValueMax
        {
            get { return ScopeValueMax * Max / part; }
            set { valueMax = value; }
        }


        private int scopeValueMin;

        public int ScopeValueMin
        {
            get { return scopeValueMin; }
            set
            {
                if (value >= 0 && value <= part)
                {
                    bool hasChanged = value != scopeValueMin;

                    scopeValueMin = value;
                    Refresh();

                    ScopeValueChanged?.Invoke(this, scopeValueMin);
                }
            }
        }

        private int scopeValueMax;

        public int ScopeValueMax
        {
            get { return scopeValueMax; }
            set
            {
                if (value >= 0 && value <= part)
                {
                    bool hasChanged = value != scopeValueMax;

                    scopeValueMax = value;
                    Refresh();

                    ScopeValueChanged?.Invoke(this, scopeValueMax);
                }
            }
        }

        public ScopeBar()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            float w, h, ledWidth, ledHeight, ledX, ledY;
            w = this.Width;
            h = this.Height;

            ledWidth = w / part;//0.9f * w / 10;
            ledHeight = h;//0.9f * h;

            ledX = 0;//0.05f * w / 10;
            ledY = 0;//0.05f * h;

            Brush currentBrush = Brushes.DarkCyan;
            for (int i = 0; i < part; i++)
            {
                //if (i == scopeValueMax) { currentBrush = Brushes.DarkRed; }
                if (i >= scopeValueMin) { currentBrush = Brushes.Cyan; }
                if (i >= scopeValueMax) { currentBrush = Brushes.DarkCyan; }
                e.Graphics.FillRectangle(currentBrush, ledX, ledY, ledWidth, ledHeight);
                ledX += w / part;
            }

            base.OnPaint(e);
        }

        private void ScopeBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ScopeValueMax = 1 + part * e.X / this.Width;
            }
        }

        private void ScopeBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ScopeValueMin = part * e.X / this.Width;
            }
        }
    }
}
