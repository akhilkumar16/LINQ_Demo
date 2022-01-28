using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LinqDemo
{
    class LinqToDataTable
    {
        public void AddDataTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("ProductName");

            table.Rows.Add("1", "akhil");
            table.Rows.Add("2", "kumar");
            table.Rows.Add("3", "ch");
            DisplayProducts(table);
        }
        public void DisplayProducts(DataTable table)
        {
            var ProductNames = from Products in table.AsEnumerable() select Products.Field<string>("ProductName");
            Console.WriteLine("Product Names:");
            foreach(string ProductsName in ProductNames)
            {
                Console.WriteLine(ProductsName);
            }
        }
    }
}
