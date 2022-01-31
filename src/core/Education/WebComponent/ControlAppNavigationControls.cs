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
    [Application("education")]
    public sealed class ControlAppNavigationControls : ComponentControlNavigationItemLink
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public ControlAppNavigationControls()
            : base()
        {
        }

        /// <summary>
        /// In HTML konvertieren
        /// </summary>
        /// <param name="context">Der Kontext, indem das Steuerelement dargestellt wird</param>
        /// <returns>Das Control als HTML</returns>
        public override IHtmlNode Render(RenderContext context)
        {
            Text = "Controls";
            Uri = context.Page.Uri.Root.Append("controls");
            Active = context.Page is IPageControl ? TypeActive.Active : TypeActive.None;
            Icon = new PropertyIcon(TypeIcon.Clone);

            return base.Render(context);
        }

    }
}
