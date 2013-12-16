using System;

namespace Scommesse.Model.TipiRisultato
{
    public class TipoGNG : Risultato
    {
        #region ValoriGNG enum

        public enum ValoriGNG
        {
            [StringValue("Goal")] Goal,
            [StringValue("NoGoal")] NoGoal
        }

        #endregion

        private readonly ValoriGNG _value;

        public TipoGNG(Enum valore)
        {
            _value = (ValoriGNG) valore;
        }

        public override Enum GetValore()
        {
            return _value;
        }
    }
}