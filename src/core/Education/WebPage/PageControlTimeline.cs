using System;
using WebExpress.UI.WebControl;
using WebExpress.WebAttribute;
using WebExpress.WebResource;

namespace Education.WebPage
{
    [ID("Timeline")]
    [Title("education:page.control.timeline.name")]
    [Segment("timeline", "education:page.control.timeline.name")]
    [Path("/Control")]
    [Module("edu")]
    [Context("control")]
    public sealed class PageControlTimeline : PageControlBase
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlTimeline()
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        /// <param name="context">Der Kontext</param>
        public override void Initialization(IResourceContext context)
        {
            base.Initialization(context);

            var item1 = new ControlTimelineItem()
            {
                Name = "item1",
                User = "René Schwarzer",
                Action = "Erstellt",
                Timestamp = DateTime.Now,
                Post = "Hallo Welt"
            };

            var item2 = new ControlTimelineItem()
            {
                Name = "item2",
                User = "Philip J. Fry",
                //Image = Uri.Root.Append("/Asserts/img/PhilipFry.jpg"),
                Action = "Geändert",
                Timestamp = DateTime.Now.AddDays(-3),
                Post = "Leela, ich hab einen Plan!",
                Likes = 5
            };

            item2.Comments.Add(new ControlTimelineComment()
            {
                User = "Turanga Leela",
                //Image = Uri.Root.Append("/Asserts/img/TurangaLeela.jpg"),
                Timestamp = DateTime.Now.AddMinutes(-24),
                Post = "Ich habe einen besseren Plan.",
                Likes = 1
            });

            item2.Comments.Add(new ControlTimelineComment()
            {
                User = "Turanga Leela",
                //Image = Uri.Root.Append("/Asserts/img/TurangaLeela.jpg"),
                Timestamp = DateTime.Now.AddMinutes(-10),
                Post = "Fry, du vergeudest dein Leben, wenn du immer nur vor dem Fernseher hockst. Geh vor die Tür und sieh dir die echte Welt an.",
            });

            item2.Comments.Add(new ControlTimelineComment()
            {
                User = "Philip J. Fry",
                //Image = Uri.Root.Append("/Asserts/img/PhilipFry.jpg"),
                Timestamp = DateTime.Now.AddMinutes(-1),
                Post = "Aber der Apparat hat <b>HDTV</b>, der hat einne viel bessere Auflösung als die echte Welt!",
            });


            var timeline = new ControlTimeline(item2, item1) { };

            Description = "ControlTimeline ";
            Code = "new ControlTimeline() { }";

            AddExample
            (
                timeline
            );

            // Eigenschaften

        }
    }
}
