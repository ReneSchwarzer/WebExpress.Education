using WebExpress.UI.WebControl;
using WebExpress.WebAttribute;
using WebExpress.WebResource;

namespace Education.WebPage
{
    [ID("FormularItemInputTag")]
    [Title("education:page.control.formular.item.tag.name")]
    [Segment("formulartag", "education:page.control.formular.item.tag.name")]
    [Path("/Control")]
    [Module("edu")]
    [Context("control")]
    public sealed class PageControlFormularItemTag : PageControlBase
    {
        /// <summary>
        /// Das Beispielformular
        /// </summary>
        private readonly ControlFormular form = new ControlFormular("form", new ControlFormularItemInputTag("regards") { Label = "Grüße", Value = "Hallo;Welt", Icon = new PropertyIcon(TypeIcon.Font), Help = " Das ist der zugehörige Hilfetext." })
        {
        };

        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlFormularItemTag()
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        /// <param name="context">Der Kontext</param>
        public override void Initialization(IResourceContext context)
        {
            base.Initialization(context);

            Description = "Das ControlFormularItemInputTag stelt eine Eingabe für Tags bereit.";
            Code = "new ControlFormularItemInputTag(\"form\", new ControlFormularItemInputTag(\"regards\") { Label = \"Grüße\", Value = \"Hallo;Welt!\", Icon = new PropertyIcon(TypeIcon.Font), Help = \"Das ist der zugehörige Hilfetext.\" })";


            AddExample(form);

            // Eigenschaften
            AddProperty
            (
                "Placeholder",
                "Legt einen Platzhaltertext fest",
                "Placeholder = \"Geben Sie hier einen Wert an!\"",
                new ControlFormular(new ControlFormularItemInputTag("placeholder") { Placeholder = "Geben Sie hier einen Wert an!", Value = "Hallo;Welt" })
                {
                    //Layout = TypeLayoutFormular.Inline,
                    EnableCancelButton = false
                }
            );

            AddProperty
            (
                "MinLength",
                "Legt die minimale Länge fest. Versuchen Sie weniger als drei Zeichen zu speichern.",
                "MinLength = 3",
                new ControlFormular(new ControlFormularItemInputTag("minlength") { Value = "Hallo;Welt" })
                {
                    //Layout = TypeLayoutFormular.Inline,
                    EnableCancelButton = false
                }
            );

            AddProperty
            (
                "MaxLength",
                "Legt die maximale Länge fest. Versuchen Sie mehr als drei Zeichen einzugeben.",
                "MaxLength = 3",
                new ControlFormular(new ControlFormularItemInputTag("maxlength") { Value = "Hallo;Welt" })
                {
                    //Layout = TypeLayoutFormular.Inline,
                    EnableCancelButton = false
                }
            );

            //AddProperty
            //(
            //    "Pattern",
            //    "Legt die maximale Länge fest. Versuchen Sie nur drei Buchstaben einzugeben.",
            //    "Pattern = \"[A-Za-z]{3}\"",
            //    new ControlFormular(new ControlFormularItemInputTag("pattern") { Pattern = "[A-Za-z]{3}", Value = "Hallo;Welt" })
            //    {
            //        Layout = TypeLayoutFormular.Inline,
            //        EnableCancelButton = false
            //    }
            //);
        }
    }
}
