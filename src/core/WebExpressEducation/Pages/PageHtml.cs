using System;
using WebExpress.UI.Controls;

namespace Education.Pages
{
    public class PageHtml : PageBase, IPageHtml
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageHtml()
            : base("Html")
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        public override void Init()
        {
            base.Init();
        }

        /// <summary>
        /// Verarbeitung
        /// </summary>
        public override void Process()
        {
            base.Process();

            Main.Content.Add(new ControlText(this)
            {
                Text = "Html",
                Format = TypesTextFormat.H1,
                Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.None, PropertySpacing.Space.None, PropertySpacing.Space.Five)
            });
        }
    }
}
