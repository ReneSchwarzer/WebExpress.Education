using WebExpress.UI.WebControl;
using WebExpress.WebAttribute;
using WebExpress.WebResource;

namespace Education.WebPage
{
    [Id("FormularInline")]
    [Title("education:page.control.formularinline.name")]
    [Segment("formularinline", "education:page.control.formularinline.name")]
    [Path("/Control")]
    [Module("edu")]
    [Context("control")]
    public sealed class PageControlFormularInline : PageControlBase
    {
        /// <summary>
        /// Das Beispielformular
        /// </summary>
        private readonly ControlFormularInline form = new ControlFormularInline("form", new ControlFormularItemInputTextBox("regards") { Label = "Grüße", Value = "Hallo Welt!", Icon = new PropertyIcon(TypeIcon.Font), Help = " Das ist der zugehörige Hilfetext." })
        {
        };

        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlFormularInline()
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        /// <param name="context">Der Kontext</param>
        public override void Initialization(IResourceContext context)
        {
            base.Initialization(context);

            Description = "Das ControlFormularInline stelt ein Formular bereit.";
            Code = @"new ControlFormularInline(""form"", new ControlFormularItemInputTextBox(""regards"") { Label = ""Grüße"", Value = ""Hallo Welt!"", Icon = new PropertyIcon(TypeIcon.Font), Help = ""Das ist der zugehörige Hilfetext."" })
            {
            };";


            AddExample(form);

            AddProperty
            (
                "Name",
                "Legt den Formularnamen fest",
                "Name = \"Formular\"",
                new ControlFormularInline(new ControlFormularItemInputTextBox("regards") { Label = "Grüße", Value = "Hallo Welt!" })
                {
                    Name = "Formular",
                    Border = new PropertyBorder(true),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two),
                    Padding = new PropertySpacingPadding(PropertySpacing.Space.Two)
                }
            );
        }
    }
}
