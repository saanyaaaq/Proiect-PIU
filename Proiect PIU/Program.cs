using System;
using RestaurantManagement.Models;

namespace Proiect_PIU
{
    class Program
    {
        static void Main(string[] args)
        {
            ComandaRestaurant[] comenzi = new ComandaRestaurant[100];
            int count = 0;

            while (true)
            {
                Console.WriteLine("1. Adauga comanda");
                Console.WriteLine("2. Afiseaza comenzi");
                Console.WriteLine("3. Cauta comanda");
                Console.WriteLine("4. Iesire");
                Console.Write("Selecteaza o optiune: ");
                int optiune = int.Parse(Console.ReadLine());

                switch (optiune)
                {
                    case 1:
                        if (count < comenzi.Length)
                        {
                            comenzi[count++] = CitesteComanda();
                        }
                        else
                        {
                            Console.WriteLine("Nu se mai pot adauga comenzi.");
                        }
                        break;
                    case 2:
                        AfiseazaComenzi(comenzi, count);
                        break;
                    case 3:
                        CautaComanda(comenzi, count);
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Optiune invalida.");
                        break;
                }
            }
        }

        static ComandaRestaurant CitesteComanda()
        {
            Console.Write("Introdu ID comanda: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Introdu numar persoane: ");
            int numarPersoane = int.Parse(Console.ReadLine());

            Console.Write("Introdu pret total: ");
            double pretTotal = double.Parse(Console.ReadLine());

            Console.Write("Introdu status comanda: ");
            string status = Console.ReadLine();

            Console.Write("Introdu fel principal: ");
            string felPrincipal = Console.ReadLine();

            Console.Write("Introdu garnitura: ");
            string garnitura = Console.ReadLine();

            Console.Write("Introdu bautura: ");
            string bautura = Console.ReadLine();

            Console.Write("Introdu desert: ");
            string desert = Console.ReadLine();

            MenuRestaurant menu = new MenuRestaurant(felPrincipal, garnitura, bautura, desert);
            return new ComandaRestaurant(id, numarPersoane, pretTotal, status, menu);
        }

        static void AfiseazaComenzi(ComandaRestaurant[] comenzi, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(comenzi[i].Info());
            }
        }

        static void CautaComanda(ComandaRestaurant[] comenzi, int count)
        {
            Console.Write("Introdu ID comanda pentru cautare: ");
            int id = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                if (comenzi[i].IDComanda == id)
                {
                    Console.WriteLine(comenzi[i].Info());
                    return;
                }
            }
            Console.WriteLine("Comanda nu a fost gasita.");
        }
    }
}
