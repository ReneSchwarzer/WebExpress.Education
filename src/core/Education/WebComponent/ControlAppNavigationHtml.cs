using Education.WebPage;
using WebExpress.Html;
using WebExpress.UI.WebAttribute;
using WebExpress.UI.WebComponent;
using WebExpress.UI.WebControl;
using WebExpress.WebApp.WebComponent;
using WebExpress.WebAttribute;
using WebExpress.WebPage;

namespace Education.WebComponent
{
    [Section(Section.AppNavigationPrimary)]
    [Module("education")]
    public sealed class ControlAppNavigationHtml : ComponentControlNavigationItemLink
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
