using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedTenants {
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
        public MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedTenants.ManagementTemplate ManagementTemplate { get; set; }
        /// <summary>The portalLink property</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.ActionUrl PortalLink { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"acceptedVersion", (o,n) => { (o as ManagementTemplateStep).AcceptedVersion = n.GetObjectValue<ManagementTemplateStepVersion>(ManagementTemplateStepVersion.CreateFromDiscriminatorValue); } },
                {"category", (o,n) => { (o as ManagementTemplateStep).Category = n.GetEnumValue<ManagementCategory>(); } },
                {"createdByUserId", (o,n) => { (o as ManagementTemplateStep).CreatedByUserId = n.GetStringValue(); } },
                {"createdDateTime", (o,n) => { (o as ManagementTemplateStep).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as ManagementTemplateStep).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as ManagementTemplateStep).DisplayName = n.GetStringValue(); } },
                {"lastActionByUserId", (o,n) => { (o as ManagementTemplateStep).LastActionByUserId = n.GetStringValue(); } },
                {"lastActionDateTime", (o,n) => { (o as ManagementTemplateStep).LastActionDateTime = n.GetDateTimeOffsetValue(); } },
                {"managementTemplate", (o,n) => { (o as ManagementTemplateStep).ManagementTemplate = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedTenants.ManagementTemplate>(MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedTenants.ManagementTemplate.CreateFromDiscriminatorValue); } },
                {"portalLink", (o,n) => { (o as ManagementTemplateStep).PortalLink = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ActionUrl>(MicrosoftGraphSdk.Models.Microsoft.Graph.ActionUrl.CreateFromDiscriminatorValue); } },
                {"priority", (o,n) => { (o as ManagementTemplateStep).Priority = n.GetIntValue(); } },
                {"versions", (o,n) => { (o as ManagementTemplateStep).Versions = n.GetCollectionOfObjectValues<ManagementTemplateStepVersion>(ManagementTemplateStepVersion.CreateFromDiscriminatorValue).ToList(); } },
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
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedTenants.ManagementTemplate>("managementTemplate", ManagementTemplate);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ActionUrl>("portalLink", PortalLink);
            writer.WriteIntValue("priority", Priority);
            writer.WriteCollectionOfObjectValues<ManagementTemplateStepVersion>("versions", Versions);
        }
    }
}
