using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Chats.Item.MarkChatReadForUser {
    /// <summary>Provides operations to call the markChatReadForUser method.</summary>
    public class MarkChatReadForUserRequestBody : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string TenantId { get; set; }
        public TeamworkUserIdentity User { get; set; }
        /// <summary>
        /// Instantiates a new markChatReadForUserRequestBody and sets the default values.
        /// </summary>
        public MarkChatReadForUserRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static MarkChatReadForUserRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MarkChatReadForUserRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"tenantId", (o,n) => { (o as MarkChatReadForUserRequestBody).TenantId = n.GetStringValue(); } },
                {"user", (o,n) => { (o as MarkChatReadForUserRequestBody).User = n.GetObjectValue<TeamworkUserIdentity>(TeamworkUserIdentity.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteObjectValue<TeamworkUserIdentity>("user", User);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
