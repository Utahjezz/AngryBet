using System;
using System.Collections.Generic;

namespace Scommesse.Model
{
    public class Competizione
    {
        private readonly List<Evento> _eventi;
        private readonly string _nome;
        private DateTime _dataFine = DateTime.MaxValue;
        private DateTime _dataInizio = DateTime.MinValue;

        public Competizione(string nome, DateTime dataInizio, DateTime dataFine)
        {
            if (nome == null) throw new ArgumentNullException("nome");
            _nome = nome;
            _dataInizio = dataInizio;
            _dataFine = dataFine;
        }

        public Competizione(string nome, List<Evento> eventi)
        {
            if (nome == null) throw new ArgumentNullException("nome");
            if (eventi == null) throw new ArgumentNullException("eventi");
            _nome = nome;
            _eventi = eventi;
            foreach (Evento evento in _eventi)
                CheckDate(evento);
        }

        public string Nome
        {
            get { return _nome; }
        }

        private void CheckDate(Evento evento)
        {
            if (_dataInizio.CompareTo(evento.DataOra) > 0)
                _dataInizio = evento.DataOra;
            if (_dataFine.CompareTo(evento.DataOra) < 0)
                _dataFine = evento.DataOra;
        }

        public void AddEvento(Evento evento)
        {
            if (evento == null) throw new ArgumentNullException("evento");
            _eventi.Add(evento);
            CheckDate(evento);
        }

        public void RemoveEvento(Evento evento)
        {
            if (evento == null) throw new ArgumentNullException("evento");
            _eventi.Remove(evento);
            _dataInizio = DateTime.MinValue;
            _dataFine = DateTime.MaxValue;
            foreach (Evento e in _eventi)
                CheckDate(e);
        }

        public DateTime DataInizio()
        {
            return _dataInizio;
        }

        public DateTime DataFine()
        {
            return _dataFine;
        }

        public List<Evento> GetEventi()
        {
            return _eventi;
        }
    }
}