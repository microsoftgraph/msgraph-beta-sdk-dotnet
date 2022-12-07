using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class GroupPolicyDefinition : Entity, IParsable {
        /// <summary>The group policy category associated with the definition.</summary>
        public GroupPolicyCategory Category {
            get { return BackingStore?.Get<GroupPolicyCategory>("category"); }
            set { BackingStore?.Set("category", value); }
        }
        /// <summary>The localized full category path for the policy.</summary>
        public string CategoryPath {
            get { return BackingStore?.Get<string>("categoryPath"); }
            set { BackingStore?.Set("categoryPath", value); }
        }
        /// <summary>Group Policy Definition Class Type.</summary>
        public GroupPolicyDefinitionClassType? ClassType {
            get { return BackingStore?.Get<GroupPolicyDefinitionClassType?>("classType"); }
            set { BackingStore?.Set("classType", value); }
        }
        /// <summary>The group policy file associated with the definition.</summary>
        public GroupPolicyDefinitionFile DefinitionFile {
            get { return BackingStore?.Get<GroupPolicyDefinitionFile>("definitionFile"); }
            set { BackingStore?.Set("definitionFile", value); }
        }
        /// <summary>The localized policy name.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The localized explanation or help text associated with the policy. The default value is empty.</summary>
        public string ExplainText {
            get { return BackingStore?.Get<string>("explainText"); }
            set { BackingStore?.Set("explainText", value); }
        }
        /// <summary>The category id of the parent category</summary>
        public string GroupPolicyCategoryId {
            get { return BackingStore?.Get<string>("groupPolicyCategoryId"); }
            set { BackingStore?.Set("groupPolicyCategoryId", value); }
        }
        /// <summary>Signifies whether or not there are related definitions to this definition</summary>
        public bool? HasRelatedDefinitions {
            get { return BackingStore?.Get<bool?>("hasRelatedDefinitions"); }
            set { BackingStore?.Set("hasRelatedDefinitions", value); }
        }
        /// <summary>The date and time the entity was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Minimum required CSP version for device configuration in this definition</summary>
        public string MinDeviceCspVersion {
            get { return BackingStore?.Get<string>("minDeviceCspVersion"); }
            set { BackingStore?.Set("minDeviceCspVersion", value); }
        }
        /// <summary>Minimum required CSP version for user configuration in this definition</summary>
        public string MinUserCspVersion {
            get { return BackingStore?.Get<string>("minUserCspVersion"); }
            set { BackingStore?.Set("minUserCspVersion", value); }
        }
        /// <summary>Definition of the next version of this definition</summary>
        public GroupPolicyDefinition NextVersionDefinition {
            get { return BackingStore?.Get<GroupPolicyDefinition>("nextVersionDefinition"); }
            set { BackingStore?.Set("nextVersionDefinition", value); }
        }
        /// <summary>Type of Group Policy File or Definition.</summary>
        public GroupPolicyType? PolicyType {
            get { return BackingStore?.Get<GroupPolicyType?>("policyType"); }
            set { BackingStore?.Set("policyType", value); }
        }
        /// <summary>The group policy presentations associated with the definition.</summary>
        public List<GroupPolicyPresentation> Presentations {
            get { return BackingStore?.Get<List<GroupPolicyPresentation>>("presentations"); }
            set { BackingStore?.Set("presentations", value); }
        }
        /// <summary>Definition of the previous version of this definition</summary>
        public GroupPolicyDefinition PreviousVersionDefinition {
            get { return BackingStore?.Get<GroupPolicyDefinition>("previousVersionDefinition"); }
            set { BackingStore?.Set("previousVersionDefinition", value); }
        }
        /// <summary>Localized string used to specify what operating system or application version is affected by the policy.</summary>
        public string SupportedOn {
            get { return BackingStore?.Get<string>("supportedOn"); }
            set { BackingStore?.Set("supportedOn", value); }
        }
        /// <summary>Setting definition version</summary>
        public string Version {
            get { return BackingStore?.Get<string>("version"); }
            set { BackingStore?.Set("version", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new GroupPolicyDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GroupPolicyDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"category", n => { Category = n.GetObjectValue<GroupPolicyCategory>(GroupPolicyCategory.CreateFromDiscriminatorValue); } },
                {"categoryPath", n => { CategoryPath = n.GetStringValue(); } },
                {"classType", n => { ClassType = n.GetEnumValue<GroupPolicyDefinitionClassType>(); } },
                {"definitionFile", n => { DefinitionFile = n.GetObjectValue<GroupPolicyDefinitionFile>(GroupPolicyDefinitionFile.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"explainText", n => { ExplainText = n.GetStringValue(); } },
                {"groupPolicyCategoryId", n => { GroupPolicyCategoryId = n.GetStringValue(); } },
                {"hasRelatedDefinitions", n => { HasRelatedDefinitions = n.GetBoolValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"minDeviceCspVersion", n => { MinDeviceCspVersion = n.GetStringValue(); } },
                {"minUserCspVersion", n => { MinUserCspVersion = n.GetStringValue(); } },
                {"nextVersionDefinition", n => { NextVersionDefinition = n.GetObjectValue<GroupPolicyDefinition>(GroupPolicyDefinition.CreateFromDiscriminatorValue); } },
                {"policyType", n => { PolicyType = n.GetEnumValue<GroupPolicyType>(); } },
                {"presentations", n => { Presentations = n.GetCollectionOfObjectValues<GroupPolicyPresentation>(GroupPolicyPresentation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"previousVersionDefinition", n => { PreviousVersionDefinition = n.GetObjectValue<GroupPolicyDefinition>(GroupPolicyDefinition.CreateFromDiscriminatorValue); } },
                {"supportedOn", n => { SupportedOn = n.GetStringValue(); } },
                {"version", n => { Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
