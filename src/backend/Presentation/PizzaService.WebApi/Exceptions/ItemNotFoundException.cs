namespace PizzaService.WebApi.Exceptions
{
    public sealed class ItemNotFoundException : NotFoundException
    {
        public ItemNotFoundException(string message) : base(message)
        {

        }
    }
}
