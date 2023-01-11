using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public class ManagementTemplateCollectionTenantSummary : Entity, IParsable {
        /// <summary>The completeStepsCount property</summary>
        public int? CompleteStepsCount {
            get { return BackingStore?.Get<int?>("completeStepsCount"); }
            set { BackingStore?.Set("completeStepsCount", value); }
        }
        /// <summary>The completeUsersCount property</summary>
        public int? CompleteUsersCount {
            get { return BackingStore?.Get<int?>("completeUsersCount"); }
            set { BackingStore?.Set("completeUsersCount", value); }
        }
        /// <summary>The createdByUserId property</summary>
        public string CreatedByUserId {
            get { return BackingStore?.Get<string>("createdByUserId"); }
            set { BackingStore?.Set("createdByUserId", value); }
        }
        /// <summary>The createdDateTime property</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The dismissedStepsCount property</summary>
        public int? DismissedStepsCount {
            get { return BackingStore?.Get<int?>("dismissedStepsCount"); }
            set { BackingStore?.Set("dismissedStepsCount", value); }
        }
        /// <summary>The excludedUsersCount property</summary>
        public int? ExcludedUsersCount {
            get { return BackingStore?.Get<int?>("excludedUsersCount"); }
            set { BackingStore?.Set("excludedUsersCount", value); }
        }
        /// <summary>The excludedUsersDistinctCount property</summary>
        public int? ExcludedUsersDistinctCount {
            get { return BackingStore?.Get<int?>("excludedUsersDistinctCount"); }
            set { BackingStore?.Set("excludedUsersDistinctCount", value); }
        }
        /// <summary>The incompleteStepsCount property</summary>
        public int? IncompleteStepsCount {
            get { return BackingStore?.Get<int?>("incompleteStepsCount"); }
            set { BackingStore?.Set("incompleteStepsCount", value); }
        }
        /// <summary>The incompleteUsersCount property</summary>
        public int? IncompleteUsersCount {
            get { return BackingStore?.Get<int?>("incompleteUsersCount"); }
            set { BackingStore?.Set("incompleteUsersCount", value); }
        }
        /// <summary>The ineligibleStepsCount property</summary>
        public int? IneligibleStepsCount {
            get { return BackingStore?.Get<int?>("ineligibleStepsCount"); }
            set { BackingStore?.Set("ineligibleStepsCount", value); }
        }
        /// <summary>The isComplete property</summary>
        public bool? IsComplete {
            get { return BackingStore?.Get<bool?>("isComplete"); }
            set { BackingStore?.Set("isComplete", value); }
        }
        /// <summary>The lastActionByUserId property</summary>
        public string LastActionByUserId {
            get { return BackingStore?.Get<string>("lastActionByUserId"); }
            set { BackingStore?.Set("lastActionByUserId", value); }
        }
        /// <summary>The lastActionDateTime property</summary>
        public DateTimeOffset? LastActionDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastActionDateTime"); }
            set { BackingStore?.Set("lastActionDateTime", value); }
        }
        /// <summary>The managementTemplateCollectionDisplayName property</summary>
        public string ManagementTemplateCollectionDisplayName {
            get { return BackingStore?.Get<string>("managementTemplateCollectionDisplayName"); }
            set { BackingStore?.Set("managementTemplateCollectionDisplayName", value); }
        }
        /// <summary>The managementTemplateCollectionId property</summary>
        public string ManagementTemplateCollectionId {
            get { return BackingStore?.Get<string>("managementTemplateCollectionId"); }
            set { BackingStore?.Set("managementTemplateCollectionId", value); }
        }
        /// <summary>The tenantId property</summary>
        public string TenantId {
            get { return BackingStore?.Get<string>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ManagementTemplateCollectionTenantSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagementTemplateCollectionTenantSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"completeStepsCount", n => { CompleteStepsCount = n.GetIntValue(); } },
                {"completeUsersCount", n => { CompleteUsersCount = n.GetIntValue(); } },
                {"createdByUserId", n => { CreatedByUserId = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"dismissedStepsCount", n => { DismissedStepsCount = n.GetIntValue(); } },
                {"excludedUsersCount", n => { ExcludedUsersCount = n.GetIntValue(); } },
                {"excludedUsersDistinctCount", n => { ExcludedUsersDistinctCount = n.GetIntValue(); } },
                {"incompleteStepsCount", n => { IncompleteStepsCount = n.GetIntValue(); } },
                {"incompleteUsersCount", n => { IncompleteUsersCount = n.GetIntValue(); } },
                {"ineligibleStepsCount", n => { IneligibleStepsCount = n.GetIntValue(); } },
                {"isComplete", n => { IsComplete = n.GetBoolValue(); } },
                {"lastActionByUserId", n => { LastActionByUserId = n.GetStringValue(); } },
                {"lastActionDateTime", n => { LastActionDateTime = n.GetDateTimeOffsetValue(); } },
                {"managementTemplateCollectionDisplayName", n => { ManagementTemplateCollectionDisplayName = n.GetStringValue(); } },
                {"managementTemplateCollectionId", n => { ManagementTemplateCollectionId = n.GetStringValue(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("completeStepsCount", CompleteStepsCount);
            writer.WriteIntValue("completeUsersCount", CompleteUsersCount);
            writer.WriteStringValue("createdByUserId", CreatedByUserId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteIntValue("dismissedStepsCount", DismissedStepsCount);
            writer.WriteIntValue("excludedUsersCount", ExcludedUsersCount);
            writer.WriteIntValue("excludedUsersDistinctCount", ExcludedUsersDistinctCount);
            writer.WriteIntValue("incompleteStepsCount", IncompleteStepsCount);
            writer.WriteIntValue("incompleteUsersCount", IncompleteUsersCount);
            writer.WriteIntValue("ineligibleStepsCount", IneligibleStepsCount);
            writer.WriteBoolValue("isComplete", IsComplete);
            writer.WriteStringValue("lastActionByUserId", LastActionByUserId);
            writer.WriteDateTimeOffsetValue("lastActionDateTime", LastActionDateTime);
            writer.WriteStringValue("managementTemplateCollectionDisplayName", ManagementTemplateCollectionDisplayName);
            writer.WriteStringValue("managementTemplateCollectionId", ManagementTemplateCollectionId);
            writer.WriteStringValue("tenantId", TenantId);
        }
    }
}
