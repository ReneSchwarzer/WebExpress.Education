using WebExpress.Attribute;
using WebExpress.UI.WebControl;

namespace Education.WebResource
{
    [ID("FormularItemInputMoveSelector")]
    [Title("page.control.formular.item.moveselector.name")]
    [Segment("formularmoveselector", "page.control.formular.item.moveselector.name")]
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
        public override void Initialization()
        {
            base.Initialization();

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
