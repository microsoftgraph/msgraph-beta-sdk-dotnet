using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Conflict summary for a set of device configuration policies.</summary>
    public class DeviceConfigurationTargetedUserAndDevice : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The id of the device in the checkin.</summary>
        public string DeviceId { get; set; }
        /// <summary>The name of the device in the checkin.</summary>
        public string DeviceName { get; set; }
        /// <summary>Last checkin time for this user/device pair.</summary>
        public DateTimeOffset? LastCheckinDateTime { get; set; }
        /// <summary>The display name of the user in the checkin</summary>
        public string UserDisplayName { get; set; }
        /// <summary>The id of the user in the checkin.</summary>
        public string UserId { get; set; }
        /// <summary>The UPN of the user in the checkin.</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// Instantiates a new deviceConfigurationTargetedUserAndDevice and sets the default values.
        /// </summary>
        public DeviceConfigurationTargetedUserAndDevice() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceConfigurationTargetedUserAndDevice CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceConfigurationTargetedUserAndDevice();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"deviceId", (o,n) => { (o as DeviceConfigurationTargetedUserAndDevice).DeviceId = n.GetStringValue(); } },
                {"deviceName", (o,n) => { (o as DeviceConfigurationTargetedUserAndDevice).DeviceName = n.GetStringValue(); } },
                {"lastCheckinDateTime", (o,n) => { (o as DeviceConfigurationTargetedUserAndDevice).LastCheckinDateTime = n.GetDateTimeOffsetValue(); } },
                {"userDisplayName", (o,n) => { (o as DeviceConfigurationTargetedUserAndDevice).UserDisplayName = n.GetStringValue(); } },
                {"userId", (o,n) => { (o as DeviceConfigurationTargetedUserAndDevice).UserId = n.GetStringValue(); } },
                {"userPrincipalName", (o,n) => { (o as DeviceConfigurationTargetedUserAndDevice).UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteDateTimeOffsetValue("lastCheckinDateTime", LastCheckinDateTime);
            writer.WriteStringValue("userDisplayName", UserDisplayName);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
