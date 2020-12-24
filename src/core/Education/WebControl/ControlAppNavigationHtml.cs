using Education.WebResource;
using WebExpress.Attribute;
using WebExpress.Html;
using WebExpress.UI.Attribute;
using WebExpress.UI.Component;
using WebExpress.UI.Components;
using WebExpress.UI.WebControl;
using WebExpress.WebApp.Components;

namespace Education.WebControl
{
    [Section(Section.AppNavigationPrimary)]
    [Application("education")]
    public sealed class ControlAppNavigationHtml : ControlNavigationItemLink, IComponent
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public ControlAppNavigationHtml()
            : base()
        {
            Init();
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        private void Init()
        {
        }

        /// <summary>
        /// In HTML konvertieren
        /// </summary>
        /// <param name="context">Der Kontext, indem das Steuerelement dargestellt wird</param>
        /// <returns>Das Control als HTML</returns>
        public override IHtmlNode Render(RenderContext context)
        {
            Text = "Html";
            Uri = context.Page.Uri.Root.Append("html");
            Active = context.Page is IPageHtml ? TypeActive.Active : TypeActive.None;
            Icon = new PropertyIcon(TypeIcon.Code);

            return base.Render(context);
        }

    }
}
