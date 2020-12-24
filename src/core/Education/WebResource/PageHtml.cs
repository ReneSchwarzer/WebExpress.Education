using WebExpress.Attribute;
using WebExpress.Module;
using WebExpress.UI.WebControl;
using WebExpress.Uri;

namespace Education.WebResource
{
    [ID("HTML")]
    [Title("page.html.name")]
    [Segment("html", "page.html.name")]
    [Path("/")]
    [Module("edu")]
    [Context("html")]
    public sealed class PageHtml : PageBase, IPageHtml
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageHtml()
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        public override void Initialization()
        {
            base.Initialization();
        }

        /// <summary>
        /// Verarbeitung
        /// </summary>
        public override void Process()
        {
            base.Process();

            Content.Content.Add(new ControlText()
            {
                Text = "Html",
                Format = TypeFormatText.H1,
                Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.None, PropertySpacing.Space.None, PropertySpacing.Space.Five)
            });
        }
    }
}
