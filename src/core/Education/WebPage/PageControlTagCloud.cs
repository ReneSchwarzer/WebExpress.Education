using WebExpress.UI.WebControl;
using WebExpress.WebAttribute;
using WebExpress.WebResource;

namespace Education.WebPage
{
    [ID("TagCloud")]
    [Title("education:page.control.tagcloud.name")]
    [Segment("tagcloud", "education:page.control.tagcloud.name")]
    [Path("/Control")]
    [Module("edu")]
    [Context("control")]
    public sealed class PageControlTagCloud : PageControlBase
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlTagCloud()
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        /// <param name="context">Der Kontext</param>
        public override void Initialization(IResourceContext context)
        {
            base.Initialization(context);

            Description = "Das ControlTagCloud sellt eine Schlagwortwolke bereit.";
            Code = "new ControlTagCloud() { Uri = Page.Uri.Root }";

            AddExample
            (
                new ControlTagCloud()
                {
                    Uri = Uri
                },
                new ControlTagCloud()
                {
                    Uri = Uri
                }
            );

            // Eigenschaften

        }
    }
}
