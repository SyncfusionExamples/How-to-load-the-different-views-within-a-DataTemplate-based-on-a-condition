
using Syncfusion.Maui.Data;
using System.Collections.ObjectModel;

namespace MauiApp1
{
    public class OrderInfoRepository 
    {

        private ObservableCollection<OrderInfo> orderInfo;

        public ObservableCollection<OrderInfo> OrderInfoCollection
        {
            get { return orderInfo; }
            set
            {
                this.orderInfo = value;
            }
        }
        public OrderInfoRepository()
        {
            orderInfo = new ObservableCollection<OrderInfo>();
            this.GenerateOrders();
        }

        public void GenerateOrders()
        {
            orderInfo.Add(new OrderInfo(1001, "Maria Anders", "Germany", "ALFKI", "Berlin", new DateTime(2024, 2, 10), 15000, true));
            orderInfo.Add(new OrderInfo(1002, "Emma Johnson", "Mexico", "ANATR", "Mexico D.F.", null, 12000, false));
            orderInfo.Add(new OrderInfo(1003, "Andrea Rossi", "Mexico", "ANTON", "Mexico D.F.", new DateTime(2024, 1, 15), 16000, true));
            orderInfo.Add(new OrderInfo(1004, "Thomas Hardy", "UK", "BERGS", "London", new DateTime(2023, 10, 15), 14000, true));
            orderInfo.Add(new OrderInfo(1005, "Sophie Dubois", "Germany", "BLAUS", "Mannheim", null, 22000, false));
            orderInfo.Add(new OrderInfo(1006, "John Smith", "USA", "BSBEV", "New York", new DateTime(2023, 12, 15), 18000, true));
            orderInfo.Add(new OrderInfo(1007, "Anna Müller", "Germany", "HANAR", "Berlin", null, 20000, false));
            orderInfo.Add(new OrderInfo(1008, "Yoshi Tanaka", "Japan", "HILAA", "Tokyo", new DateTime(2023, 10, 10), 16000, true));
            orderInfo.Add(new OrderInfo(1009, "Paula Wilson", "Canada", "WELLI", "Vancouver", new DateTime(2023, 9, 25), 19000, true));
            orderInfo.Add(new OrderInfo(1010, "Miguel Ángel", "Spain", "LAZYK", "Madrid", null, 22000, false));
        }
    }
}
