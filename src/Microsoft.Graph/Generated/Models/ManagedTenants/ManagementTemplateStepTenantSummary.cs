using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    /// <summary>
    /// Provides operations to manage the collection of activityStatistics entities.
    /// </summary>
    public class ManagementTemplateStepTenantSummary : Entity, IParsable {
        /// <summary>The assignedTenantsCount property</summary>
        public int? AssignedTenantsCount {
            get { return BackingStore?.Get<int?>("assignedTenantsCount"); }
            set { BackingStore?.Set("assignedTenantsCount", value); }
        }
        /// <summary>The compliantTenantsCount property</summary>
        public int? CompliantTenantsCount {
            get { return BackingStore?.Get<int?>("compliantTenantsCount"); }
            set { BackingStore?.Set("compliantTenantsCount", value); }
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
        /// <summary>The dismissedTenantsCount property</summary>
        public int? DismissedTenantsCount {
            get { return BackingStore?.Get<int?>("dismissedTenantsCount"); }
            set { BackingStore?.Set("dismissedTenantsCount", value); }
        }
        /// <summary>The ineligibleTenantsCount property</summary>
        public int? IneligibleTenantsCount {
            get { return BackingStore?.Get<int?>("ineligibleTenantsCount"); }
            set { BackingStore?.Set("ineligibleTenantsCount", value); }
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
        /// <summary>The managementTemplateDisplayName property</summary>
        public string ManagementTemplateDisplayName {
            get { return BackingStore?.Get<string>("managementTemplateDisplayName"); }
            set { BackingStore?.Set("managementTemplateDisplayName", value); }
        }
        /// <summary>The managementTemplateId property</summary>
        public string ManagementTemplateId {
            get { return BackingStore?.Get<string>("managementTemplateId"); }
            set { BackingStore?.Set("managementTemplateId", value); }
        }
        /// <summary>The managementTemplateStepDisplayName property</summary>
        public string ManagementTemplateStepDisplayName {
            get { return BackingStore?.Get<string>("managementTemplateStepDisplayName"); }
            set { BackingStore?.Set("managementTemplateStepDisplayName", value); }
        }
        /// <summary>The managementTemplateStepId property</summary>
        public string ManagementTemplateStepId {
            get { return BackingStore?.Get<string>("managementTemplateStepId"); }
            set { BackingStore?.Set("managementTemplateStepId", value); }
        }
        /// <summary>The notCompliantTenantsCount property</summary>
        public int? NotCompliantTenantsCount {
            get { return BackingStore?.Get<int?>("notCompliantTenantsCount"); }
            set { BackingStore?.Set("notCompliantTenantsCount", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ManagementTemplateStepTenantSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagementTemplateStepTenantSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignedTenantsCount", n => { AssignedTenantsCount = n.GetIntValue(); } },
                {"compliantTenantsCount", n => { CompliantTenantsCount = n.GetIntValue(); } },
                {"createdByUserId", n => { CreatedByUserId = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"dismissedTenantsCount", n => { DismissedTenantsCount = n.GetIntValue(); } },
                {"ineligibleTenantsCount", n => { IneligibleTenantsCount = n.GetIntValue(); } },
                {"lastActionByUserId", n => { LastActionByUserId = n.GetStringValue(); } },
                {"lastActionDateTime", n => { LastActionDateTime = n.GetDateTimeOffsetValue(); } },
                {"managementTemplateCollectionDisplayName", n => { ManagementTemplateCollectionDisplayName = n.GetStringValue(); } },
                {"managementTemplateCollectionId", n => { ManagementTemplateCollectionId = n.GetStringValue(); } },
                {"managementTemplateDisplayName", n => { ManagementTemplateDisplayName = n.GetStringValue(); } },
                {"managementTemplateId", n => { ManagementTemplateId = n.GetStringValue(); } },
                {"managementTemplateStepDisplayName", n => { ManagementTemplateStepDisplayName = n.GetStringValue(); } },
                {"managementTemplateStepId", n => { ManagementTemplateStepId = n.GetStringValue(); } },
                {"notCompliantTenantsCount", n => { NotCompliantTenantsCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("assignedTenantsCount", AssignedTenantsCount);
            writer.WriteIntValue("compliantTenantsCount", CompliantTenantsCount);
            writer.WriteStringValue("createdByUserId", CreatedByUserId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteIntValue("dismissedTenantsCount", DismissedTenantsCount);
            writer.WriteIntValue("ineligibleTenantsCount", IneligibleTenantsCount);
            writer.WriteStringValue("lastActionByUserId", LastActionByUserId);
            writer.WriteDateTimeOffsetValue("lastActionDateTime", LastActionDateTime);
            writer.WriteStringValue("managementTemplateCollectionDisplayName", ManagementTemplateCollectionDisplayName);
            writer.WriteStringValue("managementTemplateCollectionId", ManagementTemplateCollectionId);
            writer.WriteStringValue("managementTemplateDisplayName", ManagementTemplateDisplayName);
            writer.WriteStringValue("managementTemplateId", ManagementTemplateId);
            writer.WriteStringValue("managementTemplateStepDisplayName", ManagementTemplateStepDisplayName);
            writer.WriteStringValue("managementTemplateStepId", ManagementTemplateStepId);
            writer.WriteIntValue("notCompliantTenantsCount", NotCompliantTenantsCount);
        }
    }
}
