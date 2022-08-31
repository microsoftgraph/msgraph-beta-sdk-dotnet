using Microsoft.Graph.Beta.AccessReviewDecisions;
using Microsoft.Graph.Beta.AccessReviews;
using Microsoft.Graph.Beta.Activitystatistics;
using Microsoft.Graph.Beta.Admin;
using Microsoft.Graph.Beta.AdministrativeUnits;
using Microsoft.Graph.Beta.AgreementAcceptances;
using Microsoft.Graph.Beta.Agreements;
using Microsoft.Graph.Beta.AllowedDataLocations;
using Microsoft.Graph.Beta.App;
using Microsoft.Graph.Beta.AppCatalogs;
using Microsoft.Graph.Beta.Applications;
using Microsoft.Graph.Beta.ApplicationTemplates;
using Microsoft.Graph.Beta.AppRoleAssignments;
using Microsoft.Graph.Beta.ApprovalWorkflowProviders;
using Microsoft.Graph.Beta.AuditLogs;
using Microsoft.Graph.Beta.AuthenticationMethodConfigurations;
using Microsoft.Graph.Beta.AuthenticationMethodsPolicy;
using Microsoft.Graph.Beta.BookingBusinesses;
using Microsoft.Graph.Beta.BookingCurrencies;
using Microsoft.Graph.Beta.Branding;
using Microsoft.Graph.Beta.BusinessFlowTemplates;
using Microsoft.Graph.Beta.CertificateBasedAuthConfiguration;
using Microsoft.Graph.Beta.Chats;
using Microsoft.Graph.Beta.Commands;
using Microsoft.Graph.Beta.Communications;
using Microsoft.Graph.Beta.Compliance;
using Microsoft.Graph.Beta.Connections;
using Microsoft.Graph.Beta.Contacts;
using Microsoft.Graph.Beta.Contracts;
using Microsoft.Graph.Beta.DataClassification;
using Microsoft.Graph.Beta.DataPolicyOperations;
using Microsoft.Graph.Beta.DeviceAppManagement;
using Microsoft.Graph.Beta.DeviceManagement;
using Microsoft.Graph.Beta.DeviceRegistrationPolicy;
using Microsoft.Graph.Beta.Devices;
using Microsoft.Graph.Beta.DirectoryNamespace;
using Microsoft.Graph.Beta.DirectoryObjects;
using Microsoft.Graph.Beta.DirectoryRoles;
using Microsoft.Graph.Beta.DirectoryRoleTemplates;
using Microsoft.Graph.Beta.DirectorySettingTemplates;
using Microsoft.Graph.Beta.DomainDnsRecords;
using Microsoft.Graph.Beta.Domains;
using Microsoft.Graph.Beta.Drive;
using Microsoft.Graph.Beta.Drives;
using Microsoft.Graph.Beta.Education;
using Microsoft.Graph.Beta.EmployeeExperience;
using Microsoft.Graph.Beta.External;
using Microsoft.Graph.Beta.FilterOperators;
using Microsoft.Graph.Beta.Financials;
using Microsoft.Graph.Beta.Functions;
using Microsoft.Graph.Beta.GovernanceResources;
using Microsoft.Graph.Beta.GovernanceRoleAssignmentRequests;
using Microsoft.Graph.Beta.GovernanceRoleAssignments;
using Microsoft.Graph.Beta.GovernanceRoleDefinitions;
using Microsoft.Graph.Beta.GovernanceRoleSettings;
using Microsoft.Graph.Beta.GovernanceSubjects;
using Microsoft.Graph.Beta.GroupLifecyclePolicies;
using Microsoft.Graph.Beta.Groups;
using Microsoft.Graph.Beta.Identity;
using Microsoft.Graph.Beta.IdentityGovernance;
using Microsoft.Graph.Beta.IdentityProtection;
using Microsoft.Graph.Beta.IdentityProviders;
using Microsoft.Graph.Beta.InformationProtection;
using Microsoft.Graph.Beta.Invitations;
using Microsoft.Graph.Beta.Me;
using Microsoft.Graph.Beta.MessageEvents;
using Microsoft.Graph.Beta.MessageRecipients;
using Microsoft.Graph.Beta.MessageTraces;
using Microsoft.Graph.Beta.MobilityManagementPolicies;
using Microsoft.Graph.Beta.Oauth2PermissionGrants;
using Microsoft.Graph.Beta.OfficeConfiguration;
using Microsoft.Graph.Beta.OnPremisesPublishingProfiles;
using Microsoft.Graph.Beta.Organization;
using Microsoft.Graph.Beta.PayloadResponse;
using Microsoft.Graph.Beta.PermissionGrants;
using Microsoft.Graph.Beta.Places;
using Microsoft.Graph.Beta.Planner;
using Microsoft.Graph.Beta.Policies;
using Microsoft.Graph.Beta.Print;
using Microsoft.Graph.Beta.Privacy;
using Microsoft.Graph.Beta.PrivilegedAccess;
using Microsoft.Graph.Beta.PrivilegedApproval;
using Microsoft.Graph.Beta.PrivilegedOperationEvents;
using Microsoft.Graph.Beta.PrivilegedRoleAssignmentRequests;
using Microsoft.Graph.Beta.PrivilegedRoleAssignments;
using Microsoft.Graph.Beta.PrivilegedRoles;
using Microsoft.Graph.Beta.PrivilegedSignupStatus;
using Microsoft.Graph.Beta.ProgramControls;
using Microsoft.Graph.Beta.ProgramControlTypes;
using Microsoft.Graph.Beta.Programs;
using Microsoft.Graph.Beta.Reports;
using Microsoft.Graph.Beta.RiskDetections;
using Microsoft.Graph.Beta.RiskyUsers;
using Microsoft.Graph.Beta.RoleManagement;
using Microsoft.Graph.Beta.SchemaExtensions;
using Microsoft.Graph.Beta.ScopedRoleMemberships;
using Microsoft.Graph.Beta.Search;
using Microsoft.Graph.Beta.Security;
using Microsoft.Graph.Beta.ServicePrincipals;
using Microsoft.Graph.Beta.Settings;
using Microsoft.Graph.Beta.Shares;
using Microsoft.Graph.Beta.Sites;
using Microsoft.Graph.Beta.Solutions;
using Microsoft.Graph.Beta.Storage;
using Microsoft.Graph.Beta.SubscribedSkus;
using Microsoft.Graph.Beta.Subscriptions;
using Microsoft.Graph.Beta.Teams;
using Microsoft.Graph.Beta.TeamsTemplates;
using Microsoft.Graph.Beta.Teamwork;
using Microsoft.Graph.Beta.TenantRelationships;
using Microsoft.Graph.Beta.TermStore;
using Microsoft.Graph.Beta.ThreatSubmission;
using Microsoft.Graph.Beta.TrustFramework;
using Microsoft.Graph.Beta.Users;
using Microsoft.Graph.Beta.Workbooks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Store;
using Microsoft.Kiota.Serialization.Json;
using Microsoft.Kiota.Serialization.Text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace Microsoft.Graph.Beta {
    /// <summary>The main entry point of the SDK, exposes the configuration and the fluent API.</summary>
    public class BaseGraphServiceClient {
        /// <summary>The accessReviewDecisions property</summary>
        public AccessReviewDecisionsRequestBuilder AccessReviewDecisions { get =>
            new AccessReviewDecisionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The accessReviews property</summary>
        public AccessReviewsRequestBuilder AccessReviews { get =>
            new AccessReviewsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The activitystatistics property</summary>
        public ActivitystatisticsRequestBuilder Activitystatistics { get =>
            new ActivitystatisticsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The admin property</summary>
        public AdminRequestBuilder Admin { get =>
            new AdminRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The administrativeUnits property</summary>
        public AdministrativeUnitsRequestBuilder AdministrativeUnits { get =>
            new AdministrativeUnitsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The agreementAcceptances property</summary>
        public AgreementAcceptancesRequestBuilder AgreementAcceptances { get =>
            new AgreementAcceptancesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The agreements property</summary>
        public AgreementsRequestBuilder Agreements { get =>
            new AgreementsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The allowedDataLocations property</summary>
        public AllowedDataLocationsRequestBuilder AllowedDataLocations { get =>
            new AllowedDataLocationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The app property</summary>
        public AppRequestBuilder App { get =>
            new AppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The appCatalogs property</summary>
        public AppCatalogsRequestBuilder AppCatalogs { get =>
            new AppCatalogsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The applications property</summary>
        public ApplicationsRequestBuilder Applications { get =>
            new ApplicationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The applicationTemplates property</summary>
        public ApplicationTemplatesRequestBuilder ApplicationTemplates { get =>
            new ApplicationTemplatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The appRoleAssignments property</summary>
        public AppRoleAssignmentsRequestBuilder AppRoleAssignments { get =>
            new AppRoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The approvalWorkflowProviders property</summary>
        public ApprovalWorkflowProvidersRequestBuilder ApprovalWorkflowProviders { get =>
            new ApprovalWorkflowProvidersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The auditLogs property</summary>
        public AuditLogsRequestBuilder AuditLogs { get =>
            new AuditLogsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The authenticationMethodConfigurations property</summary>
        public AuthenticationMethodConfigurationsRequestBuilder AuthenticationMethodConfigurations { get =>
            new AuthenticationMethodConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The authenticationMethodsPolicy property</summary>
        public AuthenticationMethodsPolicyRequestBuilder AuthenticationMethodsPolicy { get =>
            new AuthenticationMethodsPolicyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The bookingBusinesses property</summary>
        public BookingBusinessesRequestBuilder BookingBusinesses { get =>
            new BookingBusinessesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The bookingCurrencies property</summary>
        public BookingCurrenciesRequestBuilder BookingCurrencies { get =>
            new BookingCurrenciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The branding property</summary>
        public BrandingRequestBuilder Branding { get =>
            new BrandingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The businessFlowTemplates property</summary>
        public BusinessFlowTemplatesRequestBuilder BusinessFlowTemplates { get =>
            new BusinessFlowTemplatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The certificateBasedAuthConfiguration property</summary>
        public CertificateBasedAuthConfigurationRequestBuilder CertificateBasedAuthConfiguration { get =>
            new CertificateBasedAuthConfigurationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The chats property</summary>
        public ChatsRequestBuilder Chats { get =>
            new ChatsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The commands property</summary>
        public CommandsRequestBuilder Commands { get =>
            new CommandsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The communications property</summary>
        public CommunicationsRequestBuilder Communications { get =>
            new CommunicationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The compliance property</summary>
        public ComplianceRequestBuilder Compliance { get =>
            new ComplianceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The connections property</summary>
        public ConnectionsRequestBuilder Connections { get =>
            new ConnectionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The contacts property</summary>
        public ContactsRequestBuilder Contacts { get =>
            new ContactsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The contracts property</summary>
        public ContractsRequestBuilder Contracts { get =>
            new ContractsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The dataClassification property</summary>
        public DataClassificationRequestBuilder DataClassification { get =>
            new DataClassificationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The dataPolicyOperations property</summary>
        public DataPolicyOperationsRequestBuilder DataPolicyOperations { get =>
            new DataPolicyOperationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deviceAppManagement property</summary>
        public DeviceAppManagementRequestBuilder DeviceAppManagement { get =>
            new DeviceAppManagementRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deviceManagement property</summary>
        public DeviceManagementRequestBuilder DeviceManagement { get =>
            new DeviceManagementRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deviceRegistrationPolicy property</summary>
        public DeviceRegistrationPolicyRequestBuilder DeviceRegistrationPolicy { get =>
            new DeviceRegistrationPolicyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The devices property</summary>
        public DevicesRequestBuilder Devices { get =>
            new DevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The directory property</summary>
        public DirectoryRequestBuilder DirectoryObject { get =>
            new DirectoryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The directoryObjects property</summary>
        public DirectoryObjectsRequestBuilder DirectoryObjects { get =>
            new DirectoryObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The directoryRoles property</summary>
        public DirectoryRolesRequestBuilder DirectoryRoles { get =>
            new DirectoryRolesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The directoryRoleTemplates property</summary>
        public DirectoryRoleTemplatesRequestBuilder DirectoryRoleTemplates { get =>
            new DirectoryRoleTemplatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The directorySettingTemplates property</summary>
        public DirectorySettingTemplatesRequestBuilder DirectorySettingTemplates { get =>
            new DirectorySettingTemplatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The domainDnsRecords property</summary>
        public DomainDnsRecordsRequestBuilder DomainDnsRecords { get =>
            new DomainDnsRecordsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The domains property</summary>
        public DomainsRequestBuilder Domains { get =>
            new DomainsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The drive property</summary>
        public DriveRequestBuilder Drive { get =>
            new DriveRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The drives property</summary>
        public DrivesRequestBuilder Drives { get =>
            new DrivesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The education property</summary>
        public EducationRequestBuilder Education { get =>
            new EducationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The employeeExperience property</summary>
        public EmployeeExperienceRequestBuilder EmployeeExperience { get =>
            new EmployeeExperienceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The external property</summary>
        public ExternalRequestBuilder External { get =>
            new ExternalRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The filterOperators property</summary>
        public FilterOperatorsRequestBuilder FilterOperators { get =>
            new FilterOperatorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The financials property</summary>
        public FinancialsRequestBuilder Financials { get =>
            new FinancialsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The functions property</summary>
        public FunctionsRequestBuilder Functions { get =>
            new FunctionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The governanceResources property</summary>
        public GovernanceResourcesRequestBuilder GovernanceResources { get =>
            new GovernanceResourcesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The governanceRoleAssignmentRequests property</summary>
        public GovernanceRoleAssignmentRequestsRequestBuilder GovernanceRoleAssignmentRequests { get =>
            new GovernanceRoleAssignmentRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The governanceRoleAssignments property</summary>
        public GovernanceRoleAssignmentsRequestBuilder GovernanceRoleAssignments { get =>
            new GovernanceRoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The governanceRoleDefinitions property</summary>
        public GovernanceRoleDefinitionsRequestBuilder GovernanceRoleDefinitions { get =>
            new GovernanceRoleDefinitionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The governanceRoleSettings property</summary>
        public GovernanceRoleSettingsRequestBuilder GovernanceRoleSettings { get =>
            new GovernanceRoleSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The governanceSubjects property</summary>
        public GovernanceSubjectsRequestBuilder GovernanceSubjects { get =>
            new GovernanceSubjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The groupLifecyclePolicies property</summary>
        public GroupLifecyclePoliciesRequestBuilder GroupLifecyclePolicies { get =>
            new GroupLifecyclePoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The groups property</summary>
        public GroupsRequestBuilder Groups { get =>
            new GroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The identity property</summary>
        public IdentityRequestBuilder Identity { get =>
            new IdentityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The identityGovernance property</summary>
        public IdentityGovernanceRequestBuilder IdentityGovernance { get =>
            new IdentityGovernanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The identityProtection property</summary>
        public IdentityProtectionRequestBuilder IdentityProtection { get =>
            new IdentityProtectionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The identityProviders property</summary>
        public IdentityProvidersRequestBuilder IdentityProviders { get =>
            new IdentityProvidersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The informationProtection property</summary>
        public InformationProtectionRequestBuilder InformationProtection { get =>
            new InformationProtectionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The invitations property</summary>
        public InvitationsRequestBuilder Invitations { get =>
            new InvitationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The me property</summary>
        public MeRequestBuilder Me { get =>
            new MeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The messageEvents property</summary>
        public MessageEventsRequestBuilder MessageEvents { get =>
            new MessageEventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The messageRecipients property</summary>
        public MessageRecipientsRequestBuilder MessageRecipients { get =>
            new MessageRecipientsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The messageTraces property</summary>
        public MessageTracesRequestBuilder MessageTraces { get =>
            new MessageTracesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The mobilityManagementPolicies property</summary>
        public MobilityManagementPoliciesRequestBuilder MobilityManagementPolicies { get =>
            new MobilityManagementPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The oauth2PermissionGrants property</summary>
        public Oauth2PermissionGrantsRequestBuilder Oauth2PermissionGrants { get =>
            new Oauth2PermissionGrantsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The officeConfiguration property</summary>
        public OfficeConfigurationRequestBuilder OfficeConfiguration { get =>
            new OfficeConfigurationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The onPremisesPublishingProfiles property</summary>
        public OnPremisesPublishingProfilesRequestBuilder OnPremisesPublishingProfiles { get =>
            new OnPremisesPublishingProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The organization property</summary>
        public OrganizationRequestBuilder Organization { get =>
            new OrganizationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The payloadResponse property</summary>
        public PayloadResponseRequestBuilder PayloadResponse { get =>
            new PayloadResponseRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The permissionGrants property</summary>
        public PermissionGrantsRequestBuilder PermissionGrants { get =>
            new PermissionGrantsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The places property</summary>
        public PlacesRequestBuilder Places { get =>
            new PlacesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The planner property</summary>
        public PlannerRequestBuilder Planner { get =>
            new PlannerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The policies property</summary>
        public PoliciesRequestBuilder Policies { get =>
            new PoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The print property</summary>
        public PrintRequestBuilder Print { get =>
            new PrintRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The privacy property</summary>
        public PrivacyRequestBuilder Privacy { get =>
            new PrivacyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The privilegedAccess property</summary>
        public PrivilegedAccessRequestBuilder PrivilegedAccess { get =>
            new PrivilegedAccessRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The privilegedApproval property</summary>
        public PrivilegedApprovalRequestBuilder PrivilegedApproval { get =>
            new PrivilegedApprovalRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The privilegedOperationEvents property</summary>
        public PrivilegedOperationEventsRequestBuilder PrivilegedOperationEvents { get =>
            new PrivilegedOperationEventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The privilegedRoleAssignmentRequests property</summary>
        public PrivilegedRoleAssignmentRequestsRequestBuilder PrivilegedRoleAssignmentRequests { get =>
            new PrivilegedRoleAssignmentRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The privilegedRoleAssignments property</summary>
        public PrivilegedRoleAssignmentsRequestBuilder PrivilegedRoleAssignments { get =>
            new PrivilegedRoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The privilegedRoles property</summary>
        public PrivilegedRolesRequestBuilder PrivilegedRoles { get =>
            new PrivilegedRolesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The privilegedSignupStatus property</summary>
        public PrivilegedSignupStatusRequestBuilder PrivilegedSignupStatus { get =>
            new PrivilegedSignupStatusRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The programControls property</summary>
        public ProgramControlsRequestBuilder ProgramControls { get =>
            new ProgramControlsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The programControlTypes property</summary>
        public ProgramControlTypesRequestBuilder ProgramControlTypes { get =>
            new ProgramControlTypesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The programs property</summary>
        public ProgramsRequestBuilder Programs { get =>
            new ProgramsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The reports property</summary>
        public ReportsRequestBuilder Reports { get =>
            new ReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>The riskDetections property</summary>
        public RiskDetectionsRequestBuilder RiskDetections { get =>
            new RiskDetectionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The riskyUsers property</summary>
        public RiskyUsersRequestBuilder RiskyUsers { get =>
            new RiskyUsersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The roleManagement property</summary>
        public RoleManagementRequestBuilder RoleManagement { get =>
            new RoleManagementRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The schemaExtensions property</summary>
        public SchemaExtensionsRequestBuilder SchemaExtensions { get =>
            new SchemaExtensionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The scopedRoleMemberships property</summary>
        public ScopedRoleMembershipsRequestBuilder ScopedRoleMemberships { get =>
            new ScopedRoleMembershipsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The search property</summary>
        public SearchRequestBuilder Search { get =>
            new SearchRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The security property</summary>
        public SecurityRequestBuilder Security { get =>
            new SecurityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The servicePrincipals property</summary>
        public ServicePrincipalsRequestBuilder ServicePrincipals { get =>
            new ServicePrincipalsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The settings property</summary>
        public SettingsRequestBuilder Settings { get =>
            new SettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The shares property</summary>
        public SharesRequestBuilder Shares { get =>
            new SharesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The sites property</summary>
        public SitesRequestBuilder Sites { get =>
            new SitesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The solutions property</summary>
        public SolutionsRequestBuilder Solutions { get =>
            new SolutionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The storage property</summary>
        public StorageRequestBuilder Storage { get =>
            new StorageRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The subscribedSkus property</summary>
        public SubscribedSkusRequestBuilder SubscribedSkus { get =>
            new SubscribedSkusRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The subscriptions property</summary>
        public SubscriptionsRequestBuilder Subscriptions { get =>
            new SubscriptionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The teams property</summary>
        public TeamsRequestBuilder Teams { get =>
            new TeamsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The teamsTemplates property</summary>
        public TeamsTemplatesRequestBuilder TeamsTemplates { get =>
            new TeamsTemplatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The teamwork property</summary>
        public TeamworkRequestBuilder Teamwork { get =>
            new TeamworkRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The tenantRelationships property</summary>
        public TenantRelationshipsRequestBuilder TenantRelationships { get =>
            new TenantRelationshipsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The termStore property</summary>
        public TermStoreRequestBuilder TermStore { get =>
            new TermStoreRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The threatSubmission property</summary>
        public ThreatSubmissionRequestBuilder ThreatSubmission { get =>
            new ThreatSubmissionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The trustFramework property</summary>
        public TrustFrameworkRequestBuilder TrustFramework { get =>
            new TrustFrameworkRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>The users property</summary>
        public UsersRequestBuilder Users { get =>
            new UsersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The workbooks property</summary>
        public WorkbooksRequestBuilder Workbooks { get =>
            new WorkbooksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new BaseGraphServiceClient and sets the default values.
        /// <param name="backingStore">The backing store to use for the models.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public BaseGraphServiceClient(IRequestAdapter requestAdapter, IBackingStoreFactory backingStore = default) {
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            PathParameters = new Dictionary<string, object>();
            UrlTemplate = "{+baseurl}";
            RequestAdapter = requestAdapter;
            ApiClientBuilder.RegisterDefaultSerializer<JsonSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<TextSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<JsonParseNodeFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<TextParseNodeFactory>();
            if (string.IsNullOrEmpty(RequestAdapter.BaseUrl)) {
                RequestAdapter.BaseUrl = "https://graph.microsoft.com/beta";
            }
            RequestAdapter.EnableBackingStore(backingStore);
        }
    }
}
