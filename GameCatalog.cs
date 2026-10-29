namespace LojaGamesRetro;

internal static class GameCatalog
{
    public static IReadOnlyList<GameItem> Games { get; } = new List<GameItem>
    {
        new("Super Mario World", "SNES", 129.90m, "🟡"),
        new("Sonic the Hedgehog 2", "Mega Drive", 99.90m, "🔵"),
        new("The Legend of Zelda", "NES", 149.90m, "🗡"),
        new("Street Fighter II", "SNES", 119.90m, "🥊"),
        new("Pokémon Red", "Game Boy", 179.90m, "🔴"),
        new("Pac-Man", "Arcade", 79.90m, "🟠")
    };
}
