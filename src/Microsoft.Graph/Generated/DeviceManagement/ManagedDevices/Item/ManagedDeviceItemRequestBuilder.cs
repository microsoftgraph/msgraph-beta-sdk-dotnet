using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.ActivateDeviceEsim;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.AssignmentFilterEvaluationStatusDetails;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.BypassActivationLock;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.CleanWindowsDevice;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.CreateDeviceLogCollectionRequest;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.CreateRemoteHelpSession;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.DeleteUserFromSharedAppleDevice;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.Deprovision;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.DetectedApps;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.DeviceCategory;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.DeviceCompliancePolicyStates;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.DeviceConfigurationStates;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.Disable;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.DisableLostMode;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.EnableLostMode;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.GetCloudPcRemoteActionResults;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.GetCloudPcReviewStatus;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.GetFileVaultKey;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.GetNonCompliantSettings;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.GetOemWarranty;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.LocateDevice;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.LogCollectionRequests;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.LogoutSharedAppleDeviceActiveUser;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.ManagedDeviceMobileAppConfigurationStates;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.OverrideComplianceState;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.PlayLostModeSound;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.RebootNow;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.RecoverPasscode;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.Reenable;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.RemoteLock;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.RemoveDeviceFirmwareConfigurationInterfaceManagement;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.ReprovisionCloudPc;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.RequestRemoteAssistance;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.RequestRemoteHelpSessionAccess;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.ResetPasscode;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.ResizeCloudPc;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.RestoreCloudPc;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.Retire;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.RetrieveRemoteHelpSessionWithSessionKey;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.RevokeAppleVppLicenses;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.RotateBitLockerKeys;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.RotateFileVaultKey;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.SecurityBaselineStates;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.SendCustomNotificationToCompanyPortal;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.SetCloudPcReviewStatus;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.SetDeviceName;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.ShutDown;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.SyncDevice;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.TriggerConfigurationManagerAction;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.UpdateWindowsDeviceAccount;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.Users;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.WindowsDefenderScan;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.WindowsDefenderUpdateSignatures;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.WindowsProtectionState;
using Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item.Wipe;
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
namespace Microsoft.Graph.Beta.DeviceManagement.ManagedDevices.Item {
    /// <summary>Provides operations to manage the managedDevices property of the microsoft.graph.deviceManagement entity.</summary>
    public class ManagedDeviceItemRequestBuilder {
        /// <summary>The activateDeviceEsim property</summary>
        public ActivateDeviceEsimRequestBuilder ActivateDeviceEsim { get =>
            new ActivateDeviceEsimRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The assignmentFilterEvaluationStatusDetails property</summary>
        public AssignmentFilterEvaluationStatusDetailsRequestBuilder AssignmentFilterEvaluationStatusDetails { get =>
            new AssignmentFilterEvaluationStatusDetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The bypassActivationLock property</summary>
        public BypassActivationLockRequestBuilder BypassActivationLock { get =>
            new BypassActivationLockRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The cleanWindowsDevice property</summary>
        public CleanWindowsDeviceRequestBuilder CleanWindowsDevice { get =>
            new CleanWindowsDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The createDeviceLogCollectionRequest property</summary>
        public CreateDeviceLogCollectionRequestRequestBuilder CreateDeviceLogCollectionRequest { get =>
            new CreateDeviceLogCollectionRequestRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The createRemoteHelpSession property</summary>
        public CreateRemoteHelpSessionRequestBuilder CreateRemoteHelpSession { get =>
            new CreateRemoteHelpSessionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deleteUserFromSharedAppleDevice property</summary>
        public DeleteUserFromSharedAppleDeviceRequestBuilder DeleteUserFromSharedAppleDevice { get =>
            new DeleteUserFromSharedAppleDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deprovision property</summary>
        public DeprovisionRequestBuilder Deprovision { get =>
            new DeprovisionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The detectedApps property</summary>
        public DetectedAppsRequestBuilder DetectedApps { get =>
            new DetectedAppsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deviceCategory property</summary>
        public DeviceCategoryRequestBuilder DeviceCategory { get =>
            new DeviceCategoryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deviceCompliancePolicyStates property</summary>
        public DeviceCompliancePolicyStatesRequestBuilder DeviceCompliancePolicyStates { get =>
            new DeviceCompliancePolicyStatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deviceConfigurationStates property</summary>
        public DeviceConfigurationStatesRequestBuilder DeviceConfigurationStates { get =>
            new DeviceConfigurationStatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The disable property</summary>
        public DisableRequestBuilder Disable { get =>
            new DisableRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The disableLostMode property</summary>
        public DisableLostModeRequestBuilder DisableLostMode { get =>
            new DisableLostModeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The enableLostMode property</summary>
        public EnableLostModeRequestBuilder EnableLostMode { get =>
            new EnableLostModeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The locateDevice property</summary>
        public LocateDeviceRequestBuilder LocateDevice { get =>
            new LocateDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The logCollectionRequests property</summary>
        public LogCollectionRequestsRequestBuilder LogCollectionRequests { get =>
            new LogCollectionRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The logoutSharedAppleDeviceActiveUser property</summary>
        public LogoutSharedAppleDeviceActiveUserRequestBuilder LogoutSharedAppleDeviceActiveUser { get =>
            new LogoutSharedAppleDeviceActiveUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The managedDeviceMobileAppConfigurationStates property</summary>
        public ManagedDeviceMobileAppConfigurationStatesRequestBuilder ManagedDeviceMobileAppConfigurationStates { get =>
            new ManagedDeviceMobileAppConfigurationStatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The overrideComplianceState property</summary>
        public OverrideComplianceStateRequestBuilder OverrideComplianceState { get =>
            new OverrideComplianceStateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The playLostModeSound property</summary>
        public PlayLostModeSoundRequestBuilder PlayLostModeSound { get =>
            new PlayLostModeSoundRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The rebootNow property</summary>
        public RebootNowRequestBuilder RebootNow { get =>
            new RebootNowRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The recoverPasscode property</summary>
        public RecoverPasscodeRequestBuilder RecoverPasscode { get =>
            new RecoverPasscodeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The reenable property</summary>
        public ReenableRequestBuilder Reenable { get =>
            new ReenableRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The remoteLock property</summary>
        public RemoteLockRequestBuilder RemoteLock { get =>
            new RemoteLockRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The removeDeviceFirmwareConfigurationInterfaceManagement property</summary>
        public RemoveDeviceFirmwareConfigurationInterfaceManagementRequestBuilder RemoveDeviceFirmwareConfigurationInterfaceManagement { get =>
            new RemoveDeviceFirmwareConfigurationInterfaceManagementRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The reprovisionCloudPc property</summary>
        public ReprovisionCloudPcRequestBuilder ReprovisionCloudPc { get =>
            new ReprovisionCloudPcRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>The requestRemoteAssistance property</summary>
        public RequestRemoteAssistanceRequestBuilder RequestRemoteAssistance { get =>
            new RequestRemoteAssistanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The requestRemoteHelpSessionAccess property</summary>
        public RequestRemoteHelpSessionAccessRequestBuilder RequestRemoteHelpSessionAccess { get =>
            new RequestRemoteHelpSessionAccessRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The resetPasscode property</summary>
        public ResetPasscodeRequestBuilder ResetPasscode { get =>
            new ResetPasscodeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The resizeCloudPc property</summary>
        public ResizeCloudPcRequestBuilder ResizeCloudPc { get =>
            new ResizeCloudPcRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The restoreCloudPc property</summary>
        public RestoreCloudPcRequestBuilder RestoreCloudPc { get =>
            new RestoreCloudPcRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The retire property</summary>
        public RetireRequestBuilder Retire { get =>
            new RetireRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The revokeAppleVppLicenses property</summary>
        public RevokeAppleVppLicensesRequestBuilder RevokeAppleVppLicenses { get =>
            new RevokeAppleVppLicensesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The rotateBitLockerKeys property</summary>
        public RotateBitLockerKeysRequestBuilder RotateBitLockerKeys { get =>
            new RotateBitLockerKeysRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The rotateFileVaultKey property</summary>
        public RotateFileVaultKeyRequestBuilder RotateFileVaultKey { get =>
            new RotateFileVaultKeyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The securityBaselineStates property</summary>
        public SecurityBaselineStatesRequestBuilder SecurityBaselineStates { get =>
            new SecurityBaselineStatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The sendCustomNotificationToCompanyPortal property</summary>
        public SendCustomNotificationToCompanyPortalRequestBuilder SendCustomNotificationToCompanyPortal { get =>
            new SendCustomNotificationToCompanyPortalRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The setCloudPcReviewStatus property</summary>
        public SetCloudPcReviewStatusRequestBuilder SetCloudPcReviewStatus { get =>
            new SetCloudPcReviewStatusRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The setDeviceName property</summary>
        public SetDeviceNameRequestBuilder SetDeviceName { get =>
            new SetDeviceNameRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The shutDown property</summary>
        public ShutDownRequestBuilder ShutDown { get =>
            new ShutDownRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The syncDevice property</summary>
        public SyncDeviceRequestBuilder SyncDevice { get =>
            new SyncDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The triggerConfigurationManagerAction property</summary>
        public TriggerConfigurationManagerActionRequestBuilder TriggerConfigurationManagerAction { get =>
            new TriggerConfigurationManagerActionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The updateWindowsDeviceAccount property</summary>
        public UpdateWindowsDeviceAccountRequestBuilder UpdateWindowsDeviceAccount { get =>
            new UpdateWindowsDeviceAccountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>The users property</summary>
        public UsersRequestBuilder Users { get =>
            new UsersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The windowsDefenderScan property</summary>
        public WindowsDefenderScanRequestBuilder WindowsDefenderScan { get =>
            new WindowsDefenderScanRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The windowsDefenderUpdateSignatures property</summary>
        public WindowsDefenderUpdateSignaturesRequestBuilder WindowsDefenderUpdateSignatures { get =>
            new WindowsDefenderUpdateSignaturesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The windowsProtectionState property</summary>
        public WindowsProtectionStateRequestBuilder WindowsProtectionState { get =>
            new WindowsProtectionStateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The wipe property</summary>
        public WipeRequestBuilder Wipe { get =>
            new WipeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new ManagedDeviceItemRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public ManagedDeviceItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/managedDevices/{managedDevice%2Did}{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new ManagedDeviceItemRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public ManagedDeviceItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/managedDevices/{managedDevice%2Did}{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property managedDevices for deviceManagement
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<ManagedDeviceItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
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
        /// The list of managed devices.
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<ManagedDeviceItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
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
        /// Update the navigation property managedDevices in deviceManagement
        /// <param name="body"></param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(Microsoft.Graph.Beta.Models.ManagedDevice body, Action<ManagedDeviceItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
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
        /// Delete navigation property managedDevices for deviceManagement
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(CancellationToken cancellationToken = default, Action<ManagedDeviceItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// The list of managed devices.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<Microsoft.Graph.Beta.Models.ManagedDevice> GetAsync(CancellationToken cancellationToken = default, Action<ManagedDeviceItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.ManagedDevice>(requestInfo, Microsoft.Graph.Beta.Models.ManagedDevice.CreateFromDiscriminatorValue, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Provides operations to call the getCloudPcRemoteActionResults method.
        /// </summary>
        public GetCloudPcRemoteActionResultsRequestBuilder GetCloudPcRemoteActionResults() {
            return new GetCloudPcRemoteActionResultsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the getCloudPcReviewStatus method.
        /// </summary>
        public GetCloudPcReviewStatusRequestBuilder GetCloudPcReviewStatus() {
            return new GetCloudPcReviewStatusRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the getFileVaultKey method.
        /// </summary>
        public GetFileVaultKeyRequestBuilder GetFileVaultKey() {
            return new GetFileVaultKeyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the getNonCompliantSettings method.
        /// </summary>
        public GetNonCompliantSettingsRequestBuilder GetNonCompliantSettings() {
            return new GetNonCompliantSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the getOemWarranty method.
        /// </summary>
        public GetOemWarrantyRequestBuilder GetOemWarranty() {
            return new GetOemWarrantyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Update the navigation property managedDevices in deviceManagement
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(Microsoft.Graph.Beta.Models.ManagedDevice body, CancellationToken cancellationToken = default, Action<ManagedDeviceItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default, IResponseHandler responseHandler = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Provides operations to call the retrieveRemoteHelpSession method.
        /// <param name="sessionKey">Usage: sessionKey=&apos;{sessionKey}&apos;</param>
        /// </summary>
        public RetrieveRemoteHelpSessionWithSessionKeyRequestBuilder RetrieveRemoteHelpSessionWithSessionKey(string sessionKey) {
            if(string.IsNullOrEmpty(sessionKey)) throw new ArgumentNullException(nameof(sessionKey));
            return new RetrieveRemoteHelpSessionWithSessionKeyRequestBuilder(PathParameters, RequestAdapter, sessionKey);
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class ManagedDeviceItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new ManagedDeviceItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public ManagedDeviceItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
        /// <summary>The list of managed devices.</summary>
        public class ManagedDeviceItemRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class ManagedDeviceItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public ManagedDeviceItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new ManagedDeviceItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new ManagedDeviceItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public ManagedDeviceItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class ManagedDeviceItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new ManagedDeviceItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public ManagedDeviceItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
    }
}
