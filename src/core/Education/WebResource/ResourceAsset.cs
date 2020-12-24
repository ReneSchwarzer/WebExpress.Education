using System.IO;
using WebExpress.Attribute;

namespace Education.WebResource
{
    /// <summary>
    /// Lieferung einer im Assamby eingebetteten Ressource
    /// </summary>
    [ID("Asset")]
    [Title("Assets")]
    [Segment("assets")]
    [Path("/")]
    [IncludeSubPaths(true)]
    [Module("edu")]
    public sealed class ResourceAsset : WebExpress.WebResource.ResourceAsset
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public ResourceAsset()
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        public override void Initialization()
        {
            base.Initialization();

            AssetDirectory = "Education";
        }
    }
}