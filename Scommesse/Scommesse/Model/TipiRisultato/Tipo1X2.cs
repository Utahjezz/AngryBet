using System;

namespace Scommesse.Model.TipiRisultato
{
    public class Tipo1X2 : Risultato
    {
        #region Valori1X2 enum

        public enum Valori1X2
        {
            [StringValue("1")] Uno,
            [StringValue("X")] X,
            [StringValue("2")] Due
        }

        #endregion

        private readonly Valori1X2 _value;

        public Tipo1X2(Enum valore)
        {
            _value = (Valori1X2) valore;
        }

        public override Enum GetValore()
        {
            return _value;
        }
    }
}