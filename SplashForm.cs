namespace LojaGamesRetro;

public class SplashForm : Form
{
    private readonly System.Windows.Forms.Timer timer = new();

    public SplashForm()
    {
        Text = "Pixel Vault | Carregando";
        StartPosition = FormStartPosition.CenterScreen;
        FormBorderStyle = FormBorderStyle.None;
        ClientSize = new Size(620, 330);
        BackColor = Color.FromArgb(22, 18, 42);
        ForeColor = Color.White;
        ShowInTaskbar = false;

        var title = new Label
        {
            Text = "PIXEL VAULT",
            Font = new Font("Segoe UI", 30, FontStyle.Bold),
            ForeColor = Color.FromArgb(255, 207, 77),
            AutoSize = false,
            TextAlign = ContentAlignment.MiddleCenter,
            Dock = DockStyle.Top,
            Height = 115
        };
        var subtitle = new Label
        {
            Text = "SUA LOJA DE GAMES RETRÔ",
            Font = new Font("Segoe UI", 13, FontStyle.Bold),
            ForeColor = Color.White,
            AutoSize = false,
            TextAlign = ContentAlignment.MiddleCenter,
            Dock = DockStyle.Top,
            Height = 48
        };
        var loading = new Label
        {
            Text = "Preparando sua próxima aventura...",
            Font = new Font("Segoe UI", 10),
            ForeColor = Color.FromArgb(190, 185, 215),
            AutoSize = false,
            TextAlign = ContentAlignment.MiddleCenter,
            Dock = DockStyle.Bottom,
            Height = 50
        };
        var credits = new Label
        {
            Text = "Desenvolvido por Felipe Gimenes · RM 99799",
            Font = new Font("Segoe UI", 9),
            ForeColor = Color.FromArgb(140, 135, 170),
            AutoSize = false,
            TextAlign = ContentAlignment.MiddleCenter,
            Dock = DockStyle.Bottom,
            Height = 30
        };

        Controls.Add(loading);
        Controls.Add(credits);
        Controls.Add(subtitle);
        Controls.Add(title);

        timer.Interval = 1600;
        timer.Tick += (_, _) => { timer.Stop(); Close(); };
        Shown += (_, _) => timer.Start();
    }
}
