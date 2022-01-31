using WebExpress.WebResource;

namespace Education.WebPage
{
    public abstract class PageControlBase : PageBaseItem, IPageControl
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlBase()
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
    }
}
