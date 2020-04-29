using System;
using System.Collections.Generic;
using System.Linq;
using WebExpress.UI.Controls;

namespace Education.Pages
{
    public class PageControlProgress : PageControlBase
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlProgress()
            : base("ControlProgressBar")
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        public override void Init()
        {
            base.Init();

            Description = "Das ControlProgressBar stellt eine Fortschrittsanzeige bereit.";
            Code = "new ControlProgressBar(Page) { Color = new PropertyColorProgress(TypeColorProgress.Success) }";

            var enums = new List<TypeIcon>((TypeIcon[])Enum.GetValues(typeof(TypeIcon))).Where(x => x != TypeIcon.None && x != TypeIcon.UserIcon);

            AddExample
            (
                new ControlProgressBar(this)
                {
                    Value = 0,
                    Format = TypeFormatProgress.Colored,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                },
                 new ControlProgressBar(this)
                 {
                     Value = 25,
                     Format = TypeFormatProgress.Colored,
                     Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                 }
                 ,
                 new ControlProgressBar(this)
                 {
                     Value = 50,
                     Format = TypeFormatProgress.Colored,
                     Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                 },
                 new ControlProgressBar(this)
                 {
                     Value = 75,
                     Format = TypeFormatProgress.Colored,
                     Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                 },
                 new ControlProgressBar(this)
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
               new ControlProgressBar(this)
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
                new ControlProgressBar(this)
                {
                    Value = 10,
                    Text = "Primär",
                    Color = new PropertyColorProgress(TypeColorProgress.Primary),
                    Format = TypeFormatProgress.Colored,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                },
                new ControlProgressBar(this)
                {
                    Value = 20,
                    Text = "Sekundär",
                    Color = new PropertyColorProgress(TypeColorProgress.Secondary),
                    Format = TypeFormatProgress.Colored,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                }
                 ,
                 new ControlProgressBar(this)
                 {
                     Value = 30,
                     Text = "Info",
                     Color = new PropertyColorProgress(TypeColorProgress.Info),
                     Format = TypeFormatProgress.Colored,
                     Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                 },
                 new ControlProgressBar(this)
                 {
                     Value = 40,
                     Text = "Erfolg",
                     Color = new PropertyColorProgress(TypeColorProgress.Success),
                     Format = TypeFormatProgress.Colored,
                     Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                 },
                 new ControlProgressBar(this)
                 {
                     Value = 50,
                     Text = "Warnung",
                     Color = new PropertyColorProgress(TypeColorProgress.Warning),
                     Format = TypeFormatProgress.Colored,
                     Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                 },
                 new ControlProgressBar(this)
                 {
                     Value = 60,
                     Text = "Fehler",
                     Color = new PropertyColorProgress(TypeColorProgress.Danger),
                     Format = TypeFormatProgress.Colored,
                     Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                 },
                 new ControlProgressBar(this)
                 {
                     Value = 70,
                     Text = "Dunkel",
                     Color = new PropertyColorProgress(TypeColorProgress.Dark),
                     Format = TypeFormatProgress.Colored,
                     Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                 },
                 new ControlProgressBar(this)
                 {
                     Value = 80,
                     Text = "Hell",
                     Color = new PropertyColorProgress(TypeColorProgress.Light),
                     TextColor = new PropertyColorText(TypeColorText.Dark),
                     Format = TypeFormatProgress.Colored,
                     Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                 },
                 new ControlProgressBar(this)
                 {
                     Value = 90,
                     Text = "Weiß",
                     Color = new PropertyColorProgress(TypeColorProgress.White),
                     TextColor = new PropertyColorText(TypeColorText.Dark),
                     Format = TypeFormatProgress.Colored,
                     Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                 },
                 new ControlProgressBar(this)
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
                new ControlProgressBar(this)
                {
                    Value = 25,
                    Text = "Primär",
                    Color = new PropertyColorProgress(TypeColorProgress.Primary),
                    Format = TypeFormatProgress.Default,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                },
                new ControlProgressBar(this)
                {
                    Value = 50,
                    Text = "Sekundär",
                    Color = new PropertyColorProgress(TypeColorProgress.Secondary),
                    Format = TypeFormatProgress.Colored,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                },
                 new ControlProgressBar(this)
                 {
                     Value = 75,
                     Text = "Info",
                     Color = new PropertyColorProgress(TypeColorProgress.Info),
                     Format = TypeFormatProgress.Striped,
                     Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                 },
                 new ControlProgressBar(this)
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
                new ControlProgressBar(this)
                {
                    Value = 25,
                    Text = "ExtraSmall",
                    Size = TypesSizeProgress.ExtraSmall,
                    Color = new PropertyColorProgress(TypeColorProgress.Primary),
                    Format = TypeFormatProgress.Striped,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                },
                new ControlProgressBar(this)
                {
                    Value = 50,
                    Text = "Small",
                    Size = TypesSizeProgress.Small,
                    Color = new PropertyColorProgress(TypeColorProgress.Secondary),
                    Format = TypeFormatProgress.Striped,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                },
                 new ControlProgressBar(this)
                 {
                     Value = 75,
                     Text = "Standard",
                     Size = TypesSizeProgress.Default,
                     Color = new PropertyColorProgress(TypeColorProgress.Info),
                     Format = TypeFormatProgress.Striped,
                     Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                 },
                 new ControlProgressBar(this)
                 {
                     Value = 75,
                     Text = "Large",
                     Size = TypesSizeProgress.Large,
                     Color = new PropertyColorProgress(TypeColorProgress.Success),
                     Format = TypeFormatProgress.Striped,
                     Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                 },
                 new ControlProgressBar(this)
                 {
                     Value = 100,
                     Text = "ExtraLarge",
                     Size = TypesSizeProgress.ExtraLarge,
                     Color = new PropertyColorProgress(TypeColorProgress.Warning),
                     Format = TypeFormatProgress.Striped,
                     Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Three)
                 }
            );

            AddProperty
            (
                "TextColor",
                new ControlProgressBar(this)
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
                new ControlProgressBar(this)
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
