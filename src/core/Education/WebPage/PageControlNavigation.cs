using WebExpress.Message;
using WebExpress.UI.WebControl;
using WebExpress.WebApp.WebPage;
using WebExpress.WebAttribute;
using WebExpress.WebResource;

namespace Education.WebPage
{
    [Id("Navigation")]
    [Title("education:page.control.navigation.name")]
    [Segment("navigation", "education:page.control.navigation.name")]
    [Path("/Control")]
    [Module("edu")]
    [Context("control")]
    public sealed class PageControlNavigation : PageControlBase
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlNavigation()
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        /// <param name="context">Der Kontext</param>
        public override void Initialization(IResourceContext context)
        {
            base.Initialization(context);

            Description = "Das ControlNavigation sellt Links in einem Navigationssteuerelement dar.";
            Code = "new ControlNavigation() {  }";

            

        }

        /// <summary>
        /// Erstellt ein Link
        /// </summary>
        /// <param name="id">Die ID</param>
        /// <param name="text">Der Text</param>
        /// <param name="active">Der Aktivitätsstatus</param>
        /// <returns></returns>
        private ControlNavigationItemLink CreateLink
        (
            int id,
            string text,
            TypeActive active = TypeActive.None
        )
        {
            var link = new ControlNavigationItemLink()
            {
                Text = text,
                Uri = Uri,
                Active = active
            };
            link.Params.Add(new Parameter("link", id, ParameterScope.Parameter));

            return link;
        }

