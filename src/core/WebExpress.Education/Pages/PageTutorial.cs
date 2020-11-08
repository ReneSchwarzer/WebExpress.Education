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

            Content.Content.Add(new ControlText()
            {
                Text = "Tutorials",
                Format = TypeFormatText.H1,
                Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.None, PropertySpacing.Space.None, PropertySpacing.Space.Five)
            });
        }
    }
}
