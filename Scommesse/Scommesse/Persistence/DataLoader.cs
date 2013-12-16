using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Scommesse.Model;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace Scommesse.Persistence
{
    static class DataLoader
    {
       
        public static Palinsesto LoadPalinsestoFromFile(String fileName)
        {
            Palinsesto palinsesto;
            FileStream fs = new FileStream(fileName, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            palinsesto = (Palinsesto) bf.Deserialize(fs);
            return palinsesto;
        }

        public static BetCard LoadBetCardFromFile(String codiceTesseraBetCard)
        {
            BetCard betCard;
            FileStream fs = new FileStream(codiceTesseraBetCard, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            betCard = (BetCard) bf.Deserialize(fs);
            return betCard;
        }
    }
}
