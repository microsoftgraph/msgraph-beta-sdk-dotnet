using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.DeviceManagement.ComanagedDevices.Item.CreateDeviceLogCollectionRequest {
    /// <summary>Provides operations to call the createDeviceLogCollectionRequest method.</summary>
    public class CreateDeviceLogCollectionRequestRequestBody : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public DeviceLogCollectionRequest TemplateType { get; set; }
        /// <summary>
        /// Instantiates a new createDeviceLogCollectionRequestRequestBody and sets the default values.
        /// </summary>
        public CreateDeviceLogCollectionRequestRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CreateDeviceLogCollectionRequestRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CreateDeviceLogCollectionRequestRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"templateType", (o,n) => { (o as CreateDeviceLogCollectionRequestRequestBody).TemplateType = n.GetObjectValue<DeviceLogCollectionRequest>(DeviceLogCollectionRequest.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<DeviceLogCollectionRequest>("templateType", TemplateType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
