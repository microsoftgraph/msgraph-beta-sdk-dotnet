using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceEnrollmentPlatformRestrictionsConfiguration : DeviceEnrollmentConfiguration, IParsable {
        /// <summary>Android for work restrictions based on platform, platform operating system version, and device ownership</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceEnrollmentPlatformRestriction? AndroidForWorkRestriction {
            get { return BackingStore?.Get<DeviceEnrollmentPlatformRestriction?>("androidForWorkRestriction"); }
            set { BackingStore?.Set("androidForWorkRestriction", value); }
        }
#nullable restore
#else
        public DeviceEnrollmentPlatformRestriction AndroidForWorkRestriction {
            get { return BackingStore?.Get<DeviceEnrollmentPlatformRestriction>("androidForWorkRestriction"); }
            set { BackingStore?.Set("androidForWorkRestriction", value); }
        }
#endif
        /// <summary>Android restrictions based on platform, platform operating system version, and device ownership</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceEnrollmentPlatformRestriction? AndroidRestriction {
            get { return BackingStore?.Get<DeviceEnrollmentPlatformRestriction?>("androidRestriction"); }
            set { BackingStore?.Set("androidRestriction", value); }
        }
#nullable restore
#else
        public DeviceEnrollmentPlatformRestriction AndroidRestriction {
            get { return BackingStore?.Get<DeviceEnrollmentPlatformRestriction>("androidRestriction"); }
            set { BackingStore?.Set("androidRestriction", value); }
        }
#endif
        /// <summary>Ios restrictions based on platform, platform operating system version, and device ownership</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceEnrollmentPlatformRestriction? IosRestriction {
            get { return BackingStore?.Get<DeviceEnrollmentPlatformRestriction?>("iosRestriction"); }
            set { BackingStore?.Set("iosRestriction", value); }
        }
#nullable restore
#else
        public DeviceEnrollmentPlatformRestriction IosRestriction {
            get { return BackingStore?.Get<DeviceEnrollmentPlatformRestriction>("iosRestriction"); }
            set { BackingStore?.Set("iosRestriction", value); }
        }
#endif
        /// <summary>Mac restrictions based on platform, platform operating system version, and device ownership</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceEnrollmentPlatformRestriction? MacOSRestriction {
            get { return BackingStore?.Get<DeviceEnrollmentPlatformRestriction?>("macOSRestriction"); }
            set { BackingStore?.Set("macOSRestriction", value); }
        }
#nullable restore
#else
        public DeviceEnrollmentPlatformRestriction MacOSRestriction {
            get { return BackingStore?.Get<DeviceEnrollmentPlatformRestriction>("macOSRestriction"); }
            set { BackingStore?.Set("macOSRestriction", value); }
        }
#endif
        /// <summary>Mac restrictions based on platform, platform operating system version, and device ownership</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceEnrollmentPlatformRestriction? MacRestriction {
            get { return BackingStore?.Get<DeviceEnrollmentPlatformRestriction?>("macRestriction"); }
            set { BackingStore?.Set("macRestriction", value); }
        }
#nullable restore
#else
        public DeviceEnrollmentPlatformRestriction MacRestriction {
            get { return BackingStore?.Get<DeviceEnrollmentPlatformRestriction>("macRestriction"); }
            set { BackingStore?.Set("macRestriction", value); }
        }
#endif
        /// <summary>Windows Home Sku restrictions based on platform, platform operating system version, and device ownership</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceEnrollmentPlatformRestriction? WindowsHomeSkuRestriction {
            get { return BackingStore?.Get<DeviceEnrollmentPlatformRestriction?>("windowsHomeSkuRestriction"); }
            set { BackingStore?.Set("windowsHomeSkuRestriction", value); }
        }
#nullable restore
#else
        public DeviceEnrollmentPlatformRestriction WindowsHomeSkuRestriction {
            get { return BackingStore?.Get<DeviceEnrollmentPlatformRestriction>("windowsHomeSkuRestriction"); }
            set { BackingStore?.Set("windowsHomeSkuRestriction", value); }
        }
#endif
        /// <summary>Windows mobile restrictions based on platform, platform operating system version, and device ownership</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceEnrollmentPlatformRestriction? WindowsMobileRestriction {
            get { return BackingStore?.Get<DeviceEnrollmentPlatformRestriction?>("windowsMobileRestriction"); }
            set { BackingStore?.Set("windowsMobileRestriction", value); }
        }
#nullable restore
#else
        public DeviceEnrollmentPlatformRestriction WindowsMobileRestriction {
            get { return BackingStore?.Get<DeviceEnrollmentPlatformRestriction>("windowsMobileRestriction"); }
            set { BackingStore?.Set("windowsMobileRestriction", value); }
        }
#endif
        /// <summary>Windows restrictions based on platform, platform operating system version, and device ownership</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceEnrollmentPlatformRestriction? WindowsRestriction {
            get { return BackingStore?.Get<DeviceEnrollmentPlatformRestriction?>("windowsRestriction"); }
            set { BackingStore?.Set("windowsRestriction", value); }
        }
#nullable restore
#else
        public DeviceEnrollmentPlatformRestriction WindowsRestriction {
            get { return BackingStore?.Get<DeviceEnrollmentPlatformRestriction>("windowsRestriction"); }
            set { BackingStore?.Set("windowsRestriction", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new DeviceEnrollmentPlatformRestrictionsConfiguration and sets the default values.
        /// </summary>
        public DeviceEnrollmentPlatformRestrictionsConfiguration() : base() {
            OdataType = "#microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
