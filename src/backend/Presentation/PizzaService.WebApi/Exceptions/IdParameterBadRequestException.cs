namespace PizzaService.WebApi.Exceptions
{
    public abstract class IdParameterBadRequestException : Exception
    {
        protected IdParameterBadRequestException() : base("Parameter Id is null")
        {
        }
    }
}
