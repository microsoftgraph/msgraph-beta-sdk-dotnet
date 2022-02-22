using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph.Security {
    public class Alert : Entity, IParsable {
        public string ActorDisplayName { get; set; }
        public string AlertWebUrl { get; set; }
        public string AssignedTo { get; set; }
        public string Category { get; set; }
        public AlertClassification? Classification { get; set; }
        public List<AlertComment> Comments { get; set; }
        public DateTimeOffset? CreatedDateTime { get; set; }
        public string Description { get; set; }
        public DetectionSource? DetectionSource { get; set; }
        public string DetectorId { get; set; }
        public AlertDetermination? Determination { get; set; }
        public DateTimeOffset? FirstActivityDateTime { get; set; }
        public string IncidentId { get; set; }
        public string IncidentWebUrl { get; set; }
        public DateTimeOffset? LastActivityDateTime { get; set; }
        public DateTimeOffset? LastUpdateDateTime { get; set; }
        public List<string> MitreTechniques { get; set; }
        public string ProviderAlertId { get; set; }
        public string RecommendedActions { get; set; }
        public DateTimeOffset? ResolvedDateTime { get; set; }
        public ServiceSource? ServiceSource { get; set; }
        public AlertSeverity? Severity { get; set; }
        public AlertStatus? Status { get; set; }
        public string TenantId { get; set; }
        public string ThreatDisplayName { get; set; }
        public string ThreatFamilyName { get; set; }
        public string Title { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"actorDisplayName", (o,n) => { (o as Alert).ActorDisplayName = n.GetStringValue(); } },
                {"alertWebUrl", (o,n) => { (o as Alert).AlertWebUrl = n.GetStringValue(); } },
                {"assignedTo", (o,n) => { (o as Alert).AssignedTo = n.GetStringValue(); } },
                {"category", (o,n) => { (o as Alert).Category = n.GetStringValue(); } },
                {"classification", (o,n) => { (o as Alert).Classification = n.GetEnumValue<AlertClassification>(); } },
                {"comments", (o,n) => { (o as Alert).Comments = n.GetCollectionOfObjectValues<AlertComment>().ToList(); } },
                {"createdDateTime", (o,n) => { (o as Alert).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as Alert).Description = n.GetStringValue(); } },
                {"detectionSource", (o,n) => { (o as Alert).DetectionSource = n.GetEnumValue<DetectionSource>(); } },
                {"detectorId", (o,n) => { (o as Alert).DetectorId = n.GetStringValue(); } },
                {"determination", (o,n) => { (o as Alert).Determination = n.GetEnumValue<AlertDetermination>(); } },
                {"firstActivityDateTime", (o,n) => { (o as Alert).FirstActivityDateTime = n.GetDateTimeOffsetValue(); } },
                {"incidentId", (o,n) => { (o as Alert).IncidentId = n.GetStringValue(); } },
                {"incidentWebUrl", (o,n) => { (o as Alert).IncidentWebUrl = n.GetStringValue(); } },
                {"lastActivityDateTime", (o,n) => { (o as Alert).LastActivityDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastUpdateDateTime", (o,n) => { (o as Alert).LastUpdateDateTime = n.GetDateTimeOffsetValue(); } },
                {"mitreTechniques", (o,n) => { (o as Alert).MitreTechniques = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"providerAlertId", (o,n) => { (o as Alert).ProviderAlertId = n.GetStringValue(); } },
                {"recommendedActions", (o,n) => { (o as Alert).RecommendedActions = n.GetStringValue(); } },
                {"resolvedDateTime", (o,n) => { (o as Alert).ResolvedDateTime = n.GetDateTimeOffsetValue(); } },
                {"serviceSource", (o,n) => { (o as Alert).ServiceSource = n.GetEnumValue<ServiceSource>(); } },
                {"severity", (o,n) => { (o as Alert).Severity = n.GetEnumValue<AlertSeverity>(); } },
                {"status", (o,n) => { (o as Alert).Status = n.GetEnumValue<AlertStatus>(); } },
                {"tenantId", (o,n) => { (o as Alert).TenantId = n.GetStringValue(); } },
                {"threatDisplayName", (o,n) => { (o as Alert).ThreatDisplayName = n.GetStringValue(); } },
                {"threatFamilyName", (o,n) => { (o as Alert).ThreatFamilyName = n.GetStringValue(); } },
                {"title", (o,n) => { (o as Alert).Title = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("actorDisplayName", ActorDisplayName);
            writer.WriteStringValue("alertWebUrl", AlertWebUrl);
            writer.WriteStringValue("assignedTo", AssignedTo);
            writer.WriteStringValue("category", Category);
            writer.WriteEnumValue<AlertClassification>("classification", Classification);
            writer.WriteCollectionOfObjectValues<AlertComment>("comments", Comments);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteEnumValue<DetectionSource>("detectionSource", DetectionSource);
            writer.WriteStringValue("detectorId", DetectorId);
            writer.WriteEnumValue<AlertDetermination>("determination", Determination);
            writer.WriteDateTimeOffsetValue("firstActivityDateTime", FirstActivityDateTime);
            writer.WriteStringValue("incidentId", IncidentId);
            writer.WriteStringValue("incidentWebUrl", IncidentWebUrl);
            writer.WriteDateTimeOffsetValue("lastActivityDateTime", LastActivityDateTime);
            writer.WriteDateTimeOffsetValue("lastUpdateDateTime", LastUpdateDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("mitreTechniques", MitreTechniques);
            writer.WriteStringValue("providerAlertId", ProviderAlertId);
            writer.WriteStringValue("recommendedActions", RecommendedActions);
            writer.WriteDateTimeOffsetValue("resolvedDateTime", ResolvedDateTime);
            writer.WriteEnumValue<ServiceSource>("serviceSource", ServiceSource);
            writer.WriteEnumValue<AlertSeverity>("severity", Severity);
            writer.WriteEnumValue<AlertStatus>("status", Status);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteStringValue("threatDisplayName", ThreatDisplayName);
            writer.WriteStringValue("threatFamilyName", ThreatFamilyName);
            writer.WriteStringValue("title", Title);
        }
    }
}
