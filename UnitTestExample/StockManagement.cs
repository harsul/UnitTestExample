using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestExample
{
    public class StockManagement
    {
        private readonly string m_code;
        private readonly string m_name;
        private double m_stockBalance;

        private StockManagement() { }

        public StockManagement(string code, string name, double balance)
        {
            m_code = code;
            m_name = name;
            m_stockBalance = balance;
        }

        public string Code
        {
            get { return m_code; }
        }
        public string MaterialName
        {
            get { return m_name; }
        }

        public double StockBalance
        {
            get { return m_stockBalance; }
        }

        public void Output(double quantity)
        {
            if (quantity > m_stockBalance)
            {
                throw new ArgumentOutOfRangeException("quantity");
            }

            if (quantity < 0)
            {
                throw new ArgumentOutOfRangeException("quantity");
            }

            m_stockBalance -= quantity;
        }

        public void Receipt(double quantity)
        {
            if (quantity < 0)
            {
                throw new ArgumentOutOfRangeException("quantity");
            }

            m_stockBalance += quantity;
        }
    }

}
