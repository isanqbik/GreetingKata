namespace GreetingKata.classes
{
    public abstract class BaseHandler : IGreetingHandler
    {
        private IGreetingHandler _next;

        public void SetNext(IGreetingHandler next) => _next = next;

        public virtual string Handle(string[] names)
        {
            if (_next != null)
            {
                return _next.Handle(names);
            }
            return string.Empty; // Devuelve vacío si no hay más manejadores
        }
    }
}
