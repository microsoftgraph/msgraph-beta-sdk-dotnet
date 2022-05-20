using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Device operating system summary.</summary>
    public class DeviceOperatingSystemSummary : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>The count of Corporate work profile Android devices. Also known as Corporate Owned Personally Enabled (COPE). Valid values -1 to 2147483647</summary>
        public int? AndroidCorporateWorkProfileCount {
            get { return BackingStore?.Get<int?>(nameof(AndroidCorporateWorkProfileCount)); }
            set { BackingStore?.Set(nameof(AndroidCorporateWorkProfileCount), value); }
        }
        /// <summary>Number of android device count.</summary>
        public int? AndroidCount {
            get { return BackingStore?.Get<int?>(nameof(AndroidCount)); }
            set { BackingStore?.Set(nameof(AndroidCount), value); }
        }
        /// <summary>Number of dedicated Android devices.</summary>
        public int? AndroidDedicatedCount {
            get { return BackingStore?.Get<int?>(nameof(AndroidDedicatedCount)); }
            set { BackingStore?.Set(nameof(AndroidDedicatedCount), value); }
        }
        /// <summary>Number of device admin Android devices.</summary>
        public int? AndroidDeviceAdminCount {
            get { return BackingStore?.Get<int?>(nameof(AndroidDeviceAdminCount)); }
            set { BackingStore?.Set(nameof(AndroidDeviceAdminCount), value); }
        }
        /// <summary>Number of fully managed Android devices.</summary>
        public int? AndroidFullyManagedCount {
            get { return BackingStore?.Get<int?>(nameof(AndroidFullyManagedCount)); }
            set { BackingStore?.Set(nameof(AndroidFullyManagedCount), value); }
        }
        /// <summary>Number of work profile Android devices.</summary>
        public int? AndroidWorkProfileCount {
            get { return BackingStore?.Get<int?>(nameof(AndroidWorkProfileCount)); }
            set { BackingStore?.Set(nameof(AndroidWorkProfileCount), value); }
        }
        /// <summary>Number of AOSP user-associated Android devices. Valid values 0 to 2147483647</summary>
        public int? AospUserAssociatedCount {
            get { return BackingStore?.Get<int?>(nameof(AospUserAssociatedCount)); }
            set { BackingStore?.Set(nameof(AospUserAssociatedCount), value); }
        }
        /// <summary>Number of AOSP userless Android devices. Valid values 0 to 2147483647</summary>
        public int? AospUserlessCount {
            get { return BackingStore?.Get<int?>(nameof(AospUserlessCount)); }
            set { BackingStore?.Set(nameof(AospUserlessCount), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Number of Chrome OS devices. Valid values 0 to 2147483647</summary>
        public int? ChromeOSCount {
            get { return BackingStore?.Get<int?>(nameof(ChromeOSCount)); }
            set { BackingStore?.Set(nameof(ChromeOSCount), value); }
        }
        /// <summary>Number of ConfigMgr managed devices.</summary>
        public int? ConfigMgrDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(ConfigMgrDeviceCount)); }
            set { BackingStore?.Set(nameof(ConfigMgrDeviceCount), value); }
        }
        /// <summary>Number of iOS device count.</summary>
        public int? IosCount {
            get { return BackingStore?.Get<int?>(nameof(IosCount)); }
            set { BackingStore?.Set(nameof(IosCount), value); }
        }
        /// <summary>Number of Linux OS devices. Valid values 0 to 2147483647</summary>
        public int? LinuxCount {
            get { return BackingStore?.Get<int?>(nameof(LinuxCount)); }
            set { BackingStore?.Set(nameof(LinuxCount), value); }
        }
        /// <summary>Number of Mac OS X device count.</summary>
        public int? MacOSCount {
            get { return BackingStore?.Get<int?>(nameof(MacOSCount)); }
            set { BackingStore?.Set(nameof(MacOSCount), value); }
        }
        /// <summary>Number of unknown device count.</summary>
        public int? UnknownCount {
            get { return BackingStore?.Get<int?>(nameof(UnknownCount)); }
            set { BackingStore?.Set(nameof(UnknownCount), value); }
        }
        /// <summary>Number of Windows device count.</summary>
        public int? WindowsCount {
            get { return BackingStore?.Get<int?>(nameof(WindowsCount)); }
            set { BackingStore?.Set(nameof(WindowsCount), value); }
        }
        /// <summary>Number of Windows mobile device count.</summary>
        public int? WindowsMobileCount {
            get { return BackingStore?.Get<int?>(nameof(WindowsMobileCount)); }
            set { BackingStore?.Set(nameof(WindowsMobileCount), value); }
        }
        /// <summary>
        /// Instantiates a new deviceOperatingSystemSummary and sets the default values.
        /// </summary>
        public DeviceOperatingSystemSummary() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceOperatingSystemSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceOperatingSystemSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"androidCorporateWorkProfileCount", n => { AndroidCorporateWorkProfileCount = n.GetIntValue(); } },
                {"androidCount", n => { AndroidCount = n.GetIntValue(); } },
                {"androidDedicatedCount", n => { AndroidDedicatedCount = n.GetIntValue(); } },
                {"androidDeviceAdminCount", n => { AndroidDeviceAdminCount = n.GetIntValue(); } },
                {"androidFullyManagedCount", n => { AndroidFullyManagedCount = n.GetIntValue(); } },
                {"androidWorkProfileCount", n => { AndroidWorkProfileCount = n.GetIntValue(); } },
                {"aospUserAssociatedCount", n => { AospUserAssociatedCount = n.GetIntValue(); } },
                {"aospUserlessCount", n => { AospUserlessCount = n.GetIntValue(); } },
                {"chromeOSCount", n => { ChromeOSCount = n.GetIntValue(); } },
                {"configMgrDeviceCount", n => { ConfigMgrDeviceCount = n.GetIntValue(); } },
                {"iosCount", n => { IosCount = n.GetIntValue(); } },
                {"linuxCount", n => { LinuxCount = n.GetIntValue(); } },
                {"macOSCount", n => { MacOSCount = n.GetIntValue(); } },
                {"unknownCount", n => { UnknownCount = n.GetIntValue(); } },
                {"windowsCount", n => { WindowsCount = n.GetIntValue(); } },
                {"windowsMobileCount", n => { WindowsMobileCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("androidCorporateWorkProfileCount", AndroidCorporateWorkProfileCount);
            writer.WriteIntValue("androidCount", AndroidCount);
            writer.WriteIntValue("androidDedicatedCount", AndroidDedicatedCount);
            writer.WriteIntValue("androidDeviceAdminCount", AndroidDeviceAdminCount);
            writer.WriteIntValue("androidFullyManagedCount", AndroidFullyManagedCount);
            writer.WriteIntValue("androidWorkProfileCount", AndroidWorkProfileCount);
            writer.WriteIntValue("aospUserAssociatedCount", AospUserAssociatedCount);
            writer.WriteIntValue("aospUserlessCount", AospUserlessCount);
            writer.WriteIntValue("chromeOSCount", ChromeOSCount);
            writer.WriteIntValue("configMgrDeviceCount", ConfigMgrDeviceCount);
            writer.WriteIntValue("iosCount", IosCount);
            writer.WriteIntValue("linuxCount", LinuxCount);
            writer.WriteIntValue("macOSCount", MacOSCount);
            writer.WriteIntValue("unknownCount", UnknownCount);
            writer.WriteIntValue("windowsCount", WindowsCount);
            writer.WriteIntValue("windowsMobileCount", WindowsMobileCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
