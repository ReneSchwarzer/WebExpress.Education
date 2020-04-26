using WebExpress.UI.Controls;

namespace Education.Pages
{
    public abstract class PageControl : PageBaseItem, IPageControl
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

            Menu.Items.Add(new ControlLink(this)
            {
                Text = "Alert",
                Uri = Uri.Take(2).Append("alert"),
                Active = this is PageControlAlert ? TypesActive.Active : TypesActive.None   
            });
            Menu.Items.Add(new ControlLink(this)
            {
                Text = "Badge",
                Uri = Uri.Take(2).Append("badge"),
                Active = this is PageControlBadge ? TypesActive.Active : TypesActive.None
            });
            Menu.Items.Add(new ControlLink(this)
            {
                Text = "Breadcrumb",
                Uri = Uri.Take(2).Append("breadcrumb"),
                Active = this is PageControlBreadcrumb ? TypesActive.Active : TypesActive.None
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
