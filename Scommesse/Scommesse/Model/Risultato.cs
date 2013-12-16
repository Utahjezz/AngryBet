using System;

namespace Scommesse.Model
{
    public abstract class Risultato
    {
        public abstract Enum GetValore();

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            Risultato r = (Risultato) obj;
            return GetValore() == r.GetValore();
        }

        public override int GetHashCode()
        {
           return GetType().GetHashCode();
        }
    }
}