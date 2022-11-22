using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Contains properties for the installation state of a mobile app for a device.</summary>
    public class MobileAppInstallStatus : Entity, IParsable {
        /// <summary>The navigation link to the mobile app.</summary>
        public MobileApp App {
            get { return BackingStore?.Get<MobileApp>("app"); }
            set { BackingStore?.Set("app", value); }
        }
        /// <summary>Device ID</summary>
        public string DeviceId {
            get { return BackingStore?.Get<string>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
        /// <summary>Device name</summary>
        public string DeviceName {
            get { return BackingStore?.Get<string>("deviceName"); }
            set { BackingStore?.Set("deviceName", value); }
        }
        /// <summary>Human readable version of the application</summary>
        public string DisplayVersion {
            get { return BackingStore?.Get<string>("displayVersion"); }
            set { BackingStore?.Set("displayVersion", value); }
        }
        /// <summary>The error code for install or uninstall failures.</summary>
        public int? ErrorCode {
            get { return BackingStore?.Get<int?>("errorCode"); }
            set { BackingStore?.Set("errorCode", value); }
        }
        /// <summary>A list of possible states for application status on an individual device. When devices contact the Intune service and find targeted application enforcement intent, the status of the enforcement is recorded and becomes accessible in the Graph API. Since the application status is identified during device interaction with the Intune service, status records do not immediately appear upon application group assignment; it is created only after the assignment is evaluated in the service and devices start receiving the policy during check-ins.</summary>
        public ResultantAppState? InstallState {
            get { return BackingStore?.Get<ResultantAppState?>("installState"); }
            set { BackingStore?.Set("installState", value); }
        }
        /// <summary>Enum indicating additional details regarding why an application has a particular install state.</summary>
        public ResultantAppStateDetail? InstallStateDetail {
            get { return BackingStore?.Get<ResultantAppStateDetail?>("installStateDetail"); }
            set { BackingStore?.Set("installStateDetail", value); }
        }
        /// <summary>Last sync date time</summary>
        public DateTimeOffset? LastSyncDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastSyncDateTime"); }
            set { BackingStore?.Set("lastSyncDateTime", value); }
        }
        /// <summary>A list of possible states for application status on an individual device. When devices contact the Intune service and find targeted application enforcement intent, the status of the enforcement is recorded and becomes accessible in the Graph API. Since the application status is identified during device interaction with the Intune service, status records do not immediately appear upon application group assignment; it is created only after the assignment is evaluated in the service and devices start receiving the policy during check-ins.</summary>
        public ResultantAppState? MobileAppInstallStatusValue {
            get { return BackingStore?.Get<ResultantAppState?>("mobileAppInstallStatusValue"); }
            set { BackingStore?.Set("mobileAppInstallStatusValue", value); }
        }
        /// <summary>OS Description</summary>
        public string OsDescription {
            get { return BackingStore?.Get<string>("osDescription"); }
            set { BackingStore?.Set("osDescription", value); }
        }
        /// <summary>OS Version</summary>
        public string OsVersion {
            get { return BackingStore?.Get<string>("osVersion"); }
            set { BackingStore?.Set("osVersion", value); }
        }
        /// <summary>Device User Name</summary>
        public string UserName {
            get { return BackingStore?.Get<string>("userName"); }
            set { BackingStore?.Set("userName", value); }
        }
        /// <summary>User Principal Name</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MobileAppInstallStatus CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MobileAppInstallStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"app", n => { App = n.GetObjectValue<MobileApp>(MobileApp.CreateFromDiscriminatorValue); } },
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"displayVersion", n => { DisplayVersion = n.GetStringValue(); } },
                {"errorCode", n => { ErrorCode = n.GetIntValue(); } },
                {"installState", n => { InstallState = n.GetEnumValue<ResultantAppState>(); } },
                {"installStateDetail", n => { InstallStateDetail = n.GetEnumValue<ResultantAppStateDetail>(); } },
                {"lastSyncDateTime", n => { LastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"mobileAppInstallStatusValue", n => { MobileAppInstallStatusValue = n.GetEnumValue<ResultantAppState>(); } },
                {"osDescription", n => { OsDescription = n.GetStringValue(); } },
                {"osVersion", n => { OsVersion = n.GetStringValue(); } },
                {"userName", n => { UserName = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<MobileApp>("app", App);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteStringValue("displayVersion", DisplayVersion);
            writer.WriteIntValue("errorCode", ErrorCode);
            writer.WriteEnumValue<ResultantAppState>("installState", InstallState);
            writer.WriteEnumValue<ResultantAppStateDetail>("installStateDetail", InstallStateDetail);
            writer.WriteDateTimeOffsetValue("lastSyncDateTime", LastSyncDateTime);
            writer.WriteEnumValue<ResultantAppState>("mobileAppInstallStatusValue", MobileAppInstallStatusValue);
            writer.WriteStringValue("osDescription", OsDescription);
            writer.WriteStringValue("osVersion", OsVersion);
            writer.WriteStringValue("userName", UserName);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
