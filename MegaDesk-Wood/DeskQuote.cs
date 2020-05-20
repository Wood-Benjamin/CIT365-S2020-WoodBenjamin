using Microsoft.SqlServer.Server;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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

        //=========Added for RushOrder Method (Traesa)
        public static int[,] rushOrderPrices = new int[3, 3];
      //  public static int[] testPriceArray = new int[9];

        //constraints
        public const int BASEPRICE = 200;
        public const int BASESURFACE = 1000;
        public const int OVERSURFACE = 1;
        public const int LARGESURFACE = 2000;

        public static int [ , ] GetRushOrderPrices()
        {

            int[,] rushOrderPrices = new int[3, 3];
            var filePath = @"../../docs/rushOrderPrices.txt";
            StreamReader reader = new StreamReader(filePath);
            string[] priceList = new string[9];
            int i = 0;
            while (reader.EndOfStream == false)
            {
                string line = reader.ReadLine();
                priceList[i] = line;
                i++;
            }
            
            reader.Close();
            int counter = 0;
           while( counter < 9)
            {
                for(int y = 0; y<3;y++)
                { for (int x = 0; x < 3; x++)
                    { rushOrderPrices[y, x] = int.Parse(priceList[counter]);
                        counter++;
                    }

                }
            }
            return rushOrderPrices;
        }

    }
    public struct NewQuote
    {
        public string SpecName;
        public string SpecDate;
        public string SpecMaterial;
        public string SpecWidth;
        public string SpecDepth;
        public string SpecDrawers;
        public string SpecRush;
        public string SpecTotal;
    }

}
