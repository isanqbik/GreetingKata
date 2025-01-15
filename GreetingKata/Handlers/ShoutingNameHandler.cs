using GreetingKata.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingKata.Handlers
{
    public class ShoutingNameHandler : BaseHandler
    {
        public override string Handle(string[] names)
        {
            var shoutingNames = names.Where(name => name == name.ToUpper()).ToArray();
            if (shoutingNames.Length > 0)
            {
                return $"HELLO {string.Join(" AND ", shoutingNames)}!";
            }
            return base.Handle(names);
        }
    }
}
