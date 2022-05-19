using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Describes the installation status details of the child app in the context of UPN and device id.</summary>
    public class MobileAppRelationshipState : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The corresponding device id.</summary>
        public string DeviceId {
            get { return BackingStore?.Get<string>(nameof(DeviceId)); }
            set { BackingStore?.Set(nameof(DeviceId), value); }
        }
        /// <summary>The error code for install or uninstall failures of target app.</summary>
        public int? ErrorCode {
            get { return BackingStore?.Get<int?>(nameof(ErrorCode)); }
            set { BackingStore?.Set(nameof(ErrorCode), value); }
        }
        /// <summary>The install state of the app of target app. Possible values are: installed, failed, notInstalled, uninstallFailed, pendingInstall, unknown, notApplicable.</summary>
        public ResultantAppState? InstallState {
            get { return BackingStore?.Get<ResultantAppState?>(nameof(InstallState)); }
            set { BackingStore?.Set(nameof(InstallState), value); }
        }
        /// <summary>The install state detail of the app. Possible values are: noAdditionalDetails, dependencyFailedToInstall, dependencyWithRequirementsNotMet, dependencyPendingReboot, dependencyWithAutoInstallDisabled, supersededAppUninstallFailed, supersededAppUninstallPendingReboot, removingSupersededApps, iosAppStoreUpdateFailedToInstall, vppAppHasUpdateAvailable, userRejectedUpdate, uninstallPendingReboot, supersedingAppsDetected, supersededAppsDetected, seeInstallErrorCode, autoInstallDisabled, managedAppNoLongerPresent, userRejectedInstall, userIsNotLoggedIntoAppStore, untargetedSupersedingAppsDetected, appRemovedBySupersedence, seeUninstallErrorCode, pendingReboot, installingDependencies, contentDownloaded, supersedingAppsNotApplicable, powerShellScriptRequirementNotMet, registryRequirementNotMet, fileSystemRequirementNotMet, platformNotApplicable, minimumCpuSpeedNotMet, minimumLogicalProcessorCountNotMet, minimumPhysicalMemoryNotMet, minimumOsVersionNotMet, minimumDiskSpaceNotMet, processorArchitectureNotApplicable.</summary>
        public ResultantAppStateDetail? InstallStateDetail {
            get { return BackingStore?.Get<ResultantAppStateDetail?>(nameof(InstallStateDetail)); }
            set { BackingStore?.Set(nameof(InstallStateDetail), value); }
        }
        /// <summary>The collection of source mobile app&apos;s ids.</summary>
        public List<string> SourceIds {
            get { return BackingStore?.Get<List<string>>(nameof(SourceIds)); }
            set { BackingStore?.Set(nameof(SourceIds), value); }
        }
        /// <summary>The related target app&apos;s display name.</summary>
        public string TargetDisplayName {
            get { return BackingStore?.Get<string>(nameof(TargetDisplayName)); }
            set { BackingStore?.Set(nameof(TargetDisplayName), value); }
        }
        /// <summary>The related target app&apos;s id.</summary>
        public string TargetId {
            get { return BackingStore?.Get<string>(nameof(TargetId)); }
            set { BackingStore?.Set(nameof(TargetId), value); }
        }
        /// <summary>The last sync time of the target app.</summary>
        public DateTimeOffset? TargetLastSyncDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(TargetLastSyncDateTime)); }
            set { BackingStore?.Set(nameof(TargetLastSyncDateTime), value); }
        }
        /// <summary>
        /// Instantiates a new mobileAppRelationshipState and sets the default values.
        /// </summary>
        public MobileAppRelationshipState() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
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
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"errorCode", n => { ErrorCode = n.GetIntValue(); } },
                {"installState", n => { InstallState = n.GetEnumValue<ResultantAppState>(); } },
                {"installStateDetail", n => { InstallStateDetail = n.GetEnumValue<ResultantAppStateDetail>(); } },
                {"sourceIds", n => { SourceIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"targetDisplayName", n => { TargetDisplayName = n.GetStringValue(); } },
                {"targetId", n => { TargetId = n.GetStringValue(); } },
                {"targetLastSyncDateTime", n => { TargetLastSyncDateTime = n.GetDateTimeOffsetValue(); } },
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
