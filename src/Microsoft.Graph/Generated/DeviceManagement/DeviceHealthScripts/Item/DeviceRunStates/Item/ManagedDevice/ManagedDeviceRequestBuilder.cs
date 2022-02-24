using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.DeviceManagement.DeviceHealthScripts.Item.DeviceRunStates.Item.ManagedDevice.ActivateDeviceEsim;
using MicrosoftGraphSdk.DeviceManagement.DeviceHealthScripts.Item.DeviceRunStates.Item.ManagedDevice.BypassActivationLock;
using MicrosoftGraphSdk.DeviceManagement.DeviceHealthScripts.Item.DeviceRunStates.Item.ManagedDevice.CleanWindowsDevice;
using MicrosoftGraphSdk.DeviceManagement.DeviceHealthScripts.Item.DeviceRunStates.Item.ManagedDevice.CreateDeviceLogCollectionRequest;
using MicrosoftGraphSdk.DeviceManagement.DeviceHealthScripts.Item.DeviceRunStates.Item.ManagedDevice.DeleteUserFromSharedAppleDevice;
using MicrosoftGraphSdk.DeviceManagement.DeviceHealthScripts.Item.DeviceRunStates.Item.ManagedDevice.Deprovision;
using MicrosoftGraphSdk.DeviceManagement.DeviceHealthScripts.Item.DeviceRunStates.Item.ManagedDevice.Disable;
using MicrosoftGraphSdk.DeviceManagement.DeviceHealthScripts.Item.DeviceRunStates.Item.ManagedDevice.DisableLostMode;
using MicrosoftGraphSdk.DeviceManagement.DeviceHealthScripts.Item.DeviceRunStates.Item.ManagedDevice.EnableLostMode;
using MicrosoftGraphSdk.DeviceManagement.DeviceHealthScripts.Item.DeviceRunStates.Item.ManagedDevice.GetCloudPcRemoteActionResults;
using MicrosoftGraphSdk.DeviceManagement.DeviceHealthScripts.Item.DeviceRunStates.Item.ManagedDevice.GetFileVaultKey;
using MicrosoftGraphSdk.DeviceManagement.DeviceHealthScripts.Item.DeviceRunStates.Item.ManagedDevice.GetNonCompliantSettings;
using MicrosoftGraphSdk.DeviceManagement.DeviceHealthScripts.Item.DeviceRunStates.Item.ManagedDevice.GetOemWarranty;
using MicrosoftGraphSdk.DeviceManagement.DeviceHealthScripts.Item.DeviceRunStates.Item.ManagedDevice.LocateDevice;
using MicrosoftGraphSdk.DeviceManagement.DeviceHealthScripts.Item.DeviceRunStates.Item.ManagedDevice.LogoutSharedAppleDeviceActiveUser;
using MicrosoftGraphSdk.DeviceManagement.DeviceHealthScripts.Item.DeviceRunStates.Item.ManagedDevice.OverrideComplianceState;
using MicrosoftGraphSdk.DeviceManagement.DeviceHealthScripts.Item.DeviceRunStates.Item.ManagedDevice.PlayLostModeSound;
using MicrosoftGraphSdk.DeviceManagement.DeviceHealthScripts.Item.DeviceRunStates.Item.ManagedDevice.RebootNow;
using MicrosoftGraphSdk.DeviceManagement.DeviceHealthScripts.Item.DeviceRunStates.Item.ManagedDevice.RecoverPasscode;
using MicrosoftGraphSdk.DeviceManagement.DeviceHealthScripts.Item.DeviceRunStates.Item.ManagedDevice.Reenable;
using MicrosoftGraphSdk.DeviceManagement.DeviceHealthScripts.Item.DeviceRunStates.Item.ManagedDevice.Ref;
using MicrosoftGraphSdk.DeviceManagement.DeviceHealthScripts.Item.DeviceRunStates.Item.ManagedDevice.RemoteLock;
using MicrosoftGraphSdk.DeviceManagement.DeviceHealthScripts.Item.DeviceRunStates.Item.ManagedDevice.ReprovisionCloudPc;
using MicrosoftGraphSdk.DeviceManagement.DeviceHealthScripts.Item.DeviceRunStates.Item.ManagedDevice.RequestRemoteAssistance;
using MicrosoftGraphSdk.DeviceManagement.DeviceHealthScripts.Item.DeviceRunStates.Item.ManagedDevice.ResetPasscode;
using MicrosoftGraphSdk.DeviceManagement.DeviceHealthScripts.Item.DeviceRunStates.Item.ManagedDevice.ResizeCloudPc;
using MicrosoftGraphSdk.DeviceManagement.DeviceHealthScripts.Item.DeviceRunStates.Item.ManagedDevice.RestoreCloudPc;
using MicrosoftGraphSdk.DeviceManagement.DeviceHealthScripts.Item.DeviceRunStates.Item.ManagedDevice.Retire;
using MicrosoftGraphSdk.DeviceManagement.DeviceHealthScripts.Item.DeviceRunStates.Item.ManagedDevice.RevokeAppleVppLicenses;
using MicrosoftGraphSdk.DeviceManagement.DeviceHealthScripts.Item.DeviceRunStates.Item.ManagedDevice.RotateBitLockerKeys;
using MicrosoftGraphSdk.DeviceManagement.DeviceHealthScripts.Item.DeviceRunStates.Item.ManagedDevice.RotateFileVaultKey;
using MicrosoftGraphSdk.DeviceManagement.DeviceHealthScripts.Item.DeviceRunStates.Item.ManagedDevice.SendCustomNotificationToCompanyPortal;
using MicrosoftGraphSdk.DeviceManagement.DeviceHealthScripts.Item.DeviceRunStates.Item.ManagedDevice.SetDeviceName;
using MicrosoftGraphSdk.DeviceManagement.DeviceHealthScripts.Item.DeviceRunStates.Item.ManagedDevice.ShutDown;
using MicrosoftGraphSdk.DeviceManagement.DeviceHealthScripts.Item.DeviceRunStates.Item.ManagedDevice.SyncDevice;
using MicrosoftGraphSdk.DeviceManagement.DeviceHealthScripts.Item.DeviceRunStates.Item.ManagedDevice.TriggerConfigurationManagerAction;
using MicrosoftGraphSdk.DeviceManagement.DeviceHealthScripts.Item.DeviceRunStates.Item.ManagedDevice.UpdateWindowsDeviceAccount;
using MicrosoftGraphSdk.DeviceManagement.DeviceHealthScripts.Item.DeviceRunStates.Item.ManagedDevice.WindowsDefenderScan;
using MicrosoftGraphSdk.DeviceManagement.DeviceHealthScripts.Item.DeviceRunStates.Item.ManagedDevice.WindowsDefenderUpdateSignatures;
using MicrosoftGraphSdk.DeviceManagement.DeviceHealthScripts.Item.DeviceRunStates.Item.ManagedDevice.Wipe;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MicrosoftGraphSdk.DeviceManagement.DeviceHealthScripts.Item.DeviceRunStates.Item.ManagedDevice {
    /// <summary>Builds and executes requests for operations under \deviceManagement\deviceHealthScripts\{deviceHealthScript-id}\deviceRunStates\{deviceHealthScriptDeviceState-id}\managedDevice</summary>
    public class ManagedDeviceRequestBuilder {
        public ActivateDeviceEsimRequestBuilder ActivateDeviceEsim { get =>
            new ActivateDeviceEsimRequestBuilder(PathParameters, RequestAdapter);
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
        public LogoutSharedAppleDeviceActiveUserRequestBuilder LogoutSharedAppleDeviceActiveUser { get =>
            new LogoutSharedAppleDeviceActiveUserRequestBuilder(PathParameters, RequestAdapter);
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
        public RefRequestBuilder Ref { get =>
            new RefRequestBuilder(PathParameters, RequestAdapter);
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
        public WindowsDefenderScanRequestBuilder WindowsDefenderScan { get =>
            new WindowsDefenderScanRequestBuilder(PathParameters, RequestAdapter);
        }
        public WindowsDefenderUpdateSignaturesRequestBuilder WindowsDefenderUpdateSignatures { get =>
            new WindowsDefenderUpdateSignaturesRequestBuilder(PathParameters, RequestAdapter);
        }
        public WipeRequestBuilder Wipe { get =>
            new WipeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new ManagedDeviceRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public ManagedDeviceRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/deviceHealthScripts/{deviceHealthScript_id}/deviceRunStates/{deviceHealthScriptDeviceState_id}/managedDevice{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new ManagedDeviceRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public ManagedDeviceRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/deviceHealthScripts/{deviceHealthScript_id}/deviceRunStates/{deviceHealthScriptDeviceState_id}/managedDevice{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// The managed device on which the device health script executed
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
        /// The managed device on which the device health script executed
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedDevice> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedDevice>(requestInfo, responseHandler, default, cancellationToken);
        }
        /// <summary>
        /// Builds and executes requests for operations under \deviceManagement\deviceHealthScripts\{deviceHealthScript-id}\deviceRunStates\{deviceHealthScriptDeviceState-id}\managedDevice\microsoft.graph.getCloudPcRemoteActionResults()
        /// </summary>
        public GetCloudPcRemoteActionResultsRequestBuilder GetCloudPcRemoteActionResults() {
            return new GetCloudPcRemoteActionResultsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \deviceManagement\deviceHealthScripts\{deviceHealthScript-id}\deviceRunStates\{deviceHealthScriptDeviceState-id}\managedDevice\microsoft.graph.getFileVaultKey()
        /// </summary>
        public GetFileVaultKeyRequestBuilder GetFileVaultKey() {
            return new GetFileVaultKeyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \deviceManagement\deviceHealthScripts\{deviceHealthScript-id}\deviceRunStates\{deviceHealthScriptDeviceState-id}\managedDevice\microsoft.graph.getNonCompliantSettings()
        /// </summary>
        public GetNonCompliantSettingsRequestBuilder GetNonCompliantSettings() {
            return new GetNonCompliantSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Builds and executes requests for operations under \deviceManagement\deviceHealthScripts\{deviceHealthScript-id}\deviceRunStates\{deviceHealthScriptDeviceState-id}\managedDevice\microsoft.graph.getOemWarranty()
        /// </summary>
        public GetOemWarrantyRequestBuilder GetOemWarranty() {
            return new GetOemWarrantyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The managed device on which the device health script executed</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
