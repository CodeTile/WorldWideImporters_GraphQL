namespace WWI_graph_ql.GraphQL
{
    using HotChocolate;
    using HotChocolate.Data;
    using System.Linq;
    using WWI.Data.Context;
    using WWI.Data.Models;

    /// <summary>
    /// Represents the queries available.
    /// </summary>
    [GraphQLDescription("Represents the queries available.")]
    public class Query
    {
        /// <summary>
        /// Gets the queryable <see cref="BuyingGroups"/>.
        /// </summary>
        /// <param name="context">The <see cref="WideworldimportersContext"/>.</param>
        /// <returns>The queryable <see cref="Command"/>.</returns>
        [UseDbContext(typeof(WideworldimportersContext))]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Gets the queryable command for BuyingGroups.")]
        public IQueryable<BuyingGroups> GetBuyingGroups([ScopedService] WideworldimportersContext context) => context.BuyingGroups;

        /// <summary>
        /// Gets the queryable <see cref="Cities"/>.
        /// </summary>
        /// <param name="context">The <see cref="WideworldimportersContext"/>.</param>
        /// <returns>The queryable <see cref="Command"/>.</returns>
        [UseDbContext(typeof(WideworldimportersContext))]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Gets the queryable command for Cities.")]
        public IQueryable<Cities> GetCities([ScopedService] WideworldimportersContext context) => context.Cities;

        /// <summary>
        /// Gets the queryable <see cref="ColdRoomTemperatures"/>.
        /// </summary>
        /// <param name="context">The <see cref="WideworldimportersContext"/>.</param>
        /// <returns>The queryable <see cref="Command"/>.</returns>
        [UseDbContext(typeof(WideworldimportersContext))]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Gets the queryable command for ColdRoomTemperatures.")]
        public IQueryable<ColdRoomTemperatures> GetColdRoomTemperatures([ScopedService] WideworldimportersContext context) => context.ColdRoomTemperatures;

        /// <summary>
        /// Gets the queryable <see cref="Colors"/>.
        /// </summary>
        /// <param name="context">The <see cref="WideworldimportersContext"/>.</param>
        /// <returns>The queryable <see cref="Command"/>.</returns>
        [UseDbContext(typeof(WideworldimportersContext))]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Gets the queryable command for Colors.")]
        public IQueryable<Colors> GetColors([ScopedService] WideworldimportersContext context) => context.Colors;

        /// <summary>
        /// Gets the queryable <see cref="Countries"/>.
        /// </summary>
        /// <param name="context">The <see cref="WideworldimportersContext"/>.</param>
        /// <returns>The queryable <see cref="Command"/>.</returns>
        [UseDbContext(typeof(WideworldimportersContext))]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Gets the queryable command for Countries.")]
        public IQueryable<Countries> GetCountries([ScopedService] WideworldimportersContext context) => context.Countries;

        /// <summary>
        /// Gets the queryable <see cref="CustomerCategories"/>.
        /// </summary>
        /// <param name="context">The <see cref="WideworldimportersContext"/>.</param>
        /// <returns>The queryable <see cref="Command"/>.</returns>
        [UseDbContext(typeof(WideworldimportersContext))]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Gets the queryable command for CustomerCategories.")]
        public IQueryable<CustomerCategories> GetCustomerCategories([ScopedService] WideworldimportersContext context) => context.CustomerCategories;

        /// <summary>
        /// Gets the queryable <see cref="Customers"/>.
        /// </summary>
        /// <param name="context">The <see cref="WideworldimportersContext"/>.</param>
        /// <returns>The queryable <see cref="Command"/>.</returns>
        [UseDbContext(typeof(WideworldimportersContext))]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Gets the queryable command for Customers.")]
        public IQueryable<Customers> GetCustomers([ScopedService] WideworldimportersContext context) => context.Customers;

        /// <summary>
        /// Gets the queryable <see cref="CustomerTransactions"/>.
        /// </summary>
        /// <param name="context">The <see cref="WideworldimportersContext"/>.</param>
        /// <returns>The queryable <see cref="Command"/>.</returns>
        [UseDbContext(typeof(WideworldimportersContext))]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Gets the queryable command for CustomerTransactions.")]
        public IQueryable<CustomerTransactions> GetCustomerTransactions([ScopedService] WideworldimportersContext context) => context.CustomerTransactions;

        /// <summary>
        /// Gets the queryable <see cref="DeliveryMethods"/>.
        /// </summary>
        /// <param name="context">The <see cref="WideworldimportersContext"/>.</param>
        /// <returns>The queryable <see cref="Command"/>.</returns>
        [UseDbContext(typeof(WideworldimportersContext))]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Gets the queryable command for DeliveryMethods.")]
        public IQueryable<DeliveryMethods> GetDeliveryMethods([ScopedService] WideworldimportersContext context) => context.DeliveryMethods;

        /// <summary>
        /// Gets the queryable <see cref="InvoiceLines"/>.
        /// </summary>
        /// <param name="context">The <see cref="WideworldimportersContext"/>.</param>
        /// <returns>The queryable <see cref="Command"/>.</returns>
        [UseDbContext(typeof(WideworldimportersContext))]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Gets the queryable command for InvoiceLines.")]
        public IQueryable<InvoiceLines> GetInvoiceLines([ScopedService] WideworldimportersContext context) => context.InvoiceLines;

        /// <summary>
        /// Gets the queryable <see cref="Invoices"/>.
        /// </summary>
        /// <param name="context">The <see cref="WideworldimportersContext"/>.</param>
        /// <returns>The queryable <see cref="Command"/>.</returns>
        [UseDbContext(typeof(WideworldimportersContext))]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Gets the queryable command for Invoices.")]
        public IQueryable<Invoices> GetInvoices([ScopedService] WideworldimportersContext context) => context.Invoices;

        /// <summary>
        /// Gets the queryable <see cref="OrderLines"/>.
        /// </summary>
        /// <param name="context">The <see cref="WideworldimportersContext"/>.</param>
        /// <returns>The queryable <see cref="Command"/>.</returns>
        [UseDbContext(typeof(WideworldimportersContext))]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Gets the queryable command for OrderLines.")]
        public IQueryable<OrderLines> GetOrderLines([ScopedService] WideworldimportersContext context) => context.OrderLines;

        /// <summary>
        /// Gets the queryable <see cref="Orders"/>.
        /// </summary>
        /// <param name="context">The <see cref="WideworldimportersContext"/>.</param>
        /// <returns>The queryable <see cref="Command"/>.</returns>
        [UseDbContext(typeof(WideworldimportersContext))]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Gets the queryable command for Orders.")]
        public IQueryable<Orders> GetOrders([ScopedService] WideworldimportersContext context) => context.Orders;

        /// <summary>
        /// Gets the queryable <see cref="PackageTypes"/>.
        /// </summary>
        /// <param name="context">The <see cref="WideworldimportersContext"/>.</param>
        /// <returns>The queryable <see cref="Command"/>.</returns>
        [UseDbContext(typeof(WideworldimportersContext))]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Gets the queryable command for PackageTypes.")]
        public IQueryable<PackageTypes> GetPackageTypes([ScopedService] WideworldimportersContext context) => context.PackageTypes;

        /// <summary>
        /// Gets the queryable <see cref="PaymentMethods"/>.
        /// </summary>
        /// <param name="context">The <see cref="WideworldimportersContext"/>.</param>
        /// <returns>The queryable <see cref="Command"/>.</returns>
        [UseDbContext(typeof(WideworldimportersContext))]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Gets the queryable command for PaymentMethods.")]
        public IQueryable<PaymentMethods> GetPaymentMethods([ScopedService] WideworldimportersContext context) => context.PaymentMethods;

        /// <summary>
        /// Gets the queryable <see cref="People"/>.
        /// </summary>
        /// <param name="context">The <see cref="WideworldimportersContext"/>.</param>
        /// <returns>The queryable <see cref="Command"/>.</returns>
        [UseDbContext(typeof(WideworldimportersContext))]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Gets the queryable command for People.")]
        public IQueryable<People> GetPeople([ScopedService] WideworldimportersContext context) => context.People;

        /// <summary>
        /// Gets the queryable <see cref="PurchaseOrderLines"/>.
        /// </summary>
        /// <param name="context">The <see cref="WideworldimportersContext"/>.</param>
        /// <returns>The queryable <see cref="Command"/>.</returns>
        [UseDbContext(typeof(WideworldimportersContext))]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Gets the queryable command for PurchaseOrderLines.")]
        public IQueryable<PurchaseOrderLines> GetPurchaseOrderLines([ScopedService] WideworldimportersContext context) => context.PurchaseOrderLines;

        /// <summary>
        /// Gets the queryable <see cref="PurchaseOrders"/>.
        /// </summary>
        /// <param name="context">The <see cref="WideworldimportersContext"/>.</param>
        /// <returns>The queryable <see cref="Command"/>.</returns>
        [UseDbContext(typeof(WideworldimportersContext))]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Gets the queryable command for PurchaseOrders.")]
        public IQueryable<PurchaseOrders> GetPurchaseOrders([ScopedService] WideworldimportersContext context) => context.PurchaseOrders;

        /// <summary>
        /// Gets the queryable <see cref="SpecialDeals"/>.
        /// </summary>
        /// <param name="context">The <see cref="WideworldimportersContext"/>.</param>
        /// <returns>The queryable <see cref="Command"/>.</returns>
        [UseDbContext(typeof(WideworldimportersContext))]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Gets the queryable command for SpecialDeals.")]
        public IQueryable<SpecialDeals> GetSpecialDeals([ScopedService] WideworldimportersContext context) => context.SpecialDeals;

        /// <summary>
        /// Gets the queryable <see cref="StateProvinces"/>.
        /// </summary>
        /// <param name="context">The <see cref="WideworldimportersContext"/>.</param>
        /// <returns>The queryable <see cref="Command"/>.</returns>
        [UseDbContext(typeof(WideworldimportersContext))]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Gets the queryable command for StateProvinces.")]
        public IQueryable<StateProvinces> GetStateProvinces([ScopedService] WideworldimportersContext context) => context.StateProvinces;

        /// <summary>
        /// Gets the queryable <see cref="StockGroups"/>.
        /// </summary>
        /// <param name="context">The <see cref="WideworldimportersContext"/>.</param>
        /// <returns>The queryable <see cref="Command"/>.</returns>
        [UseDbContext(typeof(WideworldimportersContext))]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Gets the queryable command for StockGroups.")]
        public IQueryable<StockGroups> GetStockGroups([ScopedService] WideworldimportersContext context) => context.StockGroups;

        /// <summary>
        /// Gets the queryable <see cref="StockItemHoldings"/>.
        /// </summary>
        /// <param name="context">The <see cref="WideworldimportersContext"/>.</param>
        /// <returns>The queryable <see cref="Command"/>.</returns>
        [UseDbContext(typeof(WideworldimportersContext))]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Gets the queryable command for StockItemHoldings.")]
        public IQueryable<StockItemHoldings> GetStockItemHoldings([ScopedService] WideworldimportersContext context) => context.StockItemHoldings;

        /// <summary>
        /// Gets the queryable <see cref="StockItems"/>.
        /// </summary>
        /// <param name="context">The <see cref="WideworldimportersContext"/>.</param>
        /// <returns>The queryable <see cref="Command"/>.</returns>
        [UseDbContext(typeof(WideworldimportersContext))]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Gets the queryable command for StockItems.")]
        public IQueryable<StockItems> GetStockItems([ScopedService] WideworldimportersContext context) => context.StockItems;

        /// <summary>
        /// Gets the queryable <see cref="StockItemStockGroups"/>.
        /// </summary>
        /// <param name="context">The <see cref="WideworldimportersContext"/>.</param>
        /// <returns>The queryable <see cref="Command"/>.</returns>
        [UseDbContext(typeof(WideworldimportersContext))]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Gets the queryable command for StockItemStockGroups.")]
        public IQueryable<StockItemStockGroups> GetStockItemStockGroups([ScopedService] WideworldimportersContext context) => context.StockItemStockGroups;

        /// <summary>
        /// Gets the queryable <see cref="StockItemTransactions"/>.
        /// </summary>
        /// <param name="context">The <see cref="WideworldimportersContext"/>.</param>
        /// <returns>The queryable <see cref="Command"/>.</returns>
        [UseDbContext(typeof(WideworldimportersContext))]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Gets the queryable command for StockItemTransactions.")]
        public IQueryable<StockItemTransactions> GetStockItemTransactions([ScopedService] WideworldimportersContext context) => context.StockItemTransactions;

        /// <summary>
        /// Gets the queryable <see cref="SupplierCategories"/>.
        /// </summary>
        /// <param name="context">The <see cref="WideworldimportersContext"/>.</param>
        /// <returns>The queryable <see cref="Command"/>.</returns>
        [UseDbContext(typeof(WideworldimportersContext))]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Gets the queryable command for SupplierCategories.")]
        public IQueryable<SupplierCategories> GetSupplierCategories([ScopedService] WideworldimportersContext context) => context.SupplierCategories;

        /// <summary>
        /// Gets the queryable <see cref="Suppliers"/>.
        /// </summary>
        /// <param name="context">The <see cref="WideworldimportersContext"/>.</param>
        /// <returns>The queryable <see cref="Command"/>.</returns>
        [UseDbContext(typeof(WideworldimportersContext))]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Gets the queryable command for Suppliers.")]
        public IQueryable<Suppliers> GetSuppliers([ScopedService] WideworldimportersContext context) => context.Suppliers;

        /// <summary>
        /// Gets the queryable <see cref="SupplierTransactions"/>.
        /// </summary>
        /// <param name="context">The <see cref="WideworldimportersContext"/>.</param>
        /// <returns>The queryable <see cref="Command"/>.</returns>
        [UseDbContext(typeof(WideworldimportersContext))]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Gets the queryable command for SupplierTransactions.")]
        public IQueryable<SupplierTransactions> GetSupplierTransactions([ScopedService] WideworldimportersContext context) => context.SupplierTransactions;

        /// <summary>
        /// Gets the queryable <see cref="SystemParameters"/>.
        /// </summary>
        /// <param name="context">The <see cref="WideworldimportersContext"/>.</param>
        /// <returns>The queryable <see cref="Command"/>.</returns>
        [UseDbContext(typeof(WideworldimportersContext))]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Gets the queryable command for SystemParameters.")]
        public IQueryable<SystemParameters> GetSystemParameters([ScopedService] WideworldimportersContext context) => context.SystemParameters;

        /// <summary>
        /// Gets the queryable <see cref="TransactionTypes"/>.
        /// </summary>
        /// <param name="context">The <see cref="WideworldimportersContext"/>.</param>
        /// <returns>The queryable <see cref="Command"/>.</returns>
        [UseDbContext(typeof(WideworldimportersContext))]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Gets the queryable command for TransactionTypes.")]
        public IQueryable<TransactionTypes> GetTransactionTypes([ScopedService] WideworldimportersContext context) => context.TransactionTypes;

        /// <summary>
        /// Gets the queryable <see cref="VehicleTemperatures"/>.
        /// </summary>
        /// <param name="context">The <see cref="WideworldimportersContext"/>.</param>
        /// <returns>The queryable <see cref="Command"/>.</returns>
        [UseDbContext(typeof(WideworldimportersContext))]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Gets the queryable command for VehicleTemperatures.")]
        public IQueryable<VehicleTemperatures> GetVehicleTemperatures([ScopedService] WideworldimportersContext context) => context.VehicleTemperatures;
    }
}