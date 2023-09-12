using AbstractFactoryPattern.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    // Abstract Factory
    public interface IWidgetFactory
    {
        IButton CreateButton();
        ITextBox CreateTextBox();
    }
}
