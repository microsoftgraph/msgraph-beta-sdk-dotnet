using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class OutboundSharedUserProfile : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<TenantReference> Tenants { get; set; }
        public string UserId { get; set; }
        /// <summary>
        /// Instantiates a new outboundSharedUserProfile and sets the default values.
        /// </summary>
        public OutboundSharedUserProfile() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static OutboundSharedUserProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OutboundSharedUserProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"tenants", (o,n) => { (o as OutboundSharedUserProfile).Tenants = n.GetCollectionOfObjectValues<TenantReference>(TenantReference.CreateFromDiscriminatorValue).ToList(); } },
                {"userId", (o,n) => { (o as OutboundSharedUserProfile).UserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<TenantReference>("tenants", Tenants);
            writer.WriteStringValue("userId", UserId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
