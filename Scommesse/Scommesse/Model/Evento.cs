using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Scommesse.Model.TipiRisultato;

namespace Scommesse.Model
{
    public class Evento
    {
        #region StatoEvento enum

        public enum StatoEvento
        {
            [StringValue("Scommettibile")] Scommettibile,
            [StringValue("In Corso")] InCorso,
            [StringValue("Terminato")] Terminato
        }

        #endregion

        private readonly Dictionary<Tipologia, List<Quota>> _quote;
        private List<Risultato> _risultati;

        public Evento(string competitoreA, string competitoreB, DateTime dataOra)
        {
            if (dataOra == null)
                throw new ArgumentNullException("dataOra");
            if (dataOra <= DateTime.Now)
                throw new InvalidDataException("dataOra");
            DataOra = dataOra;
            CompetitoreA = competitoreA;
            CompetitoreB = competitoreB;
            PunteggioA = 0;
            PunteggioB = 0;
            Stato = StatoEvento.Scommettibile;

            _quote = new Dictionary<Tipologia, List<Quota>>();
        }

        public string CompetitoreA { get; private set; }

        public string CompetitoreB { get; private set; }

        public int PunteggioA { get; private set; }

        public int PunteggioB { get; private set; }

        public StatoEvento Stato { get; set; }

        public DateTime DataOra { get; private set; }

        public List<Risultato> GetRisultati()
        {
            return _risultati;
        }

        public void SetPunteggi(int punteggioA, int punteggioB)
        {
            PunteggioA = punteggioA;
            PunteggioB = punteggioB;
            foreach (Tipologia tipologia in _quote.Keys)
            {
                switch (tipologia)
                {
                    case Tipologia.UXD:
                        if (punteggioA > punteggioB)
                            _risultati.Add(new Tipo1X2(Tipo1X2.Valori1X2.Uno));
                        else if (punteggioB > punteggioA)
                            _risultati.Add(new Tipo1X2(Tipo1X2.Valori1X2.Due));
                        else
                            _risultati.Add(new Tipo1X2(Tipo1X2.Valori1X2.X));
                        break;
                    case Tipologia.UD:
                        _risultati.Add(punteggioA > punteggioB
                                           ? new Tipo12(Tipo12.Valori12.Uno)
                                           : new Tipo12(Tipo12.Valori12.Due));
                        break;
                    case Tipologia.UO:
                        _risultati.Add(punteggioA + punteggioB >= 3
                                           ? new TipoUO(TipoUO.ValoriUO.Over)
                                           : new TipoUO(TipoUO.ValoriUO.Under));
                        break;
                    case Tipologia.GNG:
                        _risultati.Add((punteggioA > 0 && punteggioB > 0)
                                           ? new TipoGNG(TipoGNG.ValoriGNG.Goal)
                                           : new TipoGNG(TipoGNG.ValoriGNG.NoGoal));
                        break;
                }
            }
        }

        public void SetQuote(Tipologia tipologia, float[] moltiplicatori)
        {
            // Se le quote per la tipologia immessa sono già state definite, vengono cancellate, quindi ridefinite
            if (_quote.ContainsKey(tipologia))
                _quote.Remove(tipologia);

            var quote = new List<Quota>(moltiplicatori.Length);
            if (moltiplicatori == null) throw new ArgumentNullException("moltiplicatori");
            int i = 0;
            Array valori;

            // A seconda della tipologia si settano le quote
            // Il numero di moltiplicatori passati alla funzione (moltiplicatori.Length) 
            // deve essere uguale al numero di valori della tipologia (valori.Length), 
            // quindi in ogni case si effettua un primo controllo sul numero di moltiplicatori immessi
            // Infine si creano le quote della tipologia e alla fine dello switch si aggiungono al dictionary
            switch (tipologia)
            {
                case Tipologia.UXD:
                    valori = Enum.GetValues(typeof (Tipo1X2.Valori1X2));
                    if (moltiplicatori.Length != valori.Length)
                        throw new ArgumentException("la tipologia selezionata deve avere " + valori.Length + " valori");

                    foreach (Tipo1X2 r in from Tipo1X2.Valori1X2 v in valori select new Tipo1X2(v))
                    {
                        quote.Add(new Quota(this, r, moltiplicatori[i]));
                        i++;
                    }
                    break;

                case Tipologia.UD:
                    valori = Enum.GetValues(typeof (Tipo12.Valori12));
                    if (moltiplicatori.Length != valori.Length)
                        throw new ArgumentException("la tipologia selezionata deve avere " + valori.Length + " valori");

                    foreach (Tipo12 r in from Tipo12.Valori12 v in valori select new Tipo12(v))
                    {
                        quote.Add(new Quota(this, r, moltiplicatori[i]));
                        i++;
                    }
                    break;

                case Tipologia.UO:
                    valori = Enum.GetValues(typeof (TipoUO.ValoriUO));
                    if (moltiplicatori.Length != valori.Length)
                        throw new ArgumentException("la tipologia selezionata deve avere " + valori.Length + " valori");

                    foreach (TipoUO r in from TipoUO.ValoriUO v in valori select new TipoUO(v))
                    {
                        quote.Add(new Quota(this, r, moltiplicatori[i]));
                        i++;
                    }
                    break;

                case Tipologia.GNG:
                    valori = Enum.GetValues(typeof (TipoGNG.ValoriGNG));
                    if (moltiplicatori.Length != valori.Length)
                        throw new ArgumentException("la tipologia selezionata deve avere " + valori.Length + " valori");

                    foreach (TipoGNG r in from TipoGNG.ValoriGNG v in valori select new TipoGNG(v))
                    {
                        quote.Add(new Quota(this, r, moltiplicatori[i]));
                        i++;
                    }
                    break;
            }

            _quote.Add(tipologia, quote);
        }
    }
}