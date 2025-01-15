using GreetingKata.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingKata.Handlers
{
    public class MultipleNameHandler : BaseHandler
    {
        public override string Handle(string[] names)
        {
            if (names.Length > 2)
            {
                var normalNames = names.Where(name => name != name.ToUpper()).ToArray();
                var formattedNames = string.Join(", ", normalNames.Take(normalNames.Length - 1)) +
                                     $", and {normalNames.Last()}";
                return $"Hello, {formattedNames}.";
            }

            // Pasar al siguiente manejador si no hay más de dos nombres
            return base.Handle(names);
        }
    }
}
