using WebExpress.WebApp.WebPage;
using WebExpress.WebResource;

namespace Education.WebPage
{
    public abstract class PageBase : PageWebApp
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
        /// <param name="context">Der Kontext</param>
        public override void Initialization(IResourceContext context)
        {
            base.Initialization(context);

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
        /// <param name="context">Der Kontext zum Rendern der Seite</param>
        public override void Process(RenderContextWebApp context)
        {
            base.Process(context);
        }
    }
}
