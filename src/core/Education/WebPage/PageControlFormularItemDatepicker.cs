using System;
using WebExpress.UI.WebControl;
using WebExpress.WebAttribute;
using WebExpress.WebResource;

namespace Education.WebPage
{
    [ID("FormularItemInputDatepicker")]
    [Title("education:page.control.formular.item.datepicker.name")]
    [Segment("formulartag", "education:page.control.formular.item.datepicker.name")]
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
        /// <param name="context">Der Kontext</param>
        public override void Initialization(IResourceContext context)
        {
            base.Initialization(context);

            var form = new ControlFormular("form", new ControlFormularItemInputDatepicker("regards")
            {
                Label = "Grüße",
                Icon = new PropertyIcon(TypeIcon.Font),
                Value = DateTime.Now.ToString(Culture.DateTimeFormat.ShortDatePattern),
                Help = "Das ist der zugehörige Hilfetext."
            });

            Description = "Das ControlFormularItemInputDatepicker stelt eine Eingabe für ein Datum bereit.";
            Code = @"new ControlFormular(""form"", new ControlFormularItemInputDatepicker(""regards"")
            {
                Label = ""Grüße"",
                Icon = new PropertyIcon(TypeIcon.Font),
                Value = DateTime.Now.ToString(Culture.DateTimeFormat.ShortDatePattern),
                Help = ""Das ist der zugehörige Hilfetext.""
            });";

            AddExample(form);

            // Eigenschaften

        }
    }
}
