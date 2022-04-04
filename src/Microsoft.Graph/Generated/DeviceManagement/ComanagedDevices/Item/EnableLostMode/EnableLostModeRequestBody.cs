using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.DeviceManagement.ComanagedDevices.Item.EnableLostMode {
    /// <summary>Provides operations to call the enableLostMode method.</summary>
    public class EnableLostModeRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The footer property</summary>
        public string Footer { get; set; }
        /// <summary>The message property</summary>
        public string Message { get; set; }
        /// <summary>The phoneNumber property</summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Instantiates a new enableLostModeRequestBody and sets the default values.
        /// </summary>
        public EnableLostModeRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static EnableLostModeRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EnableLostModeRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"footer", (o,n) => { (o as EnableLostModeRequestBody).Footer = n.GetStringValue(); } },
                {"message", (o,n) => { (o as EnableLostModeRequestBody).Message = n.GetStringValue(); } },
                {"phoneNumber", (o,n) => { (o as EnableLostModeRequestBody).PhoneNumber = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("footer", Footer);
            writer.WriteStringValue("message", Message);
            writer.WriteStringValue("phoneNumber", PhoneNumber);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
