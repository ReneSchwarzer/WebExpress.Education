using System.Linq;
using WebExpress.Html;
using WebExpress.Internationalization;
using WebExpress.UI.WebAttribute;
using WebExpress.UI.WebComponent;
using WebExpress.UI.WebControl;
using WebExpress.Uri;
using WebExpress.WebApp.WebComponent;
using WebExpress.WebAttribute;
using WebExpress.WebPage;
using WebExpress.WebResource;

namespace Education.WebComponent
{
    [Section(Section.SidebarPrimary)]
    [Module("education")]
    [Context("control")]
    public sealed class ControlSidebarControls : ControlNavigation, IComponent
    {
        /// <summary>
        /// Liefert der Kontext
        /// </summary>
        public IComponentContext Context { get; private set; }

        /// <summary>
        /// Konstruktor
        /// </summary>
        public ControlSidebarControls()
            : base()
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        /// <param name="context">Der Kontext</param>
        /// <param name="page">Die Seite, indem die Komonente aktiv ist</param>
        public void Initialization(IComponentContext context, IPage page)
        {
            Context = context;

            Layout = TypeLayoutTab.Pill;
            Orientation = TypeOrientationTab.Vertical;
            GridColumn = new PropertyGrid(TypeDevice.Medium, 2);
        }

        /// <summary>
        /// In HTML konvertieren
        /// </summary>
        /// <param name="context">Der Kontext, indem das Steuerelement dargestellt wird</param>
        /// <returns>Das Control als HTML</returns>
        public override IHtmlNode Render(RenderContext context)
        {
            var sitemap = ResourceManager.GetSitemap(Context.Application, Context.Module);

            foreach (var control in sitemap.Where(x => x.ResourceContext.Contains("control")))
            {
                var uri = new UriResource(context.Page.Context.ContextPath, control.ExpressionPath);

                Items.Add(new ControlNavigationItemLink()
                {
                    Text = context.I18N(control.Title),
                    Uri = uri,
                    Active = control.Title == context.Page.Uri.Display ? TypeActive.Active : TypeActive.None
                });
            }

            return base.Render(context);
        }
    }
}
