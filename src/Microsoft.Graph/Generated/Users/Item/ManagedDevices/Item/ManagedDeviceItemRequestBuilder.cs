using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using MicrosoftGraphSdk.Models.Microsoft.Graph.ODataErrors;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.ActivateDeviceEsim;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.AssignmentFilterEvaluationStatusDetails;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.BypassActivationLock;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.CleanWindowsDevice;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.CreateDeviceLogCollectionRequest;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.DeleteUserFromSharedAppleDevice;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.Deprovision;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.DetectedApps;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.DeviceCategory;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.DeviceCompliancePolicyStates;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.DeviceConfigurationStates;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.Disable;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.DisableLostMode;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.EnableLostMode;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.GetCloudPcRemoteActionResults;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.GetFileVaultKey;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.GetNonCompliantSettings;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.GetOemWarranty;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.LocateDevice;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.LogCollectionRequests;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.LogoutSharedAppleDeviceActiveUser;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.ManagedDeviceMobileAppConfigurationStates;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.OverrideComplianceState;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.PlayLostModeSound;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.RebootNow;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.RecoverPasscode;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.Reenable;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.RemoteLock;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.ReprovisionCloudPc;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.RequestRemoteAssistance;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.ResetPasscode;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.ResizeCloudPc;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.RestoreCloudPc;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.Retire;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.RevokeAppleVppLicenses;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.RotateBitLockerKeys;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.RotateFileVaultKey;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.SecurityBaselineStates;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.SendCustomNotificationToCompanyPortal;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.SetDeviceName;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.ShutDown;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.SyncDevice;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.TriggerConfigurationManagerAction;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.UpdateWindowsDeviceAccount;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.Users;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.WindowsDefenderScan;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.WindowsDefenderUpdateSignatures;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.WindowsProtectionState;
using MicrosoftGraphSdk.Users.Item.ManagedDevices.Item.Wipe;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MicrosoftGraphSdk.Users.Item.ManagedDevices.Item {
    /// <summary>Provides operations to manage the managedDevices property of the microsoft.graph.user entity.</summary>
    public class ManagedDeviceItemRequestBuilder {
        public ActivateDeviceEsimRequestBuilder ActivateDeviceEsim { get =>
            new ActivateDeviceEsimRequestBuilder(PathParameters, RequestAdapter);
        }
        public AssignmentFilterEvaluationStatusDetailsRequestBuilder AssignmentFilterEvaluationStatusDetails { get =>
            new AssignmentFilterEvaluationStatusDetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        public BypassActivationLockRequestBuilder BypassActivationLock { get =>
            new BypassActivationLockRequestBuilder(PathParameters, RequestAdapter);
        }
        public CleanWindowsDeviceRequestBuilder CleanWindowsDevice { get =>
            new CleanWindowsDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        public CreateDeviceLogCollectionRequestRequestBuilder CreateDeviceLogCollectionRequest { get =>
            new CreateDeviceLogCollectionRequestRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeleteUserFromSharedAppleDeviceRequestBuilder DeleteUserFromSharedAppleDevice { get =>
            new DeleteUserFromSharedAppleDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeprovisionRequestBuilder Deprovision { get =>
            new DeprovisionRequestBuilder(PathParameters, RequestAdapter);
        }
        public DetectedAppsRequestBuilder DetectedApps { get =>
            new DetectedAppsRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeviceCategoryRequestBuilder DeviceCategory { get =>
            new DeviceCategoryRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeviceCompliancePolicyStatesRequestBuilder DeviceCompliancePolicyStates { get =>
            new DeviceCompliancePolicyStatesRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeviceConfigurationStatesRequestBuilder DeviceConfigurationStates { get =>
            new DeviceConfigurationStatesRequestBuilder(PathParameters, RequestAdapter);
        }
        public DisableRequestBuilder Disable { get =>
            new DisableRequestBuilder(PathParameters, RequestAdapter);
        }
        public DisableLostModeRequestBuilder DisableLostMode { get =>
            new DisableLostModeRequestBuilder(PathParameters, RequestAdapter);
        }
        public EnableLostModeRequestBuilder EnableLostMode { get =>
            new EnableLostModeRequestBuilder(PathParameters, RequestAdapter);
        }
        public LocateDeviceRequestBuilder LocateDevice { get =>
            new LocateDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        public LogCollectionRequestsRequestBuilder LogCollectionRequests { get =>
            new LogCollectionRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        public LogoutSharedAppleDeviceActiveUserRequestBuilder LogoutSharedAppleDeviceActiveUser { get =>
            new LogoutSharedAppleDeviceActiveUserRequestBuilder(PathParameters, RequestAdapter);
        }
        public ManagedDeviceMobileAppConfigurationStatesRequestBuilder ManagedDeviceMobileAppConfigurationStates { get =>
            new ManagedDeviceMobileAppConfigurationStatesRequestBuilder(PathParameters, RequestAdapter);
        }
        public OverrideComplianceStateRequestBuilder OverrideComplianceState { get =>
            new OverrideComplianceStateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        public PlayLostModeSoundRequestBuilder PlayLostModeSound { get =>
            new PlayLostModeSoundRequestBuilder(PathParameters, RequestAdapter);
        }
        public RebootNowRequestBuilder RebootNow { get =>
            new RebootNowRequestBuilder(PathParameters, RequestAdapter);
        }
        public RecoverPasscodeRequestBuilder RecoverPasscode { get =>
            new RecoverPasscodeRequestBuilder(PathParameters, RequestAdapter);
        }
        public ReenableRequestBuilder Reenable { get =>
            new ReenableRequestBuilder(PathParameters, RequestAdapter);
        }
        public RemoteLockRequestBuilder RemoteLock { get =>
            new RemoteLockRequestBuilder(PathParameters, RequestAdapter);
        }
        public ReprovisionCloudPcRequestBuilder ReprovisionCloudPc { get =>
            new ReprovisionCloudPcRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        public RequestRemoteAssistanceRequestBuilder RequestRemoteAssistance { get =>
            new RequestRemoteAssistanceRequestBuilder(PathParameters, RequestAdapter);
        }
        public ResetPasscodeRequestBuilder ResetPasscode { get =>
            new ResetPasscodeRequestBuilder(PathParameters, RequestAdapter);
        }
        public ResizeCloudPcRequestBuilder ResizeCloudPc { get =>
            new ResizeCloudPcRequestBuilder(PathParameters, RequestAdapter);
        }
        public RestoreCloudPcRequestBuilder RestoreCloudPc { get =>
            new RestoreCloudPcRequestBuilder(PathParameters, RequestAdapter);
        }
        public RetireRequestBuilder Retire { get =>
            new RetireRequestBuilder(PathParameters, RequestAdapter);
        }
        public RevokeAppleVppLicensesRequestBuilder RevokeAppleVppLicenses { get =>
            new RevokeAppleVppLicensesRequestBuilder(PathParameters, RequestAdapter);
        }
        public RotateBitLockerKeysRequestBuilder RotateBitLockerKeys { get =>
            new RotateBitLockerKeysRequestBuilder(PathParameters, RequestAdapter);
        }
        public RotateFileVaultKeyRequestBuilder RotateFileVaultKey { get =>
            new RotateFileVaultKeyRequestBuilder(PathParameters, RequestAdapter);
        }
        public SecurityBaselineStatesRequestBuilder SecurityBaselineStates { get =>
            new SecurityBaselineStatesRequestBuilder(PathParameters, RequestAdapter);
        }
        public SendCustomNotificationToCompanyPortalRequestBuilder SendCustomNotificationToCompanyPortal { get =>
            new SendCustomNotificationToCompanyPortalRequestBuilder(PathParameters, RequestAdapter);
        }
        public SetDeviceNameRequestBuilder SetDeviceName { get =>
            new SetDeviceNameRequestBuilder(PathParameters, RequestAdapter);
        }
        public ShutDownRequestBuilder ShutDown { get =>
            new ShutDownRequestBuilder(PathParameters, RequestAdapter);
        }
        public SyncDeviceRequestBuilder SyncDevice { get =>
            new SyncDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        public TriggerConfigurationManagerActionRequestBuilder TriggerConfigurationManagerAction { get =>
            new TriggerConfigurationManagerActionRequestBuilder(PathParameters, RequestAdapter);
        }
        public UpdateWindowsDeviceAccountRequestBuilder UpdateWindowsDeviceAccount { get =>
            new UpdateWindowsDeviceAccountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public UsersRequestBuilder Users { get =>
            new UsersRequestBuilder(PathParameters, RequestAdapter);
        }
        public WindowsDefenderScanRequestBuilder WindowsDefenderScan { get =>
            new WindowsDefenderScanRequestBuilder(PathParameters, RequestAdapter);
        }
        public WindowsDefenderUpdateSignaturesRequestBuilder WindowsDefenderUpdateSignatures { get =>
            new WindowsDefenderUpdateSignaturesRequestBuilder(PathParameters, RequestAdapter);
        }
        public WindowsProtectionStateRequestBuilder WindowsProtectionState { get =>
            new WindowsProtectionStateRequestBuilder(PathParameters, RequestAdapter);
        }
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
            UrlTemplate = "{+baseurl}/users/{user_id}/managedDevices/{managedDevice_id}{?select,expand}";
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
            UrlTemplate = "{+baseurl}/users/{user_id}/managedDevices/{managedDevice_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property managedDevices for users
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// The managed devices associated with the user.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (q != null) {
                var qParams = new GetQueryParameters();
                q.Invoke(qParams);
                qParams.AddQueryParameters(requestInfo.QueryParameters);
            }
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property managedDevices in users
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedDevice body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Delete navigation property managedDevices for users
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// The managed devices associated with the user.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedDevice> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedDevice>(requestInfo, MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedDevice.CreateFromDiscriminatorValue, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Provides operations to call the getCloudPcRemoteActionResults method.
        /// </summary>
        public GetCloudPcRemoteActionResultsRequestBuilder GetCloudPcRemoteActionResults() {
            return new GetCloudPcRemoteActionResultsRequestBuilder(PathParameters, RequestAdapter);
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
        /// Update the navigation property managedDevices in users
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedDevice body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>The managed devices associated with the user.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
