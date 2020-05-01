using WebExpress.UI.Controls;

namespace Education.Pages
{
    public class PageControlPanelCallout : PageControlBase
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlPanelCallout()
            : base("ControlPanelCallout")
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        public override void Init()
        {
            base.Init();

            Description = "Das ControlPanelCallout stellt eine wichtige Information dar.";
            Code = "new ControlPanelCallout(Page) { Title = \"Fehler\", Color = new PropertyColorCallout(TypeColorCallout.Info) }";

            AddExample
            (
                new ControlPanelCallout(this, new ControlText(this) { Text = "Hallo Welt!" })
                {
                    Title = "Standard",
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlPanelCallout(this, new ControlText(this) { Text = "Hallo Welt!" })
                {
                    Title = "Info",
                    Color = new PropertyColorCallout(TypeColorCallout.Info),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlPanelCallout(this, new ControlText(this) { Text = "Hallo Welt!" })
                {
                    Title = "Primär",
                    Color = new PropertyColorCallout(TypeColorCallout.Primary),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlPanelCallout(this, new ControlText(this) { Text = "Hallo Welt!" })
                {
                    Title = "Sekundär",
                    Color = new PropertyColorCallout(TypeColorCallout.Secondary),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlPanelCallout(this, new ControlText(this) { Text = "Hallo Welt!"})
                {
                    Title = "Erfolgreich",
                    Color = new PropertyColorCallout(TypeColorCallout.Success),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlPanelCallout(this, new ControlText(this) { Text = "Hallo Welt!" })
                {
                    Title = "Warnung",
                    Color = new PropertyColorCallout(TypeColorCallout.Warning),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlPanelCallout(this, new ControlText(this) { Text = "Hallo Welt!" })
                {
                    Title = "Fehler",
                    Color = new PropertyColorCallout(TypeColorCallout.Danger),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlPanelCallout(this, new ControlText(this) { Text = "Hallo Welt!" })
                {
                    Title = "Dunkel",
                    Color = new PropertyColorCallout(TypeColorCallout.Dark),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlPanelCallout(this, new ControlText(this) { Text = "Hallo Welt!" })
                {
                    Title = "Hell",
                    Color = new PropertyColorCallout(TypeColorCallout.Light),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlPanelCallout(this, new ControlText(this) { Text = "Hallo Welt!" })
                {
                    Title = "Benutzerdefiniert",
                    Color = new PropertyColorCallout("gold"),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                }

            );

            // Eigenschaften
            AddProperty
            (
                "Title",
                new ControlPanelCallout(this, new ControlText(this) { Text = "Mit einem Titel" })
                {
                    Title = "Erfolgreich",
                    Color = new PropertyColorCallout(TypeColorCallout.Success),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlPanelCallout(this, new ControlText(this) { Text = "Ohne einen Titel" })
                {
                    Color = new PropertyColorCallout(TypeColorCallout.Success),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                }
            );

            AddProperty
            (
                "TextColor",
                new ControlPanelCallout(this, new ControlText(this) { Text = "Mit einer Erfolgs-Textfarbe" })
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
                new ControlPanelCallout(this, new ControlText(this) { Text = "Mit einem Warn-Hintergrund" })
                {
                    Title = "Erfolgreich",
                    Color = new PropertyColorCallout(TypeColorCallout.Success),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
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
