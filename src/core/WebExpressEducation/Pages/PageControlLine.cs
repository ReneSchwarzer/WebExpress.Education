using WebExpress.UI.Controls;

namespace Education.Pages
{
    public class PageControlLine : PageControlBase
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlLine()
            : base("ControlLine")
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        public override void Init()
        {
            base.Init();

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

        /// <summary>
        /// Verarbeitung
        /// </summary>
        public override void Process()
        {
            base.Process();
        }
    }
}
