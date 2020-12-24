using Education.Model;
using WebExpress.Module;
using WebExpress.UI.WebControl;
using WebExpress.Uri;
using WebExpress.WebApp.WebResource;

namespace Education.WebResource
{
    public abstract class PageBase : PageTemplateWebApp
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageBase()
        {
            //Favicons.Add(new Favicon(UriManager.CreateUri(context.ApplicationID, "/assets/img/Favicon.png"), TypeFavicon.PNG));
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        public override void Initialization()
        {
            base.Initialization();

            //if (this is PageHome)
            //{
            //    Sidebar.Header.Content.Add(new ControlLink()
            //    {
            //        Text = "Home",
            //        Uri = Uri.Root,
            //        Active = TypeActive.Active,
            //        Icon = new PropertyIcon(TypeIcon.Home),
            //        Size = new PropertySizeText(TypeSizeText.Large),
            //        Margin = new PropertySpacingMargin(PropertySpacing.Space.Two, PropertySpacing.Space.None),
            //        TextColor = new PropertyColorText(TypeColorText.Dark)
            //    });
            //}
            //else if (this is PageTutorial)
            //{
            //    Sidebar.Header.Content.Add(new ControlLink()
            //    {
            //        Text = "Tutorials",
            //        Uri = Uri.Root.Append("tutorials"),
            //        Active = TypeActive.Active,
            //        Icon = new PropertyIcon(TypeIcon.GraduationCap),
            //        Size = new PropertySizeText(TypeSizeText.Large),
            //        Margin = new PropertySpacingMargin(PropertySpacing.Space.Two, PropertySpacing.Space.None),
            //        TextColor = new PropertyColorText(TypeColorText.Dark)
            //    });
            //}
            //else if (this is PageControl)
            //{
            //    Sidebar.Header.Content.Add(new ControlLink()
            //    {
            //        Text = "Controls",
            //        Uri = Uri.Root.Append("control"),
            //        Active = TypeActive.Active,
            //        Icon = new PropertyIcon(TypeIcon.Clone),
            //        Size = new PropertySizeText(TypeSizeText.Large),
            //        Margin = new PropertySpacingMargin(PropertySpacing.Space.Two, PropertySpacing.Space.None),
            //        TextColor = new PropertyColorText(TypeColorText.Dark)
            //    });
            //}
            //else if (this is PageHtml)
            //{
            //    Sidebar.Header.Content.Add(new ControlLink()
            //    {
            //        Text = "Html",
            //        Uri = Uri.Root.Append("html"),
            //        Active = TypeActive.Active,
            //        Icon = new PropertyIcon(TypeIcon.Code),
            //        Size = new PropertySizeText(TypeSizeText.Large),
            //        Margin = new PropertySpacingMargin(PropertySpacing.Space.Two, PropertySpacing.Space.None),
            //        TextColor = new PropertyColorText(TypeColorText.Dark)
            //    });
            //}
            //else if (this is PageHelp)
            //{
            //    Sidebar.Header.Content.Add(new ControlLink()
            //    {
            //        Text = "Hilfe",
            //        Uri = Uri.Root.Append("help"),
            //        Active = TypeActive.Active,
            //        Icon = new PropertyIcon(TypeIcon.InfoCircle),
            //        Size = new PropertySizeText(TypeSizeText.Large),
            //        Margin = new PropertySpacingMargin(PropertySpacing.Space.Two, PropertySpacing.Space.None),
            //        TextColor = new PropertyColorText(TypeColorText.Dark)
            //    });
            //}
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
