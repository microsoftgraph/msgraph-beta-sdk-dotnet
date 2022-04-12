using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
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
        public Microsoft.Graph.Beta.Models.ErrorCode? ErrorCode { get; set; }
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
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new PolicySet CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PolicySet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<PolicySetAssignment>(PolicySetAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"errorCode", n => { ErrorCode = n.GetEnumValue<ErrorCode>(); } },
                {"guidedDeploymentTags", n => { GuidedDeploymentTags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"items", n => { Items = n.GetCollectionOfObjectValues<PolicySetItem>(PolicySetItem.CreateFromDiscriminatorValue).ToList(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"roleScopeTags", n => { RoleScopeTags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
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
