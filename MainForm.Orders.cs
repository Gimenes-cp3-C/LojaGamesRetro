namespace LojaGamesRetro;

// Lançamento de pedidos a partir dos cards
public partial class MainForm
{
    private void RegisterSale(GameItem game)
    {
        using var dialog = new Form
        {
            Text = "Novo pedido", Size = new Size(390, 270), StartPosition = FormStartPosition.CenterParent,
            FormBorderStyle = FormBorderStyle.FixedDialog, MaximizeBox = false, MinimizeBox = false,
            BackColor = background, ForeColor = Color.White, Font = Font
        };
        var nameLabel = new Label { Text = "Nome do cliente:", Location = new Point(20, 22), AutoSize = true };
        var nameBox = new TextBox { Location = new Point(20, 48), Width = 325 };
        var quantityLabel = new Label { Text = "Quantidade:", Location = new Point(20, 88), AutoSize = true };
        var quantity = new NumericUpDown { Location = new Point(20, 114), Width = 100, Minimum = 1, Maximum = 20, Value = 1 };
        var totalLabel = new Label { Text = "Total: " + game.Price.ToString("C2"), Location = new Point(145, 117), AutoSize = true, ForeColor = accent, Font = new Font("Segoe UI", 11, FontStyle.Bold) };
        quantity.ValueChanged += (_, _) => totalLabel.Text = "Total: " + (game.Price * quantity.Value).ToString("C2");

        var save = new Button { Text = "Confirmar pedido", Location = new Point(20, 165), Size = new Size(325, 38), BackColor = accent, ForeColor = background, FlatStyle = FlatStyle.Flat };
        save.Click += (_, _) =>
        {
            if (string.IsNullOrWhiteSpace(nameBox.Text))
            {
                MessageBox.Show("Informe o nome do cliente.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sales.Add(new Sale(nameBox.Text.Trim(), game.Name, (int)quantity.Value, game.Price, DateTime.Now));
            MessageBox.Show("Pedido registrado com sucesso!", "Pixel Vault", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dialog.DialogResult = DialogResult.OK;
            dialog.Close();
        };

        dialog.Controls.AddRange(new Control[] { nameLabel, nameBox, quantityLabel, quantity, totalLabel, save });
        dialog.ShowDialog(this);
    }
}
