using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class DetectedSensitiveContent : DetectedSensitiveContentBase, IParsable {
        public List<ClassificationAttribute> ClassificationAttributes { get; set; }
        public MicrosoftGraphSdk.Models.Microsoft.Graph.ClassificationMethod? ClassificationMethod { get; set; }
        public List<SensitiveContentLocation> Matches { get; set; }
        public SensitiveTypeScope? Scope { get; set; }
        public MicrosoftGraphSdk.Models.Microsoft.Graph.SensitiveTypeSource? SensitiveTypeSource { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"classificationAttributes", (o,n) => { (o as DetectedSensitiveContent).ClassificationAttributes = n.GetCollectionOfObjectValues<ClassificationAttribute>(ClassificationAttribute.CreateFromDiscriminatorValue).ToList(); } },
                {"classificationMethod", (o,n) => { (o as DetectedSensitiveContent).ClassificationMethod = n.GetEnumValue<ClassificationMethod>(); } },
                {"matches", (o,n) => { (o as DetectedSensitiveContent).Matches = n.GetCollectionOfObjectValues<SensitiveContentLocation>(SensitiveContentLocation.CreateFromDiscriminatorValue).ToList(); } },
                {"scope", (o,n) => { (o as DetectedSensitiveContent).Scope = n.GetEnumValue<SensitiveTypeScope>(); } },
                {"sensitiveTypeSource", (o,n) => { (o as DetectedSensitiveContent).SensitiveTypeSource = n.GetEnumValue<SensitiveTypeSource>(); } },
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
