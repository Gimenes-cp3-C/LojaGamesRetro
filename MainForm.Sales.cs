namespace LojaGamesRetro;

// Tela de Relatório de Vendas
public partial class MainForm
{
    private readonly List<Sale> sales = new();

    private void ShowSales()
    {
        var wrapper = new Panel { Dock = DockStyle.Fill };
        var summary = new Label
        {
            Text = $"Pedidos: {sales.Count}     |     Faturamento: {sales.Sum(s => s.Total):C2}",
            Dock = DockStyle.Top, Height = 45, ForeColor = accent, Font = new Font("Segoe UI", 13, FontStyle.Bold)
        };

        salesGrid.DataSource = null;
        salesGrid.DataSource = sales.Select(s => new
        {
            Cliente = s.Customer,
            Jogo = s.Game,
            Quantidade = s.Quantity,
            Unitario = s.UnitPrice.ToString("C2"),
            Total = s.Total.ToString("C2"),
            Data = s.Date.ToString("dd/MM/yyyy HH:mm")
        }).ToList();

        wrapper.Controls.Add(salesGrid);
        wrapper.Controls.Add(summary);
        SetPage("Relatório de vendas", wrapper);
    }
}
