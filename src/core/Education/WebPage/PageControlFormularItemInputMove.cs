using WebExpress.UI.WebControl;
using WebExpress.WebAttribute;
using WebExpress.WebResource;

namespace Education.WebPage
{
    [Id("FormularItemInputMoveSelector")]
    [Title("education:page.control.formular.item.selectionmove.name")]
    [Segment("formularmoveselector", "education:page.control.formular.item.selectionmove.name")]
    [Path("/Control")]
    [Module("edu")]
    [Context("control")]
    public sealed class PageControlFormularItemInputMove : PageControlBase
    {
        /// <summary>
        /// Das Beispielformular
        /// </summary>
        private readonly ControlFormular form = new ControlFormular("form", new ControlFormularItemInputMove
        (
            "regards",
            new ControlFormularItemInputSelectionItem() { ID = "1", Label = "Hallo", Image = "../assets/img/flag_ca.svg", Icon = "fas fa-flag" },
            new ControlFormularItemInputSelectionItem() { ID = "2", Label = "Guten Tag", Image = "../assets/img/flag_de.svg" },
            new ControlFormularItemInputSelectionItem() { ID = "3", Label = "Moin", Image = "../assets/img/flag_it.svg" },
            new ControlFormularItemInputSelectionItem() { ID = "4", Label = "Grüß Gott", Image = "../assets/img/flag_ru.svg" },
            new ControlFormularItemInputSelectionItem() { ID = "5", Label = "Hi", Image = "../assets/img/flag_us.svg" },
            new ControlFormularItemInputSelectionItem() { ID = "6", Label = "Tag", Image = "../assets/img/flag_dd.svg" },
            new ControlFormularItemInputSelectionItem() { ID = "7", Label = "Mahlzeit", Image = "../assets/img/flag_cn.svg" },
            new ControlFormularItemInputSelectionItem() { ID = "8", Label = "Freundschaft", Image = "../assets/img/flag_kp.svg" }
        )
        {
            Label = "Grüße",
            Value = "1;5",
            Icon = new PropertyIcon(TypeIcon.Font),
            Help = " Das ist der zugehörige Hilfetext."
        });

        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlFormularItemInputMove()
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        /// <param name="context">Der Kontext</param>
        public override void Initialization(IResourceContext context)
        {
            base.Initialization(context);

            Description = "Das ControlFormularItemInputSelectionMove stelt eine Eingabe für Tags bereit.";
            Code = @"new ControlFormular(""form"", new ControlFormularItemInputSelectionMove
            (
                ""regards"",
                new ControlFormularItemInputMoveSelectorItem() { ID = ""1"", Value = ""Hallo"" },
                new ControlFormularItemInputMoveSelectorItem() { ID = ""2"", Value = ""Guten Tag"" },
                new ControlFormularItemInputMoveSelectorItem() { ID = ""3"", Value = ""Moin"" },
                new ControlFormularItemInputMoveSelectorItem() { ID = ""4"", Value = ""Grüß Gott"" },
                new ControlFormularItemInputMoveSelectorItem() { ID = ""5"", Value = ""Hi"" },
                new ControlFormularItemInputMoveSelectorItem() { ID = ""6"", Value = ""Tag"" },
                new ControlFormularItemInputMoveSelectorItem() { ID = ""7"", Value = ""Mahlzeit"" },
                new ControlFormularItemInputMoveSelectorItem() { ID = ""8"", Value = ""Freundschaft"" }
            )
            {
                Label = ""Grüße"", 
                Value = ""1;5"", 
                Icon = new PropertyIcon(TypeIcon.Font), 
                Help = "" Das ist der zugehörige Hilfetext.""
            }); ";

            AddExample(form);

            // Eigenschaften
        }
    }
}
