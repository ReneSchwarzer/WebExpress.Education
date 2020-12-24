using System;
using System.Reflection;
using System.Xml.Serialization;
using WebExpress.Module;
using WebExpress.Plugin;

namespace Education.Model
{
    public class ViewModel
    {
        /// <summary>
        /// Instanz des einzigen Modells
        /// </summary>
        private static ViewModel _this = null;

        /// <summary>
        /// Lifert die einzige Instanz der Modell-Klasse
        /// </summary>
        public static ViewModel Instance
        {
            get
            {
                if (_this == null)
                {
                    _this = new ViewModel();
                }

                return _this;
            }
        }

        /// <summary>
        /// Liefert die aktuelle Zeit
        /// </summary>
        public string Now => DateTime.Now.ToString("dd.MM.yyyy<br>HH:mm:ss");

        /// <summary>
        /// Liefert oder setzt den Verweis auf den Kontext des Plugins
        /// </summary>
        public IModuleContext Context { get; set; }

        /// <summary>
        /// Liefert die Programmversion
        /// </summary>
        [XmlIgnore]
        public string Version => Assembly.GetExecutingAssembly().GetName().Version.ToString();

        /// <summary>
        /// Konstruktor
        /// </summary>
        private ViewModel()
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        public void Init()
        {

        }

        /// <summary>
        /// Updatefunktion
        /// </summary>
        public virtual void Update()
        {

        }
    }
}