using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates {
    public class Updates : Entity, IParsable {
        /// <summary>Catalog of content that can be approved for deployment by the deployment service. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.WindowsUpdates.Catalog Catalog {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsUpdates.Catalog>("catalog"); }
            set { BackingStore?.Set("catalog", value); }
        }
        /// <summary>Deployments created using the deployment service. Read-only.</summary>
        public List<Deployment> Deployments {
            get { return BackingStore?.Get<List<Deployment>>("deployments"); }
            set { BackingStore?.Set("deployments", value); }
        }
        /// <summary>The resourceConnections property</summary>
        public List<ResourceConnection> ResourceConnections {
            get { return BackingStore?.Get<List<ResourceConnection>>("resourceConnections"); }
            set { BackingStore?.Set("resourceConnections", value); }
        }
        /// <summary>Assets registered with the deployment service that can receive updates. Read-only.</summary>
        public List<UpdatableAsset> UpdatableAssets {
            get { return BackingStore?.Get<List<UpdatableAsset>>("updatableAssets"); }
            set { BackingStore?.Set("updatableAssets", value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"catalog", n => { Catalog = n.GetObjectValue<Microsoft.Graph.Beta.Models.WindowsUpdates.Catalog>(Microsoft.Graph.Beta.Models.WindowsUpdates.Catalog.CreateFromDiscriminatorValue); } },
                {"deployments", n => { Deployments = n.GetCollectionOfObjectValues<Deployment>(Deployment.CreateFromDiscriminatorValue).ToList(); } },
                {"resourceConnections", n => { ResourceConnections = n.GetCollectionOfObjectValues<ResourceConnection>(ResourceConnection.CreateFromDiscriminatorValue).ToList(); } },
                {"updatableAssets", n => { UpdatableAssets = n.GetCollectionOfObjectValues<UpdatableAsset>(UpdatableAsset.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.WindowsUpdates.Catalog>("catalog", Catalog);
            writer.WriteCollectionOfObjectValues<Deployment>("deployments", Deployments);
            writer.WriteCollectionOfObjectValues<ResourceConnection>("resourceConnections", ResourceConnections);
            writer.WriteCollectionOfObjectValues<UpdatableAsset>("updatableAssets", UpdatableAssets);
        }
    }
}
