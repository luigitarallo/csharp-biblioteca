using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Documento
    {
        private string _codice;
        private string _titolo;
        private int _anno;
        private string _settore;
        private Dictionary<string, int> _scaffale;
        private Dictionary<string, string> _autore;

        public string Codice
        {
            get { return _codice; }
            set { _codice = value; }
        }

        public string Titolo
        {
            get { return _titolo; }
            set { _titolo = value; }
        }

        public int Anno
        {
            get { return _anno; }
            set { _anno = value; }
        }

        public string Settore
        {
            get { return _settore; }
            set { _settore = value; }
        }

        public Dictionary<string, int> Scaffale
        {
            get { return _scaffale; }
            set { _scaffale = value; }
        }

        public Dictionary<string, string> Autore
        {
            get { return _autore; }
            set { _autore = value; }
        }

        public Documento(string codice, string titolo, int anno, string settore, Dictionary<string, int> scaffale, Dictionary<string, string> autore)
        {
            _codice = codice;
            _titolo = titolo;
            _anno = anno;
            _settore = settore;
            _scaffale = scaffale;
            _autore = autore;
        }
    }

    class Libro : Documento
    {
        private int _numeroPagine;

        public int NumeroPagine
        {
            get { return _numeroPagine; }
            set { _numeroPagine = value; }
        }
        public Libro(string codice, string titolo, int anno, string settore, Dictionary<string, int> scaffale, Dictionary<string, string> autore, int numeroPagine) : base(codice, titolo, anno, settore, scaffale, autore)
        {
            _numeroPagine = numeroPagine;
        }
    }
    class DVD : Documento
    {
        private int _durata;

        public int Durata 
        { 
            get { return _durata; } 
            set { _durata = value; } 
        }
        
        public DVD(string codice, string titolo, int anno, string settore, Dictionary<string, int> scaffale, Dictionary<string, string> autore, int durata) : base(codice, titolo, anno, settore, scaffale, autore)
        {
            _durata = durata;
        }
    }

}
