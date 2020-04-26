using System;
using WebExpress.UI.Controls;

namespace Education.Pages
{
    public class PageTutorial : PageBase, IPageTutorial
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageTutorial()
            : base("Tutorials")
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
                Text = "Tutorials",
                Format = TypesTextFormat.H1,
                Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.None, PropertySpacing.Space.None, PropertySpacing.Space.Five)
            });
        }
    }
}
