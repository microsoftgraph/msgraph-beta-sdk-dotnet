using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Device operating system summary.</summary>
    public class DeviceOperatingSystemSummary : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The count of Corporate work profile Android devices. Also known as Corporate Owned Personally Enabled (COPE). Valid values -1 to 2147483647</summary>
        public int? AndroidCorporateWorkProfileCount { get; set; }
        /// <summary>Number of android device count.</summary>
        public int? AndroidCount { get; set; }
        /// <summary>Number of dedicated Android devices.</summary>
        public int? AndroidDedicatedCount { get; set; }
        /// <summary>Number of device admin Android devices.</summary>
        public int? AndroidDeviceAdminCount { get; set; }
        /// <summary>Number of fully managed Android devices.</summary>
        public int? AndroidFullyManagedCount { get; set; }
        /// <summary>Number of work profile Android devices.</summary>
        public int? AndroidWorkProfileCount { get; set; }
        /// <summary>Number of AOSP user-associated Android devices. Valid values 0 to 2147483647</summary>
        public int? AospUserAssociatedCount { get; set; }
        /// <summary>Number of AOSP userless Android devices. Valid values 0 to 2147483647</summary>
        public int? AospUserlessCount { get; set; }
        /// <summary>Number of Chrome OS devices. Valid values 0 to 2147483647</summary>
        public int? ChromeOSCount { get; set; }
        /// <summary>Number of ConfigMgr managed devices.</summary>
        public int? ConfigMgrDeviceCount { get; set; }
        /// <summary>Number of iOS device count.</summary>
        public int? IosCount { get; set; }
        /// <summary>Number of Linux OS devices. Valid values 0 to 2147483647</summary>
        public int? LinuxCount { get; set; }
        /// <summary>Number of Mac OS X device count.</summary>
        public int? MacOSCount { get; set; }
        /// <summary>Number of unknown device count.</summary>
        public int? UnknownCount { get; set; }
        /// <summary>Number of Windows device count.</summary>
        public int? WindowsCount { get; set; }
        /// <summary>Number of Windows mobile device count.</summary>
        public int? WindowsMobileCount { get; set; }
        /// <summary>
        /// Instantiates a new deviceOperatingSystemSummary and sets the default values.
        /// </summary>
        public DeviceOperatingSystemSummary() {
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
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"androidCorporateWorkProfileCount", (o,n) => { (o as DeviceOperatingSystemSummary).AndroidCorporateWorkProfileCount = n.GetIntValue(); } },
                {"androidCount", (o,n) => { (o as DeviceOperatingSystemSummary).AndroidCount = n.GetIntValue(); } },
                {"androidDedicatedCount", (o,n) => { (o as DeviceOperatingSystemSummary).AndroidDedicatedCount = n.GetIntValue(); } },
                {"androidDeviceAdminCount", (o,n) => { (o as DeviceOperatingSystemSummary).AndroidDeviceAdminCount = n.GetIntValue(); } },
                {"androidFullyManagedCount", (o,n) => { (o as DeviceOperatingSystemSummary).AndroidFullyManagedCount = n.GetIntValue(); } },
                {"androidWorkProfileCount", (o,n) => { (o as DeviceOperatingSystemSummary).AndroidWorkProfileCount = n.GetIntValue(); } },
                {"aospUserAssociatedCount", (o,n) => { (o as DeviceOperatingSystemSummary).AospUserAssociatedCount = n.GetIntValue(); } },
                {"aospUserlessCount", (o,n) => { (o as DeviceOperatingSystemSummary).AospUserlessCount = n.GetIntValue(); } },
                {"chromeOSCount", (o,n) => { (o as DeviceOperatingSystemSummary).ChromeOSCount = n.GetIntValue(); } },
                {"configMgrDeviceCount", (o,n) => { (o as DeviceOperatingSystemSummary).ConfigMgrDeviceCount = n.GetIntValue(); } },
                {"iosCount", (o,n) => { (o as DeviceOperatingSystemSummary).IosCount = n.GetIntValue(); } },
                {"linuxCount", (o,n) => { (o as DeviceOperatingSystemSummary).LinuxCount = n.GetIntValue(); } },
                {"macOSCount", (o,n) => { (o as DeviceOperatingSystemSummary).MacOSCount = n.GetIntValue(); } },
                {"unknownCount", (o,n) => { (o as DeviceOperatingSystemSummary).UnknownCount = n.GetIntValue(); } },
                {"windowsCount", (o,n) => { (o as DeviceOperatingSystemSummary).WindowsCount = n.GetIntValue(); } },
                {"windowsMobileCount", (o,n) => { (o as DeviceOperatingSystemSummary).WindowsMobileCount = n.GetIntValue(); } },
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
