using System.Collections.Generic;
using WebExpress.Attribute;
using WebExpress.Module;
using WebExpress.UI.WebControl;
using WebExpress.Uri;

namespace Education.WebResource
{
    [ID("FormularGrid")]
    [Title("page.control.formulargrid.name")]
    [Segment("formulargrid", "page.control.formulargrid.name")]
    [Path("/Control")]
    [Module("edu")]
    [Context("control")]
    public sealed class PageControlFormularGrid : PageControlBase
    {
        

        /// <summary>
        /// Das Beispielformular
        /// </summary>
        private readonly ControlFormular form = new ControlFormular("form", new ControlFormularItemGrid
        (
            "grid", 
            new ControlFormularItemLabelGroup("zip", new ControlFormularItemInputTextBox() { Name = "zip", Label = "Zip" }) { GridColumn = new PropertyGrid(TypeDevice.Auto, 3) },
            new ControlFormularItemLabelGroup("place", new ControlFormularItemInputTextBox() { Name = "place", Label = "Place" }) { GridColumn = new PropertyGrid(TypeDevice.Auto, 9) }
        ));

        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlFormularGrid()
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        public override void Initialization()
        {
            base.Initialization();

            Description = "Das ControlFormularGrid stelt eine Gruppierung für Formulareingaben bereit.";
            Code = @"new ControlFormular(""form"", new ControlFormularItemGrid
            (
                ""grid"",
                new ControlFormularItemLabelGroup(""zip"", new ControlFormularItemInputTextBox() { Name = ""zip"", Label = ""Zip"" }) { GridColumn = new PropertyGrid(TypeDevice.Auto, 3) },
                new ControlFormularItemLabelGroup(""place"", new ControlFormularItemInputTextBox() { Name = ""place"", Label = ""Place"" }) { GridColumn = new PropertyGrid(TypeDevice.Auto, 9) }
            ));";

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

        /// <summary>
        /// Verarbeitung
        /// </summary>
        public override void Process()
        {
            base.Process();
        }
    }
}
