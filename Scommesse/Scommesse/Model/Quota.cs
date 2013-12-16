namespace Scommesse.Model
{
    public class Quota
    {
        public Quota(Evento evento, Risultato valore, float moltiplicatore)
        {
            Evento = evento;
            Valore = valore;
            Moltiplicatore = moltiplicatore;
        }

        public Evento Evento { get; private set; }

        public float Moltiplicatore { get; set; }

        public Risultato Valore { get; private set; }
    }
}