using WebExpress.Attribute;
using WebExpress.Module;
using WebExpress.UI.WebControl;
using WebExpress.Uri;

namespace Education.WebResource
{
    [ID("Formular")]
    [Title("page.control.formular.name")]
    [Segment("formular", "page.control.formular.name")]
    [Path("/Control")]
    [Module("edu")]
    [Context("control")]
    public sealed class PageControlFormular : PageControlBase
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
        public PageControlFormular()
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        public override void Initialization()
        {
            base.Initialization();

            Description = "Das ControlFormular stelt ein Formular bereit.";
            Code = "new ControlFormular(\"form\", new ControlFormularItemInputTextBox(\"regards\") { Label = \"Grüße\", Value = \"Hallo Welt!\", Icon = new PropertyIcon(TypeIcon.Font), Help = \"Das ist der zugehörige Hilfetext.\" })";


            AddExample(form);

            // Eigenschaften
            //AddProperty
            //(
            //    "Layout",
            //    "Legt die Anordnung der Steuerelemente fest",
            //    "Layout = TypeLayoutFormular.Inline",
            //    new ControlFormular(new ControlFormularItemInputTextBox("layout1") { Icon = new PropertyIcon(TypeIcon.AlignLeft), Label = "Anordnung", Value = "Default", Help = "Dies ist ein Hilfetext" })
            //    {
            //        Border = new PropertyBorder(true),
            //        EnableCancelButton = false,
            //        Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two),
            //        Padding = new PropertySpacingPadding(PropertySpacing.Space.Two)
            //    },
            //    new ControlFormular(new ControlFormularItemInputTextBox("layout1") { Icon = new PropertyIcon(TypeIcon.AlignLeft), Label = "Anordnung", Value = "Inline", Help = "Dies ist ein Hilfetext" })
            //    {
            //        Border = new PropertyBorder(true),
            //        EnableCancelButton = false,
            //        Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two),
            //        Padding = new PropertySpacingPadding(PropertySpacing.Space.Two)
            //    },
            //    new ControlFormular(new ControlFormularItemInputTextBox("layout2") { Icon = new PropertyIcon(TypeIcon.AlignLeft), Label = "Anordnung", Value = "Horizontal", Help = "Dies ist ein Hilfetext" })
            //    {
            //        Border = new PropertyBorder(true),
            //        EnableCancelButton = false,
            //        Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two),
            //        Padding = new PropertySpacingPadding(PropertySpacing.Space.Two)
            //    }
            //);

            AddProperty
            (
                "Name",
                "Legt den Formularnamen fest",
                "Name = \"Formular\"",
                new ControlFormular(new ControlFormularItemInputTextBox("regards") { Label = "Grüße", Value = "Hallo Welt!" })
                {
                    Name = "Formular",
                    Border = new PropertyBorder(true),
                    EnableCancelButton = false,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two),
                    Padding = new PropertySpacingPadding(PropertySpacing.Space.Two)
                }
            );

            AddProperty
            (
                "EnableCancelButton",
                "Bestimmt ob die Abbrechenschaltfläche angezeigt wird.",
                "EnableCancelButton = true",
                new ControlFormular(new ControlFormularItemInputTextBox("cancel") { Label = "Abbrechen", Value = "Die Abbrechen-Schaltfläche ist an" })
                {
                    Name = "Formular",
                    Border = new PropertyBorder(true),
                    EnableCancelButton = true,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two),
                    Padding = new PropertySpacingPadding(PropertySpacing.Space.Two)
                },
                new ControlFormular(new ControlFormularItemInputTextBox("cancel") { Label = "Abbrechen", Value = "Die Abbrechen-Schaltfläche ist aus" })
                {
                    Name = "Formular",
                    Border = new PropertyBorder(true),
                    EnableCancelButton = false,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two),
                    Padding = new PropertySpacingPadding(PropertySpacing.Space.Two)
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
