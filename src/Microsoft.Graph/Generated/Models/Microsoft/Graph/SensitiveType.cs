using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class SensitiveType : Entity, IParsable {
        /// <summary>The classificationMethod property</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.ClassificationMethod? ClassificationMethod { get; set; }
        /// <summary>The description property</summary>
        public string Description { get; set; }
        /// <summary>The name property</summary>
        public string Name { get; set; }
        /// <summary>The publisherName property</summary>
        public string PublisherName { get; set; }
        /// <summary>The rulePackageId property</summary>
        public string RulePackageId { get; set; }
        /// <summary>The rulePackageType property</summary>
        public string RulePackageType { get; set; }
        /// <summary>The scope property</summary>
        public SensitiveTypeScope? Scope { get; set; }
        /// <summary>The sensitiveTypeSource property</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.SensitiveTypeSource? SensitiveTypeSource { get; set; }
        /// <summary>The state property</summary>
        public string State { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SensitiveType CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SensitiveType();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"classificationMethod", (o,n) => { (o as SensitiveType).ClassificationMethod = n.GetEnumValue<ClassificationMethod>(); } },
                {"description", (o,n) => { (o as SensitiveType).Description = n.GetStringValue(); } },
                {"name", (o,n) => { (o as SensitiveType).Name = n.GetStringValue(); } },
                {"publisherName", (o,n) => { (o as SensitiveType).PublisherName = n.GetStringValue(); } },
                {"rulePackageId", (o,n) => { (o as SensitiveType).RulePackageId = n.GetStringValue(); } },
                {"rulePackageType", (o,n) => { (o as SensitiveType).RulePackageType = n.GetStringValue(); } },
                {"scope", (o,n) => { (o as SensitiveType).Scope = n.GetEnumValue<SensitiveTypeScope>(); } },
                {"sensitiveTypeSource", (o,n) => { (o as SensitiveType).SensitiveTypeSource = n.GetEnumValue<SensitiveTypeSource>(); } },
                {"state", (o,n) => { (o as SensitiveType).State = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<ClassificationMethod>("classificationMethod", ClassificationMethod);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("publisherName", PublisherName);
            writer.WriteStringValue("rulePackageId", RulePackageId);
            writer.WriteStringValue("rulePackageType", RulePackageType);
            writer.WriteEnumValue<SensitiveTypeScope>("scope", Scope);
            writer.WriteEnumValue<SensitiveTypeSource>("sensitiveTypeSource", SensitiveTypeSource);
            writer.WriteStringValue("state", State);
        }
    }
}
