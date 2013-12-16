using System;

namespace Scommesse.Model.TipiRisultato
{
    public class Tipo12 : Risultato
    {
        #region Valori12 enum

        public enum Valori12
        {
            [StringValue("1")] Uno,
            [StringValue("2")] Due
        }

        #endregion

        private readonly Valori12 _value;

        public Tipo12(Enum valore)
        {
            _value = (Valori12) valore;
        }

        public override Enum GetValore()
        {
            return _value;
        }
    }
}