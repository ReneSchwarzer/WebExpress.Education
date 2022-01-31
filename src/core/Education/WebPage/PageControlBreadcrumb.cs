using WebExpress.UI.WebControl;
using WebExpress.WebAttribute;
using WebExpress.WebResource;

namespace Education.WebPage
{
    [ID("Breadcrumb")]
    [Title("education:page.control.breadcrumb.name")]
    [Segment("breadcrumb", "education:page.control.breadcrumb.name")]
    [Path("/Control")]
    [Module("edu")]
    [Context("control")]
    public sealed class PageControlBreadcrumb : PageControlBase
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlBreadcrumb()
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        /// <param name="context">Der Kontext</param>
        public override void Initialization(IResourceContext context)
        {
            base.Initialization(context);

            Description = "Das ControlBreadcrumb zerlegt den Uri-Pfad, so dass diese seperat aufgerufen werden können.";
            Code = "new ControlBreadcrumb() { Uri = Page.Uri }";

            AddExample
            (
                new ControlBreadcrumb()
                {
                    Uri = Uri.Root
                },
                new ControlBreadcrumb()
                {
                    Uri = Uri
                }
            );

            //// Eigenschaften
            //AddProperty
            //(
            //    "Pill",
            //    new ControlBadge(this)
            //    {
            //        Value = "Standard",
            //        Pill = TypesBadgePill.Pill
            //    },
            //    new ControlBadge(this)
            //    {
            //        Value = "Primär",
            //        Pill = TypesBadgePill.Pill,
            //        BackgroundColor = new PropertyColorBackground(TypesBackgroundColor.Primary)
            //    },
            //    new ControlBadge(this)
            //    {
            //        Value = "Sekundär",
            //        Pill = TypesBadgePill.Pill,
            //        BackgroundColor = new PropertyColorBackground(TypesBackgroundColor.Secondary)
            //    },
            //    new ControlBadge(this)
            //    {
            //        Value = "Info",
            //        Pill = TypesBadgePill.Pill,
            //        BackgroundColor = new PropertyColorBackground(TypesBackgroundColor.Info)
            //    },
            //    new ControlBadge(this)
            //    {
            //        Value = "Erfolg",
            //        Pill = TypesBadgePill.Pill,
            //        BackgroundColor = new PropertyColorBackground(TypesBackgroundColor.Success)
            //    },
            //    new ControlBadge(this)
            //    {
            //        Value = "Warnung",
            //        Pill = TypesBadgePill.Pill,
            //        BackgroundColor = new PropertyColorBackground(TypesBackgroundColor.Warning)
            //    },
            //    new ControlBadge(this)
            //    {
            //        Value = "Fehler",
            //        Pill = TypesBadgePill.Pill,
            //        BackgroundColor = new PropertyColorBackground(TypesBackgroundColor.Danger)
            //    },
            //    new ControlBadge(this)
            //    {
            //        Value = "Dunkel",
            //        Pill = TypesBadgePill.Pill,
            //        BackgroundColor = new PropertyColorBackground(TypesBackgroundColor.Dark)
            //    },
            //    new ControlBadge(this)
            //    {
            //        Value = "Hell",
            //        Pill = TypesBadgePill.Pill,
            //        BackgroundColor = new PropertyColorBackground(TypesBackgroundColor.Light)
            //    },
            //    new ControlBadge(this)
            //    {
            //        Value = "Weiß",
            //        Pill = TypesBadgePill.Pill,
            //        BackgroundColor = new PropertyColorBackground(TypesBackgroundColor.White)
            //    },
            //    new ControlBadge(this)
            //    {
            //        Value = "Transparent",
            //        Pill = TypesBadgePill.Pill,
            //        BackgroundColor = new PropertyColorBackground(TypesBackgroundColor.Transparent)
            //    },
            //    new ControlBadge(this)
            //    {
            //        Value = "Benutzerdefiniert",
            //        Pill = TypesBadgePill.Pill,
            //        Color = new PropertyColorText("red"),
            //        BackgroundColor = new PropertyColorBackground("gold")
            //    }
            //);

            //AddProperty
            //(
            //    "Link",
            //    new ControlBadge(this)
            //    {
            //        Value = "Standard",
            //        Uri = Uri
            //    },
            //    new ControlBadge(this)
            //    {
            //        Value = "Primär",
            //        Uri = Uri,
            //        BackgroundColor = new PropertyColorBackground(TypesBackgroundColor.Primary)
            //    },
            //    new ControlBadge(this)
            //    {
            //        Value = "Sekundär",
            //        Uri = Uri,
            //        BackgroundColor = new PropertyColorBackground(TypesBackgroundColor.Secondary)
            //    },
            //    new ControlBadge(this)
            //    {
            //        Value = "Info",
            //        Uri = Uri,
            //        BackgroundColor = new PropertyColorBackground(TypesBackgroundColor.Info)
            //    },
            //    new ControlBadge(this)
            //    {
            //        Value = "Erfolg",
            //        Uri = Uri,
            //        BackgroundColor = new PropertyColorBackground(TypesBackgroundColor.Success)
            //    },
            //    new ControlBadge(this)
            //    {
            //        Value = "Warnung",
            //        Uri = Uri,
            //        BackgroundColor = new PropertyColorBackground(TypesBackgroundColor.Warning)
            //    },
            //    new ControlBadge(this)
            //    {
            //        Value = "Fehler",
            //        Uri = Uri,
            //        BackgroundColor = new PropertyColorBackground(TypesBackgroundColor.Danger)
            //    },
            //    new ControlBadge(this)
            //    {
            //        Value = "Dunkel",
            //        Uri = Uri,
            //        BackgroundColor = new PropertyColorBackground(TypesBackgroundColor.Dark)
            //    },
            //    new ControlBadge(this)
            //    {
            //        Value = "Hell",
            //        Uri = Uri,
            //        BackgroundColor = new PropertyColorBackground(TypesBackgroundColor.Light)
            //    },
            //    new ControlBadge(this)
            //    {
            //        Value = "Weiß",
            //        Uri = Uri,
            //        BackgroundColor = new PropertyColorBackground(TypesBackgroundColor.White)
            //    },
            //    new ControlBadge(this)
            //    {
            //        Value = "Transparent",
            //        Uri = Uri,
            //        BackgroundColor = new PropertyColorBackground(TypesBackgroundColor.Transparent)
            //    },
            //    new ControlBadge(this)
            //    {
            //        Value = "Benutzerdefiniert",
            //        Uri = Uri,
            //        Color = new PropertyColorText("red"),
            //        BackgroundColor = new PropertyColorBackground("gold")
            //    }
            //);
        }
    }
}
