using WebExpress.UI.WebControl;
using WebExpress.WebAttribute;
using WebExpress.WebResource;

namespace Education.WebPage
{
    [ID("Line")]
    [Title("education:page.control.line.name")]
    [Segment("line", "education:page.control.line.name")]
    [Path("/Control")]
    [Module("edu")]
    [Context("control")]
    public sealed class PageControlLine : PageControlBase
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlLine()
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        /// <param name="context">Der Kontext</param>
        public override void Initialization(IResourceContext context)
        {
            base.Initialization(context);

            Description = "Das ControlLine stellt eine Abgrenzung (horizontale Linie) bereit.";
            Code = "new ControlLine() { }";

            AddExample
            (
                new ControlLine()
                {
                }
            );

            // Eigenschaften
            AddProperty
            (
                "Color",
                "Legt die Farbe fest.",
                "Color = new PropertyColorLine(TypeColorLine.Primary)",
                new ControlText() { Text = "Standard", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlLine()
                {
                    Color = new PropertyColorLine(TypeColorLine.Default)
                },
                new ControlText() { Text = "Primär", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlLine()
                {
                    Color = new PropertyColorLine(TypeColorLine.Primary)
                },
                new ControlText() { Text = "Sekundär", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlLine()
                {
                    Color = new PropertyColorLine(TypeColorLine.Secondary)
                },
                new ControlText() { Text = "Info", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlLine()
                {
                    Color = new PropertyColorLine(TypeColorLine.Info)
                },
                new ControlText() { Text = "Erfolg", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlLine()
                {
                    Color = new PropertyColorLine(TypeColorLine.Success)
                },
                new ControlText() { Text = "Warnung", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlLine()
                {
                    Color = new PropertyColorLine(TypeColorLine.Warning)
                },
                new ControlText() { Text = "Fehler", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlLine()
                {
                    Color = new PropertyColorLine(TypeColorLine.Danger)
                },
                new ControlText() { Text = "Dunkel", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlLine()
                {
                    Color = new PropertyColorLine(TypeColorLine.Dark)
                },
                new ControlText() { Text = "Hell", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlLine()
                {
                    Color = new PropertyColorLine(TypeColorLine.Light)
                },
                new ControlText() { Text = "Benutzerdefiniert", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlLine()
                {
                    Color = new PropertyColorLine("gold")
                }
            );
        }
    }
}
