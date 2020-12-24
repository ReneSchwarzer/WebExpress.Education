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
    public sealed class ControlAppNavigationTutorials : ControlNavigationItemLink, IComponent
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
