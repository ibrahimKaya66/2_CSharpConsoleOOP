using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_OOPEft
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<BankAccount> Accounts { get; set; } = new List<BankAccount>();
        public Customer()
        {

        }

        public Customer(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public Customer(string name, string surname,BankAccount account):this(name, surname)
        {
            Accounts.Add(account);
            account.Customer = this;
        }
        public void EftSend(BankAccount sender_account,BankAccount receiver_account,decimal balance)
        {
            var account = this.Accounts.FirstOrDefault(i=>i.Iban == sender_account.Iban);
            if (account == null)
            {
                Console.WriteLine("Müşterinin böyle bir hesabı yok");
                return;
            }
                
            if (balance > account.Balance)
            {
                Console.WriteLine("Yetersiz Bakiye");
                return;
            }
            Console.WriteLine($"EFT\nGönderen Bilgileri\n{sender_account}\nBakiye:{balance}\nAlıcı Bilgileri\n{receiver_account}");
        }
    }
}
