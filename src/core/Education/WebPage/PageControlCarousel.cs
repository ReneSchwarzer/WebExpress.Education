using WebExpress.UI.WebControl;
using WebExpress.WebAttribute;
using WebExpress.WebResource;

namespace Education.WebPage
{
    /// <summary>
    /// Control zur visuellen Darstellung eines Bilderkarussells
    /// </summary>
    [ID("Carousel")]
    [Title("education:page.control.carousel.name")]
    [Segment("carousel", "education:page.control.carousel.name")]
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
        /// <param name="context">Der Kontext</param>
        public override void Initialization(IResourceContext context)
        {
            base.Initialization(context);

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
