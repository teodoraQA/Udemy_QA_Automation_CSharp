using System;
using System.Collections.Generic;
using System.Text;

namespace Retail_Store_Exam
{
    class Receipt
    {

        //description, unit price, and quantity purchased.  Create private class variables and the necessary Properties.
        private int receiptNumber;
        private string dateOfPurchase;
        private int customerNumber;
        private string customerName;
        private string customerAdress;
        private string phoneNumber;
        private int itemNumber;
        private string itemDescription;
        private decimal unitPrice;
        private int qtyPurchased;

        public int ReceiptNumber
        {
            get { return receiptNumber; }
            set
            {
                if (value > 0) { receiptNumber = value; }
                else { Console.WriteLine("Error: customer number should be more than 0!"); }
            }
        }

        public string DateOfPurchase
        {
            get; set;
        }

        public int CustomerNumber
        {
            get { return customerNumber; }
            set
            {
                if (value > 0) { customerNumber = value; }
                else { Console.WriteLine("Error: customer number should be more than 0!"); }
            }
        }

        public string CustomerName
        {
            get; set;
        }

        public string CustomerAdress
        {
            get; set;
        }

        public string PhoneNumber
        {
            get; set;
        }

        public int ItemNumber
        {
            get { return itemNumber; }
            set
            {
                if (value > 0 && value < 9999) { itemNumber = value; }
                else { Console.WriteLine("Error: item number should be more than 0 and less than 9999!"); }
            }
        }

        public string ItemDescription { get; set; }
        public decimal UnitPrice
        {
            get { return unitPrice; }
            set
            {
                if (value > 0 && value < 9999) { unitPrice = value; }
                else { Console.WriteLine("Error: price should be more than 0 and less than 9999!"); }
            }
        }

        public int QtyPurchased
        {
            get { return qtyPurchased; }
            set
            {
                if (value > 0) { qtyPurchased = value; }
                else { Console.WriteLine("Error: quantity should be more than 0!"); }
            }
        }

        public Receipt(int receiptNum, string date, int customerID, string customerName, string customerAdress, string phoneNum, int itemNum,
            string itemDescription, decimal price, int qty)
        {
            ReceiptNumber = receiptNum;
            DateOfPurchase = date;
            CustomerNumber = customerID;
            CustomerName = customerName;
            CustomerAdress = customerAdress;
            PhoneNumber = phoneNum;
            ItemNumber = itemNum;
            ItemDescription = itemDescription;
            UnitPrice = price;
            QtyPurchased = qty;

        }

        public decimal CalculateTotalCost()
        {
            return qtyPurchased * unitPrice;
        }

        public override string ToString()
        {

            return $"Customer {CustomerName}" +
                $"\nPhone: {PhoneNumber}" +
                $"\nTotal Purchases: {CalculateTotalCost():C2}";
        }
    }
}
