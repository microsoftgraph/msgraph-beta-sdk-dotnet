using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class SimulationAutomation : Entity, IParsable {
        /// <summary>Identity of the user who created the attack simulation automation.</summary>
        public EmailIdentity CreatedBy { get; set; }
        /// <summary>Date and time when the attack simulation automation was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Description of the attack simulation automation.</summary>
        public string Description { get; set; }
        /// <summary>Display name of the attack simulation automation. Supports $filter and $orderby.</summary>
        public string DisplayName { get; set; }
        /// <summary>Identity of the user who most recently modified the attack simulation automation.</summary>
        public EmailIdentity LastModifiedBy { get; set; }
        /// <summary>Date and time when the attack simulation automation was most recently modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Date and time of the latest run of the attack simulation automation.</summary>
        public DateTimeOffset? LastRunDateTime { get; set; }
        /// <summary>Date and time of the upcoming run of the attack simulation automation.</summary>
        public DateTimeOffset? NextRunDateTime { get; set; }
        /// <summary>A collection of simulation automation runs.</summary>
        public List<SimulationAutomationRun> Runs { get; set; }
        /// <summary>Status of the attack simulation automation. Supports $filter and $orderby. The possible values are: unknown, draft, notRunning, running, completed, unknownFutureValue.</summary>
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
