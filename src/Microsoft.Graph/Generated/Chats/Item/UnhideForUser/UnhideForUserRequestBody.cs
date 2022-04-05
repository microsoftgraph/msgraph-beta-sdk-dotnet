using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Chats.Item.UnhideForUser {
    /// <summary>Provides operations to call the unhideForUser method.</summary>
    public class UnhideForUserRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The tenantId property</summary>
        public string TenantId { get; set; }
        /// <summary>The user property</summary>
        public TeamworkUserIdentity User { get; set; }
        /// <summary>
        /// Instantiates a new unhideForUserRequestBody and sets the default values.
        /// </summary>
        public UnhideForUserRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UnhideForUserRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnhideForUserRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"tenantId", (o,n) => { (o as UnhideForUserRequestBody).TenantId = n.GetStringValue(); } },
                {"user", (o,n) => { (o as UnhideForUserRequestBody).User = n.GetObjectValue<TeamworkUserIdentity>(TeamworkUserIdentity.CreateFromDiscriminatorValue); } },
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
