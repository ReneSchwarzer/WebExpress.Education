using WebExpress.Attribute;
using WebExpress.Module;
using WebExpress.Plugin;
using WebExpress.UI.WebControl;
using WebExpress.Uri;

namespace Education.WebResource
{
    [ID("Help")]
    [Title("page.help.name")]
    [Segment("help", "page.help.name")]
    [Path("/")]
    [Module("edu")]
    [Context("help")]
    public sealed class PageHelp : PageBase
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageHelp()
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        public override void Initialization()
        {
            base.Initialization();
        }

        /// <summary>
        /// Verarbeitung
        /// </summary>
        public override void Process()
        {
            base.Process();

            var version = PluginManager.GetPlugin(Context.PluginID)?.Version;

            Content.Content.Add(new ControlImage()
            {
                Uri = Uri.Root.Append("Assets/StoreLogo.png"),
                Width = 200,
                Height = 200,
                HorizontalAlignment = TypeHorizontalAlignment.Right
            });

            Content.Content.Add(new ControlText()
            {
                Text = "WebExpressEducation",
                Format = TypeFormatText.H1
            });

            Content.Content.Add(new ControlText()
            {
                Text = "Einführung in die Nutzung und Entwicklung mit WebExpress.",
                Format = TypeFormatText.Paragraph
            });

            Content.Content.Add(new ControlText()
            {
                Text = "Die Software stellt Informationen und Ressourcen bereit, welche zum Verständnis und zu Erlernung von WebExpress beitragen.",
                Format = TypeFormatText.Paragraph
            });

            Content.Content.Add(new ControlText()
            {
                Text = "Datenschutzrichtlinie",
                Format = TypeFormatText.H4
            });

            Content.Content.Add(new ControlText()
            {
                Text = "Die während der Nutzung eingegebenen Daten werden lokal auf Ihrem Gerät gespeichert. Sie behalten jederzeit die Datenhoheit. Die Daten werden zu keiner Zeit an Dritte übermittelt. Persönliche Informationen und Standortinformationen werden nicht erhoben.",
                Format = TypeFormatText.Paragraph
            });

            Content.Content.Add(new ControlText()
            {
                Text = "Haftungsausschluss",
                Format = TypeFormatText.H4
            });

            Content.Content.Add(new ControlText()
            {
                Text = "Die Haftung für Schäden durch Sachmängel wird ausgeschlossen. Die Haftung auf Schadensersatz wegen Körperverletzung sowie bei grober Fahrlässigkeit oder Vorsatz bleibt unberührt.",
                Format = TypeFormatText.Paragraph
            });

            Content.Content.Add(new ControlText()
            {
                Text = "Informationen über WebExpressEducation",
                Format = TypeFormatText.H1
            });

            Content.Content.Add
            (
                new ControlPanelCenter
                (
                     new ControlText()
                     {
                         Text = string.Format("Version"),
                         TextColor = new PropertyColorText(TypeColorText.Primary)
                     },
                    new ControlText()
                    {
                        Text = string.Format("{0}", version),
                        TextColor = new PropertyColorText(TypeColorText.Dark)
                    },
                    new ControlText()
                    {
                        Text = string.Format("Kontakt"),
                        TextColor = new PropertyColorText(TypeColorText.Primary)
                    },
                    new ControlLink()
                    {
                        Text = string.Format("rene_schwarzer@hotmail.de"),
                        Uri = new UriAbsolute()
                        {
                            Scheme = UriScheme.Mailto,
                            Authority = new UriAuthority("rene_schwarzer@hotmail.de")
                        },
                        TextColor = new PropertyColorText(TypeColorText.Dark)
                    }
                )
            );
        }
    }
}
