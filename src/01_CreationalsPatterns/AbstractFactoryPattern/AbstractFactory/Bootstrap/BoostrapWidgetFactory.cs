using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.AbstractFactory.Bootstrap
{
    // Concrete Factory B
    public class BoostrapWidgetFactory : IWidgetFactory
    {
        public IButton CreateButton()
        {
            return new BootstrapButton();
        }

        public ITextBox CreateTextBox()
        {
            return new BootstrapTextBox();
        }
    }
}
