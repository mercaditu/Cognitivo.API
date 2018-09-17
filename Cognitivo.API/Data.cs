using System;
using System.Collections.Generic;

namespace Cognitivo.API.Data
{
    /// <summary>
    /// List of Tables that are not updated as often, and mostly used as reference to the Transactional Data.
    /// </summary>
    public class Base
    {
        List<Models.Account> Accounts { get; set; }
        List<Models.Company> Companies { get; set; }
        List<Models.Customer> Customers { get; set; }
        public List<Models.Item> Items { get; set; }
        List<Models.ItemCategory> ItemCategories { get; set; }
        List<Models.ItemPriceList> ItemPriceLists { get; set; }

        List<Models.Location> Locations { get; set; }
        List<Models.PaymentContract> PaymentContracts { get; set; }
        List<Models.PaymentContractDetail> PaymentContractDetails { get; set; }
        List<Models.PaymentType> PaymentTypes { get; set; }
        List<Models.PointOfSale> PointOfSales { get; set; }
        List<Models.Range> Ranges { get; set; }
        List<Models.Supplier> Suppliers { get; set; }
        List<Models.User> Users { get; set; }

        List<Models.Vat> Vats { get; set; }
        List<Models.VatDetail> VatDetails { get; set; }
    }

    /// <summary>
    /// List of Tables that get updated regurarly.
    /// </summary>
    public class Transactional
    {
        List<Models.AccountMovement> AccountMovements { get; set; }
        List<Models.ItemMovement> ItemMovements { get; set; }
        List<Models.Sales> Sales { get; set; }
        List<Models.Purchase> Purchases { get; set; }
    }
}
