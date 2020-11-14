using Education.Pages;
using WebExpress.Html;
using WebExpress.UI.Controls;
using WebExpress.UI.Plugin;

namespace Education.Controls
{
    public class ControlAppNavigationTutorials : ControlLink, IPluginComponentAppNavigationPrimary
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
            TextColor = new PropertyColorText(TypeColorText.Light);
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
