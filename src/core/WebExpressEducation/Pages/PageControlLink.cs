using WebExpress.Html;
using WebExpress.Messages;
using WebExpress.UI.Controls;

namespace Education.Pages
{
    public class PageControlLink : PageControlBase
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlLink()
            : base("ControlLlink")
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        public override void Init()
        {
            base.Init();

            Description = "Das ControlLlink sellt einen Link auf eine Uri bereit.";
            Code = "new ControlLlink(Page) { Text = \"Home\", Uri = Page.Uri.Root }";

            AddExample
            (
                new ControlLink(this)
                {
                    Text = "Home",
                    Uri = Uri.Root,
                    TextColor = new PropertyColorText(TypeColorText.Default)
                },
                new ControlLink(this)
                {
                    Text = Name,
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.Default)
                }
            );

            // Eigenschaften
            AddProperty
            (
                "Text",
                "Setzt den Text des Links",
                "Text = \"Hallo Welt!\"",
                new ControlLink(this)
                {
                    Text = "Hallo Welt!",
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.Default),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                }
            );

            AddProperty
            (
                "Content",
                "Setzt den Inhalt des Links",
                "new ControlLink(this, new ControlText(this) { Text = \"Hallo Welt!\", Format = TypesTextFormat.Italic }, new ControlBadge(this) { Value = \"1\", BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Danger) })",
                new ControlLink(this, new ControlText(this) { Text = "Hallo Welt!", Format = TypesTextFormat.Italic }, new ControlBadge(this) { Value = "1", BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Danger) })
                {
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.Default),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                }
            );

            AddProperty
            (
                "Title",
                new ControlLink(this)
                {
                    Text = "Probier es aus",
                    Uri = Uri,
                    Title = "Hallo Welt!",
                    TextColor = new PropertyColorText(TypeColorText.Default),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                }
            );

            AddProperty
            (
                "Target",
                new ControlLink(this)
                {
                    Text = "Probier es aus",
                    Uri = Uri,
                    Target = TypeTarget.Blank,
                    TextColor = new PropertyColorText(TypeColorText.Default),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                }
            );

            AddProperty
            (
                "Uri",
                new ControlLink(this)
                {
                    Text = "Mit Uri",
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.Default),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink(this)
                {
                    Text = "Ohne Uri",
                    TextColor = new PropertyColorText(TypeColorText.Default),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                }
            );
            
            AddProperty
            (
                "Icon",
                new ControlLink(this)
                { 
                    Text = "Home", 
                    Icon = new PropertyIcon(TypeIcon.Home), 
                    Uri = Uri.Root,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink(this) 
                { 
                    Text = "Tutorials", 
                    Icon = new PropertyIcon(TypeIcon.GraduationCap), 
                    Uri = Uri.Root.Append("tutorials"),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink(this) 
                { 
                    Text = "Controls", 
                    Icon = new PropertyIcon(TypeIcon.Clone), 
                    Uri = Uri.Root.Append("controls"),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink(this) 
                { 
                    Text = "Html", 
                    Icon = new PropertyIcon(TypeIcon.Code), 
                    Uri = Uri.Root.Append("html"),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink(this) 
                { 
                    Text = "Hilfe", 
                    Icon = new PropertyIcon(TypeIcon.InfoCircle), 
                    Uri = Uri.Root.Append("help"),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink(this) 
                { 
                    Text = "Benutzerdefiniert",
                    Icon = new PropertyIcon(Uri.Root.Append("/Assets/img/Icon16.png")),
                    Uri = Uri.Root.Append("help"),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                }
            );

            AddProperty
            (
                "Active",
                "Setzt die Aktivitätseigenschaft des Links.",
                "Diese Eigenschaft wirkt sich nicht in allen Kontexten aus.",
                "Active = TypesActive.Active",
                new ControlLink(this)
                {
                    Text = "None",
                    Active = TypeActive.None,
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.Default),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink(this)
                {
                    Text = "Active",
                    Active = TypeActive.Active,
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.Default),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink(this)
                {
                    Text = "Disable",
                    Active = TypeActive.Disabled,
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.Default),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                }
            );

            AddProperty
            (
                "Size",
                new ControlLink(this)
                {
                    Text = "Extra Small",
                    Uri = Uri,
                    Size = new PropertySizeText(TypeSizeText.ExtraSmall),
                    TextColor = new PropertyColorText(TypeColorText.Default),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink(this)
                {
                    Text = "Small",
                    Uri = Uri,
                    Size = new PropertySizeText(TypeSizeText.Small),
                    TextColor = new PropertyColorText(TypeColorText.Default),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink(this)
                {
                    Text = "Standard",
                    Uri = Uri,
                    Size = new PropertySizeText(TypeSizeText.Default),
                    TextColor = new PropertyColorText(TypeColorText.Default),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink(this)
                {
                    Text = "Large",
                    Uri = Uri,
                    Size = new PropertySizeText(TypeSizeText.Large),
                    TextColor = new PropertyColorText(TypeColorText.Default),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink(this)
                {
                    Text = "Extra Large",
                    Uri = Uri,
                    Size = new PropertySizeText(TypeSizeText.ExtraLarge),
                    TextColor = new PropertyColorText(TypeColorText.Default),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink(this)
                {
                    Text = "Benutzerdefiniert",
                    Uri = Uri,
                    Size = new PropertySizeText(3.1f),
                    TextColor = new PropertyColorText(TypeColorText.Default),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                }
            );

            AddProperty
            (
                "TextColor",
                new ControlLink(this)
                {
                    Text = "Standard",
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.Default),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink(this)
                {
                    Text = "Primär",
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.Primary),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink(this)
                {
                    Text = "Info",
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.Info),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink(this)
                {
                    Text = "Erfolg",
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.Success),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink(this)
                {
                    Text = "Warnung",
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.Warning),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink(this)
                {
                    Text = "Fehler",
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.Danger),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink(this)
                {
                    Text = "Dunkl",
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.Dark),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink(this)
                {
                    Text = "Hell",
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.Light),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink(this)
                {
                    Text = "Stumm",
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.Muted),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink(this)
                {
                    Text = "Weiß",
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.White),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink(this)
                {
                    Text = "Benutzerdefiniert",
                    Uri = Uri,
                    TextColor = new PropertyColorText("red"),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                }
            );

            // Eigenschaften
            AddProperty
            (
                "BackgroundColor",
                new ControlLink(this)
                {
                    Text = "Standard",
                    Uri = Uri,
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Default),
                    Padding = new PropertySpacingPadding(PropertySpacing.Space.Two),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Auto)
                }, 
                new ControlLink(this)
                {
                    Text = "Primär",
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.White),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Primary),
                    Padding = new PropertySpacingPadding(PropertySpacing.Space.Two),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Auto)
                },
                new ControlLink(this)
                {
                    Text = "Sekundär",
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.White),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Secondary),
                    Padding = new PropertySpacingPadding(PropertySpacing.Space.Two),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Auto)
                },
                new ControlLink(this)
                {
                    Text = "Info",
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.White),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Info),
                    Padding = new PropertySpacingPadding(PropertySpacing.Space.Two),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Auto)
                },
                new ControlLink(this)
                {
                    Text = "Erfolg",
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.White),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Success),
                    Padding = new PropertySpacingPadding(PropertySpacing.Space.Two),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Auto)
                },
                new ControlLink(this)
                {
                    Text = "Warnung",
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.White),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning),
                    Padding = new PropertySpacingPadding(PropertySpacing.Space.Two),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Auto)
                },
                new ControlLink(this)
                {
                    Text = "Fehler",
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.White),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Danger),
                    Padding = new PropertySpacingPadding(PropertySpacing.Space.Two),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Auto)
                },
                new ControlLink(this)
                {
                    Text = "Dunkel",
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.White),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Dark),
                    Padding = new PropertySpacingPadding(PropertySpacing.Space.Two),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Auto)
                },
                new ControlLink(this)
                {
                    Text = "Hell",
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.Dark),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light),
                    Padding = new PropertySpacingPadding(PropertySpacing.Space.Two),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Auto)
                },
                new ControlLink(this)
                {
                    Text = "Weiß",
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.Dark),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.White),
                    Padding = new PropertySpacingPadding(PropertySpacing.Space.Two),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Auto)
                },
                new ControlLink(this)
                {
                    Text = "Transparent",
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.Dark),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Transparent),
                    Padding = new PropertySpacingPadding(PropertySpacing.Space.Two),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Auto)
                },
                new ControlLink(this)
                {
                    Text = "Benutzerdefiniert",
                    Uri = Uri,
                    TextColor = new PropertyColorText("red"),
                    BackgroundColor = new PropertyColorBackground("gold"),
                    Padding = new PropertySpacingPadding(PropertySpacing.Space.Two),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Auto)
                }
            );

            var linkParam = new ControlLink(this)
            {
                Text = "Mit Parameter",
                Uri = Uri,
                Active = TypeActive.Active
            };
            linkParam.Params.Add(new Parameter("param1", 1));
            linkParam.Params.Add(new Parameter("param2", "zwei"));

            AddProperty
            (
                "Param",
                "Link mit Parametern",
                "Params.Add(new Parameter(\"param1\", 1))",
                linkParam
            );

            AddProperty
            (
                "Modal",
                new ControlLink(this)
                {
                    Text = "Klick mich!",
                    Uri = Uri,
                    Modal = new ControlModal(this, null, "Dialog", new ControlText(this) { Text = "Hallo Welt!" }),
                    TextColor = new PropertyColorText(TypeColorText.Default),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
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
