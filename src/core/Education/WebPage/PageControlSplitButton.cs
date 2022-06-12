using WebExpress.UI.WebControl;
using WebExpress.WebAttribute;
using WebExpress.WebResource;

namespace Education.WebPage
{
    [Id("SplitButton")]
    [Title("education:page.control.splitbutton.name")]
    [Segment("splitbutton", "education:page.control.splitbutton.name")]
    [Path("/Control")]
    [Module("edu")]
    [Context("control")]
    public sealed class PageControlSplitButton : PageControlBase
    {
        private readonly IControlSplitButtonItem item1 = new ControlSplitButtonItemHeader() { Text = "Header" };
        private readonly IControlSplitButtonItem item2 = new ControlSplitButtonItemLink() { Text = "Erster Eintrag" };
        private readonly IControlSplitButtonItem item3 = new ControlSplitButtonItemLink() { Text = "Zweiter Eintrag" };
        private readonly IControlSplitButtonItem item4 = new ControlSplitButtonItemDivider();
        private readonly IControlSplitButtonItem item5 = new ControlSplitButtonItemLink() { Text = "Dritter Eintrag" };

        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlSplitButton()
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        /// <param name="context">Der Kontext</param>
        public override void Initialization(IResourceContext context)
        {
            base.Initialization(context);

            Description = "Das ControlSplitButton sellt eine Schaltfläche mit einem Menü für zusätzliche Optionen bereit.";
            Code = "new ControlSplitButton() {  }";

            AddExample
            (
                new ControlSplitButton(item1, item2, item3, item4, item5)
                {
                    Text = "Hallo Welt!"
                },
                new ControlSplitButton(item1, item2, item3, item4, item5)
                {
                    Text = "Hallo Welt!",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Info)
                },
                new ControlSplitButton(item1, item2, item3, item4, item5)
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
                new ControlSplitButton(item1, item2, item3, item4, item5)
                {
                    Text = "Standard"
                },
                new ControlSplitButton(item1, item2, item3, item4, item5)
                {
                    Text = "Primär",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Primary)
                },
                new ControlSplitButton(item1, item2, item3, item4, item5)
                {
                    Text = "Info",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Info)
                },
                new ControlSplitButton(item1, item2, item3, item4, item5)
                {
                    Text = "Erfolg",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Success)
                },
                new ControlSplitButton(item1, item2, item3, item4, item5)
                {
                    Text = "Warnung",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Warning)
                },
                new ControlSplitButton(item1, item2, item3, item4, item5)
                {
                    Text = "Fehler",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Danger)
                },
                new ControlSplitButton(item1, item2, item3, item4, item5)
                {
                    Text = "Dunkel",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Dark)
                },
                new ControlSplitButton(item1, item2, item3, item4, item5)
                {
                    Text = "Hell",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Light)
                },
                new ControlSplitButton(item1, item2, item3, item4, item5)
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
                new ControlSplitButton(item1, item2, item3, item4, item5)
                {
                    Text = "Standard",
                    Outline = true
                },
                new ControlSplitButton(item1, item2, item3, item4, item5)
                {
                    Text = "Primär",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Primary),
                    Outline = true
                },
                new ControlSplitButton(item1, item2, item3, item4, item5)
                {
                    Text = "Sekundär",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Secondary),
                    Outline = true
                },
                new ControlSplitButton(item1, item2, item3, item4, item5)
                {
                    Text = "Info",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Info),
                    Outline = true
                },
                new ControlSplitButton(item1, item2, item3, item4, item5)
                {
                    Text = "Erfolg",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Success),
                    Outline = true
                },
                new ControlSplitButton(item1, item2, item3, item4, item5)
                {
                    Text = "Warnung",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Warning),
                    Outline = true
                },
                new ControlSplitButton(item1, item2, item3, item4, item5)
                {
                    Text = "Fehler",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Danger),
                    Outline = true
                },
                new ControlSplitButton(item1, item2, item3, item4, item5)
                {
                    Text = "Dunkel",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Dark),
                    Outline = true
                },
                new ControlSplitButton(item1, item2, item3, item4, item5)
                {
                    Text = "Hell",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Light),
                    Outline = true
                },
                new ControlSplitButton(item1, item2, item3, item4, item5)
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
                new ControlSplitButton(item1, item2, item3, item4, item5)
                {
                    Text = "Small",
                    Size = TypeSizeButton.Small,
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Primary),
                },
                new ControlSplitButton(item1, item2, item3, item4, item5)
                {
                    Text = "Standard",
                    Size = TypeSizeButton.Default,
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Primary)
                },
                new ControlSplitButton(item1, item2, item3, item4, item5)
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
                new ControlSplitButton(item1, item2, item3, item4, item5)
                {
                    Text = "Home",
                    Icon = new PropertyIcon(TypeIcon.Home),
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Primary),
                },
                new ControlSplitButton(item1, item2, item3, item4, item5)
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
               new ControlSplitButton(item1, item2, item3, item4, item5)
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
                new ControlSplitButton(item1, item2, item3, item4, item5)
                {
                    Text = "None",
                    Active = TypeActive.None,
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Primary),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlSplitButton(item1, item2, item3, item4, item5)
                {
                    Text = "Active",
                    Active = TypeActive.Active,
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Primary),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlSplitButton(item1, item2, item3, item4, item5)
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
                new ControlSplitButton(item1, item2, item3, item4, item5)
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
