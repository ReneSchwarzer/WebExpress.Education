﻿using WebExpress.Html;
using WebExpress.UI.Controls;

namespace Education.Pages
{
    public class PageHelp : PageBase
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageHelp()
            : base("Hilfe")
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        public override void Init()
        {
            base.Init();
        }

        /// <summary>
        /// Verarbeitung
        /// </summary>
        public override void Process()
        {
            base.Process();

            Main.Content.Add(new ControlImage(this)
            {
                Source = Uri.Root.Append("Assets/StoreLogo.png"),
                Width = 200,
                Height = 200,
                HorizontalAlignment = TypesHorizontalAlignment.Right
            });
            
            Main.Content.Add(new ControlText(this)
            {
                Text = "WebExpressEducation",
                Format = TypesTextFormat.H1
            });

            Main.Content.Add(new ControlText(this)
            {
                Text = "Einführung in die Nutzung und Entwicklung mit WebExpress.",
                Format = TypesTextFormat.Paragraph
            });

            Main.Content.Add(new ControlText(this)
            {
                Text = "Die Software stellt Informationen und Ressourcen bereit, welche zum Verständnis und zu Erlernung von WebExpress beitragen.",
                Format = TypesTextFormat.Paragraph
            });

            Main.Content.Add(new ControlText(this)
            {
                Text = "Datenschutzrichtlinie",
                Format = TypesTextFormat.H4
            });

            Main.Content.Add(new ControlText(this)
            {
                Text = "Die während der Nutzung eingegebenen Daten werden lokal auf Ihrem Gerät gespeichert. Sie behalten jederzeit die Datenhoheit. Die Daten werden zu keiner Zeit an Dritte übermittelt. Persönliche Informationen und Standortinformationen werden nicht erhoben.",
                Format = TypesTextFormat.Paragraph
            });

            Main.Content.Add(new ControlText(this)
            {
                Text = "Haftungsausschluss",
                Format = TypesTextFormat.H4
            });

            Main.Content.Add(new ControlText(this)
            {
                Text = "Die Haftung für Schäden durch Sachmängel wird ausgeschlossen. Die Haftung auf Schadensersatz wegen Körperverletzung sowie bei grober Fahrlässigkeit oder Vorsatz bleibt unberührt.",
                Format = TypesTextFormat.Paragraph
            });

            Main.Content.Add(new ControlText(this)
            {
                Text = "Informationen über WebExpressEducation",
                Format = TypesTextFormat.H1
            });

            Main.Content.Add
            (
                new ControlPanelCenter
                (
                    this,

                    new ControlText(this)
                    {
                        Text = string.Format("Version"),
                        TextColor = new PropertyColorText(TypeColorText.Primary)
                    },
                    new ControlText(this)
                    {
                        Text = string.Format("{0}", Context.Version),
                        TextColor = new PropertyColorText(TypeColorText.Dark)
                    },
                    new ControlText(this)
                    {
                        Text = string.Format("Kontakt"),
                        TextColor = new PropertyColorText(TypeColorText.Primary)
                    },
                    new ControlLink(this)
                    {
                        Text = string.Format("rene_schwarzer@hotmail.de"),
                        Uri = new UriAbsolute()
                        {
                            Scheme = UriScheme.Mailto,
                            Authority = new UriAuthority("rene_schwarzer@hotmail.de")
                        },
                        Color = TypeColorText.Dark
                    }
                )
            );
        }
    }
}
