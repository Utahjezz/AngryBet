using System.Collections.Generic;

namespace Scommesse.Model
{
    public class Categoria
    {
        private readonly List<Competizione> _competizioni;
        private readonly string _nome;
        private readonly List<Tipologia> _tipologie;

        public Categoria(string nome)
        {
            _nome = nome;
            _competizioni = new List<Competizione>();
            _tipologie = new List<Tipologia>();
        }

        public string Nome
        {
            get { return _nome; }
        }

        public void AddCompetizione(Competizione competizione)
        {
            _competizioni.Add(competizione);
        }

        public void RemoveCompetizione(Competizione competizione)
        {
            _competizioni.Remove(competizione);
        }

        public List<Competizione> GetCompetizioni()
        {
            return _competizioni;
        }

        public void AddTipologia(Tipologia tipologia)
        {
            _tipologie.Add(tipologia);
        }

        public void RemoveTipologia(Tipologia tipologia)
        {
            _tipologie.Remove(tipologia);
        }

        public List<Tipologia> GetTipologie()
        {
            return _tipologie;
        }
    }
}