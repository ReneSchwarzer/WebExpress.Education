using WebExpress.UI.WebControl;
using WebExpress.WebAttribute;
using WebExpress.WebResource;

namespace Education.WebPage
{
    [Id("FormularItemComboBox")]
    [Title("education:page.control.formular.item.combobox.name")]
    [Segment("formularcombobox", "education:page.control.formular.item.combobox.name")]
    [Path("/Control")]
    [Module("edu")]
    [Context("control")]
    public sealed class PageControlFormularItemComboBox : PageControlBase
    {
        /// <summary>
        /// Das Beispielformular
        /// </summary>
        private readonly ControlFormularItemInputComboBox combo = new ControlFormularItemInputComboBox
        (
            "combo",
            new ControlFormularItemInputComboBoxItem() { Value = null },
            new ControlFormularItemInputComboBoxItem() { Text = "Hallo Welt!", Value = "1" },
            new ControlFormularItemInputComboBoxItem() { Text = "Hello World!", Value = "2" },
            new ControlFormularItemInputComboBoxItem() { Text = "Всем привет!", Value = "3" },
            new ControlFormularItemInputComboBoxItem() { Text = "ハローワールド！", Value = "4" },
            new ControlFormularItemInputComboBoxItem() { Text = "¡Hola mundo!", Value = "5" }
        )
        {
            Label = "Grüße",
            Icon = new PropertyIcon(TypeIcon.Font),
            Help = "Das ist der zugehörige Hilfetext."
        };

        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlFormularItemComboBox()
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        /// <param name="context">Der Kontext</param>
        public override void Initialization(IResourceContext context)
        {
            base.Initialization(context);

            Description = "Die ControlFormularItemInputComboBox stelt eine ComboBox für Formulareingaben bereit.";
            Code = "new ControlFormularItemInputComboBox \n";
            Code += "(\n";
            Code += "\"combo\",\n";
            Code += "new ControlFormularItemInputComboBoxItem() { Value = null },\n";
            Code += "new ControlFormularItemInputComboBoxItem() { Text = \"Hallo Welt!\", Value = \"1\" },\n";
            Code += "new ControlFormularItemInputComboBoxItem() { Text = \"Hello World!\", Value = \"2\" },\n";
            Code += "new ControlFormularItemInputComboBoxItem() { Text = \"Всем привет!\", Value = \"3\" },\n";
            Code += "new ControlFormularItemInputComboBoxItem() { Text = \"ハローワールド！\", Value = \"4\" },\n";
            Code += "new ControlFormularItemInputComboBoxItem() { Text = \"¡Hola mundo!\", Value = \"5\" \n";
            Code += "})";


            var form = new ControlFormular(combo);
            form.InitializeFormular += (s, e) =>
            {
                combo.Value = "1";
            };

            AddExample(form);

            //// Eigenschaften
            //AddProperty
            //(
            //    "Placeholder",
            //    "Legt einen Platzhaltertext fest",
            //    "Placeholder = \"Geben Sie hier einen Wert an!\"",
            //    new ControlFormular(new ControlFormularItemInputComboBox("placeholder") { Placeholder = "Geben Sie hier einen Wert an!" })
            //    {
            //        Layout = TypeLayoutFormular.Inline,
            //        EnableCancelButton = false
            //    }
            //);


        }
    }
}
