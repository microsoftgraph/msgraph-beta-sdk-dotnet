using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class Alert : Entity, IParsable {
        /// <summary>The actorDisplayName property</summary>
        public string ActorDisplayName {
            get { return BackingStore?.Get<string>(nameof(ActorDisplayName)); }
            set { BackingStore?.Set(nameof(ActorDisplayName), value); }
        }
        /// <summary>The alertWebUrl property</summary>
        public string AlertWebUrl {
            get { return BackingStore?.Get<string>(nameof(AlertWebUrl)); }
            set { BackingStore?.Set(nameof(AlertWebUrl), value); }
        }
        /// <summary>The assignedTo property</summary>
        public string AssignedTo {
            get { return BackingStore?.Get<string>(nameof(AssignedTo)); }
            set { BackingStore?.Set(nameof(AssignedTo), value); }
        }
        /// <summary>The category property</summary>
        public string Category {
            get { return BackingStore?.Get<string>(nameof(Category)); }
            set { BackingStore?.Set(nameof(Category), value); }
        }
        /// <summary>The classification property</summary>
        public AlertClassification? Classification {
            get { return BackingStore?.Get<AlertClassification?>(nameof(Classification)); }
            set { BackingStore?.Set(nameof(Classification), value); }
        }
        /// <summary>The comments property</summary>
        public List<AlertComment> Comments {
            get { return BackingStore?.Get<List<AlertComment>>(nameof(Comments)); }
            set { BackingStore?.Set(nameof(Comments), value); }
        }
        /// <summary>The createdDateTime property</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>The description property</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>The detectionSource property</summary>
        public Microsoft.Graph.Beta.Models.Security.DetectionSource? DetectionSource {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.DetectionSource?>(nameof(DetectionSource)); }
            set { BackingStore?.Set(nameof(DetectionSource), value); }
        }
        /// <summary>The detectorId property</summary>
        public string DetectorId {
            get { return BackingStore?.Get<string>(nameof(DetectorId)); }
            set { BackingStore?.Set(nameof(DetectorId), value); }
        }
        /// <summary>The determination property</summary>
        public AlertDetermination? Determination {
            get { return BackingStore?.Get<AlertDetermination?>(nameof(Determination)); }
            set { BackingStore?.Set(nameof(Determination), value); }
        }
        /// <summary>The evidence property</summary>
        public List<AlertEvidence> Evidence {
            get { return BackingStore?.Get<List<AlertEvidence>>(nameof(Evidence)); }
            set { BackingStore?.Set(nameof(Evidence), value); }
        }
        /// <summary>The firstActivityDateTime property</summary>
        public DateTimeOffset? FirstActivityDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(FirstActivityDateTime)); }
            set { BackingStore?.Set(nameof(FirstActivityDateTime), value); }
        }
        /// <summary>The incidentId property</summary>
        public string IncidentId {
            get { return BackingStore?.Get<string>(nameof(IncidentId)); }
            set { BackingStore?.Set(nameof(IncidentId), value); }
        }
        /// <summary>The incidentWebUrl property</summary>
        public string IncidentWebUrl {
            get { return BackingStore?.Get<string>(nameof(IncidentWebUrl)); }
            set { BackingStore?.Set(nameof(IncidentWebUrl), value); }
        }
        /// <summary>The lastActivityDateTime property</summary>
        public DateTimeOffset? LastActivityDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastActivityDateTime)); }
            set { BackingStore?.Set(nameof(LastActivityDateTime), value); }
        }
        /// <summary>The lastUpdateDateTime property</summary>
        public DateTimeOffset? LastUpdateDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastUpdateDateTime)); }
            set { BackingStore?.Set(nameof(LastUpdateDateTime), value); }
        }
        /// <summary>The mitreTechniques property</summary>
        public List<string> MitreTechniques {
            get { return BackingStore?.Get<List<string>>(nameof(MitreTechniques)); }
            set { BackingStore?.Set(nameof(MitreTechniques), value); }
        }
        /// <summary>The providerAlertId property</summary>
        public string ProviderAlertId {
            get { return BackingStore?.Get<string>(nameof(ProviderAlertId)); }
            set { BackingStore?.Set(nameof(ProviderAlertId), value); }
        }
        /// <summary>The recommendedActions property</summary>
        public string RecommendedActions {
            get { return BackingStore?.Get<string>(nameof(RecommendedActions)); }
            set { BackingStore?.Set(nameof(RecommendedActions), value); }
        }
        /// <summary>The resolvedDateTime property</summary>
        public DateTimeOffset? ResolvedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ResolvedDateTime)); }
            set { BackingStore?.Set(nameof(ResolvedDateTime), value); }
        }
        /// <summary>The serviceSource property</summary>
        public Microsoft.Graph.Beta.Models.Security.ServiceSource? ServiceSource {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.ServiceSource?>(nameof(ServiceSource)); }
            set { BackingStore?.Set(nameof(ServiceSource), value); }
        }
        /// <summary>The severity property</summary>
        public AlertSeverity? Severity {
            get { return BackingStore?.Get<AlertSeverity?>(nameof(Severity)); }
            set { BackingStore?.Set(nameof(Severity), value); }
        }
        /// <summary>The status property</summary>
        public AlertStatus? Status {
            get { return BackingStore?.Get<AlertStatus?>(nameof(Status)); }
            set { BackingStore?.Set(nameof(Status), value); }
        }
        /// <summary>The tenantId property</summary>
        public string TenantId {
            get { return BackingStore?.Get<string>(nameof(TenantId)); }
            set { BackingStore?.Set(nameof(TenantId), value); }
        }
        /// <summary>The threatDisplayName property</summary>
        public string ThreatDisplayName {
            get { return BackingStore?.Get<string>(nameof(ThreatDisplayName)); }
            set { BackingStore?.Set(nameof(ThreatDisplayName), value); }
        }
        /// <summary>The threatFamilyName property</summary>
        public string ThreatFamilyName {
            get { return BackingStore?.Get<string>(nameof(ThreatFamilyName)); }
            set { BackingStore?.Set(nameof(ThreatFamilyName), value); }
        }
        /// <summary>The title property</summary>
        public string Title {
            get { return BackingStore?.Get<string>(nameof(Title)); }
            set { BackingStore?.Set(nameof(Title), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Alert CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Alert();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"actorDisplayName", n => { ActorDisplayName = n.GetStringValue(); } },
                {"alertWebUrl", n => { AlertWebUrl = n.GetStringValue(); } },
                {"assignedTo", n => { AssignedTo = n.GetStringValue(); } },
                {"category", n => { Category = n.GetStringValue(); } },
                {"classification", n => { Classification = n.GetEnumValue<AlertClassification>(); } },
                {"comments", n => { Comments = n.GetCollectionOfObjectValues<AlertComment>(AlertComment.CreateFromDiscriminatorValue).ToList(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"detectionSource", n => { DetectionSource = n.GetEnumValue<DetectionSource>(); } },
                {"detectorId", n => { DetectorId = n.GetStringValue(); } },
                {"determination", n => { Determination = n.GetEnumValue<AlertDetermination>(); } },
                {"evidence", n => { Evidence = n.GetCollectionOfObjectValues<AlertEvidence>(AlertEvidence.CreateFromDiscriminatorValue).ToList(); } },
                {"firstActivityDateTime", n => { FirstActivityDateTime = n.GetDateTimeOffsetValue(); } },
                {"incidentId", n => { IncidentId = n.GetStringValue(); } },
                {"incidentWebUrl", n => { IncidentWebUrl = n.GetStringValue(); } },
                {"lastActivityDateTime", n => { LastActivityDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastUpdateDateTime", n => { LastUpdateDateTime = n.GetDateTimeOffsetValue(); } },
                {"mitreTechniques", n => { MitreTechniques = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"providerAlertId", n => { ProviderAlertId = n.GetStringValue(); } },
                {"recommendedActions", n => { RecommendedActions = n.GetStringValue(); } },
                {"resolvedDateTime", n => { ResolvedDateTime = n.GetDateTimeOffsetValue(); } },
                {"serviceSource", n => { ServiceSource = n.GetEnumValue<ServiceSource>(); } },
                {"severity", n => { Severity = n.GetEnumValue<AlertSeverity>(); } },
                {"status", n => { Status = n.GetEnumValue<AlertStatus>(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
                {"threatDisplayName", n => { ThreatDisplayName = n.GetStringValue(); } },
                {"threatFamilyName", n => { ThreatFamilyName = n.GetStringValue(); } },
                {"title", n => { Title = n.GetStringValue(); } },
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
            writer.WriteCollectionOfObjectValues<AlertEvidence>("evidence", Evidence);
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
