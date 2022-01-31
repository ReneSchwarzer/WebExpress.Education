using System;
using WebExpress.UI.WebControl;
using WebExpress.WebAttribute;
using WebExpress.WebResource;

namespace Education.WebPage
{
    [ID("Tree")]
    [Title("education:page.control.tree.name")]
    [Segment("tree", "education:page.control.tree.name")]
    [Path("/Control")]
    [Module("edu")]
    [Context("control")]
    [Cache()]
    public sealed class PageControlTree : PageControlBase
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlTree()
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        /// <param name="context">Der Kontext</param>
        public override void Initialization(IResourceContext context)
        {
            base.Initialization(context);

            Description = "Das ControlTree stellt ein Baum bereit.";
            Code = "new ControlTree";
            Code += "(";
            Code += "    new ControlTreeItem(new ControlText() { Text = \"1. Element\" }),";
            Code += "    new ControlTreeItem(";
            Code += "    (";
            Code += "        new ControlTreeItem(new ControlText() { Text = \"2.1 Element\" }),";
            Code += "        new ControlTreeItem(new ControlText() { Text = \"2.2 Element\" }),";
            Code += "        new ControlTreeItem(new ControlText() { Text = \"2.3 Element\" }),";
            Code += "        new ControlText() { Text = \"2. Element\" }";
            Code += "    ),";
            Code += "    new ControlTreeItem(new ControlText() { Text = \"3. Element\" })";
            Code += ");";

            var nodes = new Func<TypeLayoutTreeItem, TypeActive, TypeExpandTree, ControlTreeItem[]>((layout, active, expand) =>
            {
                return new ControlTreeItem[]
                {
                    new ControlTreeItem(new ControlText() { Text = "1. Element" }) { Layout = layout },
                        new ControlTreeItem
                        (
                            new ControlTreeItem(new ControlText() { Text = "2.1. Element" }) { Layout = layout },
                            new ControlTreeItem(new ControlText() { Text = "2.2. Element" }) { Active = active, Layout = layout },
                            new ControlTreeItem(new ControlText() { Text = "2.3. Element" }) { Layout = layout },
                            new ControlText() { Text = "2. Element" }
                        ) { Layout = layout, Expand = expand },
                        new ControlTreeItem(new ControlText() { Text = "3. Element" }) { Layout = layout }
                };
            });

            AddExample(new ControlTree(nodes(TypeLayoutTreeItem.Default, TypeActive.None, TypeExpandTree.None)));

            // Eigenschaften
            AddProperty
            (
                "Layout",
                "Bestimmt das Layout",
                "Layout = TypesLayoutTree.Group",
                new ControlText() { Text = "Default", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlTree(nodes(TypeLayoutTreeItem.Default, TypeActive.None, TypeExpandTree.None))
                {
                    Layout = TypeLayoutTree.Default
                },
                new ControlText() { Text = "Flat", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlTree(nodes(TypeLayoutTreeItem.Flat, TypeActive.None, TypeExpandTree.None))
                {
                    Layout = TypeLayoutTree.Flat
                },
                new ControlText() { Text = "Simple", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlTree(nodes(TypeLayoutTreeItem.Simple, TypeActive.None, TypeExpandTree.None))
                {
                    Layout = TypeLayoutTree.Simple
                },
                new ControlText() { Text = "Group", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlTree(nodes(TypeLayoutTreeItem.Group, TypeActive.None, TypeExpandTree.None))
                {
                    Layout = TypeLayoutTree.Group
                },
                new ControlText() { Text = "Flush", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlTree(nodes(TypeLayoutTreeItem.Flush, TypeActive.None, TypeExpandTree.None))
                {
                    Layout = TypeLayoutTree.Flush
                },
                new ControlText() { Text = "Horizontal", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlTree(nodes(TypeLayoutTreeItem.Horizontal, TypeActive.None, TypeExpandTree.None))
                {
                    Layout = TypeLayoutTree.Horizontal
                },
                new ControlText() { Text = "TreeView", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlTree(nodes(TypeLayoutTreeItem.TreeView, TypeActive.None, TypeExpandTree.None))
                {
                    Layout = TypeLayoutTree.TreeView
                }
            );

            AddProperty
            (
                "Active",
                "Bestimmt den Ativitätsstatus eines Baumelementes. Hinweis: Wird nur bei Group, Flush und Horizontal angewendet.",
                "Active = TypeActive.Active",
                new ControlText() { Text = "Ohne", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlTree(nodes(TypeLayoutTreeItem.Group, TypeActive.None, TypeExpandTree.None))
                {
                    Layout = TypeLayoutTree.Group
                },
                new ControlText() { Text = "Aktiviert", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlTree(nodes(TypeLayoutTreeItem.Group, TypeActive.Active, TypeExpandTree.None))
                {
                    Layout = TypeLayoutTree.Group
                },
                new ControlText() { Text = "Deaktiviert", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlTree(nodes(TypeLayoutTreeItem.Group, TypeActive.Disabled, TypeExpandTree.None))
                {
                    Layout = TypeLayoutTree.Group
                }
            );

            AddProperty
            (
                "Expand",
                "Bestimmt den Sichtbarkeitsstaus untergeordneter Baumelemente.",
                "Expand = TypeExpandTree.Collapse",
                new ControlText() { Text = "Ohne", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlTree(nodes(TypeLayoutTreeItem.Simple, TypeActive.None, TypeExpandTree.None))
                {
                    Layout = TypeLayoutTree.Simple
                },
                new ControlText() { Text = "Visible", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlTree(nodes(TypeLayoutTreeItem.Simple, TypeActive.Active, TypeExpandTree.Visible))
                {
                    Layout = TypeLayoutTree.Simple
                },
                new ControlText() { Text = "Collapse", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlTree(nodes(TypeLayoutTreeItem.Simple, TypeActive.Disabled, TypeExpandTree.Collapse))
                {
                    Layout = TypeLayoutTree.Simple
                },
                new ControlTree(nodes(TypeLayoutTreeItem.TreeView, TypeActive.Disabled, TypeExpandTree.Collapse))
                {
                    Layout = TypeLayoutTree.TreeView
                }
            );

            // Elemente
            AddContent
            (
                "ControlTreeItem",
                "Ein einfaches Baumelement.",
                "new ControlTreeItem(...);",
                new ControlTree(nodes(TypeLayoutTreeItem.Group, TypeActive.None, TypeExpandTree.None))
                {
                    Layout = TypeLayoutTree.Group
                }
            );

            AddContent
            (
                "ControlTreeItemLink",
                "Ein Link als Baumelement.",
                "new ControlTreeItemLink(...);",
                new ControlText() { Text = "TreeView", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlTree
                (
                    new ControlTreeItemLink() { Text = "1. Element", Uri = Uri, Layout = TypeLayoutTreeItem.TreeView },
                        new ControlTreeItemLink
                        (
                            new ControlTreeItemLink() { Text = "2.1. Element", Uri = Uri, Icon = new PropertyIcon(TypeIcon.At), Layout = TypeLayoutTreeItem.TreeView },
                            new ControlTreeItemLink() { Text = "2.2. Element", Uri = Uri, Active = TypeActive.Active, Layout = TypeLayoutTreeItem.TreeView },
                            new ControlTreeItemLink() { Text = "2.3. Element", Uri = Uri, Layout = TypeLayoutTreeItem.TreeView }
                        )
                        { Text = "2. Element", Uri = Uri, Layout = TypeLayoutTreeItem.TreeView },
                        new ControlTreeItemLink() { Text = "3. Element", Uri = Uri, Layout = TypeLayoutTreeItem.TreeView }
                )
                {
                    Layout = TypeLayoutTree.TreeView
                },
                new ControlText() { Text = "Flush", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlTree
                (
                    new ControlTreeItemLink() { Text = "1. Element", Uri = Uri, Layout = TypeLayoutTreeItem.Flush },
                        new ControlTreeItemLink
                        (
                            new ControlTreeItemLink() { Text = "2.1. Element", Uri = Uri, Icon = new PropertyIcon(TypeIcon.At), Layout = TypeLayoutTreeItem.Flush },
                            new ControlTreeItemLink() { Text = "2.2. Element", Uri = Uri, Active = TypeActive.Active, Layout = TypeLayoutTreeItem.Flush },
                            new ControlTreeItemLink() { Text = "2.3. Element", Uri = Uri, Layout = TypeLayoutTreeItem.Flush }
                        )
                        { Text = "2. Element", Uri = Uri, Layout = TypeLayoutTreeItem.Flush },
                        new ControlTreeItemLink() { Text = "3. Element", Uri = Uri, Layout = TypeLayoutTreeItem.Flush }
                )
                {
                    Layout = TypeLayoutTree.Flush
                },
                new ControlText() { Text = "Simple", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlTree
                (
                    new ControlTreeItemLink() { Text = "1. Element", Uri = Uri, Layout = TypeLayoutTreeItem.Simple },
                        new ControlTreeItemLink
                        (
                            new ControlTreeItemLink() { Text = "2.1. Element", Uri = Uri, Icon = new PropertyIcon(TypeIcon.At), Layout = TypeLayoutTreeItem.Simple },
                            new ControlTreeItemLink() { Text = "2.2. Element", Uri = Uri, Active = TypeActive.Active, Layout = TypeLayoutTreeItem.Simple },
                            new ControlTreeItemLink() { Text = "2.3. Element", Uri = Uri, Layout = TypeLayoutTreeItem.Simple }
                        )
                        { Text = "2. Element", Uri = Uri, Layout = TypeLayoutTreeItem.Simple },
                        new ControlTreeItemLink() { Text = "3. Element", Uri = Uri, Layout = TypeLayoutTreeItem.Simple }
                )
                {
                    Layout = TypeLayoutTree.Simple
                }
            );
        }
    }
}
