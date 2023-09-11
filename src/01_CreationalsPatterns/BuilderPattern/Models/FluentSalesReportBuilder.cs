using System;
using System.Collections.Generic;
using System.Linq;

namespace BuilderPattern
{
    public class FluentSalesReportBuilder : IFluentSalesReportBuilder, IInstance, IHeader, ISection, IFooter
    {
        // Product
        private SalesReport salesReport = new SalesReport();

        private IEnumerable<Order> orders;

        //public IFluentSalesReportBuilder Instance(IEnumerable<Order> orders)
        //{
        //    return new FluentSalesReportBuilder(orders);
        //}

        public FluentSalesReportBuilder(IEnumerable<Order> orders)
        {
            this.orders = orders;
        }


        public IFluentSalesReportBuilder AddFooter()
        {
            return this;
        }

        public ISection AddHeader(string title)
        {
            salesReport.Title = title;
            salesReport.CreateDate = DateTime.Now;
            salesReport.TotalSalesAmount = orders.Sum(s => s.Amount);

            return this;
        }

        public IFooter AddProductDetailsSection()
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

        public IHeader Instance()
        {
            return this;
        }
    }




}