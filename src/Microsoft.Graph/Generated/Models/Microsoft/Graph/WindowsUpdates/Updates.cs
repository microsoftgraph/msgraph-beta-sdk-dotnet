using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.WindowsUpdates {
    public class Updates : Entity, IParsable {
        /// <summary>Catalog of content that can be approved for deployment by the deployment service. Read-only.</summary>
        public Catalog Catalog { get; set; }
        /// <summary>Deployments created using the deployment service. Read-only.</summary>
        public List<Deployment> Deployments { get; set; }
        /// <summary>Assets registered with the deployment service that can receive updates. Read-only.</summary>
        public List<UpdatableAsset> UpdatableAssets { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"catalog", (o,n) => { (o as Updates).Catalog = n.GetObjectValue<Catalog>(); } },
                {"deployments", (o,n) => { (o as Updates).Deployments = n.GetCollectionOfObjectValues<Deployment>().ToList(); } },
                {"updatableAssets", (o,n) => { (o as Updates).UpdatableAssets = n.GetCollectionOfObjectValues<UpdatableAsset>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Catalog>("catalog", Catalog);
            writer.WriteCollectionOfObjectValues<Deployment>("deployments", Deployments);
            writer.WriteCollectionOfObjectValues<UpdatableAsset>("updatableAssets", UpdatableAssets);
        }
    }
}
