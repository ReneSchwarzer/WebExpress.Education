using WebExpress.UI.Controls;

namespace Education.Pages
{
    public class PageControlBreadcrumb : PageControlBase
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlBreadcrumb()
            : base("ControlBreadcrumb")
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        public override void Init()
        {
            base.Init();

            Description = "Das ControlBreadcrumb zerlegt den Uri-Pfad, so dass diese seperat aufgerufen werden können.";
            Code = "new ControlBreadcrumb(Page) { Uri = Page.Uri }";

            AddExample
            (
                new ControlBreadcrumb(this)
                {
                    Uri = Uri.Root
                },
                new ControlBreadcrumb(this)
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

        /// <summary>
        /// Verarbeitung
        /// </summary>
        public override void Process()
        {
            base.Process();
        }
    }
}
