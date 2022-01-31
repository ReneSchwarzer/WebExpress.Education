using WebExpress.UI.WebControl;
using WebExpress.WebAttribute;
using WebExpress.WebResource;

namespace Education.WebPage
{
    [ID("FormularItemInputMoveSelector")]
    [Title("education:page.control.formular.item.moveselector.name")]
    [Segment("formularmoveselector", "education:page.control.formular.item.moveselector.name")]
    [Path("/Control")]
    [Module("edu")]
    [Context("control")]
    public sealed class PageControlFormularItemInputMoveSelector : PageControlBase
    {
        /// <summary>
        /// Das Beispielformular
        /// </summary>
        private readonly ControlFormular form = new ControlFormular("form", new ControlFormularItemInputMoveSelector
        (
            "regards",
            new ControlFormularItemInputMoveSelectorItem() { ID = "1", Value = "Hallo" },
            new ControlFormularItemInputMoveSelectorItem() { ID = "2", Value = "Guten Tag" },
            new ControlFormularItemInputMoveSelectorItem() { ID = "3", Value = "Moin" },
            new ControlFormularItemInputMoveSelectorItem() { ID = "4", Value = "Grüß Gott" },
            new ControlFormularItemInputMoveSelectorItem() { ID = "5", Value = "Hi" },
            new ControlFormularItemInputMoveSelectorItem() { ID = "6", Value = "Tag" },
            new ControlFormularItemInputMoveSelectorItem() { ID = "7", Value = "Mahlzeit" },
            new ControlFormularItemInputMoveSelectorItem() { ID = "8", Value = "Freundschaft" }
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
        public PageControlFormularItemInputMoveSelector()
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        /// <param name="context">Der Kontext</param>
        public override void Initialization(IResourceContext context)
        {
            base.Initialization(context);

            Description = "Das ControlFormularItemInputMoveSelector stelt eine Eingabe für Tags bereit.";
            Code = @"new ControlFormular(""form"", new ControlFormularItemInputMoveSelector
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
