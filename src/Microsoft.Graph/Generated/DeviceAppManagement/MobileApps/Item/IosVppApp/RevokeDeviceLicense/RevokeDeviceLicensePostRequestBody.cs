using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.IosVppApp.RevokeDeviceLicense {
    /// <summary>Provides operations to call the revokeDeviceLicense method.</summary>
    public class RevokeDeviceLicensePostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The managedDeviceId property</summary>
        public string ManagedDeviceId {
            get { return BackingStore?.Get<string>(nameof(ManagedDeviceId)); }
            set { BackingStore?.Set(nameof(ManagedDeviceId), value); }
        }
        /// <summary>The notifyManagedDevices property</summary>
        public bool? NotifyManagedDevices {
            get { return BackingStore?.Get<bool?>(nameof(NotifyManagedDevices)); }
            set { BackingStore?.Set(nameof(NotifyManagedDevices), value); }
        }
        /// <summary>
        /// Instantiates a new revokeDeviceLicensePostRequestBody and sets the default values.
        /// </summary>
        public RevokeDeviceLicensePostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static RevokeDeviceLicensePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RevokeDeviceLicensePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"managedDeviceId", n => { ManagedDeviceId = n.GetStringValue(); } },
                {"notifyManagedDevices", n => { NotifyManagedDevices = n.GetBoolValue(); } },
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
