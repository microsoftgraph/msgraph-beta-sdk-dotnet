using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedTenants {
    public class TenantStatusInformation : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The status of the delegated admin privilege relationship between the managing entity and the managed tenant. Possible values are: none, delegatedAdminPrivileges, unknownFutureValue. Optional. Read-only.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedTenants.DelegatedPrivilegeStatus? DelegatedPrivilegeStatus { get; set; }
        /// <summary>The date and time the delegated admin privileges status was updated. Optional. Read-only.</summary>
        public DateTimeOffset? LastDelegatedPrivilegeRefreshDateTime { get; set; }
        /// <summary>The identifier for the account that offboarded the managed tenant. Optional. Read-only.</summary>
        public string OffboardedByUserId { get; set; }
        /// <summary>The date and time when the managed tenant was offboarded. Optional. Read-only.</summary>
        public DateTimeOffset? OffboardedDateTime { get; set; }
        /// <summary>The identifier for the account that onboarded the managed tenant. Optional. Read-only.</summary>
        public string OnboardedByUserId { get; set; }
        /// <summary>The date and time when the managed tenant was onboarded. Optional. Read-only.</summary>
        public DateTimeOffset? OnboardedDateTime { get; set; }
        /// <summary>The onboarding status for the managed tenant.. Possible values are: ineligible, inProcess, active, inactive, unknownFutureValue. Optional. Read-only.</summary>
        public TenantOnboardingStatus? OnboardingStatus { get; set; }
        /// <summary>Organization&apos;s onboarding eligibility reason in Microsoft 365 Lighthouse.. Possible values are: none, contractType, delegatedAdminPrivileges,usersCount,license and unknownFutureValue. Optional. Read-only.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedTenants.TenantOnboardingEligibilityReason? TenantOnboardingEligibilityReason { get; set; }
        /// <summary>The collection of workload statues for the managed tenant. Optional. Read-only.</summary>
        public List<WorkloadStatus> WorkloadStatuses { get; set; }
        /// <summary>
        /// Instantiates a new tenantStatusInformation and sets the default values.
        /// </summary>
        public TenantStatusInformation() {
            AdditionalData = new Dictionary<string, object>();
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
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"delegatedPrivilegeStatus", (o,n) => { (o as TenantStatusInformation).DelegatedPrivilegeStatus = n.GetEnumValue<DelegatedPrivilegeStatus>(); } },
                {"lastDelegatedPrivilegeRefreshDateTime", (o,n) => { (o as TenantStatusInformation).LastDelegatedPrivilegeRefreshDateTime = n.GetDateTimeOffsetValue(); } },
                {"offboardedByUserId", (o,n) => { (o as TenantStatusInformation).OffboardedByUserId = n.GetStringValue(); } },
                {"offboardedDateTime", (o,n) => { (o as TenantStatusInformation).OffboardedDateTime = n.GetDateTimeOffsetValue(); } },
                {"onboardedByUserId", (o,n) => { (o as TenantStatusInformation).OnboardedByUserId = n.GetStringValue(); } },
                {"onboardedDateTime", (o,n) => { (o as TenantStatusInformation).OnboardedDateTime = n.GetDateTimeOffsetValue(); } },
                {"onboardingStatus", (o,n) => { (o as TenantStatusInformation).OnboardingStatus = n.GetEnumValue<TenantOnboardingStatus>(); } },
                {"tenantOnboardingEligibilityReason", (o,n) => { (o as TenantStatusInformation).TenantOnboardingEligibilityReason = n.GetEnumValue<TenantOnboardingEligibilityReason>(); } },
                {"workloadStatuses", (o,n) => { (o as TenantStatusInformation).WorkloadStatuses = n.GetCollectionOfObjectValues<WorkloadStatus>(WorkloadStatus.CreateFromDiscriminatorValue).ToList(); } },
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
