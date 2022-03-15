using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class AuditResource : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Display name.</summary>
        public string DisplayName { get; set; }
        /// <summary>List of modified properties.</summary>
        public List<AuditProperty> ModifiedProperties { get; set; }
        /// <summary>Audit resource's Id.</summary>
        public string ResourceId { get; set; }
        /// <summary>Audit resource's type.</summary>
        public string Type { get; set; }
        /// <summary>
        /// Instantiates a new auditResource and sets the default values.
        /// </summary>
        public AuditResource() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AuditResource CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuditResource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"displayName", (o,n) => { (o as AuditResource).DisplayName = n.GetStringValue(); } },
                {"modifiedProperties", (o,n) => { (o as AuditResource).ModifiedProperties = n.GetCollectionOfObjectValues<AuditProperty>(AuditProperty.CreateFromDiscriminatorValue).ToList(); } },
                {"resourceId", (o,n) => { (o as AuditResource).ResourceId = n.GetStringValue(); } },
                {"type", (o,n) => { (o as AuditResource).Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<AuditProperty>("modifiedProperties", ModifiedProperties);
            writer.WriteStringValue("resourceId", ResourceId);
            writer.WriteStringValue("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
