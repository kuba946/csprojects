using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BazaPojazdow.Controls
{
    public class Statuses
    {
        protected Brush[] colors;
        protected string[] messages;

        public Statuses(Brush[]colors, string[] messages)
        {
            this.colors = colors;
            this.messages = messages;
        }
    }
}
