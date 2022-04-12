using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DetectedSensitiveContent : DetectedSensitiveContentBase, IParsable {
        /// <summary>The classificationAttributes property</summary>
        public List<ClassificationAttribute> ClassificationAttributes { get; set; }
        /// <summary>The classificationMethod property</summary>
        public Microsoft.Graph.Beta.Models.ClassificationMethod? ClassificationMethod { get; set; }
        /// <summary>The matches property</summary>
        public List<SensitiveContentLocation> Matches { get; set; }
        /// <summary>The scope property</summary>
        public SensitiveTypeScope? Scope { get; set; }
        /// <summary>The sensitiveTypeSource property</summary>
        public Microsoft.Graph.Beta.Models.SensitiveTypeSource? SensitiveTypeSource { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DetectedSensitiveContent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DetectedSensitiveContent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"classificationAttributes", n => { ClassificationAttributes = n.GetCollectionOfObjectValues<ClassificationAttribute>(ClassificationAttribute.CreateFromDiscriminatorValue).ToList(); } },
                {"classificationMethod", n => { ClassificationMethod = n.GetEnumValue<ClassificationMethod>(); } },
                {"matches", n => { Matches = n.GetCollectionOfObjectValues<SensitiveContentLocation>(SensitiveContentLocation.CreateFromDiscriminatorValue).ToList(); } },
                {"scope", n => { Scope = n.GetEnumValue<SensitiveTypeScope>(); } },
                {"sensitiveTypeSource", n => { SensitiveTypeSource = n.GetEnumValue<SensitiveTypeSource>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ClassificationAttribute>("classificationAttributes", ClassificationAttributes);
            writer.WriteEnumValue<ClassificationMethod>("classificationMethod", ClassificationMethod);
            writer.WriteCollectionOfObjectValues<SensitiveContentLocation>("matches", Matches);
            writer.WriteEnumValue<SensitiveTypeScope>("scope", Scope);
            writer.WriteEnumValue<SensitiveTypeSource>("sensitiveTypeSource", SensitiveTypeSource);
        }
    }
}
