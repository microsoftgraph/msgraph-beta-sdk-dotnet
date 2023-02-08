using Microsoft.Graph.Beta.Me.ManagedDevices.Item.AssignmentFilterEvaluationStatusDetails;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.DetectedApps;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.DeviceCategory;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.DeviceCompliancePolicyStates;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.DeviceConfigurationStates;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.DeviceHealthScriptStates;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.LogCollectionRequests;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.ManagedDeviceMobileAppConfigurationStates;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphActivateDeviceEsim;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphBypassActivationLock;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphCleanWindowsDevice;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphCreateDeviceLogCollectionRequest;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphCreateRemoteHelpSession;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphDeleteUserFromSharedAppleDevice;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphDeprovision;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphDisable;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphDisableLostMode;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphEnableLostMode;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphEndRemoteHelpSession;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphEnrollNowAction;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphGetCloudPcRemoteActionResults;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphGetCloudPcReviewStatus;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphGetFileVaultKey;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphGetNonCompliantSettings;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphGetOemWarranty;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphInitiateMobileDeviceManagementKeyRecovery;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphInitiateOnDemandProactiveRemediation;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphLocateDevice;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphLogoutSharedAppleDeviceActiveUser;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphOverrideComplianceState;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphPlayLostModeSound;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphRebootNow;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphRecoverPasscode;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphReenable;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphRemoteLock;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphRemoveDeviceFirmwareConfigurationInterfaceManagement;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphReprovisionCloudPc;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphRequestRemoteAssistance;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphRequestRemoteHelpSessionAccess;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphResetPasscode;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphResizeCloudPc;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphRestoreCloudPc;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphRetire;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphRetrieveRemoteHelpSessionWithSessionKey;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphRevokeAppleVppLicenses;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphRotateBitLockerKeys;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphRotateFileVaultKey;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphSendCustomNotificationToCompanyPortal;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphSetCloudPcReviewStatus;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphSetDeviceName;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphShutDown;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphSyncDevice;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphTriggerConfigurationManagerAction;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphUpdateWindowsDeviceAccount;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphWindowsDefenderScan;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphWindowsDefenderUpdateSignatures;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.MicrosoftGraphWipe;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.SecurityBaselineStates;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.Users;
using Microsoft.Graph.Beta.Me.ManagedDevices.Item.WindowsProtectionState;
using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Microsoft.Graph.Beta.Me.ManagedDevices.Item {
    /// <summary>
    /// Provides operations to manage the managedDevices property of the microsoft.graph.user entity.
    /// </summary>
    public class ManagedDeviceItemRequestBuilder {
        /// <summary>Provides operations to manage the assignmentFilterEvaluationStatusDetails property of the microsoft.graph.managedDevice entity.</summary>
        public AssignmentFilterEvaluationStatusDetailsRequestBuilder AssignmentFilterEvaluationStatusDetails { get =>
            new AssignmentFilterEvaluationStatusDetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the detectedApps property of the microsoft.graph.managedDevice entity.</summary>
        public DetectedAppsRequestBuilder DetectedApps { get =>
            new DetectedAppsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceCategory property of the microsoft.graph.managedDevice entity.</summary>
        public DeviceCategoryRequestBuilder DeviceCategory { get =>
            new DeviceCategoryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceCompliancePolicyStates property of the microsoft.graph.managedDevice entity.</summary>
        public DeviceCompliancePolicyStatesRequestBuilder DeviceCompliancePolicyStates { get =>
            new DeviceCompliancePolicyStatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceConfigurationStates property of the microsoft.graph.managedDevice entity.</summary>
        public DeviceConfigurationStatesRequestBuilder DeviceConfigurationStates { get =>
            new DeviceConfigurationStatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceHealthScriptStates property of the microsoft.graph.managedDevice entity.</summary>
        public DeviceHealthScriptStatesRequestBuilder DeviceHealthScriptStates { get =>
            new DeviceHealthScriptStatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the logCollectionRequests property of the microsoft.graph.managedDevice entity.</summary>
        public LogCollectionRequestsRequestBuilder LogCollectionRequests { get =>
            new LogCollectionRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the managedDeviceMobileAppConfigurationStates property of the microsoft.graph.managedDevice entity.</summary>
        public ManagedDeviceMobileAppConfigurationStatesRequestBuilder ManagedDeviceMobileAppConfigurationStates { get =>
            new ManagedDeviceMobileAppConfigurationStatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the activateDeviceEsim method.</summary>
        public MicrosoftGraphActivateDeviceEsimRequestBuilder MicrosoftGraphActivateDeviceEsim { get =>
            new MicrosoftGraphActivateDeviceEsimRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the bypassActivationLock method.</summary>
        public MicrosoftGraphBypassActivationLockRequestBuilder MicrosoftGraphBypassActivationLock { get =>
            new MicrosoftGraphBypassActivationLockRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the cleanWindowsDevice method.</summary>
        public MicrosoftGraphCleanWindowsDeviceRequestBuilder MicrosoftGraphCleanWindowsDevice { get =>
            new MicrosoftGraphCleanWindowsDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the createDeviceLogCollectionRequest method.</summary>
        public MicrosoftGraphCreateDeviceLogCollectionRequestRequestBuilder MicrosoftGraphCreateDeviceLogCollectionRequest { get =>
            new MicrosoftGraphCreateDeviceLogCollectionRequestRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the createRemoteHelpSession method.</summary>
        public MicrosoftGraphCreateRemoteHelpSessionRequestBuilder MicrosoftGraphCreateRemoteHelpSession { get =>
            new MicrosoftGraphCreateRemoteHelpSessionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the deleteUserFromSharedAppleDevice method.</summary>
        public MicrosoftGraphDeleteUserFromSharedAppleDeviceRequestBuilder MicrosoftGraphDeleteUserFromSharedAppleDevice { get =>
            new MicrosoftGraphDeleteUserFromSharedAppleDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the deprovision method.</summary>
        public MicrosoftGraphDeprovisionRequestBuilder MicrosoftGraphDeprovision { get =>
            new MicrosoftGraphDeprovisionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the disable method.</summary>
        public MicrosoftGraphDisableRequestBuilder MicrosoftGraphDisable { get =>
            new MicrosoftGraphDisableRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the disableLostMode method.</summary>
        public MicrosoftGraphDisableLostModeRequestBuilder MicrosoftGraphDisableLostMode { get =>
            new MicrosoftGraphDisableLostModeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the enableLostMode method.</summary>
        public MicrosoftGraphEnableLostModeRequestBuilder MicrosoftGraphEnableLostMode { get =>
            new MicrosoftGraphEnableLostModeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the endRemoteHelpSession method.</summary>
        public MicrosoftGraphEndRemoteHelpSessionRequestBuilder MicrosoftGraphEndRemoteHelpSession { get =>
            new MicrosoftGraphEndRemoteHelpSessionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the enrollNowAction method.</summary>
        public MicrosoftGraphEnrollNowActionRequestBuilder MicrosoftGraphEnrollNowAction { get =>
            new MicrosoftGraphEnrollNowActionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getCloudPcRemoteActionResults method.</summary>
        public MicrosoftGraphGetCloudPcRemoteActionResultsRequestBuilder MicrosoftGraphGetCloudPcRemoteActionResults { get =>
            new MicrosoftGraphGetCloudPcRemoteActionResultsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getCloudPcReviewStatus method.</summary>
        public MicrosoftGraphGetCloudPcReviewStatusRequestBuilder MicrosoftGraphGetCloudPcReviewStatus { get =>
            new MicrosoftGraphGetCloudPcReviewStatusRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getFileVaultKey method.</summary>
        public MicrosoftGraphGetFileVaultKeyRequestBuilder MicrosoftGraphGetFileVaultKey { get =>
            new MicrosoftGraphGetFileVaultKeyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getNonCompliantSettings method.</summary>
        public MicrosoftGraphGetNonCompliantSettingsRequestBuilder MicrosoftGraphGetNonCompliantSettings { get =>
            new MicrosoftGraphGetNonCompliantSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getOemWarranty method.</summary>
        public MicrosoftGraphGetOemWarrantyRequestBuilder MicrosoftGraphGetOemWarranty { get =>
            new MicrosoftGraphGetOemWarrantyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the initiateMobileDeviceManagementKeyRecovery method.</summary>
        public MicrosoftGraphInitiateMobileDeviceManagementKeyRecoveryRequestBuilder MicrosoftGraphInitiateMobileDeviceManagementKeyRecovery { get =>
            new MicrosoftGraphInitiateMobileDeviceManagementKeyRecoveryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the initiateOnDemandProactiveRemediation method.</summary>
        public MicrosoftGraphInitiateOnDemandProactiveRemediationRequestBuilder MicrosoftGraphInitiateOnDemandProactiveRemediation { get =>
            new MicrosoftGraphInitiateOnDemandProactiveRemediationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the locateDevice method.</summary>
        public MicrosoftGraphLocateDeviceRequestBuilder MicrosoftGraphLocateDevice { get =>
            new MicrosoftGraphLocateDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the logoutSharedAppleDeviceActiveUser method.</summary>
        public MicrosoftGraphLogoutSharedAppleDeviceActiveUserRequestBuilder MicrosoftGraphLogoutSharedAppleDeviceActiveUser { get =>
            new MicrosoftGraphLogoutSharedAppleDeviceActiveUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the overrideComplianceState method.</summary>
        public MicrosoftGraphOverrideComplianceStateRequestBuilder MicrosoftGraphOverrideComplianceState { get =>
            new MicrosoftGraphOverrideComplianceStateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the playLostModeSound method.</summary>
        public MicrosoftGraphPlayLostModeSoundRequestBuilder MicrosoftGraphPlayLostModeSound { get =>
            new MicrosoftGraphPlayLostModeSoundRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the rebootNow method.</summary>
        public MicrosoftGraphRebootNowRequestBuilder MicrosoftGraphRebootNow { get =>
            new MicrosoftGraphRebootNowRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the recoverPasscode method.</summary>
        public MicrosoftGraphRecoverPasscodeRequestBuilder MicrosoftGraphRecoverPasscode { get =>
            new MicrosoftGraphRecoverPasscodeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the reenable method.</summary>
        public MicrosoftGraphReenableRequestBuilder MicrosoftGraphReenable { get =>
            new MicrosoftGraphReenableRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the remoteLock method.</summary>
        public MicrosoftGraphRemoteLockRequestBuilder MicrosoftGraphRemoteLock { get =>
            new MicrosoftGraphRemoteLockRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the removeDeviceFirmwareConfigurationInterfaceManagement method.</summary>
        public MicrosoftGraphRemoveDeviceFirmwareConfigurationInterfaceManagementRequestBuilder MicrosoftGraphRemoveDeviceFirmwareConfigurationInterfaceManagement { get =>
            new MicrosoftGraphRemoveDeviceFirmwareConfigurationInterfaceManagementRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the reprovisionCloudPc method.</summary>
        public MicrosoftGraphReprovisionCloudPcRequestBuilder MicrosoftGraphReprovisionCloudPc { get =>
            new MicrosoftGraphReprovisionCloudPcRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the requestRemoteAssistance method.</summary>
        public MicrosoftGraphRequestRemoteAssistanceRequestBuilder MicrosoftGraphRequestRemoteAssistance { get =>
            new MicrosoftGraphRequestRemoteAssistanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the requestRemoteHelpSessionAccess method.</summary>
        public MicrosoftGraphRequestRemoteHelpSessionAccessRequestBuilder MicrosoftGraphRequestRemoteHelpSessionAccess { get =>
            new MicrosoftGraphRequestRemoteHelpSessionAccessRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the resetPasscode method.</summary>
        public MicrosoftGraphResetPasscodeRequestBuilder MicrosoftGraphResetPasscode { get =>
            new MicrosoftGraphResetPasscodeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the resizeCloudPc method.</summary>
        public MicrosoftGraphResizeCloudPcRequestBuilder MicrosoftGraphResizeCloudPc { get =>
            new MicrosoftGraphResizeCloudPcRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the restoreCloudPc method.</summary>
        public MicrosoftGraphRestoreCloudPcRequestBuilder MicrosoftGraphRestoreCloudPc { get =>
            new MicrosoftGraphRestoreCloudPcRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the retire method.</summary>
        public MicrosoftGraphRetireRequestBuilder MicrosoftGraphRetire { get =>
            new MicrosoftGraphRetireRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the revokeAppleVppLicenses method.</summary>
        public MicrosoftGraphRevokeAppleVppLicensesRequestBuilder MicrosoftGraphRevokeAppleVppLicenses { get =>
            new MicrosoftGraphRevokeAppleVppLicensesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the rotateBitLockerKeys method.</summary>
        public MicrosoftGraphRotateBitLockerKeysRequestBuilder MicrosoftGraphRotateBitLockerKeys { get =>
            new MicrosoftGraphRotateBitLockerKeysRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the rotateFileVaultKey method.</summary>
        public MicrosoftGraphRotateFileVaultKeyRequestBuilder MicrosoftGraphRotateFileVaultKey { get =>
            new MicrosoftGraphRotateFileVaultKeyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the sendCustomNotificationToCompanyPortal method.</summary>
        public MicrosoftGraphSendCustomNotificationToCompanyPortalRequestBuilder MicrosoftGraphSendCustomNotificationToCompanyPortal { get =>
            new MicrosoftGraphSendCustomNotificationToCompanyPortalRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the setCloudPcReviewStatus method.</summary>
        public MicrosoftGraphSetCloudPcReviewStatusRequestBuilder MicrosoftGraphSetCloudPcReviewStatus { get =>
            new MicrosoftGraphSetCloudPcReviewStatusRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the setDeviceName method.</summary>
        public MicrosoftGraphSetDeviceNameRequestBuilder MicrosoftGraphSetDeviceName { get =>
            new MicrosoftGraphSetDeviceNameRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the shutDown method.</summary>
        public MicrosoftGraphShutDownRequestBuilder MicrosoftGraphShutDown { get =>
            new MicrosoftGraphShutDownRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the syncDevice method.</summary>
        public MicrosoftGraphSyncDeviceRequestBuilder MicrosoftGraphSyncDevice { get =>
            new MicrosoftGraphSyncDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the triggerConfigurationManagerAction method.</summary>
        public MicrosoftGraphTriggerConfigurationManagerActionRequestBuilder MicrosoftGraphTriggerConfigurationManagerAction { get =>
            new MicrosoftGraphTriggerConfigurationManagerActionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the updateWindowsDeviceAccount method.</summary>
        public MicrosoftGraphUpdateWindowsDeviceAccountRequestBuilder MicrosoftGraphUpdateWindowsDeviceAccount { get =>
            new MicrosoftGraphUpdateWindowsDeviceAccountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the windowsDefenderScan method.</summary>
        public MicrosoftGraphWindowsDefenderScanRequestBuilder MicrosoftGraphWindowsDefenderScan { get =>
            new MicrosoftGraphWindowsDefenderScanRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the windowsDefenderUpdateSignatures method.</summary>
        public MicrosoftGraphWindowsDefenderUpdateSignaturesRequestBuilder MicrosoftGraphWindowsDefenderUpdateSignatures { get =>
            new MicrosoftGraphWindowsDefenderUpdateSignaturesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the wipe method.</summary>
        public MicrosoftGraphWipeRequestBuilder MicrosoftGraphWipe { get =>
            new MicrosoftGraphWipeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Provides operations to manage the securityBaselineStates property of the microsoft.graph.managedDevice entity.</summary>
        public SecurityBaselineStatesRequestBuilder SecurityBaselineStates { get =>
            new SecurityBaselineStatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>Provides operations to manage the users property of the microsoft.graph.managedDevice entity.</summary>
        public UsersRequestBuilder Users { get =>
            new UsersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the windowsProtectionState property of the microsoft.graph.managedDevice entity.</summary>
        public WindowsProtectionStateRequestBuilder WindowsProtectionState { get =>
            new WindowsProtectionStateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new ManagedDeviceItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ManagedDeviceItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/me/managedDevices/{managedDevice%2Did}{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new ManagedDeviceItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ManagedDeviceItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/me/managedDevices/{managedDevice%2Did}{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>();
            if (!string.IsNullOrWhiteSpace(rawUrl)) urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property managedDevices for me
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<ManagedDeviceItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<ManagedDeviceItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// The managed devices associated with the user.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.ManagedDevice?> GetAsync(Action<ManagedDeviceItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.ManagedDevice> GetAsync(Action<ManagedDeviceItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.ManagedDevice>(requestInfo, Microsoft.Graph.Beta.Models.ManagedDevice.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Provides operations to call the retrieveRemoteHelpSession method.
        /// </summary>
        /// <param name="sessionKey">Usage: sessionKey=&apos;{sessionKey}&apos;</param>
        public MicrosoftGraphRetrieveRemoteHelpSessionWithSessionKeyRequestBuilder MicrosoftGraphRetrieveRemoteHelpSessionWithSessionKey(string sessionKey) {
            if(string.IsNullOrEmpty(sessionKey)) throw new ArgumentNullException(nameof(sessionKey));
            return new MicrosoftGraphRetrieveRemoteHelpSessionWithSessionKeyRequestBuilder(PathParameters, RequestAdapter, sessionKey);
        }
        /// <summary>
        /// Update the navigation property managedDevices in me
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.ManagedDevice?> PatchAsync(Microsoft.Graph.Beta.Models.ManagedDevice body, Action<ManagedDeviceItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.ManagedDevice> PatchAsync(Microsoft.Graph.Beta.Models.ManagedDevice body, Action<ManagedDeviceItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.ManagedDevice>(requestInfo, Microsoft.Graph.Beta.Models.ManagedDevice.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Delete navigation property managedDevices for me
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<ManagedDeviceItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<ManagedDeviceItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new ManagedDeviceItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// The managed devices associated with the user.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<ManagedDeviceItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<ManagedDeviceItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new ManagedDeviceItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property managedDevices in me
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.ManagedDevice body, Action<ManagedDeviceItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.ManagedDevice body, Action<ManagedDeviceItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new ManagedDeviceItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ManagedDeviceItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new ManagedDeviceItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public ManagedDeviceItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// The managed devices associated with the user.
        /// </summary>
        public class ManagedDeviceItemRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ManagedDeviceItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public ManagedDeviceItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new ManagedDeviceItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new ManagedDeviceItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public ManagedDeviceItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ManagedDeviceItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new ManagedDeviceItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public ManagedDeviceItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
