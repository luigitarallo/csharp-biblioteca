using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Prestito
    {
        private Utente _utente;
        private Documento _documento;
        private DateTime _dataInizio;
        private DateTime _dataFine;

        public Utente Utente
        {
            get { return _utente; }
            set { _utente = value; }
        }

        public Documento Documento
        {
            get { return _documento; }
            set { _documento = value; }
        }
        public DateTime DataInizio
        {
            get { return _dataInizio; }
            set { _dataInizio = value; }
        }

        public DateTime DataFine
        {
            get { return _dataFine; }
            set { _dataFine = value; }
        }

        public Prestito(Utente utente, Documento documento, DateTime dataInizio, DateTime dataFine)
        {
            _utente = utente;
            _documento = documento;
            _dataInizio = dataInizio;
            _dataFine = dataFine;
        }
    }
}
