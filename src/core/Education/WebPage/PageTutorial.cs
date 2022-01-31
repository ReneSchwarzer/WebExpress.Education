using WebExpress.UI.WebControl;
using WebExpress.WebApp.WebPage;
using WebExpress.WebAttribute;
using WebExpress.WebResource;

namespace Education.WebPage
{
    [ID("Tutorial")]
    [Title("education:page.tutorial.name")]
    [Segment("tutorial", "education:page.tutorial.name")]
    [Path("/")]
    [Module("edu")]
    [Context("tutorial")]
    public sealed class PageTutorial : PageBase, IPageTutorial
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageTutorial()
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
                Text = "Tutorials",
                Format = TypeFormatText.H1,
                Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.None, PropertySpacing.Space.None, PropertySpacing.Space.Five)
            });
        }
    }
}
