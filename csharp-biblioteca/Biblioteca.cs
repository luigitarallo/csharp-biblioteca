using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Biblioteca
    {
        private List<Utente> utenti = new List<Utente>();
        private List<Documento> documenti = new List<Documento>();
        private List<Prestito> prestiti = new List<Prestito>();

        public void AggiungiUtente(Utente utente)
        {
            utenti.Add(utente);
        }

        public void AggiungiDocumento(Documento documento)
        {
            documenti.Add(documento);
        }

        public void RegistraPrestito(Prestito prestito, Utente utente, Documento documento, DateTime dataInizio, DateTime dataFine)
        {
            prestito.Utente = utente;
            prestito.Documento = documento;
            prestito.DataInizio = dataInizio;
            prestito.DataFine = dataFine;
            prestiti.Add(prestito);
        }
        public List<Documento> CercaDocumentoPerTitolo(string titolo)
        {
            List<Documento> risultati = new List<Documento>();

            foreach (Documento documento in documenti)
            {
                if (documento.Titolo.ToLower().Contains(titolo.ToLower()))
                {
                    risultati.Add(documento);
                }
            }

            return risultati;
        }

        public List<Documento> CercaDocumentoPerCodice(string codice)
        {
            List<Documento> risultati = new List<Documento>();

            foreach (Documento documento in documenti)
            {
                if (documento.Codice.ToLower() == codice.ToLower())
                {
                    risultati.Add(documento);
                }
            }

            return risultati;
        }

        public List<Prestito> CercaPrestitiPerUtente(string nome, string cognome)
        {
            List<Prestito> risultati = new List<Prestito>();

            foreach (Prestito prestito in prestiti)
            {
                if (prestito.Utente.Nome.ToLower() == nome.ToLower() && prestito.Utente.Cognome.ToLower() == cognome.ToLower())
                {
                    risultati.Add(prestito);
                }
            }

            return risultati;
        }

        public List<Utente> CercaUtenti()
    }
}
