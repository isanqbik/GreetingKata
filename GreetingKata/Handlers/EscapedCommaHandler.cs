using GreetingKata.classes;
using System;
using System.Linq;

namespace GreetingKata.Handlers
{
    public class EscapedCommaHandler : BaseHandler
    {
        public override string Handle(string[] names)
        {
            // Proceso: separar por comas no escapadas
            var processedNames = names.SelectMany(name =>
            {
                // Si el nombre está entre comillas, no dividir
                if (name.StartsWith("\"") && name.EndsWith("\""))
                {
                    return new[] { name }; // Mantener el nombre completo con comillas
                }

                // Dividir nombres que contienen comas no escapadas
                return name.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                           .Select(n => n.Trim());
            }).ToArray();

            // Pasar los nombres procesados al siguiente manejador
            return base.Handle(processedNames);
        }
    }
}
