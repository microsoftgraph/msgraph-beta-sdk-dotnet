using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.DeviceAppManagement.MobileApps.Item.IosVppApp.RevokeDeviceLicense {
    public class RevokeDeviceLicenseRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string ManagedDeviceId { get; set; }
        public bool? NotifyManagedDevices { get; set; }
        /// <summary>
        /// Instantiates a new revokeDeviceLicenseRequestBody and sets the default values.
        /// </summary>
        public RevokeDeviceLicenseRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"managedDeviceId", (o,n) => { (o as RevokeDeviceLicenseRequestBody).ManagedDeviceId = n.GetStringValue(); } },
                {"notifyManagedDevices", (o,n) => { (o as RevokeDeviceLicenseRequestBody).NotifyManagedDevices = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("managedDeviceId", ManagedDeviceId);
            writer.WriteBoolValue("notifyManagedDevices", NotifyManagedDevices);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
