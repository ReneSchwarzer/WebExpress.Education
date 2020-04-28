using System.Linq;
using WebExpress.Pages;
using WebExpress.UI.Controls;

namespace Education.Pages
{
    public class PageControl : PageBase, IPageControl
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControl()
            : base("Controls")
        {
        }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="name">Der Seitenname</param>
        public PageControl(string name)
            : base(name)
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        public override void Init()
        {
            base.Init();

            var pages = Context.SiteMap.Pages.Values.Distinct();
            var grid = new ControlGrid(this)
            {
                Margin = new PropertySpacingMargin(PropertySpacing.Space.Null)
            };

            var content = new ControlPanel(this);

            content.Content.Add(new ControlText(this)
            {
                Text = "Allgemein",
                Format = TypesTextFormat.H1
            });

            content.Content.Add(new ControlText(this)
            {
                Text = "Steuerelemente sind komplexe HTML-Objekte.",
                Format = TypesTextFormat.Paragraph
            });


            var tab = new ControlTab(this)
            {
                Layout = TypesLayoutTab.Pill,
                Orientation = TypesNavOrientation.Vertical
            };

            foreach (var v in pages.Where(x=> x.ID != new UriSegmentID("Controls")).OrderBy(x => x.Display))
            {
                var uri = Context.SiteMap.GetUri(v.ID) as UriPage;
                var last = Uri.Path.LastOrDefault() as UriPathSegmentPage;

                if (uri.Contains("Controls"))
                {
                    tab.Items.Add(new ControlLink(this)
                    {
                        Text = v.Display,
                        Uri = uri,
                        Active = last.SegmentID == v.ID ? TypesActive.Active : TypesActive.None
                    });
                }
            }

            grid.Add(0, 2, tab);
            grid.Add(0, 10, content);
            Main.Content.Add(grid);
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
