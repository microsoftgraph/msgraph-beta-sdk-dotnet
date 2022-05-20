using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementConfigurationSettingApplicability : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>description of the setting</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>Device Mode that setting can be applied on. Possible values are: none, kiosk.</summary>
        public DeviceManagementConfigurationDeviceMode? DeviceMode {
            get { return BackingStore?.Get<DeviceManagementConfigurationDeviceMode?>(nameof(DeviceMode)); }
            set { BackingStore?.Set(nameof(DeviceMode), value); }
        }
        /// <summary>Platform setting can be applied on. Possible values are: none, android, iOS, macOS, windows10X, windows10, linux, unknownFutureValue.</summary>
        public DeviceManagementConfigurationPlatforms? Platform {
            get { return BackingStore?.Get<DeviceManagementConfigurationPlatforms?>(nameof(Platform)); }
            set { BackingStore?.Set(nameof(Platform), value); }
        }
        /// <summary>Which technology channels this setting can be deployed through. Possible values are: none, mdm, windows10XManagement, configManager, appleRemoteManagement, microsoftSense, exchangeOnline, linuxMdm, unknownFutureValue.</summary>
        public DeviceManagementConfigurationTechnologies? Technologies {
            get { return BackingStore?.Get<DeviceManagementConfigurationTechnologies?>(nameof(Technologies)); }
            set { BackingStore?.Set(nameof(Technologies), value); }
        }
        /// <summary>
        /// Instantiates a new deviceManagementConfigurationSettingApplicability and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationSettingApplicability() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceManagementConfigurationSettingApplicability CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationSettingApplicability();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"description", n => { Description = n.GetStringValue(); } },
                {"deviceMode", n => { DeviceMode = n.GetEnumValue<DeviceManagementConfigurationDeviceMode>(); } },
                {"platform", n => { Platform = n.GetEnumValue<DeviceManagementConfigurationPlatforms>(); } },
                {"technologies", n => { Technologies = n.GetEnumValue<DeviceManagementConfigurationTechnologies>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteEnumValue<DeviceManagementConfigurationDeviceMode>("deviceMode", DeviceMode);
            writer.WriteEnumValue<DeviceManagementConfigurationPlatforms>("platform", Platform);
            writer.WriteEnumValue<DeviceManagementConfigurationTechnologies>("technologies", Technologies);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
