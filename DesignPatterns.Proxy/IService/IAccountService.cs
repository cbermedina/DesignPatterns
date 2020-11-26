using DesignPatterns.Proxy.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Proxy.IService
{
  public   interface IAccountService
    {
        Account withdrawals(Account cuenta, double monto);
        Account depositMoney(Account cuenta, double monto);
        void showBalance(Account cuenta);
    }
}
