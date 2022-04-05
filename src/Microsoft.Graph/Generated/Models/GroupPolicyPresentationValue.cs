using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class GroupPolicyPresentationValue : Entity, IParsable {
        /// <summary>The date and time the object was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The group policy definition value associated with the presentation value.</summary>
        public GroupPolicyDefinitionValue DefinitionValue { get; set; }
        /// <summary>The date and time the object was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The group policy presentation associated with the presentation value.</summary>
        public GroupPolicyPresentation Presentation { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new GroupPolicyPresentationValue CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GroupPolicyPresentationValue();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"createdDateTime", (o,n) => { (o as GroupPolicyPresentationValue).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"definitionValue", (o,n) => { (o as GroupPolicyPresentationValue).DefinitionValue = n.GetObjectValue<GroupPolicyDefinitionValue>(GroupPolicyDefinitionValue.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", (o,n) => { (o as GroupPolicyPresentationValue).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"presentation", (o,n) => { (o as GroupPolicyPresentationValue).Presentation = n.GetObjectValue<GroupPolicyPresentation>(GroupPolicyPresentation.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<GroupPolicyDefinitionValue>("definitionValue", DefinitionValue);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteObjectValue<GroupPolicyPresentation>("presentation", Presentation);
        }
    }
}
