using Education.Pages;
using WebExpress.Html;
using WebExpress.UI.Controls;
using WebExpress.UI.Plugin;

namespace Education.Controls
{
    public class ControlAppNavigationControls : ControlLink, IPluginComponentAppNavigationPrimary
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
            TextColor = new PropertyColorText(TypeColorText.Light);
        }

        /// <summary>
        /// In HTML konvertieren
        /// </summary>
        /// <param name="context">Der Kontext, indem das Steuerelement dargestellt wird</param>
        /// <returns>Das Control als HTML</returns>
        public override IHtmlNode Render(RenderContext context)
        {
            Text = "Controls";
            Uri = context.Page.Uri.Root.Append("control");
            Active = context.Page is IPageControl ? TypeActive.Active : TypeActive.None;
            Icon = new PropertyIcon(TypeIcon.Clone);

            return base.Render(context);
        }

    }
}
