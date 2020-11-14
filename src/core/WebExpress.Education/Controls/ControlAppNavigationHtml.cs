using Education.Pages;
using WebExpress.Html;
using WebExpress.UI.Controls;
using WebExpress.UI.Plugin;

namespace Education.Controls
{
    public class ControlAppNavigationHtml : ControlLink, IPluginComponentAppNavigationPrimary
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
            TextColor = new PropertyColorText(TypeColorText.Light);
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
