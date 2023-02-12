using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_OOPEft
{
    internal class BankAccount
    {
        public Customer Customer { get; set; }
        public string BankName { get; set; }
        public string Iban { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(string bankname, string ıban,decimal balance)
        {
            this.BankName = bankname;
            this.Iban = ıban;
            this.Balance = balance;
        }

        public BankAccount(Customer customer,string bankname, string ıban, decimal balance):this(bankname,ıban,balance)
        {
            this.Customer = customer;
        }

        public void AddBalance(decimal balance)
        {
            this.Balance += balance;
        }

        public override string ToString()
        {
            return $"Ad:{this.Customer.Name}\nSurname: {this.Customer.Surname}\nIban:{this.Iban}\nBankası:{this.BankName}";
        }
    }
}
