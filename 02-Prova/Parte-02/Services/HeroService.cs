using Microsoft.EntityFrameworkCore;
using DC.Contexts;
using DC.Endpoints;
using DC.Models;

namespace DC.Services;

public class HeroService
(
    DCContext ctx
)
{
    public async Task<ICollection<Hero>> GetAll()
    {
        var all = await ctx.Heroes
            .ToListAsync();

        return all;
    }

    public async Task<Hero?> Create(CreateHeroRequest request)
    {
        if(request.Name.Count() < 5)
            return null;
        
        var hero = new Hero
        {
            Name=request.Name,
            Description=request.Description,
            Power=request.Power,
            Status=request.Status
        };
        ctx.Heroes.Add(hero);
        await ctx.SaveChangesAsync();

        return hero;
    }
}