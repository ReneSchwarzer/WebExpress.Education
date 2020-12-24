using System;
using System.Collections.Generic;
using System.Linq;
using WebExpress.Attribute;
using WebExpress.Module;
using WebExpress.UI.WebControl;
using WebExpress.Uri;

namespace Education.WebResource
{
    [ID("Image")]
    [Title("page.control.image.name")]
    [Segment("image", "page.control.image.name")]
    [Path("/Control")]
    [Module("edu")]
    [Context("control")]
    public sealed class PageControlImage : PageControlBase
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlImage()
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        public override void Initialization()
        {
            base.Initialization();

            Description = "Das ControlImage stellt ein Bild bereit.";
            Code = "new ControlImage() { Uri = Uri.Root.Append(\"Assets/img/Rocket.png\" }";

            var enums = new List<TypeIcon>((TypeIcon[])Enum.GetValues(typeof(TypeIcon))).Where(x => x != TypeIcon.None);

            AddExample
            (
                new ControlImage()
                {
                    Uri = Uri.Root.Append("Assets/img/Rocket.png")
                }
            );

            // Eigenschaften
            AddProperty
            (
               "Width",
               "Bestimmt die Weite des Bildes.",
               "Width = 50",
               new ControlImage()
               {
                   Uri = Uri.Root.Append("Assets/img/Rocket.png"),
                   Width = 50
               }
            );

            AddProperty
            (
               "Height",
               "Bestimmt die Höhe des Bildes.",
               "Height = 50",
               new ControlImage()
               {
                   Uri = Uri.Root.Append("Assets/img/Rocket.png"),
                   Height = 50
               }
            );

            AddProperty
            (
               "Tooltip",
               "Bestimmt den Tooltiptext.",
               "Tooltip = \"Hallo Welt!\"",
               new ControlImage()
               {
                   Uri = Uri.Root.Append("Assets/img/Rocket.png"),
                   Height = 50,
                   Tooltip = "Hallo Welt!"
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
