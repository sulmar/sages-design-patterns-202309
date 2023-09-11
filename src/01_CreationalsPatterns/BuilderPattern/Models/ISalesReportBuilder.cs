namespace BuilderPattern
{
    // Abstract Builder
    public interface ISalesReportBuilder
    {
        void AddHeader(string title);
        void AddProductDetailsSection();
        void AddFooter();
        SalesReport Build();
    }




}