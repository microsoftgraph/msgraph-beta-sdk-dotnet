using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.WindowsUpdates {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public class Updates : Entity, IParsable {
        /// <summary>Catalog of content that can be approved for deployment by the deployment service. Read-only.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.WindowsUpdates.Catalog Catalog { get; set; }
        /// <summary>Deployments created using the deployment service. Read-only.</summary>
        public List<Deployment> Deployments { get; set; }
        /// <summary>Assets registered with the deployment service that can receive updates. Read-only.</summary>
        public List<UpdatableAsset> UpdatableAssets { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Updates CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Updates();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"catalog", (o,n) => { (o as Updates).Catalog = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.WindowsUpdates.Catalog>(MicrosoftGraphSdk.Models.Microsoft.Graph.WindowsUpdates.Catalog.CreateFromDiscriminatorValue); } },
                {"deployments", (o,n) => { (o as Updates).Deployments = n.GetCollectionOfObjectValues<Deployment>(Deployment.CreateFromDiscriminatorValue).ToList(); } },
                {"updatableAssets", (o,n) => { (o as Updates).UpdatableAssets = n.GetCollectionOfObjectValues<UpdatableAsset>(UpdatableAsset.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.WindowsUpdates.Catalog>("catalog", Catalog);
            writer.WriteCollectionOfObjectValues<Deployment>("deployments", Deployments);
            writer.WriteCollectionOfObjectValues<UpdatableAsset>("updatableAssets", UpdatableAssets);
        }
    }
}
