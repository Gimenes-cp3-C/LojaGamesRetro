namespace LojaGamesRetro;

// Painel inicial do menu e tela "Sobre"
public partial class MainForm
{
    private void ShowHome()
    {
        var page = new FlowLayoutPanel { FlowDirection = FlowDirection.TopDown, WrapContents = false, AutoScroll = true };
        page.Controls.Add(new Label
        {
            Text = "Bem-vindo à Pixel Vault!\nNostalgia em cada pixel.",
            Font = new Font("Segoe UI", 24, FontStyle.Bold),
            ForeColor = accent, AutoSize = true, Margin = new Padding(0, 8, 0, 25)
        });
        page.Controls.Add(StatCard("Jogos disponíveis", GameCatalog.Games.Count.ToString()));
        page.Controls.Add(StatCard("Pedidos registrados", sales.Count.ToString()));
        page.Controls.Add(StatCard("Total em vendas", sales.Sum(s => s.Total).ToString("C2")));
        page.Controls.Add(new Label
        {
            Text = "Explore os clássicos, registre um pedido e acompanhe as vendas pelo relatório.\n\nUse o menu à esquerda para navegar pelo sistema.",
            AutoSize = true, ForeColor = Color.FromArgb(205, 201, 220), Font = new Font("Segoe UI", 12), Margin = new Padding(5, 20, 5, 5)
        });
        SetPage("Painel principal", page);
    }

    private Control StatCard(string caption, string value)
    {
        var p = new Panel { Width = 640, Height = 82, BackColor = panelColor, Margin = new Padding(0, 0, 0, 12), Padding = new Padding(18) };
        p.Controls.Add(new Label { Text = caption, ForeColor = Color.FromArgb(190, 185, 215), Font = new Font("Segoe UI", 10), Location = new Point(16, 10), AutoSize = true });
        p.Controls.Add(new Label { Text = value, ForeColor = accent, Font = new Font("Segoe UI", 20, FontStyle.Bold), Location = new Point(16, 30), AutoSize = true });
        return p;
    }

    private void ShowAbout()
    {
        var label = new Label
        {
            Text = "PIXEL VAULT\nLoja de Games Retrô\n\n" +
                   "Projeto acadêmico — C# Windows Forms\n" +
                   "Checkpoint 3 — C# Development — FIAP\n\n" +
                   "Aluno: Felipe Gimenes\nRM: 99799\n\n" +
                   "Funcionalidades:\n• Tela de splash\n• Menu de navegação\n• Catálogo de jogos em cards\n• Registro de pedidos\n• Relatório de vendas em memória\n\n" +
                   "Observação: os pedidos são mantidos enquanto o programa estiver aberto.",
            Font = new Font("Segoe UI", 13), ForeColor = Color.White, AutoSize = true
        };
        SetPage("Sobre o projeto", label);
    }
}
