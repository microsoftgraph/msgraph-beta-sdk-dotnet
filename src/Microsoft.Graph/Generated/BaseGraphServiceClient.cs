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
using Microsoft.Graph.Beta.AppRoleAssignments;
using Microsoft.Graph.Beta.ApplicationTemplates;
using Microsoft.Graph.Beta.Applications;
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
using Microsoft.Graph.Beta.Devices;
using Microsoft.Graph.Beta.DirectoryNamespace;
using Microsoft.Graph.Beta.DirectoryObjects;
using Microsoft.Graph.Beta.DirectoryRoleTemplates;
using Microsoft.Graph.Beta.DirectoryRoles;
using Microsoft.Graph.Beta.DirectorySettingTemplates;
using Microsoft.Graph.Beta.DomainDnsRecords;
using Microsoft.Graph.Beta.Domains;
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
using Microsoft.Graph.Beta.Monitoring;
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
using Microsoft.Graph.Beta.ProgramControlTypes;
using Microsoft.Graph.Beta.ProgramControls;
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
using Microsoft.Graph.Beta.TeamTemplateDefinition;
using Microsoft.Graph.Beta.Teams;
using Microsoft.Graph.Beta.TeamsTemplates;
using Microsoft.Graph.Beta.Teamwork;
using Microsoft.Graph.Beta.TenantRelationships;
using Microsoft.Graph.Beta.TermStore;
using Microsoft.Graph.Beta.ThreatSubmission;
using Microsoft.Graph.Beta.TrustFramework;
using Microsoft.Graph.Beta.Users;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Store;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Serialization.Form;
using Microsoft.Kiota.Serialization.Json;
using Microsoft.Kiota.Serialization.Text;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Microsoft.Graph.Beta {
    /// <summary>
    /// The main entry point of the SDK, exposes the configuration and the fluent API.
    /// </summary>
    public class BaseGraphServiceClient : BaseRequestBuilder {
        /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
        public AccessReviewDecisionsRequestBuilder AccessReviewDecisions { get =>
            new AccessReviewDecisionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
        public AccessReviewsRequestBuilder AccessReviews { get =>
            new AccessReviewsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
        public ActivitystatisticsRequestBuilder Activitystatistics { get =>
            new ActivitystatisticsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the admin singleton.</summary>
        public AdminRequestBuilder Admin { get =>
            new AdminRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of administrativeUnit entities.</summary>
        public AdministrativeUnitsRequestBuilder AdministrativeUnits { get =>
            new AdministrativeUnitsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of agreementAcceptance entities.</summary>
        public AgreementAcceptancesRequestBuilder AgreementAcceptances { get =>
            new AgreementAcceptancesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of agreement entities.</summary>
        public AgreementsRequestBuilder Agreements { get =>
            new AgreementsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of allowedDataLocation entities.</summary>
        public AllowedDataLocationsRequestBuilder AllowedDataLocations { get =>
            new AllowedDataLocationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the commsApplication singleton.</summary>
        public AppRequestBuilder App { get =>
            new AppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the appCatalogs singleton.</summary>
        public AppCatalogsRequestBuilder AppCatalogs { get =>
            new AppCatalogsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of application entities.</summary>
        public ApplicationsRequestBuilder Applications { get =>
            new ApplicationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of applicationTemplate entities.</summary>
        public ApplicationTemplatesRequestBuilder ApplicationTemplates { get =>
            new ApplicationTemplatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of appRoleAssignment entities.</summary>
        public AppRoleAssignmentsRequestBuilder AppRoleAssignments { get =>
            new AppRoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of approvalWorkflowProvider entities.</summary>
        public ApprovalWorkflowProvidersRequestBuilder ApprovalWorkflowProviders { get =>
            new ApprovalWorkflowProvidersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the auditLogRoot singleton.</summary>
        public AuditLogsRequestBuilder AuditLogs { get =>
            new AuditLogsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of authenticationMethodConfiguration entities.</summary>
        public AuthenticationMethodConfigurationsRequestBuilder AuthenticationMethodConfigurations { get =>
            new AuthenticationMethodConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the authenticationMethodsPolicy singleton.</summary>
        public AuthenticationMethodsPolicyRequestBuilder AuthenticationMethodsPolicy { get =>
            new AuthenticationMethodsPolicyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of bookingBusiness entities.</summary>
        public BookingBusinessesRequestBuilder BookingBusinesses { get =>
            new BookingBusinessesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of bookingCurrency entities.</summary>
        public BookingCurrenciesRequestBuilder BookingCurrencies { get =>
            new BookingCurrenciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the organizationalBranding singleton.</summary>
        public BrandingRequestBuilder Branding { get =>
            new BrandingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of businessFlowTemplate entities.</summary>
        public BusinessFlowTemplatesRequestBuilder BusinessFlowTemplates { get =>
            new BusinessFlowTemplatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of certificateBasedAuthConfiguration entities.</summary>
        public CertificateBasedAuthConfigurationRequestBuilder CertificateBasedAuthConfiguration { get =>
            new CertificateBasedAuthConfigurationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of chat entities.</summary>
        public ChatsRequestBuilder Chats { get =>
            new ChatsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of command entities.</summary>
        public CommandsRequestBuilder Commands { get =>
            new CommandsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the cloudCommunications singleton.</summary>
        public CommunicationsRequestBuilder Communications { get =>
            new CommunicationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the compliance singleton.</summary>
        public ComplianceRequestBuilder Compliance { get =>
            new ComplianceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of externalConnection entities.</summary>
        public ConnectionsRequestBuilder Connections { get =>
            new ConnectionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of orgContact entities.</summary>
        public ContactsRequestBuilder Contacts { get =>
            new ContactsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of contract entities.</summary>
        public ContractsRequestBuilder Contracts { get =>
            new ContractsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the dataClassificationService singleton.</summary>
        public DataClassificationRequestBuilder DataClassification { get =>
            new DataClassificationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of dataPolicyOperation entities.</summary>
        public DataPolicyOperationsRequestBuilder DataPolicyOperations { get =>
            new DataPolicyOperationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceAppManagement singleton.</summary>
        public DeviceAppManagementRequestBuilder DeviceAppManagement { get =>
            new DeviceAppManagementRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
        public DeviceManagementRequestBuilder DeviceManagement { get =>
            new DeviceManagementRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of device entities.</summary>
        public DevicesRequestBuilder Devices { get =>
            new DevicesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the directory singleton.</summary>
        public DirectoryRequestBuilder Directory { get =>
            new DirectoryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of directoryObject entities.</summary>
        public DirectoryObjectsRequestBuilder DirectoryObjects { get =>
            new DirectoryObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of directoryRole entities.</summary>
        public DirectoryRolesRequestBuilder DirectoryRoles { get =>
            new DirectoryRolesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of directoryRoleTemplate entities.</summary>
        public DirectoryRoleTemplatesRequestBuilder DirectoryRoleTemplates { get =>
            new DirectoryRoleTemplatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of directorySettingTemplate entities.</summary>
        public DirectorySettingTemplatesRequestBuilder DirectorySettingTemplates { get =>
            new DirectorySettingTemplatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of domainDnsRecord entities.</summary>
        public DomainDnsRecordsRequestBuilder DomainDnsRecords { get =>
            new DomainDnsRecordsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of domain entities.</summary>
        public DomainsRequestBuilder Domains { get =>
            new DomainsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of drive entities.</summary>
        public DrivesRequestBuilder Drives { get =>
            new DrivesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the educationRoot singleton.</summary>
        public EducationRequestBuilder Education { get =>
            new EducationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the employeeExperience singleton.</summary>
        public EmployeeExperienceRequestBuilder EmployeeExperience { get =>
            new EmployeeExperienceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the external singleton.</summary>
        public ExternalRequestBuilder External { get =>
            new ExternalRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of filterOperatorSchema entities.</summary>
        public FilterOperatorsRequestBuilder FilterOperators { get =>
            new FilterOperatorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the financials singleton.</summary>
        public FinancialsRequestBuilder Financials { get =>
            new FinancialsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of attributeMappingFunctionSchema entities.</summary>
        public FunctionsRequestBuilder Functions { get =>
            new FunctionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of governanceResource entities.</summary>
        public GovernanceResourcesRequestBuilder GovernanceResources { get =>
            new GovernanceResourcesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of governanceRoleAssignmentRequest entities.</summary>
        public GovernanceRoleAssignmentRequestsRequestBuilder GovernanceRoleAssignmentRequests { get =>
            new GovernanceRoleAssignmentRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of governanceRoleAssignment entities.</summary>
        public GovernanceRoleAssignmentsRequestBuilder GovernanceRoleAssignments { get =>
            new GovernanceRoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of governanceRoleDefinition entities.</summary>
        public GovernanceRoleDefinitionsRequestBuilder GovernanceRoleDefinitions { get =>
            new GovernanceRoleDefinitionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of governanceRoleSetting entities.</summary>
        public GovernanceRoleSettingsRequestBuilder GovernanceRoleSettings { get =>
            new GovernanceRoleSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of governanceSubject entities.</summary>
        public GovernanceSubjectsRequestBuilder GovernanceSubjects { get =>
            new GovernanceSubjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of groupLifecyclePolicy entities.</summary>
        public GroupLifecyclePoliciesRequestBuilder GroupLifecyclePolicies { get =>
            new GroupLifecyclePoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of group entities.</summary>
        public GroupsRequestBuilder Groups { get =>
            new GroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the identityContainer singleton.</summary>
        public IdentityRequestBuilder Identity { get =>
            new IdentityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the identityGovernance singleton.</summary>
        public IdentityGovernanceRequestBuilder IdentityGovernance { get =>
            new IdentityGovernanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the identityProtectionRoot singleton.</summary>
        public IdentityProtectionRequestBuilder IdentityProtection { get =>
            new IdentityProtectionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of identityProvider entities.</summary>
        public IdentityProvidersRequestBuilder IdentityProviders { get =>
            new IdentityProvidersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the informationProtection singleton.</summary>
        public InformationProtectionRequestBuilder InformationProtection { get =>
            new InformationProtectionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of invitation entities.</summary>
        public InvitationsRequestBuilder Invitations { get =>
            new InvitationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the user singleton.</summary>
        public MeRequestBuilder Me { get =>
            new MeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of messageEvent entities.</summary>
        public MessageEventsRequestBuilder MessageEvents { get =>
            new MessageEventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of messageRecipient entities.</summary>
        public MessageRecipientsRequestBuilder MessageRecipients { get =>
            new MessageRecipientsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of messageTrace entities.</summary>
        public MessageTracesRequestBuilder MessageTraces { get =>
            new MessageTracesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of mobilityManagementPolicy entities.</summary>
        public MobilityManagementPoliciesRequestBuilder MobilityManagementPolicies { get =>
            new MobilityManagementPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the monitoring singleton.</summary>
        public MonitoringRequestBuilder Monitoring { get =>
            new MonitoringRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of oAuth2PermissionGrant entities.</summary>
        public Oauth2PermissionGrantsRequestBuilder Oauth2PermissionGrants { get =>
            new Oauth2PermissionGrantsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the officeConfiguration singleton.</summary>
        public OfficeConfigurationRequestBuilder OfficeConfiguration { get =>
            new OfficeConfigurationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of onPremisesPublishingProfile entities.</summary>
        public OnPremisesPublishingProfilesRequestBuilder OnPremisesPublishingProfiles { get =>
            new OnPremisesPublishingProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of organization entities.</summary>
        public OrganizationRequestBuilder Organization { get =>
            new OrganizationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of payloadResponse entities.</summary>
        public PayloadResponseRequestBuilder PayloadResponse { get =>
            new PayloadResponseRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of resourceSpecificPermissionGrant entities.</summary>
        public PermissionGrantsRequestBuilder PermissionGrants { get =>
            new PermissionGrantsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The places property</summary>
        public PlacesRequestBuilder Places { get =>
            new PlacesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the planner singleton.</summary>
        public PlannerRequestBuilder Planner { get =>
            new PlannerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the policyRoot singleton.</summary>
        public PoliciesRequestBuilder Policies { get =>
            new PoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the print singleton.</summary>
        public PrintRequestBuilder Print { get =>
            new PrintRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the privacy singleton.</summary>
        public PrivacyRequestBuilder Privacy { get =>
            new PrivacyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of privilegedAccess entities.</summary>
        public PrivilegedAccessRequestBuilder PrivilegedAccess { get =>
            new PrivilegedAccessRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of privilegedApproval entities.</summary>
        public PrivilegedApprovalRequestBuilder PrivilegedApproval { get =>
            new PrivilegedApprovalRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of privilegedOperationEvent entities.</summary>
        public PrivilegedOperationEventsRequestBuilder PrivilegedOperationEvents { get =>
            new PrivilegedOperationEventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of privilegedRoleAssignmentRequest entities.</summary>
        public PrivilegedRoleAssignmentRequestsRequestBuilder PrivilegedRoleAssignmentRequests { get =>
            new PrivilegedRoleAssignmentRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of privilegedRoleAssignment entities.</summary>
        public PrivilegedRoleAssignmentsRequestBuilder PrivilegedRoleAssignments { get =>
            new PrivilegedRoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of privilegedRole entities.</summary>
        public PrivilegedRolesRequestBuilder PrivilegedRoles { get =>
            new PrivilegedRolesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of privilegedSignupStatus entities.</summary>
        public PrivilegedSignupStatusRequestBuilder PrivilegedSignupStatus { get =>
            new PrivilegedSignupStatusRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of programControl entities.</summary>
        public ProgramControlsRequestBuilder ProgramControls { get =>
            new ProgramControlsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of programControlType entities.</summary>
        public ProgramControlTypesRequestBuilder ProgramControlTypes { get =>
            new ProgramControlTypesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of program entities.</summary>
        public ProgramsRequestBuilder Programs { get =>
            new ProgramsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the reportRoot singleton.</summary>
        public ReportsRequestBuilder Reports { get =>
            new ReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of riskDetection entities.</summary>
        public RiskDetectionsRequestBuilder RiskDetections { get =>
            new RiskDetectionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of riskyUser entities.</summary>
        public RiskyUsersRequestBuilder RiskyUsers { get =>
            new RiskyUsersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the roleManagement singleton.</summary>
        public RoleManagementRequestBuilder RoleManagement { get =>
            new RoleManagementRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of schemaExtension entities.</summary>
        public SchemaExtensionsRequestBuilder SchemaExtensions { get =>
            new SchemaExtensionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of scopedRoleMembership entities.</summary>
        public ScopedRoleMembershipsRequestBuilder ScopedRoleMemberships { get =>
            new ScopedRoleMembershipsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the searchEntity singleton.</summary>
        public SearchRequestBuilder Search { get =>
            new SearchRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the security singleton.</summary>
        public SecurityRequestBuilder Security { get =>
            new SecurityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of servicePrincipal entities.</summary>
        public ServicePrincipalsRequestBuilder ServicePrincipals { get =>
            new ServicePrincipalsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of directorySetting entities.</summary>
        public SettingsRequestBuilder Settings { get =>
            new SettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of sharedDriveItem entities.</summary>
        public SharesRequestBuilder Shares { get =>
            new SharesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of site entities.</summary>
        public SitesRequestBuilder Sites { get =>
            new SitesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the solutionsRoot singleton.</summary>
        public SolutionsRequestBuilder Solutions { get =>
            new SolutionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the storage singleton.</summary>
        public StorageRequestBuilder Storage { get =>
            new StorageRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of subscribedSku entities.</summary>
        public SubscribedSkusRequestBuilder SubscribedSkus { get =>
            new SubscribedSkusRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of subscription entities.</summary>
        public SubscriptionsRequestBuilder Subscriptions { get =>
            new SubscriptionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of team entities.</summary>
        public TeamsRequestBuilder Teams { get =>
            new TeamsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of teamsTemplate entities.</summary>
        public TeamsTemplatesRequestBuilder TeamsTemplates { get =>
            new TeamsTemplatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of teamTemplateDefinition entities.</summary>
        public TeamTemplateDefinitionRequestBuilder TeamTemplateDefinition { get =>
            new TeamTemplateDefinitionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the teamwork singleton.</summary>
        public TeamworkRequestBuilder Teamwork { get =>
            new TeamworkRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the tenantRelationship singleton.</summary>
        public TenantRelationshipsRequestBuilder TenantRelationships { get =>
            new TenantRelationshipsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the store singleton.</summary>
        public TermStoreRequestBuilder TermStore { get =>
            new TermStoreRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the threatSubmissionRoot singleton.</summary>
        public ThreatSubmissionRequestBuilder ThreatSubmission { get =>
            new ThreatSubmissionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the trustFramework singleton.</summary>
        public TrustFrameworkRequestBuilder TrustFramework { get =>
            new TrustFrameworkRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of user entities.</summary>
        public UsersRequestBuilder Users { get =>
            new UsersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new BaseGraphServiceClient and sets the default values.
        /// </summary>
        /// <param name="backingStore">The backing store to use for the models.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BaseGraphServiceClient(IRequestAdapter requestAdapter, IBackingStoreFactory backingStore = default) : base(requestAdapter, "{+baseurl}", new Dictionary<string, object>()) {
            ApiClientBuilder.RegisterDefaultSerializer<JsonSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<TextSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<FormSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<JsonParseNodeFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<TextParseNodeFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<FormParseNodeFactory>();
            if (string.IsNullOrEmpty(RequestAdapter.BaseUrl)) {
                RequestAdapter.BaseUrl = "https://graph.microsoft.com/beta";
            }
            PathParameters.TryAdd("baseurl", RequestAdapter.BaseUrl);
            RequestAdapter.EnableBackingStore(backingStore);
        }
    }
}
