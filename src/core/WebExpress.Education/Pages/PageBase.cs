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
            Title = title;
            Favicons.Add(new Favicon("/Assets/img/Favicon.png", TypeFavicon.PNG));
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        public override void Init()
        {
            base.Init();
            
            //Hamburger.Add(new ControlLink() { Text = "Home", Icon = new PropertyIcon(TypeIcon.Home), Uri = Uri.Root });
            //Hamburger.Add(new ControlLink() { Text = "Tutorials", Icon = new PropertyIcon(TypeIcon.GraduationCap), Uri = Uri.Root.Append("tutorials") });
            //Hamburger.Add(new ControlLink() { Text = "Controls", Icon = new PropertyIcon(TypeIcon.Clone), Uri = Uri.Root.Append("control") });
            //Hamburger.Add(new ControlLink() { Text = "Html", Icon = new PropertyIcon(TypeIcon.Code), Uri = Uri.Root.Append("html") });
            //Hamburger.AddSeperator();
            //Hamburger.Add(new ControlLink() { Text = "Hilfe", Icon = new PropertyIcon(TypeIcon.InfoCircle), Uri = Uri.Root.Append("help") });

            //AppNavigation = new ControlTabMenu(this);

            if (this is PageHome)
            {
                Sidebar.Header.Content.Add(new ControlLink()
                {
                    Text = "Home",
                    Uri = Uri.Root,
                    Active = TypeActive.Active,
                    Icon = new PropertyIcon(TypeIcon.Home),
                    Size = new PropertySizeText(TypeSizeText.Large),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two, PropertySpacing.Space.None),
                    TextColor = new PropertyColorText(TypeColorText.Dark)
                });
            }
            else if (this is PageTutorial)
            {
                Sidebar.Header.Content.Add(new ControlLink()
                {
                    Text = "Tutorials",
                    Uri = Uri.Root.Append("tutorials"),
                    Active = TypeActive.Active,
                    Icon = new PropertyIcon(TypeIcon.GraduationCap),
                    Size = new PropertySizeText(TypeSizeText.Large),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two, PropertySpacing.Space.None),
                    TextColor = new PropertyColorText(TypeColorText.Dark)
                });
            }
            else if (this is PageControl)
            {
                Sidebar.Header.Content.Add(new ControlLink()
                {
                    Text = "Controls",
                    Uri = Uri.Root.Append("control"),
                    Active = TypeActive.Active,
                    Icon = new PropertyIcon(TypeIcon.Clone),
                    Size = new PropertySizeText(TypeSizeText.Large),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two, PropertySpacing.Space.None),
                    TextColor = new PropertyColorText(TypeColorText.Dark)
                });
            }
            else if (this is PageHtml)
            {
                Sidebar.Header.Content.Add(new ControlLink()
                {
                    Text = "Html",
                    Uri = Uri.Root.Append("html"),
                    Active = TypeActive.Active,
                    Icon = new PropertyIcon(TypeIcon.Code),
                    Size = new PropertySizeText(TypeSizeText.Large),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two, PropertySpacing.Space.None),
                    TextColor = new PropertyColorText(TypeColorText.Dark)
                });
            }
            else if (this is PageHelp)
            {
                Sidebar.Header.Content.Add(new ControlLink()
                {
                    Text = "Hilfe",
                    Uri = Uri.Root.Append("help"),
                    Active = TypeActive.Active,
                    Icon = new PropertyIcon(TypeIcon.InfoCircle),
                    Size = new PropertySizeText(TypeSizeText.Large),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two, PropertySpacing.Space.None),
                    TextColor = new PropertyColorText(TypeColorText.Dark)
                });
            }

            Footer.Content.Add(new ControlText("now")
            {
                Text = string.Format("{0}", ViewModel.Instance.Now),
                TextColor = new PropertyColorText(TypeColorText.Muted),
                Format = TypeFormatText.Center,
                Size = new PropertySizeText(TypeSizeText.Small)
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
