using Education.WebResource;
using WebExpress.Html;
using WebExpress.UI.Components;
using WebExpress.UI.WebControl;
using WebExpress.Attribute;
using WebExpress.UI.Attribute;
using WebExpress.UI.Component;
using WebExpress.WebApp.Components;

namespace Education.WebControl
{
    [Section(Section.AppNavigationPrimary)]
    [Application("education")]
    public sealed class ControlAppNavigationControls : ControlNavigationItemLink, IComponent
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public ControlAppNavigationControls()
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
            Text = "Controls";
            Uri = context.Page.Uri.Root.Append("controls");
            Active = context.Page is IPageControl ? TypeActive.Active : TypeActive.None;
            Icon = new PropertyIcon(TypeIcon.Clone);

            return base.Render(context);
        }

    }
}
