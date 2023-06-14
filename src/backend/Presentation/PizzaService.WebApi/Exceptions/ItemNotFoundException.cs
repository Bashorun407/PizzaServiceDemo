namespace PizzaService.WebApi.Exceptions
{
    public class ItemNotFoundException : NotFoundException
    {
        public ItemNotFoundException(string message) : base(message)
        {

        }
    }
}
