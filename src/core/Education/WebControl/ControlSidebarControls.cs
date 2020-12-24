using System.Linq;
using WebExpress.Attribute;
using WebExpress.Html;
using WebExpress.Internationalization;
using WebExpress.UI.Attribute;
using WebExpress.UI.Component;
using WebExpress.UI.WebControl;
using WebExpress.Uri;
using WebExpress.WebApp.Components;
using WebExpress.WebResource;

namespace Education.WebControl
{
    [Section(Section.SidebarPrimary)]
    [Application("education")]
    [Context("control")]
    public sealed class ControlSidebarControls : ControlNavigation, IComponent
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public ControlSidebarControls()
            : base()
        {
            Init();
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        private void Init()
        {
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
            var sitemap = ResourceManager.GetSitemap(context.Page.Context.ModuleID);

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
