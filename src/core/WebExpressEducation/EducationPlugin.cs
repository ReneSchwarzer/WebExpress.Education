using Education.Model;
using Education.Pages;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using WebExpress.Pages;
using WebExpress.Workers;

namespace Education
{
    public class EducationPlugin : WebExpress.Plugins.Plugin
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public EducationPlugin()
            : base("Education", "/Asserts/img/Education.svg")
        {
        }

        /// <summary>
        /// Initialisierung des Prozesszustandes. Hier können z.B. verwaltete Ressourcen geladen werden. 
        /// </summary>
        /// <param name="configFileName">Der Dateiname der Konfiguration oder null</param>
        public override void Init(string configFileName = null)
        {
            base.Init(configFileName);

            ViewModel.Instance.Context = Context;
            ViewModel.Instance.Init();
            Context.Log.Info(MethodBase.GetCurrentMethod(), "Education Plugin initialisierung");

            var siteMap = new SiteMap(Context);

            // Ressourcen
            siteMap.AddPage("Assets", "Assets", (x) => new WorkerFile(x, Context.AssetBaseFolder));
            siteMap.AddPath("Assets", true);
            
            // Seiten
            siteMap.AddPage("Home", "", (x) => new WorkerPage<PageHome>(x));
            siteMap.AddPage("Tutorials", "tutorial", (x) => new WorkerPage<PageTutorial>(x));
            siteMap.AddPage("Controls", "control", (x) => new WorkerPage<PageControlAlert>(x));
            siteMap.AddPage("Alert", "alert", (x) => new WorkerPage<PageControlAlert>(x));
            siteMap.AddPage("Badge", "badge", (x) => new WorkerPage<PageControlBadge>(x));
            siteMap.AddPage("Breadcrumb", "breadcrumb", (x) => new WorkerPage<PageControlBreadcrumb>(x));
            siteMap.AddPage("Html", "html", (x) => new WorkerPage<PageHtml>(x));
            siteMap.AddPage("Hilfe", "help", (x) => new WorkerPage<PageHelp>(x));

            siteMap.AddPath("Home");
            siteMap.AddPath("Home/Tutorials");
            siteMap.AddPath("Home/Controls");
            siteMap.AddPath("Home/Controls/Alert");
            siteMap.AddPath("Home/Controls/Badge");
            siteMap.AddPath("Home/Controls/Breadcrumb");
            siteMap.AddPath("Home/Html");
            siteMap.AddPath("Home/Hilfe");


            Register(siteMap);

            Task.Run(() => { Run(); });
        }

        /// <summary>
        /// Diese Methode wird aufgerufen, nachdem das Fenster aktiv ist.
        /// </summary>
        private void Run()
        {
            Thread.CurrentThread.Priority = ThreadPriority.Highest;

            // Loop
            while (true)
            {
                try
                {
                    Update();
                }
                finally
                {
                    Thread.Sleep(60000);
                }
            }
        }

        /// <summary>
        /// Diese Methode wird aufgerufen, nachdem das Fenster aktiv ist.
        /// </summary>
        private void Update()
        {
            ViewModel.Instance.Update();
        }
    }
}
