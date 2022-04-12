using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Users.Item.SendMail {
    /// <summary>Provides operations to call the sendMail method.</summary>
    public class SendMailRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Message property</summary>
        public Microsoft.Graph.Beta.Models.Message Message { get; set; }
        /// <summary>The SaveToSentItems property</summary>
        public bool? SaveToSentItems { get; set; }
        /// <summary>
        /// Instantiates a new sendMailRequestBody and sets the default values.
        /// </summary>
        public SendMailRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SendMailRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SendMailRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"message", n => { Message = n.GetObjectValue<Microsoft.Graph.Beta.Models.Message>(Microsoft.Graph.Beta.Models.Message.CreateFromDiscriminatorValue); } },
                {"saveToSentItems", n => { SaveToSentItems = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Message>("message", Message);
            writer.WriteBoolValue("saveToSentItems", SaveToSentItems);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
