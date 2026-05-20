using System.Reflection.Metadata;
using Seta.Application;
using Seta.Application.PizzaUseCases;
using Seta.Infrastructure;

var service = new PizzaService();
var addUseCase = new AddPizzaUseCase(service);
var cortarPizzaUseCase = new CortarPizzaUseCase(service);
var getQuantidadeUseCase = new GetQuantidade(service);

while(true)
{
    Console.WriteLine(@"
        1 - add pizza
        2 - cortar pizza
        3 - ver quantidade
    ");
    var op = Console.ReadLine();
    if(op is null)
        continue;

    switch(op)
    {
        case "1":
            Console.WriteLine("Nome:\n>>");
            var nome = Console.ReadLine();
            Console.WriteLine("Sabor:\n>>");
            var sabor = Console.ReadLine();
            Console.WriteLine("Fatias:\n>> 1");
            var fatias = 1;

            PizzaDTO pizza = new(
                nome!,
                sabor!,
                fatias!
            );
            addUseCase.Do(pizza);
            break;
        case "2":
            cortarPizzaUseCase.Do();
            break;
        case "3":
            var qnt = getQuantidadeUseCase.Do();
            Console.WriteLine(qnt);
            break;
    }

}