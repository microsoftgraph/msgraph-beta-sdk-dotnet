using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedTenants {
    public class WorkloadActionDeploymentStatus : IParsable {
        /// <summary>The unique identifier for the workload action. Required. Read-only.</summary>
        public string ActionId { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The identifier of any policy that was created by applying the workload action. Optional. Read-only.</summary>
        public string DeployedPolicyId { get; set; }
        /// <summary>The detailed information for exceptions that occur when deploying the workload action. Optional. Required.</summary>
        public GenericError Error { get; set; }
        public List<string> ExcludeGroups { get; set; }
        public bool? IncludeAllUsers { get; set; }
        public List<string> IncludeGroups { get; set; }
        /// <summary>The date and time the workload action was last deployed. Optional.</summary>
        public DateTimeOffset? LastDeploymentDateTime { get; set; }
        /// <summary>The status of the workload action deployment. Possible values are: toAddress, completed, error, timeOut, inProgress, unknownFutureValue. Required. Read-only.</summary>
        public WorkloadActionStatus? Status { get; set; }
        /// <summary>
        /// Instantiates a new workloadActionDeploymentStatus and sets the default values.
        /// </summary>
        public WorkloadActionDeploymentStatus() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"actionId", (o,n) => { (o as WorkloadActionDeploymentStatus).ActionId = n.GetStringValue(); } },
                {"deployedPolicyId", (o,n) => { (o as WorkloadActionDeploymentStatus).DeployedPolicyId = n.GetStringValue(); } },
                {"error", (o,n) => { (o as WorkloadActionDeploymentStatus).Error = n.GetObjectValue<GenericError>(); } },
                {"excludeGroups", (o,n) => { (o as WorkloadActionDeploymentStatus).ExcludeGroups = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"includeAllUsers", (o,n) => { (o as WorkloadActionDeploymentStatus).IncludeAllUsers = n.GetBoolValue(); } },
                {"includeGroups", (o,n) => { (o as WorkloadActionDeploymentStatus).IncludeGroups = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"lastDeploymentDateTime", (o,n) => { (o as WorkloadActionDeploymentStatus).LastDeploymentDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", (o,n) => { (o as WorkloadActionDeploymentStatus).Status = n.GetEnumValue<WorkloadActionStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("actionId", ActionId);
            writer.WriteStringValue("deployedPolicyId", DeployedPolicyId);
            writer.WriteObjectValue<GenericError>("error", Error);
            writer.WriteCollectionOfPrimitiveValues<string>("excludeGroups", ExcludeGroups);
            writer.WriteBoolValue("includeAllUsers", IncludeAllUsers);
            writer.WriteCollectionOfPrimitiveValues<string>("includeGroups", IncludeGroups);
            writer.WriteDateTimeOffsetValue("lastDeploymentDateTime", LastDeploymentDateTime);
            writer.WriteEnumValue<WorkloadActionStatus>("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
