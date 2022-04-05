using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class GroupPolicyDefinition : Entity, IParsable {
        /// <summary>The group policy category associated with the definition.</summary>
        public GroupPolicyCategory Category { get; set; }
        /// <summary>The localized full category path for the policy.</summary>
        public string CategoryPath { get; set; }
        /// <summary>Identifies the type of groups the policy can be applied to. Possible values are: user, machine.</summary>
        public GroupPolicyDefinitionClassType? ClassType { get; set; }
        /// <summary>The group policy file associated with the definition.</summary>
        public GroupPolicyDefinitionFile DefinitionFile { get; set; }
        /// <summary>The localized policy name.</summary>
        public string DisplayName { get; set; }
        /// <summary>The localized explanation or help text associated with the policy. The default value is empty.</summary>
        public string ExplainText { get; set; }
        /// <summary>The category id of the parent category</summary>
        public string GroupPolicyCategoryId { get; set; }
        /// <summary>Signifies whether or not there are related definitions to this definition</summary>
        public bool? HasRelatedDefinitions { get; set; }
        /// <summary>The date and time the entity was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Minimum required CSP version for device configuration in this definition</summary>
        public string MinDeviceCspVersion { get; set; }
        /// <summary>Minimum required CSP version for user configuration in this definition</summary>
        public string MinUserCspVersion { get; set; }
        /// <summary>Definition of the next version of this definition</summary>
        public GroupPolicyDefinition NextVersionDefinition { get; set; }
        /// <summary>Specifies the type of group policy. Possible values are: admxBacked, admxIngested.</summary>
        public GroupPolicyType? PolicyType { get; set; }
        /// <summary>The group policy presentations associated with the definition.</summary>
        public List<GroupPolicyPresentation> Presentations { get; set; }
        /// <summary>Definition of the previous version of this definition</summary>
        public GroupPolicyDefinition PreviousVersionDefinition { get; set; }
        /// <summary>Localized string used to specify what operating system or application version is affected by the policy.</summary>
        public string SupportedOn { get; set; }
        /// <summary>Setting definition version</summary>
        public string Version { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new GroupPolicyDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GroupPolicyDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"category", (o,n) => { (o as GroupPolicyDefinition).Category = n.GetObjectValue<GroupPolicyCategory>(GroupPolicyCategory.CreateFromDiscriminatorValue); } },
                {"categoryPath", (o,n) => { (o as GroupPolicyDefinition).CategoryPath = n.GetStringValue(); } },
                {"classType", (o,n) => { (o as GroupPolicyDefinition).ClassType = n.GetEnumValue<GroupPolicyDefinitionClassType>(); } },
                {"definitionFile", (o,n) => { (o as GroupPolicyDefinition).DefinitionFile = n.GetObjectValue<GroupPolicyDefinitionFile>(GroupPolicyDefinitionFile.CreateFromDiscriminatorValue); } },
                {"displayName", (o,n) => { (o as GroupPolicyDefinition).DisplayName = n.GetStringValue(); } },
                {"explainText", (o,n) => { (o as GroupPolicyDefinition).ExplainText = n.GetStringValue(); } },
                {"groupPolicyCategoryId", (o,n) => { (o as GroupPolicyDefinition).GroupPolicyCategoryId = n.GetStringValue(); } },
                {"hasRelatedDefinitions", (o,n) => { (o as GroupPolicyDefinition).HasRelatedDefinitions = n.GetBoolValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as GroupPolicyDefinition).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"minDeviceCspVersion", (o,n) => { (o as GroupPolicyDefinition).MinDeviceCspVersion = n.GetStringValue(); } },
                {"minUserCspVersion", (o,n) => { (o as GroupPolicyDefinition).MinUserCspVersion = n.GetStringValue(); } },
                {"nextVersionDefinition", (o,n) => { (o as GroupPolicyDefinition).NextVersionDefinition = n.GetObjectValue<GroupPolicyDefinition>(GroupPolicyDefinition.CreateFromDiscriminatorValue); } },
                {"policyType", (o,n) => { (o as GroupPolicyDefinition).PolicyType = n.GetEnumValue<GroupPolicyType>(); } },
                {"presentations", (o,n) => { (o as GroupPolicyDefinition).Presentations = n.GetCollectionOfObjectValues<GroupPolicyPresentation>(GroupPolicyPresentation.CreateFromDiscriminatorValue).ToList(); } },
                {"previousVersionDefinition", (o,n) => { (o as GroupPolicyDefinition).PreviousVersionDefinition = n.GetObjectValue<GroupPolicyDefinition>(GroupPolicyDefinition.CreateFromDiscriminatorValue); } },
                {"supportedOn", (o,n) => { (o as GroupPolicyDefinition).SupportedOn = n.GetStringValue(); } },
                {"version", (o,n) => { (o as GroupPolicyDefinition).Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<GroupPolicyCategory>("category", Category);
            writer.WriteStringValue("categoryPath", CategoryPath);
            writer.WriteEnumValue<GroupPolicyDefinitionClassType>("classType", ClassType);
            writer.WriteObjectValue<GroupPolicyDefinitionFile>("definitionFile", DefinitionFile);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("explainText", ExplainText);
            writer.WriteStringValue("groupPolicyCategoryId", GroupPolicyCategoryId);
            writer.WriteBoolValue("hasRelatedDefinitions", HasRelatedDefinitions);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("minDeviceCspVersion", MinDeviceCspVersion);
            writer.WriteStringValue("minUserCspVersion", MinUserCspVersion);
            writer.WriteObjectValue<GroupPolicyDefinition>("nextVersionDefinition", NextVersionDefinition);
            writer.WriteEnumValue<GroupPolicyType>("policyType", PolicyType);
            writer.WriteCollectionOfObjectValues<GroupPolicyPresentation>("presentations", Presentations);
            writer.WriteObjectValue<GroupPolicyDefinition>("previousVersionDefinition", PreviousVersionDefinition);
            writer.WriteStringValue("supportedOn", SupportedOn);
            writer.WriteStringValue("version", Version);
        }
    }
}
