using WebExpress.UI.WebControl;
using WebExpress.WebAttribute;
using WebExpress.WebResource;

namespace Education.WebPage
{
    [Id("SplitButtonLink")]
    [Title("education:page.control.splitbuttonlink.name")]
    [Segment("splitbuttonlink", "education:page.control.splitbuttonlink.name")]
    [Path("/Control")]
    [Module("edu")]
    [Context("control")]
    public sealed class PageControlSplitButtonLink : PageControlBase
    {
        private readonly IControlSplitButtonItem item1 = new ControlSplitButtonItemHeader() { Text = "Header" };
        private readonly IControlSplitButtonItem item2 = new ControlSplitButtonItemLink() { Text = "Erster Eintrag" };
        private readonly IControlSplitButtonItem item3 = new ControlSplitButtonItemLink() { Text = "Zweiter Eintrag" };
        private readonly IControlSplitButtonItem item4 = new ControlSplitButtonItemDivider();
        private readonly IControlSplitButtonItem item5 = new ControlSplitButtonItemLink() { Text = "Dritter Eintrag" };

        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlSplitButtonLink()
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        /// <param name="context">Der Kontext</param>
        public override void Initialization(IResourceContext context)
        {
            base.Initialization(context);

            Description = "Das ControlSplitButtonLink stellt einen Link mit dem Aussehen einer Schaltfläche und einem Menü für zusätzliche Optionen bereit.";
            Code = "new ControlSplitButtonLink() {  }";

            AddExample
            (
                new ControlSplitButtonLink(item1, item2, item3, item4, item5)
                {
                    Text = "Hallo Welt!",
                    Uri = Uri
                },
                new ControlSplitButtonLink(item1, item2, item3, item4, item5)
                {
                    Text = "Hallo Welt!",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Info),
                    Uri = Uri
                },
                new ControlSplitButtonLink(item1, item2, item3, item4, item5)
                {
                    Text = "Hallo Welt!",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Warning),
                    Uri = Uri
                }
            );

