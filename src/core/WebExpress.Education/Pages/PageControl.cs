using WebExpress.UI.Controls;

namespace Education.Pages
{
    public class PageControl : PageControlBase
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControl()
            : base("Controls")
        {
        }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="name">Der Seitenname</param>
        public PageControl(string name)
            : base(name)
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        public override void Init()
        {
            base.Init();

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
                    TextColor = new PropertyColorText(TypeColorText.Default)
                },
                new ControlText()
                {
                    Text = "Primäre-Textfarbe",
                    TextColor = new PropertyColorText(TypeColorText.Primary)
                },
                new ControlText()
                {
                    Text = "Info-Textfarbe",
                    TextColor = new PropertyColorText(TypeColorText.Info)
                },
                new ControlText()
                {
                    Text = "Erfolgs-Textfarbe",
                    TextColor = new PropertyColorText(TypeColorText.Success)
                },
                new ControlText()
                {
                    Text = "Warnungs-Textfarbe",
                    TextColor = new PropertyColorText(TypeColorText.Warning)
                },
                new ControlText()
                {
                    Text = "Fehler-Textfarbe",
                    TextColor = new PropertyColorText(TypeColorText.Danger)
                },
                new ControlText()
                {
                    Text = "Dunkle Textfarbe",
                    TextColor = new PropertyColorText(TypeColorText.Dark)
                },
                new ControlText()
                {
                    Text = "Helle Textfarbe",
                    TextColor = new PropertyColorText(TypeColorText.Light)
                },
                new ControlText()
                {
                    Text = "Weiße Textfarbe",
                    TextColor = new PropertyColorText(TypeColorText.White)
                },
                new ControlText()
                {
                    Text = "Benutzerdefinierte Textfarbe",
                    TextColor = new PropertyColorText("gold")
                }
             );

            AddProperty
            (
                "BackgroundColor",
                "Setzt die Hintergrundfarbe des Steuerelementes.",
                "BackgroundColor = new PropertyColorBackground(TypeColorBackground.Primary)",
                new ControlText()
                {
                    Text = "Standard-Hintergrund"
                },
                new ControlText()
                {
                    Text = "Primär-Hintergrund",
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Primary)
                },
                new ControlText()
                {
                    Text = "Sekundär-Hintergrund",
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Secondary)
                },
                new ControlText()
                {
                    Text = "Info-Hintergrund",
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Info)
                },
                new ControlText()
                {
                    Text = "Erfolgs-Hintergrund",
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Success)
                },
                new ControlText()
                {
                    Text = "Warnungs-Hintergrund",
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning)
                },
                new ControlText()
                {
                    Text = "Fehler-Hintergrund",
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Danger)
                },
                new ControlText()
                {
                    Text = "Dunkler Hintergrund",
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Dark)
                },
                new ControlText()
                {
                    Text = "Heller Hintergrund",
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light)
                },
                new ControlText()
                {
                    Text = "Weißer Hintergrund",
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.White)
                },
                new ControlText()
                {
                    Text = "Transparenter Hintergrund",
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Transparent)
                },
                new ControlText()
                {
                    Text = "Benutzerdefinierter Hintergrund",
                    TextColor = new PropertyColorText("red"),
                    BackgroundColor = new PropertyColorBackground("gold")
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

        /// <summary>
        /// Verarbeitung
        /// </summary>
        public override void Process()
        {
            base.Process();

        }
    }
}
