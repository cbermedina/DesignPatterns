using DesignPatterns.Proxy.Classes;
using DesignPatterns.Proxy.IService;
using DesignPatterns.Proxy.Service;
using System;

namespace DesignPatterns.Proxy.Proxy
{
    public class AccountProxy : IAccountService
    {
        private IAccountService _cuentaReal;
        public AccountProxy(IAccountService cuentaReal)
        {
            this._cuentaReal = cuentaReal;
        }
        public Account withdrawals(Account cuenta, double monto)
        {
            Console.WriteLine("----Cuenta Proxy - Retirar Dinero----");
            if (_cuentaReal == null)
            {
                _cuentaReal = new AccountBankAImplService();
                return _cuentaReal.withdrawals(cuenta, monto);
            }
            else
            {
                return _cuentaReal.withdrawals(cuenta, monto);
            }
        }
        public Account depositMoney(Account cuenta, double monto)
        {
            Console.WriteLine("----Cuenta Proxy - Depositar Dinero----");
            if (_cuentaReal == null)
            {
                _cuentaReal = new AccountBankAImplService();
                return _cuentaReal.depositMoney(cuenta, monto);
            }
            else
            {
                return _cuentaReal.depositMoney(cuenta, monto);
            }
        }
        public void showBalance(Account cuenta)
        {
            Console.WriteLine("----Cuenta Proxy - Mostrar Dinero----");
            if (_cuentaReal == null)
            {
                _cuentaReal = new AccountBankAImplService();
                _cuentaReal.showBalance(cuenta);
            }
            else
            {
                _cuentaReal.showBalance(cuenta);
            }
        }
    }
}
