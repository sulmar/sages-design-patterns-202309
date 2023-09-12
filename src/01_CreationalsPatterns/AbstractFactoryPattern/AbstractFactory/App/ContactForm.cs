using AbstractFactoryPattern.AbstractFactory.Bootstrap;
using AbstractFactoryPattern.AbstractFactory.Material;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.AbstractFactory.App
{
    public class ContactForm
    {
        public void Render(IWidgetFactory factory)
        {
            factory.CreateTextBox().Render();
            factory.CreateButton().Render();
        }
    }

    public enum Theme
    {
        Material,
        Bootstrap
    }
}
