using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public class ManagementActionDeploymentStatus : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The identifier for the management action. Required. Read-only.</summary>
        public string ManagementActionId { get; set; }
        /// <summary>The management template identifier that was used to generate the management action. Required. Read-only.</summary>
        public string ManagementTemplateId { get; set; }
        /// <summary>The managementTemplateVersion property</summary>
        public int? ManagementTemplateVersion { get; set; }
        /// <summary>The status of the management action. Possible values are: toAddress, completed, error, timeOut, inProgress, planned, resolvedBy3rdParty, resolvedThroughAlternateMitigation, riskAccepted, unknownFutureValue. Required.</summary>
        public ManagementActionStatus? Status { get; set; }
        /// <summary>The collection of workload action deployment statues for the given management action. Optional.</summary>
        public List<WorkloadActionDeploymentStatus> WorkloadActionDeploymentStatuses { get; set; }
        /// <summary>
        /// Instantiates a new managementActionDeploymentStatus and sets the default values.
        /// </summary>
        public ManagementActionDeploymentStatus() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ManagementActionDeploymentStatus CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagementActionDeploymentStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"managementActionId", (o,n) => { (o as ManagementActionDeploymentStatus).ManagementActionId = n.GetStringValue(); } },
                {"managementTemplateId", (o,n) => { (o as ManagementActionDeploymentStatus).ManagementTemplateId = n.GetStringValue(); } },
                {"managementTemplateVersion", (o,n) => { (o as ManagementActionDeploymentStatus).ManagementTemplateVersion = n.GetIntValue(); } },
                {"status", (o,n) => { (o as ManagementActionDeploymentStatus).Status = n.GetEnumValue<ManagementActionStatus>(); } },
                {"workloadActionDeploymentStatuses", (o,n) => { (o as ManagementActionDeploymentStatus).WorkloadActionDeploymentStatuses = n.GetCollectionOfObjectValues<WorkloadActionDeploymentStatus>(WorkloadActionDeploymentStatus.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("managementActionId", ManagementActionId);
            writer.WriteStringValue("managementTemplateId", ManagementTemplateId);
            writer.WriteIntValue("managementTemplateVersion", ManagementTemplateVersion);
            writer.WriteEnumValue<ManagementActionStatus>("status", Status);
            writer.WriteCollectionOfObjectValues<WorkloadActionDeploymentStatus>("workloadActionDeploymentStatuses", WorkloadActionDeploymentStatuses);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
