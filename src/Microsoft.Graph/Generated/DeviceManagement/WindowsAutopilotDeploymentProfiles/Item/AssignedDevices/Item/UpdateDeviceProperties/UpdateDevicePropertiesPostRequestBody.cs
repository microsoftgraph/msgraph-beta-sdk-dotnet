using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceManagement.WindowsAutopilotDeploymentProfiles.Item.AssignedDevices.Item.UpdateDeviceProperties {
    /// <summary>Provides operations to call the updateDeviceProperties method.</summary>
    public class UpdateDevicePropertiesPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The addressableUserName property</summary>
        public string AddressableUserName {
            get { return BackingStore?.Get<string>("addressableUserName"); }
            set { BackingStore?.Set("addressableUserName", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The deviceAccountPassword property</summary>
        public string DeviceAccountPassword {
            get { return BackingStore?.Get<string>("deviceAccountPassword"); }
            set { BackingStore?.Set("deviceAccountPassword", value); }
        }
        /// <summary>The deviceAccountUpn property</summary>
        public string DeviceAccountUpn {
            get { return BackingStore?.Get<string>("deviceAccountUpn"); }
            set { BackingStore?.Set("deviceAccountUpn", value); }
        }
        /// <summary>The deviceFriendlyName property</summary>
        public string DeviceFriendlyName {
            get { return BackingStore?.Get<string>("deviceFriendlyName"); }
            set { BackingStore?.Set("deviceFriendlyName", value); }
        }
        /// <summary>The displayName property</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The groupTag property</summary>
        public string GroupTag {
            get { return BackingStore?.Get<string>("groupTag"); }
            set { BackingStore?.Set("groupTag", value); }
        }
        /// <summary>The userPrincipalName property</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
        /// <summary>
        /// Instantiates a new updateDevicePropertiesPostRequestBody and sets the default values.
        /// </summary>
        public UpdateDevicePropertiesPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UpdateDevicePropertiesPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UpdateDevicePropertiesPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"addressableUserName", n => { AddressableUserName = n.GetStringValue(); } },
                {"deviceAccountPassword", n => { DeviceAccountPassword = n.GetStringValue(); } },
                {"deviceAccountUpn", n => { DeviceAccountUpn = n.GetStringValue(); } },
                {"deviceFriendlyName", n => { DeviceFriendlyName = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"groupTag", n => { GroupTag = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
