using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The definition value entity stores the value for a single group policy definition.</summary>
    public class GroupPolicyDefinitionValue : Entity, IParsable {
        /// <summary>Specifies how the value should be configured. This can be either as a Policy or as a Preference. Possible values are: policy, preference.</summary>
        public GroupPolicyConfigurationType? ConfigurationType {
            get { return BackingStore?.Get<GroupPolicyConfigurationType?>(nameof(ConfigurationType)); }
            set { BackingStore?.Set(nameof(ConfigurationType), value); }
        }
        /// <summary>The date and time the object was created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>The associated group policy definition with the value.</summary>
        public GroupPolicyDefinition Definition {
            get { return BackingStore?.Get<GroupPolicyDefinition>(nameof(Definition)); }
            set { BackingStore?.Set(nameof(Definition), value); }
        }
        /// <summary>Enables or disables the associated group policy definition.</summary>
        public bool? Enabled {
            get { return BackingStore?.Get<bool?>(nameof(Enabled)); }
            set { BackingStore?.Set(nameof(Enabled), value); }
        }
        /// <summary>The date and time the entity was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(LastModifiedDateTime), value); }
        }
        /// <summary>The associated group policy presentation values with the definition value.</summary>
        public List<GroupPolicyPresentationValue> PresentationValues {
            get { return BackingStore?.Get<List<GroupPolicyPresentationValue>>(nameof(PresentationValues)); }
            set { BackingStore?.Set(nameof(PresentationValues), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new GroupPolicyDefinitionValue CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GroupPolicyDefinitionValue();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"configurationType", n => { ConfigurationType = n.GetEnumValue<GroupPolicyConfigurationType>(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"definition", n => { Definition = n.GetObjectValue<GroupPolicyDefinition>(GroupPolicyDefinition.CreateFromDiscriminatorValue); } },
                {"enabled", n => { Enabled = n.GetBoolValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"presentationValues", n => { PresentationValues = n.GetCollectionOfObjectValues<GroupPolicyPresentationValue>(GroupPolicyPresentationValue.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<GroupPolicyConfigurationType>("configurationType", ConfigurationType);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<GroupPolicyDefinition>("definition", Definition);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfObjectValues<GroupPolicyPresentationValue>("presentationValues", PresentationValues);
        }
    }
}
