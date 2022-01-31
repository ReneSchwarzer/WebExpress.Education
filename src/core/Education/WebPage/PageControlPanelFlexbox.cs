using WebExpress.UI.WebControl;
using WebExpress.WebAttribute;
using WebExpress.WebResource;

namespace Education.WebPage
{
    [ID("Flexbox")]
    [Title("education:page.control.flexbox.name")]
    [Segment("flexbox", "education:page.control.flexbox.name")]
    [Path("/Control")]
    [Module("edu")]
    [Context("control")]
    public sealed class PageControlPanelFlexbox : PageControlBase
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlPanelFlexbox()
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        /// <param name="context">Der Kontext</param>
        public override void Initialization(IResourceContext context)
        {
            base.Initialization(context);

            Description = "Das ControlPanelFlexbox stellt eine ... bereit.";
            Code = "new ControlPanelFlexbox";
            Code += "(";
            Code += "    new ControlText() { Text = \"Erster Eintrag\", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two) },";
            Code += "    new ControlText() { Text = \"Zweiter Eintrag\", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two) },";
            Code += "    new ControlText() { Text = \"Dritter Eintrag\", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two) }";
            Code += ")";

            AddExample
            (
                new ControlPanelFlexbox
                (
                    new ControlText() { Text = "Erster Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zweiter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dritter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) }
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
                    new ControlText() { Text = "Erster Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zweiter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dritter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) }
                )
                {
                    Layout = TypeLayoutFlexbox.None,
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning)
                },
                new ControlText() { Text = "Standard", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelFlexbox
                (
                    new ControlText() { Text = "Erster Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zweiter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dritter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) }
                )
                {
                    Layout = TypeLayoutFlexbox.Default,
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning)
                },
                new ControlText() { Text = "Inline", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelFlexbox
                (
                    new ControlText() { Text = "Erster Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zweiter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dritter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) }
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
                    new ControlText() { Text = "Erster Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zweiter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dritter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) }
                )
                {
                    Layout = TypeLayoutFlexbox.Default,
                    Justify = TypeJustifiedFlexbox.None,
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning)
                },
                new ControlText() { Text = "Links", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelFlexbox
                (
                    new ControlText() { Text = "Erster Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zweiter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dritter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) }
                )
                {
                    Layout = TypeLayoutFlexbox.Default,
                    Justify = TypeJustifiedFlexbox.Start,
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning)
                },
                new ControlText() { Text = "Rechts", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelFlexbox
                (
                    new ControlText() { Text = "Erster Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zweiter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dritter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) }
                )
                {
                    Layout = TypeLayoutFlexbox.Default,
                    Justify = TypeJustifiedFlexbox.End,
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning)
                },
                new ControlText() { Text = "Zentriert", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelFlexbox
                (
                    new ControlText() { Text = "Erster Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zweiter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dritter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) }
                )
                {
                    Layout = TypeLayoutFlexbox.Default,
                    Justify = TypeJustifiedFlexbox.Center,
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning)
                },
                new ControlText() { Text = "Between", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelFlexbox
                (
                    new ControlText() { Text = "Erster Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zweiter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dritter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) }
                )
                {
                    Layout = TypeLayoutFlexbox.Default,
                    Justify = TypeJustifiedFlexbox.Between,
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Warning)
                },
                new ControlText() { Text = "Around", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlPanelFlexbox
                (
                    new ControlText() { Text = "Erster Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zweiter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dritter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) }
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
                    new ControlText() { Text = "Erster Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zweiter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dritter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) }
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
                    new ControlText() { Text = "Erster Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zweiter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dritter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) }
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
                    new ControlText() { Text = "Erster Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zweiter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dritter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) }
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
                    new ControlText() { Text = "Erster Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zweiter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dritter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) }
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
                    new ControlText() { Text = "Erster Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zweiter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dritter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) }
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
                    new ControlText() { Text = "Erster Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zweiter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dritter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) }
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
                    new ControlText() { Text = "Erster Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zweiter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dritter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Vierter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Fünfter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Sechster Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Siebenter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Achter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Neunter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zenhnter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Elfter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zwölfter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dreizehnter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Vierzenhnter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Fünfzehnter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) }
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
new ControlText() { Text = "Erster Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zweiter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dritter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Vierter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Fünfter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Sechster Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Siebenter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Achter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Neunter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zenhnter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Elfter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zwölfter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dreizehnter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Vierzenhnter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Fünfzehnter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) })
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
new ControlText() { Text = "Erster Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zweiter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dritter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Vierter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Fünfter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Sechster Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Siebenter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Achter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Neunter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zenhnter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Elfter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zwölfter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dreizehnter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Vierzenhnter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Fünfzehnter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) })
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
new ControlText() { Text = "Erster Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zweiter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dritter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Vierter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Fünfter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Sechster Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Siebenter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Achter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Neunter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zenhnter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Elfter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Zwölfter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Dreizehnter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Vierzenhnter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) },
                    new ControlText() { Text = "Fünfzehnter Eintrag", Format = TypeFormatText.Default, Border = new PropertyBorder(true), Padding = new PropertySpacingPadding(PropertySpacing.Space.Two), BackgroundColor = new PropertyColorBackground(TypeColorBackground.Light) })
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
