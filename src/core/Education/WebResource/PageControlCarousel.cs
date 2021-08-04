using WebExpress.Attribute;
using WebExpress.Module;
using WebExpress.UI.WebControl;
using WebExpress.Uri;

namespace Education.WebResource
{
    /// <summary>
    /// Control zur visuellen Darstellung eines Bilderkarussells
    /// </summary>
    [ID("Carousel")]
    [Title("page.control.carousel.name")]
    [Segment("carousel", "page.control.Carousel.name")]
    [Path("/Control")]
    [Module("edu")]
    [Context("control")]
    public sealed class PageControlCarousel : PageControlBase
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlCarousel()
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        public override void Initialization()
        {
            base.Initialization();

            Description = "Das ControlCarousel kann zum Anzeigen von Bildern oder anderen Inhalten eingesetzt werden.";
            Code = @"new ControlCarousel
                (
                 new ControlCarouselItem() { Headline = ""Item 1"", Text = ""Text zum Item 1"", Control = new ControlImage() { Uri = Uri.Root.Append(""Assets/img/Carousel1.svg"") } },
                new ControlCarouselItem() { Headline = ""Item 2"", Text = ""Text zum Item 2"", Control = new ControlImage() { Uri = Uri.Root.Append(""Assets/img/Carousel2.svg"") } },
                new ControlCarouselItem() { Headline = ""Item 3"", Text = ""Text zum Item 3"", Control = new ControlImage() { Uri = Uri.Root.Append(""Assets/img/Carousel3.svg"") } }
                ) { }";

            AddExample(new ControlCarousel
            (
                new ControlCarouselItem() { Headline = "Item 1", Text = "Text zum Item 1", Control = new ControlImage() { Uri = Uri.Root.Append("Assets/img/Carousel1.svg") } },
                new ControlCarouselItem() { Headline = "Item 2", Text = "Text zum Item 2", Control = new ControlImage() { Uri = Uri.Root.Append("Assets/img/Carousel2.svg") } },
                new ControlCarouselItem() { Headline = "Item 3", Text = "Text zum Item 3", Control = new ControlImage() { Uri = Uri.Root.Append("Assets/img/Carousel3.svg") } }
            )
            {
            });

            //AddProperty
            //(
            //    "Fade",
            //    "Bestimmt welcher Fadereffekt verwendet werden soll",
            //    "Fade = TypeFade.FadeShow",
            //    new ControlCarousel()
            //    {
                    
            //    },
            //    new ControlCarousel()
            //    {
                    
            //    }
            //);
        }
    }
}
