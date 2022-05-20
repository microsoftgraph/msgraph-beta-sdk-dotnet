using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceManagement.WindowsAutopilotDeviceIdentities.Item.UpdateDeviceProperties {
    /// <summary>Provides operations to call the updateDeviceProperties method.</summary>
    public class UpdateDevicePropertiesPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>The addressableUserName property</summary>
        public string AddressableUserName {
            get { return BackingStore?.Get<string>(nameof(AddressableUserName)); }
            set { BackingStore?.Set(nameof(AddressableUserName), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The deviceAccountPassword property</summary>
        public string DeviceAccountPassword {
            get { return BackingStore?.Get<string>(nameof(DeviceAccountPassword)); }
            set { BackingStore?.Set(nameof(DeviceAccountPassword), value); }
        }
        /// <summary>The deviceAccountUpn property</summary>
        public string DeviceAccountUpn {
            get { return BackingStore?.Get<string>(nameof(DeviceAccountUpn)); }
            set { BackingStore?.Set(nameof(DeviceAccountUpn), value); }
        }
        /// <summary>The deviceFriendlyName property</summary>
        public string DeviceFriendlyName {
            get { return BackingStore?.Get<string>(nameof(DeviceFriendlyName)); }
            set { BackingStore?.Set(nameof(DeviceFriendlyName), value); }
        }
        /// <summary>The displayName property</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The groupTag property</summary>
        public string GroupTag {
            get { return BackingStore?.Get<string>(nameof(GroupTag)); }
            set { BackingStore?.Set(nameof(GroupTag), value); }
        }
        /// <summary>The userPrincipalName property</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>(nameof(UserPrincipalName)); }
            set { BackingStore?.Set(nameof(UserPrincipalName), value); }
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
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
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
