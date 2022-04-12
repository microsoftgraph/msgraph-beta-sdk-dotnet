using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CloudPcSourceDeviceImage : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The display name for the source image.</summary>
        public string DisplayName { get; set; }
        /// <summary>The ID of the source image.</summary>
        public string Id { get; set; }
        /// <summary>The display name of subscription that hosts the source image.</summary>
        public string SubscriptionDisplayName { get; set; }
        /// <summary>The ID of subscription that hosts the source image.</summary>
        public string SubscriptionId { get; set; }
        /// <summary>
        /// Instantiates a new cloudPcSourceDeviceImage and sets the default values.
        /// </summary>
        public CloudPcSourceDeviceImage() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CloudPcSourceDeviceImage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcSourceDeviceImage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"subscriptionDisplayName", n => { SubscriptionDisplayName = n.GetStringValue(); } },
                {"subscriptionId", n => { SubscriptionId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("subscriptionDisplayName", SubscriptionDisplayName);
            writer.WriteStringValue("subscriptionId", SubscriptionId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
