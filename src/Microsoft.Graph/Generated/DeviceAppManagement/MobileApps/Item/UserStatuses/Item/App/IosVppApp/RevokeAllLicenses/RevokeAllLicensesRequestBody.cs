using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.DeviceAppManagement.MobileApps.Item.UserStatuses.Item.App.IosVppApp.RevokeAllLicenses {
    public class RevokeAllLicensesRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public bool? NotifyManagedDevices { get; set; }
        /// <summary>
        /// Instantiates a new revokeAllLicensesRequestBody and sets the default values.
        /// </summary>
        public RevokeAllLicensesRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"notifyManagedDevices", (o,n) => { (o as RevokeAllLicensesRequestBody).NotifyManagedDevices = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("notifyManagedDevices", NotifyManagedDevices);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
