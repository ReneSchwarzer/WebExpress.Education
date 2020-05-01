using System;
using WebExpress.UI.Controls;

namespace Education.Pages
{
    public class PageControlText : PageControlBase
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlText()
            : base("ControlText")
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        public override void Init()
        {
            base.Init();

            var text = "WebExpress ist ein leichtgewichtiger Webserver, welcher in C# geschrieben und für verschiedene Palttformen verfügbar ist.";

            Description = "Das ControlText repräsentiert ein Text.";
            Code = "new ControlText(Page) { Text = \"Hallo Welt!\" }";

            AddExample
            (
                new ControlText(this)
                {
                    Text = text
                }
            );

            // Eigenschaften
            AddProperty
            (
                "Format",
                "Legt das Format des Textet fest.",
                "Format = TypesTextFormat.Paragraph",
                new ControlText(this) { Text = "Standard", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText(this)
                {
                    Text = text
                },
                new ControlText(this) { Text = "H1", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText(this)
                {
                    Text = "Überschrift Ebene 1",
                    Format = TypeTextFormat.H1
                },
                new ControlText(this) { Text = "H2", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText(this)
                {
                    Text = "Überschrift Ebene 2",
                    Format = TypeTextFormat.H2
                },
                new ControlText(this) { Text = "H3", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText(this)
                {
                    Text = "Überschrift Ebene 3",
                    Format = TypeTextFormat.H3
                },
                new ControlText(this) { Text = "H4", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText(this)
                {
                    Text = "Überschrift Ebene 4",
                    Format = TypeTextFormat.H4
                },
                new ControlText(this) { Text = "H5", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText(this)
                {
                    Text = "Überschrift Ebene 5",
                    Format = TypeTextFormat.H5
                },
                new ControlText(this) { Text = "H6", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText(this)
                {
                    Text = "Überschrift Ebene 6",
                    Format = TypeTextFormat.H6
                },
                new ControlText(this) { Text = "Paragraph", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.One), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText(this)
                {
                    Text = text,
                    Format = TypeTextFormat.Paragraph
                },
                new ControlText(this) { Text = "Bold", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText(this)
                {
                    Text = text,
                    Format = TypeTextFormat.Bold
                },
                new ControlText(this) { Text = "Italic", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText(this)
                {
                    Text = text,
                    Format = TypeTextFormat.Italic
                },
                new ControlText(this) { Text = "Underline", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText(this)
                {
                    Text = text,
                    Format = TypeTextFormat.Underline
                },
                new ControlText(this) { Text = "StruckOut", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText(this)
                {
                    Text = text,
                    Format = TypeTextFormat.StruckOut
                },
                new ControlText(this) { Text = "Cite", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText(this)
                {
                    Text = text,
                    Format = TypeTextFormat.Cite
                },
                new ControlText(this) { Text = "Small", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText(this)
                {
                    Text = text,
                    Format = TypeTextFormat.Small
                },
                new ControlText(this) { Text = "Strong", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText(this)
                {
                    Text = text,
                    Format = TypeTextFormat.Strong
                },
                new ControlText(this) { Text = "Code", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText(this)
                {
                    Text = "10 PRINT \"HALLO WELT!\"<br>20 GOTO 10",
                    Format = TypeTextFormat.Code
                },
                new ControlText(this) { Text = "Output", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText(this)
                {
                    Text = "C:\\DOS\\",
                    Format = TypeTextFormat.Output
                },
                new ControlText(this) { Text = "Output", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText(this)
                {
                    Text = DateTime.Now.ToString(),
                    Format = TypeTextFormat.Time
                },
                new ControlText(this) { Text = "Mark", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText(this)
                {
                    Text = text,
                    Format = TypeTextFormat.Mark
                },
                new ControlText(this) { Text = "Highlight", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText(this)
                {
                    Text = text,
                    Format = TypeTextFormat.Highlight
                },
                new ControlText(this) { Text = "Definition", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText(this)
                {
                    Text = text,
                    Format = TypeTextFormat.Definition
                },
                new ControlText(this) { Text = "Abbreviation", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText(this)
                {
                    Text = text,
                    Format = TypeTextFormat.Abbreviation
                },
                new ControlText(this) { Text = "Blockquote", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText(this)
                {
                    Text = text,
                    Format = TypeTextFormat.Blockquote
                },
                new ControlText(this) { Text = "Figcaption", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText(this)
                {
                    Text = text,
                    Format = TypeTextFormat.Figcaption
                },
                new ControlText(this) { Text = "Preformatted", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText(this)
                {
                    Text = text,
                    Format = TypeTextFormat.Preformatted
                }
            );

            AddProperty
            (
                "TextColor",
                "Legt das Farbe des Textet fest.",
                "TextColor = new PropertyColorText(TypeColorText.Primary)",
                new ControlText(this) { Text = "Standard", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText(this)
                {
                    Text = text,
                    TextColor = new PropertyColorText(TypeColorText.Default)
                },
                new ControlText(this) { Text = "Primär", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText(this)
                {
                    Text = text,
                    TextColor = new PropertyColorText(TypeColorText.Primary)
                },
                new ControlText(this) { Text = "Info", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText(this)
                {
                    Text = text,
                    TextColor = new PropertyColorText(TypeColorText.Info)
                },
                new ControlText(this) { Text = "Erfolg", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText(this)
                {
                    Text = text,
                    TextColor = new PropertyColorText(TypeColorText.Success)
                },
                new ControlText(this) { Text = "Warnung", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText(this)
                {
                    Text = text,
                    TextColor = new PropertyColorText(TypeColorText.Warning)
                },
                new ControlText(this) { Text = "Fehler", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText(this)
                {
                    Text = text,
                    TextColor = new PropertyColorText(TypeColorText.Danger)
                },
                new ControlText(this) { Text = "Dunkel", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText(this)
                {
                    Text = text,
                    TextColor = new PropertyColorText(TypeColorText.Dark)
                },
                new ControlText(this) { Text = "Hell", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText(this)
                {
                    Text = text,
                    TextColor = new PropertyColorText(TypeColorText.Light)
                },
                new ControlText(this) { Text = "Weiß", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText(this)
                {
                    Text = text,
                    TextColor = new PropertyColorText(TypeColorText.White)
                },
                new ControlText(this) { Text = "Benutzerdefiniert", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText(this)
                {
                    Text = text,
                    TextColor = new PropertyColorText("red")
                }
             );

            AddProperty
            (
                "Size",
                "Legt die Textgröße fest.",
                "Size = new PropertySizeText(TypeSizeText.Small)",
                new ControlText(this) { Text = "ExtraSmall", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText(this)
                {
                    Text = text,
                    Size = new PropertySizeText(TypeSizeText.ExtraSmall)
                },
                new ControlText(this) { Text = "Small", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText(this)
                {
                    Text = text,
                    Size = new PropertySizeText(TypeSizeText.Small)
                },
                new ControlText(this) { Text = "Standard", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText(this)
                {
                    Text = text,
                    Size = new PropertySizeText(TypeSizeText.Default)
                },
                new ControlText(this) { Text = "Large", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText(this)
                {
                    Text = text,
                    Size = new PropertySizeText(TypeSizeText.Large)
                },
                new ControlText(this) { Text = "ExtraLarge", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText(this)
                {
                    Text = text,
                    Size = new PropertySizeText(TypeSizeText.ExtraLarge)
                },
                new ControlText(this) { Text = "Benutzerdefiniert", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText(this)
                {
                    Text = text,
                    Size = new PropertySizeText(3.1f)
                }
            );

            AddProperty
            (
                "Title",
                "Legt einen Tooltip fest.",
                "Title = \"Hallo Welt!\"",
                new ControlText(this) { Text = "ExtraSmall", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText(this)
                {
                    Text = text,
                    Title = "Hallo Welt!"
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
