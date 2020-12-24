using WebExpress.Attribute;
using WebExpress.Module;
using WebExpress.UI.WebControl;
using WebExpress.Uri;

namespace Education.WebResource
{
    [ID("Card")]
    [Title("page.control.card.name")]
    [Segment("card", "page.control.card.name")]
    [Path("/Control")]
    [Module("edu")]
    [Context("control")]
    public sealed class PageControlPanelCard : PageControlBase
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlPanelCard()
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        public override void Initialization()
        {
            base.Initialization();

            Description = "Das ControlPanelCard-Steuerelement kann zur Anzeige eines umgebenden Panels eingesetzt werden.";
            Code = "new ControlPanelCard(new ControlText() { Text = \"Hallo Welt!\" }) { Headline = \"Überschrift\" }";

            AddExample(new ControlPanelCard(new ControlText() { Text = "Hallo Welt!" })
            {
                Header = "Header",
                Headline = "Überschrift",
                Footer = "Footer"
            });

            AddProperty
            (
                "BackgroundColor",
                "Setzt die Hintergrundfarbe der Karte.",
                "BackgroundColor = new PropertyColorBackgroundAlert(TypeColorBackground.Primary)",
                new ControlPanelCard(new ControlText() { Text = "Ohne Angabe einer Hintergrundfarbe" })
                {

                },
                new ControlPanelCard(new ControlText() { Text = "Die Primär-Hintergrundfarbe" })
                {
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Primary),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Null, PropertySpacing.Space.Two)
                },
                new ControlPanelCard(new ControlText() { Text = "Die Sekundär-Hintergrundfarbe" })
                {
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Secondary),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Null, PropertySpacing.Space.Two)
                },
                new ControlPanelCard(new ControlText() { Text = "Die Info-Hintergrundfarbe" })
                {
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Info),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Null, PropertySpacing.Space.Two)
                },
                new ControlPanelCard(new ControlText() { Text = "Die Erfolgs-Hintergrundfarbe" })
                {
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Success),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Null, PropertySpacing.Space.Two)
                },
                new ControlPanelCard(new ControlText() { Text = "Die Warnungs-Hintergrundfarbe" })
                {
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Null, PropertySpacing.Space.Two)
                },
                new ControlPanelCard(new ControlText() { Text = "Die Fehler-Hintergrundfarbe" })
                {
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Danger),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Null, PropertySpacing.Space.Two)
                },
                new ControlPanelCard(new ControlText() { Text = "Die dunkel Hintergrundfarbe" })
                {
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Dark),
                    TextColor = new PropertyColorText(TypeColorText.White),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Null, PropertySpacing.Space.Two)
                },
                new ControlPanelCard(new ControlText() { Text = "Die helle Hintergrundfarbe" })
                {
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Null, PropertySpacing.Space.Two)
                },
                new ControlPanelCard(new ControlText() { Text = "Die weiße Hintergrundfarbe" })
                {
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.White),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Null, PropertySpacing.Space.Two)
                },
                new ControlPanelCard(new ControlText() { Text = "Die Tranzparenz-Hintergrundfarbe" })
                {
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Transparent),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Null, PropertySpacing.Space.Two)
                },
                new ControlPanelCard(new ControlText() { Text = "Die benutzerdefinierte Hintergrundfarbe" })
                {
                    BackgroundColor = new PropertyColorBackground("gold"),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Null, PropertySpacing.Space.Two)
                }
            );

            AddProperty
            (
                "Header",
                "Bestimmt den Text des Headers",
                "Header = \"Header\"",
                new ControlPanelCard(new ControlText() { Text = "Mit Angabe eines Headertextes" })
                {
                    Header = "Header",
                    TextColor = new PropertyColorText(TypeColorText.White),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Success)
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
