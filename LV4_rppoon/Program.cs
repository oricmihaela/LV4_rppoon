using LV4_rppoon.Dekorater;
using LV4_rppoon.Fasada;
using System;
using System.Collections.Generic;

namespace LV4_rppoon
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Zadatak
            Console.WriteLine("Ovo je 2. zadatak.");
            Dataset newDataset = new Dataset("csv.txt");
            Analyzer3rdParty newAnalyzer = new Analyzer3rdParty();
            Adapter newAdapter = new Adapter(newAnalyzer);
            double[] averageRows = newAdapter.CalculateAveragePerRow(newDataset);
            Console.WriteLine("Prosjek redaka:");
            for (int i = 0; i < averageRows.Length; i++)
            {
                Console.WriteLine(averageRows[i]);
            }
            double[] averageColumns = newAdapter.CalculateAveragePerColumn(newDataset);
            Console.WriteLine("Prosjek stupaca:");
            for (int i = 0; i < averageColumns.Length; i++)
            {
                Console.WriteLine(averageColumns[i]);
            }

            //3. Zadatak
            Console.WriteLine("Ovo je 3. zadatak.");
            List<IRentable> BooksAndMovies = new List<IRentable>();
            Book bookExample = new Book("Ana Karenjina");
            Video videoExample = new Video("Rat i mir");
            BooksAndMovies.Add(bookExample);
            BooksAndMovies.Add(videoExample);
            RentingConsolePrinter printerExample = new RentingConsolePrinter();
            printerExample.PrintTotalPrice(BooksAndMovies);
            printerExample.DisplayItems(BooksAndMovies);

            //4. Zadatak
            Console.WriteLine("Ovo je 4. zadatak.");
            HotItem newestBook = new HotItem(new Book("Stranac"));
            HotItem newestVideo = new HotItem(new Video("Parazit"));
            BooksAndMovies.Add(newestBook);
            BooksAndMovies.Add(newestVideo);
            printerExample.PrintTotalPrice(BooksAndMovies);
            printerExample.DisplayItems(BooksAndMovies);
            /* Cijena liste sa samo prva dva elementa bila je 13.98. Dodavanje jos 
               elementa cijena bi trebala biti 27.96. Međutim, dodani asortiman
               pripada HitItem-ima pa je cijena veća -> 31.94. Također uz naslove 
               stoji naznaka da artikl pripada Trendingu.*/

            //5. Zadatak
            Console.WriteLine("Ovo je 5. zadatak.");
            List<IRentable> flashSale = new List<IRentable>();

            for (int i = 0; i < 4; i++)
            {
                flashSale.Add(new DiscountedItem(BooksAndMovies[i], 20));
            }
            printerExample.PrintTotalPrice(flashSale);
            printerExample.DisplayItems(flashSale);


            //6. zadatak
            Console.WriteLine("Ovo je 6. zadatak.");
            string myMail = "mihaela.oric@gmail.com";
            string myPass = "R3aD.now";
            EmailValidator mailValidator = new EmailValidator();
            PasswordValidator passValidator = new PasswordValidator(8);
            if (mailValidator.IsValidAddress(myMail))
            {
                Console.WriteLine("Vasa eMail adresa" + myMail + "je ispravna.");
            }
            else
            {
                Console.WriteLine("Vasa eMail adresa " + myMail + " nije ispravna.");
            }
            if (passValidator.IsValidPassword(myPass))
            {
                Console.WriteLine("Vasa lozinka je ispravna.");
            }
            else
            {
                Console.WriteLine("Vasa lozinka nije ispravna.");
            }

            //7. Zadatak
            Console.WriteLine("Ovo je 7. zadatak.");
            //UserEntry.ReadUserFromConsole();
            RegistrationValidator finalValidator = new RegistrationValidator();
            UserEntry entry = UserEntry.ReadUserFromConsole();
            while(!(finalValidator.IsUserEntryValid(entry)))
            {
                entry = UserEntry.ReadUserFromConsole();
            }

        }
    }
}
