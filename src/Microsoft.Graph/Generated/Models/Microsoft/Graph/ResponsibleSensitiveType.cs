using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class ResponsibleSensitiveType : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string Description { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string PublisherName { get; set; }
        public string RulePackageId { get; set; }
        public string RulePackageType { get; set; }
        /// <summary>
        /// Instantiates a new responsibleSensitiveType and sets the default values.
        /// </summary>
        public ResponsibleSensitiveType() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"description", (o,n) => { (o as ResponsibleSensitiveType).Description = n.GetStringValue(); } },
                {"id", (o,n) => { (o as ResponsibleSensitiveType).Id = n.GetStringValue(); } },
                {"name", (o,n) => { (o as ResponsibleSensitiveType).Name = n.GetStringValue(); } },
                {"publisherName", (o,n) => { (o as ResponsibleSensitiveType).PublisherName = n.GetStringValue(); } },
                {"rulePackageId", (o,n) => { (o as ResponsibleSensitiveType).RulePackageId = n.GetStringValue(); } },
                {"rulePackageType", (o,n) => { (o as ResponsibleSensitiveType).RulePackageType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("publisherName", PublisherName);
            writer.WriteStringValue("rulePackageId", RulePackageId);
            writer.WriteStringValue("rulePackageType", RulePackageType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
