namespace BuilderPattern
{
    // Abstract Builder (Fluent Api)
    public interface IFluentSalesReportBuilder
    {       
        SalesReport Build();
    }


    public interface IInstance
    {
        IHeader Instance();
    }

    public interface ISectionOrFooter : ISection, IFooter
    {

    }

    public interface IHeader
    {
        ISectionOrFooter AddHeader(string title);
    }

    public interface ISection
    {
        IFooter AddProductDetailsSection();
    }

    public interface IFooter
    {
        IFluentSalesReportBuilder AddFooter();
    }






}