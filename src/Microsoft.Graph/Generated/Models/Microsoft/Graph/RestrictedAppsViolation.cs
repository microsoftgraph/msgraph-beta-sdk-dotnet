using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class RestrictedAppsViolation : Entity, IParsable {
        /// <summary>Device configuration profile unique identifier, must be Guid</summary>
        public string DeviceConfigurationId { get; set; }
        /// <summary>Device configuration profile name</summary>
        public string DeviceConfigurationName { get; set; }
        /// <summary>Device name</summary>
        public string DeviceName { get; set; }
        /// <summary>Managed device unique identifier, must be Guid</summary>
        public string ManagedDeviceId { get; set; }
        /// <summary>Platform type. Possible values are: android, androidForWork, iOS, macOS, windowsPhone81, windows81AndLater, windows10AndLater, androidWorkProfile, windows10XProfile, androidAOSP, all.</summary>
        public PolicyPlatformType? PlatformType { get; set; }
        /// <summary>List of violated restricted apps</summary>
        public List<ManagedDeviceReportedApp> RestrictedApps { get; set; }
        /// <summary>Restricted apps state. Possible values are: prohibitedApps, notApprovedApps.</summary>
        public RestrictedAppsState? RestrictedAppsState { get; set; }
        /// <summary>User unique identifier, must be Guid</summary>
        public string UserId { get; set; }
        /// <summary>User name</summary>
        public string UserName { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"deviceConfigurationId", (o,n) => { (o as RestrictedAppsViolation).DeviceConfigurationId = n.GetStringValue(); } },
                {"deviceConfigurationName", (o,n) => { (o as RestrictedAppsViolation).DeviceConfigurationName = n.GetStringValue(); } },
                {"deviceName", (o,n) => { (o as RestrictedAppsViolation).DeviceName = n.GetStringValue(); } },
                {"managedDeviceId", (o,n) => { (o as RestrictedAppsViolation).ManagedDeviceId = n.GetStringValue(); } },
                {"platformType", (o,n) => { (o as RestrictedAppsViolation).PlatformType = n.GetEnumValue<PolicyPlatformType>(); } },
                {"restrictedApps", (o,n) => { (o as RestrictedAppsViolation).RestrictedApps = n.GetCollectionOfObjectValues<ManagedDeviceReportedApp>().ToList(); } },
                {"restrictedAppsState", (o,n) => { (o as RestrictedAppsViolation).RestrictedAppsState = n.GetEnumValue<RestrictedAppsState>(); } },
                {"userId", (o,n) => { (o as RestrictedAppsViolation).UserId = n.GetStringValue(); } },
                {"userName", (o,n) => { (o as RestrictedAppsViolation).UserName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("deviceConfigurationId", DeviceConfigurationId);
            writer.WriteStringValue("deviceConfigurationName", DeviceConfigurationName);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteStringValue("managedDeviceId", ManagedDeviceId);
            writer.WriteEnumValue<PolicyPlatformType>("platformType", PlatformType);
            writer.WriteCollectionOfObjectValues<ManagedDeviceReportedApp>("restrictedApps", RestrictedApps);
            writer.WriteEnumValue<RestrictedAppsState>("restrictedAppsState", RestrictedAppsState);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userName", UserName);
        }
    }
}
