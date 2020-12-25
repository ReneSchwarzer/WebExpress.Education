using WebExpress.Attribute;
using WebExpress.Module;
using WebExpress.UI.WebControl;
using WebExpress.Uri;

namespace Education.WebResource
{
    [ID("Tutorial")]
    [Title("page.tutorial.name")]
    [Segment("tutorial", "page.tutorial.name")]
    [Path("/")]
    [Module("edu")]
    [Context("tutorial")]
    public sealed class PageTutorial : PageBase, IPageTutorial
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageTutorial()
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        public override void Initialization()
        {
            base.Initialization();
        }

        /// <summary>
        /// Verarbeitung
        /// </summary>
        public override void Process()
        {
            base.Process();

            Content.Primary.Add(new ControlText()
            {
                Text = "Tutorials",
                Format = TypeFormatText.H1,
                Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.None, PropertySpacing.Space.None, PropertySpacing.Space.Five)
            });
        }
    }
}
