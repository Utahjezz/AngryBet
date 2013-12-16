using System.Collections.Generic;

namespace Scommesse.Model
{
     public abstract class ScommessaAstratta
     {
        protected ScommessaAstratta()
        {
        }
        protected ScommessaAstratta(ScommessaAstratta scommessaAstratta)
        {
            Importo = scommessaAstratta.Importo;
            Puntate = scommessaAstratta.Puntate;
            ScommessaController = scommessaAstratta.ScommessaController;
        }

        public float Importo { get; protected set; }

        public List<Quota> Puntate { get; protected set; }

        public ScommessaController ScommessaController { get; protected set; }

        public bool ContainsPuntata(Quota quota)
        {
            return Puntate.Contains(quota);
        }

        protected abstract bool Controllabile();

        public abstract void ControllaScommessa(ScommessaController controller);
    }
}