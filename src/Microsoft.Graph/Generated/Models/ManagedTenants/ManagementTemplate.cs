using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    /// <summary>Provides operations to manage the tenantRelationship singleton.</summary>
    public class ManagementTemplate : Entity, IParsable {
        /// <summary>The management category for the management template. Possible values are: custom, devices, identity, unknownFutureValue. Required. Read-only.</summary>
        public ManagementCategory? Category {
            get { return BackingStore?.Get<ManagementCategory?>(nameof(Category)); }
            set { BackingStore?.Set(nameof(Category), value); }
        }
        /// <summary>The createdByUserId property</summary>
        public string CreatedByUserId {
            get { return BackingStore?.Get<string>(nameof(CreatedByUserId)); }
            set { BackingStore?.Set(nameof(CreatedByUserId), value); }
        }
        /// <summary>The createdDateTime property</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>The description for the management template. Optional. Read-only.</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>The display name for the management template. Required. Read-only.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The informationLinks property</summary>
        public List<Microsoft.Graph.Beta.Models.ActionUrl> InformationLinks {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ActionUrl>>(nameof(InformationLinks)); }
            set { BackingStore?.Set(nameof(InformationLinks), value); }
        }
        /// <summary>The lastActionByUserId property</summary>
        public string LastActionByUserId {
            get { return BackingStore?.Get<string>(nameof(LastActionByUserId)); }
            set { BackingStore?.Set(nameof(LastActionByUserId), value); }
        }
        /// <summary>The lastActionDateTime property</summary>
        public DateTimeOffset? LastActionDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastActionDateTime)); }
            set { BackingStore?.Set(nameof(LastActionDateTime), value); }
        }
        /// <summary>The managementTemplateCollections property</summary>
        public List<ManagementTemplateCollection> ManagementTemplateCollections {
            get { return BackingStore?.Get<List<ManagementTemplateCollection>>(nameof(ManagementTemplateCollections)); }
            set { BackingStore?.Set(nameof(ManagementTemplateCollections), value); }
        }
        /// <summary>The managementTemplateSteps property</summary>
        public List<ManagementTemplateStep> ManagementTemplateSteps {
            get { return BackingStore?.Get<List<ManagementTemplateStep>>(nameof(ManagementTemplateSteps)); }
            set { BackingStore?.Set(nameof(ManagementTemplateSteps), value); }
        }
        /// <summary>The collection of parameters used by the management template. Optional. Read-only.</summary>
        public List<TemplateParameter> Parameters {
            get { return BackingStore?.Get<List<TemplateParameter>>(nameof(Parameters)); }
            set { BackingStore?.Set(nameof(Parameters), value); }
        }
        /// <summary>The priority property</summary>
        public int? Priority {
            get { return BackingStore?.Get<int?>(nameof(Priority)); }
            set { BackingStore?.Set(nameof(Priority), value); }
        }
        /// <summary>The provider property</summary>
        public ManagementProvider? Provider {
            get { return BackingStore?.Get<ManagementProvider?>(nameof(Provider)); }
            set { BackingStore?.Set(nameof(Provider), value); }
        }
        /// <summary>The userImpact property</summary>
        public string UserImpact {
            get { return BackingStore?.Get<string>(nameof(UserImpact)); }
            set { BackingStore?.Set(nameof(UserImpact), value); }
        }
        /// <summary>The version property</summary>
        public int? Version {
            get { return BackingStore?.Get<int?>(nameof(Version)); }
            set { BackingStore?.Set(nameof(Version), value); }
        }
        /// <summary>The collection of workload actions associated with the management template. Optional. Read-only.</summary>
        public List<WorkloadAction> WorkloadActions {
            get { return BackingStore?.Get<List<WorkloadAction>>(nameof(WorkloadActions)); }
            set { BackingStore?.Set(nameof(WorkloadActions), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ManagementTemplate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagementTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"category", n => { Category = n.GetEnumValue<ManagementCategory>(); } },
                {"createdByUserId", n => { CreatedByUserId = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"informationLinks", n => { InformationLinks = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ActionUrl>(Microsoft.Graph.Beta.Models.ActionUrl.CreateFromDiscriminatorValue).ToList(); } },
                {"lastActionByUserId", n => { LastActionByUserId = n.GetStringValue(); } },
                {"lastActionDateTime", n => { LastActionDateTime = n.GetDateTimeOffsetValue(); } },
                {"managementTemplateCollections", n => { ManagementTemplateCollections = n.GetCollectionOfObjectValues<ManagementTemplateCollection>(ManagementTemplateCollection.CreateFromDiscriminatorValue).ToList(); } },
                {"managementTemplateSteps", n => { ManagementTemplateSteps = n.GetCollectionOfObjectValues<ManagementTemplateStep>(ManagementTemplateStep.CreateFromDiscriminatorValue).ToList(); } },
                {"parameters", n => { Parameters = n.GetCollectionOfObjectValues<TemplateParameter>(TemplateParameter.CreateFromDiscriminatorValue).ToList(); } },
                {"priority", n => { Priority = n.GetIntValue(); } },
                {"provider", n => { Provider = n.GetEnumValue<ManagementProvider>(); } },
                {"userImpact", n => { UserImpact = n.GetStringValue(); } },
                {"version", n => { Version = n.GetIntValue(); } },
                {"workloadActions", n => { WorkloadActions = n.GetCollectionOfObjectValues<WorkloadAction>(WorkloadAction.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<ManagementCategory>("category", Category);
            writer.WriteStringValue("createdByUserId", CreatedByUserId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ActionUrl>("informationLinks", InformationLinks);
            writer.WriteStringValue("lastActionByUserId", LastActionByUserId);
            writer.WriteDateTimeOffsetValue("lastActionDateTime", LastActionDateTime);
            writer.WriteCollectionOfObjectValues<ManagementTemplateCollection>("managementTemplateCollections", ManagementTemplateCollections);
            writer.WriteCollectionOfObjectValues<ManagementTemplateStep>("managementTemplateSteps", ManagementTemplateSteps);
            writer.WriteCollectionOfObjectValues<TemplateParameter>("parameters", Parameters);
            writer.WriteIntValue("priority", Priority);
            writer.WriteEnumValue<ManagementProvider>("provider", Provider);
            writer.WriteStringValue("userImpact", UserImpact);
            writer.WriteIntValue("version", Version);
            writer.WriteCollectionOfObjectValues<WorkloadAction>("workloadActions", WorkloadActions);
        }
    }
}
