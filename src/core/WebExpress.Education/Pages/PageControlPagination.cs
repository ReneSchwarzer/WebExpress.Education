using WebExpress.UI.Controls;

namespace Education.Pages
{
    public class PageControlPagination : PageControlBase
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlPagination()
            : base("ControlPagination")
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        public override void Init()
        {
            base.Init();

            Description = "Das ControlPagination stellt Seitenverzeichnis bereit.";
            Code = "new ControlPagination() { }";

            AddExample
            (
                new ControlPagination()
                {
                    PageCount = 3
                }
            );
            // Eigenschaften
            AddProperty
            (
                "PageCount",
                "Bestimmt die Anzahl der Seiten.",
                "PageCount = 10",
                new ControlText() { Text = "Standard", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPagination()
                {
                    PageCount = 10,
                    MaxDisplayCount = 10
                }
            );

            AddProperty
            (
                "MaxDisplayCount",
                "Bestimmt die maximale Anzahl der Seitenschaltflächen.",
                "MaxDisplayCount = 5",
                new ControlText() { Text = "Standard", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPagination()
                {
                    PageCount = 10,
                    MaxDisplayCount = 5
                }
            );

            AddProperty
            (
                "PageOffset",
                "Bestimmt die aktuelle Seite. " +
                "Hinwies! Die Zählung auf der gerenderten Seite beginnt mit 1, im Code mit 0",
                "PageOffset = 3",
                new ControlText() { Text = "Standard", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPagination()
                {
                    PageCount = 10,
                    PageOffset = 3
                }
            );
            
            AddProperty
            (
                "PageSize",
                "Bestimmt die Seitengröße. ",
                "PageSize = 5",
                new ControlText() { Text = "Standard", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPagination()
                {
                    PageCount = 10,
                    PageSize = 5
                }
            );

            AddProperty
            (
                "Size",
                "Bestimmt die Größe.",
                "Size = TypeSizeButton.Small",
                new ControlText() { Text = "Small", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPagination()
                {
                    PageCount = 10,
                    Size = TypeSizePagination.Small
                },
                new ControlText() { Text = "Standard", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPagination()
                {
                    PageCount = 10,
                    Size = TypeSizePagination.Default
                },
                new ControlText() { Text = "Large", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPagination()
                {
                    PageCount = 10,
                    Size = TypeSizePagination.Large
                }
            );

            AddProperty
            (
                "HorizontalAlignment",
                "Bestimmt die horizontale Anordnung.",
                "HorizontalAlignment = TypeHorizontalAlignment.Left",
                new ControlText() { Text = "Standardausrichtung", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPagination()
                {
                    PageCount = 10,
                    HorizontalAlignment = TypeHorizontalAlignment.Default,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Null, PropertySpacing.Space.Two)
                },
                new ControlText() { Text = "Ausrichtung links", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPagination()
                {
                    PageCount = 10,
                    HorizontalAlignment = TypeHorizontalAlignment.Left,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Null, PropertySpacing.Space.Two)
                },
                new ControlText() { Text = "Ausrichtung rechts", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPagination()
                {
                    PageCount = 10,
                    HorizontalAlignment = TypeHorizontalAlignment.Right,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Null, PropertySpacing.Space.Two)
                }
            );

            AddProperty
            (
                "BackgroundColor",
                "Legt die Farbe fest.",
                "BackgroundColor = new PropertyColorBackground(TypeColorBackground.Primary)",
                new ControlText() { Text = "Standard", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPagination()
                {
                    PageCount = 3
                },
                new ControlText() { Text = "Primär", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPagination()
                {
                    PageCount = 3,
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Primary)
                },
                new ControlText() { Text = "Sekundär", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPagination()
                {
                    PageCount = 3,
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Secondary)
                },
                new ControlText() { Text = "Info", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPagination()
                {
                    PageCount = 3,
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Info)
                },
                new ControlText() { Text = "Erfolg", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPagination()
                {
                    PageCount = 3,
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Success)
                },
                new ControlText() { Text = "Warnung", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPagination()
                {
                    PageCount = 3,
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning),
                    BorderColor = new PropertyColorBorder(TypeColorBorder.Warning)
                },
                new ControlText() { Text = "Fehler", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPagination()
                {
                    PageCount = 3,
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Danger)
                },
                new ControlText() { Text = "Dunkel", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPagination()
                {
                    PageCount = 3,
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Dark)
                },
                new ControlText() { Text = "Hell", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPagination()
                {
                    PageCount = 3,
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light)
                },
                new ControlText() { Text = "Benutzerdefiniert", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPagination()
                {
                    PageCount = 3,
                    BackgroundColor = new PropertyColorBackground("gold")
                }
            );          
        }

        /// <summary>
        /// Verarbeitung
        /// </summary>
        public override void Process()
        {
            base.Process();
        }
    }
}
