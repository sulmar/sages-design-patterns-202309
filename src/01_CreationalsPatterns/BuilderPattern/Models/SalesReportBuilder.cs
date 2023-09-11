using System;
using System.Collections.Generic;
using System.Linq;

namespace BuilderPattern
{
    public class SalesReportBuilder : ISalesReportBuilder
    {
        // Product
        private SalesReport salesReport = new SalesReport();

        private IEnumerable<Order> orders;

        public SalesReportBuilder(IEnumerable<Order> orders)
        {
            this.orders = orders;
        }

        public void AddHeader(string title)
        {
            salesReport.Title = title;
            salesReport.CreateDate = DateTime.Now;
            salesReport.TotalSalesAmount = orders.Sum(s => s.Amount);
        }

        public void AddProductDetailsSection()
        {
            salesReport.ProductDetails = orders
                .SelectMany(o => o.Details)
                .GroupBy(o => o.Product)
                .Select(g => new ProductReportDetail(g.Key, g.Sum(p => p.Quantity), g.Sum(p => p.LineTotal)));
        }

        public void AddFooter()
        {

        }
       

        public SalesReport Build()
        {
            return salesReport;
        }

       
    }




}