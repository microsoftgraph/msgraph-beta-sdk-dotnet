using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using MicrosoftGraphSdk.Models.Microsoft.Graph.ODataErrors;
using MicrosoftGraphSdk.Reports.ApplicationSignInDetailedSummary;
using MicrosoftGraphSdk.Reports.AuthenticationMethods;
using MicrosoftGraphSdk.Reports.CredentialUserRegistrationDetails;
using MicrosoftGraphSdk.Reports.DailyPrintUsageByPrinter;
using MicrosoftGraphSdk.Reports.DailyPrintUsageByUser;
using MicrosoftGraphSdk.Reports.DailyPrintUsageSummariesByPrinter;
using MicrosoftGraphSdk.Reports.DailyPrintUsageSummariesByUser;
using MicrosoftGraphSdk.Reports.DeviceConfigurationDeviceActivity;
using MicrosoftGraphSdk.Reports.DeviceConfigurationUserActivity;
using MicrosoftGraphSdk.Reports.GetAttackSimulationRepeatOffenders;
using MicrosoftGraphSdk.Reports.GetAttackSimulationSimulationUserCoverage;
using MicrosoftGraphSdk.Reports.GetAttackSimulationTrainingUserCoverage;
using MicrosoftGraphSdk.Reports.GetAzureADApplicationSignInSummaryWithPeriod;
using MicrosoftGraphSdk.Reports.GetAzureADFeatureUsageWithPeriod;
using MicrosoftGraphSdk.Reports.GetAzureADLicenseUsageWithPeriod;
using MicrosoftGraphSdk.Reports.GetAzureADUserFeatureUsage;
using MicrosoftGraphSdk.Reports.GetBrowserDistributionUserCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetBrowserUserCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetBrowserUserDetailWithPeriod;
using MicrosoftGraphSdk.Reports.GetCredentialUsageSummaryWithPeriod;
using MicrosoftGraphSdk.Reports.GetCredentialUserRegistrationCount;
using MicrosoftGraphSdk.Reports.GetEmailActivityCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetEmailActivityUserCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetEmailActivityUserDetailWithDate;
using MicrosoftGraphSdk.Reports.GetEmailActivityUserDetailWithPeriod;
using MicrosoftGraphSdk.Reports.GetEmailAppUsageAppsUserCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetEmailAppUsageUserCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetEmailAppUsageUserDetailWithDate;
using MicrosoftGraphSdk.Reports.GetEmailAppUsageUserDetailWithPeriod;
using MicrosoftGraphSdk.Reports.GetEmailAppUsageVersionsUserCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetGroupArchivedPrintJobsWithGroupIdWithStartDateTimeWithEndDateTime;
using MicrosoftGraphSdk.Reports.GetM365AppPlatformUserCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetM365AppUserCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetM365AppUserDetailWithDate;
using MicrosoftGraphSdk.Reports.GetM365AppUserDetailWithPeriod;
using MicrosoftGraphSdk.Reports.GetMailboxUsageDetailWithPeriod;
using MicrosoftGraphSdk.Reports.GetMailboxUsageMailboxCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetMailboxUsageQuotaStatusMailboxCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetMailboxUsageStorageWithPeriod;
using MicrosoftGraphSdk.Reports.GetOffice365ActivationCounts;
using MicrosoftGraphSdk.Reports.GetOffice365ActivationsUserCounts;
using MicrosoftGraphSdk.Reports.GetOffice365ActivationsUserDetail;
using MicrosoftGraphSdk.Reports.GetOffice365ActiveUserCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetOffice365ActiveUserDetailWithDate;
using MicrosoftGraphSdk.Reports.GetOffice365ActiveUserDetailWithPeriod;
using MicrosoftGraphSdk.Reports.GetOffice365GroupsActivityCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetOffice365GroupsActivityDetailWithDate;
using MicrosoftGraphSdk.Reports.GetOffice365GroupsActivityDetailWithPeriod;
using MicrosoftGraphSdk.Reports.GetOffice365GroupsActivityFileCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetOffice365GroupsActivityGroupCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetOffice365GroupsActivityStorageWithPeriod;
using MicrosoftGraphSdk.Reports.GetOffice365ServicesUserCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetOneDriveActivityFileCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetOneDriveActivityUserCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetOneDriveActivityUserDetailWithDate;
using MicrosoftGraphSdk.Reports.GetOneDriveActivityUserDetailWithPeriod;
using MicrosoftGraphSdk.Reports.GetOneDriveUsageAccountCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetOneDriveUsageAccountDetailWithDate;
using MicrosoftGraphSdk.Reports.GetOneDriveUsageAccountDetailWithPeriod;
using MicrosoftGraphSdk.Reports.GetOneDriveUsageFileCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetOneDriveUsageStorageWithPeriod;
using MicrosoftGraphSdk.Reports.GetPrinterArchivedPrintJobsWithPrinterIdWithStartDateTimeWithEndDateTime;
using MicrosoftGraphSdk.Reports.GetRelyingPartyDetailedSummaryWithPeriod;
using MicrosoftGraphSdk.Reports.GetSharePointActivityFileCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetSharePointActivityPagesWithPeriod;
using MicrosoftGraphSdk.Reports.GetSharePointActivityUserCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetSharePointActivityUserDetailWithDate;
using MicrosoftGraphSdk.Reports.GetSharePointActivityUserDetailWithPeriod;
using MicrosoftGraphSdk.Reports.GetSharePointSiteUsageDetailWithDate;
using MicrosoftGraphSdk.Reports.GetSharePointSiteUsageDetailWithPeriod;
using MicrosoftGraphSdk.Reports.GetSharePointSiteUsageFileCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetSharePointSiteUsagePagesWithPeriod;
using MicrosoftGraphSdk.Reports.GetSharePointSiteUsageSiteCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetSharePointSiteUsageStorageWithPeriod;
using MicrosoftGraphSdk.Reports.GetSkypeForBusinessActivityCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetSkypeForBusinessActivityUserCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetSkypeForBusinessActivityUserDetailWithDate;
using MicrosoftGraphSdk.Reports.GetSkypeForBusinessActivityUserDetailWithPeriod;
using MicrosoftGraphSdk.Reports.GetSkypeForBusinessDeviceUsageDistributionUserCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetSkypeForBusinessDeviceUsageUserCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetSkypeForBusinessDeviceUsageUserDetailWithDate;
using MicrosoftGraphSdk.Reports.GetSkypeForBusinessDeviceUsageUserDetailWithPeriod;
using MicrosoftGraphSdk.Reports.GetSkypeForBusinessOrganizerActivityCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetSkypeForBusinessOrganizerActivityMinuteCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetSkypeForBusinessOrganizerActivityUserCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetSkypeForBusinessParticipantActivityCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetSkypeForBusinessParticipantActivityMinuteCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetSkypeForBusinessParticipantActivityUserCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetSkypeForBusinessPeerToPeerActivityCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetSkypeForBusinessPeerToPeerActivityMinuteCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetSkypeForBusinessPeerToPeerActivityUserCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetTeamsDeviceUsageDistributionTotalUserCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetTeamsDeviceUsageDistributionUserCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetTeamsDeviceUsageTotalUserCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetTeamsDeviceUsageUserCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetTeamsDeviceUsageUserDetailWithDate;
using MicrosoftGraphSdk.Reports.GetTeamsDeviceUsageUserDetailWithPeriod;
using MicrosoftGraphSdk.Reports.GetTeamsTeamActivityCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetTeamsTeamActivityDetailWithDate;
using MicrosoftGraphSdk.Reports.GetTeamsTeamActivityDetailWithPeriod;
using MicrosoftGraphSdk.Reports.GetTeamsTeamActivityDistributionCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetTeamsUserActivityCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetTeamsUserActivityDistributionTotalUserCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetTeamsUserActivityDistributionUserCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetTeamsUserActivityTotalCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetTeamsUserActivityTotalDistributionCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetTeamsUserActivityTotalUserCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetTeamsUserActivityUserCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetTeamsUserActivityUserDetailWithDate;
using MicrosoftGraphSdk.Reports.GetTeamsUserActivityUserDetailWithPeriod;
using MicrosoftGraphSdk.Reports.GetUserArchivedPrintJobsWithUserIdWithStartDateTimeWithEndDateTime;
using MicrosoftGraphSdk.Reports.GetYammerActivityCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetYammerActivityUserCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetYammerActivityUserDetailWithDate;
using MicrosoftGraphSdk.Reports.GetYammerActivityUserDetailWithPeriod;
using MicrosoftGraphSdk.Reports.GetYammerDeviceUsageDistributionUserCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetYammerDeviceUsageUserCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetYammerDeviceUsageUserDetailWithDate;
using MicrosoftGraphSdk.Reports.GetYammerDeviceUsageUserDetailWithPeriod;
using MicrosoftGraphSdk.Reports.GetYammerGroupsActivityCountsWithPeriod;
using MicrosoftGraphSdk.Reports.GetYammerGroupsActivityDetailWithDate;
using MicrosoftGraphSdk.Reports.GetYammerGroupsActivityDetailWithPeriod;
using MicrosoftGraphSdk.Reports.GetYammerGroupsActivityGroupCountsWithPeriod;
using MicrosoftGraphSdk.Reports.ManagedDeviceEnrollmentAbandonmentDetailsWithSkipWithTopWithFilterWithSkipToken;
using MicrosoftGraphSdk.Reports.ManagedDeviceEnrollmentAbandonmentSummaryWithSkipWithTopWithFilterWithSkipToken;
using MicrosoftGraphSdk.Reports.ManagedDeviceEnrollmentFailureDetails;
using MicrosoftGraphSdk.Reports.ManagedDeviceEnrollmentFailureDetailsWithSkipWithTopWithFilterWithSkipToken;
using MicrosoftGraphSdk.Reports.ManagedDeviceEnrollmentFailureTrends;
using MicrosoftGraphSdk.Reports.ManagedDeviceEnrollmentTopFailures;
using MicrosoftGraphSdk.Reports.ManagedDeviceEnrollmentTopFailuresWithPeriod;
using MicrosoftGraphSdk.Reports.MonthlyPrintUsageByPrinter;
using MicrosoftGraphSdk.Reports.MonthlyPrintUsageByUser;
using MicrosoftGraphSdk.Reports.MonthlyPrintUsageSummariesByPrinter;
using MicrosoftGraphSdk.Reports.MonthlyPrintUsageSummariesByUser;
using MicrosoftGraphSdk.Reports.UserCredentialUsageDetails;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MicrosoftGraphSdk.Reports {
    /// <summary>Provides operations to manage the reportRoot singleton.</summary>
    public class ReportsRequestBuilder {
        /// <summary>The applicationSignInDetailedSummary property</summary>
        public ApplicationSignInDetailedSummaryRequestBuilder ApplicationSignInDetailedSummary { get =>
            new ApplicationSignInDetailedSummaryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The authenticationMethods property</summary>
        public AuthenticationMethodsRequestBuilder AuthenticationMethods { get =>
            new AuthenticationMethodsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The credentialUserRegistrationDetails property</summary>
        public CredentialUserRegistrationDetailsRequestBuilder CredentialUserRegistrationDetails { get =>
            new CredentialUserRegistrationDetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The dailyPrintUsageByPrinter property</summary>
        public DailyPrintUsageByPrinterRequestBuilder DailyPrintUsageByPrinter { get =>
            new DailyPrintUsageByPrinterRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The dailyPrintUsageByUser property</summary>
        public DailyPrintUsageByUserRequestBuilder DailyPrintUsageByUser { get =>
            new DailyPrintUsageByUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The dailyPrintUsageSummariesByPrinter property</summary>
        public DailyPrintUsageSummariesByPrinterRequestBuilder DailyPrintUsageSummariesByPrinter { get =>
            new DailyPrintUsageSummariesByPrinterRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The dailyPrintUsageSummariesByUser property</summary>
        public DailyPrintUsageSummariesByUserRequestBuilder DailyPrintUsageSummariesByUser { get =>
            new DailyPrintUsageSummariesByUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The monthlyPrintUsageByPrinter property</summary>
        public MonthlyPrintUsageByPrinterRequestBuilder MonthlyPrintUsageByPrinter { get =>
            new MonthlyPrintUsageByPrinterRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The monthlyPrintUsageByUser property</summary>
        public MonthlyPrintUsageByUserRequestBuilder MonthlyPrintUsageByUser { get =>
            new MonthlyPrintUsageByUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The monthlyPrintUsageSummariesByPrinter property</summary>
        public MonthlyPrintUsageSummariesByPrinterRequestBuilder MonthlyPrintUsageSummariesByPrinter { get =>
            new MonthlyPrintUsageSummariesByPrinterRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The monthlyPrintUsageSummariesByUser property</summary>
        public MonthlyPrintUsageSummariesByUserRequestBuilder MonthlyPrintUsageSummariesByUser { get =>
            new MonthlyPrintUsageSummariesByUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>The userCredentialUsageDetails property</summary>
        public UserCredentialUsageDetailsRequestBuilder UserCredentialUsageDetails { get =>
            new UserCredentialUsageDetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new ReportsRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public ReportsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/reports{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new ReportsRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public ReportsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/reports{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Get reports
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// <param name="queryParameters">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> queryParameters = default, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (queryParameters != null) {
                var qParams = new GetQueryParameters();
                queryParameters.Invoke(qParams);
                qParams.AddQueryParameters(requestInfo.QueryParameters);
            }
            headers?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(options?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Update reports
        /// <param name="body"></param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(ReportRoot body, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            headers?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(options?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Provides operations to call the deviceConfigurationDeviceActivity method.
        /// </summary>
        public DeviceConfigurationDeviceActivityRequestBuilder DeviceConfigurationDeviceActivity() {
            return new DeviceConfigurationDeviceActivityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the deviceConfigurationUserActivity method.
        /// </summary>
        public DeviceConfigurationUserActivityRequestBuilder DeviceConfigurationUserActivity() {
            return new DeviceConfigurationUserActivityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Get reports
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// <param name="queryParameters">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<ReportRoot> GetAsync(Action<GetQueryParameters> queryParameters = default, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(queryParameters, headers, options);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<ReportRoot>(requestInfo, ReportRoot.CreateFromDiscriminatorValue, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Provides operations to call the getAttackSimulationRepeatOffenders method.
        /// </summary>
        public GetAttackSimulationRepeatOffendersRequestBuilder GetAttackSimulationRepeatOffenders() {
            return new GetAttackSimulationRepeatOffendersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the getAttackSimulationSimulationUserCoverage method.
        /// </summary>
        public GetAttackSimulationSimulationUserCoverageRequestBuilder GetAttackSimulationSimulationUserCoverage() {
            return new GetAttackSimulationSimulationUserCoverageRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the getAttackSimulationTrainingUserCoverage method.
        /// </summary>
        public GetAttackSimulationTrainingUserCoverageRequestBuilder GetAttackSimulationTrainingUserCoverage() {
            return new GetAttackSimulationTrainingUserCoverageRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the getAzureADApplicationSignInSummary method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetAzureADApplicationSignInSummaryWithPeriodRequestBuilder GetAzureADApplicationSignInSummaryWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetAzureADApplicationSignInSummaryWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getAzureADFeatureUsage method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetAzureADFeatureUsageWithPeriodRequestBuilder GetAzureADFeatureUsageWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetAzureADFeatureUsageWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getAzureADLicenseUsage method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetAzureADLicenseUsageWithPeriodRequestBuilder GetAzureADLicenseUsageWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetAzureADLicenseUsageWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getAzureADUserFeatureUsage method.
        /// </summary>
        public GetAzureADUserFeatureUsageRequestBuilder GetAzureADUserFeatureUsage() {
            return new GetAzureADUserFeatureUsageRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the getBrowserDistributionUserCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetBrowserDistributionUserCountsWithPeriodRequestBuilder GetBrowserDistributionUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetBrowserDistributionUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getBrowserUserCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetBrowserUserCountsWithPeriodRequestBuilder GetBrowserUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetBrowserUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getBrowserUserDetail method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetBrowserUserDetailWithPeriodRequestBuilder GetBrowserUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetBrowserUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getCredentialUsageSummary method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetCredentialUsageSummaryWithPeriodRequestBuilder GetCredentialUsageSummaryWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetCredentialUsageSummaryWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getCredentialUserRegistrationCount method.
        /// </summary>
        public GetCredentialUserRegistrationCountRequestBuilder GetCredentialUserRegistrationCount() {
            return new GetCredentialUserRegistrationCountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the getEmailActivityCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetEmailActivityCountsWithPeriodRequestBuilder GetEmailActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetEmailActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getEmailActivityUserCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetEmailActivityUserCountsWithPeriodRequestBuilder GetEmailActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetEmailActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getEmailActivityUserDetail method.
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetEmailActivityUserDetailWithDateRequestBuilder GetEmailActivityUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetEmailActivityUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getEmailActivityUserDetail method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetEmailActivityUserDetailWithPeriodRequestBuilder GetEmailActivityUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetEmailActivityUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getEmailAppUsageAppsUserCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetEmailAppUsageAppsUserCountsWithPeriodRequestBuilder GetEmailAppUsageAppsUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetEmailAppUsageAppsUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getEmailAppUsageUserCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetEmailAppUsageUserCountsWithPeriodRequestBuilder GetEmailAppUsageUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetEmailAppUsageUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getEmailAppUsageUserDetail method.
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetEmailAppUsageUserDetailWithDateRequestBuilder GetEmailAppUsageUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetEmailAppUsageUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getEmailAppUsageUserDetail method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetEmailAppUsageUserDetailWithPeriodRequestBuilder GetEmailAppUsageUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetEmailAppUsageUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getEmailAppUsageVersionsUserCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetEmailAppUsageVersionsUserCountsWithPeriodRequestBuilder GetEmailAppUsageVersionsUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetEmailAppUsageVersionsUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getGroupArchivedPrintJobs method.
        /// <param name="endDateTime">Usage: endDateTime=&apos;{endDateTime}&apos;</param>
        /// <param name="groupId">Usage: groupId=&apos;{groupId}&apos;</param>
        /// <param name="startDateTime">Usage: startDateTime=&apos;{startDateTime}&apos;</param>
        /// </summary>
        public GetGroupArchivedPrintJobsWithGroupIdWithStartDateTimeWithEndDateTimeRequestBuilder GetGroupArchivedPrintJobsWithGroupIdWithStartDateTimeWithEndDateTime(DateTimeOffset? endDateTime, string groupId, DateTimeOffset? startDateTime) {
            _ = endDateTime ?? throw new ArgumentNullException(nameof(endDateTime));
            if(string.IsNullOrEmpty(groupId)) throw new ArgumentNullException(nameof(groupId));
            _ = startDateTime ?? throw new ArgumentNullException(nameof(startDateTime));
            return new GetGroupArchivedPrintJobsWithGroupIdWithStartDateTimeWithEndDateTimeRequestBuilder(PathParameters, RequestAdapter, endDateTime, groupId, startDateTime);
        }
        /// <summary>
        /// Provides operations to call the getM365AppPlatformUserCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetM365AppPlatformUserCountsWithPeriodRequestBuilder GetM365AppPlatformUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetM365AppPlatformUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getM365AppUserCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetM365AppUserCountsWithPeriodRequestBuilder GetM365AppUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetM365AppUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getM365AppUserDetail method.
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetM365AppUserDetailWithDateRequestBuilder GetM365AppUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetM365AppUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getM365AppUserDetail method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetM365AppUserDetailWithPeriodRequestBuilder GetM365AppUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetM365AppUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getMailboxUsageDetail method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetMailboxUsageDetailWithPeriodRequestBuilder GetMailboxUsageDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetMailboxUsageDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getMailboxUsageMailboxCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetMailboxUsageMailboxCountsWithPeriodRequestBuilder GetMailboxUsageMailboxCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetMailboxUsageMailboxCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getMailboxUsageQuotaStatusMailboxCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetMailboxUsageQuotaStatusMailboxCountsWithPeriodRequestBuilder GetMailboxUsageQuotaStatusMailboxCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetMailboxUsageQuotaStatusMailboxCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getMailboxUsageStorage method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetMailboxUsageStorageWithPeriodRequestBuilder GetMailboxUsageStorageWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetMailboxUsageStorageWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOffice365ActivationCounts method.
        /// </summary>
        public GetOffice365ActivationCountsRequestBuilder GetOffice365ActivationCounts() {
            return new GetOffice365ActivationCountsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the getOffice365ActivationsUserCounts method.
        /// </summary>
        public GetOffice365ActivationsUserCountsRequestBuilder GetOffice365ActivationsUserCounts() {
            return new GetOffice365ActivationsUserCountsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the getOffice365ActivationsUserDetail method.
        /// </summary>
        public GetOffice365ActivationsUserDetailRequestBuilder GetOffice365ActivationsUserDetail() {
            return new GetOffice365ActivationsUserDetailRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the getOffice365ActiveUserCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetOffice365ActiveUserCountsWithPeriodRequestBuilder GetOffice365ActiveUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365ActiveUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOffice365ActiveUserDetail method.
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetOffice365ActiveUserDetailWithDateRequestBuilder GetOffice365ActiveUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetOffice365ActiveUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getOffice365ActiveUserDetail method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetOffice365ActiveUserDetailWithPeriodRequestBuilder GetOffice365ActiveUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365ActiveUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOffice365GroupsActivityCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetOffice365GroupsActivityCountsWithPeriodRequestBuilder GetOffice365GroupsActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365GroupsActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOffice365GroupsActivityDetail method.
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetOffice365GroupsActivityDetailWithDateRequestBuilder GetOffice365GroupsActivityDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetOffice365GroupsActivityDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getOffice365GroupsActivityDetail method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetOffice365GroupsActivityDetailWithPeriodRequestBuilder GetOffice365GroupsActivityDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365GroupsActivityDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOffice365GroupsActivityFileCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetOffice365GroupsActivityFileCountsWithPeriodRequestBuilder GetOffice365GroupsActivityFileCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365GroupsActivityFileCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOffice365GroupsActivityGroupCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetOffice365GroupsActivityGroupCountsWithPeriodRequestBuilder GetOffice365GroupsActivityGroupCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365GroupsActivityGroupCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOffice365GroupsActivityStorage method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetOffice365GroupsActivityStorageWithPeriodRequestBuilder GetOffice365GroupsActivityStorageWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365GroupsActivityStorageWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOffice365ServicesUserCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetOffice365ServicesUserCountsWithPeriodRequestBuilder GetOffice365ServicesUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOffice365ServicesUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOneDriveActivityFileCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetOneDriveActivityFileCountsWithPeriodRequestBuilder GetOneDriveActivityFileCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOneDriveActivityFileCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOneDriveActivityUserCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetOneDriveActivityUserCountsWithPeriodRequestBuilder GetOneDriveActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOneDriveActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOneDriveActivityUserDetail method.
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetOneDriveActivityUserDetailWithDateRequestBuilder GetOneDriveActivityUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetOneDriveActivityUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getOneDriveActivityUserDetail method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetOneDriveActivityUserDetailWithPeriodRequestBuilder GetOneDriveActivityUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOneDriveActivityUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOneDriveUsageAccountCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetOneDriveUsageAccountCountsWithPeriodRequestBuilder GetOneDriveUsageAccountCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOneDriveUsageAccountCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOneDriveUsageAccountDetail method.
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetOneDriveUsageAccountDetailWithDateRequestBuilder GetOneDriveUsageAccountDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetOneDriveUsageAccountDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getOneDriveUsageAccountDetail method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetOneDriveUsageAccountDetailWithPeriodRequestBuilder GetOneDriveUsageAccountDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOneDriveUsageAccountDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOneDriveUsageFileCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetOneDriveUsageFileCountsWithPeriodRequestBuilder GetOneDriveUsageFileCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOneDriveUsageFileCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOneDriveUsageStorage method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetOneDriveUsageStorageWithPeriodRequestBuilder GetOneDriveUsageStorageWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetOneDriveUsageStorageWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getPrinterArchivedPrintJobs method.
        /// <param name="endDateTime">Usage: endDateTime=&apos;{endDateTime}&apos;</param>
        /// <param name="printerId">Usage: printerId=&apos;{printerId}&apos;</param>
        /// <param name="startDateTime">Usage: startDateTime=&apos;{startDateTime}&apos;</param>
        /// </summary>
        public GetPrinterArchivedPrintJobsWithPrinterIdWithStartDateTimeWithEndDateTimeRequestBuilder GetPrinterArchivedPrintJobsWithPrinterIdWithStartDateTimeWithEndDateTime(DateTimeOffset? endDateTime, string printerId, DateTimeOffset? startDateTime) {
            _ = endDateTime ?? throw new ArgumentNullException(nameof(endDateTime));
            if(string.IsNullOrEmpty(printerId)) throw new ArgumentNullException(nameof(printerId));
            _ = startDateTime ?? throw new ArgumentNullException(nameof(startDateTime));
            return new GetPrinterArchivedPrintJobsWithPrinterIdWithStartDateTimeWithEndDateTimeRequestBuilder(PathParameters, RequestAdapter, endDateTime, printerId, startDateTime);
        }
        /// <summary>
        /// Provides operations to call the getRelyingPartyDetailedSummary method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetRelyingPartyDetailedSummaryWithPeriodRequestBuilder GetRelyingPartyDetailedSummaryWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetRelyingPartyDetailedSummaryWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSharePointActivityFileCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetSharePointActivityFileCountsWithPeriodRequestBuilder GetSharePointActivityFileCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointActivityFileCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSharePointActivityPages method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetSharePointActivityPagesWithPeriodRequestBuilder GetSharePointActivityPagesWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointActivityPagesWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSharePointActivityUserCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetSharePointActivityUserCountsWithPeriodRequestBuilder GetSharePointActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSharePointActivityUserDetail method.
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetSharePointActivityUserDetailWithDateRequestBuilder GetSharePointActivityUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetSharePointActivityUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getSharePointActivityUserDetail method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetSharePointActivityUserDetailWithPeriodRequestBuilder GetSharePointActivityUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointActivityUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSharePointSiteUsageDetail method.
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetSharePointSiteUsageDetailWithDateRequestBuilder GetSharePointSiteUsageDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetSharePointSiteUsageDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getSharePointSiteUsageDetail method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetSharePointSiteUsageDetailWithPeriodRequestBuilder GetSharePointSiteUsageDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointSiteUsageDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSharePointSiteUsageFileCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetSharePointSiteUsageFileCountsWithPeriodRequestBuilder GetSharePointSiteUsageFileCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointSiteUsageFileCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSharePointSiteUsagePages method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetSharePointSiteUsagePagesWithPeriodRequestBuilder GetSharePointSiteUsagePagesWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointSiteUsagePagesWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSharePointSiteUsageSiteCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetSharePointSiteUsageSiteCountsWithPeriodRequestBuilder GetSharePointSiteUsageSiteCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointSiteUsageSiteCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSharePointSiteUsageStorage method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetSharePointSiteUsageStorageWithPeriodRequestBuilder GetSharePointSiteUsageStorageWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSharePointSiteUsageStorageWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessActivityCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetSkypeForBusinessActivityCountsWithPeriodRequestBuilder GetSkypeForBusinessActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessActivityUserCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetSkypeForBusinessActivityUserCountsWithPeriodRequestBuilder GetSkypeForBusinessActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessActivityUserDetail method.
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetSkypeForBusinessActivityUserDetailWithDateRequestBuilder GetSkypeForBusinessActivityUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetSkypeForBusinessActivityUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessActivityUserDetail method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetSkypeForBusinessActivityUserDetailWithPeriodRequestBuilder GetSkypeForBusinessActivityUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessActivityUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessDeviceUsageDistributionUserCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetSkypeForBusinessDeviceUsageDistributionUserCountsWithPeriodRequestBuilder GetSkypeForBusinessDeviceUsageDistributionUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessDeviceUsageDistributionUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessDeviceUsageUserCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetSkypeForBusinessDeviceUsageUserCountsWithPeriodRequestBuilder GetSkypeForBusinessDeviceUsageUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessDeviceUsageUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessDeviceUsageUserDetail method.
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetSkypeForBusinessDeviceUsageUserDetailWithDateRequestBuilder GetSkypeForBusinessDeviceUsageUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetSkypeForBusinessDeviceUsageUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessDeviceUsageUserDetail method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetSkypeForBusinessDeviceUsageUserDetailWithPeriodRequestBuilder GetSkypeForBusinessDeviceUsageUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessDeviceUsageUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessOrganizerActivityCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetSkypeForBusinessOrganizerActivityCountsWithPeriodRequestBuilder GetSkypeForBusinessOrganizerActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessOrganizerActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessOrganizerActivityMinuteCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetSkypeForBusinessOrganizerActivityMinuteCountsWithPeriodRequestBuilder GetSkypeForBusinessOrganizerActivityMinuteCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessOrganizerActivityMinuteCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessOrganizerActivityUserCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetSkypeForBusinessOrganizerActivityUserCountsWithPeriodRequestBuilder GetSkypeForBusinessOrganizerActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessOrganizerActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessParticipantActivityCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetSkypeForBusinessParticipantActivityCountsWithPeriodRequestBuilder GetSkypeForBusinessParticipantActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessParticipantActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessParticipantActivityMinuteCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetSkypeForBusinessParticipantActivityMinuteCountsWithPeriodRequestBuilder GetSkypeForBusinessParticipantActivityMinuteCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessParticipantActivityMinuteCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessParticipantActivityUserCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetSkypeForBusinessParticipantActivityUserCountsWithPeriodRequestBuilder GetSkypeForBusinessParticipantActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessParticipantActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessPeerToPeerActivityCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetSkypeForBusinessPeerToPeerActivityCountsWithPeriodRequestBuilder GetSkypeForBusinessPeerToPeerActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessPeerToPeerActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessPeerToPeerActivityMinuteCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetSkypeForBusinessPeerToPeerActivityMinuteCountsWithPeriodRequestBuilder GetSkypeForBusinessPeerToPeerActivityMinuteCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessPeerToPeerActivityMinuteCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessPeerToPeerActivityUserCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetSkypeForBusinessPeerToPeerActivityUserCountsWithPeriodRequestBuilder GetSkypeForBusinessPeerToPeerActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetSkypeForBusinessPeerToPeerActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getTeamsDeviceUsageDistributionTotalUserCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetTeamsDeviceUsageDistributionTotalUserCountsWithPeriodRequestBuilder GetTeamsDeviceUsageDistributionTotalUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsDeviceUsageDistributionTotalUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getTeamsDeviceUsageDistributionUserCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetTeamsDeviceUsageDistributionUserCountsWithPeriodRequestBuilder GetTeamsDeviceUsageDistributionUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsDeviceUsageDistributionUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getTeamsDeviceUsageTotalUserCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetTeamsDeviceUsageTotalUserCountsWithPeriodRequestBuilder GetTeamsDeviceUsageTotalUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsDeviceUsageTotalUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getTeamsDeviceUsageUserCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetTeamsDeviceUsageUserCountsWithPeriodRequestBuilder GetTeamsDeviceUsageUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsDeviceUsageUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getTeamsDeviceUsageUserDetail method.
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetTeamsDeviceUsageUserDetailWithDateRequestBuilder GetTeamsDeviceUsageUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetTeamsDeviceUsageUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getTeamsDeviceUsageUserDetail method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetTeamsDeviceUsageUserDetailWithPeriodRequestBuilder GetTeamsDeviceUsageUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsDeviceUsageUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getTeamsTeamActivityCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetTeamsTeamActivityCountsWithPeriodRequestBuilder GetTeamsTeamActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsTeamActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getTeamsTeamActivityDetail method.
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetTeamsTeamActivityDetailWithDateRequestBuilder GetTeamsTeamActivityDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetTeamsTeamActivityDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getTeamsTeamActivityDetail method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetTeamsTeamActivityDetailWithPeriodRequestBuilder GetTeamsTeamActivityDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsTeamActivityDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getTeamsTeamActivityDistributionCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetTeamsTeamActivityDistributionCountsWithPeriodRequestBuilder GetTeamsTeamActivityDistributionCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsTeamActivityDistributionCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getTeamsUserActivityCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetTeamsUserActivityCountsWithPeriodRequestBuilder GetTeamsUserActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsUserActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getTeamsUserActivityDistributionTotalUserCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetTeamsUserActivityDistributionTotalUserCountsWithPeriodRequestBuilder GetTeamsUserActivityDistributionTotalUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsUserActivityDistributionTotalUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getTeamsUserActivityDistributionUserCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetTeamsUserActivityDistributionUserCountsWithPeriodRequestBuilder GetTeamsUserActivityDistributionUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsUserActivityDistributionUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getTeamsUserActivityTotalCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetTeamsUserActivityTotalCountsWithPeriodRequestBuilder GetTeamsUserActivityTotalCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsUserActivityTotalCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getTeamsUserActivityTotalDistributionCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetTeamsUserActivityTotalDistributionCountsWithPeriodRequestBuilder GetTeamsUserActivityTotalDistributionCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsUserActivityTotalDistributionCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getTeamsUserActivityTotalUserCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetTeamsUserActivityTotalUserCountsWithPeriodRequestBuilder GetTeamsUserActivityTotalUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsUserActivityTotalUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getTeamsUserActivityUserCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetTeamsUserActivityUserCountsWithPeriodRequestBuilder GetTeamsUserActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsUserActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getTeamsUserActivityUserDetail method.
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetTeamsUserActivityUserDetailWithDateRequestBuilder GetTeamsUserActivityUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetTeamsUserActivityUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getTeamsUserActivityUserDetail method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetTeamsUserActivityUserDetailWithPeriodRequestBuilder GetTeamsUserActivityUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetTeamsUserActivityUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getUserArchivedPrintJobs method.
        /// <param name="endDateTime">Usage: endDateTime=&apos;{endDateTime}&apos;</param>
        /// <param name="startDateTime">Usage: startDateTime=&apos;{startDateTime}&apos;</param>
        /// <param name="userId">Usage: userId=&apos;{userId}&apos;</param>
        /// </summary>
        public GetUserArchivedPrintJobsWithUserIdWithStartDateTimeWithEndDateTimeRequestBuilder GetUserArchivedPrintJobsWithUserIdWithStartDateTimeWithEndDateTime(DateTimeOffset? endDateTime, DateTimeOffset? startDateTime, string userId) {
            _ = endDateTime ?? throw new ArgumentNullException(nameof(endDateTime));
            _ = startDateTime ?? throw new ArgumentNullException(nameof(startDateTime));
            if(string.IsNullOrEmpty(userId)) throw new ArgumentNullException(nameof(userId));
            return new GetUserArchivedPrintJobsWithUserIdWithStartDateTimeWithEndDateTimeRequestBuilder(PathParameters, RequestAdapter, endDateTime, startDateTime, userId);
        }
        /// <summary>
        /// Provides operations to call the getYammerActivityCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetYammerActivityCountsWithPeriodRequestBuilder GetYammerActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getYammerActivityUserCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetYammerActivityUserCountsWithPeriodRequestBuilder GetYammerActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getYammerActivityUserDetail method.
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetYammerActivityUserDetailWithDateRequestBuilder GetYammerActivityUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetYammerActivityUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getYammerActivityUserDetail method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetYammerActivityUserDetailWithPeriodRequestBuilder GetYammerActivityUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerActivityUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getYammerDeviceUsageDistributionUserCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetYammerDeviceUsageDistributionUserCountsWithPeriodRequestBuilder GetYammerDeviceUsageDistributionUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerDeviceUsageDistributionUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getYammerDeviceUsageUserCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetYammerDeviceUsageUserCountsWithPeriodRequestBuilder GetYammerDeviceUsageUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerDeviceUsageUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getYammerDeviceUsageUserDetail method.
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetYammerDeviceUsageUserDetailWithDateRequestBuilder GetYammerDeviceUsageUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetYammerDeviceUsageUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getYammerDeviceUsageUserDetail method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetYammerDeviceUsageUserDetailWithPeriodRequestBuilder GetYammerDeviceUsageUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerDeviceUsageUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getYammerGroupsActivityCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetYammerGroupsActivityCountsWithPeriodRequestBuilder GetYammerGroupsActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerGroupsActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getYammerGroupsActivityDetail method.
        /// <param name="date">Usage: date={date}</param>
        /// </summary>
        public GetYammerGroupsActivityDetailWithDateRequestBuilder GetYammerGroupsActivityDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new GetYammerGroupsActivityDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getYammerGroupsActivityDetail method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetYammerGroupsActivityDetailWithPeriodRequestBuilder GetYammerGroupsActivityDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerGroupsActivityDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getYammerGroupsActivityGroupCounts method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public GetYammerGroupsActivityGroupCountsWithPeriodRequestBuilder GetYammerGroupsActivityGroupCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new GetYammerGroupsActivityGroupCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the managedDeviceEnrollmentAbandonmentDetails method.
        /// <param name="filter">Usage: filter=&apos;{filter}&apos;</param>
        /// <param name="skip">Usage: skip={skip}</param>
        /// <param name="skipToken">Usage: skipToken=&apos;{skipToken}&apos;</param>
        /// <param name="top">Usage: top={top}</param>
        /// </summary>
        public ManagedDeviceEnrollmentAbandonmentDetailsWithSkipWithTopWithFilterWithSkipTokenRequestBuilder ManagedDeviceEnrollmentAbandonmentDetailsWithSkipWithTopWithFilterWithSkipToken(string filter, int? skip, string skipToken, int? top) {
            if(string.IsNullOrEmpty(filter)) throw new ArgumentNullException(nameof(filter));
            _ = skip ?? throw new ArgumentNullException(nameof(skip));
            if(string.IsNullOrEmpty(skipToken)) throw new ArgumentNullException(nameof(skipToken));
            _ = top ?? throw new ArgumentNullException(nameof(top));
            return new ManagedDeviceEnrollmentAbandonmentDetailsWithSkipWithTopWithFilterWithSkipTokenRequestBuilder(PathParameters, RequestAdapter, filter, skip, skipToken, top);
        }
        /// <summary>
        /// Provides operations to call the managedDeviceEnrollmentAbandonmentSummary method.
        /// <param name="filter">Usage: filter=&apos;{filter}&apos;</param>
        /// <param name="skip">Usage: skip={skip}</param>
        /// <param name="skipToken">Usage: skipToken=&apos;{skipToken}&apos;</param>
        /// <param name="top">Usage: top={top}</param>
        /// </summary>
        public ManagedDeviceEnrollmentAbandonmentSummaryWithSkipWithTopWithFilterWithSkipTokenRequestBuilder ManagedDeviceEnrollmentAbandonmentSummaryWithSkipWithTopWithFilterWithSkipToken(string filter, int? skip, string skipToken, int? top) {
            if(string.IsNullOrEmpty(filter)) throw new ArgumentNullException(nameof(filter));
            _ = skip ?? throw new ArgumentNullException(nameof(skip));
            if(string.IsNullOrEmpty(skipToken)) throw new ArgumentNullException(nameof(skipToken));
            _ = top ?? throw new ArgumentNullException(nameof(top));
            return new ManagedDeviceEnrollmentAbandonmentSummaryWithSkipWithTopWithFilterWithSkipTokenRequestBuilder(PathParameters, RequestAdapter, filter, skip, skipToken, top);
        }
        /// <summary>
        /// Provides operations to call the managedDeviceEnrollmentFailureDetails method.
        /// </summary>
        public ManagedDeviceEnrollmentFailureDetailsRequestBuilder ManagedDeviceEnrollmentFailureDetails() {
            return new ManagedDeviceEnrollmentFailureDetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the managedDeviceEnrollmentFailureDetails method.
        /// <param name="filter">Usage: filter=&apos;{filter}&apos;</param>
        /// <param name="skip">Usage: skip={skip}</param>
        /// <param name="skipToken">Usage: skipToken=&apos;{skipToken}&apos;</param>
        /// <param name="top">Usage: top={top}</param>
        /// </summary>
        public ManagedDeviceEnrollmentFailureDetailsWithSkipWithTopWithFilterWithSkipTokenRequestBuilder ManagedDeviceEnrollmentFailureDetailsWithSkipWithTopWithFilterWithSkipToken(string filter, int? skip, string skipToken, int? top) {
            if(string.IsNullOrEmpty(filter)) throw new ArgumentNullException(nameof(filter));
            _ = skip ?? throw new ArgumentNullException(nameof(skip));
            if(string.IsNullOrEmpty(skipToken)) throw new ArgumentNullException(nameof(skipToken));
            _ = top ?? throw new ArgumentNullException(nameof(top));
            return new ManagedDeviceEnrollmentFailureDetailsWithSkipWithTopWithFilterWithSkipTokenRequestBuilder(PathParameters, RequestAdapter, filter, skip, skipToken, top);
        }
        /// <summary>
        /// Provides operations to call the managedDeviceEnrollmentFailureTrends method.
        /// </summary>
        public ManagedDeviceEnrollmentFailureTrendsRequestBuilder ManagedDeviceEnrollmentFailureTrends() {
            return new ManagedDeviceEnrollmentFailureTrendsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the managedDeviceEnrollmentTopFailures method.
        /// </summary>
        public ManagedDeviceEnrollmentTopFailuresRequestBuilder ManagedDeviceEnrollmentTopFailures() {
            return new ManagedDeviceEnrollmentTopFailuresRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the managedDeviceEnrollmentTopFailures method.
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        /// </summary>
        public ManagedDeviceEnrollmentTopFailuresWithPeriodRequestBuilder ManagedDeviceEnrollmentTopFailuresWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new ManagedDeviceEnrollmentTopFailuresWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Update reports
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(ReportRoot body, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, headers, options);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>Get reports</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
