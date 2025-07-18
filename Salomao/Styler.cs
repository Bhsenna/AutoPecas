﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salomao
{
    internal class Styler
    {
        public static class GridStyler
        {
            public static void Personalizar(DataGridView grid)
            {
                grid.BorderStyle = BorderStyle.None;
                grid.BackgroundColor = ColorTranslator.FromHtml("#D1D5DB");
                grid.EnableHeadersVisualStyles = false;

                grid.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#1E3A8A");
                grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                grid.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F3F4F6");
                grid.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#374151");
                grid.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#2563EB");
                grid.DefaultCellStyle.SelectionForeColor = Color.White;
                grid.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                grid.RowTemplate.Height = 30;

                grid.GridColor = ColorTranslator.FromHtml("#D1D5DB");
                grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                grid.RowHeadersVisible = false;
                grid.AllowUserToResizeRows = false;
                grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }

            public static void PersonalizarSaldoEstoque(DataGridView grid, double limiteEstoqueBaixo = 5)
            {
                Personalizar(grid);
                // Ajuste automático das colunas
                grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                // Alinhar colunas numéricas à direita
                foreach (DataGridViewColumn col in grid.Columns)
                {
                    if (col.ValueType == typeof(double) || col.ValueType == typeof(float) || col.ValueType == typeof(decimal) || col.ValueType == typeof(int))
                        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                // Destacar saldo baixo
                grid.RowPrePaint += (s, e) =>
                {
                    var dgv = (DataGridView)s;
                    if (dgv.Columns.Contains("QuantidadeAtual"))
                    {
                        var qtd = dgv.Rows[e.RowIndex].Cells["QuantidadeAtual"].Value;
                        if (qtd != null && double.TryParse(qtd.ToString(), out double valor) && valor <= limiteEstoqueBaixo)
                        {
                            dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#FDE68A"); // Amarelo claro
                        }
                        else
                        {
                            dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#F3F4F6");
                        }
                    }
                };
            }
        }

        public static class ButtonStyler
        {
            public static void PersonalizaGravar(Button button)
            {
                button.BackColor = ColorTranslator.FromHtml("#10B981");
                button.ForeColor = Color.White;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                button.Height = 36;
                button.Width = 100;
                //button.Region = System.Drawing.Region.FromHrgn(
                //CreateRoundRectRgn(0, 0, button.Width, button.Height, 8, 8));
            }
            public static void PersonalizaLimpar(Button button)
            {
                button.BackColor = ColorTranslator.FromHtml("#EF4444");
                button.ForeColor = Color.White;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                button.Height = 36;
                button.Width = 100;
                //button.Region = System.Drawing.Region.FromHrgn(
                //CreateRoundRectRgn(0, 0, button.Width, button.Height, 8, 8));
            }

            [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
            private static extern IntPtr CreateRoundRectRgn(
                int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
                int nWidthEllipse, int nHeightEllipse);
        }
    }
}
