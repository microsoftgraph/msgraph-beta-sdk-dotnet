using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Credential : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The name of the field for this credential. e.g, username or password or phoneNumber. This is defined by the application. Must match what is in the html field on singleSignOnSettings/password object.</summary>
        public string FieldId { get; set; }
        /// <summary>The type for this credential. Valid values: username, password, or other.</summary>
        public string Type { get; set; }
        /// <summary>The value for this credential. e.g, mysuperhiddenpassword. Note the value for passwords is write-only, the value can never be read back.</summary>
        public string Value { get; set; }
        /// <summary>
        /// Instantiates a new credential and sets the default values.
        /// </summary>
        public Credential() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static Credential CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Credential();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"fieldId", (o,n) => { (o as Credential).FieldId = n.GetStringValue(); } },
                {"type", (o,n) => { (o as Credential).Type = n.GetStringValue(); } },
                {"value", (o,n) => { (o as Credential).Value = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("fieldId", FieldId);
            writer.WriteStringValue("type", Type);
            writer.WriteStringValue("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
