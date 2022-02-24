using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class PolicySet : Entity, IParsable {
        /// <summary>Assignments of the PolicySet.</summary>
        public List<PolicySetAssignment> Assignments { get; set; }
        /// <summary>Creation time of the PolicySet.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Description of the PolicySet.</summary>
        public string Description { get; set; }
        /// <summary>DisplayName of the PolicySet.</summary>
        public string DisplayName { get; set; }
        /// <summary>Error code if any occured. Possible values are: noError, unauthorized, notFound, deleted.</summary>
        public ErrorCode? ErrorCode { get; set; }
        /// <summary>Tags of the guided deployment</summary>
        public List<string> GuidedDeploymentTags { get; set; }
        /// <summary>Items of the PolicySet with maximum count 100.</summary>
        public List<PolicySetItem> Items { get; set; }
        /// <summary>Last modified time of the PolicySet.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>RoleScopeTags of the PolicySet</summary>
        public List<string> RoleScopeTags { get; set; }
        /// <summary>Validation/assignment status of the PolicySet. Possible values are: unknown, validating, partialSuccess, success, error, notAssigned.</summary>
        public PolicySetStatus? Status { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assignments", (o,n) => { (o as PolicySet).Assignments = n.GetCollectionOfObjectValues<PolicySetAssignment>().ToList(); } },
                {"createdDateTime", (o,n) => { (o as PolicySet).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as PolicySet).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as PolicySet).DisplayName = n.GetStringValue(); } },
                {"errorCode", (o,n) => { (o as PolicySet).ErrorCode = n.GetEnumValue<ErrorCode>(); } },
                {"guidedDeploymentTags", (o,n) => { (o as PolicySet).GuidedDeploymentTags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"items", (o,n) => { (o as PolicySet).Items = n.GetCollectionOfObjectValues<PolicySetItem>().ToList(); } },
                {"lastModifiedDateTime", (o,n) => { (o as PolicySet).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"roleScopeTags", (o,n) => { (o as PolicySet).RoleScopeTags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"status", (o,n) => { (o as PolicySet).Status = n.GetEnumValue<PolicySetStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<PolicySetAssignment>("assignments", Assignments);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<ErrorCode>("errorCode", ErrorCode);
            writer.WriteCollectionOfPrimitiveValues<string>("guidedDeploymentTags", GuidedDeploymentTags);
            writer.WriteCollectionOfObjectValues<PolicySetItem>("items", Items);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTags", RoleScopeTags);
            writer.WriteEnumValue<PolicySetStatus>("status", Status);
        }
    }
}
