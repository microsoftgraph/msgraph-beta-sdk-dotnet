using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceManagement.WindowsAutopilotDeploymentProfiles.Item.AssignedDevices.Item.UpdateDeviceProperties {
    /// <summary>Provides operations to call the updateDeviceProperties method.</summary>
    public class UpdateDevicePropertiesRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The addressableUserName property</summary>
        public string AddressableUserName { get; set; }
        /// <summary>The deviceAccountPassword property</summary>
        public string DeviceAccountPassword { get; set; }
        /// <summary>The deviceAccountUpn property</summary>
        public string DeviceAccountUpn { get; set; }
        /// <summary>The deviceFriendlyName property</summary>
        public string DeviceFriendlyName { get; set; }
        /// <summary>The displayName property</summary>
        public string DisplayName { get; set; }
        /// <summary>The groupTag property</summary>
        public string GroupTag { get; set; }
        /// <summary>The userPrincipalName property</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// Instantiates a new updateDevicePropertiesRequestBody and sets the default values.
        /// </summary>
        public UpdateDevicePropertiesRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UpdateDevicePropertiesRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UpdateDevicePropertiesRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"addressableUserName", (o,n) => { (o as UpdateDevicePropertiesRequestBody).AddressableUserName = n.GetStringValue(); } },
                {"deviceAccountPassword", (o,n) => { (o as UpdateDevicePropertiesRequestBody).DeviceAccountPassword = n.GetStringValue(); } },
                {"deviceAccountUpn", (o,n) => { (o as UpdateDevicePropertiesRequestBody).DeviceAccountUpn = n.GetStringValue(); } },
                {"deviceFriendlyName", (o,n) => { (o as UpdateDevicePropertiesRequestBody).DeviceFriendlyName = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as UpdateDevicePropertiesRequestBody).DisplayName = n.GetStringValue(); } },
                {"groupTag", (o,n) => { (o as UpdateDevicePropertiesRequestBody).GroupTag = n.GetStringValue(); } },
                {"userPrincipalName", (o,n) => { (o as UpdateDevicePropertiesRequestBody).UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("addressableUserName", AddressableUserName);
            writer.WriteStringValue("deviceAccountPassword", DeviceAccountPassword);
            writer.WriteStringValue("deviceAccountUpn", DeviceAccountUpn);
            writer.WriteStringValue("deviceFriendlyName", DeviceFriendlyName);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("groupTag", GroupTag);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
