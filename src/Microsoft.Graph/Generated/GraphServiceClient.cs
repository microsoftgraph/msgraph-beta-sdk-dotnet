using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Serialization.Json;
using MicrosoftGraph.AccessReviewDecisions;
using MicrosoftGraph.AccessReviews;
using MicrosoftGraph.Activitystatistics;
using MicrosoftGraph.Admin;
using MicrosoftGraph.AdministrativeUnits;
using MicrosoftGraph.AgreementAcceptances;
using MicrosoftGraph.Agreements;
using MicrosoftGraph.AllowedDataLocations;
using MicrosoftGraph.App;
using MicrosoftGraph.AppCatalogs;
using MicrosoftGraph.Applications;
using MicrosoftGraph.ApplicationTemplates;
using MicrosoftGraph.AppRoleAssignments;
using MicrosoftGraph.ApprovalWorkflowProviders;
using MicrosoftGraph.AuditLogs;
using MicrosoftGraph.AuthenticationMethodConfigurations;
using MicrosoftGraph.AuthenticationMethodsPolicy;
using MicrosoftGraph.BookingBusinesses;
using MicrosoftGraph.BookingCurrencies;
using MicrosoftGraph.Branding;
using MicrosoftGraph.BusinessFlowTemplates;
using MicrosoftGraph.CertificateBasedAuthConfiguration;
using MicrosoftGraph.Chats;
using MicrosoftGraph.Commands;
using MicrosoftGraph.Communications;
using MicrosoftGraph.Compliance;
using MicrosoftGraph.Connections;
using MicrosoftGraph.Contacts;
using MicrosoftGraph.Contracts;
using MicrosoftGraph.DataClassification;
using MicrosoftGraph.DataPolicyOperations;
using MicrosoftGraph.DeviceAppManagement;
using MicrosoftGraph.DeviceManagement;
using MicrosoftGraph.Devices;
using MicrosoftGraph.Directory;
using MicrosoftGraph.DirectoryObjects;
using MicrosoftGraph.DirectoryRoles;
using MicrosoftGraph.DirectoryRoleTemplates;
using MicrosoftGraph.DirectorySettingTemplates;
using MicrosoftGraph.DomainDnsRecords;
using MicrosoftGraph.Domains;
using MicrosoftGraph.Drive;
using MicrosoftGraph.Drives;
using MicrosoftGraph.Education;
using MicrosoftGraph.External;
using MicrosoftGraph.FilterOperators;
using MicrosoftGraph.Financials;
using MicrosoftGraph.Functions;
using MicrosoftGraph.GovernanceResources;
using MicrosoftGraph.GovernanceRoleAssignmentRequests;
using MicrosoftGraph.GovernanceRoleAssignments;
using MicrosoftGraph.GovernanceRoleDefinitions;
using MicrosoftGraph.GovernanceRoleSettings;
using MicrosoftGraph.GovernanceSubjects;
using MicrosoftGraph.GroupLifecyclePolicies;
using MicrosoftGraph.Groups;
using MicrosoftGraph.Identity;
using MicrosoftGraph.IdentityGovernance;
using MicrosoftGraph.IdentityProtection;
using MicrosoftGraph.IdentityProviders;
using MicrosoftGraph.InformationProtection;
using MicrosoftGraph.Invitations;
using MicrosoftGraph.Me;
using MicrosoftGraph.MessageEvents;
using MicrosoftGraph.MessageRecipients;
using MicrosoftGraph.MessageTraces;
using MicrosoftGraph.MobilityManagementPolicies;
using MicrosoftGraph.Oauth2PermissionGrants;
using MicrosoftGraph.OfficeConfiguration;
using MicrosoftGraph.OnPremisesPublishingProfiles;
using MicrosoftGraph.Organization;
using MicrosoftGraph.PayloadResponse;
using MicrosoftGraph.PermissionGrants;
using MicrosoftGraph.Places;
using MicrosoftGraph.Planner;
using MicrosoftGraph.Policies;
using MicrosoftGraph.Print;
using MicrosoftGraph.Privacy;
using MicrosoftGraph.PrivilegedAccess;
using MicrosoftGraph.PrivilegedApproval;
using MicrosoftGraph.PrivilegedOperationEvents;
using MicrosoftGraph.PrivilegedRoleAssignmentRequests;
using MicrosoftGraph.PrivilegedRoleAssignments;
using MicrosoftGraph.PrivilegedRoles;
using MicrosoftGraph.PrivilegedSignupStatus;
using MicrosoftGraph.ProgramControls;
using MicrosoftGraph.ProgramControlTypes;
using MicrosoftGraph.Programs;
using MicrosoftGraph.Reports;
using MicrosoftGraph.RiskDetections;
using MicrosoftGraph.RiskyUsers;
using MicrosoftGraph.RoleManagement;
using MicrosoftGraph.SchemaExtensions;
using MicrosoftGraph.ScopedRoleMemberships;
using MicrosoftGraph.Search;
using MicrosoftGraph.Security;
using MicrosoftGraph.ServicePrincipals;
using MicrosoftGraph.Settings;
using MicrosoftGraph.Shares;
using MicrosoftGraph.Sites;
using MicrosoftGraph.SubscribedSkus;
using MicrosoftGraph.Subscriptions;
using MicrosoftGraph.Teams;
using MicrosoftGraph.TeamsTemplates;
using MicrosoftGraph.Teamwork;
using MicrosoftGraph.TenantRelationships;
using MicrosoftGraph.TermStore;
using MicrosoftGraph.TrustFramework;
using MicrosoftGraph.Users;
using MicrosoftGraph.Workbooks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MicrosoftGraph {
    /// <summary>The main entry point of the SDK, exposes the configuration and the fluent API.</summary>
    public class GraphServiceClient {
        public AccessReviewDecisionsRequestBuilder AccessReviewDecisions { get =>
            new AccessReviewDecisionsRequestBuilder(PathParameters, RequestAdapter);
        }
        public AccessReviewsRequestBuilder AccessReviews { get =>
            new AccessReviewsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ActivitystatisticsRequestBuilder Activitystatistics { get =>
            new ActivitystatisticsRequestBuilder(PathParameters, RequestAdapter);
        }
        public AdminRequestBuilder Admin { get =>
            new AdminRequestBuilder(PathParameters, RequestAdapter);
        }
        public AdministrativeUnitsRequestBuilder AdministrativeUnits { get =>
            new AdministrativeUnitsRequestBuilder(PathParameters, RequestAdapter);
        }
        public AgreementAcceptancesRequestBuilder AgreementAcceptances { get =>
            new AgreementAcceptancesRequestBuilder(PathParameters, RequestAdapter);
        }
        public AgreementsRequestBuilder Agreements { get =>
            new AgreementsRequestBuilder(PathParameters, RequestAdapter);
        }
        public AllowedDataLocationsRequestBuilder AllowedDataLocations { get =>
            new AllowedDataLocationsRequestBuilder(PathParameters, RequestAdapter);
        }
        public AppRequestBuilder App { get =>
            new AppRequestBuilder(PathParameters, RequestAdapter);
        }
        public AppCatalogsRequestBuilder AppCatalogs { get =>
            new AppCatalogsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ApplicationsRequestBuilder Applications { get =>
            new ApplicationsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ApplicationTemplatesRequestBuilder ApplicationTemplates { get =>
            new ApplicationTemplatesRequestBuilder(PathParameters, RequestAdapter);
        }
        public AppRoleAssignmentsRequestBuilder AppRoleAssignments { get =>
            new AppRoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ApprovalWorkflowProvidersRequestBuilder ApprovalWorkflowProviders { get =>
            new ApprovalWorkflowProvidersRequestBuilder(PathParameters, RequestAdapter);
        }
        public AuditLogsRequestBuilder AuditLogs { get =>
            new AuditLogsRequestBuilder(PathParameters, RequestAdapter);
        }
        public AuthenticationMethodConfigurationsRequestBuilder AuthenticationMethodConfigurations { get =>
            new AuthenticationMethodConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        public AuthenticationMethodsPolicyRequestBuilder AuthenticationMethodsPolicy { get =>
            new AuthenticationMethodsPolicyRequestBuilder(PathParameters, RequestAdapter);
        }
        public BookingBusinessesRequestBuilder BookingBusinesses { get =>
            new BookingBusinessesRequestBuilder(PathParameters, RequestAdapter);
        }
        public BookingCurrenciesRequestBuilder BookingCurrencies { get =>
            new BookingCurrenciesRequestBuilder(PathParameters, RequestAdapter);
        }
        public BrandingRequestBuilder Branding { get =>
            new BrandingRequestBuilder(PathParameters, RequestAdapter);
        }
        public BusinessFlowTemplatesRequestBuilder BusinessFlowTemplates { get =>
            new BusinessFlowTemplatesRequestBuilder(PathParameters, RequestAdapter);
        }
        public CertificateBasedAuthConfigurationRequestBuilder CertificateBasedAuthConfiguration { get =>
            new CertificateBasedAuthConfigurationRequestBuilder(PathParameters, RequestAdapter);
        }
        public ChatsRequestBuilder Chats { get =>
            new ChatsRequestBuilder(PathParameters, RequestAdapter);
        }
        public CommandsRequestBuilder Commands { get =>
            new CommandsRequestBuilder(PathParameters, RequestAdapter);
        }
        public CommunicationsRequestBuilder Communications { get =>
            new CommunicationsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ComplianceRequestBuilder Compliance { get =>
            new ComplianceRequestBuilder(PathParameters, RequestAdapter);
        }
        public ConnectionsRequestBuilder Connections { get =>
            new ConnectionsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ContactsRequestBuilder Contacts { get =>
            new ContactsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ContractsRequestBuilder Contracts { get =>
            new ContractsRequestBuilder(PathParameters, RequestAdapter);
        }
        public DataClassificationRequestBuilder DataClassification { get =>
            new DataClassificationRequestBuilder(PathParameters, RequestAdapter);
        }
        public DataPolicyOperationsRequestBuilder DataPolicyOperations { get =>
            new DataPolicyOperationsRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeviceAppManagementRequestBuilder DeviceAppManagement { get =>
            new DeviceAppManagementRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeviceManagementRequestBuilder DeviceManagement { get =>
            new DeviceManagementRequestBuilder(PathParameters, RequestAdapter);
        }
        public DevicesRequestBuilder Devices { get =>
            new DevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        public DirectoryRequestBuilder Directory { get =>
            new DirectoryRequestBuilder(PathParameters, RequestAdapter);
        }
        public DirectoryObjectsRequestBuilder DirectoryObjects { get =>
            new DirectoryObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        public DirectoryRolesRequestBuilder DirectoryRoles { get =>
            new DirectoryRolesRequestBuilder(PathParameters, RequestAdapter);
        }
        public DirectoryRoleTemplatesRequestBuilder DirectoryRoleTemplates { get =>
            new DirectoryRoleTemplatesRequestBuilder(PathParameters, RequestAdapter);
        }
        public DirectorySettingTemplatesRequestBuilder DirectorySettingTemplates { get =>
            new DirectorySettingTemplatesRequestBuilder(PathParameters, RequestAdapter);
        }
        public DomainDnsRecordsRequestBuilder DomainDnsRecords { get =>
            new DomainDnsRecordsRequestBuilder(PathParameters, RequestAdapter);
        }
        public DomainsRequestBuilder Domains { get =>
            new DomainsRequestBuilder(PathParameters, RequestAdapter);
        }
        public DriveRequestBuilder Drive { get =>
            new DriveRequestBuilder(PathParameters, RequestAdapter);
        }
        public DrivesRequestBuilder Drives { get =>
            new DrivesRequestBuilder(PathParameters, RequestAdapter);
        }
        public EducationRequestBuilder Education { get =>
            new EducationRequestBuilder(PathParameters, RequestAdapter);
        }
        public ExternalRequestBuilder External { get =>
            new ExternalRequestBuilder(PathParameters, RequestAdapter);
        }
        public FilterOperatorsRequestBuilder FilterOperators { get =>
            new FilterOperatorsRequestBuilder(PathParameters, RequestAdapter);
        }
        public FinancialsRequestBuilder Financials { get =>
            new FinancialsRequestBuilder(PathParameters, RequestAdapter);
        }
        public FunctionsRequestBuilder Functions { get =>
            new FunctionsRequestBuilder(PathParameters, RequestAdapter);
        }
        public GovernanceResourcesRequestBuilder GovernanceResources { get =>
            new GovernanceResourcesRequestBuilder(PathParameters, RequestAdapter);
        }
        public GovernanceRoleAssignmentRequestsRequestBuilder GovernanceRoleAssignmentRequests { get =>
            new GovernanceRoleAssignmentRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        public GovernanceRoleAssignmentsRequestBuilder GovernanceRoleAssignments { get =>
            new GovernanceRoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        public GovernanceRoleDefinitionsRequestBuilder GovernanceRoleDefinitions { get =>
            new GovernanceRoleDefinitionsRequestBuilder(PathParameters, RequestAdapter);
        }
        public GovernanceRoleSettingsRequestBuilder GovernanceRoleSettings { get =>
            new GovernanceRoleSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        public GovernanceSubjectsRequestBuilder GovernanceSubjects { get =>
            new GovernanceSubjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        public GroupLifecyclePoliciesRequestBuilder GroupLifecyclePolicies { get =>
            new GroupLifecyclePoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        public GroupsRequestBuilder Groups { get =>
            new GroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        public IdentityRequestBuilder Identity { get =>
            new IdentityRequestBuilder(PathParameters, RequestAdapter);
        }
        public IdentityGovernanceRequestBuilder IdentityGovernance { get =>
            new IdentityGovernanceRequestBuilder(PathParameters, RequestAdapter);
        }
        public IdentityProtectionRequestBuilder IdentityProtection { get =>
            new IdentityProtectionRequestBuilder(PathParameters, RequestAdapter);
        }
        public IdentityProvidersRequestBuilder IdentityProviders { get =>
            new IdentityProvidersRequestBuilder(PathParameters, RequestAdapter);
        }
        public InformationProtectionRequestBuilder InformationProtection { get =>
            new InformationProtectionRequestBuilder(PathParameters, RequestAdapter);
        }
        public InvitationsRequestBuilder Invitations { get =>
            new InvitationsRequestBuilder(PathParameters, RequestAdapter);
        }
        public MeRequestBuilder Me { get =>
            new MeRequestBuilder(PathParameters, RequestAdapter);
        }
        public MessageEventsRequestBuilder MessageEvents { get =>
            new MessageEventsRequestBuilder(PathParameters, RequestAdapter);
        }
        public MessageRecipientsRequestBuilder MessageRecipients { get =>
            new MessageRecipientsRequestBuilder(PathParameters, RequestAdapter);
        }
        public MessageTracesRequestBuilder MessageTraces { get =>
            new MessageTracesRequestBuilder(PathParameters, RequestAdapter);
        }
        public MobilityManagementPoliciesRequestBuilder MobilityManagementPolicies { get =>
            new MobilityManagementPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        public Oauth2PermissionGrantsRequestBuilder Oauth2PermissionGrants { get =>
            new Oauth2PermissionGrantsRequestBuilder(PathParameters, RequestAdapter);
        }
        public OfficeConfigurationRequestBuilder OfficeConfiguration { get =>
            new OfficeConfigurationRequestBuilder(PathParameters, RequestAdapter);
        }
        public OnPremisesPublishingProfilesRequestBuilder OnPremisesPublishingProfiles { get =>
            new OnPremisesPublishingProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        public OrganizationRequestBuilder Organization { get =>
            new OrganizationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        public PayloadResponseRequestBuilder PayloadResponse { get =>
            new PayloadResponseRequestBuilder(PathParameters, RequestAdapter);
        }
        public PermissionGrantsRequestBuilder PermissionGrants { get =>
            new PermissionGrantsRequestBuilder(PathParameters, RequestAdapter);
        }
        public PlacesRequestBuilder Places { get =>
            new PlacesRequestBuilder(PathParameters, RequestAdapter);
        }
        public PlannerRequestBuilder Planner { get =>
            new PlannerRequestBuilder(PathParameters, RequestAdapter);
        }
        public PoliciesRequestBuilder Policies { get =>
            new PoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        public PrintRequestBuilder Print { get =>
            new PrintRequestBuilder(PathParameters, RequestAdapter);
        }
        public PrivacyRequestBuilder Privacy { get =>
            new PrivacyRequestBuilder(PathParameters, RequestAdapter);
        }
        public PrivilegedAccessRequestBuilder PrivilegedAccess { get =>
            new PrivilegedAccessRequestBuilder(PathParameters, RequestAdapter);
        }
        public PrivilegedApprovalRequestBuilder PrivilegedApproval { get =>
            new PrivilegedApprovalRequestBuilder(PathParameters, RequestAdapter);
        }
        public PrivilegedOperationEventsRequestBuilder PrivilegedOperationEvents { get =>
            new PrivilegedOperationEventsRequestBuilder(PathParameters, RequestAdapter);
        }
        public PrivilegedRoleAssignmentRequestsRequestBuilder PrivilegedRoleAssignmentRequests { get =>
            new PrivilegedRoleAssignmentRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        public PrivilegedRoleAssignmentsRequestBuilder PrivilegedRoleAssignments { get =>
            new PrivilegedRoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        public PrivilegedRolesRequestBuilder PrivilegedRoles { get =>
            new PrivilegedRolesRequestBuilder(PathParameters, RequestAdapter);
        }
        public PrivilegedSignupStatusRequestBuilder PrivilegedSignupStatus { get =>
            new PrivilegedSignupStatusRequestBuilder(PathParameters, RequestAdapter);
        }
        public ProgramControlsRequestBuilder ProgramControls { get =>
            new ProgramControlsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ProgramControlTypesRequestBuilder ProgramControlTypes { get =>
            new ProgramControlTypesRequestBuilder(PathParameters, RequestAdapter);
        }
        public ProgramsRequestBuilder Programs { get =>
            new ProgramsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ReportsRequestBuilder Reports { get =>
            new ReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        public RiskDetectionsRequestBuilder RiskDetections { get =>
            new RiskDetectionsRequestBuilder(PathParameters, RequestAdapter);
        }
        public RiskyUsersRequestBuilder RiskyUsers { get =>
            new RiskyUsersRequestBuilder(PathParameters, RequestAdapter);
        }
        public RoleManagementRequestBuilder RoleManagement { get =>
            new RoleManagementRequestBuilder(PathParameters, RequestAdapter);
        }
        public SchemaExtensionsRequestBuilder SchemaExtensions { get =>
            new SchemaExtensionsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ScopedRoleMembershipsRequestBuilder ScopedRoleMemberships { get =>
            new ScopedRoleMembershipsRequestBuilder(PathParameters, RequestAdapter);
        }
        public SearchRequestBuilder Search { get =>
            new SearchRequestBuilder(PathParameters, RequestAdapter);
        }
        public SecurityRequestBuilder Security { get =>
            new SecurityRequestBuilder(PathParameters, RequestAdapter);
        }
        public ServicePrincipalsRequestBuilder ServicePrincipals { get =>
            new ServicePrincipalsRequestBuilder(PathParameters, RequestAdapter);
        }
        public SettingsRequestBuilder Settings { get =>
            new SettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        public SharesRequestBuilder Shares { get =>
            new SharesRequestBuilder(PathParameters, RequestAdapter);
        }
        public SitesRequestBuilder Sites { get =>
            new SitesRequestBuilder(PathParameters, RequestAdapter);
        }
        public SubscribedSkusRequestBuilder SubscribedSkus { get =>
            new SubscribedSkusRequestBuilder(PathParameters, RequestAdapter);
        }
        public SubscriptionsRequestBuilder Subscriptions { get =>
            new SubscriptionsRequestBuilder(PathParameters, RequestAdapter);
        }
        public TeamsRequestBuilder Teams { get =>
            new TeamsRequestBuilder(PathParameters, RequestAdapter);
        }
        public TeamsTemplatesRequestBuilder TeamsTemplates { get =>
            new TeamsTemplatesRequestBuilder(PathParameters, RequestAdapter);
        }
        public TeamworkRequestBuilder Teamwork { get =>
            new TeamworkRequestBuilder(PathParameters, RequestAdapter);
        }
        public TenantRelationshipsRequestBuilder TenantRelationships { get =>
            new TenantRelationshipsRequestBuilder(PathParameters, RequestAdapter);
        }
        public TermStoreRequestBuilder TermStore { get =>
            new TermStoreRequestBuilder(PathParameters, RequestAdapter);
        }
        public TrustFrameworkRequestBuilder TrustFramework { get =>
            new TrustFrameworkRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public UsersRequestBuilder Users { get =>
            new UsersRequestBuilder(PathParameters, RequestAdapter);
        }
        public WorkbooksRequestBuilder Workbooks { get =>
            new WorkbooksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new GraphServiceClient and sets the default values.
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public GraphServiceClient(IRequestAdapter requestAdapter) {
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            PathParameters = new Dictionary<string, object>();
            UrlTemplate = "{+baseurl}";
            RequestAdapter = requestAdapter;
            ApiClientBuilder.RegisterDefaultSerializer<JsonSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<JsonParseNodeFactory>();
            RequestAdapter.BaseUrl = "https://graph.microsoft.com/beta";
        }
        public RequestInformation CreateGetRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        public async Task GetAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, default, cancellationToken);
        }
    }
}
