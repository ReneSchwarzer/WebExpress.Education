using WebExpress.UI.WebControl;
using WebExpress.WebAttribute;
using WebExpress.WebResource;

namespace Education.WebPage
{
    [ID("FormularItemGroupColumnMix")]
    [Title("education:page.control.formular.item.groupcolumnmix.name")]
    [Segment("formulargroupcolumnmix", "education:page.control.formular.item.groupcolumnmix.name")]
    [Path("/Control")]
    [Module("edu")]
    [Context("control")]
    public sealed class PageControlFormularItemGroupColumnMix : PageControlBase
    {
        /// <summary>
        /// Das Beispielformular
        /// </summary>
        private readonly ControlFormular form = new ControlFormular("form", new ControlFormularItemGroupColumnMix
        (
            new ControlFormularItemInputTextBox() { Name = "zip", Label = "Zip", Icon = new PropertyIcon(TypeIcon.MapMarker), Help = "Hilfetext zur Postleitzahl" },
            new ControlFormularItemInputTextBox() { Name = "place", Label = "Place", Icon = new PropertyIcon(TypeIcon.City), Help = "Hilfetext zum Ort" }
        )
        {
            Distribution = new int[] { 33 }
        });

        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlFormularItemGroupColumnMix()
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        /// <param name="context">Der Kontext</param>
        public override void Initialization(IResourceContext context)
        {
            base.Initialization(context);

            Description = "Das ControlFormularItemGroupColumnMix stelt eine Gruppierung für Formulareingaben bereit.";
            Code = @"new ControlFormular(""form"", new ControlFormularItemGroupColumnMix
            (
                new ControlFormularItemInputTextBox() { Name = ""zip"", Label = ""Zip"", Icon = new PropertyIcon(TypeIcon.MapMarker), Help = ""Hilfetext zur Postleitzahl"" },
                new ControlFormularItemInputTextBox() { Name = ""place"", Label = ""Place"", Icon = new PropertyIcon(TypeIcon.City), Help = ""Hilfetext zum Ort"" }
            )
            {
                Distribution = new int[] { 33 }
            });";

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