        /// <summary>
        /// Verarbeitung
        /// </summary>
        /// <param name="context">Der Kontext zum Rendern der Seite</param>
        public override void Process(RenderContextWebApp context)
        {
            base.Process(context);

            AddExample
            (
                new ControlNavigation
                (
                    CreateLink(1, "Eins", string.IsNullOrWhiteSpace(context.Request.GetParameter("link")?.Value) || context.Request.GetParameter("link")?.Value == "1" ? TypeActive.Active : TypeActive.None),
                    CreateLink(2, "Zwei", context.Request.GetParameter("link")?.Value == "2" ? TypeActive.Active : TypeActive.None),
                    CreateLink(3, "Drei", context.Request.GetParameter("link")?.Value == "3" ? TypeActive.Active : TypeActive.None)
                )
                {
                    Layout = TypeLayoutTab.Pill
                }
            );

            // Eigenschaften
            AddProperty
            (
                "Active",
                "Setzt den Aktivitätsstatus innerhalb des Links.",
                "Active = TypesActive.Active",
                new ControlNavigation
                (
                    CreateLink(1, "None", TypeActive.None),
                    CreateLink(1, "Active", TypeActive.Active),
                    CreateLink(1, "Disable", TypeActive.Disabled)
                )
                {
                    Layout = TypeLayoutTab.Default
                }
            );

            AddProperty
            (
                "Layout",
                "Setzt das Layout des Navigationssteuerelementes.",
                "Layout = TypesLayoutTab.Tab",
                new ControlText() { Text = "Default", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlNavigation
                (
                    CreateLink(1, "None", TypeActive.None),
                    CreateLink(1, "Active", TypeActive.Active),
                    CreateLink(1, "Disable", TypeActive.Disabled)
                )
                {
                    Layout = TypeLayoutTab.Default
                },
                new ControlText() { Text = "Menu", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlNavigation
                (
                    CreateLink(1, "None", TypeActive.None),
                    CreateLink(1, "Active", TypeActive.Active),
                    CreateLink(1, "Disable", TypeActive.Disabled)
                )
                {
                    Layout = TypeLayoutTab.Menu
                },
                new ControlText() { Text = "Tab", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlNavigation
                (
                    CreateLink(1, "None", TypeActive.None),
                    CreateLink(1, "Active", TypeActive.Active),
                    CreateLink(1, "Disable", TypeActive.Disabled)
                )
                {
                    Layout = TypeLayoutTab.Tab
                },
                new ControlText() { Text = "Pill", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlNavigation
                (
                    CreateLink(1, "None", TypeActive.None),
                    CreateLink(1, "Active", TypeActive.Active),
                    CreateLink(1, "Disable", TypeActive.Disabled)
                )
                {
                    Layout = TypeLayoutTab.Pill
                }
            );

            AddProperty
            (
                "HorizontalAlignment",
                "Setzt die horizontale Ausrichtung des Navigationssteuerelementes.",
                "Active = TypeActive.Active",
                new ControlText() { Text = "Default", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlNavigation
                (
                    CreateLink(1, "Eins", string.IsNullOrWhiteSpace(context.Request.GetParameter("link")?.Value) || context.Request.GetParameter("link")?.Value == "1" ? TypeActive.Active : TypeActive.None),
                    CreateLink(2, "Zwei", context.Request.GetParameter("link")?.Value == "2" ? TypeActive.Active : TypeActive.None),
                    CreateLink(3, "Drei", context.Request.GetParameter("link")?.Value == "3" ? TypeActive.Active : TypeActive.None)
                )
                {
                    Layout = TypeLayoutTab.Pill,
                    HorizontalAlignment = TypeHorizontalAlignmentTab.Default
                },
                new ControlText() { Text = "Left", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlNavigation
                (
                    CreateLink(1, "Eins", string.IsNullOrWhiteSpace(context.Request.GetParameter("link")?.Value) || context.Request.GetParameter("link")?.Value == "1" ? TypeActive.Active : TypeActive.None),
                    CreateLink(2, "Zwei", context.Request.GetParameter("link")?.Value == "2" ? TypeActive.Active : TypeActive.None),
                    CreateLink(3, "Drei", context.Request.GetParameter("link")?.Value == "3" ? TypeActive.Active : TypeActive.None)

                )
                {
                    Layout = TypeLayoutTab.Pill,
                    HorizontalAlignment = TypeHorizontalAlignmentTab.Left
                },
                new ControlText() { Text = "Center", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlNavigation
                (
                    CreateLink(1, "Eins", string.IsNullOrWhiteSpace(context.Request.GetParameter("link")?.Value) || context.Request.GetParameter("link")?.Value == "1" ? TypeActive.Active : TypeActive.None),
                    CreateLink(2, "Zwei", context.Request.GetParameter("link")?.Value == "2" ? TypeActive.Active : TypeActive.None),
                    CreateLink(3, "Drei", context.Request.GetParameter("link")?.Value == "3" ? TypeActive.Active : TypeActive.None)
                )
                {
                    Layout = TypeLayoutTab.Pill,
                    HorizontalAlignment = TypeHorizontalAlignmentTab.Center
                },
                new ControlText() { Text = "Right", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlNavigation
                (
                    CreateLink(1, "Eins", string.IsNullOrWhiteSpace(context.Request.GetParameter("link")?.Value) || context.Request.GetParameter("link")?.Value == "1" ? TypeActive.Active : TypeActive.None),
                    CreateLink(2, "Zwei", context.Request.GetParameter("link")?.Value == "2" ? TypeActive.Active : TypeActive.None),
                    CreateLink(3, "Drei", context.Request.GetParameter("link")?.Value == "3" ? TypeActive.Active : TypeActive.None)
                )
                {
                    Layout = TypeLayoutTab.Pill,
                    HorizontalAlignment = TypeHorizontalAlignmentTab.Right
                }
            );

            AddProperty
            (
                "Orientation",
                "Setzt die Orientierung des Navigationssteuerelementes.",
                "Orientation = TypeNavOrientation.Vertical",
                new ControlText() { Text = "Default", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlNavigation
                (
                    CreateLink(1, "Eins", string.IsNullOrWhiteSpace(context.Request.GetParameter("link")?.Value) || context.Request.GetParameter("link")?.Value == "1" ? TypeActive.Active : TypeActive.None),
                    CreateLink(2, "Zwei", context.Request.GetParameter("link")?.Value == "2" ? TypeActive.Active : TypeActive.None),
                    CreateLink(3, "Drei", context.Request.GetParameter("link")?.Value == "3" ? TypeActive.Active : TypeActive.None)
                )
                {
                    Layout = TypeLayoutTab.Pill,
                    Orientation = TypeOrientationTab.Default
                },
                new ControlText() { Text = "Horizontal", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlNavigation
                (
                    CreateLink(1, "Eins", string.IsNullOrWhiteSpace(context.Request.GetParameter("link")?.Value) || context.Request.GetParameter("link")?.Value == "1" ? TypeActive.Active : TypeActive.None),
                    CreateLink(2, "Zwei", context.Request.GetParameter("link")?.Value == "2" ? TypeActive.Active : TypeActive.None),
                    CreateLink(3, "Drei", context.Request.GetParameter("link")?.Value == "3" ? TypeActive.Active : TypeActive.None)
                )
                {
                    Layout = TypeLayoutTab.Pill,
                    Orientation = TypeOrientationTab.Horizontal
                },
                new ControlText() { Text = "Vertical", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlNavigation
                (
                    CreateLink(1, "Eins", string.IsNullOrWhiteSpace(context.Request.GetParameter("link")?.Value) || context.Request.GetParameter("link")?.Value == "1" ? TypeActive.Active : TypeActive.None),
                    CreateLink(2, "Zwei", context.Request.GetParameter("link")?.Value == "2" ? TypeActive.Active : TypeActive.None),
                    CreateLink(3, "Drei", context.Request.GetParameter("link")?.Value == "3" ? TypeActive.Active : TypeActive.None)
                )
                {
                    Layout = TypeLayoutTab.Pill,
                    Orientation = TypeOrientationTab.Vertical
                }
            );

            AddProperty
            (
                "Justified",
                "Bestimmt, ob die Links die gleiche Größe besitzen sollen.",
                "Justified = TypeNavJustified.Justified",
                new ControlText() { Text = "Default", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlNavigation
                (
                    CreateLink(1, "Eins", string.IsNullOrWhiteSpace(context.Request.GetParameter("link")?.Value) || context.Request.GetParameter("link")?.Value == "1" ? TypeActive.Active : TypeActive.None),
                    CreateLink(2, "Zwei", context.Request.GetParameter("link")?.Value == "2" ? TypeActive.Active : TypeActive.None),
                    CreateLink(3, "Drei", context.Request.GetParameter("link")?.Value == "3" ? TypeActive.Active : TypeActive.None)
                )
                {
                    Layout = TypeLayoutTab.Pill,
                    Justified = TypeJustifiedTab.Default
                },
                new ControlText() { Text = "Justified", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlNavigation
                (
                    CreateLink(1, "Eins", string.IsNullOrWhiteSpace(context.Request.GetParameter("link")?.Value) || context.Request.GetParameter("link")?.Value == "1" ? TypeActive.Active : TypeActive.None),
                    CreateLink(2, "Zwei", context.Request.GetParameter("link")?.Value == "2" ? TypeActive.Active : TypeActive.None),
                    CreateLink(3, "Drei", context.Request.GetParameter("link")?.Value == "3" ? TypeActive.Active : TypeActive.None)
                )
                {
                    Layout = TypeLayoutTab.Pill,
                    Justified = TypeJustifiedTab.Justified
                }
            );

            AddProperty
            (
                "ActiveColor",
                "Bestimmt die aktive Farbe.",
                "ActiveColor = new PropertyColorBackground(TypeColorBackground.Secondary)",
                new ControlText() { Text = "Default", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlNavigation
                (
                    CreateLink(1, "Eins", string.IsNullOrWhiteSpace(context.Request.GetParameter("link")?.Value) || context.Request.GetParameter("link")?.Value == "1" ? TypeActive.Active : TypeActive.None),
                    CreateLink(2, "Zwei", context.Request.GetParameter("link")?.Value == "2" ? TypeActive.Active : TypeActive.None),
                    CreateLink(3, "Drei", context.Request.GetParameter("link")?.Value == "3" ? TypeActive.Active : TypeActive.None)
                )
                {
                    Layout = TypeLayoutTab.Pill,
                    ActiveColor = new PropertyColorBackground(TypeColorBackground.Default)
                },
                new ControlText() { Text = "Primär", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlNavigation
                (
                    CreateLink(1, "Eins", string.IsNullOrWhiteSpace(context.Request.GetParameter("link")?.Value) || context.Request.GetParameter("link")?.Value == "1" ? TypeActive.Active : TypeActive.None),
                    CreateLink(2, "Zwei", context.Request.GetParameter("link")?.Value == "2" ? TypeActive.Active : TypeActive.None),
                    CreateLink(3, "Drei", context.Request.GetParameter("link")?.Value == "3" ? TypeActive.Active : TypeActive.None)
                )
                {
                    Layout = TypeLayoutTab.Pill,
                    ActiveColor = new PropertyColorBackground(TypeColorBackground.Primary)
                },
                new ControlText() { Text = "Sekundär", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlNavigation
                (
                    CreateLink(1, "Eins", string.IsNullOrWhiteSpace(context.Request.GetParameter("link")?.Value) || context.Request.GetParameter("link")?.Value == "1" ? TypeActive.Active : TypeActive.None),
                    CreateLink(2, "Zwei", context.Request.GetParameter("link")?.Value == "2" ? TypeActive.Active : TypeActive.None),
                    CreateLink(3, "Drei", context.Request.GetParameter("link")?.Value == "3" ? TypeActive.Active : TypeActive.None)
                )
                {
                    Layout = TypeLayoutTab.Pill,
                    ActiveColor = new PropertyColorBackground(TypeColorBackground.Secondary)
                },
                new ControlText() { Text = "Info", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlNavigation
                (
                    CreateLink(1, "Eins", string.IsNullOrWhiteSpace(context.Request.GetParameter("link")?.Value) || context.Request.GetParameter("link")?.Value == "1" ? TypeActive.Active : TypeActive.None),
                    CreateLink(2, "Zwei", context.Request.GetParameter("link")?.Value == "2" ? TypeActive.Active : TypeActive.None),
                    CreateLink(3, "Drei", context.Request.GetParameter("link")?.Value == "3" ? TypeActive.Active : TypeActive.None)
                )
                {
                    Layout = TypeLayoutTab.Pill,
                    ActiveColor = new PropertyColorBackground(TypeColorBackground.Info)
                },
                new ControlText() { Text = "Erfolg", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlNavigation
                (
                    CreateLink(1, "Eins", string.IsNullOrWhiteSpace(context.Request.GetParameter("link")?.Value) || context.Request.GetParameter("link")?.Value == "1" ? TypeActive.Active : TypeActive.None),
                    CreateLink(2, "Zwei", context.Request.GetParameter("link")?.Value == "2" ? TypeActive.Active : TypeActive.None),
                    CreateLink(3, "Drei", context.Request.GetParameter("link")?.Value == "3" ? TypeActive.Active : TypeActive.None)
                )
                {
                    Layout = TypeLayoutTab.Pill,
                    ActiveColor = new PropertyColorBackground(TypeColorBackground.Success)
                },
                new ControlText() { Text = "Warnung", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlNavigation
                (
                    CreateLink(1, "Eins", string.IsNullOrWhiteSpace(context.Request.GetParameter("link")?.Value) || context.Request.GetParameter("link")?.Value == "1" ? TypeActive.Active : TypeActive.None),
                    CreateLink(2, "Zwei", context.Request.GetParameter("link")?.Value == "2" ? TypeActive.Active : TypeActive.None),
                    CreateLink(3, "Drei", context.Request.GetParameter("link")?.Value == "3" ? TypeActive.Active : TypeActive.None)
                )
                {
                    Layout = TypeLayoutTab.Pill,
                    ActiveColor = new PropertyColorBackground(TypeColorBackground.Warning)
                },
                new ControlText() { Text = "Fehler", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlNavigation
                (
                    CreateLink(1, "Eins", string.IsNullOrWhiteSpace(context.Request.GetParameter("link")?.Value) || context.Request.GetParameter("link")?.Value == "1" ? TypeActive.Active : TypeActive.None),
                    CreateLink(2, "Zwei", context.Request.GetParameter("link")?.Value == "2" ? TypeActive.Active : TypeActive.None),
                    CreateLink(3, "Drei", context.Request.GetParameter("link")?.Value == "3" ? TypeActive.Active : TypeActive.None)
                )
                {
                    Layout = TypeLayoutTab.Pill,
                    ActiveColor = new PropertyColorBackground(TypeColorBackground.Danger)
                },
                new ControlText() { Text = "Dunkel", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlNavigation
                (
                    CreateLink(1, "Eins", string.IsNullOrWhiteSpace(context.Request.GetParameter("link")?.Value) || context.Request.GetParameter("link")?.Value == "1" ? TypeActive.Active : TypeActive.None),
                    CreateLink(2, "Zwei", context.Request.GetParameter("link")?.Value == "2" ? TypeActive.Active : TypeActive.None),
                    CreateLink(3, "Drei", context.Request.GetParameter("link")?.Value == "3" ? TypeActive.Active : TypeActive.None)
                )
                {
                    Layout = TypeLayoutTab.Pill,
                    ActiveColor = new PropertyColorBackground(TypeColorBackground.Dark)
                },
                new ControlText() { Text = "Hell", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlNavigation
                (
                    CreateLink(1, "Eins", string.IsNullOrWhiteSpace(context.Request.GetParameter("link")?.Value) || context.Request.GetParameter("link")?.Value == "1" ? TypeActive.Active : TypeActive.None),
                    CreateLink(2, "Zwei", context.Request.GetParameter("link")?.Value == "2" ? TypeActive.Active : TypeActive.None),
                    CreateLink(3, "Drei", context.Request.GetParameter("link")?.Value == "3" ? TypeActive.Active : TypeActive.None)
                )
                {
                    Layout = TypeLayoutTab.Pill,
                    ActiveColor = new PropertyColorBackground(TypeColorBackground.Light)
                },
                new ControlText() { Text = "Weiß", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlNavigation
                (
                    CreateLink(1, "Eins", string.IsNullOrWhiteSpace(context.Request.GetParameter("link")?.Value) || context.Request.GetParameter("link")?.Value == "1" ? TypeActive.Active : TypeActive.None),
                    CreateLink(2, "Zwei", context.Request.GetParameter("link")?.Value == "2" ? TypeActive.Active : TypeActive.None),
                    CreateLink(3, "Drei", context.Request.GetParameter("link")?.Value == "3" ? TypeActive.Active : TypeActive.None)
                )
                {
                    Layout = TypeLayoutTab.Pill,
                    ActiveColor = new PropertyColorBackground(TypeColorBackground.White)
                },
                new ControlText() { Text = "Transparent", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlNavigation
                (
                    CreateLink(1, "Eins", string.IsNullOrWhiteSpace(context.Request.GetParameter("link")?.Value) || context.Request.GetParameter("link")?.Value == "1" ? TypeActive.Active : TypeActive.None),
                    CreateLink(2, "Zwei", context.Request.GetParameter("link")?.Value == "2" ? TypeActive.Active : TypeActive.None),
                    CreateLink(3, "Drei", context.Request.GetParameter("link")?.Value == "3" ? TypeActive.Active : TypeActive.None)
                )
                {
                    Layout = TypeLayoutTab.Pill,
                    ActiveColor = new PropertyColorBackground(TypeColorBackground.Transparent)
                },
                new ControlText() { Text = "Benutzerdefiniert", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlNavigation
                (
                    CreateLink(1, "Eins", string.IsNullOrWhiteSpace(context.Request.GetParameter("link")?.Value) || context.Request.GetParameter("link")?.Value == "1" ? TypeActive.Active : TypeActive.None),
                    CreateLink(2, "Zwei", context.Request.GetParameter("link")?.Value == "2" ? TypeActive.Active : TypeActive.None),
                    CreateLink(3, "Drei", context.Request.GetParameter("link")?.Value == "3" ? TypeActive.Active : TypeActive.None)
                )
                {
                    Layout = TypeLayoutTab.Pill,
                    ActiveColor = new PropertyColorBackground("gold")
                }

            );
        }
    }
}
