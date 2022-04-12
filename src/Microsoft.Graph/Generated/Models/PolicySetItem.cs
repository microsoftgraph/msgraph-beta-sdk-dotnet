using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PolicySetItem : Entity, IParsable {
        /// <summary>Creation time of the PolicySetItem.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>DisplayName of the PolicySetItem.</summary>
        public string DisplayName { get; set; }
        /// <summary>Error code if any occured. Possible values are: noError, unauthorized, notFound, deleted.</summary>
        public Microsoft.Graph.Beta.Models.ErrorCode? ErrorCode { get; set; }
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
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new PolicySetItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PolicySetItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"errorCode", n => { ErrorCode = n.GetEnumValue<ErrorCode>(); } },
                {"guidedDeploymentTags", n => { GuidedDeploymentTags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"itemType", n => { ItemType = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"payloadId", n => { PayloadId = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<PolicySetStatus>(); } },
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
