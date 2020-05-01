using System.Linq;
using WebExpress.Pages;
using WebExpress.UI.Controls;

namespace Education.Pages
{
    public abstract class PageControlBase : PageBaseItem, IPageControl
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlBase()
            : base("Controls")
        {
        }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="name">Der Seitenname</param>
        public PageControlBase(string name)
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

            foreach (var v in pages.Where(x=> x.ID != new UriSegmentID("Controls")).OrderBy(x => x.Display))
            {
                var uri = Context.SiteMap.GetUri(v.ID) as UriPage;
                var last = Uri.Path.LastOrDefault() as UriPathSegmentPage;

                if (uri.Contains("Controls"))
                {
                    Menu.Items.Add(new ControlLink(this)
                    {
                        Text = v.Display,
                        Uri = uri,
                        Active = last.SegmentID == v.ID ? TypeActive.Active : TypeActive.None
                    });
                }
            }
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
