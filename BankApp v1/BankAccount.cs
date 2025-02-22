using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp_v1
{
    public class BankAccount
    {
        public string Owner { get; set; }
        public Guid AccountNum { get; set; }
        public decimal Balance { get; private set; }

        public BankAccount(string owner)
        {
            this.Owner = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(owner);
            AccountNum = Guid.NewGuid();
            Balance = 0;
        }

        public string Deposit(decimal amount)
        {
            if(amount <= 0)
                return "You can not deposit $" + amount;
            if (amount > 20000)
                return "ATM deposit limit reached";

            Balance += amount;
            return "Deposit completed successfully.";
        }

        public string Withdraw(decimal amount)
        {
            if (amount <= 0)
                return "You can not withdraw $" + amount;
            if (amount > Balance)
                return "You do not have enough money.";

            Balance -= amount;
            return "Wthdraw complete successfully";
        }
    }
}
