using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Wood
{
    public class DeskQuote
    {
        public DateTime QuoteDate { get; set; }
        public string CustomerName { get; set; }
        public Desk desk;
        public int MaterialCost { get; set; }
        public int SurfaceAreaCost { get; set; }
        public int DrawerCost { get; set; }
        public int RushCost { get; set; }
        public int QuoteTotal { get; set; }

        //constraints
        public const int BASEPRICE = 200;
        public const int BASESURFACE = 1000;
        public const int OVERSURFACE = 1;
        public const int LARGESURFACE = 2000;
    }
}
