using System;
using System.Collections.Generic;
using System.Linq;
using WebExpress.Attribute;
using WebExpress.Module;
using WebExpress.UI.WebControl;
using WebExpress.Uri;

namespace Education.WebResource
{
    [ID("Progress")]
    [Title("page.control.progress.name")]
    [Segment("progress", "page.control.progress.name")]
    [Path("/Control")]
    [Module("edu")]
    [Context("control")]
    public sealed class PageControlProgress : PageControlBase
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlProgress()
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        public override void Initialization()
        {
            base.Initialization();

            Description = "Das ControlProgressBar stellt eine Fortschrittsanzeige bereit.";
            Code = "new ControlProgressBar() { Color = new PropertyColorProgress(TypeColorProgress.Success) }";

            var enums = new List<TypeIcon>((TypeIcon[])Enum.GetValues(typeof(TypeIcon))).Where(x => x != TypeIcon.None);

            AddExample
            (
                new ControlProgressBar()
                {
                    Value = 0,
                    Format = TypeFormatProgress.Colored,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                },
                 new ControlProgressBar()
                 {
                     Value = 25,
                     Format = TypeFormatProgress.Colored,
                     Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                 }
                 ,
                 new ControlProgressBar()
                 {
                     Value = 50,
                     Format = TypeFormatProgress.Colored,
                     Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                 },
                 new ControlProgressBar()
                 {
                     Value = 75,
                     Format = TypeFormatProgress.Colored,
                     Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                 },
                 new ControlProgressBar()
                 {
                     Value = 100,
                     Format = TypeFormatProgress.Colored,
                     Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                 }
            );

            // Eigenschaften
            AddProperty
            (
               "Text",
               "Legt den Text fest, welcher auf dem Fortschrittsbalken angezeigt wird.",
               "Text = \"75%\"",
               new ControlProgressBar()
               {
                   Value = 75,
                   Text = "75%",
                   Format = TypeFormatProgress.Colored,
                   Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
               }
            );

            AddProperty
            (
                "Color",
                "Setzt die Farbe des Fortschrittsbalkens.",
                "Color = new PropertyColorProgress(TypeColorProgress.Secondary)",
                new ControlProgressBar()
                {
                    Value = 10,
                    Text = "Primär",
                    Color = new PropertyColorProgress(TypeColorProgress.Primary),
                    Format = TypeFormatProgress.Colored,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                },
                new ControlProgressBar()
                {
                    Value = 20,
                    Text = "Sekundär",
                    Color = new PropertyColorProgress(TypeColorProgress.Secondary),
                    Format = TypeFormatProgress.Colored,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                },
                new ControlProgressBar()
                {
                    Value = 30,
                    Text = "Info",
                    Color = new PropertyColorProgress(TypeColorProgress.Info),
                    Format = TypeFormatProgress.Colored,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                },
                new ControlProgressBar()
                {
                    Value = 40,
                    Text = "Erfolg",
                    Color = new PropertyColorProgress(TypeColorProgress.Success),
                    Format = TypeFormatProgress.Colored,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                },
                new ControlProgressBar()
                {
                    Value = 50,
                    Text = "Warnung",
                    Color = new PropertyColorProgress(TypeColorProgress.Warning),
                    Format = TypeFormatProgress.Colored,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                },
                new ControlProgressBar()
                {
                    Value = 60,
                    Text = "Fehler",
                    Color = new PropertyColorProgress(TypeColorProgress.Danger),
                    Format = TypeFormatProgress.Colored,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                },
                new ControlProgressBar()
                {
                    Value = 70,
                    Text = "Dunkel",
                    Color = new PropertyColorProgress(TypeColorProgress.Dark),
                    Format = TypeFormatProgress.Colored,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                },
                new ControlProgressBar()
                {
                    Value = 80,
                    Text = "Hell",
                    Color = new PropertyColorProgress(TypeColorProgress.Light),
                    TextColor = new PropertyColorText(TypeColorText.Dark),
                    Format = TypeFormatProgress.Colored,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                },
                new ControlProgressBar()
                {
                    Value = 90,
                    Text = "Weiß",
                    Color = new PropertyColorProgress(TypeColorProgress.White),
                    TextColor = new PropertyColorText(TypeColorText.Dark),
                    Format = TypeFormatProgress.Colored,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                },
                new ControlProgressBar()
                {
                    Value = 100,
                    Text = "Benutzerdefiniert",
                    Color = new PropertyColorProgress("gold"),
                    TextColor = new PropertyColorText("red"),
                    Format = TypeFormatProgress.Colored,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                }
            );

            AddProperty
            (
                "Format",
                "Setzt das Format des Fortschrittsbalkens",
                "Format = TypeFormatProgress.Colored",
                new ControlProgressBar()
                {
                    Value = 25,
                    Text = "Primär",
                    Color = new PropertyColorProgress(TypeColorProgress.Primary),
                    Format = TypeFormatProgress.Default,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                },
                new ControlProgressBar()
                {
                    Value = 50,
                    Text = "Sekundär",
                    Color = new PropertyColorProgress(TypeColorProgress.Secondary),
                    Format = TypeFormatProgress.Colored,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                },
                 new ControlProgressBar()
                 {
                     Value = 75,
                     Text = "Info",
                     Color = new PropertyColorProgress(TypeColorProgress.Info),
                     Format = TypeFormatProgress.Striped,
                     Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                 },
                 new ControlProgressBar()
                 {
                     Value = 100,
                     Text = "Erfolg",
                     Color = new PropertyColorProgress(TypeColorProgress.Success),
                     Format = TypeFormatProgress.Animated,
                     Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                 }
            );

            AddProperty
            (
                "Size",
                "Bestimmt die Höhe des Fortschrittbalkens.",
                "Size = TypeSizeProgress.Small",
                new ControlProgressBar()
                {
                    Value = 25,
                    Text = "ExtraSmall",
                    Size = TypeSizeProgress.ExtraSmall,
                    Color = new PropertyColorProgress(TypeColorProgress.Primary),
                    Format = TypeFormatProgress.Striped,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                },
                new ControlProgressBar()
                {
                    Value = 50,
                    Text = "Small",
                    Size = TypeSizeProgress.Small,
                    Color = new PropertyColorProgress(TypeColorProgress.Secondary),
                    Format = TypeFormatProgress.Striped,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                },
                 new ControlProgressBar()
                 {
                     Value = 75,
                     Text = "Standard",
                     Size = TypeSizeProgress.Default,
                     Color = new PropertyColorProgress(TypeColorProgress.Info),
                     Format = TypeFormatProgress.Striped,
                     Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                 },
                 new ControlProgressBar()
                 {
                     Value = 75,
                     Text = "Large",
                     Size = TypeSizeProgress.Large,
                     Color = new PropertyColorProgress(TypeColorProgress.Success),
                     Format = TypeFormatProgress.Striped,
                     Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                 },
                 new ControlProgressBar()
                 {
                     Value = 100,
                     Text = "ExtraLarge",
                     Size = TypeSizeProgress.ExtraLarge,
                     Color = new PropertyColorProgress(TypeColorProgress.Warning),
                     Format = TypeFormatProgress.Striped,
                     Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                 }
            );

            AddProperty
            (
                "TextColor",
                "Legt die Textfarbe fest.",
                "TextColor = new PropertyColorText(TypeColorText.Warning)",
                new ControlProgressBar()
                {
                    Value = 50,
                    Text = "Warnung",
                    TextColor = new PropertyColorText(TypeColorText.Warning),
                    Color = new PropertyColorProgress(TypeColorProgress.Secondary),
                    Format = TypeFormatProgress.Striped,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                }
            );

            AddProperty
            (
                "BackgroundColor",
                "Legt die Hintergrundfarbe fest.",
                "BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning)",
                new ControlProgressBar()
                {
                    Value = 50,
                    Text = "Warnung",
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning),
                    Color = new PropertyColorProgress(TypeColorProgress.Secondary),
                    Format = TypeFormatProgress.Striped,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
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
