using AbstractFactoryPattern.AbstractFactory.App;
using AbstractFactoryPattern.AbstractFactory.Bootstrap;
using AbstractFactoryPattern.AbstractFactory.Material;
using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Abstract Factory Method Pattern!");

            ContactForm form = new ContactForm();
            form.Render(new MaterialWidgetFactory());

        }
    }
}
