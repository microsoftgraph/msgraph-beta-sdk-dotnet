using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the attackSimulation property of the microsoft.graph.security entity.</summary>
    public class SimulationAutomation : Entity, IParsable {
        public EmailIdentity CreatedBy { get; set; }
        public DateTimeOffset? CreatedDateTime { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public EmailIdentity LastModifiedBy { get; set; }
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        public DateTimeOffset? LastRunDateTime { get; set; }
        public DateTimeOffset? NextRunDateTime { get; set; }
        public List<SimulationAutomationRun> Runs { get; set; }
        public SimulationAutomationStatus? Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SimulationAutomation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SimulationAutomation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"createdBy", (o,n) => { (o as SimulationAutomation).CreatedBy = n.GetObjectValue<EmailIdentity>(EmailIdentity.CreateFromDiscriminatorValue); } },
                {"createdDateTime", (o,n) => { (o as SimulationAutomation).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as SimulationAutomation).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as SimulationAutomation).DisplayName = n.GetStringValue(); } },
                {"lastModifiedBy", (o,n) => { (o as SimulationAutomation).LastModifiedBy = n.GetObjectValue<EmailIdentity>(EmailIdentity.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", (o,n) => { (o as SimulationAutomation).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastRunDateTime", (o,n) => { (o as SimulationAutomation).LastRunDateTime = n.GetDateTimeOffsetValue(); } },
                {"nextRunDateTime", (o,n) => { (o as SimulationAutomation).NextRunDateTime = n.GetDateTimeOffsetValue(); } },
                {"runs", (o,n) => { (o as SimulationAutomation).Runs = n.GetCollectionOfObjectValues<SimulationAutomationRun>(SimulationAutomationRun.CreateFromDiscriminatorValue).ToList(); } },
                {"status", (o,n) => { (o as SimulationAutomation).Status = n.GetEnumValue<SimulationAutomationStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<EmailIdentity>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<EmailIdentity>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteDateTimeOffsetValue("lastRunDateTime", LastRunDateTime);
            writer.WriteDateTimeOffsetValue("nextRunDateTime", NextRunDateTime);
            writer.WriteCollectionOfObjectValues<SimulationAutomationRun>("runs", Runs);
            writer.WriteEnumValue<SimulationAutomationStatus>("status", Status);
        }
    }
}
