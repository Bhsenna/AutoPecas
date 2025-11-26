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
        #region Paleta de Cores Moderna Refinada
        public static class ModernColors
        {
            // Cores principais (azul mais vibrante)
            public static Color Primary = ColorTranslator.FromHtml("#3B82F6");        // Blue-500
            public static Color PrimaryLight = ColorTranslator.FromHtml("#60A5FA");   // Blue-400
            public static Color PrimaryDark = ColorTranslator.FromHtml("#2563EB");    // Blue-600
            public static Color PrimaryDeep = ColorTranslator.FromHtml("#1E3A8A");    // Blue-900 - Sidebar

            // Cores de fundo (mais suaves)
            public static Color Background = ColorTranslator.FromHtml("#F8FAFC");     // Slate-50
            public static Color Surface = ColorTranslator.FromHtml("#FFFFFF");        // Branco puro
            public static Color SurfaceElevated = ColorTranslator.FromHtml("#F1F5F9"); // Slate-100

            // Cores de texto (melhor contraste)
            public static Color TextPrimary = ColorTranslator.FromHtml("#1E293B");    // Slate-800
            public static Color TextSecondary = ColorTranslator.FromHtml("#475569");  // Slate-600
            public static Color TextMuted = ColorTranslator.FromHtml("#64748B");      // Slate-500
            public static Color TextOnPrimary = Color.White;

            // Cores de estado
            public static Color Success = ColorTranslator.FromHtml("#10B981");        // Green-500
            public static Color SuccessLight = ColorTranslator.FromHtml("#34D399");   // Green-400
            public static Color SuccessGreen = ColorTranslator.FromHtml("#10B981");   // Alias
            public static Color Warning = ColorTranslator.FromHtml("#F59E0B");        // Amber-500
            public static Color WarningLight = ColorTranslator.FromHtml("#FCD34D");   // Amber-300
            public static Color WarningAmber = ColorTranslator.FromHtml("#F59E0B");   // Alias
            public static Color Error = ColorTranslator.FromHtml("#EF4444");          // Red-500
            public static Color ErrorLight = ColorTranslator.FromHtml("#F87171");     // Red-400
            public static Color ErrorRed = ColorTranslator.FromHtml("#EF4444");       // Alias
            public static Color Info = ColorTranslator.FromHtml("#3B82F6");           // Mesmo que Primary

            // Cores de bordas (mais sutis)
            public static Color Border = ColorTranslator.FromHtml("#E2E8F0");         // Slate-200
            public static Color BorderLight = ColorTranslator.FromHtml("#F1F5F9");    // Slate-100

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

        #region Sistema de Espaçamento Consistente
        public static class Spacing
        {
            public const int XS = 4;    // Margem mínima
            public const int SM = 8;    // Espaçamento pequeno
            public const int MD = 16;   // Espaçamento padrão
            public const int LG = 24;   // Espaçamento grande
            public const int XL = 32;   // Espaçamento extra grande
            public const int XXL = 48;  // Espaçamento máximo
        }
        #endregion

        #region Tipografia Moderna Expandida
        public static class ModernFonts
        {
            private const string FontFamily = "Segoe UI";

            // Hierarquia de tamanhos
            public static Font DisplayLarge = new Font(FontFamily, 32F, FontStyle.Bold);
            public static Font DisplayMedium = new Font(FontFamily, 28F, FontStyle.Bold);
            public static Font HeadlineLarge = new Font(FontFamily, 24F, FontStyle.Bold);
            public static Font HeadlineMedium = new Font(FontFamily, 20F, FontStyle.Bold);
            public static Font TitleLarge = new Font(FontFamily, 16F, FontStyle.Bold);
            public static Font TitleMedium = new Font(FontFamily, 14F, FontStyle.Bold);
            public static Font BodyLarge = new Font(FontFamily, 14F, FontStyle.Regular);
            public static Font BodyMedium = new Font(FontFamily, 12F, FontStyle.Regular);
            public static Font BodySmall = new Font(FontFamily, 10F, FontStyle.Regular);
            public static Font Caption = new Font(FontFamily, 9F, FontStyle.Regular);

            // Variações existentes (compatibilidade)
            public static Font Primary = new Font(FontFamily, 10F, FontStyle.Regular);
            public static Font PrimaryBold = new Font(FontFamily, 10F, FontStyle.Bold);
            public static Font Header = new Font(FontFamily, 16F, FontStyle.Bold);
            public static Font SubHeader = new Font(FontFamily, 14F, FontStyle.Bold);
            public static Font Small = new Font(FontFamily, 8F, FontStyle.Regular);
            public static Font SmallBold = new Font(FontFamily, 8F, FontStyle.Bold);
            public static Font Button = new Font(FontFamily, 10F, FontStyle.Bold);
            public static Font CalendarDay = new Font(FontFamily, 10F, FontStyle.Regular);
            public static Font CalendarHeader = new Font(FontFamily, 20F, FontStyle.Bold);
            public static Font CalendarEvent = new Font(FontFamily, 8F, FontStyle.Bold);

            // Contextos específicos
            public static Font ButtonText = new Font(FontFamily, 12F, FontStyle.Bold);
            public static Font TableHeader = new Font(FontFamily, 11F, FontStyle.Bold);
            public static Font TableCell = new Font(FontFamily, 11F, FontStyle.Regular);
            public static Font MoneyLarge = new Font(FontFamily, 32F, FontStyle.Bold);
            public static Font MoneyMedium = new Font(FontFamily, 20F, FontStyle.Bold);
        }
        #endregion

        #region Paleta de Cores para Gráficos
        public static class ChartColors
        {
            // Cores principais para diferentes categorias (acessibilidade considerada)
            public static Color[] CategoryColors = new[]
            {
                ColorTranslator.FromHtml("#3B82F6"),  // Blue-500
                ColorTranslator.FromHtml("#10B981"),  // Green-500
                ColorTranslator.FromHtml("#F59E0B"),  // Amber-500
                ColorTranslator.FromHtml("#EF4444"),  // Red-500
                ColorTranslator.FromHtml("#8B5CF6"),  // Violet-500
                ColorTranslator.FromHtml("#EC4899"),  // Pink-500
                ColorTranslator.FromHtml("#14B8A6"),  // Teal-500
                ColorTranslator.FromHtml("#F97316")   // Orange-500
            };

            // Gradientes para áreas e barras
            public static LinearGradientBrush CreateFaturamentoGradient(Rectangle rect)
            {
                return new LinearGradientBrush(rect,
                    ColorTranslator.FromHtml("#3B82F6"),  // Primary
                    ColorTranslator.FromHtml("#60A5FA"),  // PrimaryLight
                    LinearGradientMode.Vertical);
            }

            public static LinearGradientBrush CreateLucroGradient(Rectangle rect)
            {
                return new LinearGradientBrush(rect,
                    ColorTranslator.FromHtml("#10B981"),  // Success
                    ColorTranslator.FromHtml("#34D399"),  // SuccessLight
                    LinearGradientMode.Vertical);
            }
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

        #region Grid Styler
        public static class GridStyler
        {
            public static void Personalizar(DataGridView grid)
            {
                grid.BorderStyle = BorderStyle.None;
                grid.BackgroundColor = ModernColors.Background;
                grid.EnableHeadersVisualStyles = false;

                grid.ColumnHeadersDefaultCellStyle.BackColor = ModernColors.PrimaryDeep;
                grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                grid.ColumnHeadersDefaultCellStyle.Font = ModernFonts.TableHeader;
                grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                grid.DefaultCellStyle.BackColor = ModernColors.Surface;
                grid.DefaultCellStyle.ForeColor = ModernColors.TextPrimary;
                grid.DefaultCellStyle.SelectionBackColor = ModernColors.Primary;
                grid.DefaultCellStyle.SelectionForeColor = Color.White;
                grid.DefaultCellStyle.Font = ModernFonts.TableCell;
                grid.RowTemplate.Height = 30;

                grid.GridColor = ModernColors.Border;
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
        #endregion

        #region Button Styler
        public static class ButtonStyler
        {
            public static void PersonalizaGravar(Button button)
            {
                button.BackColor = ModernColors.Success;
                button.ForeColor = Color.White;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.Font = ModernFonts.ButtonText;
                button.Height = 36;
                button.Width = 100;
            }
            public static void PersonalizaLimpar(Button button)
            {
                button.BackColor = ModernColors.Error;
                button.ForeColor = Color.White;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.Font = ModernFonts.ButtonText;
                button.Height = 36;
                button.Width = 100;
            }

            [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
            private static extern IntPtr CreateRoundRectRgn(
                int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
                int nWidthEllipse, int nHeightEllipse);
        }
        #endregion

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
                        ModernColors.Primary, 
                        ModernColors.PrimaryLight, 
                        LinearGradientMode.Horizontal))
                    {
                        e.Graphics.FillRectangle(brush, rect);
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

                // Borda superior mais sutil
                panel.Paint += (s, e) =>
                {
                    using (var pen = new Pen(Color.FromArgb(30, ModernColors.Border.R, ModernColors.Border.G, ModernColors.Border.B), 1))
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

                // Row styling com melhor espaçamento
                grid.RowTemplate.Height = 65;
                grid.AlternatingRowsDefaultCellStyle.BackColor = ModernColors.SurfaceElevated;
                grid.AlternatingRowsDefaultCellStyle.ForeColor = ModernColors.TextPrimary;
                grid.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(40, ModernColors.Primary.R, ModernColors.Primary.G, ModernColors.Primary.B);
                grid.AlternatingRowsDefaultCellStyle.SelectionForeColor = ModernColors.Primary;

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

        #region Card Styler
        public static class CardStyler
        {
            public enum Elevation
            {
                None = 0,
                Low = 1,
                Medium = 2,
                High = 3
            }

            public static Panel CreateModernCard(Size size, Elevation elevation = Elevation.Low)
            {
                var card = new Panel
                {
                    Size = size,
                    BackColor = ModernColors.Surface,
                    Padding = new Padding(Spacing.LG),
                    BorderStyle = BorderStyle.None
                };

                card.Paint += (s, e) =>
                {
                    var rect = card.ClientRectangle;
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                    using (var pen = new Pen(ModernColors.Border, 1))
                    {
                        e.Graphics.DrawRectangle(pen, 0, 0, rect.Width - 1, rect.Height - 1);
                    }

                    if (elevation != Elevation.None)
                    {
                        DrawElevationShadow(e.Graphics, rect, elevation);
                    }
                };

                card.MouseEnter += (s, e) =>
                {
                    card.BackColor = ModernColors.SurfaceElevated;
                    card.Cursor = Cursors.Hand;
                    card.Invalidate();
                };

                card.MouseLeave += (s, e) =>
                {
                    card.BackColor = ModernColors.Surface;
                    card.Invalidate();
                };

                return card;
            }

            private static void DrawElevationShadow(Graphics g, Rectangle rect, Elevation elevation)
            {
                int depth = elevation switch
                {
                    Elevation.Low => 4,
                    Elevation.Medium => 8,
                    Elevation.High => 12,
                    _ => 0
                };

                for (int i = 0; i < depth; i++)
                {
                    int alpha = (int)(15 * (1 - (float)i / depth));
                    using (var brush = new SolidBrush(Color.FromArgb(alpha, 0, 0, 0)))
                    {
                        g.FillRectangle(brush, rect.X + i + 1, rect.Y + depth, rect.Width - 1, 1);
                        g.FillRectangle(brush, rect.X + depth, rect.Y + i + 1, 1, rect.Height - 1);
                    }
                }
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
                this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | 
                             ControlStyles.DoubleBuffer | ControlStyles.ResizeRedraw, true);
                
                this.UpdateStyles();
            }

            protected override void OnPaint(PaintEventArgs e)
            {
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
                this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | 
                             ControlStyles.DoubleBuffer | ControlStyles.ResizeRedraw, true);
                
                this.UpdateStyles();
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                
                base.OnPaint(e);
            }
        }
        #endregion

        #region Sistema de Feedback Visual
        public static class InteractionStyler
        {
            public enum ButtonStyle
            {
                Primary,
                Success,
                Danger,
                Secondary
            }

            public static void ApplyButtonStates(Button button, ButtonStyle style)
            {
                var (normal, hover, active, disabled) = GetButtonColors(style);

                button.BackColor = normal;
                button.FlatAppearance.MouseOverBackColor = hover;
                button.FlatAppearance.MouseDownBackColor = active;

                button.MouseEnter += (s, e) =>
                {
                    button.BackColor = hover;
                    button.Cursor = Cursors.Hand;
                };

                button.MouseLeave += (s, e) =>
                {
                    button.BackColor = button.Enabled ? normal : disabled;
                };

                button.MouseDown += (s, e) =>
                {
                    button.BackColor = active;
                };

                button.MouseUp += (s, e) =>
                {
                    button.BackColor = hover;
                };

                button.EnabledChanged += (s, e) =>
                {
                    button.BackColor = button.Enabled ? normal : disabled;
                    button.ForeColor = button.Enabled 
                        ? ModernColors.TextOnPrimary 
                        : ModernColors.TextMuted;
                };
            }

            private static (Color normal, Color hover, Color active, Color disabled) 
                GetButtonColors(ButtonStyle style)
            {
                return style switch
                {
                    ButtonStyle.Primary => (
                        ModernColors.Primary,
                        ModernColors.PrimaryLight,
                        ModernColors.PrimaryDark,
                        ModernColors.Border
                    ),
                    ButtonStyle.Success => (
                        ModernColors.SuccessGreen,
                        ColorTranslator.FromHtml("#34D399"),
                        ColorTranslator.FromHtml("#059669"),
                        ModernColors.Border
                    ),
                    ButtonStyle.Danger => (
                        ModernColors.ErrorRed,
                        ColorTranslator.FromHtml("#F87171"),
                        ColorTranslator.FromHtml("#DC2626"),
                        ModernColors.Border
                    ),
                    _ => (ModernColors.TextSecondary, ModernColors.TextPrimary, 
                          ModernColors.TextMuted, ModernColors.Border)
                };
            }
        }
        #endregion
    }
}
