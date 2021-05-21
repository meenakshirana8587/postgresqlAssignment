using DepartmentalStoreApp.Data;
using DepartmentalStoreApp.Domain;
using DepartmentalStoreApp.Queries;
using System;

namespace DepartmentalStoreApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //AddData.AddRole();
            //AddData.AddAddress();
            //AddData.InsertIntoProduct();
            //AddData.InsertIntoCategory();
            //AddData.InsertIntoProductCategory();
            //AddData.InsertIntoSupplier();
            //AddData.InsertIntoInventory();
            //AddData.InsertIntoPurchaseOrder();

            DepartmentalStoreQueries dq = new DepartmentalStoreQueries();
            dq.SelectFromStaff();
            dq.SelectFromProduct();
            dq.NumberofProductswithinacategory();
            dq.Listsupplier();
        }

        
    }
}
