using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class PolicySetItem : Entity, IParsable {
        /// <summary>Creation time of the PolicySetItem.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>DisplayName of the PolicySetItem.</summary>
        public string DisplayName { get; set; }
        /// <summary>Error code if any occured. Possible values are: noError, unauthorized, notFound, deleted.</summary>
        public ErrorCode? ErrorCode { get; set; }
        /// <summary>Tags of the guided deployment</summary>
        public List<string> GuidedDeploymentTags { get; set; }
        /// <summary>policySetType of the PolicySetItem.</summary>
        public string ItemType { get; set; }
        /// <summary>Last modified time of the PolicySetItem.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>PayloadId of the PolicySetItem.</summary>
        public string PayloadId { get; set; }
        /// <summary>Status of the PolicySetItem. Possible values are: unknown, validating, partialSuccess, success, error, notAssigned.</summary>
        public PolicySetStatus? Status { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"createdDateTime", (o,n) => { (o as PolicySetItem).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", (o,n) => { (o as PolicySetItem).DisplayName = n.GetStringValue(); } },
                {"errorCode", (o,n) => { (o as PolicySetItem).ErrorCode = n.GetEnumValue<ErrorCode>(); } },
                {"guidedDeploymentTags", (o,n) => { (o as PolicySetItem).GuidedDeploymentTags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"itemType", (o,n) => { (o as PolicySetItem).ItemType = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as PolicySetItem).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"payloadId", (o,n) => { (o as PolicySetItem).PayloadId = n.GetStringValue(); } },
                {"status", (o,n) => { (o as PolicySetItem).Status = n.GetEnumValue<PolicySetStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<ErrorCode>("errorCode", ErrorCode);
            writer.WriteCollectionOfPrimitiveValues<string>("guidedDeploymentTags", GuidedDeploymentTags);
            writer.WriteStringValue("itemType", ItemType);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("payloadId", PayloadId);
            writer.WriteEnumValue<PolicySetStatus>("status", Status);
        }
    }
}
