using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class UserAppInstallStatus : Entity, IParsable {
        /// <summary>The navigation link to the mobile app.</summary>
        public MobileApp App { get; set; }
        /// <summary>The install state of the app on devices.</summary>
        public List<MobileAppInstallStatus> DeviceStatuses { get; set; }
        /// <summary>Failed Device Count.</summary>
        public int? FailedDeviceCount { get; set; }
        /// <summary>Installed Device Count.</summary>
        public int? InstalledDeviceCount { get; set; }
        /// <summary>Not installed device count.</summary>
        public int? NotInstalledDeviceCount { get; set; }
        /// <summary>User name.</summary>
        public string UserName { get; set; }
        /// <summary>User Principal Name.</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserAppInstallStatus CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserAppInstallStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"app", (o,n) => { (o as UserAppInstallStatus).App = n.GetObjectValue<MobileApp>(MobileApp.CreateFromDiscriminatorValue); } },
                {"deviceStatuses", (o,n) => { (o as UserAppInstallStatus).DeviceStatuses = n.GetCollectionOfObjectValues<MobileAppInstallStatus>(MobileAppInstallStatus.CreateFromDiscriminatorValue).ToList(); } },
                {"failedDeviceCount", (o,n) => { (o as UserAppInstallStatus).FailedDeviceCount = n.GetIntValue(); } },
                {"installedDeviceCount", (o,n) => { (o as UserAppInstallStatus).InstalledDeviceCount = n.GetIntValue(); } },
                {"notInstalledDeviceCount", (o,n) => { (o as UserAppInstallStatus).NotInstalledDeviceCount = n.GetIntValue(); } },
                {"userName", (o,n) => { (o as UserAppInstallStatus).UserName = n.GetStringValue(); } },
                {"userPrincipalName", (o,n) => { (o as UserAppInstallStatus).UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<MobileApp>("app", App);
            writer.WriteCollectionOfObjectValues<MobileAppInstallStatus>("deviceStatuses", DeviceStatuses);
            writer.WriteIntValue("failedDeviceCount", FailedDeviceCount);
            writer.WriteIntValue("installedDeviceCount", InstalledDeviceCount);
            writer.WriteIntValue("notInstalledDeviceCount", NotInstalledDeviceCount);
            writer.WriteStringValue("userName", UserName);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
