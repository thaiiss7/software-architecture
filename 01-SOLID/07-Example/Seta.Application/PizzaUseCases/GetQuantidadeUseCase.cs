namespace Seta.Application.PizzaUseCases;

public class GetQuantidade(
    IPizzaService service
)
{
    public int Do()
    {
        return service.GetQuantidade();
    }
}