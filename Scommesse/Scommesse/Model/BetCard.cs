using System;
using System.Collections.Generic;

namespace Scommesse.Model
{
    [Serializable]
    public class BetCard
    {
        private readonly List<ScommessaConfermata> _scommesse;

        public BetCard(Cliente cliente, string codiceTessera, string pin)
        {
            Cliente = cliente;
            CodiceTessera = codiceTessera;
            Pin = pin;
            Credito = 5.0F;
            _scommesse = new List<ScommessaConfermata>();
            Bloccata = false;
        }

        public BetCard(Cliente cliente, string codiceTessera, string pin, float credito)
            : this(cliente, codiceTessera, pin)
        {
            Credito = credito;
        }

        public string CodiceTessera { get; private set; }
        public float Credito { get; private set; }
        public bool Bloccata { get; private set; }
        public string Pin { get; private set; }
        public Cliente Cliente { get; private set; }

       public void AddScommessaConfermata(ScommessaConfermata scommessaConfermata)
        {
            if (scommessaConfermata == null) throw new ArgumentNullException("scommessaConfermata");
            _scommesse.Add(scommessaConfermata);
        }
    }
}