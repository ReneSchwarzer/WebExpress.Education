using WebExpress.UI.WebControl;
using WebExpress.Uri;
using WebExpress.WebApp.WebPage;
using WebExpress.WebAttribute;
using WebExpress.WebPlugin;
using WebExpress.WebResource;

namespace Education.WebPage
{
    [ID("Help")]
    [Title("education:page.help.name")]
    [Segment("help", "education:page.help.name")]
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
        /// <param name="context">Der Kontext</param>
        public override void Initialization(IResourceContext context)
        {
            base.Initialization(context);
        }

        /// <summary>
        /// Verarbeitung
        /// </summary>
        /// <param name="context">Der Kontext zum Rendern der Seite</param>
        public override void Process(RenderContextWebApp context)
        {
            base.Process(context);

            var version = PluginManager.GetPlugin(Context.Application.Plugin.PluginID)?.Version;

            context.VisualTree.Content.Primary.Add(new ControlImage()
            {
                Uri = context.Uri.Root.Append("Assets/StoreLogo.png"),
                Width = 200,
                Height = 200,
                HorizontalAlignment = TypeHorizontalAlignment.Right
            });

            context.VisualTree.Content.Primary.Add(new ControlText()
            {
                Text = "WebExpressEducation",
                Format = TypeFormatText.H1
            });

            context.VisualTree.Content.Primary.Add(new ControlText()
            {
                Text = "Einführung in die Nutzung und Entwicklung mit WebExpress.",
                Format = TypeFormatText.Paragraph
            });

            context.VisualTree.Content.Primary.Add(new ControlText()
            {
                Text = "Die Software stellt Informationen und Ressourcen bereit, welche zum Verständnis und zu Erlernung von WebExpress beitragen.",
                Format = TypeFormatText.Paragraph
            });

            context.VisualTree.Content.Primary.Add(new ControlText()
            {
                Text = "Datenschutzrichtlinie",
                Format = TypeFormatText.H4
            });

            context.VisualTree.Content.Primary.Add(new ControlText()
            {
                Text = "Die während der Nutzung eingegebenen Daten werden lokal auf Ihrem Gerät gespeichert. Sie behalten jederzeit die Datenhoheit. Die Daten werden zu keiner Zeit an Dritte übermittelt. Persönliche Informationen und Standortinformationen werden nicht erhoben.",
                Format = TypeFormatText.Paragraph
            });

            context.VisualTree.Content.Primary.Add(new ControlText()
            {
                Text = "Haftungsausschluss",
                Format = TypeFormatText.H4
            });

            context.VisualTree.Content.Primary.Add(new ControlText()
            {
                Text = "Die Haftung für Schäden durch Sachmängel wird ausgeschlossen. Die Haftung auf Schadensersatz wegen Körperverletzung sowie bei grober Fahrlässigkeit oder Vorsatz bleibt unberührt.",
                Format = TypeFormatText.Paragraph
            });

            context.VisualTree.Content.Primary.Add(new ControlText()
            {
                Text = "Informationen über WebExpressEducation",
                Format = TypeFormatText.H1
            });

            context.VisualTree.Content.Primary.Add
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
