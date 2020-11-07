using WebExpress.UI.Controls;

namespace Education.Pages
{
    public class PageControlPanelFlexbox : PageControlBase
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlPanelFlexbox()
            : base("ControlPanelFlexbox")
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        public override void Init()
        {
            base.Init();

            Description = "Das ControlPanelFlexbox stellt eine ... bereit.";
            Code = "new ControlPanelFlexbox";
            Code += "(";
            Code += "    new ControlText() { Text = \"Erster Einrag\", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two) },";
            Code += "    new ControlText() { Text = \"Zweiter Einrag\", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two) },";
            Code += "    new ControlText() { Text = \"Dritter Einrag\", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two) }";
            Code += ")";

            AddExample
            (
                new ControlPanelFlexbox
                (
                    new ControlText() { Text = "Erster Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zweiter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dritter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) }
                )
                {
                    Layout = TypeLayoutFlexbox.Default,
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning)
                }
            );

            // Eigenschaften
            AddProperty
            (
                "Layout",
                "Legt das Layout fest.",
                "Layout = TypeLayoutFlexbox.None",
                new ControlText() { Text = "Ohne", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelFlexbox
                (
                    new ControlText() { Text = "Erster Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zweiter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dritter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) }
                )
                {
                    Layout = TypeLayoutFlexbox.None,
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning)
                },
                new ControlText() { Text = "Standard", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelFlexbox
                (
                    new ControlText() { Text = "Erster Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zweiter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dritter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) }
                )
                {
                    Layout = TypeLayoutFlexbox.Default,
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning)
                },
                new ControlText() { Text = "Inline", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelFlexbox
                (
                    new ControlText() { Text = "Erster Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zweiter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dritter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) }
                )
                {
                    Layout = TypeLayoutFlexbox.Inline,
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning)
                }
            );

            AddProperty
            (
                "Justify",
                 "Legt die horizentale Ausrichtung der Items fest.",
                "Justify = TypeJustifiedFlexbox.Start",
                new ControlText() { Text = "Ohne", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelFlexbox
                (
                    new ControlText() { Text = "Erster Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zweiter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dritter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) }
                )
                {
                    Layout = TypeLayoutFlexbox.Default,
                    Justify = TypeJustifiedFlexbox.None,
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning)
                },
                new ControlText() { Text = "Links", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelFlexbox
                (
                    new ControlText() { Text = "Erster Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zweiter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dritter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) }
                )
                {
                    Layout = TypeLayoutFlexbox.Default,
                    Justify = TypeJustifiedFlexbox.Start,
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning)
                },
                new ControlText() { Text = "Rechts", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelFlexbox
                (
                    new ControlText() { Text = "Erster Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zweiter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dritter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) }
                )
                {
                    Layout = TypeLayoutFlexbox.Default,
                    Justify = TypeJustifiedFlexbox.End,
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning)
                },
                new ControlText() { Text = "Zentriert", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelFlexbox
                (
                    new ControlText() { Text = "Erster Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zweiter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dritter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) }
                )
                {
                    Layout = TypeLayoutFlexbox.Default,
                    Justify = TypeJustifiedFlexbox.Center,
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning)
                },
                new ControlText() { Text = "Between", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelFlexbox
                (
                    new ControlText() { Text = "Erster Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zweiter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dritter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) }
                )
                {
                    Layout = TypeLayoutFlexbox.Default,
                    Justify = TypeJustifiedFlexbox.Between,
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning)
                },
                new ControlText() { Text = "Around", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelFlexbox
                (
                    new ControlText() { Text = "Erster Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zweiter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dritter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) }
                )
                {
                    Layout = TypeLayoutFlexbox.Default,
                    Justify = TypeJustifiedFlexbox.Around,
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning)
                }
                
            );

            AddProperty
            (
                "Align",
                "Legt die vertikale Ausrichtung der Items fest.",
                "Align = TypeAlignFlexbox.Start",
                new ControlText() { Text = "Ohne", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelFlexbox
                (
                    new ControlText() { Text = "Erster Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zweiter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dritter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) }
                )
                {
                    Layout = TypeLayoutFlexbox.Default,
                    Align = TypeAlignFlexbox.None,
                    Styles = new System.Collections.Generic.List<string>(new[] { "height: 100px" }),
                    Border = new PropertyBorder(true),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning)
                },
                new ControlText() { Text = "Oben", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelFlexbox
                (
                    new ControlText() { Text = "Erster Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zweiter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dritter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) }
                )
                {
                    Layout = TypeLayoutFlexbox.Default,
                    Align = TypeAlignFlexbox.Start,
                    Styles = new System.Collections.Generic.List<string>(new[] { "height: 100px" }),
                    Border = new PropertyBorder(true),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning)
                },
                new ControlText() { Text = "Unten", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelFlexbox
                (
                    new ControlText() { Text = "Erster Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zweiter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dritter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) }
                )
                {
                    Layout = TypeLayoutFlexbox.Default,
                    Align = TypeAlignFlexbox.End,
                    Styles = new System.Collections.Generic.List<string>(new[] { "height: 100px" }),
                    Border = new PropertyBorder(true),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning)
                },
                new ControlText() { Text = "Zentriert", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelFlexbox
                (
                    new ControlText() { Text = "Erster Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zweiter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dritter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) }
                )
                {
                    Layout = TypeLayoutFlexbox.Default,
                    Align = TypeAlignFlexbox.Center,
                    Styles = new System.Collections.Generic.List<string>(new[] { "height: 100px" }),
                    Border = new PropertyBorder(true),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning)
                },
                new ControlText() { Text = "Baseline", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelFlexbox
                (
                    new ControlText() { Text = "Erster Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zweiter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dritter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) }
                )
                {
                    Layout = TypeLayoutFlexbox.Default,
                    Align = TypeAlignFlexbox.Baseline,
                    Styles = new System.Collections.Generic.List<string>(new[] { "height: 100px" }),
                    Border = new PropertyBorder(true),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning)
                },
                new ControlText() { Text = "Gestreckt", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelFlexbox
                (
                    new ControlText() { Text = "Erster Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zweiter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dritter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) }
                )
                {
                    Layout = TypeLayoutFlexbox.Default,
                    Align = TypeAlignFlexbox.Stretch,
                    Styles = new System.Collections.Generic.List<string>(new[] { "height: 100px" }),
                    Border = new PropertyBorder(true),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning)
                }

            ); 
            
            AddProperty
            (
                "Wrap",
                "Bestimmt das Überlaufverhalten der Items.",
                "Align = TypeAlignFlexbox.Start",
                new ControlText() { Text = "Ohne", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelFlexbox
                (
                    new ControlText() { Text = "Erster Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zweiter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dritter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Vierter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Fünfter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Sechster Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Siebenter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Achter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Neunter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zenhnter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Elfter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zwölfter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dreizehnter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Vierzenhnter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Fünfzehnter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) }
                )
                {
                    Layout = TypeLayoutFlexbox.Default,
                    Wrap = TypeWrap.None,
                    //Styles = new System.Collections.Generic.List<string>(new[] { "height: 100px" }),
                    Border = new PropertyBorder(true),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning)
                },
                new ControlText() { Text = "Nowrap", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelFlexbox
                (
new ControlText() { Text = "Erster Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zweiter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dritter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Vierter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Fünfter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Sechster Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Siebenter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Achter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Neunter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zenhnter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Elfter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zwölfter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dreizehnter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Vierzenhnter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Fünfzehnter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) })
                {
                    Layout = TypeLayoutFlexbox.Default,
                    Wrap = TypeWrap.Nowrap,
                    //Styles = new System.Collections.Generic.List<string>(new[] { "height: 100px" }),
                    Border = new PropertyBorder(true),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning)
                },
                new ControlText() { Text = "Oben", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelFlexbox
                (
new ControlText() { Text = "Erster Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zweiter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dritter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Vierter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Fünfter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Sechster Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Siebenter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Achter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Neunter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zenhnter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Elfter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zwölfter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dreizehnter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Vierzenhnter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Fünfzehnter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) })
                {
                    Layout = TypeLayoutFlexbox.Default,
                    Wrap = TypeWrap.Wrap,
                    //Styles = new System.Collections.Generic.List<string>(new[] { "height: 100px" }),
                    Border = new PropertyBorder(true),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning)
                },
                new ControlText() { Text = "Unten", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelFlexbox
                (
new ControlText() { Text = "Erster Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zweiter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dritter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Vierter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Fünfter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Sechster Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Siebenter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Achter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Neunter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zenhnter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Elfter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zwölfter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dreizehnter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Vierzenhnter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Fünfzehnter Einrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) })
                {
                    Layout = TypeLayoutFlexbox.Default,
                    Wrap = TypeWrap.Reverse,
                    //Styles = new System.Collections.Generic.List<string>(new[] { "height: 100px" }),
                    Border = new PropertyBorder(true),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning)
                }
            );
        }
    }
}
