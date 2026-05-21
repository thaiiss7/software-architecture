namespace DC.Endpoints;

public record CreateHeroRequest(
    string Name,
    string Description,
    string Power,
    string Status
);