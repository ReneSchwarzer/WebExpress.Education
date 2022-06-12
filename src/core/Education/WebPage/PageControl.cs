using WebExpress.UI.WebControl;
using WebExpress.WebApp.WebPage;
using WebExpress.WebAttribute;
using WebExpress.WebResource;

namespace Education.WebPage
{
    [Id("Control")]
    [Title("education:page.control.name")]
    [Segment("controls", "education:page.control.name")]
    [Path("/")]
    [Module("edu")]
    [Context("control")]
    public sealed class PageControl : PageControlBase
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControl()
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        /// <param name="context">Der Kontext</param>
        public override void Initialization(IResourceContext context)
        {
            base.Initialization(context);

            Description = "Steuerelemente sind komplexe HTML-Objekte. Ein Steuerelement vom Typ Control kann nicht erzeugt werden, da dieses abstract sind. Alle nachfolgenden Eigenschaften sind auf alle Steuerlementtypen anwendbar.";
            Code = "";

            AddExample(new ControlText()
            {
                Text = "Dies ist ein Beispiel",
                BackgroundColor = new PropertyColorBackgroundAlert(TypeColorBackground.Info)
            });

            AddProperty
            (
                "TextColor",
                "Legt die Textfarbe fest.",
                "TextColor = new PropertyColorText(TypeColorText.Primary)",
                new ControlText()
                {
                    Text = "Standard-Textfarbe",
                    TextColor = new PropertyColorText(TypeColorText.Default),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlText()
                {
                    Text = "Primäre-Textfarbe",
                    TextColor = new PropertyColorText(TypeColorText.Primary),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlText()
                {
                    Text = "Info-Textfarbe",
                    TextColor = new PropertyColorText(TypeColorText.Info),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlText()
                {
                    Text = "Erfolgs-Textfarbe",
                    TextColor = new PropertyColorText(TypeColorText.Success),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlText()
                {
                    Text = "Warnungs-Textfarbe",
                    TextColor = new PropertyColorText(TypeColorText.Warning),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlText()
                {
                    Text = "Fehler-Textfarbe",
                    TextColor = new PropertyColorText(TypeColorText.Danger),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlText()
                {
                    Text = "Dunkle Textfarbe",
                    TextColor = new PropertyColorText(TypeColorText.Dark),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlText()
                {
                    Text = "Helle Textfarbe",
                    TextColor = new PropertyColorText(TypeColorText.Light),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlText()
                {
                    Text = "Weiße Textfarbe",
                    TextColor = new PropertyColorText(TypeColorText.White),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlText()
                {
                    Text = "Benutzerdefinierte Textfarbe",
                    TextColor = new PropertyColorText("gold"),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                }
             );

            AddProperty
            (
                "BackgroundColor",
                "Setzt die Hintergrundfarbe des Steuerelementes.",
                "BackgroundColor = new PropertyColorBackground(TypeColorBackground.Primary)",
                new ControlText()
                {
                    Text = "Standard-Hintergrund",
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlText()
                {
                    Text = "Primär-Hintergrund",
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Primary),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlText()
                {
                    Text = "Sekundär-Hintergrund",
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Secondary),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlText()
                {
                    Text = "Info-Hintergrund",
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Info),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlText()
                {
                    Text = "Erfolgs-Hintergrund",
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Success),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlText()
                {
                    Text = "Warnungs-Hintergrund",
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlText()
                {
                    Text = "Fehler-Hintergrund",
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Danger),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlText()
                {
                    Text = "Dunkler Hintergrund",
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Dark),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlText()
                {
                    Text = "Heller Hintergrund",
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlText()
                {
                    Text = "Weißer Hintergrund",
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.White),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlText()
                {
                    Text = "Transparenter Hintergrund",
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Transparent),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlText()
                {
                    Text = "Benutzerdefinierter Hintergrund",
                    TextColor = new PropertyColorText("red"),
                    BackgroundColor = new PropertyColorBackground("gold"),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                }
            );

            AddProperty
            (
                "BorderColor",
                "Setzt die Rahmenfarbe des Steuerelementes.",
                "BorderColor = new PropertyColorBorder(TypeColorBorder.Primary)",
                new ControlText()
                {
                    Text = "Standard-Rahmenfarbe",
                    Border = new PropertyBorder(true),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlText()
                {
                    Text = "Primär-Rahmenfarbe",
                    BorderColor = new PropertyColorBorder(TypeColorBorder.Primary),
                    Border = new PropertyBorder(true),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlText()
                {
                    Text = "Sekundär-Rahmenfarbe",
                    BorderColor = new PropertyColorBorder(TypeColorBorder.Secondary),
                    Border = new PropertyBorder(true),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlText()
                {
                    Text = "Info-Rahmenfarbe",
                    BorderColor = new PropertyColorBorder(TypeColorBorder.Info),
                    Border = new PropertyBorder(true),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlText()
                {
                    Text = "Erfolgs-Rahmenfarbe",
                    BorderColor = new PropertyColorBorder(TypeColorBorder.Success),
                    Border = new PropertyBorder(true),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlText()
                {
                    Text = "Warnungs-Rahmenfarbe",
                    BorderColor = new PropertyColorBorder(TypeColorBorder.Warning),
                    Border = new PropertyBorder(true),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlText()
                {
                    Text = "Fehler-Rahmenfarbe",
                    BorderColor = new PropertyColorBorder(TypeColorBorder.Danger),
                    Border = new PropertyBorder(true),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlText()
                {
                    Text = "Dunkle Rahmenfarbe",
                    BorderColor = new PropertyColorBorder(TypeColorBorder.Dark),
                    Border = new PropertyBorder(true),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlText()
                {
                    Text = "Helle Rahmenfarbe",
                    BorderColor = new PropertyColorBorder(TypeColorBorder.Light),
                    Border = new PropertyBorder(true),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlText()
                {
                    Text = "Weiße Rahmenfarbe",
                    BorderColor = new PropertyColorBorder(TypeColorBorder.White),
                    Border = new PropertyBorder(true),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlText()
                {
                    Text = "Transparente Rahmenfarbe",
                    BorderColor = new PropertyColorBorder(TypeColorBorder.Transparent),
                    Border = new PropertyBorder(true),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                },
                new ControlText()
                {
                    Text = "Benutzerdefinierte Rahmenfarbe",
                    TextColor = new PropertyColorText("red"),
                    Border = new PropertyBorder(true),
                    BorderColor = new PropertyColorBorder("gold"),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None, PropertySpacing.Space.Two)
                }
            );

            AddProperty
            (
                "Padding",
                "Füllt das Steuerelementes auf.",
                "Padding = new PropertySpacingPadding(PropertySpacing.Space.Two)",
                new ControlText()
                {
                    Text = "Ohne Auffüllung",
                    Padding = new PropertySpacingPadding(PropertySpacing.Space.None),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning),
                    Border = new PropertyBorder(true)
                },
                new ControlText()
                {
                    Text = "Mit Auffüllung Auto",
                    Padding = new PropertySpacingPadding(PropertySpacing.Space.Auto),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Info),
                    Border = new PropertyBorder(true)
                },
                new ControlText()
                {
                    Text = "Mit Auffüllung One",
                    Padding = new PropertySpacingPadding(PropertySpacing.Space.One),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning),
                    Border = new PropertyBorder(true)
                },
                new ControlText()
                {
                    Text = "Mit Auffüllung Two",
                    Padding = new PropertySpacingPadding(PropertySpacing.Space.Two),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Info),
                    Border = new PropertyBorder(true)
                },
                new ControlText()
                {
                    Text = "Mit Auffüllung Three",
                    Padding = new PropertySpacingPadding(PropertySpacing.Space.Three),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning),
                    Border = new PropertyBorder(true)
                },
                new ControlText()
                {
                    Text = "Mit Auffüllung Four",
                    Padding = new PropertySpacingPadding(PropertySpacing.Space.Four),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Info),
                    Border = new PropertyBorder(true)
                },
                new ControlText()
                {
                    Text = "Mit Auffüllung Five",
                    Padding = new PropertySpacingPadding(PropertySpacing.Space.Five),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning),
                    Border = new PropertyBorder(true)
                }
            );

            AddProperty
            (
                "Margin",
                "Richtet einen Abstand zu dem Steuerelementes ein.",
                "Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)",
                new ControlText()
                {
                    Text = "Ohne Abstand",
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.None),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning),
                    Border = new PropertyBorder(true)
                },
                new ControlText()
                {
                    Text = "Mit Abstand Auto",
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Auto),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Info),
                    Border = new PropertyBorder(true)
                },
                new ControlText()
                {
                    Text = "Mit Abstand One",
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.One),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning),
                    Border = new PropertyBorder(true)
                },
                new ControlText()
                {
                    Text = "Mit Abstand Two",
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Info),
                    Border = new PropertyBorder(true)
                },
                new ControlText()
                {
                    Text = "Mit Abstand Three",
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Three),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning),
                    Border = new PropertyBorder(true)
                },
                new ControlText()
                {
                    Text = "Mit Abstand Four",
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Four),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Info),
                    Border = new PropertyBorder(true)
                },
                new ControlText()
                {
                    Text = "Mit Abstand Five",
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Five),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning),
                    Border = new PropertyBorder(true)
                }
            );

            AddProperty
            (
                "Border",
                "Bestimmt ob der Rahmen angezeigt werden soll.",
                "Border = new PropertyBorder(false)",
                new ControlText()
                {
                    Text = "Ohne Rahmen",
                    Border = new PropertyBorder(false),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Null, PropertySpacing.Space.Two),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.White)
                },
                new ControlText()
                {
                    Text = "Mit Rahmen",
                    Border = new PropertyBorder(true),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Null, PropertySpacing.Space.Two),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.White)
                },
                new ControlText()
                {
                    Text = "Mit Rahmen auf linker und rechter Seite",
                    Border = new PropertyBorder(true, false),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Null, PropertySpacing.Space.Two),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.White)
                },
                new ControlText()
                {
                    Text = "Mit Rahmen Oben und Unten",
                    Border = new PropertyBorder(false, true),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Null, PropertySpacing.Space.Two),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.White)
                }
                ,
                new ControlText()
                {
                    Text = "Mit Rahmen auf der linken Seite",
                    Border = new PropertyBorder(true, false, false, false),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Null, PropertySpacing.Space.Two)
                }
            );

            AddProperty
            (
                "HorizontalAlignment",
                "Bestimmt die horizontale Anordnung.",
                "HorizontalAlignment = TypeHorizontalAlignment.Left",
                new ControlText()
                {
                    Text = "Standardausrichtung",
                    HorizontalAlignment = TypeHorizontalAlignment.Default,
                    Border = new PropertyBorder(true),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Null, PropertySpacing.Space.Two),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning)
                },
                new ControlText()
                {
                    Text = "Ausrichtung links",
                    HorizontalAlignment = TypeHorizontalAlignment.Left,
                    Border = new PropertyBorder(true),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Null, PropertySpacing.Space.Two),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning)
                },
                new ControlText()
                {
                    Text = "Ausrichtung rechts",
                    HorizontalAlignment = TypeHorizontalAlignment.Right,
                    Border = new PropertyBorder(false),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Null, PropertySpacing.Space.Two),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning)
                }
            );
        }
    }
}
