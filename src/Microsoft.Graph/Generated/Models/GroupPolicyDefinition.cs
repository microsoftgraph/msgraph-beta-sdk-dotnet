using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The entity describes all of the information about a single group policy.</summary>
    public class GroupPolicyDefinition : Entity, IParsable {
        /// <summary>The group policy category associated with the definition.</summary>
        public GroupPolicyCategory Category {
            get { return BackingStore?.Get<GroupPolicyCategory>(nameof(Category)); }
            set { BackingStore?.Set(nameof(Category), value); }
        }
        /// <summary>The localized full category path for the policy.</summary>
        public string CategoryPath {
            get { return BackingStore?.Get<string>(nameof(CategoryPath)); }
            set { BackingStore?.Set(nameof(CategoryPath), value); }
        }
        /// <summary>Identifies the type of groups the policy can be applied to. Possible values are: user, machine.</summary>
        public GroupPolicyDefinitionClassType? ClassType {
            get { return BackingStore?.Get<GroupPolicyDefinitionClassType?>(nameof(ClassType)); }
            set { BackingStore?.Set(nameof(ClassType), value); }
        }
        /// <summary>The group policy file associated with the definition.</summary>
        public GroupPolicyDefinitionFile DefinitionFile {
            get { return BackingStore?.Get<GroupPolicyDefinitionFile>(nameof(DefinitionFile)); }
            set { BackingStore?.Set(nameof(DefinitionFile), value); }
        }
        /// <summary>The localized policy name.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The localized explanation or help text associated with the policy. The default value is empty.</summary>
        public string ExplainText {
            get { return BackingStore?.Get<string>(nameof(ExplainText)); }
            set { BackingStore?.Set(nameof(ExplainText), value); }
        }
        /// <summary>The category id of the parent category</summary>
        public string GroupPolicyCategoryId {
            get { return BackingStore?.Get<string>(nameof(GroupPolicyCategoryId)); }
            set { BackingStore?.Set(nameof(GroupPolicyCategoryId), value); }
        }
        /// <summary>Signifies whether or not there are related definitions to this definition</summary>
        public bool? HasRelatedDefinitions {
            get { return BackingStore?.Get<bool?>(nameof(HasRelatedDefinitions)); }
            set { BackingStore?.Set(nameof(HasRelatedDefinitions), value); }
        }
        /// <summary>The date and time the entity was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(LastModifiedDateTime), value); }
        }
        /// <summary>Minimum required CSP version for device configuration in this definition</summary>
        public string MinDeviceCspVersion {
            get { return BackingStore?.Get<string>(nameof(MinDeviceCspVersion)); }
            set { BackingStore?.Set(nameof(MinDeviceCspVersion), value); }
        }
        /// <summary>Minimum required CSP version for user configuration in this definition</summary>
        public string MinUserCspVersion {
            get { return BackingStore?.Get<string>(nameof(MinUserCspVersion)); }
            set { BackingStore?.Set(nameof(MinUserCspVersion), value); }
        }
        /// <summary>Definition of the next version of this definition</summary>
        public GroupPolicyDefinition NextVersionDefinition {
            get { return BackingStore?.Get<GroupPolicyDefinition>(nameof(NextVersionDefinition)); }
            set { BackingStore?.Set(nameof(NextVersionDefinition), value); }
        }
        /// <summary>Specifies the type of group policy. Possible values are: admxBacked, admxIngested.</summary>
        public GroupPolicyType? PolicyType {
            get { return BackingStore?.Get<GroupPolicyType?>(nameof(PolicyType)); }
            set { BackingStore?.Set(nameof(PolicyType), value); }
        }
        /// <summary>The group policy presentations associated with the definition.</summary>
        public List<GroupPolicyPresentation> Presentations {
            get { return BackingStore?.Get<List<GroupPolicyPresentation>>(nameof(Presentations)); }
            set { BackingStore?.Set(nameof(Presentations), value); }
        }
        /// <summary>Definition of the previous version of this definition</summary>
        public GroupPolicyDefinition PreviousVersionDefinition {
            get { return BackingStore?.Get<GroupPolicyDefinition>(nameof(PreviousVersionDefinition)); }
            set { BackingStore?.Set(nameof(PreviousVersionDefinition), value); }
        }
        /// <summary>Localized string used to specify what operating system or application version is affected by the policy.</summary>
        public string SupportedOn {
            get { return BackingStore?.Get<string>(nameof(SupportedOn)); }
            set { BackingStore?.Set(nameof(SupportedOn), value); }
        }
        /// <summary>Setting definition version</summary>
        public string Version {
            get { return BackingStore?.Get<string>(nameof(Version)); }
            set { BackingStore?.Set(nameof(Version), value); }
        }
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
                {"presentations", n => { Presentations = n.GetCollectionOfObjectValues<GroupPolicyPresentation>(GroupPolicyPresentation.CreateFromDiscriminatorValue).ToList(); } },
                {"previousVersionDefinition", n => { PreviousVersionDefinition = n.GetObjectValue<GroupPolicyDefinition>(GroupPolicyDefinition.CreateFromDiscriminatorValue); } },
                {"supportedOn", n => { SupportedOn = n.GetStringValue(); } },
                {"version", n => { Version = n.GetStringValue(); } },
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
