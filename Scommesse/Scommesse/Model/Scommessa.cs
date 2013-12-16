using System.Collections.Generic;
using System.Linq;

namespace Scommesse.Model
{
    public class Scommessa : ScommessaAstratta
    {
        protected Scommessa(BetCard betCard)
        {
            Importo = 1;
            Puntate = new List<Quota>();
            ScommessaController = new ScommessaController(betCard, this);
        }

        public Scommessa(ScommessaConfermata scommessaConfermata)
            : base(scommessaConfermata)
        {
        }

        public void AddPuntata(Quota quota)
        {
            if (ContainsPuntata(quota))
                Puntate.Remove(quota);
            Puntate.Add(quota);
        }

        public void RemovePuntata(Quota quota)
        {
            Puntate.Remove(quota);
        }

        protected override bool Controllabile()
        {
            // se c'è almeno una puntata e l'importo è di almeno 1€
            if (Puntate.Count != 0 && Importo >= 1.0F)
                // e se la vincita totale non supera i 10000€ restituisce vero
                return Puntate.Aggregate(Importo, (current, quota) => current * quota.Moltiplicatore) <= 10000.0F;
            return false;
        }

        public override void ControllaScommessa(ScommessaController controller)
        {
            if(Controllabile())
                controller.Stato = new ScommessaConfermata(this);
        }
    }
}