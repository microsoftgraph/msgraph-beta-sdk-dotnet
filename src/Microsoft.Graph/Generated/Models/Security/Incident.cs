using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class Incident : Entity, IParsable {
        /// <summary>The alerts property</summary>
        public List<Alert> Alerts {
            get { return BackingStore?.Get<List<Alert>>(nameof(Alerts)); }
            set { BackingStore?.Set(nameof(Alerts), value); }
        }
        /// <summary>The assignedTo property</summary>
        public string AssignedTo {
            get { return BackingStore?.Get<string>(nameof(AssignedTo)); }
            set { BackingStore?.Set(nameof(AssignedTo), value); }
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
        /// <summary>The determination property</summary>
        public AlertDetermination? Determination {
            get { return BackingStore?.Get<AlertDetermination?>(nameof(Determination)); }
            set { BackingStore?.Set(nameof(Determination), value); }
        }
        /// <summary>The displayName property</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The incidentWebUrl property</summary>
        public string IncidentWebUrl {
            get { return BackingStore?.Get<string>(nameof(IncidentWebUrl)); }
            set { BackingStore?.Set(nameof(IncidentWebUrl), value); }
        }
        /// <summary>The lastUpdateDateTime property</summary>
        public DateTimeOffset? LastUpdateDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastUpdateDateTime)); }
            set { BackingStore?.Set(nameof(LastUpdateDateTime), value); }
        }
        /// <summary>The redirectIncidentId property</summary>
        public string RedirectIncidentId {
            get { return BackingStore?.Get<string>(nameof(RedirectIncidentId)); }
            set { BackingStore?.Set(nameof(RedirectIncidentId), value); }
        }
        /// <summary>The severity property</summary>
        public AlertSeverity? Severity {
            get { return BackingStore?.Get<AlertSeverity?>(nameof(Severity)); }
            set { BackingStore?.Set(nameof(Severity), value); }
        }
        /// <summary>The status property</summary>
        public IncidentStatus? Status {
            get { return BackingStore?.Get<IncidentStatus?>(nameof(Status)); }
            set { BackingStore?.Set(nameof(Status), value); }
        }
        /// <summary>The tags property</summary>
        public List<string> Tags {
            get { return BackingStore?.Get<List<string>>(nameof(Tags)); }
            set { BackingStore?.Set(nameof(Tags), value); }
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
        public static new Incident CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Incident();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"alerts", n => { Alerts = n.GetCollectionOfObjectValues<Alert>(Alert.CreateFromDiscriminatorValue).ToList(); } },
                {"assignedTo", n => { AssignedTo = n.GetStringValue(); } },
                {"classification", n => { Classification = n.GetEnumValue<AlertClassification>(); } },
                {"comments", n => { Comments = n.GetCollectionOfObjectValues<AlertComment>(AlertComment.CreateFromDiscriminatorValue).ToList(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"determination", n => { Determination = n.GetEnumValue<AlertDetermination>(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"incidentWebUrl", n => { IncidentWebUrl = n.GetStringValue(); } },
                {"lastUpdateDateTime", n => { LastUpdateDateTime = n.GetDateTimeOffsetValue(); } },
                {"redirectIncidentId", n => { RedirectIncidentId = n.GetStringValue(); } },
                {"severity", n => { Severity = n.GetEnumValue<AlertSeverity>(); } },
                {"status", n => { Status = n.GetEnumValue<IncidentStatus>(); } },
                {"tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
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
