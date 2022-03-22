using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Describes the installation status details of the child app in the context of UPN and device id.</summary>
    public class MobileAppRelationshipState : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The corresponding device id.</summary>
        public string DeviceId { get; set; }
        /// <summary>The error code for install or uninstall failures of target app.</summary>
        public int? ErrorCode { get; set; }
        /// <summary>The install state of the app of target app. Possible values are: installed, failed, notInstalled, uninstallFailed, pendingInstall, unknown, notApplicable.</summary>
        public ResultantAppState? InstallState { get; set; }
        /// <summary>The install state detail of the app. Possible values are: noAdditionalDetails, dependencyFailedToInstall, dependencyWithRequirementsNotMet, dependencyPendingReboot, dependencyWithAutoInstallDisabled, supersededAppUninstallFailed, supersededAppUninstallPendingReboot, removingSupersededApps, iosAppStoreUpdateFailedToInstall, vppAppHasUpdateAvailable, userRejectedUpdate, uninstallPendingReboot, supersedingAppsDetected, supersededAppsDetected, seeInstallErrorCode, autoInstallDisabled, managedAppNoLongerPresent, userRejectedInstall, userIsNotLoggedIntoAppStore, untargetedSupersedingAppsDetected, appRemovedBySupersedence, seeUninstallErrorCode, pendingReboot, installingDependencies, contentDownloaded, supersedingAppsNotApplicable, powerShellScriptRequirementNotMet, registryRequirementNotMet, fileSystemRequirementNotMet, platformNotApplicable, minimumCpuSpeedNotMet, minimumLogicalProcessorCountNotMet, minimumPhysicalMemoryNotMet, minimumOsVersionNotMet, minimumDiskSpaceNotMet, processorArchitectureNotApplicable.</summary>
        public ResultantAppStateDetail? InstallStateDetail { get; set; }
        /// <summary>The collection of source mobile app's ids.</summary>
        public List<string> SourceIds { get; set; }
        /// <summary>The related target app's display name.</summary>
        public string TargetDisplayName { get; set; }
        /// <summary>The related target app's id.</summary>
        public string TargetId { get; set; }
        /// <summary>The last sync time of the target app.</summary>
        public DateTimeOffset? TargetLastSyncDateTime { get; set; }
        /// <summary>
        /// Instantiates a new mobileAppRelationshipState and sets the default values.
        /// </summary>
        public MobileAppRelationshipState() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static MobileAppRelationshipState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MobileAppRelationshipState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"deviceId", (o,n) => { (o as MobileAppRelationshipState).DeviceId = n.GetStringValue(); } },
                {"errorCode", (o,n) => { (o as MobileAppRelationshipState).ErrorCode = n.GetIntValue(); } },
                {"installState", (o,n) => { (o as MobileAppRelationshipState).InstallState = n.GetEnumValue<ResultantAppState>(); } },
                {"installStateDetail", (o,n) => { (o as MobileAppRelationshipState).InstallStateDetail = n.GetEnumValue<ResultantAppStateDetail>(); } },
                {"sourceIds", (o,n) => { (o as MobileAppRelationshipState).SourceIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"targetDisplayName", (o,n) => { (o as MobileAppRelationshipState).TargetDisplayName = n.GetStringValue(); } },
                {"targetId", (o,n) => { (o as MobileAppRelationshipState).TargetId = n.GetStringValue(); } },
                {"targetLastSyncDateTime", (o,n) => { (o as MobileAppRelationshipState).TargetLastSyncDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteIntValue("errorCode", ErrorCode);
            writer.WriteEnumValue<ResultantAppState>("installState", InstallState);
            writer.WriteEnumValue<ResultantAppStateDetail>("installStateDetail", InstallStateDetail);
            writer.WriteCollectionOfPrimitiveValues<string>("sourceIds", SourceIds);
            writer.WriteStringValue("targetDisplayName", TargetDisplayName);
            writer.WriteStringValue("targetId", TargetId);
            writer.WriteDateTimeOffsetValue("targetLastSyncDateTime", TargetLastSyncDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
