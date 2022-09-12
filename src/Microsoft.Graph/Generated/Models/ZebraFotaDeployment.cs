using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The Zebra FOTA deployment entity that describes settings, deployment device groups required to create a FOTA deployment, and deployment status.</summary>
    public class ZebraFotaDeployment : Entity, IParsable {
        /// <summary>Collection of Android FOTA Assignment</summary>
        public List<AndroidFotaDeploymentAssignment> DeploymentAssignments {
            get { return BackingStore?.Get<List<AndroidFotaDeploymentAssignment>>("deploymentAssignments"); }
            set { BackingStore?.Set("deploymentAssignments", value); }
        }
        /// <summary>The Zebra FOTA deployment complex type that describes the settings required to create a FOTA deployment.</summary>
        public ZebraFotaDeploymentSettings DeploymentSettings {
            get { return BackingStore?.Get<ZebraFotaDeploymentSettings>("deploymentSettings"); }
            set { BackingStore?.Set("deploymentSettings", value); }
        }
        /// <summary>Represents the deployment status from Zebra. The status is a high level status of the deployment as opposed being a detailed status per device.</summary>
        public ZebraFotaDeploymentStatus DeploymentStatus {
            get { return BackingStore?.Get<ZebraFotaDeploymentStatus>("deploymentStatus"); }
            set { BackingStore?.Set("deploymentStatus", value); }
        }
        /// <summary>A human readable description of the deployment.</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>A human readable name of the deployment.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>
        /// Instantiates a new zebraFotaDeployment and sets the default values.
        /// </summary>
        public ZebraFotaDeployment() : base() {
            OdataType = "#microsoft.graph.zebraFotaDeployment";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ZebraFotaDeployment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ZebraFotaDeployment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"deploymentAssignments", n => { DeploymentAssignments = n.GetCollectionOfObjectValues<AndroidFotaDeploymentAssignment>(AndroidFotaDeploymentAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deploymentSettings", n => { DeploymentSettings = n.GetObjectValue<ZebraFotaDeploymentSettings>(ZebraFotaDeploymentSettings.CreateFromDiscriminatorValue); } },
                {"deploymentStatus", n => { DeploymentStatus = n.GetObjectValue<ZebraFotaDeploymentStatus>(ZebraFotaDeploymentStatus.CreateFromDiscriminatorValue); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AndroidFotaDeploymentAssignment>("deploymentAssignments", DeploymentAssignments);
            writer.WriteObjectValue<ZebraFotaDeploymentSettings>("deploymentSettings", DeploymentSettings);
            writer.WriteObjectValue<ZebraFotaDeploymentStatus>("deploymentStatus", DeploymentStatus);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
        }
    }
}
