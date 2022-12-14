using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// The user experience analyte remote connection entity.
    /// </summary>
    public class UserExperienceAnalyticsRemoteConnection : Entity, IParsable {
        /// <summary>The sign in failure percentage of Cloud PC Device. Valid values 0 to 100</summary>
        public double? CloudPcFailurePercentage {
            get { return BackingStore?.Get<double?>("cloudPcFailurePercentage"); }
            set { BackingStore?.Set("cloudPcFailurePercentage", value); }
        }
        /// <summary>The round tip time of Cloud PC Device. Valid values 0 to 1.79769313486232E+308</summary>
        public double? CloudPcRoundTripTime {
            get { return BackingStore?.Get<double?>("cloudPcRoundTripTime"); }
            set { BackingStore?.Set("cloudPcRoundTripTime", value); }
        }
        /// <summary>The sign in time of Cloud PC Device. Valid values 0 to 1.79769313486232E+308</summary>
        public double? CloudPcSignInTime {
            get { return BackingStore?.Get<double?>("cloudPcSignInTime"); }
            set { BackingStore?.Set("cloudPcSignInTime", value); }
        }
        /// <summary>The core boot time of Cloud PC Device. Valid values 0 to 1.79769313486232E+308</summary>
        public double? CoreBootTime {
            get { return BackingStore?.Get<double?>("coreBootTime"); }
            set { BackingStore?.Set("coreBootTime", value); }
        }
        /// <summary>The core sign in time of Cloud PC Device. Valid values 0 to 1.79769313486232E+308</summary>
        public double? CoreSignInTime {
            get { return BackingStore?.Get<double?>("coreSignInTime"); }
            set { BackingStore?.Set("coreSignInTime", value); }
        }
        /// <summary>The count of remote connection. Valid values 0 to 2147483647</summary>
        public int? DeviceCount {
            get { return BackingStore?.Get<int?>("deviceCount"); }
            set { BackingStore?.Set("deviceCount", value); }
        }
        /// <summary>The id of the device.</summary>
        public string DeviceId {
            get { return BackingStore?.Get<string>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
        /// <summary>The name of the device.</summary>
        public string DeviceName {
            get { return BackingStore?.Get<string>("deviceName"); }
            set { BackingStore?.Set("deviceName", value); }
        }
        /// <summary>The user experience analytics manufacturer.</summary>
        public string Manufacturer {
            get { return BackingStore?.Get<string>("manufacturer"); }
            set { BackingStore?.Set("manufacturer", value); }
        }
        /// <summary>The user experience analytics device model.</summary>
        public string Model {
            get { return BackingStore?.Get<string>("model"); }
            set { BackingStore?.Set("model", value); }
        }
        /// <summary>The remote sign in time of Cloud PC Device. Valid values 0 to 1.79769313486232E+308</summary>
        public double? RemoteSignInTime {
            get { return BackingStore?.Get<double?>("remoteSignInTime"); }
            set { BackingStore?.Set("remoteSignInTime", value); }
        }
        /// <summary>The user experience analytics userPrincipalName.</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
        /// <summary>The user experience analytics virtual network.</summary>
        public string VirtualNetwork {
            get { return BackingStore?.Get<string>("virtualNetwork"); }
            set { BackingStore?.Set("virtualNetwork", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UserExperienceAnalyticsRemoteConnection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsRemoteConnection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"cloudPcFailurePercentage", n => { CloudPcFailurePercentage = n.GetDoubleValue(); } },
                {"cloudPcRoundTripTime", n => { CloudPcRoundTripTime = n.GetDoubleValue(); } },
                {"cloudPcSignInTime", n => { CloudPcSignInTime = n.GetDoubleValue(); } },
                {"coreBootTime", n => { CoreBootTime = n.GetDoubleValue(); } },
                {"coreSignInTime", n => { CoreSignInTime = n.GetDoubleValue(); } },
                {"deviceCount", n => { DeviceCount = n.GetIntValue(); } },
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                {"model", n => { Model = n.GetStringValue(); } },
                {"remoteSignInTime", n => { RemoteSignInTime = n.GetDoubleValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
                {"virtualNetwork", n => { VirtualNetwork = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
