using Education.Controls;
using Education.Model;
using System.Collections.Generic;
using WebExpress.Html;
using WebExpress.UI.Controls;
using WebExpress.UI.Pages;

namespace Education.Pages
{
    public class PageBase : PageTemplateWebApp
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="title">Der Titel der Seite</param>
        public PageBase(string title)
            : base()
        {
            Title = "Education";

            if (!string.IsNullOrWhiteSpace(title))
            {
                Title += " - " + title;
            }

            Favicons.Add(new Favicon("/Assets/img/Favicon.png", TypeFavicon.PNG));
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        public override void Init()
        {
            base.Init();
            Head.Styles = new List<string>(new[] { "position: sticky; top: 0; z-index: 99;" });
            Head.Content.Add(HamburgerMenu);
            HamburgerMenu.HorizontalAlignment = TypeHorizontalAlignment.Left;
            HamburgerMenu.Image = Uri?.Root.Append("Assets/img/Logo.png");
            HamburgerMenu.Add(new ControlLink(this) { Text = "Home", Icon = new PropertyIcon(TypeIcon.Home), Uri = Uri.Root });
            HamburgerMenu.Add(new ControlLink(this) { Text = "Tutorials", Icon = new PropertyIcon(TypeIcon.GraduationCap), Uri = Uri.Root.Append("tutorials") });
            HamburgerMenu.Add(new ControlLink(this) { Text = "Controls", Icon = new PropertyIcon(TypeIcon.Clone), Uri = Uri.Root.Append("controls") });
            HamburgerMenu.Add(new ControlLink(this) { Text = "Html", Icon = new PropertyIcon(TypeIcon.Code), Uri = Uri.Root.Append("html") });
            HamburgerMenu.AddSeperator();
            HamburgerMenu.Add(new ControlLink(this) { Text = "Hilfe", Icon = new PropertyIcon(TypeIcon.InfoCircle), Uri = Uri.Root.Append("help") });

            // SideBar
            ToolBar = new ControlToolBar(this)
            {
                BackgroundColor = new PropertyColorBackground(TypeColorBackground.Dark),
                HorizontalAlignment = TypeHorizontalAlignment.Left
            };
            ToolBar.Classes.Add("sidebar");

            Head.Content.Add(new ControlPanelCenter(this, new ControlText(this)
            {
                Text = Title,
                TextColor = new PropertyColorText(TypeColorText.White),
                Format = TypesTextFormat.H1,
                Size = TypeSizeButton.Default,
                Padding = new PropertySpacingPadding(PropertySpacing.Space.One),
                Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.None, PropertySpacing.Space.None, PropertySpacing.Space.Null),
                Styles = new List<string>(new[] { "font-size:190%; height: 50px;" })
            })); ;

            Main.Classes.Add("content");
            Main.Margin = new PropertySpacingMargin(PropertySpacing.Space.Two, PropertySpacing.Space.None);
            PathCtrl.Classes.Add("content");

            Main.Content.Add(new ControlTabMenu(this));
            Main.Content.Add(new ControlLine(this));

            Foot.Content.Add(new ControlText(this, "now")
            {
                Text = string.Format("{0}", ViewModel.Instance.Now),
                TextColor = new PropertyColorText(TypeColorText.Muted),
                Format = TypesTextFormat.Center,
                Size = TypeSizeButton.Small
            });
        }

        /// <summary>
        /// Verarbeitung
        /// </summary>
        public override void Process()
        {
            base.Process();
        }
    }
}
