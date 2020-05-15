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

        //constraints
        public const int BASEPRICE = 200;
        public const int BASESURFACE = 1000;
        public const int OVERSURFACE = 1;
        public const int LARGESURFACE = 2000;

        public void GetRushOrder()
        {
            //Create a GetRushOrder method within
            //the DeskQuote class to handle the population
            //of a member variable that holds a two  dimension
            //array that encases the logic in a try catch block.
        }
        public void ReadQuotes()
        { /*
            var strResultJson = String.Empty;
            strResultJson = File.ReadAllText(@"../../docs/quotes.json"));
            //List<DeskQuote> newQuote = new List<DeskQuote>();
            //using (StreamReader jsonReader = new StreamReader(@"../../docs/quotes.json"))
                //NewMethod(newQuote, jsonReader);
            //return newQuote; */
        }

        private static void NewMethod(List<DeskQuote> newQuote, StreamReader jsonReader)
        {
          //  newQuote.AddRange(JsonConvert.DeserializeObject<List<DeskQuote>>(value: jsonReader.ReadToEnd()));
        }

        public void WriteQuotes(List<DeskQuote> listQuotes)
        {/*
            StreamWriter jsonWriter = File.WriteAllText(@"../../docs/quotes.json");
            JsonSerializer jsonSerial = new JsonSerializer();
            jsonSerial.Serialize(jsonWriter, listQuotes);
            */
        }
    }
}
