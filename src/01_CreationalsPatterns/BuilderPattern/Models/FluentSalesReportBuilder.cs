using System;
using System.Collections.Generic;
using System.Linq;

namespace BuilderPattern
{
    public class FluentSalesReportBuilder : IFluentSalesReportBuilder
    {
        // Product
        private SalesReport salesReport = new SalesReport();

        private IEnumerable<Order> orders;

        public static IFluentSalesReportBuilder Instance(IEnumerable<Order> orders)
        {
            return new FluentSalesReportBuilder(orders);
        }

        private FluentSalesReportBuilder(IEnumerable<Order> orders)
        {
            this.orders = orders;
        }


        public IFluentSalesReportBuilder AddFooter()
        {
            return this;
        }

        public IFluentSalesReportBuilder AddHeader(string title)
        {
            salesReport.Title = title;
            salesReport.CreateDate = DateTime.Now;
            salesReport.TotalSalesAmount = orders.Sum(s => s.Amount);

            return this;
        }

        public IFluentSalesReportBuilder AddProductDetailsSection()
        {
            salesReport.ProductDetails = orders
              .SelectMany(o => o.Details)
              .GroupBy(o => o.Product)
              .Select(g => new ProductReportDetail(g.Key, g.Sum(p => p.Quantity), g.Sum(p => p.LineTotal)));

            return this;
        }

        public SalesReport Build()
        {
            return salesReport;
        }

       
    }




}