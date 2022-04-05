using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ResponsibleSensitiveType : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The description property</summary>
        public string Description { get; set; }
        /// <summary>The id property</summary>
        public string Id { get; set; }
        /// <summary>The name property</summary>
        public string Name { get; set; }
        /// <summary>The publisherName property</summary>
        public string PublisherName { get; set; }
        /// <summary>The rulePackageId property</summary>
        public string RulePackageId { get; set; }
        /// <summary>The rulePackageType property</summary>
        public string RulePackageType { get; set; }
        /// <summary>
        /// Instantiates a new responsibleSensitiveType and sets the default values.
        /// </summary>
        public ResponsibleSensitiveType() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ResponsibleSensitiveType CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ResponsibleSensitiveType();
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
