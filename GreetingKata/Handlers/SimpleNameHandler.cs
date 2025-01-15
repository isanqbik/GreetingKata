using GreetingKata.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingKata.Handlers
{
    public class SimpleNameHandler : BaseHandler
    {
        public override string Handle(string[] names)
        {
            if (names.Length == 1)
            {
                return $"Hello, {names[0]}.";
            }
            else if (names.Length == 2)
            {
                return $"Hello, {names[0]} and {names[1]}.";
            }
            else
            {
                var formattedNames = string.Join(", ", names.Take(names.Length - 1)) +
                                     $", and {names.Last()}";
                return $"Hello, {formattedNames}.";
            }
        }
    }

}
