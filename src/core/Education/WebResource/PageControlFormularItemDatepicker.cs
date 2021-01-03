using System;
using WebExpress.Attribute;
using WebExpress.UI.WebControl;

namespace Education.WebResource
{
    [ID("FormularItemInputDatepicker")]
    [Title("page.control.formular.item.datepicker.name")]
    [Segment("formulartag", "page.control.formular.item.datepicker.name")]
    [Path("/Control")]
    [Module("edu")]
    [Context("control")]
    public sealed class PageControlFormularItemDatepicker : PageControlBase
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlFormularItemDatepicker()
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        public override void Initialization()
        {
            base.Initialization();

            var form = new ControlFormular("form", new ControlFormularItemInputDatepicker("regards")
            {
                Label = "Grüße",
                Icon = new PropertyIcon(TypeIcon.Font),
                Value = DateTime.Now.ToString(Culture.DateTimeFormat.ShortDatePattern),
                Help = " Das ist der zugehörige Hilfetext."
            })
            {
            };

            Description = "Das ControlFormularItemInputDatepicker stelt eine Eingabe für ein Datum bereit.";
            Code = "new ControlFormularItemInputDatepicker(\"form\", new ControlFormularItemInputTag(\"regards\") { Label = \"Grüße\", Value = \"Hallo;Welt!\", Icon = new PropertyIcon(TypeIcon.Font), Help = \"Das ist der zugehörige Hilfetext.\" })";

            AddExample(form);

            // Eigenschaften
           
        }
    }
}
