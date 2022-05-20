using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    /// <summary>Provides operations to manage the tenantRelationship singleton.</summary>
    public class ManagementTemplateStepDeployment : Entity, IParsable {
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
        /// <summary>The error property</summary>
        public GraphAPIErrorDetails Error {
            get { return BackingStore?.Get<GraphAPIErrorDetails>(nameof(Error)); }
            set { BackingStore?.Set(nameof(Error), value); }
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
        /// <summary>The status property</summary>
        public ManagementTemplateDeploymentStatus? Status {
            get { return BackingStore?.Get<ManagementTemplateDeploymentStatus?>(nameof(Status)); }
            set { BackingStore?.Set(nameof(Status), value); }
        }
        /// <summary>The templateStepVersion property</summary>
        public ManagementTemplateStepVersion TemplateStepVersion {
            get { return BackingStore?.Get<ManagementTemplateStepVersion>(nameof(TemplateStepVersion)); }
            set { BackingStore?.Set(nameof(TemplateStepVersion), value); }
        }
        /// <summary>The tenantId property</summary>
        public string TenantId {
            get { return BackingStore?.Get<string>(nameof(TenantId)); }
            set { BackingStore?.Set(nameof(TenantId), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ManagementTemplateStepDeployment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagementTemplateStepDeployment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdByUserId", n => { CreatedByUserId = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"error", n => { Error = n.GetObjectValue<GraphAPIErrorDetails>(GraphAPIErrorDetails.CreateFromDiscriminatorValue); } },
                {"lastActionByUserId", n => { LastActionByUserId = n.GetStringValue(); } },
                {"lastActionDateTime", n => { LastActionDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", n => { Status = n.GetEnumValue<ManagementTemplateDeploymentStatus>(); } },
                {"templateStepVersion", n => { TemplateStepVersion = n.GetObjectValue<ManagementTemplateStepVersion>(ManagementTemplateStepVersion.CreateFromDiscriminatorValue); } },
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
            writer.WriteStringValue("createdByUserId", CreatedByUserId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<GraphAPIErrorDetails>("error", Error);
            writer.WriteStringValue("lastActionByUserId", LastActionByUserId);
            writer.WriteDateTimeOffsetValue("lastActionDateTime", LastActionDateTime);
            writer.WriteEnumValue<ManagementTemplateDeploymentStatus>("status", Status);
            writer.WriteObjectValue<ManagementTemplateStepVersion>("templateStepVersion", TemplateStepVersion);
            writer.WriteStringValue("tenantId", TenantId);
        }
    }
}
