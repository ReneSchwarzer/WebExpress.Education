using WebExpress.UI.WebControl;
using WebExpress.WebApp.WebPage;
using WebExpress.WebAttribute;
using WebExpress.WebResource;

namespace Education.WebPage
{
    [ID("Home")]
    [Title("education:page.home.name")]
    [Segment("", "education:page.home.name")]
    [Path("")]
    [Module("edu")]
    [Context("general")]
    public sealed class PageHome : PageBase
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageHome()
        {
            //HeaderScriptLinks.Add(context.ContextPath.Append("/assets/js/Chart.min.js"));
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
                Text = "Willkommen",
                Format = TypeFormatText.H1,
                Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.None, PropertySpacing.Space.None, PropertySpacing.Space.Five)
            });
        }
    }
}
