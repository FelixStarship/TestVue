using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperConsoleApplication
{
   public class DerivedClass:BaseClass
    {
        public  override void Show(string name)
        {
            
            Console.WriteLine(name);
            base.Show("");
        }
    }
}
