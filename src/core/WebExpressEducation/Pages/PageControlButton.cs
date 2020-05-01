using WebExpress.UI.Controls;

namespace Education.Pages
{
    public class PageControlButton : PageControlBase
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlButton()
            : base("ControlButton")
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        public override void Init()
        {
            base.Init();

            Description = "Das ControlButton sellt eine Schaltfläche bereit.";
            Code = "new ControlButton(Page) {  }";

            AddExample
            (
                new ControlButton(this)
                {
                    Text = "Hallo Welt!"
                },
                new ControlButton(this)
                {
                    Text = "Hallo Welt!",
                    Color = new PropertyColorButton(TypeColorButton.Info)
                },
                new ControlButton(this)
                {
                    Text = "Hallo Welt!",
                    Color = new PropertyColorButton(TypeColorButton.Warning)
                }
            );

            // Eigenschaften
            AddProperty
            (
                "BackgroundColor",
                "Setzt die Hintergrundfarbe der Schaltfläche.",
                "Color = new PropertyColorButton(TypeColorButton.Primary)",
                new ControlButton(this)
                {
                    Text = "Standard"
                },
                new ControlButton(this)
                {
                    Text = "Primär",
                    Color = new PropertyColorButton(TypeColorButton.Primary)
                },
                new ControlButton(this)
                {
                    Text = "Info",
                    Color = new PropertyColorButton(TypeColorButton.Info)
                },
                new ControlButton(this)
                {
                    Text = "Erfolg",
                    Color = new PropertyColorButton(TypeColorButton.Success)
                },
                new ControlButton(this)
                {
                    Text = "Warnung",
                    Color = new PropertyColorButton(TypeColorButton.Warning)
                },
                new ControlButton(this)
                {
                    Text = "Fehler",
                    Color = new PropertyColorButton(TypeColorButton.Danger)
                },
                new ControlButton(this)
                {
                    Text = "Dunkel",
                    Color = new PropertyColorButton(TypeColorButton.Dark)
                },
                new ControlButton(this)
                {
                    Text = "Hell",
                    Color = new PropertyColorButton(TypeColorButton.Light)
                },
                new ControlButton(this)
                {
                    Text = "Benutzerdefiniert",
                    Color = new PropertyColorButton("gold")
                }
            );

            AddProperty
            (
                "Outline",
                "Entfernt die Hintergrundfarbe von der Schaltfläche.",
                "Outline = true",
                new ControlButton(this)
                {
                    Text = "Standard",
                    Outline = true
                },
                new ControlButton(this)
                {
                    Text = "Primär",
                    Color = new PropertyColorButton(TypeColorButton.Primary),
                    Outline = true
                },
                new ControlButton(this)
                {
                    Text = "Info",
                    Color = new PropertyColorButton(TypeColorButton.Info),
                    Outline = true
                },
                new ControlButton(this)
                {
                    Text = "Erfolg",
                    Color = new PropertyColorButton(TypeColorButton.Success),
                    Outline = true
                },
                new ControlButton(this)
                {
                    Text = "Warnung",
                    Color = new PropertyColorButton(TypeColorButton.Warning),
                    Outline = true
                },
                new ControlButton(this)
                {
                    Text = "Fehler",
                    Color = new PropertyColorButton(TypeColorButton.Danger),
                    Outline = true
                },
                new ControlButton(this)
                {
                    Text = "Dunkel",
                    Color = new PropertyColorButton(TypeColorButton.Dark),
                    Outline = true
                },
                new ControlButton(this)
                {
                    Text = "Hell",
                    Color = new PropertyColorButton(TypeColorButton.Light),
                    Outline = true
                },
                new ControlButton(this)
                {
                    Text = "Benutzerdefiniert",
                    Color = new PropertyColorButton("gold"),
                    Outline = true
                }
            );

            AddProperty
            (
                "Size",
                "Bestimmt die Größe der Schaltfläche.",
                "Size = TypeSizeButton.Small",
                new ControlButton(this)
                {
                    Text = "Small",
                    Size = TypeSizeButton.Small,
                    Color = new PropertyColorButton(TypeColorButton.Primary),
                },
                new ControlButton(this)
                {
                    Text = "Standard",
                    Size = TypeSizeButton.Default,
                    Color = new PropertyColorButton(TypeColorButton.Primary)
                },
                new ControlButton(this)
                {
                    Text = "Lagrge",
                    Size = TypeSizeButton.Large,
                    Color = new PropertyColorButton(TypeColorButton.Primary)
                }
            );

            AddProperty
            (
                "Icon",
                "Fügt ein Icon der Schaltfläche hinzu.",
                "Icon = new PropertyIcon(TypeIcon.Home)",
                new ControlButton(this)
                {
                    Text = "Home",
                    Icon = new PropertyIcon(TypeIcon.Home),
                    Color = new PropertyColorButton(TypeColorButton.Primary),
                },
                new ControlButton(this)
                {
                    Text = "Benutzerdefiniert",
                    Icon = new PropertyIcon(Uri.Root.Append("/Assets/img/Icon16.png")),
                    Color = new PropertyColorButton(TypeColorButton.Primary)
                }
            );

            AddProperty
            (
               "Block",
               "Spannt die Schaltfläche über die gesammte Bereite.",
               "Block = TypeBlockButton.Block",
               new ControlButton(this)
               {
                   Text = "Block",
                   Block = TypeBlockButton.Block,
                   Color = new PropertyColorButton(TypeColorButton.Primary)
               }
            );

            AddProperty
            (
                "Active",
                "Setzt die Aktivitätseigenschaft der Schaltfläche.",
                "Active = TypesActive.Active",
                new ControlButton(this)
                {
                    Text = "None",
                    Active = TypeActive.None,
                    Color = new PropertyColorButton(TypeColorButton.Primary),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlButton(this)
                {
                    Text = "Active",
                    Active = TypeActive.Active,
                    Color = new PropertyColorButton(TypeColorButton.Primary),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlButton(this)
                {
                    Text = "Disable",
                    Active = TypeActive.Disabled,
                    Color = new PropertyColorButton(TypeColorButton.Primary),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                }
            );

            AddProperty
            (
                "Modal",
                "Blendet ein Dialog ein.",
                "Modal = new ControlModal(...)",
                new ControlButton(this)
                {
                    Text = "Klick mich!",
                    Modal = new ControlModal(this, null, "Dialog", new ControlText(this) { Text = "Hallo Welt!" }),
                    TextColor = new PropertyColorText(TypeColorText.Default),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
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
