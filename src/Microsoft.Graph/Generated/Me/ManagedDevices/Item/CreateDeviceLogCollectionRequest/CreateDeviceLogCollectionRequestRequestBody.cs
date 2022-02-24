using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Me.ManagedDevices.Item.CreateDeviceLogCollectionRequest {
    public class CreateDeviceLogCollectionRequestRequestBody : IParsable {
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
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"templateType", (o,n) => { (o as CreateDeviceLogCollectionRequestRequestBody).TemplateType = n.GetObjectValue<DeviceLogCollectionRequest>(); } },
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
