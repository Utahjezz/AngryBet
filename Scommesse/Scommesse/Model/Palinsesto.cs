using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Scommesse.Model
{
    [Serializable]
    public class Palinsesto
    {
        private String nome;

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private readonly List<Categoria> _categorie;
        public Palinsesto(String nome)
        {
            _categorie = new List<Categoria>();
        }

        public bool AggiungiCategoria(Categoria categoria)
        {
            if (!ContieneCategoria(categoria))
            {
                _categorie.Add(categoria);
                return true;
            }
            return false;
        }

        public bool RemoveCategoria(Categoria categoria)
        {
            if(ContieneCategoria(categoria))
            {
                _categorie.Remove(categoria);
                return true;
            }
            return false;
        }

        public bool ContieneCategoria(Categoria categoria)
        {
           return _categorie.Contains(categoria);
        }
    }
}
