# Pixel Vault — Loja de Games Retrô

Projeto desktop em C# Windows Forms para o **Checkpoint 3 de C# Development** (FIAP — Engenharia de Software).

**Aluno:** Felipe Gimenes — **RM:** 99799

## Funcionalidades
- Tela de Splash (abertura/carregamento).
- Tela de Menu com navegação lateral e indicadores.
- Tela de Cards de Jogos com lançamento de pedidos (cliente e quantidade).
- Tela de Relatório de Vendas com total por pedido e faturamento acumulado.

## Estrutura
| Arquivo | Responsabilidade |
|---|---|
| `Program.cs` | Ponto de entrada: abre o splash e depois o menu |
| `SplashForm.cs` | Tela de splash |
| `MainForm.cs` / `MainForm.Home.cs` | Menu, navegação, painel inicial e "Sobre" |
| `GameCatalog.cs` / `MainForm.Games.cs` / `MainForm.Orders.cs` | Catálogo em cards e registro de pedidos |
| `MainForm.Sales.cs` / `MainForm.SalesGrid.cs` | Relatório de vendas |
| `Models.cs` | Modelos `GameItem` e `Sale` |

## Requisitos
- Windows
- Visual Studio 2022 ou mais recente, com a carga de trabalho **Desenvolvimento para desktop com .NET**
- .NET 8 SDK

## Como executar
1. Clone o repositório.
2. Abra `LojaGamesRetro.csproj` no Visual Studio.
3. Execute com `F5` ou `Ctrl+F5`.

## Observações
Os pedidos ficam em memória e são apagados quando o programa é fechado.
