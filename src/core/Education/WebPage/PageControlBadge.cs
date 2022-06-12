using WebExpress.UI.WebControl;
using WebExpress.WebAttribute;
using WebExpress.WebResource;

namespace Education.WebPage
{
    [Id("Badge")]
    [Title("education:page.control.badge.name")]
    [Segment("badge", "education:page.control.badge.name")]
    [Path("/Control")]
    [Module("edu")]
    [Context("control")]
    public sealed class PageControlBadge : PageControlBase
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlBadge()
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        /// <param name="context">Der Kontext</param>
        public override void Initialization(IResourceContext context)
        {
            base.Initialization(context);

            Description = "Das ControlBadge kann zum Anzeigen eines Abzeichens (z.B. Anzahl der neuen Nachrichten) eingesetzt werden.";
            Code = "new ControlBadge() { Value = \"Neu\", BackgroundColor = new PropertyColorBackground(TypesBackgroundColor.Success) }";

            AddExample
            (
                new ControlBadge()
                {
                    Value = "Standard"
                },
                new ControlBadge()
                {
                    Value = "Primär",
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Primary)
                },
                new ControlBadge()
                {
                    Value = "Sekundär",
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Secondary)
                },
                new ControlBadge()
                {
                    Value = "Info",
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Info)
                },
                new ControlBadge()
                {
                    Value = "Erfolg",
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Success)
                },
                new ControlBadge()
                {
                    Value = "Warnung",
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Warning)
                },
                new ControlBadge()
                {
                    Value = "Fehler",
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Danger)
                },
                new ControlBadge()
                {
                    Value = "Dunkel",
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Dark)
                },
                new ControlBadge()
                {
                    Value = "Hell",
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Light)
                },
                new ControlBadge()
                {
                    Value = "Weiß",
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.White)
                },
                new ControlBadge()
                {
                    Value = "Transparent",
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Transparent)
                },
                new ControlBadge()
                {
                    Value = "Benutzerdefiniert",
                    TextColor = new PropertyColorText("red"),
                    BackgroundColor = new PropertyColorBackgroundBadge("gold")
                }
            );

            // Eigenschaften
            AddProperty
            (
                "Pill",
                "Ändert das Design und fügt stärker abgerundete Ecken ein.",
                "Pill = TypePillBadge.Pill",
                new ControlBadge()
                {
                    Value = "Standard",
                    Pill = TypePillBadge.Pill
                },
                new ControlBadge()
                {
                    Value = "Primär",
                    Pill = TypePillBadge.Pill,
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Primary)
                },
                new ControlBadge()
                {
                    Value = "Sekundär",
                    Pill = TypePillBadge.Pill,
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Secondary)
                },
                new ControlBadge()
                {
                    Value = "Info",
                    Pill = TypePillBadge.Pill,
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Info)
                },
                new ControlBadge()
                {
                    Value = "Erfolg",
                    Pill = TypePillBadge.Pill,
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Success)
                },
                new ControlBadge()
                {
                    Value = "Warnung",
                    Pill = TypePillBadge.Pill,
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Warning)
                },
                new ControlBadge()
                {
                    Value = "Fehler",
                    Pill = TypePillBadge.Pill,
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Danger)
                },
                new ControlBadge()
                {
                    Value = "Dunkel",
                    Pill = TypePillBadge.Pill,
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Dark)
                },
                new ControlBadge()
                {
                    Value = "Hell",
                    Pill = TypePillBadge.Pill,
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Light)
                },
                new ControlBadge()
                {
                    Value = "Weiß",
                    Pill = TypePillBadge.Pill,
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.White)
                },
                new ControlBadge()
                {
                    Value = "Transparent",
                    Pill = TypePillBadge.Pill,
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Transparent)
                },
                new ControlBadge()
                {
                    Value = "Benutzerdefiniert",
                    Pill = TypePillBadge.Pill,
                    TextColor = new PropertyColorText("red"),
                    BackgroundColor = new PropertyColorBackgroundBadge("gold")
                }
            );

            AddProperty
            (
                "Uri",
                "Fügt eine Uri hinzu, so das das Abzeichen wie ein Link funktioniert.",
                "Uri = Page.Uri",
                new ControlBadge()
                {
                    Value = "Standard",
                    Uri = Uri
                },
                new ControlBadge()
                {
                    Value = "Primär",
                    Uri = Uri,
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Primary)
                },
                new ControlBadge()
                {
                    Value = "Sekundär",
                    Uri = Uri,
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Secondary)
                },
                new ControlBadge()
                {
                    Value = "Info",
                    Uri = Uri,
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Info)
                },
                new ControlBadge()
                {
                    Value = "Erfolg",
                    Uri = Uri,
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Success)
                },
                new ControlBadge()
                {
                    Value = "Warnung",
                    Uri = Uri,
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Warning)
                },
                new ControlBadge()
                {
                    Value = "Fehler",
                    Uri = Uri,
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Danger)
                },
                new ControlBadge()
                {
                    Value = "Dunkel",
                    Uri = Uri,
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Dark)
                },
                new ControlBadge()
                {
                    Value = "Hell",
                    Uri = Uri,
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Light)
                },
                new ControlBadge()
                {
                    Value = "Weiß",
                    Uri = Uri,
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.White)
                },
                new ControlBadge()
                {
                    Value = "Transparent",
                    Uri = Uri,
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Transparent)
                },
                new ControlBadge()
                {
                    Value = "Benutzerdefiniert",
                    Uri = Uri,
                    TextColor = new PropertyColorText("red"),
                    BackgroundColor = new PropertyColorBackgroundBadge("gold")
                }
            );

            AddProperty
            (
                "Size",
                "Legt die Größe fest",
                "Size = new PropertySizeText(TypeSizeText.Small)",
                new ControlBadge()
                {
                    Value = "Extra Small",
                    Size = new PropertySizeText(TypeSizeText.ExtraSmall),
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Dark),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlBadge()
                {
                    Value = "Small",
                    Size = new PropertySizeText(TypeSizeText.Small),
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Dark),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlBadge()
                {
                    Value = "Standard",
                    Size = new PropertySizeText(TypeSizeText.Default),
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Dark),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlBadge()
                {
                    Value = "Large",
                    Size = new PropertySizeText(TypeSizeText.Large),
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Dark),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlBadge()
                {
                    Value = "Extra Large",
                    Size = new PropertySizeText(TypeSizeText.ExtraLarge),
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Dark),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlBadge()
                {
                    Value = "Benutzerdefiniert",
                    Size = new PropertySizeText(3.1f),
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Dark),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                }
            );
        }
    }
}
