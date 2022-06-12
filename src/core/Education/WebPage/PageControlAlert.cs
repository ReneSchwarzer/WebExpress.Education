using WebExpress.UI.WebControl;
using WebExpress.WebAttribute;
using WebExpress.WebResource;

namespace Education.WebPage
{
    /// <summary>
    /// Control zur visuellen Darstellung eines Alarms
    /// </summary>
    [Id("Alert")]
    [Title("education:page.control.alert.name")]
    [Segment("alert", "education:page.control.alert.name")]
    [Path("/Control")]
    [Module("edu")]
    [Context("control")]
    public sealed class PageControlAlert : PageControlBase
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlAlert()
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        /// <param name="context">Der Kontext</param>
        public override void Initialization(IResourceContext context)
        {
            base.Initialization(context);

            Description = "Das ControlAlert kann zum Anzeigen eines Alarmes (z.B. bei Fehleingaben) eingesetzt werden.";
            Code = "new ControlAlert() { Text = \"Dies ist ein Alarm\", Dismissible = TypesDismissibleAlert.Dismissible, Fade = TypesFade.FadeShow, BackgroundColor = new PropertyColorBackground(TypesBackgroundColor.Success) }";

            AddExample(new ControlAlert()
            {
                Text = "Dies ist ein Beispiel-Alarm!",
                Dismissible = TypeDismissibleAlert.Dismissible,
                Fade = TypeFade.FadeShow,
                BackgroundColor = new PropertyColorBackgroundAlert(TypeColorBackground.Info)
            });

            AddProperty
            (
                "TextColor",
                "Setzt die Textfarbe des Alarms.",
                "TextColor = new PropertyColorText(TypeColorText.Warning)",
                new ControlAlert()
                {
                    Text = "Dies ist ein Alarm mit Warn-Textfarbe!",
                    Dismissible = TypeDismissibleAlert.Dismissible,
                    Fade = TypeFade.FadeShow,
                    BackgroundColor = new PropertyColorBackgroundAlert(TypeColorBackground.Success),
                    TextColor = new PropertyColorText(TypeColorText.Warning)
                }
            );

            AddProperty
            (
                "BackgroundColor",
                "Setzt die Hintergrundfarbe des Alarms.",
                "BackgroundColor = new PropertyColorBackgroundAlert(TypeColorBackground.Primary)",
                new ControlAlert()
                {
                    Text = "Dies ist ein Standard-Alarm!",
                    Dismissible = TypeDismissibleAlert.Dismissible,
                    Fade = TypeFade.FadeShow
                },
                new ControlAlert()
                {
                    Text = "Dies ist ein Primär-Alarm!",
                    Dismissible = TypeDismissibleAlert.Dismissible,
                    Fade = TypeFade.FadeShow,
                    BackgroundColor = new PropertyColorBackgroundAlert(TypeColorBackground.Primary)
                },
                new ControlAlert()
                {
                    Text = "Dies ist ein Sekundär-Alarm!",
                    Dismissible = TypeDismissibleAlert.Dismissible,
                    Fade = TypeFade.FadeShow,
                    BackgroundColor = new PropertyColorBackgroundAlert(TypeColorBackground.Secondary)
                },
                new ControlAlert()
                {
                    Text = "Dies ist ein Info-Alarm!",
                    Dismissible = TypeDismissibleAlert.Dismissible,
                    Fade = TypeFade.FadeShow,
                    BackgroundColor = new PropertyColorBackgroundAlert(TypeColorBackground.Info)
                },
                new ControlAlert()
                {
                    Text = "Dies ist ein Erfolgs-Alarm!",
                    Dismissible = TypeDismissibleAlert.Dismissible,
                    Fade = TypeFade.FadeShow,
                    BackgroundColor = new PropertyColorBackgroundAlert(TypeColorBackground.Success)
                },
                new ControlAlert()
                {
                    Text = "Dies ist ein Warnungs-Alarm!",
                    Dismissible = TypeDismissibleAlert.Dismissible,
                    Fade = TypeFade.FadeShow,
                    BackgroundColor = new PropertyColorBackgroundAlert(TypeColorBackground.Warning)
                },
                new ControlAlert()
                {
                    Text = "Dies ist ein Fehler-Alarm!",
                    Dismissible = TypeDismissibleAlert.Dismissible,
                    Fade = TypeFade.FadeShow,
                    BackgroundColor = new PropertyColorBackgroundAlert(TypeColorBackground.Danger)
                },
                new ControlAlert()
                {
                    Text = "Dies ist ein dunkler Alarm!",
                    Dismissible = TypeDismissibleAlert.Dismissible,
                    Fade = TypeFade.FadeShow,
                    BackgroundColor = new PropertyColorBackgroundAlert(TypeColorBackground.Dark)
                },
                new ControlAlert()
                {
                    Text = "Dies ist ein heller Alarm!",
                    Dismissible = TypeDismissibleAlert.Dismissible,
                    Fade = TypeFade.FadeShow,
                    BackgroundColor = new PropertyColorBackgroundAlert(TypeColorBackground.Light)
                },
                new ControlAlert()
                {
                    Text = "Dies ist ein weißer Alarm!",
                    Dismissible = TypeDismissibleAlert.Dismissible,
                    Fade = TypeFade.FadeShow,
                    BackgroundColor = new PropertyColorBackgroundAlert(TypeColorBackground.White)
                },
                new ControlAlert()
                {
                    Text = "Dies ist ein transparenter Alarm!",
                    Dismissible = TypeDismissibleAlert.Dismissible,
                    Fade = TypeFade.FadeShow,
                    BackgroundColor = new PropertyColorBackgroundAlert(TypeColorBackground.Transparent)
                },
                new ControlAlert()
                {
                    Text = "Dies ist ein benutzerdefinierter Alarm!",
                    Dismissible = TypeDismissibleAlert.Dismissible,
                    Fade = TypeFade.FadeShow,
                    TextColor = new PropertyColorText("red"),
                    BackgroundColor = new PropertyColorBackgroundAlert("gold")
                }
            );

            AddProperty
            (
                "Dismissible",
                "Bestimmt ob Control vom Benutzer geschlossen (ausgeblendet) werden kann.",
                "Dismissible = TypeDismissibleAlert.Dismissible"
                , new ControlAlert()
                {
                    Text = "Dies ist ein Erfolgs-Alarm, welcher nicht ausblendet werden kann.",
                    Dismissible = TypeDismissibleAlert.None,
                    Fade = TypeFade.FadeShow,
                    BackgroundColor = new PropertyColorBackgroundAlert(TypeColorBackground.Success)
                }, new ControlAlert()
                {
                    Text = "Dies ist ein Erfolgs-Alarm, welcher ausblendet werden kann.",
                    Dismissible = TypeDismissibleAlert.Dismissible,
                    Fade = TypeFade.FadeShow,
                    BackgroundColor = new PropertyColorBackgroundAlert(TypeColorBackground.Success)
                }
            );

            AddProperty
            (
                "Fade",
                "Bestimmt welcher Fadereffekt verwendet werden soll",
                "Fade = TypeFade.FadeShow",
                new ControlAlert()
                {
                    Text = "Dies ist ein Erfolgs-Alarm, welcher nicht animiert ist.",
                    Dismissible = TypeDismissibleAlert.Dismissible,
                    Fade = TypeFade.None,
                    BackgroundColor = new PropertyColorBackgroundAlert(TypeColorBackground.Success)
                },
                new ControlAlert()
                {
                    Text = "Dies ist ein Erfolgs-Alarm, welcher vollständig animiert ist.",
                    Dismissible = TypeDismissibleAlert.Dismissible,
                    Fade = TypeFade.FadeShow,
                    BackgroundColor = new PropertyColorBackgroundAlert(TypeColorBackground.Success)
                }
            );
        }
    }
}
