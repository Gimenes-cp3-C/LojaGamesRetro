namespace LojaGamesRetro;

// Tela de Cards de Jogos
public partial class MainForm
{
    private readonly FlowLayoutPanel gamesPanel = new();

    private void ShowGames()
    {
        gamesPanel.Controls.Clear();
        gamesPanel.Dock = DockStyle.Fill;
        gamesPanel.AutoScroll = true;
        gamesPanel.WrapContents = true;
        gamesPanel.FlowDirection = FlowDirection.LeftToRight;
        gamesPanel.Padding = new Padding(0, 0, 10, 10);

        foreach (var game in GameCatalog.Games)
            gamesPanel.Controls.Add(GameCard(game));

        SetPage("Jogos e pedidos", gamesPanel);
    }

    private Panel GameCard(GameItem game)
    {
        var card = new Panel { Width = 260, Height = 245, BackColor = panelColor, Margin = new Padding(0, 0, 18, 18), Padding = new Padding(14) };
        card.Controls.Add(new Label { Text = game.Icon, Font = new Font("Segoe UI Emoji", 32), ForeColor = accent, Location = new Point(14, 8), AutoSize = true });
        card.Controls.Add(new Label { Text = game.Name, Font = new Font("Segoe UI", 13, FontStyle.Bold), ForeColor = Color.White, Location = new Point(14, 70), Size = new Size(230, 32) });
        card.Controls.Add(new Label { Text = "Plataforma: " + game.Platform, Font = new Font("Segoe UI", 9), ForeColor = Color.Silver, Location = new Point(14, 105), AutoSize = true });
        card.Controls.Add(new Label { Text = game.Price.ToString("C2"), Font = new Font("Segoe UI", 16, FontStyle.Bold), ForeColor = accent, Location = new Point(14, 135), AutoSize = true });

        var buy = new Button { Text = "Registrar pedido", Location = new Point(14, 183), Size = new Size(225, 40), BackColor = accent, ForeColor = background, FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 10, FontStyle.Bold), Cursor = Cursors.Hand };
        buy.FlatAppearance.BorderSize = 0;
        buy.Click += (_, _) => RegisterSale(game);
        card.Controls.Add(buy);
        return card;
    }
}
