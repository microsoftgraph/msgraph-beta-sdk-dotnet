using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class GroupPolicyDefinitionValue : Entity, IParsable {
        /// <summary>Specifies how the value should be configured. This can be either as a Policy or as a Preference. Possible values are: policy, preference.</summary>
        public GroupPolicyConfigurationType? ConfigurationType { get; set; }
        /// <summary>The date and time the object was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The associated group policy definition with the value.</summary>
        public GroupPolicyDefinition Definition { get; set; }
        /// <summary>Enables or disables the associated group policy definition.</summary>
        public bool? Enabled { get; set; }
        /// <summary>The date and time the entity was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The associated group policy presentation values with the definition value.</summary>
        public List<GroupPolicyPresentationValue> PresentationValues { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"configurationType", (o,n) => { (o as GroupPolicyDefinitionValue).ConfigurationType = n.GetEnumValue<GroupPolicyConfigurationType>(); } },
                {"createdDateTime", (o,n) => { (o as GroupPolicyDefinitionValue).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"definition", (o,n) => { (o as GroupPolicyDefinitionValue).Definition = n.GetObjectValue<GroupPolicyDefinition>(); } },
                {"enabled", (o,n) => { (o as GroupPolicyDefinitionValue).Enabled = n.GetBoolValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as GroupPolicyDefinitionValue).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"presentationValues", (o,n) => { (o as GroupPolicyDefinitionValue).PresentationValues = n.GetCollectionOfObjectValues<GroupPolicyPresentationValue>().ToList(); } },
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
