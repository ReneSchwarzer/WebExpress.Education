using WebExpress.UI.Controls;

namespace Education.Pages
{
    public class PageControlAlert : PageControlBase
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlAlert()
            : base("ControlAlert")
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        public override void Init()
        {
            base.Init();

            Description = "Das ControlAlert kann zum Anzeigen eines Alarmes (z.B. bei Fehleingaben) eingesetzt werden.";
            Code = "new ControlAlert(Page) { Text = \"Dies ist ein Alarm\", Dismissible = TypesDismissibleAlert.Dismissible, Fade = TypesFade.FadeShow, BackgroundColor = new PropertyColorBackground(TypesBackgroundColor.Success) }";

            AddExample(new ControlAlert(this)
            {
                Text = "Dies ist ein Beispiel-Alarm!",
                Dismissible = TypesDismissibleAlert.Dismissible,
                Fade = TypesFade.FadeShow,
                BackgroundColor = new PropertyColorBackgroundAlert(TypeColorBackground.Info)
            });

            AddProperty("TextColor", new ControlAlert(this)
            {
                Text = "Dies ist ein Alarm mit Warn-Textfarbe!",
                Dismissible = TypesDismissibleAlert.Dismissible,
                Fade = TypesFade.FadeShow,
                BackgroundColor = new PropertyColorBackgroundAlert(TypeColorBackground.Success),
                TextColor = new PropertyColorText(TypeColorText.Warning)
            });

            AddProperty("BackgroundColor", new ControlAlert(this)
            {
                Text = "Dies ist ein Standard-Alarm!",
                Dismissible = TypesDismissibleAlert.Dismissible,
                Fade = TypesFade.FadeShow
            },
            new ControlAlert(this)
            {
                Text = "Dies ist ein Primär-Alarm!",
                Dismissible = TypesDismissibleAlert.Dismissible,
                Fade = TypesFade.FadeShow,
                BackgroundColor = new PropertyColorBackgroundAlert(TypeColorBackground.Primary)
            },
            new ControlAlert(this)
            {
                Text = "Dies ist ein Sekundär-Alarm!",
                Dismissible = TypesDismissibleAlert.Dismissible,
                Fade = TypesFade.FadeShow,
                BackgroundColor = new PropertyColorBackgroundAlert(TypeColorBackground.Secondary)
            },
            new ControlAlert(this)
            {
                Text = "Dies ist ein Info-Alarm!",
                Dismissible = TypesDismissibleAlert.Dismissible,
                Fade = TypesFade.FadeShow,
                BackgroundColor = new PropertyColorBackgroundAlert(TypeColorBackground.Info)
            },
            new ControlAlert(this)
            {
                Text = "Dies ist ein Erfolgs-Alarm!",
                Dismissible = TypesDismissibleAlert.Dismissible,
                Fade = TypesFade.FadeShow,
                BackgroundColor = new PropertyColorBackgroundAlert(TypeColorBackground.Success)
            },
            new ControlAlert(this)
            {
                Text = "Dies ist ein Warnungs-Alarm!",
                Dismissible = TypesDismissibleAlert.Dismissible,
                Fade = TypesFade.FadeShow,
                BackgroundColor = new PropertyColorBackgroundAlert(TypeColorBackground.Warning)
            },
            new ControlAlert(this)
            {
                Text = "Dies ist ein Fehler-Alarm!",
                Dismissible = TypesDismissibleAlert.Dismissible,
                Fade = TypesFade.FadeShow,
                BackgroundColor = new PropertyColorBackgroundAlert(TypeColorBackground.Danger)
            },
            new ControlAlert(this)
            {
                Text = "Dies ist ein dunkler Alarm!",
                Dismissible = TypesDismissibleAlert.Dismissible,
                Fade = TypesFade.FadeShow,
                BackgroundColor = new PropertyColorBackgroundAlert(TypeColorBackground.Dark)
            },
            new ControlAlert(this)
            {
                Text = "Dies ist ein heller Alarm!",
                Dismissible = TypesDismissibleAlert.Dismissible,
                Fade = TypesFade.FadeShow,
                BackgroundColor = new PropertyColorBackgroundAlert(TypeColorBackground.Light)
            },
            new ControlAlert(this)
            {
                Text = "Dies ist ein weißer Alarm!",
                Dismissible = TypesDismissibleAlert.Dismissible,
                Fade = TypesFade.FadeShow,
                BackgroundColor = new PropertyColorBackgroundAlert(TypeColorBackground.White)
            },
            new ControlAlert(this)
            {
                Text = "Dies ist ein transparenter Alarm!",
                Dismissible = TypesDismissibleAlert.Dismissible,
                Fade = TypesFade.FadeShow,
                BackgroundColor = new PropertyColorBackgroundAlert(TypeColorBackground.Transparent)
            },
            new ControlAlert(this)
            {
                Text = "Dies ist ein benutzerdefinierter Alarm!",
                Dismissible = TypesDismissibleAlert.Dismissible,
                Fade = TypesFade.FadeShow,
                TextColor = new PropertyColorText("red"),
                BackgroundColor = new PropertyColorBackgroundAlert("gold")
            });

            AddProperty("Dismissible", new ControlAlert(this)
            {
                Text = "Dies ist ein Erfolgs-Alarm, welcher nicht ausblendet werden kann.",
                Dismissible = TypesDismissibleAlert.None,
                Fade = TypesFade.FadeShow,
                BackgroundColor = new PropertyColorBackgroundAlert(TypeColorBackground.Success)
            }, new ControlAlert(this)
            {
                Text = "Dies ist ein Erfolgs-Alarm, welcher ausblendet werden kann.",
                Dismissible = TypesDismissibleAlert.Dismissible,
                Fade = TypesFade.FadeShow,
                BackgroundColor = new PropertyColorBackgroundAlert(TypeColorBackground.Success)
            });

            AddProperty("Fade", new ControlAlert(this)
            {
                Text = "Dies ist ein Erfolgs-Alarm, welcher nicht animiert ist.",
                Dismissible = TypesDismissibleAlert.Dismissible,
                Fade = TypesFade.None,
                BackgroundColor = new PropertyColorBackgroundAlert(TypeColorBackground.Success)
            },

            //Propertys.Content.Add(new ControlAlert(this)
            //{
            //    Text = "Dies ist ein Erfolgs-Alarm, bei welchem die Einblendung animiert ist.",
            //    Dismissible = TypesDismissibleAlert.Dismissible,
            //    Fade = TypesFade.FadeIn,
            //    BackgroundColor = new PropertyColorBackground(TypesBackgroundColor.Success)
            //});

            //Propertys.Content.Add(new ControlAlert(this)
            //{
            //    Text = "Dies ist ein Erfolgs-Alarm, bei welchem die Ausblendung animiert ist.",
            //    Dismissible = TypesDismissibleAlert.Dismissible,
            //    Fade = TypesFade.FadeOut,
            //    BackgroundColor = new PropertyColorBackground(TypesBackgroundColor.Success)
            //});

            new ControlAlert(this)
            {
                Text = "Dies ist ein Erfolgs-Alarm, welcher vollständig animiert ist.",
                Dismissible = TypesDismissibleAlert.Dismissible,
                Fade = TypesFade.FadeShow,
                BackgroundColor = new PropertyColorBackgroundAlert(TypeColorBackground.Success)
            });
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
