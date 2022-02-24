using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.Security {
    public class Incident : Entity, IParsable {
        public List<Alert> Alerts { get; set; }
        public string AssignedTo { get; set; }
        public AlertClassification? Classification { get; set; }
        public List<AlertComment> Comments { get; set; }
        public DateTimeOffset? CreatedDateTime { get; set; }
        public AlertDetermination? Determination { get; set; }
        public string DisplayName { get; set; }
        public string IncidentWebUrl { get; set; }
        public DateTimeOffset? LastUpdateDateTime { get; set; }
        public string RedirectIncidentId { get; set; }
        public AlertSeverity? Severity { get; set; }
        public IncidentStatus? Status { get; set; }
        public List<string> Tags { get; set; }
        public string TenantId { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"alerts", (o,n) => { (o as Incident).Alerts = n.GetCollectionOfObjectValues<Alert>().ToList(); } },
                {"assignedTo", (o,n) => { (o as Incident).AssignedTo = n.GetStringValue(); } },
                {"classification", (o,n) => { (o as Incident).Classification = n.GetEnumValue<AlertClassification>(); } },
                {"comments", (o,n) => { (o as Incident).Comments = n.GetCollectionOfObjectValues<AlertComment>().ToList(); } },
                {"createdDateTime", (o,n) => { (o as Incident).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"determination", (o,n) => { (o as Incident).Determination = n.GetEnumValue<AlertDetermination>(); } },
                {"displayName", (o,n) => { (o as Incident).DisplayName = n.GetStringValue(); } },
                {"incidentWebUrl", (o,n) => { (o as Incident).IncidentWebUrl = n.GetStringValue(); } },
                {"lastUpdateDateTime", (o,n) => { (o as Incident).LastUpdateDateTime = n.GetDateTimeOffsetValue(); } },
                {"redirectIncidentId", (o,n) => { (o as Incident).RedirectIncidentId = n.GetStringValue(); } },
                {"severity", (o,n) => { (o as Incident).Severity = n.GetEnumValue<AlertSeverity>(); } },
                {"status", (o,n) => { (o as Incident).Status = n.GetEnumValue<IncidentStatus>(); } },
                {"tags", (o,n) => { (o as Incident).Tags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"tenantId", (o,n) => { (o as Incident).TenantId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Alert>("alerts", Alerts);
            writer.WriteStringValue("assignedTo", AssignedTo);
            writer.WriteEnumValue<AlertClassification>("classification", Classification);
            writer.WriteCollectionOfObjectValues<AlertComment>("comments", Comments);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteEnumValue<AlertDetermination>("determination", Determination);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("incidentWebUrl", IncidentWebUrl);
            writer.WriteDateTimeOffsetValue("lastUpdateDateTime", LastUpdateDateTime);
            writer.WriteStringValue("redirectIncidentId", RedirectIncidentId);
            writer.WriteEnumValue<AlertSeverity>("severity", Severity);
            writer.WriteEnumValue<IncidentStatus>("status", Status);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteStringValue("tenantId", TenantId);
        }
    }
}
