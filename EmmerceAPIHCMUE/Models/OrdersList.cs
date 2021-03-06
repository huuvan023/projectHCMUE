﻿using EmmerceAPIHCMUE.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmmerceAPIHCMUE.Models
{
    public class OrdersList
    {
        private string IdOrderList;
        private string IdOrder;
        private string IdUser;
        private List<MultipleProduct> Products;
        public string idOrderList { get => IdOrderList; set => IdOrderList = value; }
        public string idOrder { get => IdOrder; set => IdOrder = value; }
        public string idUser { get => IdUser; set => IdUser = value; }

        public List<MultipleProduct> products { get => Products; set => Products = value; }

        public bool AddCheckout()
        {
            string idOder = Helper.Instance.CreateRandomPassword(10);
            int totalPrice = 0;

            string queryinitOrderDetail = "insert into dbo.odersDetails values('" + idOder + "','" + DateTime.UtcNow.ToString() + "','" + Constants.Instance.INITIAL_STT1 + "',0,'" + this.idUser + "')";

            if (Connection.Instance.ExecuteNonQuery(queryinitOrderDetail) < 1)
            {
                return false;
            }
            foreach (MultipleProduct item in this.products)
            {
                string query1 = "insert into odersList values('" + Helper.Instance.CreateRandomPassword(6) + "','" + idOder + "','" + this.idUser + "','" + item.idProduct + "', '" + item.quanlity + "')";
                if (Connection.Instance.ExecuteNonQuery(query1) == 1)
                {
                    string queryGetProduct = "select price from dbo.products where idProduct='" + item.idProduct + "'";
                    string localPrice = (string) Connection.Instance.ExecuteScalar(queryGetProduct);
                    totalPrice += Int32.Parse(localPrice) * item.quanlity;
                    continue;
                }
                else
                {
                    return false;
                }
            }
            string updateOrderDetail = "update dbo.odersDetails set totalPrice = " + totalPrice + " where idOder = '" + idOder + "'";
            if (Connection.Instance.ExecuteNonQuery(updateOrderDetail) == 1)
            {
                return true;
            }
            return false;
        }
        public bool UpdateStatusCheckout()
        {
            string query = "update dbo.odersDetails set status = status + 1 where idOder = '"+this.idOrder+"'";
            if (Connection.Instance.ExecuteNonQuery(query) == 1)
            {
                return true;
            }
            return false;
        }
    }
    public class MultipleProduct
    {
        private string IdProduct;
        private int Quanlity;
        public string idProduct { get => IdProduct; set => IdProduct = value; }
        public int quanlity { get => Quanlity; set => Quanlity = value; }
    }
}
