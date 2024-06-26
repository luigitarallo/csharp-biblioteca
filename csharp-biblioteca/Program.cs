﻿namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creazione Utenti

            Utente utente1 = new Utente("Tarallo", "Luigi", "gigi@esempio.it", "123pass", "23123323");
            Utente utente2 = new Utente("Rossi", "Michele", "mik@esempio.it", "123445pas", "123123323");
            Utente utente3 = new Utente("Bianchi", "Francesco", "francy@esempio.it", "123421pas", "123132132");

            //Creazione documenti
            Libro libro1 = new Libro(
                "1234",
                "Cuore", 1900, "Letteratura",
                new Dictionary<string, int> { { "A1", 1 } },
                new Dictionary<string, string> { { "Edmondo" , "De Amicis" } },
                200);
            DVD dvd1 = new DVD("12345",
                "Jurassic Park",
                1999,
                "fantascienza",
                new Dictionary<string, int> { { "F1", 2 } },
                new Dictionary<string, string> { { "Steven", "Spielberg"},
                },123);

            Libro libro2 = new Libro(
                "1342",
                "Il Signore degli anelli",1954, "Fantasy",
                new Dictionary<string, int> { { "A2", 2 } },
                new Dictionary<string, string> { { "J.J.R.", "Tolkien" } },
                1400
                );

            DVD dvd2 = new DVD("3231", "Her", 2013, "Sci-fi",
                new Dictionary<string, int> { { "F2", 3 } },
                new Dictionary<string, string> { { "Spike ", "Jonze" } },
                180);

            Biblioteca biblioteca = new Biblioteca();

            biblioteca.AggiungiUtente(utente1);
            biblioteca.AggiungiUtente(utente2);
            biblioteca.AggiungiUtente(utente3);

            biblioteca.AggiungiDocumento(libro1);
            biblioteca.AggiungiDocumento(libro2);
            biblioteca.AggiungiDocumento(dvd2);
            
            // Creazione prestiti

            biblioteca.RegistraPrestito(new Prestito(utente1, libro1, DateTime.Today, DateTime.Today.AddDays(14)), utente1, libro1, DateTime.Today, DateTime.Today.AddDays(14));
            biblioteca.RegistraPrestito(new Prestito(utente2, dvd1, DateTime.Today.AddDays(1), DateTime.Today.AddDays(8)), utente2, dvd1, DateTime.Today.AddDays(1), DateTime.Today.AddDays(8));

            // Ricerca di documenti per titolo
            Console.WriteLine("Ricerca di documenti per titolo:");
            var risultatiTitolo = biblioteca.CercaDocumentoPerTitolo("Cuore");
            foreach (var doc in risultatiTitolo)
            {
                Console.WriteLine($"Titolo: {doc.Titolo}, Anno: {doc.Anno}");
            }
            Console.WriteLine();

            // Ricerca di documenti per codice
            Console.WriteLine("Ricerca di documenti per codice:");
            var risultatiCodice = biblioteca.CercaDocumentoPerCodice("12345");
            foreach (var doc in risultatiCodice)
            {
                Console.WriteLine($"Titolo: {doc.Titolo}, Anno: {doc.Anno}");
            }
            Console.WriteLine();

            Console.WriteLine("Ricerca di prestiti per utente:");
            var risultatiPrestiti = biblioteca.CercaPrestitiPerUtente("Luigi", "Tarallo");
            foreach (var prestito in risultatiPrestiti)
            {
                Console.WriteLine($"Utente: {prestito.Utente.Nome} {prestito.Utente.Cognome}, Documento: {prestito.Documento.Titolo}, Data inizio: {prestito.DataInizio}, Data fine: {prestito.DataFine}");
            }
            Console.WriteLine();
        }
    }
}
