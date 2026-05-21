using Microsoft.AspNetCore.Mvc;
using DC.Services;

namespace DC.Endpoints;

public static class HeroEndpoint
{

    public static void ConfigureHeroEndpoints(this WebApplication app)
    {
        app.MapPost("/Hero", async (
            [FromBody] CreateHeroRequest hero,
            [FromServices] HeroService service
        ) => {
            var newHero = await service.Create(hero);
            return newHero;
        });

        app.MapGet("/Hero", async (
            [FromServices] HeroService service
        ) => {
            var all = await service.GetAll();
            return all;
        });
    }

}