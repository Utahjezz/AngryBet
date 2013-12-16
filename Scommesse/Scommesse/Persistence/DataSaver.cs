using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Scommesse.Model;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Scommesse.Persistence
{
    static class DataSaver
    {
        
        public static void SavePalinsestoFile (Palinsesto palinsesto)
        {
             FileStream fs = new FileStream(palinsesto.Nome, FileMode.OpenOrCreate);
             BinaryFormatter bf = new BinaryFormatter();
             bf.Serialize(fs, palinsesto);
             fs.Close();
        }

        public static void SaveBetCardsToFile(BetCard betCard)
        {
            FileStream fs = new FileStream(betCard.CodiceTessera, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, betCard);
            fs.Close();
        }

    }
}
