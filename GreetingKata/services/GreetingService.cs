using GreetingKata.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingKata.services
{
    public class GreetingService
    {
        private readonly IGreetingHandler _handlerChain;

        public GreetingService(IGreetingHandler handlerChain)
        {
            _handlerChain = handlerChain;
        }

        public string Greet(params string[] names)
        {
            return _handlerChain.Handle(names);
        }
    }
}
