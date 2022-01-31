using WebExpress.WebApplication;
using WebExpress.WebAttribute;

namespace WebExpress.Education
{
    [ID("education")]
    [Name("app.name")]
    [Description("app.description")]
    [Icon("/assets/img/education.svg")]
    [AssetPath("edu")]
    [DataPath("edu")]
    [ContextPath("/edu")]
    public sealed class Application : IApplication
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public Application()
        {
        }

        /// <summary>
        /// Initialisierung der Anwendung. Hier können z.B. verwaltete Ressourcen geladen werden. 
        /// </summary>
        /// <param name="context">Der Kontext, welcher für die Ausführung des Plugins gilt</param>
        public void Initialization(IApplicationContext context)
        {
        }

        /// <summary>
        /// Wird aufgerufen, wenn die Anwendung mit der Arbeit beginnt. Der Aufruf erfolgt nebenläufig.
        /// </summary>
        public void Run()
        {

        }

        /// <summary>
        /// Freigeben von nicht verwalteten Ressourcen, welche wärend der Verwendung reserviert wurden.
        /// </summary>
        public void Dispose()
        {

        }
    }
}
