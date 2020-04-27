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

            Description = "Das ControlPanelCallout stellt eine wihtige Information dar.";
            Code = "new ControlPanelCallout(Page) { Title = \"Fehler\", Layout = TypesLayoutCallout.Warning }";

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
                    Layout = TypesLayoutCallout.Info,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlPanelCallout(this, new ControlText(this) { Text = "Hallo Welt!" })
                {
                    Title = "Primär",
                    Layout = TypesLayoutCallout.Primary,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlPanelCallout(this, new ControlText(this) { Text = "Hallo Welt!" })
                {
                    Title = "Sekundär",
                    Layout = TypesLayoutCallout.Secondary,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlPanelCallout(this, new ControlText(this) { Text = "Hallo Welt!"})
                {
                    Title = "Erfolgreich",
                    Layout = TypesLayoutCallout.Success,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlPanelCallout(this, new ControlText(this) { Text = "Hallo Welt!" })
                {
                    Title = "Warnung",
                    Layout = TypesLayoutCallout.Warning,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlPanelCallout(this, new ControlText(this) { Text = "Hallo Welt!" })
                {
                    Title = "Fehler",
                    Layout = TypesLayoutCallout.Danger,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlPanelCallout(this, new ControlText(this) { Text = "Hallo Welt!" })
                {
                    Title = "Dunkel",
                    Layout = TypesLayoutCallout.Dark,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlPanelCallout(this, new ControlText(this) { Text = "Hallo Welt!" })
                {
                    Title = "Hell",
                    Layout = TypesLayoutCallout.Light,
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
                    Layout = TypesLayoutCallout.Success,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlPanelCallout(this, new ControlText(this) { Text = "Ohne einen Titel" })
                {
                    Layout = TypesLayoutCallout.Success,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                }
            );

            AddProperty
            (
                "Color",
                new ControlPanelCallout(this, new ControlText(this) { Text = "Mit einer Erfolgs-Textfarbe" })
                {
                    Title = "Erfolgreich",
                    Layout = TypesLayoutCallout.Success,
                    Color = new PropertyColorText(TypesTextColor.Success),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                }
            );

            AddProperty
            (
                "BackgroundColor",
                new ControlPanelCallout(this, new ControlText(this) { Text = "Mit einem Warn-Hintergrund" })
                {
                    Title = "Erfolgreich",
                    Layout = TypesLayoutCallout.Success,
                    BackgroundColor = new PropertyColorBackground(TypesBackgroundColor.Warning),
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
