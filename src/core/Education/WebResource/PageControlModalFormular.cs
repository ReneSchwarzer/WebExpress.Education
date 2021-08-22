using WebExpress.Attribute;
using WebExpress.UI.WebControl;

namespace Education.WebResource
{
    [ID("ModalFormular")]
    [Title("page.control.modalformular.name")]
    [Segment("modalformular", "page.control.modalformular.name")]
    [Path("/Control")]
    [Module("edu")]
    [Context("control")]
    public sealed class PageControlModalFormular : PageControlBase
    {
        /// <summary>
        /// Das Beispielformular
        /// </summary>
        private ControlModalForm Modal { get; set; }

        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlModalFormular()
        {
            var textBox = new ControlFormularItemInputTextBox("regards") 
            {
                Label = "Grüße", 
                Placeholder = "Geben Sie hier Ihre Grüße ein", 
                Icon = new PropertyIcon(TypeIcon.Font), 
                Help = " Das ist der zugehörige Hilfetext." 
            };

            textBox.Validation += (s, e) => 
            { 
                if (string.IsNullOrWhiteSpace(e.Value))
                {
                    e.Results.Add(new ValidationResult() { Type = TypesInputValidity.Error, Text = "Sie müssen mindestens ein Zeichen angeben" });
                }
            };

            Modal = new ControlModalForm("form", textBox)
            {
                Header = "Formular"
            };
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        public override void Initialization()
        {
            base.Initialization();

            Description = "Das ControlModalFormular stelt ein Formular in einem modalen Dialog bereit.";
            Code = "new ControlModalFormular(\"form\", new ControlFormularItemInputTextBox(\"regards\") { Label = \"Grüße\", Placeholder = \"Geben Sie hier Ihre Grüße ein\", Icon = new PropertyIcon(TypeIcon.Font), Help = \"Das ist der zugehörige Hilfetext.\" })";


            AddExample(new ControlButton() 
            { 
                Text = "Klicke zum öffnen des Formulars", 
                BackgroundColor = new PropertyColorButton(TypeColorButton.Primary), 
                Modal = Modal
            });

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

            //AddProperty
            //(
            //    "Name",
            //    "Legt den Formularnamen fest",
            //    "Name = \"Formular\"",
            //    new ControlFormular(new ControlFormularItemInputTextBox("regards") { Label = "Grüße", Value = "Hallo Welt!" })
            //    {
            //        Name = "Formular",
            //        Border = new PropertyBorder(true),
            //        EnableCancelButton = false,
            //        Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two),
            //        Padding = new PropertySpacingPadding(PropertySpacing.Space.Two)
            //    }
            //);

            //AddProperty
            //(
            //    "EnableCancelButton",
            //    "Bestimmt ob die Abbrechenschaltfläche angezeigt wird.",
            //    "EnableCancelButton = true",
            //    new ControlFormular(new ControlFormularItemInputTextBox("cancel") { Label = "Abbrechen", Value = "Die Abbrechen-Schaltfläche ist an" })
            //    {
            //        Name = "Formular",
            //        Border = new PropertyBorder(true),
            //        EnableCancelButton = true,
            //        Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two),
            //        Padding = new PropertySpacingPadding(PropertySpacing.Space.Two)
            //    },
            //    new ControlFormular(new ControlFormularItemInputTextBox("cancel") { Label = "Abbrechen", Value = "Die Abbrechen-Schaltfläche ist aus" })
            //    {
            //        Name = "Formular",
            //        Border = new PropertyBorder(true),
            //        EnableCancelButton = false,
            //        Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two),
            //        Padding = new PropertySpacingPadding(PropertySpacing.Space.Two)
            //    }
            //);

        }
    }
}
