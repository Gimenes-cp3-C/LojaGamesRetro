namespace LojaGamesRetro;

// Tela de Menu (principal / navegação)
public partial class MainForm : Form
{
    private readonly Color background = Color.FromArgb(18, 16, 32);
    private readonly Color panelColor = Color.FromArgb(34, 29, 56);
    private readonly Color accent = Color.FromArgb(255, 207, 77);
    private readonly Label pageTitle = new();
    private readonly Panel contentPanel = new();

    public MainForm()
    {
        Text = "Pixel Vault | Loja de Games Retrô — Felipe Gimenes (RM 99799)";
        StartPosition = FormStartPosition.CenterScreen;
        MinimumSize = new Size(1000, 680);
        Size = new Size(1180, 760);
        BackColor = background;
        ForeColor = Color.White;
        Font = new Font("Segoe UI", 10);

        var sidebar = new Panel { Dock = DockStyle.Left, Width = 225, BackColor = Color.FromArgb(25, 21, 45), Padding = new Padding(15) };
        var brand = new Label
        {
            Text = "🕹 PIXEL\nVAULT",
            Font = new Font("Segoe UI", 22, FontStyle.Bold),
            ForeColor = accent,
            Dock = DockStyle.Top,
            Height = 115,
            TextAlign = ContentAlignment.MiddleCenter
        };
        var author = new Label
        {
            Text = "Felipe Gimenes\nRM 99799",
            Font = new Font("Segoe UI", 9),
            ForeColor = Color.FromArgb(150, 145, 180),
            Dock = DockStyle.Bottom,
            Height = 45,
            TextAlign = ContentAlignment.MiddleCenter
        };

        var nav = new FlowLayoutPanel { Dock = DockStyle.Fill, FlowDirection = FlowDirection.TopDown, WrapContents = false, Padding = new Padding(0, 15, 0, 0) };
        nav.Controls.Add(NavButton("⌂  Início", ShowHome));
        nav.Controls.Add(NavButton("🎮  Jogos e pedidos", ShowGames));
        nav.Controls.Add(NavButton("📊  Relatório de vendas", ShowSales));
        nav.Controls.Add(NavButton("ℹ  Sobre", ShowAbout));

        sidebar.Controls.Add(nav);
        sidebar.Controls.Add(author);
        sidebar.Controls.Add(brand);

        var header = new Panel { Dock = DockStyle.Top, Height = 82, Padding = new Padding(28, 18, 20, 12), BackColor = background };
        pageTitle.Text = "Painel principal";
        pageTitle.Font = new Font("Segoe UI", 21, FontStyle.Bold);
        pageTitle.ForeColor = Color.White;
        pageTitle.Dock = DockStyle.Left;
        pageTitle.Width = 550;
        header.Controls.Add(pageTitle);

        contentPanel.Dock = DockStyle.Fill;
        contentPanel.Padding = new Padding(25);
        contentPanel.BackColor = background;

        Controls.Add(contentPanel);
        Controls.Add(header);
        Controls.Add(sidebar);

        ConfigureSalesGrid();
        ShowHome();
    }

    private Button NavButton(string text, Action action)
    {
        var b = new Button
        {
            Text = text, Width = 190, Height = 48, FlatStyle = FlatStyle.Flat,
            BackColor = Color.FromArgb(39, 33, 63), ForeColor = Color.White,
            TextAlign = ContentAlignment.MiddleLeft, Padding = new Padding(12, 0, 0, 0),
            Margin = new Padding(0, 6, 0, 6), Cursor = Cursors.Hand
        };
        b.FlatAppearance.BorderSize = 0;
        b.Click += (_, _) => action();
        return b;
    }

    private void SetPage(string title, Control control)
    {
        pageTitle.Text = title;
        contentPanel.Controls.Clear();
        control.Dock = DockStyle.Fill;
        contentPanel.Controls.Add(control);
    }
}
