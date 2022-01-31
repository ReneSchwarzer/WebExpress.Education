using WebExpress.UI.WebControl;
using WebExpress.WebAttribute;
using WebExpress.WebResource;

namespace Education.WebPage
{
    [ID("FormularItemGroupMix")]
    [Title("education:page.control.formular.item.groupmix.name")]
    [Segment("formulargroupmix", "education:page.control.formular.item.groupmix.name")]
    [Path("/Control")]
    [Module("edu")]
    [Context("control")]
    public sealed class PageControlFormularItemGroupMix : PageControlBase
    {
        /// <summary>
        /// Das Beispielformular
        /// </summary>
        private readonly ControlFormular form = new ControlFormular("form", new ControlFormularItemGroupMix
        (
            new ControlFormularItemInputTextBox() { Name = "zip", Label = "Zip", Icon = new PropertyIcon(TypeIcon.MapMarker), Help = "Hilfetext zur Postleitzahl" },
            new ControlFormularItemInputTextBox() { Name = "place", Label = "Place", Icon = new PropertyIcon(TypeIcon.City), Help = "Hilfetext zum Ort" }
        ));

        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlFormularItemGroupMix()
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        /// <param name="context">Der Kontext</param>
        public override void Initialization(IResourceContext context)
        {
            base.Initialization(context);

            Description = "Das ControlFormularItemGroupMix stelt eine Gruppierung für Formulareingaben bereit.";
            Code = @"new ControlFormular(""form"", new ControlFormularItemGroupMix
            (
                new ControlFormularItemInputTextBox() { Name = ""zip"", Label = ""Zip"", Icon = new PropertyIcon(TypeIcon.MapMarker), Help = ""Hilfetext zur Postleitzahl"" },
                new ControlFormularItemInputTextBox() { Name = ""place"", Label = ""Place"", Icon = new PropertyIcon(TypeIcon.City), Help = ""Hilfetext zum Ort"" }
            )); ";

            AddExample(form);

            // Eigenschaften
            //AddProperty
            //(
            //    "Placeholder",
            //    "Legt einen Platzhaltertext fest",
            //    "Placeholder = \"Geben Sie hier einen Wert an!\"",
            //    new ControlFormular(new ControlFormularItemInputTextBox("placeholder") { Placeholder = "Geben Sie hier einen Wert an!" })
            //    {
            //        Layout = TypeLayoutFormular.Inline,
            //        EnableCancelButton = false
            //    }
            //);
        }
    }
}
