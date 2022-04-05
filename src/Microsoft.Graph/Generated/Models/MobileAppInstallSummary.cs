using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MobileAppInstallSummary : Entity, IParsable {
        /// <summary>Number of Devices that have failed to install this app.</summary>
        public int? FailedDeviceCount { get; set; }
        /// <summary>Number of Users that have 1 or more device that failed to install this app.</summary>
        public int? FailedUserCount { get; set; }
        /// <summary>Number of Devices that have successfully installed this app.</summary>
        public int? InstalledDeviceCount { get; set; }
        /// <summary>Number of Users whose devices have all succeeded to install this app.</summary>
        public int? InstalledUserCount { get; set; }
        /// <summary>Number of Devices that are not applicable for this app.</summary>
        public int? NotApplicableDeviceCount { get; set; }
        /// <summary>Number of Users whose devices were all not applicable for this app.</summary>
        public int? NotApplicableUserCount { get; set; }
        /// <summary>Number of Devices that does not have this app installed.</summary>
        public int? NotInstalledDeviceCount { get; set; }
        /// <summary>Number of Users that have 1 or more devices that did not install this app.</summary>
        public int? NotInstalledUserCount { get; set; }
        /// <summary>Number of Devices that have been notified to install this app.</summary>
        public int? PendingInstallDeviceCount { get; set; }
        /// <summary>Number of Users that have 1 or more device that have been notified to install this app and have 0 devices with failures.</summary>
        public int? PendingInstallUserCount { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MobileAppInstallSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MobileAppInstallSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"failedDeviceCount", (o,n) => { (o as MobileAppInstallSummary).FailedDeviceCount = n.GetIntValue(); } },
                {"failedUserCount", (o,n) => { (o as MobileAppInstallSummary).FailedUserCount = n.GetIntValue(); } },
                {"installedDeviceCount", (o,n) => { (o as MobileAppInstallSummary).InstalledDeviceCount = n.GetIntValue(); } },
                {"installedUserCount", (o,n) => { (o as MobileAppInstallSummary).InstalledUserCount = n.GetIntValue(); } },
                {"notApplicableDeviceCount", (o,n) => { (o as MobileAppInstallSummary).NotApplicableDeviceCount = n.GetIntValue(); } },
                {"notApplicableUserCount", (o,n) => { (o as MobileAppInstallSummary).NotApplicableUserCount = n.GetIntValue(); } },
                {"notInstalledDeviceCount", (o,n) => { (o as MobileAppInstallSummary).NotInstalledDeviceCount = n.GetIntValue(); } },
                {"notInstalledUserCount", (o,n) => { (o as MobileAppInstallSummary).NotInstalledUserCount = n.GetIntValue(); } },
                {"pendingInstallDeviceCount", (o,n) => { (o as MobileAppInstallSummary).PendingInstallDeviceCount = n.GetIntValue(); } },
                {"pendingInstallUserCount", (o,n) => { (o as MobileAppInstallSummary).PendingInstallUserCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("failedDeviceCount", FailedDeviceCount);
            writer.WriteIntValue("failedUserCount", FailedUserCount);
            writer.WriteIntValue("installedDeviceCount", InstalledDeviceCount);
            writer.WriteIntValue("installedUserCount", InstalledUserCount);
            writer.WriteIntValue("notApplicableDeviceCount", NotApplicableDeviceCount);
            writer.WriteIntValue("notApplicableUserCount", NotApplicableUserCount);
            writer.WriteIntValue("notInstalledDeviceCount", NotInstalledDeviceCount);
            writer.WriteIntValue("notInstalledUserCount", NotInstalledUserCount);
            writer.WriteIntValue("pendingInstallDeviceCount", PendingInstallDeviceCount);
            writer.WriteIntValue("pendingInstallUserCount", PendingInstallUserCount);
        }
    }
}
