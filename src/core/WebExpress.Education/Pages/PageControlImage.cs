using System;
using System.Collections.Generic;
using System.Linq;
using WebExpress.UI.Controls;

namespace Education.Pages
{
    public class PageControlImage : PageControlBase
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlImage()
            : base("ControlImage")
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        public override void Init()
        {
            base.Init();

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
