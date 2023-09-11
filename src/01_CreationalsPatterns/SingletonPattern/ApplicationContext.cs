using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class ApplicationContext : Singleton<ApplicationContext>
    {
        public string LoggedUser { get; set; }
        public DateTime LoggedOn { get; set; }
    }
}
