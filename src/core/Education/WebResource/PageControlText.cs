using System;
using WebExpress.Attribute;
using WebExpress.Module;
using WebExpress.UI.WebControl;
using WebExpress.Uri;

namespace Education.WebResource
{
    [ID("Text")]
    [Title("page.control.text.name")]
    [Segment("text", "page.control.text.name")]
    [Path("/Control")]
    [Module("edu")]
    [Context("control")]
    public sealed class PageControlText : PageControlBase
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlText()
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        public override void Initialization()
        {
            base.Initialization();

            var text = "WebExpress ist ein leichtgewichtiger Webserver, welcher in C# geschrieben und für verschiedene Palttformen verfügbar ist.";

            Description = "Das ControlText repräsentiert ein Text.";
            Code = "new ControlText() { Text = \"Hallo Welt!\" }";

            AddExample
            (
                new ControlText()
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
                new ControlText() { Text = "Standard", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText()
                {
                    Text = text
                },
                new ControlText() { Text = "H1", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText()
                {
                    Text = "Überschrift Ebene 1",
                    Format = TypeFormatText.H1
                },
                new ControlText() { Text = "H2", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText()
                {
                    Text = "Überschrift Ebene 2",
                    Format = TypeFormatText.H2
                },
                new ControlText() { Text = "H3", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText()
                {
                    Text = "Überschrift Ebene 3",
                    Format = TypeFormatText.H3
                },
                new ControlText() { Text = "H4", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText()
                {
                    Text = "Überschrift Ebene 4",
                    Format = TypeFormatText.H4
                },
                new ControlText() { Text = "H5", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText()
                {
                    Text = "Überschrift Ebene 5",
                    Format = TypeFormatText.H5
                },
                new ControlText() { Text = "H6", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText()
                {
                    Text = "Überschrift Ebene 6",
                    Format = TypeFormatText.H6
                },
                new ControlText() { Text = "Paragraph", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.One), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText()
                {
                    Text = text,
                    Format = TypeFormatText.Paragraph
                },
                new ControlText() { Text = "Bold", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText()
                {
                    Text = text,
                    Format = TypeFormatText.Bold
                },
                new ControlText() { Text = "Italic", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText()
                {
                    Text = text,
                    Format = TypeFormatText.Italic
                },
                new ControlText() { Text = "Underline", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText()
                {
                    Text = text,
                    Format = TypeFormatText.Underline
                },
                new ControlText() { Text = "StruckOut", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText()
                {
                    Text = text,
                    Format = TypeFormatText.StruckOut
                },
                new ControlText() { Text = "Cite", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText()
                {
                    Text = text,
                    Format = TypeFormatText.Cite
                },
                new ControlText() { Text = "Small", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText()
                {
                    Text = text,
                    Format = TypeFormatText.Small
                },
                new ControlText() { Text = "Strong", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText()
                {
                    Text = text,
                    Format = TypeFormatText.Strong
                },
                new ControlText() { Text = "Code", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText()
                {
                    Text = "10 PRINT \"HALLO WELT!\"<br>20 GOTO 10",
                    Format = TypeFormatText.Code
                },
                new ControlText() { Text = "Output", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText()
                {
                    Text = "C:\\DOS\\",
                    Format = TypeFormatText.Output
                },
                new ControlText() { Text = "Output", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText()
                {
                    Text = DateTime.Now.ToString(),
                    Format = TypeFormatText.Time
                },
                new ControlText() { Text = "Mark", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText()
                {
                    Text = text,
                    Format = TypeFormatText.Mark
                },
                new ControlText() { Text = "Highlight", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText()
                {
                    Text = text,
                    Format = TypeFormatText.Highlight
                },
                new ControlText() { Text = "Definition", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText()
                {
                    Text = text,
                    Format = TypeFormatText.Definition
                },
                new ControlText() { Text = "Abbreviation", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText()
                {
                    Text = text,
                    Format = TypeFormatText.Abbreviation
                },
                new ControlText() { Text = "Blockquote", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText()
                {
                    Text = text,
                    Format = TypeFormatText.Blockquote
                },
                new ControlText() { Text = "Figcaption", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText()
                {
                    Text = text,
                    Format = TypeFormatText.Figcaption
                },
                new ControlText() { Text = "Preformatted", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText()
                {
                    Text = text,
                    Format = TypeFormatText.Preformatted
                }
            );

            AddProperty
            (
                "TextColor",
                "Legt die Textfarbe fest.",
                "TextColor = new PropertyColorText(TypeColorText.Primary)",
                new ControlText() { Text = "Standard", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText()
                {
                    Text = text,
                    TextColor = new PropertyColorText(TypeColorText.Default)
                },
                new ControlText() { Text = "Primär", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText()
                {
                    Text = text,
                    TextColor = new PropertyColorText(TypeColorText.Primary)
                },
                new ControlText() { Text = "Info", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText()
                {
                    Text = text,
                    TextColor = new PropertyColorText(TypeColorText.Info)
                },
                new ControlText() { Text = "Erfolg", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText()
                {
                    Text = text,
                    TextColor = new PropertyColorText(TypeColorText.Success)
                },
                new ControlText() { Text = "Warnung", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText()
                {
                    Text = text,
                    TextColor = new PropertyColorText(TypeColorText.Warning)
                },
                new ControlText() { Text = "Fehler", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText()
                {
                    Text = text,
                    TextColor = new PropertyColorText(TypeColorText.Danger)
                },
                new ControlText() { Text = "Dunkel", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText()
                {
                    Text = text,
                    TextColor = new PropertyColorText(TypeColorText.Dark)
                },
                new ControlText() { Text = "Hell", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText()
                {
                    Text = text,
                    TextColor = new PropertyColorText(TypeColorText.Light)
                },
                new ControlText() { Text = "Weiß", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText()
                {
                    Text = text,
                    TextColor = new PropertyColorText(TypeColorText.White)
                },
                new ControlText() { Text = "Benutzerdefiniert", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText()
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
                new ControlText() { Text = "ExtraSmall", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText()
                {
                    Text = text,
                    Size = new PropertySizeText(TypeSizeText.ExtraSmall)
                },
                new ControlText() { Text = "Small", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText()
                {
                    Text = text,
                    Size = new PropertySizeText(TypeSizeText.Small)
                },
                new ControlText() { Text = "Standard", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText()
                {
                    Text = text,
                    Size = new PropertySizeText(TypeSizeText.Default)
                },
                new ControlText() { Text = "Large", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText()
                {
                    Text = text,
                    Size = new PropertySizeText(TypeSizeText.Large)
                },
                new ControlText() { Text = "ExtraLarge", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText()
                {
                    Text = text,
                    Size = new PropertySizeText(TypeSizeText.ExtraLarge)
                },
                new ControlText() { Text = "Benutzerdefiniert", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText()
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
                new ControlText() { Text = "Title", Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two), TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlText()
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
