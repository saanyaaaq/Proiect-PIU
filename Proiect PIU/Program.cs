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
            Console.Write("Introdu ID comandei: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Introdu Numarul Mesei: ");
            int numarPersoane = int.Parse(Console.ReadLine());

            Console.Write("Introdu Pretul Total: ");
            double pretTotal = double.Parse(Console.ReadLine());

            Console.Write("Introdu Statusul Comanda: ");
            string status = Console.ReadLine();

            Console.Write("Introdu Felul Principal: ");
            string felPrincipal = Console.ReadLine();

            Console.Write("Introdu Garnitura: ");
            string garnitura = Console.ReadLine();

            Console.Write("Introdu Bautura: ");
            string bautura = Console.ReadLine();

            Console.Write("Introdu Desertul: ");
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
