using WebExpress.Html;
using WebExpress.Messages;
using WebExpress.UI.Controls;

namespace Education.Pages
{
    public class PageControlToolBar : PageControlBase
    {
        private IControlToolBarItem item1 = new ControlToolBarItemButton() { Text = "Erster Eintrag", Icon = new PropertyIcon(TypeIcon.Plus) };
        private IControlToolBarItem item2 = new ControlToolBarItemButton() { Text = "Zweiter Eintrag", Icon = new PropertyIcon(TypeIcon.Edit) };
        private IControlToolBarItem item3 = new ControlToolBarItemSeperator();
        private IControlToolBarItem item4 = new ControlToolBarItemButton() { Text = "Dritter Eintrag", Icon = new PropertyIcon(TypeIcon.Trash) };

        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlToolBar()
            : base("ControlToolBar")
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        public override void Init()
        {
            base.Init();

            Description = "Das ControlToolBar sellt Links in einem Navigationssteuerelement dar.";
            Code = "new ControlToolBar() {  }";

            AddExample
            (
                new ControlToolbar(item1, item2, item3, item4)
                {
                    
                }
            );

            // Eigenschaften
            AddProperty
            (
                "Active",
                "Setzt den Aktivitätsstatus innerhalb des Links.",
                "Active = TypesActive.Active",
                new ControlToolbar(item1, item2, item3, item4)
                {
                }
            );

            AddProperty
            (
                "HorizontalAlignment",
                "Setzt die horizontale Ausrichtung des Navigationssteuerelementes.",
                "Active = TypeActive.Active",
                new ControlText() { Text = "Default", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlToolbar(item1, item2, item3, item4)
                {
                    HorizontalAlignment = TypeHorizontalAlignment.Default                    
                },
                new ControlText() { Text = "Left", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlToolbar(item1, item2, item3, item4)
                {
                    HorizontalAlignment = TypeHorizontalAlignment.Left
                },
                new ControlText() { Text = "Right", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlToolbar(item1, item2, item3, item4)
                {
                    HorizontalAlignment = TypeHorizontalAlignment.Right
                }
            );
            
            AddProperty
            (
                "Orientation",
                "Setzt die Orientierung des Navigationssteuerelementes.",
                "Orientation = TypeNavOrientation.Vertical",
                new ControlText() { Text = "Default", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlToolbar(item1, item2, item3, item4)
                {
                    Orientation = TypeOrientationToolBar.Default 
                },
                new ControlText() { Text = "Horizontal", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlToolbar(item1, item2, item3, item4)
                {
                    Orientation = TypeOrientationToolBar.Horizontal
                },
                new ControlText() { Text = "Vertical", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlToolbar(item1, item2, item3, item4)
                {
                    Orientation = TypeOrientationToolBar.Vertical
                }
            ); 
            
            AddProperty
            (
                "Justified",
                "Bestimmt, ob die Links die gleiche Größe besitzen sollen.",
                "Justified = TypeNavJustified.Justified",
                new ControlText() { Text = "Default", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlToolbar(item1, item2, item3, item4)
                {
                    //Justified = TypeJustifiedTab.Default
                },
                new ControlText() { Text = "Justified", TextColor = new PropertyColorText(TypeColorText.Info) },
                new ControlToolbar(item1, item2, item3, item4)
                {
                    //Justified = TypeJustifiedTab.Justified
                }
            );

        }
    }
}
