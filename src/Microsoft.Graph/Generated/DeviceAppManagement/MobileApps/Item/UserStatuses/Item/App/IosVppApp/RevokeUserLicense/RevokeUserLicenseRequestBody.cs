using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.DeviceAppManagement.MobileApps.Item.UserStatuses.Item.App.IosVppApp.RevokeUserLicense {
    public class RevokeUserLicenseRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public bool? NotifyManagedDevices { get; set; }
        public string UserId { get; set; }
        /// <summary>
        /// Instantiates a new revokeUserLicenseRequestBody and sets the default values.
        /// </summary>
        public RevokeUserLicenseRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static RevokeUserLicenseRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RevokeUserLicenseRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"notifyManagedDevices", (o,n) => { (o as RevokeUserLicenseRequestBody).NotifyManagedDevices = n.GetBoolValue(); } },
                {"userId", (o,n) => { (o as RevokeUserLicenseRequestBody).UserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("notifyManagedDevices", NotifyManagedDevices);
            writer.WriteStringValue("userId", UserId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
