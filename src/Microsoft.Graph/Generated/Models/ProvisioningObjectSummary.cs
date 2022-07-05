using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class ProvisioningObjectSummary : Entity, IParsable {
        /// <summary>The action property</summary>
        public string Action {
            get { return BackingStore?.Get<string>(nameof(Action)); }
            set { BackingStore?.Set(nameof(Action), value); }
        }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ActivityDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ActivityDateTime)); }
            set { BackingStore?.Set(nameof(ActivityDateTime), value); }
        }
        /// <summary>Unique ID of this change in this cycle.</summary>
        public string ChangeId {
            get { return BackingStore?.Get<string>(nameof(ChangeId)); }
            set { BackingStore?.Set(nameof(ChangeId), value); }
        }
        /// <summary>Unique ID per job iteration.</summary>
        public string CycleId {
            get { return BackingStore?.Get<string>(nameof(CycleId)); }
            set { BackingStore?.Set(nameof(CycleId), value); }
        }
        /// <summary>Indicates how long this provisioning action took to finish. Measured in milliseconds.</summary>
        public int? DurationInMilliseconds {
            get { return BackingStore?.Get<int?>(nameof(DurationInMilliseconds)); }
            set { BackingStore?.Set(nameof(DurationInMilliseconds), value); }
        }
        /// <summary>Details of who initiated this provisioning.</summary>
        public Initiator InitiatedBy {
            get { return BackingStore?.Get<Initiator>(nameof(InitiatedBy)); }
            set { BackingStore?.Set(nameof(InitiatedBy), value); }
        }
        /// <summary>The unique ID for the whole provisioning job.</summary>
        public string JobId {
            get { return BackingStore?.Get<string>(nameof(JobId)); }
            set { BackingStore?.Set(nameof(JobId), value); }
        }
        /// <summary>Details of each property that was modified in this provisioning action on this object.</summary>
        public List<ModifiedProperty> ModifiedProperties {
            get { return BackingStore?.Get<List<ModifiedProperty>>(nameof(ModifiedProperties)); }
            set { BackingStore?.Set(nameof(ModifiedProperties), value); }
        }
        /// <summary>Indicates the activity name or the operation name. Possible values are: create, update, delete, stageddelete, disable, other and unknownFutureValue. For a list of activities logged, refer to Azure AD activity list.</summary>
        public Microsoft.Graph.Beta.Models.ProvisioningAction? ProvisioningAction {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ProvisioningAction?>(nameof(ProvisioningAction)); }
            set { BackingStore?.Set(nameof(ProvisioningAction), value); }
        }
        /// <summary>Details of provisioning status.</summary>
        public Microsoft.Graph.Beta.Models.ProvisioningStatusInfo ProvisioningStatusInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ProvisioningStatusInfo>(nameof(ProvisioningStatusInfo)); }
            set { BackingStore?.Set(nameof(ProvisioningStatusInfo), value); }
        }
        /// <summary>Details of each step in provisioning.</summary>
        public List<ProvisioningStep> ProvisioningSteps {
            get { return BackingStore?.Get<List<ProvisioningStep>>(nameof(ProvisioningSteps)); }
            set { BackingStore?.Set(nameof(ProvisioningSteps), value); }
        }
        /// <summary>Represents the service principal used for provisioning.</summary>
        public ProvisioningServicePrincipal ServicePrincipal {
            get { return BackingStore?.Get<ProvisioningServicePrincipal>(nameof(ServicePrincipal)); }
            set { BackingStore?.Set(nameof(ServicePrincipal), value); }
        }
        /// <summary>Details of source object being provisioned.</summary>
        public ProvisionedIdentity SourceIdentity {
            get { return BackingStore?.Get<ProvisionedIdentity>(nameof(SourceIdentity)); }
            set { BackingStore?.Set(nameof(SourceIdentity), value); }
        }
        /// <summary>Details of source system of the object being provisioned.</summary>
        public ProvisioningSystem SourceSystem {
            get { return BackingStore?.Get<ProvisioningSystem>(nameof(SourceSystem)); }
            set { BackingStore?.Set(nameof(SourceSystem), value); }
        }
        /// <summary>The statusInfo property</summary>
        public StatusBase StatusInfo {
            get { return BackingStore?.Get<StatusBase>(nameof(StatusInfo)); }
            set { BackingStore?.Set(nameof(StatusInfo), value); }
        }
        /// <summary>Details of target object being provisioned.</summary>
        public ProvisionedIdentity TargetIdentity {
            get { return BackingStore?.Get<ProvisionedIdentity>(nameof(TargetIdentity)); }
            set { BackingStore?.Set(nameof(TargetIdentity), value); }
        }
        /// <summary>Details of target system of the object being provisioned.</summary>
        public ProvisioningSystem TargetSystem {
            get { return BackingStore?.Get<ProvisioningSystem>(nameof(TargetSystem)); }
            set { BackingStore?.Set(nameof(TargetSystem), value); }
        }
        /// <summary>Unique Azure AD tenant ID.</summary>
        public string TenantId {
            get { return BackingStore?.Get<string>(nameof(TenantId)); }
            set { BackingStore?.Set(nameof(TenantId), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ProvisioningObjectSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ProvisioningObjectSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"action", n => { Action = n.GetStringValue(); } },
                {"activityDateTime", n => { ActivityDateTime = n.GetDateTimeOffsetValue(); } },
                {"changeId", n => { ChangeId = n.GetStringValue(); } },
                {"cycleId", n => { CycleId = n.GetStringValue(); } },
                {"durationInMilliseconds", n => { DurationInMilliseconds = n.GetIntValue(); } },
                {"initiatedBy", n => { InitiatedBy = n.GetObjectValue<Initiator>(Initiator.CreateFromDiscriminatorValue); } },
                {"jobId", n => { JobId = n.GetStringValue(); } },
                {"modifiedProperties", n => { ModifiedProperties = n.GetCollectionOfObjectValues<ModifiedProperty>(ModifiedProperty.CreateFromDiscriminatorValue).ToList(); } },
                {"provisioningAction", n => { ProvisioningAction = n.GetEnumValue<ProvisioningAction>(); } },
                {"provisioningStatusInfo", n => { ProvisioningStatusInfo = n.GetObjectValue<Microsoft.Graph.Beta.Models.ProvisioningStatusInfo>(Microsoft.Graph.Beta.Models.ProvisioningStatusInfo.CreateFromDiscriminatorValue); } },
                {"provisioningSteps", n => { ProvisioningSteps = n.GetCollectionOfObjectValues<ProvisioningStep>(ProvisioningStep.CreateFromDiscriminatorValue).ToList(); } },
                {"servicePrincipal", n => { ServicePrincipal = n.GetObjectValue<ProvisioningServicePrincipal>(ProvisioningServicePrincipal.CreateFromDiscriminatorValue); } },
                {"sourceIdentity", n => { SourceIdentity = n.GetObjectValue<ProvisionedIdentity>(ProvisionedIdentity.CreateFromDiscriminatorValue); } },
                {"sourceSystem", n => { SourceSystem = n.GetObjectValue<ProvisioningSystem>(ProvisioningSystem.CreateFromDiscriminatorValue); } },
                {"statusInfo", n => { StatusInfo = n.GetObjectValue<StatusBase>(StatusBase.CreateFromDiscriminatorValue); } },
                {"targetIdentity", n => { TargetIdentity = n.GetObjectValue<ProvisionedIdentity>(ProvisionedIdentity.CreateFromDiscriminatorValue); } },
                {"targetSystem", n => { TargetSystem = n.GetObjectValue<ProvisioningSystem>(ProvisioningSystem.CreateFromDiscriminatorValue); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("action", Action);
            writer.WriteDateTimeOffsetValue("activityDateTime", ActivityDateTime);
            writer.WriteStringValue("changeId", ChangeId);
            writer.WriteStringValue("cycleId", CycleId);
            writer.WriteIntValue("durationInMilliseconds", DurationInMilliseconds);
            writer.WriteObjectValue<Initiator>("initiatedBy", InitiatedBy);
            writer.WriteStringValue("jobId", JobId);
            writer.WriteCollectionOfObjectValues<ModifiedProperty>("modifiedProperties", ModifiedProperties);
            writer.WriteEnumValue<ProvisioningAction>("provisioningAction", ProvisioningAction);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ProvisioningStatusInfo>("provisioningStatusInfo", ProvisioningStatusInfo);
            writer.WriteCollectionOfObjectValues<ProvisioningStep>("provisioningSteps", ProvisioningSteps);
            writer.WriteObjectValue<ProvisioningServicePrincipal>("servicePrincipal", ServicePrincipal);
            writer.WriteObjectValue<ProvisionedIdentity>("sourceIdentity", SourceIdentity);
            writer.WriteObjectValue<ProvisioningSystem>("sourceSystem", SourceSystem);
            writer.WriteObjectValue<StatusBase>("statusInfo", StatusInfo);
            writer.WriteObjectValue<ProvisionedIdentity>("targetIdentity", TargetIdentity);
            writer.WriteObjectValue<ProvisioningSystem>("targetSystem", TargetSystem);
            writer.WriteStringValue("tenantId", TenantId);
        }
    }
}