            // Eigenschaften
            AddProperty
            (
                "BackgroundColor",
                "Setzt die Hintergrundfarbe der Schaltfläche.",
                "Color = new PropertyColorButton(TypeColorButton.Primary)",
                new ControlSplitButtonLink(item1, item2, item3, item4, item5)
                {
                    Text = "Standard",
                    Uri = Uri
                },
                new ControlSplitButtonLink(item1, item2, item3, item4, item5)
                {
                    Text = "Primär",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Primary),
                    Uri = Uri
                },
                new ControlSplitButtonLink(item1, item2, item3, item4, item5)
                {
                    Text = "Info",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Info),
                    Uri = Uri
                },
                new ControlSplitButtonLink(item1, item2, item3, item4, item5)
                {
                    Text = "Erfolg",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Success),
                    Uri = Uri
                },
                new ControlSplitButtonLink(item1, item2, item3, item4, item5)
                {
                    Text = "Warnung",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Warning),
                    Uri = Uri
                },
                new ControlSplitButtonLink(item1, item2, item3, item4, item5)
                {
                    Text = "Fehler",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Danger),
                    Uri = Uri
                },
                new ControlSplitButtonLink(item1, item2, item3, item4, item5)
                {
                    Text = "Dunkel",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Dark),
                    Uri = Uri
                },
                new ControlSplitButtonLink(item1, item2, item3, item4, item5)
                {
                    Text = "Hell",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Light),
                    Uri = Uri
                },
                new ControlSplitButtonLink(item1, item2, item3, item4, item5)
                {
                    Text = "Benutzerdefiniert",
                    BackgroundColor = new PropertyColorButton("gold"),
                    Uri = Uri
                }
            );

            AddProperty
            (
                "Outline",
                "Entfernt die Hintergrundfarbe von der Schaltfläche.",
                "Outline = true",
                new ControlSplitButtonLink(item1, item2, item3, item4, item5)
                {
                    Text = "Standard",
                    Outline = true,
                    Uri = Uri
                },
                new ControlSplitButtonLink(item1, item2, item3, item4, item5)
                {
                    Text = "Primär",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Primary),
                    Outline = true,
                    Uri = Uri
                },
                new ControlSplitButtonLink(item1, item2, item3, item4, item5)
                {
                    Text = "Sekundär",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Secondary),
                    Outline = true
                },
                new ControlSplitButtonLink(item1, item2, item3, item4, item5)
                {
                    Text = "Info",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Info),
                    Outline = true,
                    Uri = Uri
                },
                new ControlSplitButtonLink(item1, item2, item3, item4, item5)
                {
                    Text = "Erfolg",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Success),
                    Outline = true,
                    Uri = Uri
                },
                new ControlSplitButtonLink(item1, item2, item3, item4, item5)
                {
                    Text = "Warnung",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Warning),
                    Outline = true,
                    Uri = Uri
                },
                new ControlSplitButtonLink(item1, item2, item3, item4, item5)
                {
                    Text = "Fehler",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Danger),
                    Outline = true,
                    Uri = Uri
                },
                new ControlSplitButtonLink(item1, item2, item3, item4, item5)
                {
                    Text = "Dunkel",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Dark),
                    Outline = true,
                    Uri = Uri
                },
                new ControlSplitButtonLink(item1, item2, item3, item4, item5)
                {
                    Text = "Hell",
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Light),
                    Outline = true,
                    Uri = Uri
                },
                new ControlSplitButtonLink(item1, item2, item3, item4, item5)
                {
                    Text = "Benutzerdefiniert",
                    BackgroundColor = new PropertyColorButton("gold"),
                    Outline = true,
                    Uri = Uri
                }
            );

            AddProperty
            (
                "Size",
                "Bestimmt die Größe der Schaltfläche.",
                "Size = TypeSizeButton.Small",
                new ControlSplitButtonLink(item1, item2, item3, item4, item5)
                {
                    Text = "Small",
                    Size = TypeSizeButton.Small,
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Primary),
                    Uri = Uri
                },
                new ControlSplitButtonLink(item1, item2, item3, item4, item5)
                {
                    Text = "Standard",
                    Size = TypeSizeButton.Default,
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Primary),
                    Uri = Uri
                },
                new ControlSplitButtonLink(item1, item2, item3, item4, item5)
                {
                    Text = "Lagrge",
                    Size = TypeSizeButton.Large,
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Primary),
                    Uri = Uri
                }
            );

            AddProperty
            (
                "Icon",
                "Fügt ein Icon der Schaltfläche hinzu.",
                "Icon = new PropertyIcon(TypeIcon.Home)",
                new ControlSplitButtonLink(item1, item2, item3, item4, item5)
                {
                    Text = "Home",
                    Icon = new PropertyIcon(TypeIcon.Home),
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Primary),
                    Uri = Uri
                },
                new ControlSplitButtonLink(item1, item2, item3, item4, item5)
                {
                    Text = "Benutzerdefiniert",
                    Icon = new PropertyIcon(Uri.Root.Append("/Assets/img/Icon16.png")),
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Primary),
                    Uri = Uri
                }
            );

            AddProperty
            (
               "Block",
               "Spannt die Schaltfläche über die gesammte Bereite.",
               "Block = TypeBlockButton.Block",
               new ControlSplitButtonLink(item1, item2, item3, item4, item5)
               {
                   Text = "Block",
                   Block = TypeBlockButton.Block,
                   BackgroundColor = new PropertyColorButton(TypeColorButton.Primary),
                   Uri = Uri
               }
            );

            AddProperty
            (
                "Active",
                "Setzt die Aktivitätseigenschaft der Schaltfläche.",
                "Active = TypesActive.Active",
                new ControlSplitButtonLink(item1, item2, item3, item4, item5)
                {
                    Text = "None",
                    Active = TypeActive.None,
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Primary),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two),
                    Uri = Uri
                },
                new ControlSplitButtonLink(item1, item2, item3, item4, item5)
                {
                    Text = "Active",
                    Active = TypeActive.Active,
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Primary),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two),
                    Uri = Uri
                },
                new ControlSplitButtonLink(item1, item2, item3, item4, item5)
                {
                    Text = "Disable",
                    Active = TypeActive.Disabled,
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Primary),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two),
                    Uri = Uri
                }
            );

            AddProperty
            (
                "Modal",
                "Blendet ein Dialog ein.",
                "Modal = new ControlModal(...)",
                new ControlSplitButtonLink(item1, item2, item3, item4, item5)
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
