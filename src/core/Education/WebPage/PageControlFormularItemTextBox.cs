using WebExpress.UI.WebControl;
using WebExpress.WebAttribute;
using WebExpress.WebResource;

namespace Education.WebPage
{
    [Id("FormularItemTextBox")]
    [Title("education:page.control.formular.item.textbox.name")]
    [Segment("formulartextbox", "education:page.control.formular.item.textbox.name")]
    [Path("/Control")]
    [Module("edu")]
    [Context("control")]
    public sealed class PageControlFormularItemTextBox : PageControlBase
    {
        /// <summary>
        /// Das Beispielformular
        /// </summary>
        private readonly ControlFormular form = new ControlFormular("form", new ControlFormularItemInputTextBox("regards") { Label = "Grüße", Value = "Hallo Welt!", Icon = new PropertyIcon(TypeIcon.Font), Help = " Das ist der zugehörige Hilfetext." })
        {
        };

        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlFormularItemTextBox()
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        /// <param name="context">Der Kontext</param>
        public override void Initialization(IResourceContext context)
        {
            base.Initialization(context);

            Description = "Das ControlFormularItemInputTextBox stelt eine Textbox für Formulareingaben bereit.";
            Code = "new ControlFormularItemInputTextBox(\"form\", new ControlFormularItemInputTextBox(\"regards\") { Label = \"Grüße\", Value = \"Hallo Welt!\", Icon = new PropertyIcon(TypeIcon.Font), Help = \"Das ist der zugehörige Hilfetext.\" })";


            AddExample(form);

            // Eigenschaften
            AddProperty
            (
                "Placeholder",
                "Legt einen Platzhaltertext fest",
                "Placeholder = \"Geben Sie hier einen Wert an!\"",
                new ControlFormular(new ControlFormularItemInputTextBox("placeholder") { Placeholder = "Geben Sie hier einen Wert an!" })
                {
                    //Layout = TypeLayoutFormular.Inline,
                }
            );

            AddProperty
            (
                "MinLength",
                "Legt die minimale Länge fest. Versuchen Sie weniger als drei Zeichen zu speichern.",
                "MinLength = 3",
                new ControlFormular(new ControlFormularItemInputTextBox("minlength") { MinLength = 3 })
                {
                    //Layout = TypeLayoutFormular.Inline,
                }
            );

            AddProperty
            (
                "MaxLength",
                "Legt die maximale Länge fest. Versuchen Sie mehr als drei Zeichen einzugeben.",
                "MaxLength = 3",
                new ControlFormular(new ControlFormularItemInputTextBox("maxlength") { MaxLength = 3 })
                {
                    //Layout = TypeLayoutFormular.Inline,
                }
            );

            AddProperty
            (
                "Pattern",
                "Legt die maximale Länge fest. Versuchen Sie nur drei Buchstaben einzugeben.",
                "Pattern = \"[A-Za-z]{3}\"",
                new ControlFormular(new ControlFormularItemInputTextBox("pattern") { Pattern = "[A-Za-z]{3}" })
                {
                    //Layout = TypeLayoutFormular.Inline,
                }
            );
        }
    }
}
