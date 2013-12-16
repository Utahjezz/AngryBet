using System;
using System.Windows.Forms;
using Scommesse.Filters;
using Scommesse.Model;
using Scommesse.Model.TipiRisultato;
using Scommesse.Presenters;
using Scommesse.Utility;
using Scommesse.View;
using Scommesse.Persistence;

namespace Scommesse
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DateTime data = new DateTime(10/10/2010);
            Cliente admin = new Cliente("ADMIN","ADMIN",data,"codice");
            BetCardAdmin betCard = new BetCardAdmin("2",admin,"2");
            DataSaver.SaveBetCardOnFile(betCard);
            Palinsesto pal = new Palinsesto();
            Tipologia[] tip = new Tipologia[3];
            tip[0] = Tipologia.GNG;
            tip[1] = Tipologia.UXD;
            tip[2] = Tipologia.UO;
            pal.AddCategoria("calcio",tip);
            pal.GetCategoriaByName("calcio").AddCompetizione("Serie A");
            pal.GetCategoriaByName("calcio").AddCompetizione("Champions League");
            String s = "26/10/2012";
            String[] gma = new String[3];
            gma = s.Split('/');
            DateTime date = new DateTime(Int16.Parse(gma[2]), Int16.Parse(gma[1]), Int16.Parse(gma[0]));
            
            pal.GetCategoriaByName("calcio").GetCompetizioneByName("Serie A").AddEvento("Inter","Milan",date);
            pal.GetCategoriaByName("calcio").GetCompetizioneByName("Champions League").AddEvento("Barcellona", "Manchester United", date);
            Tipologia[] tipologia = new Tipologia[1];
            tipologia[0] = Tipologia.UXD;
            pal.AddCategoria("Basket",tipologia);
            pal.GetCategoriaByName("Basket").AddCompetizione("Lega A");
            pal.GetCategoriaByName("Basket").GetCompetizioneByName("Lega A").AddEvento("Scavolini", "Sutor", date);
            pal.AddCategoria("Tennis", tipologia);
            DataSaver.SavePalinsestoOnFile(pal);
            InserimentoTesseraController controller = new InserimentoTesseraController();
           
        }
    }
}