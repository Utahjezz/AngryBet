using System;

namespace Scommesse.Model
{
    [Serializable]
    public class Cliente
    {
        public Cliente(string nome, string cognome, DateTime dataNascita, string cf)
        {
            if (nome == null) throw new ArgumentNullException("nome");
            if (cognome == null) throw new ArgumentNullException("cognome");
            if (cf == null) throw new ArgumentNullException("cf");
            Nome = nome;
            Cognome = cognome;
            DataNascita = dataNascita;
            CodiceFiscale = cf;
        }

        public Cliente(string nome, string cognome, DateTime dataNascita, string cf, string indirizzo)
            : this(nome, cognome, dataNascita, cf)
        {
            if (indirizzo == null) throw new ArgumentNullException("indirizzo");
            Indirizzo = indirizzo;
        }

        public Cliente(string nome, string cognome, DateTime dataNascita, string cf, string indirizzo, string telefono)
            : this(nome, cognome, dataNascita, cf, indirizzo)
        {
            if (telefono == null) throw new ArgumentNullException("telefono");
            Telefono = telefono;
        }

        public string Nome { get; private set; }
        public string Cognome { get; private set; }
        public DateTime DataNascita { get; private set; }
        public string Indirizzo { get; private set; }
        public string CodiceFiscale { get; private set; }
        public string Telefono { get; private set; }
    }
}