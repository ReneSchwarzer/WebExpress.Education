using WebExpress.UI.WebControl;
using WebExpress.WebApp.WebPage;
using WebExpress.WebAttribute;
using WebExpress.WebResource;

namespace Education.WebPage
{
    [Id("HTML")]
    [Title("education:page.html.name")]
    [Segment("html", "education:page.html.name")]
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
        /// <param name="context">Der Kontext</param>
        public override void Initialization(IResourceContext context)
        {
            base.Initialization(context);
        }

        /// <summary>
        /// Verarbeitung
        /// </summary>
        /// <param name="context">Der Kontext zum Rendern der Seite</param>
        public override void Process(RenderContextWebApp context)
        {
            base.Process(context);

            context.VisualTree.Content.Primary.Add(new ControlText()
            {
                Text = "Html",
                Format = TypeFormatText.H1,
                Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.None, PropertySpacing.Space.None, PropertySpacing.Space.Five)
            });
        }
    }
}
