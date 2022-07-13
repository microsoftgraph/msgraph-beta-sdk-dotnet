using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>A class containing the properties used for PolicySet.</summary>
    public class PolicySet : Entity, IParsable {
        /// <summary>Assignments of the PolicySet.</summary>
        public List<PolicySetAssignment> Assignments {
            get { return BackingStore?.Get<List<PolicySetAssignment>>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
        /// <summary>Creation time of the PolicySet.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Description of the PolicySet.</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>DisplayName of the PolicySet.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The errorCode property</summary>
        public Microsoft.Graph.Beta.Models.ErrorCode? ErrorCode {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ErrorCode?>("errorCode"); }
            set { BackingStore?.Set("errorCode", value); }
        }
        /// <summary>Tags of the guided deployment</summary>
        public List<string> GuidedDeploymentTags {
            get { return BackingStore?.Get<List<string>>("guidedDeploymentTags"); }
            set { BackingStore?.Set("guidedDeploymentTags", value); }
        }
        /// <summary>Items of the PolicySet with maximum count 100.</summary>
        public List<PolicySetItem> Items {
            get { return BackingStore?.Get<List<PolicySetItem>>("items"); }
            set { BackingStore?.Set("items", value); }
        }
        /// <summary>Last modified time of the PolicySet.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>RoleScopeTags of the PolicySet</summary>
        public List<string> RoleScopeTags {
            get { return BackingStore?.Get<List<string>>("roleScopeTags"); }
            set { BackingStore?.Set("roleScopeTags", value); }
        }
        /// <summary>The enum to specify the status of PolicySet.</summary>
        public PolicySetStatus? Status {
            get { return BackingStore?.Get<PolicySetStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
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
