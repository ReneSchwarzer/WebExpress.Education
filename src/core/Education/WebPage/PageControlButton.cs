using WebExpress.UI.WebControl;
using WebExpress.WebAttribute;
using WebExpress.WebResource;

namespace Education.WebPage
{
    [Id("Button")]
    [Title("education:page.control.button.name")]
    [Segment("button", "education:page.control.button.name")]
    [Path("/Control")]
    [Module("edu")]
    [Context("control")]
    public sealed class PageControlButton : PageControlBase
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlButton()
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        /// <param name="context">Der Kontext</param>
        public override void Initialization(IResourceContext context)
        {
            base.Initialization(context);

            Description = "Das ControlButton sellt eine Schaltfläche bereit.";
            Code = "new ControlButton() {  }";

            AddExample
            (
                new ControlButton()
                {
                    Text = "Hallo Welt!"
                },
                new ControlButton()
                {
                    Text = "Hallo Welt!",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Info)
                },
                new ControlButton()
                {
                    Text = "Hallo Welt!",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Warning)
                }
            );

            // Eigenschaften
            AddProperty
            (
                "BackgroundColor",
                "Setzt die Hintergrundfarbe der Schaltfläche.",
                "Color = new PropertyColorButton(TypeColorButton.Primary)",
                new ControlButton()
                {
                    Text = "Standard"
                },
                new ControlButton()
                {
                    Text = "Primär",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Primary)
                },
                new ControlButton()
                {
                    Text = "Info",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Info)
                },
                new ControlButton()
                {
                    Text = "Erfolg",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Success)
                },
                new ControlButton()
                {
                    Text = "Warnung",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Warning)
                },
                new ControlButton()
                {
                    Text = "Fehler",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Danger)
                },
                new ControlButton()
                {
                    Text = "Dunkel",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Dark)
                },
                new ControlButton()
                {
                    Text = "Hell",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Light)
                },
                new ControlButton()
                {
                    Text = "Benutzerdefiniert",
                    BackgroundColor = new PropertyColorButton("gold")
                }
            );

            AddProperty
            (
                "Outline",
                "Entfernt die Hintergrundfarbe von der Schaltfläche.",
                "Outline = true",
                new ControlButton()
                {
                    Text = "Standard",
                    Outline = true
                },
                new ControlButton()
                {
                    Text = "Primär",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Primary),
                    Outline = true
                },
                new ControlButton()
                {
                    Text = "Sekundär",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Secondary),
                    Outline = true
                },
                new ControlButton()
                {
                    Text = "Info",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Info),
                    Outline = true
                },
                new ControlButton()
                {
                    Text = "Erfolg",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Success),
                    Outline = true
                },
                new ControlButton()
                {
                    Text = "Warnung",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Warning),
                    Outline = true
                },
                new ControlButton()
                {
                    Text = "Fehler",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Danger),
                    Outline = true
                },
                new ControlButton()
                {
                    Text = "Dunkel",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Dark),
                    Outline = true
                },
                new ControlButton()
                {
                    Text = "Hell",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Light),
                    Outline = true
                },
                new ControlButton()
                {
                    Text = "Benutzerdefiniert",
                    BackgroundColor = new PropertyColorButton("gold"),
                    Outline = true
                }
            );

            AddProperty
            (
                "Size",
                "Bestimmt die Größe der Schaltfläche.",
                "Size = TypeSizeButton.Small",
                new ControlButton()
                {
                    Text = "Small",
                    Size = TypeSizeButton.Small,
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Primary),
                },
                new ControlButton()
                {
                    Text = "Standard",
                    Size = TypeSizeButton.Default,
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Primary)
                },
                new ControlButton()
                {
                    Text = "Lagrge",
                    Size = TypeSizeButton.Large,
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Primary)
                }
            );

            AddProperty
            (
                "Icon",
                "Fügt ein Icon der Schaltfläche hinzu.",
                "Icon = new PropertyIcon(TypeIcon.Home)",
                new ControlButton()
                {
                    Text = "Home",
                    Icon = new PropertyIcon(TypeIcon.Home),
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Primary),
                },
                new ControlButton()
                {
                    Text = "Benutzerdefiniert",
                    Icon = new PropertyIcon(Uri.Root.Append("/Assets/img/Icon16.png")),
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Primary)
                }
            );

            AddProperty
            (
               "Block",
               "Spannt die Schaltfläche über die gesammte Bereite.",
               "Block = TypeBlockButton.Block",
               new ControlButton()
               {
                   Text = "Block",
                   Block = TypeBlockButton.Block,
                   BackgroundColor = new PropertyColorButton(TypeColorButton.Primary)
               }
            );

            AddProperty
            (
                "Active",
                "Setzt die Aktivitätseigenschaft der Schaltfläche.",
                "Active = TypesActive.Active",
                new ControlButton()
                {
                    Text = "None",
                    Active = TypeActive.None,
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Primary),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlButton()
                {
                    Text = "Active",
                    Active = TypeActive.Active,
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Primary),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlButton()
                {
                    Text = "Disable",
                    Active = TypeActive.Disabled,
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Primary),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                }
            );

            AddProperty
            (
                "Modal",
                "Blendet ein Dialog ein.",
                "Modal = new ControlModal(...)",
                new ControlButton()
                {
                    Text = "Klick mich!",
                    Modal = new PropertyModal(TypeModal.Modal, new ControlModal(null, "Dialog", new ControlText() { Text = "Hallo Welt!" })),
                    TextColor = new PropertyColorText(TypeColorText.Default),
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Primary),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                }
            );
        }
    }
}
