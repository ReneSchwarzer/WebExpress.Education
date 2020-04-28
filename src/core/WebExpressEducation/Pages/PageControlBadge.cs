using WebExpress.UI.Controls;

namespace Education.Pages
{
    public class PageControlBadge : PageControlBase
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlBadge()
            : base("ControlBadge")
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        public override void Init()
        {
            base.Init();

            Description = "Das ControlBadge kann zum Anzeigen eines Abzeichens (z.B. Anzahl der neuen Nachrichten) eingesetzt werden.";
            Code = "new ControlBadge(Page) { Value = \"Neu\", BackgroundColor = new PropertyColorBackground(TypesBackgroundColor.Success) }";

            AddExample
            (
                new ControlBadge(this)
                {
                    Value = "Standard"
                },
                new ControlBadge(this)
                {
                    Value = "Primär",
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Primary)
                },
                new ControlBadge(this)
                {
                    Value = "Sekundär",
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Secondary)
                },
                new ControlBadge(this)
                {
                    Value = "Info",
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Info)
                },
                new ControlBadge(this)
                {
                    Value = "Erfolg",
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Success)
                },
                new ControlBadge(this)
                {
                    Value = "Warnung",
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Warning)
                },
                new ControlBadge(this)
                {
                    Value = "Fehler",
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Danger)
                },
                new ControlBadge(this)
                {
                    Value = "Dunkel",
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Dark)
                },
                new ControlBadge(this)
                {
                    Value = "Hell",
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Light)
                },
                new ControlBadge(this)
                {
                    Value = "Weiß",
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.White)
                },
                new ControlBadge(this)
                {
                    Value = "Transparent",
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Transparent)
                },
                new ControlBadge(this)
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
                new ControlBadge(this)
                {
                    Value = "Standard",
                    Pill = TypesBadgePill.Pill
                },
                new ControlBadge(this)
                {
                    Value = "Primär",
                    Pill = TypesBadgePill.Pill,
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Primary)
                },
                new ControlBadge(this)
                {
                    Value = "Sekundär",
                    Pill = TypesBadgePill.Pill,
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Secondary)
                },
                new ControlBadge(this)
                {
                    Value = "Info",
                    Pill = TypesBadgePill.Pill,
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Info)
                },
                new ControlBadge(this)
                {
                    Value = "Erfolg",
                    Pill = TypesBadgePill.Pill,
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Success)
                },
                new ControlBadge(this)
                {
                    Value = "Warnung",
                    Pill = TypesBadgePill.Pill,
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Warning)
                },
                new ControlBadge(this)
                {
                    Value = "Fehler",
                    Pill = TypesBadgePill.Pill,
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Danger)
                },
                new ControlBadge(this)
                {
                    Value = "Dunkel",
                    Pill = TypesBadgePill.Pill,
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Dark)
                },
                new ControlBadge(this)
                {
                    Value = "Hell",
                    Pill = TypesBadgePill.Pill,
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Light)
                },
                new ControlBadge(this)
                {
                    Value = "Weiß",
                    Pill = TypesBadgePill.Pill,
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.White)
                },
                new ControlBadge(this)
                {
                    Value = "Transparent",
                    Pill = TypesBadgePill.Pill,
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Transparent)
                },
                new ControlBadge(this)
                {
                    Value = "Benutzerdefiniert",
                    Pill = TypesBadgePill.Pill,
                    TextColor = new PropertyColorText("red"),
                    BackgroundColor = new PropertyColorBackgroundBadge("gold")
                }
            );

            AddProperty
            (
                "Link",
                new ControlBadge(this)
                {
                    Value = "Standard",
                    Uri = Uri
                },
                new ControlBadge(this)
                {
                    Value = "Primär",
                    Uri = Uri,
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Primary)
                },
                new ControlBadge(this)
                {
                    Value = "Sekundär",
                    Uri = Uri,
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Secondary)
                },
                new ControlBadge(this)
                {
                    Value = "Info",
                    Uri = Uri,
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Info)
                },
                new ControlBadge(this)
                {
                    Value = "Erfolg",
                    Uri = Uri,
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Success)
                },
                new ControlBadge(this)
                {
                    Value = "Warnung",
                    Uri = Uri,
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Warning)
                },
                new ControlBadge(this)
                {
                    Value = "Fehler",
                    Uri = Uri,
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Danger)
                },
                new ControlBadge(this)
                {
                    Value = "Dunkel",
                    Uri = Uri,
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Dark)
                },
                new ControlBadge(this)
                {
                    Value = "Hell",
                    Uri = Uri,
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Light)
                },
                new ControlBadge(this)
                {
                    Value = "Weiß",
                    Uri = Uri,
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.White)
                },
                new ControlBadge(this)
                {
                    Value = "Transparent",
                    Uri = Uri,
                    BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Transparent)
                },
                new ControlBadge(this)
                {
                    Value = "Benutzerdefiniert",
                    Uri = Uri,
                    TextColor = new PropertyColorText("red"),
                    BackgroundColor = new PropertyColorBackgroundBadge("gold")
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
