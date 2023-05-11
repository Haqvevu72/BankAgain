using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Bank
    {

        public string? Name { get; set; }
        public double Budget { get; set; }
        public double Profit { get; set; }
        public CEO cEO { get; set; }
        public List<Worker> Workers{ get; set; }
        public List<Manager> Managers { get; set; }
        public List<Client> Clients { get; set; }

        public Bank(string? name, double budget, double profit, CEO cEO, List<Worker> workers, List<Manager> managers, List<Client> clients)
        {
            Name = name;
            Budget = budget;
            Profit = profit;
            this.cEO = cEO;
            Workers = workers;
            Managers = managers;
            Clients = clients;
        }

        // Show client credit
        public void ShowClientCredit() {
            string? name , surname;

            Console.Write("Client Name: ");
            name = Console.ReadLine();

            Console.Write("Client Surname: ");
            surname = Console.ReadLine();

            foreach (var item in Clients) {
                if (item.Name == name && item.Surname==surname) {
                    Console.WriteLine(item);
                }
            }

        }
        public void PayCredit() {
            string? name, surname;
            double amount;
            Console.Write("Client Name: ");
            name = Console.ReadLine();

            Console.Write("Client Surname: ");
            surname = Console.ReadLine();

            Console.Write("Pay Amount: ");
            amount = int.Parse(Console.ReadLine()??"0");
            for (int i = 0; i < Clients.Count; i++) {
                if (Clients[i].Name == name && Clients[i].Surname == surname) {
                    if (Clients[i].Credit.Amount >= amount)
                        Clients[i].Credit.Amount -= amount;
                    else
                        Console.WriteLine("Your credit debt has paid");

                }
            }
        }
        public void ShowAllCredit() {
            foreach(var item in Clients)
                Console.WriteLine(item.ToString()+"\n"+item.Credit.ToString());
        }
    }
}
