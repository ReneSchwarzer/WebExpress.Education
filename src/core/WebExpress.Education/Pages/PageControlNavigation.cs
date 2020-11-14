using WebExpress.Html;
using WebExpress.Messages;
using WebExpress.UI.Controls;

namespace Education.Pages
{
    public class PageControlNavigation : PageControlBase
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlNavigation()
            : base("ControlNavigation")
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        public override void Init()
        {
            base.Init();

            Description = "Das ControlNavigation sellt Links in einem Navigationssteuerelement dar.";
            Code = "new ControlNavigation() {  }";

            AddExample
            (
                new ControlNavigation
                (
                    CreateLink(1, "Eins", string.IsNullOrWhiteSpace(GetParam("link")) || GetParam("link") == "1" ? TypeActive.Active : TypeActive.None),
                    CreateLink(2, "Zwei", GetParam("link") == "2" ? TypeActive.Active : TypeActive.None),
                    CreateLink(3, "Drei", GetParam("link") == "3" ? TypeActive.Active : TypeActive.None)
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
                    CreateLink(1, "Eins", string.IsNullOrWhiteSpace(GetParam("link")) || GetParam("link") == "1" ? TypeActive.Active : TypeActive.None),
                    CreateLink(2, "Zwei", GetParam("link") == "2" ? TypeActive.Active : TypeActive.None),
                    CreateLink(3, "Drei", GetParam("link") == "3" ? TypeActive.Active : TypeActive.None)
                )
                {
                    Layout = TypeLayoutTab.Pill,
                    HorizontalAlignment = TypeHorizontalAlignmentTab.Default
                },
                new ControlText() { Text = "Left", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlNavigation
                (
                    CreateLink(1, "Eins", string.IsNullOrWhiteSpace(GetParam("link")) || GetParam("link") == "1" ? TypeActive.Active : TypeActive.None),
                    CreateLink(2, "Zwei", GetParam("link") == "2" ? TypeActive.Active : TypeActive.None),
                    CreateLink(3, "Drei", GetParam("link") == "3" ? TypeActive.Active : TypeActive.None)

                )
                {
                    Layout = TypeLayoutTab.Pill,
                    HorizontalAlignment = TypeHorizontalAlignmentTab.Left
                },
                new ControlText() { Text = "Center", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlNavigation
                (
                    CreateLink(1, "Eins", string.IsNullOrWhiteSpace(GetParam("link")) || GetParam("link") == "1" ? TypeActive.Active : TypeActive.None),
                    CreateLink(2, "Zwei", GetParam("link") == "2" ? TypeActive.Active : TypeActive.None),
                    CreateLink(3, "Drei", GetParam("link") == "3" ? TypeActive.Active : TypeActive.None)
                )
                {
                    Layout = TypeLayoutTab.Pill,
                    HorizontalAlignment = TypeHorizontalAlignmentTab.Center
                },
                new ControlText() { Text = "Right", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlNavigation
                (
                    CreateLink(1, "Eins", string.IsNullOrWhiteSpace(GetParam("link")) || GetParam("link") == "1" ? TypeActive.Active : TypeActive.None),
                    CreateLink(2, "Zwei", GetParam("link") == "2" ? TypeActive.Active : TypeActive.None),
                    CreateLink(3, "Drei", GetParam("link") == "3" ? TypeActive.Active : TypeActive.None)
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
                    CreateLink(1, "Eins", string.IsNullOrWhiteSpace(GetParam("link")) || GetParam("link") == "1" ? TypeActive.Active : TypeActive.None),
                    CreateLink(2, "Zwei", GetParam("link") == "2" ? TypeActive.Active : TypeActive.None),
                    CreateLink(3, "Drei", GetParam("link") == "3" ? TypeActive.Active : TypeActive.None)
                )
                {
                    Layout = TypeLayoutTab.Pill,
                    Orientation = TypeOrientationTab.Default 
                },
                new ControlText() { Text = "Horizontal", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlNavigation
                (
                    CreateLink(1, "Eins", string.IsNullOrWhiteSpace(GetParam("link")) || GetParam("link") == "1" ? TypeActive.Active : TypeActive.None),
                    CreateLink(2, "Zwei", GetParam("link") == "2" ? TypeActive.Active : TypeActive.None),
                    CreateLink(3, "Drei", GetParam("link") == "3" ? TypeActive.Active : TypeActive.None)
                )
                {
                    Layout = TypeLayoutTab.Pill,
                    Orientation = TypeOrientationTab.Horizontal
                },
                new ControlText() { Text = "Vertical", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlNavigation
                (
                    CreateLink(1, "Eins", string.IsNullOrWhiteSpace(GetParam("link")) || GetParam("link") == "1" ? TypeActive.Active : TypeActive.None),
                    CreateLink(2, "Zwei", GetParam("link") == "2" ? TypeActive.Active : TypeActive.None),
                    CreateLink(3, "Drei", GetParam("link") == "3" ? TypeActive.Active : TypeActive.None)
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
                    CreateLink(1, "Eins", string.IsNullOrWhiteSpace(GetParam("link")) || GetParam("link") == "1" ? TypeActive.Active : TypeActive.None),
                    CreateLink(2, "Zwei", GetParam("link") == "2" ? TypeActive.Active : TypeActive.None),
                    CreateLink(3, "Drei", GetParam("link") == "3" ? TypeActive.Active : TypeActive.None)
                )
                {
                    Layout = TypeLayoutTab.Pill,
                    Justified = TypeJustifiedTab.Default
                },
                new ControlText() { Text = "Justified", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlNavigation
                (
                    CreateLink(1, "Eins", string.IsNullOrWhiteSpace(GetParam("link")) || GetParam("link") == "1" ? TypeActive.Active : TypeActive.None),
                    CreateLink(2, "Zwei", GetParam("link") == "2" ? TypeActive.Active : TypeActive.None),
                    CreateLink(3, "Drei", GetParam("link") == "3" ? TypeActive.Active : TypeActive.None)
                )
                {
                    Layout = TypeLayoutTab.Pill,
                    Justified = TypeJustifiedTab.Justified
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

        /// <summary>
        /// Erstellt ein Link
        /// </summary>
        /// <param name="id">Die ID</param>
        /// <param name="text">Der Text</param>
        /// <param name="active">Der Aktivitätsstatus</param>
        /// <returns></returns>
        private ControlLink CreateLink
        (
            int id, 
            string text, 
            TypeActive active = TypeActive.None
        )
        {
            var link = new ControlLink()
            {
                Text = text,
                Uri = Uri,
                Active = active
            };
            link.Params.Add(new Parameter("link", id));

            return link;
        }
    }
}
