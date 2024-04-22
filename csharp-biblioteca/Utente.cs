using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Utente
    {
        private string _cognome;
        private string _nome;
        private string _email;
        private string _password;
        private string _telefono;

        public string Cognome {  get { return _cognome; } set { _cognome = value; } }
        public string Nome { get { return _nome; } set { _nome = value; } }

        public string Email { get { return _email; } set { _email = value; } }

        public string Password { set { _password = value; } }

        public string Telefono { get { return _telefono; } set { _telefono = value; } }

        public Utente(string cognome, string nome, string email, string password, string telefono)
        {
            _cognome = cognome;
            _nome = nome;
            _email = email;
            _password = password;
            _telefono = telefono;
        }
    }

    
}
