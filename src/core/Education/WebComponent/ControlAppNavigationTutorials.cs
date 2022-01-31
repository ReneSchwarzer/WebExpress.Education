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
    public sealed class ControlAppNavigationTutorials : ComponentControlNavigationItemLink
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public ControlAppNavigationTutorials()
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
            Text = "Tutorials";
            Uri = context.Page.Uri.Root.Append("tutorial");
            Active = context.Page is IPageTutorial ? TypeActive.Active : TypeActive.None;
            Icon = new PropertyIcon(TypeIcon.GraduationCap);

            return base.Render(context);
        }

    }
}
