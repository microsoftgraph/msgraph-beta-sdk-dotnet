using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public class TenantStatusInformation : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The status of the delegated admin privilege relationship between the managing entity and the managed tenant. Possible values are: none, delegatedAdminPrivileges, unknownFutureValue, granularDelegatedAdminPrivileges, delegatedAndGranularDelegetedAdminPrivileges. Note that you must use the Prefer: include-unknown-enum-members request header to get the following values from this evolvable enum: granularDelegatedAdminPrivileges , delegatedAndGranularDelegetedAdminPrivileges. Optional. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.ManagedTenants.DelegatedPrivilegeStatus? DelegatedPrivilegeStatus {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ManagedTenants.DelegatedPrivilegeStatus?>("delegatedPrivilegeStatus"); }
            set { BackingStore?.Set("delegatedPrivilegeStatus", value); }
        }
        /// <summary>The date and time the delegated admin privileges status was updated. Optional. Read-only.</summary>
        public DateTimeOffset? LastDelegatedPrivilegeRefreshDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastDelegatedPrivilegeRefreshDateTime"); }
            set { BackingStore?.Set("lastDelegatedPrivilegeRefreshDateTime", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The identifier for the account that offboarded the managed tenant. Optional. Read-only.</summary>
        public string OffboardedByUserId {
            get { return BackingStore?.Get<string>("offboardedByUserId"); }
            set { BackingStore?.Set("offboardedByUserId", value); }
        }
        /// <summary>The date and time when the managed tenant was offboarded. Optional. Read-only.</summary>
        public DateTimeOffset? OffboardedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("offboardedDateTime"); }
            set { BackingStore?.Set("offboardedDateTime", value); }
        }
        /// <summary>The identifier for the account that onboarded the managed tenant. Optional. Read-only.</summary>
        public string OnboardedByUserId {
            get { return BackingStore?.Get<string>("onboardedByUserId"); }
            set { BackingStore?.Set("onboardedByUserId", value); }
        }
        /// <summary>The date and time when the managed tenant was onboarded. Optional. Read-only.</summary>
        public DateTimeOffset? OnboardedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("onboardedDateTime"); }
            set { BackingStore?.Set("onboardedDateTime", value); }
        }
        /// <summary>The onboarding status for the managed tenant.. Possible values are: ineligible, inProcess, active, inactive, unknownFutureValue. Optional. Read-only.</summary>
        public TenantOnboardingStatus? OnboardingStatus {
            get { return BackingStore?.Get<TenantOnboardingStatus?>("onboardingStatus"); }
            set { BackingStore?.Set("onboardingStatus", value); }
        }
        /// <summary>Organization&apos;s onboarding eligibility reason in Microsoft 365 Lighthouse.. Possible values are: none, contractType, delegatedAdminPrivileges,usersCount,license and unknownFutureValue. Optional. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.ManagedTenants.TenantOnboardingEligibilityReason? TenantOnboardingEligibilityReason {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ManagedTenants.TenantOnboardingEligibilityReason?>("tenantOnboardingEligibilityReason"); }
            set { BackingStore?.Set("tenantOnboardingEligibilityReason", value); }
        }
        /// <summary>The collection of workload statues for the managed tenant. Optional. Read-only.</summary>
        public List<WorkloadStatus> WorkloadStatuses {
            get { return BackingStore?.Get<List<WorkloadStatus>>("workloadStatuses"); }
            set { BackingStore?.Set("workloadStatuses", value); }
        }
        /// <summary>
        /// Instantiates a new tenantStatusInformation and sets the default values.
        /// </summary>
        public TenantStatusInformation() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.managedTenants.tenantStatusInformation";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TenantStatusInformation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TenantStatusInformation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"delegatedPrivilegeStatus", n => { DelegatedPrivilegeStatus = n.GetEnumValue<DelegatedPrivilegeStatus>(); } },
                {"lastDelegatedPrivilegeRefreshDateTime", n => { LastDelegatedPrivilegeRefreshDateTime = n.GetDateTimeOffsetValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"offboardedByUserId", n => { OffboardedByUserId = n.GetStringValue(); } },
                {"offboardedDateTime", n => { OffboardedDateTime = n.GetDateTimeOffsetValue(); } },
                {"onboardedByUserId", n => { OnboardedByUserId = n.GetStringValue(); } },
                {"onboardedDateTime", n => { OnboardedDateTime = n.GetDateTimeOffsetValue(); } },
                {"onboardingStatus", n => { OnboardingStatus = n.GetEnumValue<TenantOnboardingStatus>(); } },
                {"tenantOnboardingEligibilityReason", n => { TenantOnboardingEligibilityReason = n.GetEnumValue<TenantOnboardingEligibilityReason>(); } },
                {"workloadStatuses", n => { WorkloadStatuses = n.GetCollectionOfObjectValues<WorkloadStatus>(WorkloadStatus.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<DelegatedPrivilegeStatus>("delegatedPrivilegeStatus", DelegatedPrivilegeStatus);
            writer.WriteDateTimeOffsetValue("lastDelegatedPrivilegeRefreshDateTime", LastDelegatedPrivilegeRefreshDateTime);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("offboardedByUserId", OffboardedByUserId);
            writer.WriteDateTimeOffsetValue("offboardedDateTime", OffboardedDateTime);
            writer.WriteStringValue("onboardedByUserId", OnboardedByUserId);
            writer.WriteDateTimeOffsetValue("onboardedDateTime", OnboardedDateTime);
            writer.WriteEnumValue<TenantOnboardingStatus>("onboardingStatus", OnboardingStatus);
            writer.WriteEnumValue<TenantOnboardingEligibilityReason>("tenantOnboardingEligibilityReason", TenantOnboardingEligibilityReason);
            writer.WriteCollectionOfObjectValues<WorkloadStatus>("workloadStatuses", WorkloadStatuses);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
