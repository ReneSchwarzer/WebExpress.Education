using WebExpress.Attribute;
using WebExpress.Module;
using WebExpress.UI.WebControl;
using WebExpress.Uri;

namespace Education.WebResource
{
    [ID("List")]
    [Title("page.control.list.name")]
    [Segment("list", "page.control.list.name")]
    [Path("/Control")]
    [Module("edu")]
    [Context("control")]
    public sealed class PageControlList : PageControlBase
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlList()
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        public override void Initialization()
        {
            base.Initialization();

            Description = "Das ControlList stellt eine Liste bereit.";
            Code = "new ControlList";
            Code += "(";
            Code += "    new ControlListItem(new ControlText() { Text = \"Erstes Element\" }),";
            Code += "    new ControlListItem(new ControlText() { Text = \"Zweites Element\" }),";
            Code += "    new ControlListItem(new ControlText() { Text = \"Drittes Element\" }),";
            Code += ");";

            AddExample
            (
                new ControlList
                (
                    new ControlListItem(new ControlText() { Text = "Erstes Element" }),
                    new ControlListItem(new ControlText() { Text = "Zweites Element" }),
                    new ControlListItem(new ControlText() { Text = "Drittes Element" })
                )
            );

            // Eigenschaften
            AddProperty
            (
                "Layout",
                "Bestimmt das Layout",
                "Layout = TypesLayoutList.Group",
                new ControlText() { Text = "Default", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlList
                (
                    new ControlListItem(new ControlText() { Text = "Erstes Element" }),
                    new ControlListItem(new ControlText() { Text = "Zweites Element" }),
                    new ControlListItem(new ControlText() { Text = "Drittes Element" })
                )
                {
                    Layout = TypeLayoutList.Default
                },
                new ControlText() { Text = "Simple", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlList
                (
                    new ControlListItem(new ControlText() { Text = "Erstes Element" }),
                    new ControlListItem(new ControlText() { Text = "Zweites Element" }),
                    new ControlListItem(new ControlText() { Text = "Drittes Element" })
                )
                {
                    Layout = TypeLayoutList.Simple
                },
                new ControlText() { Text = "Group", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlList
                (
                    new ControlListItem(new ControlText() { Text = "Erstes Element" }),
                    new ControlListItem(new ControlText() { Text = "Zweites Element" }),
                    new ControlListItem(new ControlText() { Text = "Drittes Element" })
                )
                {
                    Layout = TypeLayoutList.Group
                },
                new ControlText() { Text = "Flush", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlList
                (
                    new ControlListItem(new ControlText() { Text = "Erstes Element" }),
                    new ControlListItem(new ControlText() { Text = "Zweites Element" }),
                    new ControlListItem(new ControlText() { Text = "Drittes Element" })
                )
                {
                    Layout = TypeLayoutList.Flush
                },
                new ControlText() { Text = "Horizontal", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlList
                (
                    new ControlListItem(new ControlText() { Text = "Erstes Element" }),
                    new ControlListItem(new ControlText() { Text = "Zweites Element" }),
                    new ControlListItem(new ControlText() { Text = "Drittes Element" })
                )
                {
                    Layout = TypeLayoutList.Horizontal
                }
            );

            AddProperty
            (
                "Active",
                "Bestimmt den Ativitätsstatus eines Listenelementes. Hinweis: Wird nur bei Group, Flush und Horizontal angewendet.",
                "Active = TypesLayoutList.Group",
                new ControlList
                (
                    new ControlListItem(new ControlText() { Text = "Ohne" }) { Active = TypeActive.None },
                    new ControlListItem(new ControlText() { Text = "Aktiviert" }) { Active = TypeActive.Active },
                    new ControlListItem(new ControlText() { Text = "Deaktiviert" }) { Active = TypeActive.Disabled }
                )
                {
                    Layout = TypeLayoutList.Group
                }
            );

            AddProperty
            (
                "BackgroundColor",
                "Bestimmt die Farbe eines Listenelementes.",
                "BackgroundColor = new PropertyColorBackgroundList(TypeColorBackground.Primary)",
                new ControlList
                (
                    new ControlListItem(new ControlText() { Text = "Standard-Hintergrund" }),
                    new ControlListItem(new ControlText() { Text = "Primär-Hintergrund" }) { BackgroundColor = new PropertyColorBackgroundList(TypeColorBackground.Primary) },
                    new ControlListItem(new ControlText() { Text = "Sekundär-Hintergrund" }) { BackgroundColor = new PropertyColorBackgroundList(TypeColorBackground.Light) },
                    new ControlListItem(new ControlText() { Text = "Info-Hintergrund" }) { BackgroundColor = new PropertyColorBackgroundList(TypeColorBackground.Secondary) },
                    new ControlListItem(new ControlText() { Text = "Erfolgs-Hintergrund" }) { BackgroundColor = new PropertyColorBackgroundList(TypeColorBackground.Info) },
                    new ControlListItem(new ControlText() { Text = "Warnungs-Hintergrund" }) { BackgroundColor = new PropertyColorBackgroundList(TypeColorBackground.Success) },
                    new ControlListItem(new ControlText() { Text = "Fehler-Hintergrund" }) { BackgroundColor = new PropertyColorBackgroundList(TypeColorBackground.Warning) },
                    new ControlListItem(new ControlText() { Text = "Dunkler Hintergrund" }) { BackgroundColor = new PropertyColorBackgroundList(TypeColorBackground.Danger) },
                    new ControlListItem(new ControlText() { Text = "Heller Hintergrund" }) { BackgroundColor = new PropertyColorBackgroundList(TypeColorBackground.Dark) },
                    new ControlListItem(new ControlText() { Text = "Weißer Hintergrund" }) { BackgroundColor = new PropertyColorBackgroundList(TypeColorBackground.White) },
                    new ControlListItem(new ControlText() { Text = "Transparenter Hintergrund" }) { BackgroundColor = new PropertyColorBackgroundList(TypeColorBackground.Transparent) },
                    new ControlListItem(new ControlText() { Text = "Benutzerdefinierter Hintergrund" }) { BackgroundColor = new PropertyColorBackgroundList("gold"), TextColor = new PropertyColorText("red") }
                )
                {
                    Layout = TypeLayoutList.Group
                }
            );

            // Elemente
            AddContent
            (
                "ControlListItem",
                "Ein einfaches Listenelement.",
                "new ControlListItem(...);",
                new ControlList
                (
                    new ControlListItem(new ControlText() { Text = "Erstes Element" }),
                    new ControlListItem(new ControlText() { Text = "Zweites Element" }),
                    new ControlListItem(new ControlText() { Text = "Drittes Element" })
                )
                {
                    Layout = TypeLayoutList.Group
                }
            );

            AddContent
            (
                "ControlListItemLink",
                "Ein Link als Listeneintrag.",
                "new ControlListItemLink(...);",
                new ControlList
                (
                    new ControlListItemLink() { Text = "Erstes Element", Uri = Uri, Icon = new PropertyIcon(TypeIcon.At) },
                    new ControlListItemLink() { Text = "Zweites Element", Uri = Uri, Tooltip = "Tooltip" },
                    new ControlListItemLink() { Text = "Drittes Element", Uri = Uri, Title = "Title" }
                )
                {
                    Layout = TypeLayoutList.Group
                }
            );

            AddContent
            (
                "ControlListItemButton",
                "Eine Schaltfläche als Listeneintrag.",
                "new ControlListItemButton(...);",
                new ControlList
                (
                    new ControlListItemButton(new ControlText() { Text = "Erstes Element" }),
                    new ControlListItemButton(new ControlText() { Text = "Zweites Element" }),
                    new ControlListItemButton(new ControlText() { Text = "Drittes Element" })
                )
                {
                    Layout = TypeLayoutList.Group
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
