using System.ComponentModel.Design;

namespace Seta.Application.PizzaUseCases;

public class CortarPizzaUseCase
(
    IPizzaService service
)
{
    public void Do()
    {
        service.CortarPizza();
    }
}