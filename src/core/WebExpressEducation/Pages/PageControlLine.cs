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
            Code = "new ControlLine(Page) { }";

            AddExample
            (
                new ControlLine(this)
                {
                }
            );

            // Eigenschaften
            AddProperty
            (
                "Color",
                "Legt die Farbe fest.",
                "Color = new PropertyColorLine(TypeColorLine.Primary)",
                new ControlText(this) { Text = "Standard", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlLine(this)
                {
                    Color = new PropertyColorLine(TypeColorLine.Default)
                },
                new ControlText(this) { Text = "Primär", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlLine(this)
                {
                    Color = new PropertyColorLine(TypeColorLine.Primary)
                },
                new ControlText(this) { Text = "Sekundär", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlLine(this)
                {
                    Color = new PropertyColorLine(TypeColorLine.Secondary)
                },
                new ControlText(this) { Text = "Info", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlLine(this)
                {
                    Color = new PropertyColorLine(TypeColorLine.Info)
                },
                new ControlText(this) { Text = "Erfolg", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlLine(this)
                {
                    Color = new PropertyColorLine(TypeColorLine.Success)
                },
                new ControlText(this) { Text = "Warnung", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlLine(this)
                {
                    Color = new PropertyColorLine(TypeColorLine.Warning)
                },
                new ControlText(this) { Text = "Fehler", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlLine(this)
                {
                    Color = new PropertyColorLine(TypeColorLine.Danger)
                },
                new ControlText(this) { Text = "Dunkel", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlLine(this)
                {
                    Color = new PropertyColorLine(TypeColorLine.Dark)
                },
                new ControlText(this) { Text = "Hell", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlLine(this)
                {
                    Color = new PropertyColorLine(TypeColorLine.Light)
                },
                new ControlText(this) { Text = "Benutzerdefiniert", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlLine(this)
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
