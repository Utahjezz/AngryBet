using System;
using System.Linq;

namespace Scommesse.Model
{
    [Serializable]
    public class ScommessaConfermata : ScommessaAstratta
    {
        #region StatoScommessaConfermata enum

        public enum StatoScommessaConfermata
        {
            [StringValue("Vinta")] Vinta,
            [StringValue("Persa")] Persa,
            [StringValue("In Attesa")] InAttesa
        }

        #endregion

        public ScommessaConfermata(Scommessa scommessa) : base(scommessa)
        {
            DataOra = DateTime.Now;
            Codice = new Guid();
            Stato = StatoScommessaConfermata.InAttesa;
        }

        public DateTime DataOra { get; private set; }
        public Guid Codice { get; private set; }
        public StatoScommessaConfermata Stato { get; set; }

        public void GoBack(ScommessaController controller)
        {
            try
            {
                if (DateTime.Now.CompareTo(DataOra) > 20)
                    throw new Exception("non puoi più tornare indietro");
                controller.Stato = new Scommessa(this);
            }
            catch (Exception)
            {
            }
        }

        protected override bool Controllabile()
        {
            // Se tutti gli eventi legati alla scommessa sono terminati, allora puoi controllare i risultati
            return Puntate.All(quota => quota.Evento.Stato.Equals(Evento.StatoEvento.Terminato));
        }

        public override void ControllaScommessa(ScommessaController controller)
        {
            if(Controllabile())
                foreach (Quota quota in Puntate)
                {
                    // Se si è sbagliato anche solo un risultato, considera la scommessa persa
                    // (se l'evento relativo alla puntata non contiene il risultato puntato)
                    if (!quota.Evento.GetRisultati().Contains(quota.Valore))
                        Stato = StatoScommessaConfermata.Persa;
                }
            Stato = StatoScommessaConfermata.Vinta;
        }
    }
}