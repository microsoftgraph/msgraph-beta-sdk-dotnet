using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class MobileAppInstallStatus : Entity, IParsable {
        /// <summary>The navigation link to the mobile app.</summary>
        public MobileApp App { get; set; }
        /// <summary>Device ID</summary>
        public string DeviceId { get; set; }
        /// <summary>Device name</summary>
        public string DeviceName { get; set; }
        /// <summary>Human readable version of the application</summary>
        public string DisplayVersion { get; set; }
        /// <summary>The error code for install or uninstall failures.</summary>
        public int? ErrorCode { get; set; }
        /// <summary>The install state of the app. Possible values are: installed, failed, notInstalled, uninstallFailed, pendingInstall, unknown, notApplicable.</summary>
        public ResultantAppState? InstallState { get; set; }
        /// <summary>The install state detail of the app. Possible values are: noAdditionalDetails, dependencyFailedToInstall, dependencyWithRequirementsNotMet, dependencyPendingReboot, dependencyWithAutoInstallDisabled, supersededAppUninstallFailed, supersededAppUninstallPendingReboot, removingSupersededApps, iosAppStoreUpdateFailedToInstall, vppAppHasUpdateAvailable, userRejectedUpdate, uninstallPendingReboot, supersedingAppsDetected, supersededAppsDetected, seeInstallErrorCode, autoInstallDisabled, managedAppNoLongerPresent, userRejectedInstall, userIsNotLoggedIntoAppStore, untargetedSupersedingAppsDetected, appRemovedBySupersedence, seeUninstallErrorCode, pendingReboot, installingDependencies, contentDownloaded, supersedingAppsNotApplicable, powerShellScriptRequirementNotMet, registryRequirementNotMet, fileSystemRequirementNotMet, platformNotApplicable, minimumCpuSpeedNotMet, minimumLogicalProcessorCountNotMet, minimumPhysicalMemoryNotMet, minimumOsVersionNotMet, minimumDiskSpaceNotMet, processorArchitectureNotApplicable.</summary>
        public ResultantAppStateDetail? InstallStateDetail { get; set; }
        /// <summary>Last sync date time</summary>
        public DateTimeOffset? LastSyncDateTime { get; set; }
        /// <summary>The install state of the app. Possible values are: installed, failed, notInstalled, uninstallFailed, pendingInstall, unknown, notApplicable.</summary>
        public ResultantAppState? MobileAppInstallStatusValue { get; set; }
        /// <summary>OS Description</summary>
        public string OsDescription { get; set; }
        /// <summary>OS Version</summary>
        public string OsVersion { get; set; }
        /// <summary>Device User Name</summary>
        public string UserName { get; set; }
        /// <summary>User Principal Name</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"app", (o,n) => { (o as MobileAppInstallStatus).App = n.GetObjectValue<MobileApp>(); } },
                {"deviceId", (o,n) => { (o as MobileAppInstallStatus).DeviceId = n.GetStringValue(); } },
                {"deviceName", (o,n) => { (o as MobileAppInstallStatus).DeviceName = n.GetStringValue(); } },
                {"displayVersion", (o,n) => { (o as MobileAppInstallStatus).DisplayVersion = n.GetStringValue(); } },
                {"errorCode", (o,n) => { (o as MobileAppInstallStatus).ErrorCode = n.GetIntValue(); } },
                {"installState", (o,n) => { (o as MobileAppInstallStatus).InstallState = n.GetEnumValue<ResultantAppState>(); } },
                {"installStateDetail", (o,n) => { (o as MobileAppInstallStatus).InstallStateDetail = n.GetEnumValue<ResultantAppStateDetail>(); } },
                {"lastSyncDateTime", (o,n) => { (o as MobileAppInstallStatus).LastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"mobileAppInstallStatusValue", (o,n) => { (o as MobileAppInstallStatus).MobileAppInstallStatusValue = n.GetEnumValue<ResultantAppState>(); } },
                {"osDescription", (o,n) => { (o as MobileAppInstallStatus).OsDescription = n.GetStringValue(); } },
                {"osVersion", (o,n) => { (o as MobileAppInstallStatus).OsVersion = n.GetStringValue(); } },
                {"userName", (o,n) => { (o as MobileAppInstallStatus).UserName = n.GetStringValue(); } },
                {"userPrincipalName", (o,n) => { (o as MobileAppInstallStatus).UserPrincipalName = n.GetStringValue(); } },
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
