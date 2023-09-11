namespace BuilderPattern
{
    // Abstract Builder (Fluent Api)
    public interface IFluentSalesReportBuilder
    {
        IFluentSalesReportBuilder AddHeader(string title);
        IFluentSalesReportBuilder AddProductDetailsSection();
        IFluentSalesReportBuilder AddFooter();
        SalesReport Build();
    }




}