using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.ActivateDeviceEsim;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.AssignmentFilterEvaluationStatusDetails;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.BypassActivationLock;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.CleanWindowsDevice;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.CreateDeviceLogCollectionRequest;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.CreateRemoteHelpSession;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.DeleteUserFromSharedAppleDevice;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.Deprovision;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.DetectedApps;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.DeviceCategory;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.DeviceCompliancePolicyStates;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.DeviceConfigurationStates;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.DeviceHealthScriptStates;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.Disable;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.DisableLostMode;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.EnableLostMode;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.EndRemoteHelpSession;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.EnrollNowAction;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.GetCloudPcRemoteActionResults;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.GetCloudPcReviewStatus;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.GetFileVaultKey;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.GetNonCompliantSettings;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.GetOemWarranty;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.InitiateMobileDeviceManagementKeyRecovery;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.InitiateOnDemandProactiveRemediation;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.LocateDevice;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.LogCollectionRequests;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.LogoutSharedAppleDeviceActiveUser;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.ManagedDeviceMobileAppConfigurationStates;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.OverrideComplianceState;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.PlayLostModeSound;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.RebootNow;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.RecoverPasscode;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.Reenable;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.RemoteLock;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.RemoveDeviceFirmwareConfigurationInterfaceManagement;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.ReprovisionCloudPc;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.RequestRemoteAssistance;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.RequestRemoteHelpSessionAccess;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.ResetPasscode;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.ResizeCloudPc;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.RestoreCloudPc;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.Retire;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.RetrieveRemoteHelpSessionWithSessionKey;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.RevokeAppleVppLicenses;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.RotateBitLockerKeys;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.RotateFileVaultKey;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.RotateLocalAdminPassword;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.SecurityBaselineStates;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.SendCustomNotificationToCompanyPortal;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.SetCloudPcReviewStatus;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.SetDeviceName;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.ShutDown;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.SyncDevice;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.TriggerConfigurationManagerAction;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.UpdateWindowsDeviceAccount;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.Users;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.WindowsDefenderScan;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.WindowsDefenderUpdateSignatures;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.WindowsProtectionState;
using Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.Wipe;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item {
    /// <summary>
    /// Provides operations to manage the comanagedDevices property of the microsoft.graph.deviceManagement entity.
    /// </summary>
    public class ManagedDeviceItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to call the activateDeviceEsim method.</summary>
        public ActivateDeviceEsimRequestBuilder ActivateDeviceEsim { get =>
            new ActivateDeviceEsimRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the assignmentFilterEvaluationStatusDetails property of the microsoft.graph.managedDevice entity.</summary>
        public AssignmentFilterEvaluationStatusDetailsRequestBuilder AssignmentFilterEvaluationStatusDetails { get =>
            new AssignmentFilterEvaluationStatusDetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the bypassActivationLock method.</summary>
        public BypassActivationLockRequestBuilder BypassActivationLock { get =>
            new BypassActivationLockRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the cleanWindowsDevice method.</summary>
        public CleanWindowsDeviceRequestBuilder CleanWindowsDevice { get =>
            new CleanWindowsDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the createDeviceLogCollectionRequest method.</summary>
        public CreateDeviceLogCollectionRequestRequestBuilder CreateDeviceLogCollectionRequest { get =>
            new CreateDeviceLogCollectionRequestRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the createRemoteHelpSession method.</summary>
        public CreateRemoteHelpSessionRequestBuilder CreateRemoteHelpSession { get =>
            new CreateRemoteHelpSessionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the deleteUserFromSharedAppleDevice method.</summary>
        public DeleteUserFromSharedAppleDeviceRequestBuilder DeleteUserFromSharedAppleDevice { get =>
            new DeleteUserFromSharedAppleDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the deprovision method.</summary>
        public DeprovisionRequestBuilder Deprovision { get =>
            new DeprovisionRequestBuilder(PathParameters, RequestAdapter);
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
        /// <summary>Provides operations to call the disable method.</summary>
        public DisableRequestBuilder Disable { get =>
            new DisableRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the disableLostMode method.</summary>
        public DisableLostModeRequestBuilder DisableLostMode { get =>
            new DisableLostModeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the enableLostMode method.</summary>
        public EnableLostModeRequestBuilder EnableLostMode { get =>
            new EnableLostModeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the endRemoteHelpSession method.</summary>
        public EndRemoteHelpSessionRequestBuilder EndRemoteHelpSession { get =>
            new EndRemoteHelpSessionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the enrollNowAction method.</summary>
        public EnrollNowActionRequestBuilder EnrollNowAction { get =>
            new EnrollNowActionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getCloudPcRemoteActionResults method.</summary>
        public GetCloudPcRemoteActionResultsRequestBuilder GetCloudPcRemoteActionResults { get =>
            new GetCloudPcRemoteActionResultsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getCloudPcReviewStatus method.</summary>
        public GetCloudPcReviewStatusRequestBuilder GetCloudPcReviewStatus { get =>
            new GetCloudPcReviewStatusRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getFileVaultKey method.</summary>
        public GetFileVaultKeyRequestBuilder GetFileVaultKey { get =>
            new GetFileVaultKeyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getNonCompliantSettings method.</summary>
        public GetNonCompliantSettingsRequestBuilder GetNonCompliantSettings { get =>
            new GetNonCompliantSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getOemWarranty method.</summary>
        public GetOemWarrantyRequestBuilder GetOemWarranty { get =>
            new GetOemWarrantyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the initiateMobileDeviceManagementKeyRecovery method.</summary>
        public InitiateMobileDeviceManagementKeyRecoveryRequestBuilder InitiateMobileDeviceManagementKeyRecovery { get =>
            new InitiateMobileDeviceManagementKeyRecoveryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the initiateOnDemandProactiveRemediation method.</summary>
        public InitiateOnDemandProactiveRemediationRequestBuilder InitiateOnDemandProactiveRemediation { get =>
            new InitiateOnDemandProactiveRemediationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the locateDevice method.</summary>
        public LocateDeviceRequestBuilder LocateDevice { get =>
            new LocateDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the logCollectionRequests property of the microsoft.graph.managedDevice entity.</summary>
        public LogCollectionRequestsRequestBuilder LogCollectionRequests { get =>
            new LogCollectionRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the logoutSharedAppleDeviceActiveUser method.</summary>
        public LogoutSharedAppleDeviceActiveUserRequestBuilder LogoutSharedAppleDeviceActiveUser { get =>
            new LogoutSharedAppleDeviceActiveUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the managedDeviceMobileAppConfigurationStates property of the microsoft.graph.managedDevice entity.</summary>
        public ManagedDeviceMobileAppConfigurationStatesRequestBuilder ManagedDeviceMobileAppConfigurationStates { get =>
            new ManagedDeviceMobileAppConfigurationStatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the overrideComplianceState method.</summary>
        public OverrideComplianceStateRequestBuilder OverrideComplianceState { get =>
            new OverrideComplianceStateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the playLostModeSound method.</summary>
        public PlayLostModeSoundRequestBuilder PlayLostModeSound { get =>
            new PlayLostModeSoundRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the rebootNow method.</summary>
        public RebootNowRequestBuilder RebootNow { get =>
            new RebootNowRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the recoverPasscode method.</summary>
        public RecoverPasscodeRequestBuilder RecoverPasscode { get =>
            new RecoverPasscodeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the reenable method.</summary>
        public ReenableRequestBuilder Reenable { get =>
            new ReenableRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the remoteLock method.</summary>
        public RemoteLockRequestBuilder RemoteLock { get =>
            new RemoteLockRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the removeDeviceFirmwareConfigurationInterfaceManagement method.</summary>
        public RemoveDeviceFirmwareConfigurationInterfaceManagementRequestBuilder RemoveDeviceFirmwareConfigurationInterfaceManagement { get =>
            new RemoveDeviceFirmwareConfigurationInterfaceManagementRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the reprovisionCloudPc method.</summary>
        public ReprovisionCloudPcRequestBuilder ReprovisionCloudPc { get =>
            new ReprovisionCloudPcRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the requestRemoteAssistance method.</summary>
        public RequestRemoteAssistanceRequestBuilder RequestRemoteAssistance { get =>
            new RequestRemoteAssistanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the requestRemoteHelpSessionAccess method.</summary>
        public RequestRemoteHelpSessionAccessRequestBuilder RequestRemoteHelpSessionAccess { get =>
            new RequestRemoteHelpSessionAccessRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the resetPasscode method.</summary>
        public ResetPasscodeRequestBuilder ResetPasscode { get =>
            new ResetPasscodeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the resizeCloudPc method.</summary>
        public ResizeCloudPcRequestBuilder ResizeCloudPc { get =>
            new ResizeCloudPcRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the restoreCloudPc method.</summary>
        public RestoreCloudPcRequestBuilder RestoreCloudPc { get =>
            new RestoreCloudPcRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the retire method.</summary>
        public RetireRequestBuilder Retire { get =>
            new RetireRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the revokeAppleVppLicenses method.</summary>
        public RevokeAppleVppLicensesRequestBuilder RevokeAppleVppLicenses { get =>
            new RevokeAppleVppLicensesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the rotateBitLockerKeys method.</summary>
        public RotateBitLockerKeysRequestBuilder RotateBitLockerKeys { get =>
            new RotateBitLockerKeysRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the rotateFileVaultKey method.</summary>
        public RotateFileVaultKeyRequestBuilder RotateFileVaultKey { get =>
            new RotateFileVaultKeyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the rotateLocalAdminPassword method.</summary>
        public RotateLocalAdminPasswordRequestBuilder RotateLocalAdminPassword { get =>
            new RotateLocalAdminPasswordRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the securityBaselineStates property of the microsoft.graph.managedDevice entity.</summary>
        public SecurityBaselineStatesRequestBuilder SecurityBaselineStates { get =>
            new SecurityBaselineStatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the sendCustomNotificationToCompanyPortal method.</summary>
        public SendCustomNotificationToCompanyPortalRequestBuilder SendCustomNotificationToCompanyPortal { get =>
            new SendCustomNotificationToCompanyPortalRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the setCloudPcReviewStatus method.</summary>
        public SetCloudPcReviewStatusRequestBuilder SetCloudPcReviewStatus { get =>
            new SetCloudPcReviewStatusRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the setDeviceName method.</summary>
        public SetDeviceNameRequestBuilder SetDeviceName { get =>
            new SetDeviceNameRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the shutDown method.</summary>
        public ShutDownRequestBuilder ShutDown { get =>
            new ShutDownRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the syncDevice method.</summary>
        public SyncDeviceRequestBuilder SyncDevice { get =>
            new SyncDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the triggerConfigurationManagerAction method.</summary>
        public TriggerConfigurationManagerActionRequestBuilder TriggerConfigurationManagerAction { get =>
            new TriggerConfigurationManagerActionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the updateWindowsDeviceAccount method.</summary>
        public UpdateWindowsDeviceAccountRequestBuilder UpdateWindowsDeviceAccount { get =>
            new UpdateWindowsDeviceAccountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the users property of the microsoft.graph.managedDevice entity.</summary>
        public UsersRequestBuilder Users { get =>
            new UsersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the windowsDefenderScan method.</summary>
        public WindowsDefenderScanRequestBuilder WindowsDefenderScan { get =>
            new WindowsDefenderScanRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the windowsDefenderUpdateSignatures method.</summary>
        public WindowsDefenderUpdateSignaturesRequestBuilder WindowsDefenderUpdateSignatures { get =>
            new WindowsDefenderUpdateSignaturesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the windowsProtectionState property of the microsoft.graph.managedDevice entity.</summary>
        public WindowsProtectionStateRequestBuilder WindowsProtectionState { get =>
            new WindowsProtectionStateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the wipe method.</summary>
        public WipeRequestBuilder Wipe { get =>
            new WipeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new ManagedDeviceItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ManagedDeviceItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/comanagedDevices/{managedDevice%2Did}{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ManagedDeviceItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ManagedDeviceItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/comanagedDevices/{managedDevice%2Did}{?%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// Delete navigation property comanagedDevices for deviceManagement
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
        /// The list of co-managed devices report
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
        /// Update the navigation property comanagedDevices in deviceManagement
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
        /// Provides operations to call the retrieveRemoteHelpSession method.
        /// </summary>
        /// <param name="sessionKey">Usage: sessionKey=&apos;{sessionKey}&apos;</param>
        public RetrieveRemoteHelpSessionWithSessionKeyRequestBuilder RetrieveRemoteHelpSessionWithSessionKey(string sessionKey) {
            if(string.IsNullOrEmpty(sessionKey)) throw new ArgumentNullException(nameof(sessionKey));
            return new RetrieveRemoteHelpSessionWithSessionKeyRequestBuilder(PathParameters, RequestAdapter, sessionKey);
        }
        /// <summary>
        /// Delete navigation property comanagedDevices for deviceManagement
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
        /// The list of co-managed devices report
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
        /// Update the navigation property comanagedDevices in deviceManagement
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
        /// The list of co-managed devices report
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
