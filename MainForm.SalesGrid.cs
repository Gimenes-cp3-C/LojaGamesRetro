namespace LojaGamesRetro;

// Estilo da tabela do relatório de vendas
public partial class MainForm
{
    private readonly DataGridView salesGrid = new();

    private void ConfigureSalesGrid()
    {
        salesGrid.BackgroundColor = panelColor;
        salesGrid.BorderStyle = BorderStyle.None;
        salesGrid.GridColor = Color.FromArgb(70, 63, 95);
        salesGrid.EnableHeadersVisualStyles = false;
        salesGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(48, 40, 75);
        salesGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        salesGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        salesGrid.DefaultCellStyle.BackColor = panelColor;
        salesGrid.DefaultCellStyle.ForeColor = Color.White;
        salesGrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(75, 61, 110);
        salesGrid.DefaultCellStyle.SelectionForeColor = Color.White;
        salesGrid.RowHeadersVisible = false;
        salesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        salesGrid.AllowUserToAddRows = false;
        salesGrid.ReadOnly = true;
    }
}
