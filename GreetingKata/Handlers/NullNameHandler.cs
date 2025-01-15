using GreetingKata.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingKata.Handlers
{
    public class NullNameHandler : BaseHandler
    {
        public override string Handle(string[] names)
        {
            if (names == null || names.Length == 0 || names[0] == null)
            {
                return "Hello, my friend.";
            }
            return base.Handle(names);
        }
    }
}
