using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class UserExperienceAnalyticsRemoteConnection : Entity, IParsable {
        /// <summary>The sign in failure percentage of Cloud PC Device. Valid values 0 to 100</summary>
        public double? CloudPcFailurePercentage { get; set; }
        /// <summary>The round tip time of Cloud PC Device. Valid values 0 to 1.79769313486232E+308</summary>
        public double? CloudPcRoundTripTime { get; set; }
        /// <summary>The sign in time of Cloud PC Device. Valid values 0 to 1.79769313486232E+308</summary>
        public double? CloudPcSignInTime { get; set; }
        /// <summary>The core boot time of Cloud PC Device. Valid values 0 to 1.79769313486232E+308</summary>
        public double? CoreBootTime { get; set; }
        /// <summary>The core sign in time of Cloud PC Device. Valid values 0 to 1.79769313486232E+308</summary>
        public double? CoreSignInTime { get; set; }
        /// <summary>The count of remote connection. Valid values 0 to 2147483647</summary>
        public int? DeviceCount { get; set; }
        /// <summary>The id of the device.</summary>
        public string DeviceId { get; set; }
        /// <summary>The name of the device.</summary>
        public string DeviceName { get; set; }
        /// <summary>The user experience analytics manufacturer.</summary>
        public string Manufacturer { get; set; }
        /// <summary>The user experience analytics device model.</summary>
        public string Model { get; set; }
        /// <summary>The remote sign in time of Cloud PC Device. Valid values 0 to 1.79769313486232E+308</summary>
        public double? RemoteSignInTime { get; set; }
        /// <summary>The user experience analytics userPrincipalName.</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>The user experience analytics virtual network.</summary>
        public string VirtualNetwork { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"cloudPcFailurePercentage", (o,n) => { (o as UserExperienceAnalyticsRemoteConnection).CloudPcFailurePercentage = n.GetDoubleValue(); } },
                {"cloudPcRoundTripTime", (o,n) => { (o as UserExperienceAnalyticsRemoteConnection).CloudPcRoundTripTime = n.GetDoubleValue(); } },
                {"cloudPcSignInTime", (o,n) => { (o as UserExperienceAnalyticsRemoteConnection).CloudPcSignInTime = n.GetDoubleValue(); } },
                {"coreBootTime", (o,n) => { (o as UserExperienceAnalyticsRemoteConnection).CoreBootTime = n.GetDoubleValue(); } },
                {"coreSignInTime", (o,n) => { (o as UserExperienceAnalyticsRemoteConnection).CoreSignInTime = n.GetDoubleValue(); } },
                {"deviceCount", (o,n) => { (o as UserExperienceAnalyticsRemoteConnection).DeviceCount = n.GetIntValue(); } },
                {"deviceId", (o,n) => { (o as UserExperienceAnalyticsRemoteConnection).DeviceId = n.GetStringValue(); } },
                {"deviceName", (o,n) => { (o as UserExperienceAnalyticsRemoteConnection).DeviceName = n.GetStringValue(); } },
                {"manufacturer", (o,n) => { (o as UserExperienceAnalyticsRemoteConnection).Manufacturer = n.GetStringValue(); } },
                {"model", (o,n) => { (o as UserExperienceAnalyticsRemoteConnection).Model = n.GetStringValue(); } },
                {"remoteSignInTime", (o,n) => { (o as UserExperienceAnalyticsRemoteConnection).RemoteSignInTime = n.GetDoubleValue(); } },
                {"userPrincipalName", (o,n) => { (o as UserExperienceAnalyticsRemoteConnection).UserPrincipalName = n.GetStringValue(); } },
                {"virtualNetwork", (o,n) => { (o as UserExperienceAnalyticsRemoteConnection).VirtualNetwork = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDoubleValue("cloudPcFailurePercentage", CloudPcFailurePercentage);
            writer.WriteDoubleValue("cloudPcRoundTripTime", CloudPcRoundTripTime);
            writer.WriteDoubleValue("cloudPcSignInTime", CloudPcSignInTime);
            writer.WriteDoubleValue("coreBootTime", CoreBootTime);
            writer.WriteDoubleValue("coreSignInTime", CoreSignInTime);
            writer.WriteIntValue("deviceCount", DeviceCount);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("model", Model);
            writer.WriteDoubleValue("remoteSignInTime", RemoteSignInTime);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteStringValue("virtualNetwork", VirtualNetwork);
        }
    }
}
