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
    public partial class LedBar : UserControl
    {
        int part = 100;

        public event EventHandler<int> LedbarValueChanged;

        private int max;

        public int Max
        {
            get { return max; }
            set { max = value; }
        }

        private int valueMax;
        public int ValueMax
        {
            get { return LedbarValueMax * Max / part; }
            set { valueMax = value; }
        }

        private int ledbarValueMax;

        public int LedbarValueMax
        {
            get { return ledbarValueMax; }
            set
            {
                if (value >= 0 && value <= part)
                {
                    bool hasChanged = value != ledbarValueMax;

                    ledbarValueMax = value;
                    Refresh();

                    LedbarValueChanged?.Invoke(this, ledbarValueMax);
                }
            }
        }

        public LedBar()
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

            Brush currentBrush = Brushes.Magenta;
            for (int i = 0; i < part; i++)
            {
                //if (i == scopeValueMax) { currentBrush = Brushes.DarkRed; }
                if (i == ledbarValueMax) { currentBrush = Brushes.DarkMagenta; }
                e.Graphics.FillRectangle(currentBrush, ledX, ledY, ledWidth, ledHeight);
                ledX += w / part;
            }

            base.OnPaint(e);
        }

        private void LedBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                LedbarValueMax = 1 + part * e.X / this.Width;
            }
        }

        private void LedBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                LedbarValueMax = 1 + part * e.X / this.Width;
            }
        }
    }
}
