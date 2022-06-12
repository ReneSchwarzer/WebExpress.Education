using WebExpress.UI.WebControl;
using WebExpress.WebAttribute;
using WebExpress.WebResource;

namespace Education.WebPage
{
    [Id("Formular")]
    [Title("education:page.control.formular.name")]
    [Segment("formular", "education:page.control.formular.name")]
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
        /// <param name="context">Der Kontext</param>
        public override void Initialization(IResourceContext context)
        {
            base.Initialization(context);

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
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two),
                    Padding = new PropertySpacingPadding(PropertySpacing.Space.Two)
                },
                new ControlFormular(new ControlFormularItemInputTextBox("cancel") { Label = "Abbrechen", Value = "Die Abbrechen-Schaltfläche ist aus" })
                {
                    Name = "Formular",
                    Border = new PropertyBorder(true),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two),
                    Padding = new PropertySpacingPadding(PropertySpacing.Space.Two)
                }
            );

        }
    }
}
