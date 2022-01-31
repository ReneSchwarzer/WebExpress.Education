using WebExpress.Internationalization;
using WebExpress.UI.WebControl;
using WebExpress.WebAttribute;
using WebExpress.WebResource;

namespace Education.WebPage
{
    [ID("SplitPanel")]
    [Title("education:page.control.panelsplit.name")]
    [Segment("splitpanel", "education:page.control.panelsplit.name")]
    [Path("/Control")]
    [Module("edu")]
    [Context("control")]
    public sealed class PagePanelSplit : PageControlBase
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PagePanelSplit()
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        /// <param name="context">Der Kontext</param>
        public override void Initialization(IResourceContext context)
        {
            base.Initialization(context);

            Description = this.I18N("page.control.panelsplit.description");
            Code = "new ControlPanelSplit() { }";

            AddExample
            (
                new ControlPanelSplit
                (
                    "example",
                    new Control[] { new ControlText() { Text = "Links", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) } },
                    new Control[] { new ControlText() { Text = "Rechts", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) } }
                )
                {
                }
            );

            // Eigenschaften
            AddProperty
            (
                "Orientation",
                "Legt die Ausrichtung fest.",
                "Orientation = TypeOrientationSplit.Horizontal",
                new ControlText() { Text = "Horizontal", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelSplit
                (
                    "horizontal-split",
                    new Control[] { new ControlText() { Text = "Links", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) } },
                    new Control[] { new ControlText() { Text = "Rechts", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) } }
                )
                {
                    Orientation = TypeOrientationSplit.Horizontal
                },
                new ControlText() { Text = "Vertical", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelSplit
                (
                    "vertical-split",
                    new Control[] { new ControlText() { Text = "Links", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) } },
                    new Control[] { new ControlText() { Text = "Rechts", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) } }
                )
                {
                    Orientation = TypeOrientationSplit.Vertical
                }
            );

            AddProperty
            (
                "SplitterColor",
                "Legt die Farbe des Splitters fest.",
                "SplitterColor = new PropertyColorBackground(TypeColorBackground.Danger)",
                new ControlText() { Text = "Primary", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelSplit
                (
                    "primary-split",
                    new Control[] { new ControlText() { Text = "Links", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) } },
                    new Control[] { new ControlText() { Text = "Rechts", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) } }
                )
                {
                    Orientation = TypeOrientationSplit.Horizontal,
                    SplitterColor = new PropertyColorBackground(TypeColorBackground.Primary)
                },
                new ControlText() { Text = "Secondary", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelSplit
                (
                    "secondary-split",
                    new Control[] { new ControlText() { Text = "Links", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) } },
                    new Control[] { new ControlText() { Text = "Rechts", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) } }
                )
                {
                    Orientation = TypeOrientationSplit.Horizontal,
                    SplitterColor = new PropertyColorBackground(TypeColorBackground.Secondary)
                },
                new ControlText() { Text = "Info", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelSplit
                (
                    "info-split",
                    new Control[] { new ControlText() { Text = "Links", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) } },
                    new Control[] { new ControlText() { Text = "Rechts", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) } }
                )
                {
                    Orientation = TypeOrientationSplit.Horizontal,
                    SplitterColor = new PropertyColorBackground(TypeColorBackground.Info)
                },
                new ControlText() { Text = "Success", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelSplit
                (
                    "success-split",
                    new Control[] { new ControlText() { Text = "Links", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) } },
                    new Control[] { new ControlText() { Text = "Rechts", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) } }
                )
                {
                    Orientation = TypeOrientationSplit.Horizontal,
                    SplitterColor = new PropertyColorBackground(TypeColorBackground.Success)
                },
                new ControlText() { Text = "Warning", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelSplit
                (
                    "warning-split",
                    new Control[] { new ControlText() { Text = "Links", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) } },
                    new Control[] { new ControlText() { Text = "Rechts", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) } }
                )
                {
                    Orientation = TypeOrientationSplit.Horizontal,
                    SplitterColor = new PropertyColorBackground(TypeColorBackground.Warning)
                },
                new ControlText() { Text = "Danger", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelSplit
                (
                    "danger-split",
                    new Control[] { new ControlText() { Text = "Links", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) } },
                    new Control[] { new ControlText() { Text = "Rechts", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) } }
                )
                {
                    Orientation = TypeOrientationSplit.Horizontal,
                    SplitterColor = new PropertyColorBackground(TypeColorBackground.Danger)
                },
                new ControlText() { Text = "Light", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelSplit
                (
                    "light-split",
                    new Control[] { new ControlText() { Text = "Links", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) } },
                    new Control[] { new ControlText() { Text = "Rechts", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) } }
                )
                {
                    Orientation = TypeOrientationSplit.Horizontal,
                    SplitterColor = new PropertyColorBackground(TypeColorBackground.Light)
                },
                new ControlText() { Text = "Dark", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelSplit
                (
                    "dark-split",
                    new Control[] { new ControlText() { Text = "Links", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) } },
                    new Control[] { new ControlText() { Text = "Rechts", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) } }
                )
                {
                    Orientation = TypeOrientationSplit.Horizontal,
                    SplitterColor = new PropertyColorBackground(TypeColorBackground.Dark)
                },
                new ControlText() { Text = "White", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelSplit
                (
                    "white-split",
                    new Control[] { new ControlText() { Text = "Links", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) } },
                    new Control[] { new ControlText() { Text = "Rechts", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) } }
                )
                {
                    Orientation = TypeOrientationSplit.Horizontal,
                    SplitterColor = new PropertyColorBackground(TypeColorBackground.White)
                },
                new ControlText() { Text = "Transparent", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelSplit
                (
                    "transparent-split",
                    new Control[] { new ControlText() { Text = "Links", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) } },
                    new Control[] { new ControlText() { Text = "Rechts", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) } }
                )
                {
                    Orientation = TypeOrientationSplit.Horizontal,
                    SplitterColor = new PropertyColorBackground(TypeColorBackground.Transparent)
                },
                new ControlText() { Text = "Benutzerdefiniert", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelSplit
                (
                    "gold-split",
                    new Control[] { new ControlText() { Text = "Links", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) } },
                    new Control[] { new ControlText() { Text = "Rechts", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) } }
                )
                {
                    Orientation = TypeOrientationSplit.Horizontal,
                    SplitterColor = new PropertyColorBackground("gold")
                }
            );

            AddProperty
            (
                "SplitterSize",
                "Legt die Breite des Splitters fest.",
                "SplitterSize = 12",
                new ControlText() { Text = "2", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelSplit
                (
                    "thin-split",
                    new Control[] { new ControlText() { Text = "Links", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) } },
                    new Control[] { new ControlText() { Text = "Rechts", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) } }
                )
                {
                    Orientation = TypeOrientationSplit.Horizontal,
                    SplitterColor = new PropertyColorBackground(TypeColorBackground.Danger),
                    SplitterSize = 2
                },
                new ControlText() { Text = "12", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelSplit
                (
                    "bold-split",
                    new Control[] { new ControlText() { Text = "Links", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) } },
                    new Control[] { new ControlText() { Text = "Rechts", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) } }
                )
                {
                    Orientation = TypeOrientationSplit.Horizontal,
                    SplitterColor = new PropertyColorBackground(TypeColorBackground.Danger),
                    SplitterSize = 12
                }
            );

            AddProperty
            (
                "Panel1MinSize",
                "Legt minimale Größe der linken Seite oder des oberen Bereiches fest.",
                "Panel1MinSize = 100",
                new ControlText() { Text = "50", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelSplit
                (
                    "less1-split",
                    new Control[] { new ControlText() { Text = "Links", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) } },
                    new Control[] { new ControlText() { Text = "Rechts", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) } }
                )
                {
                    Orientation = TypeOrientationSplit.Horizontal,
                    SplitterColor = new PropertyColorBackground(TypeColorBackground.Danger),
                    Panel1MinSize = 50
                },
                new ControlText() { Text = "100", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelSplit
                (
                    "more1-split",
                    new Control[] { new ControlText() { Text = "Links", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) } },
                    new Control[] { new ControlText() { Text = "Rechts", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) } }
                )
                {
                    Orientation = TypeOrientationSplit.Horizontal,
                    SplitterColor = new PropertyColorBackground(TypeColorBackground.Danger),
                    Panel1MinSize = 100
                }
            );

            AddProperty
            (
                "Panel2MinSize",
                "Legt minimale Größe der rechten Seite oder des unteren Bereiches fest.",
                "Panel2MinSize = 100",
                new ControlText() { Text = "50", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelSplit
                (
                    "less2-split",
                    new Control[] { new ControlText() { Text = "Links", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) } },
                    new Control[] { new ControlText() { Text = "Rechts", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) } }
                )
                {
                    Orientation = TypeOrientationSplit.Horizontal,
                    SplitterColor = new PropertyColorBackground(TypeColorBackground.Danger),
                    Panel2MinSize = 50
                },
                new ControlText() { Text = "100", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelSplit
                (
                    "more2-split",
                    new Control[] { new ControlText() { Text = "Links", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) } },
                    new Control[] { new ControlText() { Text = "Rechts", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) } }
                )
                {
                    Orientation = TypeOrientationSplit.Horizontal,
                    SplitterColor = new PropertyColorBackground(TypeColorBackground.Danger),
                    Panel2MinSize = 100
                }
            );

            AddProperty
            (
                "Panel1InitialSize",
                "Legt anfängliche Größe in % der linken Seite oder des oberen Bereiches fest.",
                "Panel1InitialSize = 25",
                new ControlText() { Text = "50", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelSplit
                (
                    "init1-split",
                    new Control[] { new ControlText() { Text = "Links", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) } },
                    new Control[] { new ControlText() { Text = "Rechts", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) } }
                )
                {
                    Orientation = TypeOrientationSplit.Horizontal,
                    SplitterColor = new PropertyColorBackground(TypeColorBackground.Danger),
                    Panel1MinSize = 50,
                    Panel1InitialSize = 25
                }
            );

            AddProperty
            (
                "Panel2InitialSize",
                "Legt anfängliche Größe in % der rechten Seite oder des unteren Bereiches fest.",
                "Panel2InitialSize = 25",
                new ControlText() { Text = "50", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelSplit
                (
                    "init2-split",
                    new Control[] { new ControlText() { Text = "Links", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) } },
                    new Control[] { new ControlText() { Text = "Rechts", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) } }
                )
                {
                    Orientation = TypeOrientationSplit.Horizontal,
                    SplitterColor = new PropertyColorBackground(TypeColorBackground.Danger),
                    Panel1MinSize = 50,
                    Panel2InitialSize = 25
                }
            );
        }
    }
}
