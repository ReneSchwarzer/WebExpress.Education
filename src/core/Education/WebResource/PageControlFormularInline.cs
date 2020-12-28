using WebExpress.Attribute;
using WebExpress.UI.WebControl;

namespace Education.WebResource
{
    [ID("FormularInline")]
    [Title("page.control.formularinline.name")]
    [Segment("formularinline", "page.control.formularinline.name")]
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
        public override void Initialization()
        {
            base.Initialization();

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
