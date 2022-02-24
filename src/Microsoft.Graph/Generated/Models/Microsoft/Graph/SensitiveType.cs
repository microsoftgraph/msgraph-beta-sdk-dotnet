using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class SensitiveType : Entity, IParsable {
        public ClassificationMethod? ClassificationMethod { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string PublisherName { get; set; }
        public string RulePackageId { get; set; }
        public string RulePackageType { get; set; }
        public SensitiveTypeScope? Scope { get; set; }
        public SensitiveTypeSource? SensitiveTypeSource { get; set; }
        public string State { get; set; }
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
