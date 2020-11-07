using WebExpress.UI.Controls;

namespace Education.Pages
{
    public class PageControlFormularTextBox : PageControlBase
    {
        /// <summary>
        /// Das Beispielformular
        /// </summary>
        ControlFormular form = new ControlFormular("form", new ControlFormularItemInputTextBox("regards") { Label = "Grüße", Value = "Hallo Welt!", Icon = new PropertyIcon(TypeIcon.Font), Help = " Das ist der zugehörige Hilfetext." })
        {
        };

        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlFormularTextBox()
            : base("ControlFormularItemInputTextBox")
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        public override void Init()
        {
            base.Init();

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
                    Layout = TypeLayoutFormular.Inline,
                    EnableCancelButton = false
                }
            );

            AddProperty
            (
                "MinLength",
                "Legt die minimale Länge fest. Versuchen Sie weniger als drei Zeichen zu speichern.",
                "MinLength = 3",
                new ControlFormular(new ControlFormularItemInputTextBox("minlength") { MinLength = 3 })
                {
                    Layout = TypeLayoutFormular.Inline,
                    EnableCancelButton = false
                }
            );

            AddProperty
            (
                "MaxLength",
                "Legt die maximale Länge fest. Versuchen Sie mehr als drei Zeichen einzugeben.",
                "MaxLength = 3",
                new ControlFormular(new ControlFormularItemInputTextBox("maxlength") { MaxLength = 3 })
                {
                    Layout = TypeLayoutFormular.Inline,
                    EnableCancelButton = false
                }
            );
            
            AddProperty
            (
                "Pattern",
                "Legt die maximale Länge fest. Versuchen Sie nur drei Buchstaben einzugeben.",
                "Pattern = \"[A-Za-z]{3}\"",
                new ControlFormular(new ControlFormularItemInputTextBox("pattern") { Pattern = "[A-Za-z]{3}" })
                {
                    Layout = TypeLayoutFormular.Inline,
                    EnableCancelButton = false
                }
            );
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
