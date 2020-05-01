using WebExpress.Html;
using WebExpress.Messages;
using WebExpress.UI.Controls;

namespace Education.Pages
{
    public class PageControlTab : PageControlBase
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlTab()
            : base("ControlTab")
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        public override void Init()
        {
            base.Init();

            Description = "Das ControlTab sellt Links als einen Tab dar.";
            Code = "new ControlTab(Page) {  }";

            AddExample
            (
                new ControlTab
                (
                    this, 
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
                new ControlTab
                (
                    this,
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
                "Setzt das Layout des Tabs.",
                "Layout = TypesLayoutTab.Tab",
                new ControlText(this) { Text = "Default", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlTab
                (
                    this,
                    CreateLink(1, "None", TypeActive.None),
                    CreateLink(1, "Active", TypeActive.Active),
                    CreateLink(1, "Disable", TypeActive.Disabled)
                )
                {
                    Layout = TypeLayoutTab.Default
                },
                new ControlText(this) { Text = "Menu", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlTab
                (
                    this,
                    CreateLink(1, "None", TypeActive.None),
                    CreateLink(1, "Active", TypeActive.Active),
                    CreateLink(1, "Disable", TypeActive.Disabled)
                )
                {
                    Layout = TypeLayoutTab.Menu
                },
                new ControlText(this) { Text = "Tab", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlTab
                (
                    this,
                    CreateLink(1, "None", TypeActive.None),
                    CreateLink(1, "Active", TypeActive.Active),
                    CreateLink(1, "Disable", TypeActive.Disabled)
                )
                {
                    Layout = TypeLayoutTab.Tab
                },
                new ControlText(this) { Text = "Pill", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlTab
                (
                    this,
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
                "Setzt die horizontale Ausrichtung des Tabs.",
                "Active = TypeActive.Active",
                new ControlText(this) { Text = "Default", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlTab
                (
                    this,
                    CreateLink(1, "Eins", string.IsNullOrWhiteSpace(GetParam("link")) || GetParam("link") == "1" ? TypeActive.Active : TypeActive.None),
                    CreateLink(2, "Zwei", GetParam("link") == "2" ? TypeActive.Active : TypeActive.None),
                    CreateLink(3, "Drei", GetParam("link") == "3" ? TypeActive.Active : TypeActive.None)

                )
                {
                    Layout = TypeLayoutTab.Pill,
                    HorizontalAlignment = TypeHorizontalAlignmentTab.Default
                },
                new ControlText(this) { Text = "Left", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlTab
                (
                    this,
                    CreateLink(1, "Eins", string.IsNullOrWhiteSpace(GetParam("link")) || GetParam("link") == "1" ? TypeActive.Active : TypeActive.None),
                    CreateLink(2, "Zwei", GetParam("link") == "2" ? TypeActive.Active : TypeActive.None),
                    CreateLink(3, "Drei", GetParam("link") == "3" ? TypeActive.Active : TypeActive.None)

                )
                {
                    Layout = TypeLayoutTab.Pill,
                    HorizontalAlignment = TypeHorizontalAlignmentTab.Left
                },
                new ControlText(this) { Text = "Center", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlTab
                (
                    this,
                    CreateLink(1, "Eins", string.IsNullOrWhiteSpace(GetParam("link")) || GetParam("link") == "1" ? TypeActive.Active : TypeActive.None),
                    CreateLink(2, "Zwei", GetParam("link") == "2" ? TypeActive.Active : TypeActive.None),
                    CreateLink(3, "Drei", GetParam("link") == "3" ? TypeActive.Active : TypeActive.None)

                )
                {
                    Layout = TypeLayoutTab.Pill,
                    HorizontalAlignment = TypeHorizontalAlignmentTab.Center
                },
                new ControlText(this) { Text = "Right", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlTab
                (
                    this,
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
                "Setzt die Orientierung des Tabs.",
                "Orientation = TypeNavOrientation.Vertical",
                new ControlText(this) { Text = "Default", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlTab
                (
                    this,
                    CreateLink(1, "Eins", string.IsNullOrWhiteSpace(GetParam("link")) || GetParam("link") == "1" ? TypeActive.Active : TypeActive.None),
                    CreateLink(2, "Zwei", GetParam("link") == "2" ? TypeActive.Active : TypeActive.None),
                    CreateLink(3, "Drei", GetParam("link") == "3" ? TypeActive.Active : TypeActive.None)

                )
                {
                    Layout = TypeLayoutTab.Pill,
                    Orientation = TypeOrientationTab.Default 
                },
                new ControlText(this) { Text = "Horizontal", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlTab
                (
                    this,
                    CreateLink(1, "Eins", string.IsNullOrWhiteSpace(GetParam("link")) || GetParam("link") == "1" ? TypeActive.Active : TypeActive.None),
                    CreateLink(2, "Zwei", GetParam("link") == "2" ? TypeActive.Active : TypeActive.None),
                    CreateLink(3, "Drei", GetParam("link") == "3" ? TypeActive.Active : TypeActive.None)

                )
                {
                    Layout = TypeLayoutTab.Pill,
                    Orientation = TypeOrientationTab.Horizontal
                },
                new ControlText(this) { Text = "Vertical", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlTab
                (
                    this,
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
                "Bestimmt, ob die Tab-Register die gleiche Größe besitzen sollen.",
                "Justified = TypeNavJustified.Justified",
                new ControlText(this) { Text = "Default", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlTab
                (
                    this,
                    CreateLink(1, "Eins", string.IsNullOrWhiteSpace(GetParam("link")) || GetParam("link") == "1" ? TypeActive.Active : TypeActive.None),
                    CreateLink(2, "Zwei", GetParam("link") == "2" ? TypeActive.Active : TypeActive.None),
                    CreateLink(3, "Drei", GetParam("link") == "3" ? TypeActive.Active : TypeActive.None)

                )
                {
                    Layout = TypeLayoutTab.Pill,
                    Justified = TypeJustifiedTab.Default
                },
                new ControlText(this) { Text = "Justified", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlTab
                (
                    this,
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
            var link = new ControlLink(this)
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
