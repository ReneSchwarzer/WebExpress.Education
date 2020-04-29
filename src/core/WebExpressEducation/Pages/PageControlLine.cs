using WebExpress.UI.Controls;

namespace Education.Pages
{
    public class PageControlLine : PageControlBase
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlLine()
            : base("PageControlLine")
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        public override void Init()
        {
            base.Init();

            Description = "Das PageControlLine zerlegt den Uri-Pfad, so dass diese seperat aufgerufen werden können.";
            Code = "new PageControlLine(Page) { }";

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
                new ControlLine(this)
                {
                    Color = new PropertyColorLine(TypeColorLine.Default)
                },
                new ControlLine(this)
                {
                    Color = new PropertyColorLine(TypeColorLine.Primary)
                },
                new ControlLine(this)
                {
                    Color = new PropertyColorLine(TypeColorLine.Secondary)
                },
                new ControlLine(this)
                {
                    Color = new PropertyColorLine(TypeColorLine.Info)
                },
                new ControlLine(this)
                {
                    Color = new PropertyColorLine(TypeColorLine.Success)
                },
                new ControlLine(this)
                {
                    Color = new PropertyColorLine(TypeColorLine.Warning)
                },
                new ControlLine(this)
                {
                    Color = new PropertyColorLine(TypeColorLine.Danger)
                },
                new ControlLine(this)
                {
                    Color = new PropertyColorLine(TypeColorLine.Dark)
                },
                new ControlLine(this)
                {
                    Color = new PropertyColorLine(TypeColorLine.Light)
                },
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
