using WebExpress.UI.WebControl;
using WebExpress.WebAttribute;
using WebExpress.WebResource;

namespace Education.WebPage
{
    [Id("FormularItemSelect")]
    [Title("education:page.control.formular.item.selection.name")]
    [Segment("formularselection", "education:page.control.formular.item.selection.name")]
    [Path("/Control")]
    [Module("edu")]
    [Context("control")]
    public sealed class PageControlFormularItemInputSelection : PageControlBase
    {
        /// <summary>
        /// Das Beispielformular
        /// </summary>
        private readonly ControlFormularItemInputSelection selection = new ControlFormularItemInputSelection
        (
            "selection",
            new ControlFormularItemInputSelectionItem() { Label = "Europa"},
            new ControlFormularItemInputSelectionItem() { Label = "Hallo Welt!", ID = "1", Image = "../assets/img/flag_de.svg" },
            new ControlFormularItemInputSelectionItem() { Label = "¡Hola mundo!", ID = "5", Image = "../assets/img/flag_es.svg" },
            new ControlFormularItemInputSelectionItem() { Label = "Всем привет!", ID = "3", Image = "../assets/img/flag_ru.svg" },
            new ControlFormularItemInputSelectionItem() { Label = "Welt" },
            new ControlFormularItemInputSelectionItem() { Label = "Hello World!", ID = "2", Image = "../assets/img/flag_us.svg" },
            new ControlFormularItemInputSelectionItem() { Label = "ハローワールド！", ID = "4", Image = null }
            
        )
        {
            Label = "Grüße",
            Icon = new PropertyIcon(TypeIcon.Font),
            Help = "Das ist der zugehörige Hilfetext."
        };

        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlFormularItemInputSelection()
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        /// <param name="context">Der Kontext</param>
        public override void Initialization(IResourceContext context)
        {
            base.Initialization(context);

            Description = "Die ControlFormularItemInputSelection stelt ein Auswahlfeld für Formulareingaben bereit.";
            Code = "new ControlFormularItemInputSelection \n";
            Code += "(\n";
            Code += "\"selection\",\n";
            Code += "new ControlFormularItemInputSelectionItem() { Label = \"Hallo Welt!\", ID = \"1\", Image = \"../assets/img/flag_de.svg\" },\n";
            Code += "new ControlFormularItemInputSelectionItem() { Label = \"Hello World!\", ID = \"2\", Image = \"../assets/img/flag_us.svg\" },\n";
            Code += "new ControlFormularItemInputSelectionItem() { Label = \"Всем привет!\", ID = \"3\", Image = \"../assets/img/flag_ru.svg\" },\n";
            Code += "new ControlFormularItemInputSelectionItem() { Label = \"ハローワールド！\", ID = \"4\" },\n";
            Code += "new ControlFormularItemInputSelectionItem() { Label = \"¡Hola mundo!\", ID = \"5\", Image = \"../assets/img/flag_es.svg\" } \n";
            Code += "})";

            var form = new ControlFormular(selection);
            form.FillFormular += (s, e) =>
            {
                selection.Value = "1";
            };

            AddExample(form);

            // Eigenschaften
            AddProperty
            (
                "Placeholder",
                "Legt einen Platzhaltertext fest",
                "Placeholder = \"Geben Sie hier einen Wert an!\"",
                new ControlFormular(new ControlFormularItemInputSelection
                (
                    "placeholder",
                    new ControlFormularItemInputSelectionItem() { Label = "Hallo Welt!", ID = "1", Image = "../assets/img/flag_de.svg" },
                    new ControlFormularItemInputSelectionItem() { Label = "Hello World!", ID = "2", Image = "../assets/img/flag_us.svg" },
                    new ControlFormularItemInputSelectionItem() { Label = "Всем привет!", ID = "3", Image = "../assets/img/flag_ru.svg" },
                    new ControlFormularItemInputSelectionItem() { Label = "ハローワールド！", ID = "4", Image = null },
                    new ControlFormularItemInputSelectionItem() { Label = "¡Hola mundo!", ID = "5", Image = "../assets/img/flag_es.svg" }
                ) 
                {
                    Label = "Grüße",
                    Placeholder = "Geben Sie hier einen Wert an!" 

                })
                {
                }
            );
        }
    }
}
