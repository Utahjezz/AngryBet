using System;

namespace Scommesse.Model.TipiRisultato
{
    public class TipoUO : Risultato
    {
        #region ValoriUO enum

        public enum ValoriUO
        {
            [StringValue("Under")] Under,
            [StringValue("Over")] Over
        }

        #endregion

        private readonly ValoriUO _value;

        public TipoUO(Enum valore)
        {
            _value = (ValoriUO) valore;
        }

        public override Enum GetValore()
        {
            return _value;
        }
    }
}