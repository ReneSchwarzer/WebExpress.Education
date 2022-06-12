using WebExpress.UI.WebControl;
using WebExpress.WebAttribute;
using WebExpress.WebResource;

namespace Education.WebPage
{
    [Id("Callout")]
    [Title("education:page.control.callout.name")]
    [Segment("callout", "education:page.control.callout.name")]
    [Path("/Control")]
    [Module("edu")]
    [Context("control")]
    public sealed class PageControlPanelCallout : PageControlBase
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlPanelCallout()
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        /// <param name="context">Der Kontext</param>
        public override void Initialization(IResourceContext context)
        {
            base.Initialization(context);

            Description = "Das ControlPanelCallout stellt eine wichtige Information dar.";
            Code = "new ControlPanelCallout() { Title = \"Fehler\", Color = new PropertyColorCallout(TypeColorCallout.Info) }";

            AddExample
            (
                new ControlPanelCallout(new ControlText() { Text = "Hallo Welt!" })
                {
                    Title = "Info",
                    Color = new PropertyColorCallout(TypeColorCallout.Info),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                }
            );

            // Eigenschaften
            AddProperty
            (
                "Title",
                "Legt ein Titel fest.",
                "Title = \"Erfolgreich\"",
                new ControlPanelCallout(new ControlText() { Text = "Mit einem Titel" })
                {
                    Title = "Erfolgreich",
                    Color = new PropertyColorCallout(TypeColorCallout.Success),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlPanelCallout(new ControlText() { Text = "Ohne einen Titel" })
                {
                    Color = new PropertyColorCallout(TypeColorCallout.Success),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                }
            );

            AddProperty
            (
                "Color",
                "Legt die Farbe fest.",
                "Color = new PropertyColorCallout(TypeColorCallout.Primary)",
                new ControlPanelCallout(new ControlText() { Text = "Hallo Welt!" })
                {
                    Title = "Standard",
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlPanelCallout(new ControlText() { Text = "Hallo Welt!" })
                {
                    Title = "Info",
                    Color = new PropertyColorCallout(TypeColorCallout.Info),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlPanelCallout(new ControlText() { Text = "Hallo Welt!" })
                {
                    Title = "Primär",
                    Color = new PropertyColorCallout(TypeColorCallout.Primary),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlPanelCallout(new ControlText() { Text = "Hallo Welt!" })
                {
                    Title = "Sekundär",
                    Color = new PropertyColorCallout(TypeColorCallout.Secondary),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlPanelCallout(new ControlText() { Text = "Hallo Welt!" })
                {
                    Title = "Erfolgreich",
                    Color = new PropertyColorCallout(TypeColorCallout.Success),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlPanelCallout(new ControlText() { Text = "Hallo Welt!" })
                {
                    Title = "Warnung",
                    Color = new PropertyColorCallout(TypeColorCallout.Warning),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlPanelCallout(new ControlText() { Text = "Hallo Welt!" })
                {
                    Title = "Fehler",
                    Color = new PropertyColorCallout(TypeColorCallout.Danger),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlPanelCallout(new ControlText() { Text = "Hallo Welt!" })
                {
                    Title = "Dunkel",
                    Color = new PropertyColorCallout(TypeColorCallout.Dark),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlPanelCallout(new ControlText() { Text = "Hallo Welt!" })
                {
                    Title = "Hell",
                    Color = new PropertyColorCallout(TypeColorCallout.Light),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlPanelCallout(new ControlText() { Text = "Hallo Welt!" })
                {
                    Title = "Benutzerdefiniert",
                    Color = new PropertyColorCallout("gold"),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                }
            );

            AddProperty
            (
                "TextColor",
                "Legt die Textfarbe fest",
                "TextColor = new PropertyColorText(TypeColorText.Success)",
                new ControlPanelCallout(new ControlText() { Text = "Mit einer Erfolgs-Textfarbe" })
                {
                    Title = "Erfolgreich",
                    Color = new PropertyColorCallout(TypeColorCallout.Success),
                    TextColor = new PropertyColorText(TypeColorText.Success),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                }
            );

            AddProperty
            (
                "BackgroundColor",
                "Legt die Hintergrundfarbe fest",
                "BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning)",
                new ControlPanelCallout(new ControlText() { Text = "Mit einem Warn-Hintergrund" })
                {
                    Title = "Erfolgreich",
                    Color = new PropertyColorCallout(TypeColorCallout.Success),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                }
            );
        }
    }
}
