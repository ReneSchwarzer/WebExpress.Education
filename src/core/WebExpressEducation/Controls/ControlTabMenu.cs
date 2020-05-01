using Education.Pages;
using WebExpress.Pages;
using WebExpress.UI.Controls;

namespace Education.Controls
{
    public class ControlTabMenu : ControlTab
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="page">Die zugehörige Seite</param>
        public ControlTabMenu(IPage page)
            : base(page)
        {
            Init();
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        private void Init()
        {
            var root = Page.Uri.Root;

            Layout = TypeLayoutTab.Pill;
            HorizontalAlignment = TypeHorizontalAlignmentTab.Center;

            Items.Add(new ControlLink(Page)
            {
                Text = "Home",
                Uri = root,
                Active = (Page is PageHome) ? TypeActive.Active : TypeActive.None,
                Icon = new PropertyIcon(TypeIcon.Home)
            });

            Items.Add(new ControlLink(Page)
            {
                Text = "Tutorials",
                Uri = root.Append("tutorial"),
                Active = Page is IPageTutorial ? TypeActive.Active : TypeActive.None,
                Icon = new PropertyIcon(TypeIcon.GraduationCap)
            });

            Items.Add(new ControlLink(Page)
            {
                Text = "Controls",
                Uri = root.Append("control"),
                Active = Page is IPageControl ? TypeActive.Active : TypeActive.None,
                Icon = new PropertyIcon(TypeIcon.Clone)
            });

            Items.Add(new ControlLink(Page)
            {
                Text = "Html",
                Uri = root.Append("html"),
                Active = Page is IPageHtml  ? TypeActive.Active : TypeActive.None,
                Icon = new PropertyIcon(TypeIcon.Code)
            });

            Items.Add(new ControlLink(Page)
            {
                Text = "Hilfe",
                Uri = Page.Uri.Root.Append("help"),
                Active = Page is PageHelp ? TypeActive.Active : TypeActive.None,
                Icon = new PropertyIcon(TypeIcon.InfoCircle)
            });
        }
    }
}
