using WebExpress.Html;
using WebExpress.Message;
using WebExpress.UI.WebControl;
using WebExpress.WebAttribute;
using WebExpress.WebResource;

namespace Education.WebPage
{
    [Id("Link")]
    [Title("education:page.control.link.name")]
    [Segment("link", "education:page.control.link.name")]
    [Path("/Control")]
    [Module("edu")]
    [Context("control")]
    public sealed class PageControlLink : PageControlBase
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlLink()
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        /// <param name="context">Der Kontext</param>
        public override void Initialization(IResourceContext context)
        {
            base.Initialization(context);

            Description = "Das ControlLlink sellt einen Link auf eine Uri bereit.";
            Code = "new ControlLlink() { Text = \"Home\", Uri = Page.Uri.Root }";

            AddExample
            (
                new ControlLink()
                {
                    Text = "Home",
                    Uri = Uri.Root
                },
                new ControlLink()
                {
                    Text = Name,
                    Uri = Uri
                }
            );

            // Eigenschaften
            AddProperty
            (
                "Text",
                "Setzt den Text des Links",
                "Text = \"Hallo Welt!\"",
                new ControlLink()
                {
                    Text = "Hallo Welt!",
                    Uri = Uri,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                }
            );

            AddProperty
            (
                "Content",
                "Setzt den Inhalt des Links",
                "new ControlLink(this, new ControlText(this) { Text = \"Hallo Welt!\", Format = TypeFormatText.Italic }, new ControlBadge(this) { Value = \"1\", BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Danger) })",
                new ControlLink(new ControlText() { Text = "Hallo Welt!", Format = TypeFormatText.Italic }, new ControlBadge() { Value = "1", BackgroundColor = new PropertyColorBackgroundBadge(TypeColorBackground.Danger) })
                {
                    Uri = Uri,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                }
            );

            AddProperty
            (
                "Title",
                "Legt ein ToolTip fest.",
                "Title = \"Hallo Welt!\"",
                new ControlLink()
                {
                    Text = "Probier es aus",
                    Uri = Uri,
                    Title = "Hallo Welt!",
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                }
            );

            AddProperty
            (
                "Target",
                "Legt das Aufrufsziel des Links fest.",
                "Target = TypeTarget.Blank",
                new ControlLink()
                {
                    Text = "Probier es aus",
                    Uri = Uri,
                    Target = TypeTarget.Blank,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                }
            );

            AddProperty
            (
                "Uri",
                "Legt die Aufrufsadresse des Links fest.",
                "Uri = Page.Uri",
                new ControlLink()
                {
                    Text = "Mit Uri",
                    Uri = Uri,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink()
                {
                    Text = "Ohne Uri",
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                }
            );

            AddProperty
            (
                "Icon",
                "Fügt ein Icon dem Link hinzu.",
                "Icon = new PropertyIcon(TypeIcon.Home)",
                new ControlLink()
                {
                    Text = "Home",
                    Icon = new PropertyIcon(TypeIcon.Home),
                    Uri = Uri.Root,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink()
                {
                    Text = "Tutorials",
                    Icon = new PropertyIcon(TypeIcon.GraduationCap),
                    Uri = Uri.Root.Append("tutorials"),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink()
                {
                    Text = "Controls",
                    Icon = new PropertyIcon(TypeIcon.Clone),
                    Uri = Uri.Root.Append("controls"),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink()
                {
                    Text = "Html",
                    Icon = new PropertyIcon(TypeIcon.Code),
                    Uri = Uri.Root.Append("html"),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink()
                {
                    Text = "Hilfe",
                    Icon = new PropertyIcon(TypeIcon.InfoCircle),
                    Uri = Uri.Root.Append("help"),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink()
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
                "Diese Eigenschaft wirkt sich nicht in allen Kontexten aus. Siehe ControlTab",
                "Active = TypesActive.Active",
                new ControlLink()
                {
                    Text = "None",
                    Active = TypeActive.None,
                    Uri = Uri,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink()
                {
                    Text = "Active",
                    Active = TypeActive.Active,
                    Uri = Uri,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink()
                {
                    Text = "Disable",
                    Active = TypeActive.Disabled,
                    Uri = Uri,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                }
            );

            AddProperty
            (
                "Decoration",
                "Bestimmt, ob der Link beim Hoovern unterstrichen wird oder nicht.",
                "Decoration = TypeTextDecoration.None",
                new ControlLink()
                {
                    Text = "Default",
                    Decoration = TypeTextDecoration.Default,
                    Uri = Uri,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink()
                {
                    Text = "None",
                    Decoration = TypeTextDecoration.None,
                    Uri = Uri,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                }
            );

            AddProperty
            (
                "Size",
                "Bestimmt die Größe des Links.",
                "Size = TypeSizeButton.Small",
                new ControlLink()
                {
                    Text = "Extra Small",
                    Uri = Uri,
                    Size = new PropertySizeText(TypeSizeText.ExtraSmall),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink()
                {
                    Text = "Small",
                    Uri = Uri,
                    Size = new PropertySizeText(TypeSizeText.Small),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink()
                {
                    Text = "Standard",
                    Uri = Uri,
                    Size = new PropertySizeText(TypeSizeText.Default),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink()
                {
                    Text = "Large",
                    Uri = Uri,
                    Size = new PropertySizeText(TypeSizeText.Large),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink()
                {
                    Text = "Extra Large",
                    Uri = Uri,
                    Size = new PropertySizeText(TypeSizeText.ExtraLarge),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink()
                {
                    Text = "Benutzerdefiniert",
                    Uri = Uri,
                    Size = new PropertySizeText(3.1f),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                }
            );

            AddProperty
            (
                "TextColor",
                "Legt die Textfarbe fest.",
                "TextColor = new PropertyColorText(TypeColorText.Primary)",
                new ControlLink()
                {
                    Text = "Standard",
                    Uri = Uri,
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink()
                {
                    Text = "Primär",
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.Primary),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink()
                {
                    Text = "Info",
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.Info),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink()
                {
                    Text = "Erfolg",
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.Success),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink()
                {
                    Text = "Warnung",
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.Warning),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink()
                {
                    Text = "Fehler",
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.Danger),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink()
                {
                    Text = "Dunkl",
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.Dark),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink()
                {
                    Text = "Hell",
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.Light),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink()
                {
                    Text = "Stumm",
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.Muted),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink()
                {
                    Text = "Weiß",
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.White),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlLink()
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
                "Legt die Hintergrundfarbe fest.",
                "BackgroundColor = new PropertyColorBackground(TypeColorBackground.Primary)",
                new ControlLink()
                {
                    Text = "Standard",
                    Uri = Uri,
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Default),
                    Padding = new PropertySpacingPadding(PropertySpacing.Space.Two),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Auto)
                },
                new ControlLink()
                {
                    Text = "Primär",
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.White),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Primary),
                    Padding = new PropertySpacingPadding(PropertySpacing.Space.Two),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Auto)
                },
                new ControlLink()
                {
                    Text = "Sekundär",
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.White),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Secondary),
                    Padding = new PropertySpacingPadding(PropertySpacing.Space.Two),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Auto)
                },
                new ControlLink()
                {
                    Text = "Info",
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.White),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Info),
                    Padding = new PropertySpacingPadding(PropertySpacing.Space.Two),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Auto)
                },
                new ControlLink()
                {
                    Text = "Erfolg",
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.White),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Success),
                    Padding = new PropertySpacingPadding(PropertySpacing.Space.Two),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Auto)
                },
                new ControlLink()
                {
                    Text = "Warnung",
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.White),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning),
                    Padding = new PropertySpacingPadding(PropertySpacing.Space.Two),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Auto)
                },
                new ControlLink()
                {
                    Text = "Fehler",
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.White),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Danger),
                    Padding = new PropertySpacingPadding(PropertySpacing.Space.Two),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Auto)
                },
                new ControlLink()
                {
                    Text = "Dunkel",
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.White),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Dark),
                    Padding = new PropertySpacingPadding(PropertySpacing.Space.Two),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Auto)
                },
                new ControlLink()
                {
                    Text = "Hell",
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.Dark),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light),
                    Padding = new PropertySpacingPadding(PropertySpacing.Space.Two),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Auto)
                },
                new ControlLink()
                {
                    Text = "Weiß",
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.Dark),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.White),
                    Padding = new PropertySpacingPadding(PropertySpacing.Space.Two),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Auto)
                },
                new ControlLink()
                {
                    Text = "Transparent",
                    Uri = Uri,
                    TextColor = new PropertyColorText(TypeColorText.Dark),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Transparent),
                    Padding = new PropertySpacingPadding(PropertySpacing.Space.Two),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Auto)
                },
                new ControlLink()
                {
                    Text = "Benutzerdefiniert",
                    Uri = Uri,
                    TextColor = new PropertyColorText("red"),
                    BackgroundColor = new PropertyColorBackground("gold"),
                    Padding = new PropertySpacingPadding(PropertySpacing.Space.Two),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Auto)
                }
            );

            var linkParam = new ControlLink()
            {
                Text = "Mit Parameter",
                Uri = Uri,
                Active = TypeActive.Active
            };
            linkParam.Params.Add(new Parameter("param1", 1, ParameterScope.Parameter));
            linkParam.Params.Add(new Parameter("param2", "zwei", ParameterScope.Parameter));

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
                "Blendet ein Dialog ein.",
                "Modal = new ControlModal(...)",
                new ControlLink()
                {
                    Text = "Klick mich!",
                    Uri = Uri,
                    Modal = new PropertyModal(TypeModal.Modal, new ControlModal(null, "Dialog", new ControlText() { Text = "Hallo Welt!" })),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                }
            );
        }
    }
}
