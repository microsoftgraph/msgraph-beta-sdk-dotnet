using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedTenants {
    public class ManagementTemplateCollection : Entity, IParsable {
        public string CreatedByUserId { get; set; }
        public DateTimeOffset? CreatedDateTime { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public string LastActionByUserId { get; set; }
        public DateTimeOffset? LastActionDateTime { get; set; }
        public List<ManagementTemplate> ManagementTemplates { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"createdByUserId", (o,n) => { (o as ManagementTemplateCollection).CreatedByUserId = n.GetStringValue(); } },
                {"createdDateTime", (o,n) => { (o as ManagementTemplateCollection).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as ManagementTemplateCollection).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as ManagementTemplateCollection).DisplayName = n.GetStringValue(); } },
                {"lastActionByUserId", (o,n) => { (o as ManagementTemplateCollection).LastActionByUserId = n.GetStringValue(); } },
                {"lastActionDateTime", (o,n) => { (o as ManagementTemplateCollection).LastActionDateTime = n.GetDateTimeOffsetValue(); } },
                {"managementTemplates", (o,n) => { (o as ManagementTemplateCollection).ManagementTemplates = n.GetCollectionOfObjectValues<ManagementTemplate>().ToList(); } },
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
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("lastActionByUserId", LastActionByUserId);
            writer.WriteDateTimeOffsetValue("lastActionDateTime", LastActionDateTime);
            writer.WriteCollectionOfObjectValues<ManagementTemplate>("managementTemplates", ManagementTemplates);
        }
    }
}
