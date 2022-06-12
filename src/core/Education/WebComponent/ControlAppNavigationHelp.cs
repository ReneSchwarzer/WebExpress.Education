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
    [Section(Section.AppNavigationSecondary)]
    [Module("education")]
    public sealed class ControlAppNavigationHelp : ComponentControlNavigationItemLink
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public ControlAppNavigationHelp()
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
            Text = "Hilfe";
            Uri = context.Page.Uri.Root.Append("help");
            Active = context.Page is PageHelp ? TypeActive.Active : TypeActive.None;
            Icon = new PropertyIcon(TypeIcon.InfoCircle);

            return base.Render(context);
        }
    }
}
