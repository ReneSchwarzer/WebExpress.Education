using WebExpress.UI.Controls;

namespace Education.Pages
{
    public class PageControlDropdown : PageControlBase
    {
        private IControlDropdownItem item1 = new ControlDropdownHeader() { Text = "Header" };
        private IControlDropdownItem item2 = new ControlLink() { Text = "Erster Eintrag" };
        private IControlDropdownItem item3 = new ControlLink() { Text = "Zweiter Eintrag" };
        private IControlDropdownItem item4 = new ControlDropdownDivider();
        private IControlDropdownItem item5 = new ControlLink() { Text = "Dritter Eintrag" };

        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlDropdown()
            : base("ControlDropdownMenu")
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        public override void Init()
        {
            base.Init();

            Description = "Das ControlDropdown sellt einen Schaltfläche mit einem aufkapbaren Menü bereit.";
            Code = "new ControlDropdown";
            Code += "(";
            Code += "    new ControlDropdownHeader() { Text = \"Header\" },";
            Code += "    new ControlLink() { Text = \"Erster Eintrag\" },";
            Code += "    new ControlLink() { Text = \"Zweiter Eintrag\" },";
            Code += "    new ControlDropdownDivider(),";
            Code += "    new ControlLink() { Text = \"Dritter Eintrag\" }";
            Code += ")";
            Code += "{";
            Code += "    Text = \"Dropdown\"";
            Code += "    Toogle = TypeToggleDropdown.Toggle";
            Code += "}";

            AddExample
            (
                new ControlDropdown(item1, item2, item3, item4, item5)
                {
                    Text = "Dropdown",
                    TextColor = new PropertyColorText(TypeColorText.Default),
                    BackgroundColor = new PropertyColorButton(TypeColorButton.Primary),
                    Toogle = TypeToggleDropdown.Toggle
                    //BackgroundColor = new PropertyColorBackground(TypeColorBackground.Primary)
                }
            );

            // Eigenschaften
            AddProperty
            (
                "BackgroundColor",
                "Setzt die Hintergrundfarbe der Schaltfläche.",
                "Color = new PropertyColorButton(TypeColorButton.Primary)",
                new ControlPanelFlexbox
                (
                    new ControlDropdown(item1, item2, item3, item4, item5)
                    {
                        Text = "Standard",
                        Margin = new PropertySpacingMargin(PropertySpacing.Space.Two, PropertySpacing.Space.None)
                    },
                    new ControlDropdown(item1, item2, item3, item4, item5)
                    {
                        Text = "Primär",
                        BackgroundColor = new PropertyColorButton(TypeColorButton.Primary),
                        Margin = new PropertySpacingMargin(PropertySpacing.Space.Two, PropertySpacing.Space.None)
                    },
                    new ControlDropdown(item1, item2, item3, item4, item5)
                    {
                        Text = "Info",
                        BackgroundColor = new PropertyColorButton(TypeColorButton.Info),
                        Margin = new PropertySpacingMargin(PropertySpacing.Space.Two, PropertySpacing.Space.None)
                    },
                    new ControlDropdown(item1, item2, item3, item4, item5)
                    {
                        Text = "Erfolg",
                        BackgroundColor = new PropertyColorButton(TypeColorButton.Success),
                        Margin = new PropertySpacingMargin(PropertySpacing.Space.Two, PropertySpacing.Space.None)
                    },
                    new ControlDropdown(item1, item2, item3, item4, item5)
                    {
                        Text = "Warnung",
                        BackgroundColor = new PropertyColorButton(TypeColorButton.Warning),
                        Margin = new PropertySpacingMargin(PropertySpacing.Space.Two, PropertySpacing.Space.None)
                    },
                    new ControlDropdown(item1, item2, item3, item4, item5)
                    {
                        Text = "Fehler",
                        BackgroundColor = new PropertyColorButton(TypeColorButton.Danger),
                        Margin = new PropertySpacingMargin(PropertySpacing.Space.Two, PropertySpacing.Space.None)
                    },
                    new ControlDropdown(item1, item2, item3, item4, item5)
                    {
                        Text = "Dunkel",
                        BackgroundColor = new PropertyColorButton(TypeColorButton.Dark),
                        Margin = new PropertySpacingMargin(PropertySpacing.Space.Two, PropertySpacing.Space.None)
                    },
                    new ControlDropdown(item1, item2, item3, item4, item5)
                    {
                        Text = "Hell",
                        BackgroundColor = new PropertyColorButton(TypeColorButton.Light),
                        Margin = new PropertySpacingMargin(PropertySpacing.Space.Two, PropertySpacing.Space.None)
                    },
                    new ControlDropdown(item1, item2, item3, item4, item5)
                    {
                        Text = "Benutzerdefiniert",
                        BackgroundColor = new PropertyColorButton("gold"),
                        Margin = new PropertySpacingMargin(PropertySpacing.Space.Two, PropertySpacing.Space.None)
                    }
                )
                {
                    Layout = TypeLayoutFlexbox.Default,
                    Align = TypeAlignFlexbox.Center
                }
            );

            AddProperty
            (
                "Outline",
                "Entfernt die Hintergrundfarbe von der Schaltfläche.",
                "Outline = true",
                new ControlPanelFlexbox
                (
                    new ControlDropdown(item1, item2, item3, item4, item5)
                    {
                        Text = "Standard",
                        Outline = true,
                        Margin = new PropertySpacingMargin(PropertySpacing.Space.Two, PropertySpacing.Space.None)
                    },
                    new ControlDropdown(item1, item2, item3, item4, item5)
                    {
                        Text = "Primär",
                        BackgroundColor = new PropertyColorButton(TypeColorButton.Primary),
                        Outline = true,
                        Margin = new PropertySpacingMargin(PropertySpacing.Space.Two, PropertySpacing.Space.None)
                    },
                    new ControlDropdown(item1, item2, item3, item4, item5)
                    {
                        Text = "Info",
                        BackgroundColor = new PropertyColorButton(TypeColorButton.Info),
                        Outline = true,
                        Margin = new PropertySpacingMargin(PropertySpacing.Space.Two, PropertySpacing.Space.None)
                    },
                    new ControlDropdown(item1, item2, item3, item4, item5)
                    {
                        Text = "Erfolg",
                        BackgroundColor = new PropertyColorButton(TypeColorButton.Success),
                        Outline = true,
                        Margin = new PropertySpacingMargin(PropertySpacing.Space.Two, PropertySpacing.Space.None)
                    },
                    new ControlDropdown(item1, item2, item3, item4, item5)
                    {
                        Text = "Warnung",
                        BackgroundColor = new PropertyColorButton(TypeColorButton.Warning),
                        Outline = true,
                        Margin = new PropertySpacingMargin(PropertySpacing.Space.Two, PropertySpacing.Space.None)
                    },
                    new ControlDropdown(item1, item2, item3, item4, item5)
                    {
                        Text = "Fehler",
                        BackgroundColor = new PropertyColorButton(TypeColorButton.Danger),
                        Outline = true,
                        Margin = new PropertySpacingMargin(PropertySpacing.Space.Two, PropertySpacing.Space.None)
                    },
                    new ControlDropdown(item1, item2, item3, item4, item5)
                    {
                        Text = "Dunkel",
                        BackgroundColor = new PropertyColorButton(TypeColorButton.Dark),
                        Outline = true,
                        Margin = new PropertySpacingMargin(PropertySpacing.Space.Two, PropertySpacing.Space.None)
                    },
                    new ControlDropdown(item1, item2, item3, item4, item5)
                    {
                        Text = "Hell",
                        BackgroundColor = new PropertyColorButton(TypeColorButton.Light),
                        Outline = true,
                        Margin = new PropertySpacingMargin(PropertySpacing.Space.Two, PropertySpacing.Space.None)
                    },
                    new ControlDropdown(item1, item2, item3, item4, item5)
                    {
                        Text = "Benutzerdefiniert",
                        BackgroundColor = new PropertyColorButton("gold"),
                        Outline = true,
                        Margin = new PropertySpacingMargin(PropertySpacing.Space.Two, PropertySpacing.Space.None)
                    }
                )
                {
                    Layout = TypeLayoutFlexbox.Default,
                    Align = TypeAlignFlexbox.Center
                }
            );

            // Eigenschaften
            AddProperty
            (
                "Size",
                "Bestimmt die Größe der Schaltfläche.",
                "Size = TypeSizeButton.Small",
                new ControlPanelFlexbox
                (
                    new ControlDropdown(item1, item2, item3, item4, item5)
                    {
                        Text = "Small",
                        Size = TypeSizeButton.Small,
                        BackgroundColor = new PropertyColorButton(TypeColorButton.Primary),
                        Margin = new PropertySpacingMargin(PropertySpacing.Space.Two, PropertySpacing.Space.None)
                    },
                    new ControlDropdown(item1, item2, item3, item4, item5)
                    {
                        Text = "Standard",
                        Size = TypeSizeButton.Default,
                        BackgroundColor = new PropertyColorButton(TypeColorButton.Primary),
                        Margin = new PropertySpacingMargin(PropertySpacing.Space.Two, PropertySpacing.Space.None)
                    },
                    new ControlDropdown(item1, item2, item3, item4, item5)
                    {
                        Text = "Lagrge",
                        Size = TypeSizeButton.Large,
                        BackgroundColor = new PropertyColorButton(TypeColorButton.Primary),
                        Margin = new PropertySpacingMargin(PropertySpacing.Space.Two, PropertySpacing.Space.None)
                    }
                )
                {
                    Layout = TypeLayoutFlexbox.Default,
                    Align = TypeAlignFlexbox.Center
                }
            );

            AddProperty
            (
                "Icon",
                "Fügt ein Icon der Schaltfläche hinzu.",
                "Icon = new PropertyIcon(TypeIcon.Home)",
                new ControlPanelFlexbox
                (
                    new ControlDropdown(item1, item2, item3, item4, item5)
                    {
                        Text = "Home",
                        Icon = new PropertyIcon(TypeIcon.Home),
                        BackgroundColor = new PropertyColorButton(TypeColorButton.Primary),
                        Margin = new PropertySpacingMargin(PropertySpacing.Space.Two, PropertySpacing.Space.None)
                    },
                    new ControlDropdown(item1, item2, item3, item4, item5)
                    {
                        Text = "Benutzerdefiniert",
                        Icon = new PropertyIcon(Uri.Root.Append("/Assets/img/Icon16.png")),
                        BackgroundColor = new PropertyColorButton(TypeColorButton.Primary),
                        Margin = new PropertySpacingMargin(PropertySpacing.Space.Two, PropertySpacing.Space.None)
                    }
                )
                {
                    Layout = TypeLayoutFlexbox.Default,
                    Align = TypeAlignFlexbox.Center
                }
            );

            AddProperty
            (
               "Block",
               "Spannt die Schaltfläche über die gesammte Bereite.",
               "Block = TypeBlockButton.Block",
               new ControlDropdown(item1, item2, item3, item4, item5)
               {
                   Text = "Block",
                   Block = TypeBlockButton.Block,
                   BackgroundColor = new PropertyColorButton(TypeColorButton.Primary),
                   Margin = new PropertySpacingMargin(PropertySpacing.Space.Two, PropertySpacing.Space.None)
               }
            );

            AddProperty
            (
                "Active",
                "Setzt die Aktivitätseigenschaft der Schaltfläche.",
                "Active = TypesActive.Active",
                new ControlPanelFlexbox
                (
                    new ControlDropdown(item1, item2, item3, item4, item5)
                    {
                        Text = "None",
                        Active = TypeActive.None,
                        BackgroundColor = new PropertyColorButton(TypeColorButton.Primary),
                        Margin = new PropertySpacingMargin(PropertySpacing.Space.Two, PropertySpacing.Space.None)
                    },
                    new ControlDropdown(item1, item2, item3, item4, item5)
                    {
                        Text = "Active",
                        Active = TypeActive.Active,
                        BackgroundColor = new PropertyColorButton(TypeColorButton.Primary),
                        Margin = new PropertySpacingMargin(PropertySpacing.Space.Two, PropertySpacing.Space.None)
                    },
                    new ControlDropdown(item1, item2, item3, item4, item5)
                    {
                        Text = "Disable",
                        Active = TypeActive.Disabled,
                        BackgroundColor = new PropertyColorButton(TypeColorButton.Primary),
                        Margin = new PropertySpacingMargin(PropertySpacing.Space.Two, PropertySpacing.Space.None)
                    }
                )
                {
                    Layout = TypeLayoutFlexbox.Default,
                    Align = TypeAlignFlexbox.Center
                }
            );

            AddProperty
            (
                "Toggle",
                "Ein Indikator, welcher darauf hinweist, dass ein Menü vorhanden ist.",
                "Toggle = TypeToggleDropdown.Toggle",
                new ControlPanelFlexbox
                (
                    new ControlDropdown(item1, item2, item3, item4, item5)
                    {
                        Text = "None",
                        Toogle = TypeToggleDropdown.None,
                        BackgroundColor = new PropertyColorButton(TypeColorButton.Primary),
                        Margin = new PropertySpacingMargin(PropertySpacing.Space.Two, PropertySpacing.Space.None)
                    },
                    new ControlDropdown(item1, item2, item3, item4, item5)
                    {
                        Text = "Toogle",
                        Toogle = TypeToggleDropdown.Toggle,
                        BackgroundColor = new PropertyColorButton(TypeColorButton.Primary),
                        Margin = new PropertySpacingMargin(PropertySpacing.Space.Two, PropertySpacing.Space.None)
                    }
                )
                {
                    Layout = TypeLayoutFlexbox.Default,
                    Align = TypeAlignFlexbox.Center
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
