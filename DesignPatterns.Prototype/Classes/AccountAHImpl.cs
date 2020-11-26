namespace DesignPatterns.Prototype.Classes
{
    using System;
    public class AccountAHImpl : IAccount
    {

        private String type;
        private double amount;

        public AccountAHImpl()
        {
            type = "AHORRO";
        }
        public IAccount clone()
        {
               return (AccountAHImpl)MemberwiseClone();
        }
        public String toString()
        {
            return $"CuentaAHImpl [tipo={type}, monto={amount}]";
        }

        public void setAmount(double monto)
        {
            this.amount = monto;
        }
        public double getAmount()
        {
            return amount;
        }
    }
}
