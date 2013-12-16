using System;
using System.Collections.Generic;

namespace Scommesse.Model
{
    public class ScommessaController
    {
        public ScommessaAstratta Stato { get; set; }

        public BetCard BetCard { get; private set; }

        public ScommessaController(BetCard betCard, ScommessaAstratta scommessaAstratta)
        {
            BetCard = betCard;
            Stato = scommessaAstratta;
        }

        public void ControllaScommessa(ScommessaAstratta scommessaAstratta)
        {
            scommessaAstratta.ControllaScommessa(this);
        }

        public void AddScommessaConfermata(ScommessaConfermata scommessaConfermata)
        {
            BetCard.AddScommessaConfermata(scommessaConfermata);
        }
    }
}