using WebExpress.UI.WebControl;
using WebExpress.WebAttribute;
using WebExpress.WebResource;

namespace Education.WebPage
{
    [ID("Header")]
    [Title("education:page.control.header.name")]
    [Segment("header", "education:page.control.header.name")]
    [Path("/Control")]
    [Module("edu")]
    [Context("control")]
    public sealed class PageControlPanelHeader : PageControlBase
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlPanelHeader()
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        /// <param name="context">Der Kontext</param>
        public override void Initialization(IResourceContext context)
        {
            base.Initialization(context);

            Description = "Das ControlPanelHeader-Steuerelement stellt einen Kopfbereich zur verfügung.";
            Code = "new ControlPanelHeader(new ControlText() { Text = \"Hallo Welt!\" }) { Headline = \"Überschrift\" }";

            AddExample(new ControlPanelHeader(new ControlLink() { Text = "Link1", Uri = Uri }, new ControlText() { Text = "Hallo Welt!", TextColor = new PropertyColorText(TypeColorText.Light) })
            {
                BackgroundColor = new PropertyColorBackground(TypeColorBackground.Dark),
                Padding = new PropertySpacingPadding(PropertySpacing.Space.Two)
            });

            AddProperty
            (
                "Fixed",
                "Fixierte die Anordnung.",
                "Fixed = TypeFixed.None",
                new ControlPanelHeader(new ControlText() { Text = "Ohne Fixierung" })
                {
                    Fixed = TypeFixed.None,
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.White),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two),
                    Padding = new PropertySpacingPadding(PropertySpacing.Space.Two)
                },
                new ControlPanelHeader(new ControlText() { Text = "Fixierung oben" })
                {
                    Fixed = TypeFixed.Top,
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.White),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two),
                    Padding = new PropertySpacingPadding(PropertySpacing.Space.Two)
                },
                new ControlPanelHeader(new ControlText() { Text = "Fixierung unten" })
                {
                    Fixed = TypeFixed.Bottom,
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.White),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two),
                    Padding = new PropertySpacingPadding(PropertySpacing.Space.Two)
                }
            );

            AddProperty
            (
                "Sticky",
                "Fixiert die Anordnung, wenn sich die Toolbar am oberen Rand befindet.",
                "Sticky = \"Header\"",
                new ControlPanelHeader(new ControlText() { Text = "Ohne Fixierunge" })
                {
                    Sticky = TypeSticky.None,
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.White),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two),
                    Padding = new PropertySpacingPadding(PropertySpacing.Space.Two)
                },
                new ControlPanelHeader(new ControlText() { Text = "Fixierung oben" })
                {
                    Sticky = TypeSticky.Top,
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.White),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two),
                    Padding = new PropertySpacingPadding(PropertySpacing.Space.Two)
                }
            );
        }
    }
}
