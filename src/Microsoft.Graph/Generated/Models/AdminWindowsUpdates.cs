using Microsoft.Graph.Beta.Models.WindowsUpdates;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AdminWindowsUpdates : Entity, IParsable {
        /// <summary>Catalog of content that can be approved for deployment by the deployment service. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.WindowsUpdates.Catalog? Catalog {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsUpdates.Catalog?>("catalog"); }
            set { BackingStore?.Set("catalog", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.WindowsUpdates.Catalog Catalog {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsUpdates.Catalog>("catalog"); }
            set { BackingStore?.Set("catalog", value); }
        }
#endif
        /// <summary>The set of updatableAsset resources to which a deployment can apply.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeploymentAudience>? DeploymentAudiences {
            get { return BackingStore?.Get<List<DeploymentAudience>?>("deploymentAudiences"); }
            set { BackingStore?.Set("deploymentAudiences", value); }
        }
#nullable restore
#else
        public List<DeploymentAudience> DeploymentAudiences {
            get { return BackingStore?.Get<List<DeploymentAudience>>("deploymentAudiences"); }
            set { BackingStore?.Set("deploymentAudiences", value); }
        }
#endif
        /// <summary>Deployments created using the deployment service.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Deployment>? Deployments {
            get { return BackingStore?.Get<List<Deployment>?>("deployments"); }
            set { BackingStore?.Set("deployments", value); }
        }
#nullable restore
#else
        public List<Deployment> Deployments {
            get { return BackingStore?.Get<List<Deployment>>("deployments"); }
            set { BackingStore?.Set("deployments", value); }
        }
#endif
        /// <summary>Service connections to external resources such as analytics workspaces.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ResourceConnection>? ResourceConnections {
            get { return BackingStore?.Get<List<ResourceConnection>?>("resourceConnections"); }
            set { BackingStore?.Set("resourceConnections", value); }
        }
#nullable restore
#else
        public List<ResourceConnection> ResourceConnections {
            get { return BackingStore?.Get<List<ResourceConnection>>("resourceConnections"); }
            set { BackingStore?.Set("resourceConnections", value); }
        }
#endif
        /// <summary>Assets registered with the deployment service that can receive updates.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UpdatableAsset>? UpdatableAssets {
            get { return BackingStore?.Get<List<UpdatableAsset>?>("updatableAssets"); }
            set { BackingStore?.Set("updatableAssets", value); }
        }
#nullable restore
#else
        public List<UpdatableAsset> UpdatableAssets {
            get { return BackingStore?.Get<List<UpdatableAsset>>("updatableAssets"); }
            set { BackingStore?.Set("updatableAssets", value); }
        }
#endif
        /// <summary>A collection of policies for approving the deployment of different content to an audience over time.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatePolicy>? UpdatePolicies {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatePolicy>?>("updatePolicies"); }
            set { BackingStore?.Set("updatePolicies", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatePolicy> UpdatePolicies {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatePolicy>>("updatePolicies"); }
            set { BackingStore?.Set("updatePolicies", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AdminWindowsUpdates CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AdminWindowsUpdates();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"catalog", n => { Catalog = n.GetObjectValue<Microsoft.Graph.Beta.Models.WindowsUpdates.Catalog>(Microsoft.Graph.Beta.Models.WindowsUpdates.Catalog.CreateFromDiscriminatorValue); } },
                {"deploymentAudiences", n => { DeploymentAudiences = n.GetCollectionOfObjectValues<DeploymentAudience>(DeploymentAudience.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deployments", n => { Deployments = n.GetCollectionOfObjectValues<Deployment>(Deployment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"resourceConnections", n => { ResourceConnections = n.GetCollectionOfObjectValues<ResourceConnection>(ResourceConnection.CreateFromDiscriminatorValue)?.ToList(); } },
                {"updatableAssets", n => { UpdatableAssets = n.GetCollectionOfObjectValues<UpdatableAsset>(UpdatableAsset.CreateFromDiscriminatorValue)?.ToList(); } },
                {"updatePolicies", n => { UpdatePolicies = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatePolicy>(Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatePolicy.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.WindowsUpdates.Catalog>("catalog", Catalog);
            writer.WriteCollectionOfObjectValues<DeploymentAudience>("deploymentAudiences", DeploymentAudiences);
            writer.WriteCollectionOfObjectValues<Deployment>("deployments", Deployments);
            writer.WriteCollectionOfObjectValues<ResourceConnection>("resourceConnections", ResourceConnections);
            writer.WriteCollectionOfObjectValues<UpdatableAsset>("updatableAssets", UpdatableAssets);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatePolicy>("updatePolicies", UpdatePolicies);
        }
    }
}
