using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApps
{
    class Product
    {
        private static decimal DEF_DLVCHARGE = 25;
        private static decimal DEF_WRAPCHARGE = 5;
        private static decimal DEF_GSTMULT = 1.1m;

        private decimal price;
        private int quantity;
        private decimal totalPayment;
        private decimal totalPaymentIncDlv;
        private decimal totalPaymentIncWrap;
        private decimal totalPaymentAfterGST;
        private decimal delivery;
        private decimal wrapping;
        private decimal gst;

        private decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        private int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public decimal TotalPayment
        {
            get { return totalPayment; }
            set { totalPayment = value; }
        }


        private decimal Delivery
        {
            get { return delivery; }
            set { delivery = value; }
        }


        private decimal Wrapping
        {
            get { return wrapping; }
            set { wrapping = value; }
        }

        private decimal GST
        {
            get { return gst; }
            set { gst = value; }
        }

        public decimal TotalPaymentIncDlv {
            get { return totalPaymentIncDlv; }
            set { totalPaymentIncDlv = value; }
        }

        public decimal TotalPaymentIncWrap { get => totalPaymentIncWrap; set => totalPaymentIncWrap = value; }
        public decimal TotalPaymentAfterGST { get => totalPaymentAfterGST; set => totalPaymentAfterGST = value; }

        //Constructor for Product
        public Product(decimal price, int quantity)
        {
            Price = price;
            Quantity = quantity;
        }

        //Calculate the total payment
        public void calTotalPayment()
        {
            TotalPayment = Price * Quantity;
            TotalPaymentIncDlv = totalPayment + DEF_DLVCHARGE;
            TotalPaymentIncWrap = TotalPaymentIncDlv + DEF_WRAPCHARGE;
            TotalPaymentAfterGST = TotalPaymentIncWrap * DEF_GSTMULT;
        }

        
    }
}
