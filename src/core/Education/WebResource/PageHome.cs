using WebExpress.Attribute;
using WebExpress.Module;
using WebExpress.UI.WebControl;
using WebExpress.Uri;

namespace Education.WebResource
{
    [ID("Home")]
    [Title("page.home.name")]
    [Segment("", "page.home.name")]
    [Path("")]
    [Module("edu")]
    [Context("general")]
    public sealed class PageHome : PageBase
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageHome()
        {
            //HeaderScriptLinks.Add(context.ContextPath.Append("/assets/js/Chart.min.js"));
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
                Text = "Willkommen",
                Format = TypeFormatText.H1,
                Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.None, PropertySpacing.Space.None, PropertySpacing.Space.Five)
            });
        }
    }
}
