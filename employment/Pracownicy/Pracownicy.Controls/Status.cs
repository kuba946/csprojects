using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pracownicy.Controls
{
    public partial class Status : UserControl
    {
        public event EventHandler<int> ActualStatusChanged;

        private int actualStatus = -1;

        public int ActualStatus
        {
            get { return actualStatus; }
            set
            {
                if (value >= -1 && value <= 2)
                {
                    bool isChanged = actualStatus != value;
                    actualStatus = value;
                    Refresh();
                    ActualStatusChanged?.Invoke(this, actualStatus);
                }
            }
        }
        private Color defaultColor = Color.Gray;

        public Color DefaultColor
        {
            get { return defaultColor; }
            set { defaultColor = value; }
        }
        private Color[] colors = { Color.Red, Color.Orange, Color.LawnGreen };
        public Color[] StatusColors
        {
            get { return colors; }
            set { colors = value; }
        }
        private string defaultMessage = "";

        public string DefaultMessage
        {
            get { return defaultMessage; }
            set { defaultMessage = value; }
        }

        private string[] statusMessages = { "Niezatrudniony", "Urlop", "Zatrudniony" };
        public string[] StatusMessages
        {
            get { return statusMessages; }
            set { statusMessages = value; }
        }




        public Status()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            float x, y, rx, ry, r, margines;
            rx = this.Width * 30 / 200;
            ry = this.Height * 30 / 100;
            r = rx < ry ? rx : ry;
            margines = ((this.Width - this.Width * 50 / 200) / 3 - r) / 2;
            x = this.Width * 25 / 200 + margines;
            y = this.Height * 10 / 100;

            for (int i = 0; i < 3; i++)
            {
                if (actualStatus == i)
                {
                    e.Graphics.FillEllipse(new SolidBrush(StatusColors[i]), x, y, r, r);
                    message.Text = StatusMessages[i];
                }
                else
                {
                    e.Graphics.FillEllipse(new SolidBrush(DefaultColor), x, y, r, r);
                    if (actualStatus < 0)
                    {
                        message.Text = DefaultMessage;
                    }
                }
                x += r + 2 * margines;
            }

            x = (this.Width - message.Width) / 2;
            y = this.Height / 2 + (this.Height / 2 - message.Height) / 2;

            float xx = this.Width * 10 / 200;
            float yy = this.Height * 10 / 100;
            float font = xx < yy ? xx : yy;
            message.Location = new Point(int.Parse(x.ToString()), int.Parse(y.ToString()));
            message.Font = new Font(new FontFamily("Microsoft Sans Serif"), font);
        }

        private void Status_MouseClick(object sender, MouseEventArgs e)
        {
            float x, y, rx, ry, r, margines;
            rx = this.Width * 30 / 200;
            ry = this.Height * 30 / 100;
            r = rx < ry ? rx : ry;
            margines = ((this.Width - this.Width * 50 / 200) / 3 - r) / 2;
            x = this.Width * 25 / 200 + margines;
            y = this.Height * 10 / 100;

            float deltaX = r + 2 * margines;
            if (e.X >= x && e.X <= x + r && e.Y >= y && e.Y <= y + r)
            {
                if (ActualStatus != 0) { ActualStatus = 0; }
                else { ActualStatus = -1; }
            }
            else if (e.X >= x + deltaX && e.X <= (x + r) + deltaX && e.Y >= y && e.Y <= y + r)
            {
                if (ActualStatus != 1) { ActualStatus = 1; }
                else { ActualStatus = -1; }
            }
            else if (e.X >= x + 2 * deltaX && e.X <= (x + r) + 2 * deltaX && e.Y >= y && e.Y <= y + r)
            {
                if (ActualStatus != 2) { ActualStatus = 2; }
                else { ActualStatus = -1; }
            }
            else
            {
                ActualStatus = -1;
            }
        }
    }
}
