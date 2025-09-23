using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salomao
{
    internal class Styler
    {
        #region Paleta de Cores Moderna
        public static class ModernColors
        {
            // Cores principais
            public static Color Primary = ColorTranslator.FromHtml("#3B82F6");
            public static Color PrimaryLight = ColorTranslator.FromHtml("#60A5FA");
            public static Color PrimaryDark = ColorTranslator.FromHtml("#2563EB");

            // Cores de fundo
            public static Color Background = ColorTranslator.FromHtml("#F8FAFC");
            public static Color Surface = ColorTranslator.FromHtml("#FFFFFF");
            public static Color SurfaceElevated = ColorTranslator.FromHtml("#F1F5F9");

            // Cores de texto
            public static Color TextPrimary = ColorTranslator.FromHtml("#1E293B");
            public static Color TextSecondary = ColorTranslator.FromHtml("#475569");
            public static Color TextMuted = ColorTranslator.FromHtml("#64748B");
            public static Color TextOnPrimary = Color.White;

            // Cores de estado
            public static Color Success = ColorTranslator.FromHtml("#10B981");
            public static Color SuccessLight = ColorTranslator.FromHtml("#34D399");
            public static Color Warning = ColorTranslator.FromHtml("#F59E0B");
            public static Color Error = ColorTranslator.FromHtml("#EF4444");

            // Cores de bordas
            public static Color Border = ColorTranslator.FromHtml("#E2E8F0");
            public static Color BorderLight = ColorTranslator.FromHtml("#F1F5F9");

            // Cores de gradiente
            public static Color GradientStart = ColorTranslator.FromHtml("#667EEA");
            public static Color GradientEnd = ColorTranslator.FromHtml("#764BA2");

            // Cores específicas para calendário
            public static Color CalendarHeader = ColorTranslator.FromHtml("#0F172A");
            public static Color CalendarHeaderGradient1 = ColorTranslator.FromHtml("#1E293B");
            public static Color CalendarHeaderGradient2 = ColorTranslator.FromHtml("#334155");
            public static Color CalendarToday = ColorTranslator.FromHtml("#DBEAFE");
            public static Color CalendarEvent = ColorTranslator.FromHtml("#FEF3C7");
            public static Color CalendarEventText = ColorTranslator.FromHtml("#92400E");
            public static Color CalendarOtherMonth = ColorTranslator.FromHtml("#F1F5F9");
            public static Color CalendarHover = ColorTranslator.FromHtml("#EFF6FF");
        }
        #endregion

        #region Tipografia Moderna
        public static class ModernFonts
        {
            public static Font Primary = new Font("Segoe UI", 10F, FontStyle.Regular);
            public static Font PrimaryBold = new Font("Segoe UI", 10F, FontStyle.Bold);
            public static Font Header = new Font("Segoe UI", 16F, FontStyle.Bold);
            public static Font SubHeader = new Font("Segoe UI", 14F, FontStyle.Bold);
            public static Font Small = new Font("Segoe UI", 8F, FontStyle.Regular);
            public static Font SmallBold = new Font("Segoe UI", 8F, FontStyle.Bold);
            public static Font Button = new Font("Segoe UI", 10F, FontStyle.Bold);
            public static Font CalendarDay = new Font("Segoe UI", 10F, FontStyle.Regular);
            public static Font CalendarHeader = new Font("Segoe UI", 20F, FontStyle.Bold);
            public static Font CalendarEvent = new Font("Segoe UI", 8F, FontStyle.Bold);
        }
        #endregion

        #region Calendar Styler
        public static class CalendarStyler
        {
            public static Button CreateModernButton(string text, Size size, Point location, Color startColor, Color endColor)
            {
                var button = new Button
                {
                    Text = text,
                    Size = size,
                    Location = location,
                    ForeColor = ModernColors.TextOnPrimary,
                    FlatStyle = FlatStyle.Flat,
                    Font = ModernFonts.Button,
                    Cursor = Cursors.Hand,
                    UseVisualStyleBackColor = false
                };

                button.FlatAppearance.BorderSize = 0;
                button.BackColor = startColor;

                button.MouseEnter += (s, e) => button.BackColor = endColor;
                button.MouseLeave += (s, e) => button.BackColor = startColor;

                AddDropShadow(button);

                return button;
            }

            public static Button CreateModernToggleButton(string text, Size size, Point location, bool isActive)
            {
                var button = new Button
                {
                    Text = text,
                    Size = size,
                    Location = location,
                    FlatStyle = FlatStyle.Flat,
                    Font = ModernFonts.Primary,
                    Cursor = Cursors.Hand,
                    UseVisualStyleBackColor = false
                };

                button.FlatAppearance.BorderSize = 0;
                UpdateToggleButtonStyle(button, isActive);

                return button;
            }

            public static void UpdateToggleButtonStyle(Button button, bool isActive)
            {
                if (isActive)
                {
                    button.BackColor = ModernColors.Primary;
                    button.ForeColor = ModernColors.TextOnPrimary;
                }
                else
                {
                    button.BackColor = ModernColors.SurfaceElevated;
                    button.ForeColor = ModernColors.TextSecondary;
                }
            }

            public static Panel CreateDayPanel(DateTime date, bool isCurrentMonth)
            {
                var panel = new Panel
                {
                    Dock = DockStyle.Fill,
                    BorderStyle = BorderStyle.None,
                    BackColor = isCurrentMonth ? ModernColors.Surface : ModernColors.CalendarOtherMonth,
                    Padding = new Padding(4),
                    Cursor = Cursors.Hand,
                    Margin = new Padding(1)
                };

                panel.Paint += (s, e) =>
                {
                    // Melhorar qualidade de renderização
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                    
                    using (var pen = new Pen(ModernColors.Border, 1))
                    {
                        e.Graphics.DrawRectangle(pen, 0, 0, panel.Width - 1, panel.Height - 1);
                    }
                };

                panel.MouseEnter += (s, e) =>
                {
                    panel.BackColor = ModernColors.CalendarHover;
                    panel.Invalidate();
                };

                panel.MouseLeave += (s, e) =>
                {
                    panel.BackColor = isCurrentMonth ? ModernColors.Surface : ModernColors.CalendarOtherMonth;
                    panel.Invalidate();
                };

                return panel;
            }

            public static Label CreateDayLabel(DateTime date, bool isCurrentMonth)
            {
                var label = new Label
                {
                    Text = date.Day.ToString(),
                    AutoSize = true,
                    Location = new Point(6, 4),
                    ForeColor = isCurrentMonth ? ModernColors.TextPrimary : ModernColors.TextMuted,
                    Font = date.Date == DateTime.Today ? ModernFonts.PrimaryBold : ModernFonts.CalendarDay,
                    BackColor = Color.Transparent
                };

                if (date.Date == DateTime.Today)
                {
                    label.BackColor = ModernColors.Primary;
                    label.ForeColor = ModernColors.TextOnPrimary;
                    label.Size = new Size(24, 20);
                    label.Location = new Point(4, 3);
                    label.TextAlign = ContentAlignment.MiddleCenter;

                    label.Paint += (s, e) =>
                    {
                        var lbl = s as Label;
                        using (var path = GetRoundedRectangle(new Rectangle(0, 0, lbl.Width, lbl.Height), 12))
                        {
                            lbl.Region = new Region(path);
                        }
                    };
                }

                return label;
            }

            public static Label CreateEventLabel(string text, int y)
            {
                return new Label
                {
                    Text = text,
                    AutoSize = false,
                    Size = new Size(70, 16),
                    Location = new Point(4, y),
                    ForeColor = ModernColors.CalendarEventText,
                    Font = ModernFonts.CalendarEvent,
                    BackColor = ModernColors.CalendarEvent,
                    TextAlign = ContentAlignment.MiddleCenter
                };
            }

            public static Panel CreateModernHeader(int height)
            {
                var panel = new Panel
                {
                    Height = height,
                    Dock = DockStyle.Top,
                    Padding = new Padding(25, 20, 25, 20)
                };

                panel.Paint += (s, e) =>
                {
                    var rect = panel.ClientRectangle;
                    using (var brush = new LinearGradientBrush(rect,
                        ModernColors.CalendarHeaderGradient1,
                        ModernColors.CalendarHeaderGradient2,
                        LinearGradientMode.Horizontal))
                    {
                        e.Graphics.FillRectangle(brush, rect);
                    }

                    using (var shadowBrush = new LinearGradientBrush(
                        new Rectangle(0, rect.Height - 4, rect.Width, 4),
                        Color.FromArgb(50, 0, 0, 0),
                        Color.Transparent,
                        LinearGradientMode.Vertical))
                    {
                        e.Graphics.FillRectangle(shadowBrush, 0, rect.Height - 4, rect.Width, 4);
                    }
                };

                return panel;
            }

            public static void StyleTableLayoutPanel(TableLayoutPanel table)
            {
                table.BackColor = ModernColors.Background;
                table.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
                table.Margin = new Padding(0);
                table.Padding = new Padding(8);
            }
        }
        #endregion

        #region Utilitários de Desenho
        public static GraphicsPath GetRoundedRectangle(Rectangle rect, int radius)
        {
            var path = new GraphicsPath();

            if (radius <= 0)
            {
                path.AddRectangle(rect);
                return path;
            }

            int diameter = radius * 2;
            Rectangle arcRect = new Rectangle(rect.Location, new Size(diameter, diameter));

            path.AddArc(arcRect, 180, 90);

            arcRect.X = rect.Right - diameter;
            path.AddArc(arcRect, 270, 90);

            arcRect.Y = rect.Bottom - diameter;
            path.AddArc(arcRect, 0, 90);

            arcRect.X = rect.Left;
            path.AddArc(arcRect, 90, 90);

            path.CloseAllFigures();
            return path;
        }

        public static void AddDropShadow(Control control)
        {
            control.Paint += (s, e) =>
            {
                var rect = control.ClientRectangle;

                using (var shadowBrush = new SolidBrush(Color.FromArgb(20, 0, 0, 0)))
                {
                    e.Graphics.FillRectangle(shadowBrush,
                        new Rectangle(rect.X + 2, rect.Y + 2, rect.Width, rect.Height));
                }
            };
        }

        public static LinearGradientBrush CreateGradientBrush(Rectangle rect, Color startColor, Color endColor, LinearGradientMode mode = LinearGradientMode.Vertical)
        {
            return new LinearGradientBrush(rect, startColor, endColor, mode);
        }
        #endregion

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
                grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                grid.RowHeadersVisible = false;
                grid.AllowUserToAddRows = false;
                grid.AllowUserToResizeRows = true;
                grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }

            public static void PersonalizarSaldoEstoque(DataGridView grid, double limiteEstoqueBaixo = 5)
            {
                Personalizar(grid);
                grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                foreach (DataGridViewColumn col in grid.Columns)
                {
                    if (col.ValueType == typeof(double) || col.ValueType == typeof(float) || col.ValueType == typeof(decimal) || col.ValueType == typeof(int))
                        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                grid.RowPrePaint += (s, e) =>
                {
                    var dgv = (DataGridView)s;
                    if (dgv.Columns.Contains("QuantidadeAtual"))
                    {
                        var qtd = dgv.Rows[e.RowIndex].Cells["QuantidadeAtual"].Value;
                        if (qtd != null && double.TryParse(qtd.ToString(), out double valor) && valor <= limiteEstoqueBaixo)
                        {
                            dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FEE2E2");
                            dgv.Rows[e.RowIndex].DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#991B1B");
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
            }

            [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
            private static extern IntPtr CreateRoundRectRgn(
                int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
                int nWidthEllipse, int nHeightEllipse);
        }

        #region Form Styler
        public static class FormStyler
        {
            /// <summary>
            /// Aplica estilo moderno a um formulário
            /// </summary>
            public static void ApplyModernStyle(Form form)
            {
                form.BackColor = ModernColors.Background;
                form.Font = ModernFonts.Primary;
            }

            /// <summary>
            /// Cria um header moderno para formulário
            /// </summary>
            public static Panel CreateFormHeader(string title, string subtitle = "", int height = 100)
            {
                var panel = new Panel
                {
                    Height = height,
                    Dock = DockStyle.Top,
                    Padding = new Padding(30, 20, 30, 20)
                };

                panel.Paint += (s, e) =>
                {
                    var rect = panel.ClientRectangle;
                    using (var brush = new LinearGradientBrush(rect, 
                        ModernColors.CalendarHeaderGradient1, 
                        ModernColors.CalendarHeaderGradient2, 
                        LinearGradientMode.Horizontal))
                    {
                        e.Graphics.FillRectangle(brush, rect);
                    }
                    
                    // Adicionar sombra sutil na parte inferior
                    using (var shadowBrush = new LinearGradientBrush(
                        new Rectangle(0, rect.Height - 6, rect.Width, 6),
                        Color.FromArgb(40, 0, 0, 0),
                        Color.Transparent,
                        LinearGradientMode.Vertical))
                    {
                        e.Graphics.FillRectangle(shadowBrush, 0, rect.Height - 6, rect.Width, 6);
                    }
                };

                // Título principal
                var lblTitle = new Label
                {
                    Text = title,
                    Dock = DockStyle.Top,
                    Height = string.IsNullOrEmpty(subtitle) ? height - 40 : 45,
                    ForeColor = ModernColors.TextOnPrimary,
                    Font = ModernFonts.CalendarHeader,
                    TextAlign = ContentAlignment.MiddleLeft,
                    BackColor = Color.Transparent
                };

                panel.Controls.Add(lblTitle);

                // Subtítulo (se fornecido)
                if (!string.IsNullOrEmpty(subtitle))
                {
                    var lblSubtitle = new Label
                    {
                        Text = subtitle,
                        Dock = DockStyle.Bottom,
                        Height = 25,
                        ForeColor = Color.FromArgb(200, 255, 255, 255),
                        Font = ModernFonts.Primary,
                        TextAlign = ContentAlignment.MiddleLeft,
                        BackColor = Color.Transparent
                    };
                    
                    panel.Controls.Add(lblSubtitle);
                }

                return panel;
            }

            /// <summary>
            /// Cria um footer moderno para formulário
            /// </summary>
            public static Panel CreateFormFooter(int height = 70)
            {
                var panel = new Panel
                {
                    Height = height,
                    Dock = DockStyle.Bottom,
                    BackColor = ModernColors.SurfaceElevated,
                    Padding = new Padding(30, 15, 30, 15)
                };

                // Adicionar borda superior sutil
                panel.Paint += (s, e) =>
                {
                    using (var pen = new Pen(ModernColors.Border, 1))
                    {
                        e.Graphics.DrawLine(pen, 0, 0, panel.Width, 0);
                    }
                };

                return panel;
            }

            /// <summary>
            /// Cria um painel de conteúdo moderno
            /// </summary>
            public static Panel CreateContentPanel(int padding = 30)
            {
                return new Panel
                {
                    Dock = DockStyle.Fill,
                    BackColor = ModernColors.Surface,
                    Padding = new Padding(padding)
                };
            }

            /// <summary>
            /// Cria um botão de ação moderno
            /// </summary>
            public static Button CreateActionButton(string text, bool isPrimary = true, Size? size = null)
            {
                var buttonSize = size ?? new Size(120, 45);
                
                var button = new Button
                {
                    Text = text,
                    Size = buttonSize,
                    ForeColor = ModernColors.TextOnPrimary,
                    FlatStyle = FlatStyle.Flat,
                    Font = ModernFonts.Button,
                    Cursor = Cursors.Hand,
                    UseVisualStyleBackColor = false,
                    BackColor = isPrimary ? ModernColors.Primary : ModernColors.TextSecondary
                };

                button.FlatAppearance.BorderSize = 0;

                // Efeito hover
                var originalColor = button.BackColor;
                var hoverColor = isPrimary ? ModernColors.PrimaryLight : ModernColors.TextMuted;
                
                button.MouseEnter += (s, e) => button.BackColor = hoverColor;
                button.MouseLeave += (s, e) => button.BackColor = originalColor;

                // Adicionar cantos arredondados
                button.Paint += (s, e) =>
                {
                    var rect = button.ClientRectangle;
                    using (var path = GetRoundedRectangle(rect, 8))
                    {
                        button.Region = new Region(path);
                    }
                };

                return button;
            }
        }
        #endregion

        #region Enhanced Grid Styler
        public static class EnhancedGridStyler
        {
            /// <summary>
            /// Aplica estilo moderno avançado ao DataGridView
            /// </summary>
            public static void ApplyModernStyle(DataGridView grid)
            {
                // Configurações básicas
                grid.BorderStyle = BorderStyle.None;
                grid.BackgroundColor = ModernColors.Background;
                grid.EnableHeadersVisualStyles = false;
                grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                grid.GridColor = ModernColors.Border;

                // Header styling
                grid.ColumnHeadersDefaultCellStyle.BackColor = ModernColors.SurfaceElevated;
                grid.ColumnHeadersDefaultCellStyle.ForeColor = ModernColors.TextPrimary;
                grid.ColumnHeadersDefaultCellStyle.Font = ModernFonts.PrimaryBold;
                grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = ModernColors.SurfaceElevated;
                grid.ColumnHeadersDefaultCellStyle.SelectionForeColor = ModernColors.TextPrimary;
                grid.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 4, 8, 4);
                grid.ColumnHeadersHeight = 50;
                grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

                // Cell styling
                grid.DefaultCellStyle.BackColor = ModernColors.Surface;
                grid.DefaultCellStyle.ForeColor = ModernColors.TextPrimary;
                grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(40, ModernColors.Primary.R, ModernColors.Primary.G, ModernColors.Primary.B);
                grid.DefaultCellStyle.SelectionForeColor = ModernColors.Primary;
                grid.DefaultCellStyle.Font = ModernFonts.Primary;
                grid.DefaultCellStyle.Padding = new Padding(8, 4, 8, 4);
                grid.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

                // Row styling
                grid.RowTemplate.Height = 55;
                grid.AlternatingRowsDefaultCellStyle.BackColor = ModernColors.SurfaceElevated;
                grid.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(40, ModernColors.Primary.R, ModernColors.Primary.G, ModernColors.Primary.B);

                // Behavior
                grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                grid.RowHeadersVisible = false;
                grid.AllowUserToAddRows = false;
                grid.AllowUserToResizeRows = false;
                grid.AllowUserToResizeColumns = true;
                grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                grid.MultiSelect = false;
                grid.ScrollBars = ScrollBars.Both;

                // Performance settings
                grid.VirtualMode = false;
                grid.AutoGenerateColumns = true;

                // Eventos para hover effect melhorado
                grid.CellMouseEnter += Grid_CellMouseEnter;
                grid.CellMouseLeave += Grid_CellMouseLeave;
                grid.Paint += Grid_Paint;
            }

            private static void Grid_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
            {
                var grid = sender as DataGridView;
                if (grid != null && e.RowIndex >= 0 && e.RowIndex < grid.Rows.Count)
                {
                    try
                    {
                        var row = grid.Rows[e.RowIndex];
                        row.DefaultCellStyle.BackColor = ModernColors.CalendarHover;
                        grid.InvalidateRow(e.RowIndex);
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine($"Erro no hover enter: {ex.Message}");
                    }
                }
            }

            private static void Grid_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
            {
                var grid = sender as DataGridView;
                if (grid != null && e.RowIndex >= 0 && e.RowIndex < grid.Rows.Count)
                {
                    try
                    {
                        var row = grid.Rows[e.RowIndex];
                        var isAlternating = e.RowIndex % 2 != 0;
                        row.DefaultCellStyle.BackColor = isAlternating ? ModernColors.SurfaceElevated : ModernColors.Surface;
                        grid.InvalidateRow(e.RowIndex);
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine($"Erro no hover leave: {ex.Message}");
                    }
                }
            }

            private static void Grid_Paint(object sender, PaintEventArgs e)
            {
                // Melhorar qualidade de renderização
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            }
        }
        #endregion

        #region Custom Controls
        /// <summary>
        /// DataGridView personalizado com renderização otimizada
        /// </summary>
        public class OptimizedDataGridView : DataGridView
        {
            public OptimizedDataGridView()
            {
                // Configurar renderização otimizada
                this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | 
                             ControlStyles.DoubleBuffer | ControlStyles.ResizeRedraw, true);
                
                // Outras otimizações
                this.UpdateStyles();
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                // Melhorar qualidade de renderização
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                
                base.OnPaint(e);
            }
        }

        /// <summary>
        /// Panel personalizado com renderização otimizada
        /// </summary>
        public class OptimizedPanel : Panel
        {
            public OptimizedPanel()
            {
                // Configurar renderização otimizada
                this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | 
                             ControlStyles.DoubleBuffer | ControlStyles.ResizeRedraw, true);
                
                // Outras otimizações
                this.UpdateStyles();
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                // Melhorar qualidade de renderização
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                
                base.OnPaint(e);
            }
        }
        #endregion
    }
}
