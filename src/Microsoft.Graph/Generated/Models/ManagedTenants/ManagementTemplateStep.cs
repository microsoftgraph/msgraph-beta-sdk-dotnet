using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public class ManagementTemplateStep : Entity, IParsable {
        /// <summary>The acceptedVersion property</summary>
        public ManagementTemplateStepVersion AcceptedVersion { get; set; }
        /// <summary>The category property</summary>
        public ManagementCategory? Category { get; set; }
        /// <summary>The createdByUserId property</summary>
        public string CreatedByUserId { get; set; }
        /// <summary>The createdDateTime property</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The description property</summary>
        public string Description { get; set; }
        /// <summary>The displayName property</summary>
        public string DisplayName { get; set; }
        /// <summary>The lastActionByUserId property</summary>
        public string LastActionByUserId { get; set; }
        /// <summary>The lastActionDateTime property</summary>
        public DateTimeOffset? LastActionDateTime { get; set; }
        /// <summary>The managementTemplate property</summary>
        public Microsoft.Graph.Beta.Models.ManagedTenants.ManagementTemplate ManagementTemplate { get; set; }
        /// <summary>The portalLink property</summary>
        public Microsoft.Graph.Beta.Models.ActionUrl PortalLink { get; set; }
        /// <summary>The priority property</summary>
        public int? Priority { get; set; }
        /// <summary>The versions property</summary>
        public List<ManagementTemplateStepVersion> Versions { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ManagementTemplateStep CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagementTemplateStep();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"acceptedVersion", n => { AcceptedVersion = n.GetObjectValue<ManagementTemplateStepVersion>(ManagementTemplateStepVersion.CreateFromDiscriminatorValue); } },
                {"category", n => { Category = n.GetEnumValue<ManagementCategory>(); } },
                {"createdByUserId", n => { CreatedByUserId = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastActionByUserId", n => { LastActionByUserId = n.GetStringValue(); } },
                {"lastActionDateTime", n => { LastActionDateTime = n.GetDateTimeOffsetValue(); } },
                {"managementTemplate", n => { ManagementTemplate = n.GetObjectValue<Microsoft.Graph.Beta.Models.ManagedTenants.ManagementTemplate>(Microsoft.Graph.Beta.Models.ManagedTenants.ManagementTemplate.CreateFromDiscriminatorValue); } },
                {"portalLink", n => { PortalLink = n.GetObjectValue<Microsoft.Graph.Beta.Models.ActionUrl>(Microsoft.Graph.Beta.Models.ActionUrl.CreateFromDiscriminatorValue); } },
                {"priority", n => { Priority = n.GetIntValue(); } },
                {"versions", n => { Versions = n.GetCollectionOfObjectValues<ManagementTemplateStepVersion>(ManagementTemplateStepVersion.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ManagementTemplateStepVersion>("acceptedVersion", AcceptedVersion);
            writer.WriteEnumValue<ManagementCategory>("category", Category);
            writer.WriteStringValue("createdByUserId", CreatedByUserId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("lastActionByUserId", LastActionByUserId);
            writer.WriteDateTimeOffsetValue("lastActionDateTime", LastActionDateTime);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ManagedTenants.ManagementTemplate>("managementTemplate", ManagementTemplate);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ActionUrl>("portalLink", PortalLink);
            writer.WriteIntValue("priority", Priority);
            writer.WriteCollectionOfObjectValues<ManagementTemplateStepVersion>("versions", Versions);
        }
    }
}
