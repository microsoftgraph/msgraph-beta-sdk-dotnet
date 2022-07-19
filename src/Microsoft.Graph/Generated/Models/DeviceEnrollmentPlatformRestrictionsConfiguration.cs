using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceEnrollmentPlatformRestrictionsConfiguration : DeviceEnrollmentConfiguration, IParsable {
        /// <summary>Android for work restrictions based on platform, platform operating system version, and device ownership</summary>
        public DeviceEnrollmentPlatformRestriction AndroidForWorkRestriction {
            get { return BackingStore?.Get<DeviceEnrollmentPlatformRestriction>("androidForWorkRestriction"); }
            set { BackingStore?.Set("androidForWorkRestriction", value); }
        }
        /// <summary>Android restrictions based on platform, platform operating system version, and device ownership</summary>
        public DeviceEnrollmentPlatformRestriction AndroidRestriction {
            get { return BackingStore?.Get<DeviceEnrollmentPlatformRestriction>("androidRestriction"); }
            set { BackingStore?.Set("androidRestriction", value); }
        }
        /// <summary>Ios restrictions based on platform, platform operating system version, and device ownership</summary>
        public DeviceEnrollmentPlatformRestriction IosRestriction {
            get { return BackingStore?.Get<DeviceEnrollmentPlatformRestriction>("iosRestriction"); }
            set { BackingStore?.Set("iosRestriction", value); }
        }
        /// <summary>Mac restrictions based on platform, platform operating system version, and device ownership</summary>
        public DeviceEnrollmentPlatformRestriction MacOSRestriction {
            get { return BackingStore?.Get<DeviceEnrollmentPlatformRestriction>("macOSRestriction"); }
            set { BackingStore?.Set("macOSRestriction", value); }
        }
        /// <summary>Mac restrictions based on platform, platform operating system version, and device ownership</summary>
        public DeviceEnrollmentPlatformRestriction MacRestriction {
            get { return BackingStore?.Get<DeviceEnrollmentPlatformRestriction>("macRestriction"); }
            set { BackingStore?.Set("macRestriction", value); }
        }
        /// <summary>Windows Home Sku restrictions based on platform, platform operating system version, and device ownership</summary>
        public DeviceEnrollmentPlatformRestriction WindowsHomeSkuRestriction {
            get { return BackingStore?.Get<DeviceEnrollmentPlatformRestriction>("windowsHomeSkuRestriction"); }
            set { BackingStore?.Set("windowsHomeSkuRestriction", value); }
        }
        /// <summary>Windows mobile restrictions based on platform, platform operating system version, and device ownership</summary>
        public DeviceEnrollmentPlatformRestriction WindowsMobileRestriction {
            get { return BackingStore?.Get<DeviceEnrollmentPlatformRestriction>("windowsMobileRestriction"); }
            set { BackingStore?.Set("windowsMobileRestriction", value); }
        }
        /// <summary>Windows restrictions based on platform, platform operating system version, and device ownership</summary>
        public DeviceEnrollmentPlatformRestriction WindowsRestriction {
            get { return BackingStore?.Get<DeviceEnrollmentPlatformRestriction>("windowsRestriction"); }
            set { BackingStore?.Set("windowsRestriction", value); }
        }
        /// <summary>
        /// Instantiates a new DeviceEnrollmentPlatformRestrictionsConfiguration and sets the default values.
        /// </summary>
        public DeviceEnrollmentPlatformRestrictionsConfiguration() : base() {
            OdataType = "#microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceEnrollmentPlatformRestrictionsConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceEnrollmentPlatformRestrictionsConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"androidForWorkRestriction", n => { AndroidForWorkRestriction = n.GetObjectValue<DeviceEnrollmentPlatformRestriction>(DeviceEnrollmentPlatformRestriction.CreateFromDiscriminatorValue); } },
                {"androidRestriction", n => { AndroidRestriction = n.GetObjectValue<DeviceEnrollmentPlatformRestriction>(DeviceEnrollmentPlatformRestriction.CreateFromDiscriminatorValue); } },
                {"iosRestriction", n => { IosRestriction = n.GetObjectValue<DeviceEnrollmentPlatformRestriction>(DeviceEnrollmentPlatformRestriction.CreateFromDiscriminatorValue); } },
                {"macOSRestriction", n => { MacOSRestriction = n.GetObjectValue<DeviceEnrollmentPlatformRestriction>(DeviceEnrollmentPlatformRestriction.CreateFromDiscriminatorValue); } },
                {"macRestriction", n => { MacRestriction = n.GetObjectValue<DeviceEnrollmentPlatformRestriction>(DeviceEnrollmentPlatformRestriction.CreateFromDiscriminatorValue); } },
                {"windowsHomeSkuRestriction", n => { WindowsHomeSkuRestriction = n.GetObjectValue<DeviceEnrollmentPlatformRestriction>(DeviceEnrollmentPlatformRestriction.CreateFromDiscriminatorValue); } },
                {"windowsMobileRestriction", n => { WindowsMobileRestriction = n.GetObjectValue<DeviceEnrollmentPlatformRestriction>(DeviceEnrollmentPlatformRestriction.CreateFromDiscriminatorValue); } },
                {"windowsRestriction", n => { WindowsRestriction = n.GetObjectValue<DeviceEnrollmentPlatformRestriction>(DeviceEnrollmentPlatformRestriction.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<DeviceEnrollmentPlatformRestriction>("androidForWorkRestriction", AndroidForWorkRestriction);
            writer.WriteObjectValue<DeviceEnrollmentPlatformRestriction>("androidRestriction", AndroidRestriction);
            writer.WriteObjectValue<DeviceEnrollmentPlatformRestriction>("iosRestriction", IosRestriction);
            writer.WriteObjectValue<DeviceEnrollmentPlatformRestriction>("macOSRestriction", MacOSRestriction);
            writer.WriteObjectValue<DeviceEnrollmentPlatformRestriction>("macRestriction", MacRestriction);
            writer.WriteObjectValue<DeviceEnrollmentPlatformRestriction>("windowsHomeSkuRestriction", WindowsHomeSkuRestriction);
            writer.WriteObjectValue<DeviceEnrollmentPlatformRestriction>("windowsMobileRestriction", WindowsMobileRestriction);
            writer.WriteObjectValue<DeviceEnrollmentPlatformRestriction>("windowsRestriction", WindowsRestriction);
        }
    }
}
