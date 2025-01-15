using GreetingKata.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingKata.Handlers
{
    public class TwoNameHandler : BaseHandler
    {
        public override string Handle(string[] names)
        {
            if (names.Length == 2)
            {
                return $"Hello, {names[0]} and {names[1]}.";
            }
            return base.Handle(names);
        }
    }
}
