using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class Simulation : Entity, IParsable {
        /// <summary>The social engineering technique used in the attack simulation and training campaign. Supports $filter and $orderby. Possible values are: unknown, credentialHarvesting, attachmentMalware, driveByUrl, linkInAttachment, linkToMalwareFile, unknownFutureValue. For more information on the types of social engineering attack techniques, see simulations.</summary>
        public SimulationAttackTechnique? AttackTechnique { get; set; }
        /// <summary>Attack type of the attack simulation and training campaign. Supports $filter and $orderby. Possible values are: unknown, social, cloud, endpoint, unknownFutureValue.</summary>
        public SimulationAttackType? AttackType { get; set; }
        public string AutomationId { get; set; }
        /// <summary>Date and time of completion of the attack simulation and training campaign. Supports $filter and $orderby.</summary>
        public DateTimeOffset? CompletionDateTime { get; set; }
        /// <summary>Identity of the user who created the attack simulation and training campaign.</summary>
        public EmailIdentity CreatedBy { get; set; }
        /// <summary>Date and time of creation of the attack simulation and training campaign.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Description of the attack simulation and training campaign.</summary>
        public string Description { get; set; }
        /// <summary>Display name of the attack simulation and training campaign. Supports $filter and $orderby.</summary>
        public string DisplayName { get; set; }
        /// <summary>Flag representing if the attack simulation and training campaign was created from a simulation automation flow. Supports $filter and $orderby.</summary>
        public bool? IsAutomated { get; set; }
        /// <summary>Identity of the user who most recently modified the attack simulation and training campaign.</summary>
        public EmailIdentity LastModifiedBy { get; set; }
        /// <summary>Date and time of the most recent modification of the attack simulation and training campaign.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Date and time of the launch/start of the attack simulation and training campaign. Supports $filter and $orderby.</summary>
        public DateTimeOffset? LaunchDateTime { get; set; }
        /// <summary>Method of delivery of the phishing payload used in the attack simulation and training campaign. Possible values are: unknown, sms, email, teams, unknownFutureValue.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.PayloadDeliveryPlatform? PayloadDeliveryPlatform { get; set; }
        /// <summary>Report of the attack simulation and training campaign.</summary>
        public SimulationReport Report { get; set; }
        /// <summary>Status of the attack simulation and training campaign. Supports $filter and $orderby. Possible values are: unknown, draft, inProgress, scheduled, completed, partiallyCompleted, failed, cancelled, excluded, deleted, included, unknownFutureValue.</summary>
        public SimulationStatus? Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Simulation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Simulation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"attackTechnique", (o,n) => { (o as Simulation).AttackTechnique = n.GetEnumValue<SimulationAttackTechnique>(); } },
                {"attackType", (o,n) => { (o as Simulation).AttackType = n.GetEnumValue<SimulationAttackType>(); } },
                {"automationId", (o,n) => { (o as Simulation).AutomationId = n.GetStringValue(); } },
                {"completionDateTime", (o,n) => { (o as Simulation).CompletionDateTime = n.GetDateTimeOffsetValue(); } },
                {"createdBy", (o,n) => { (o as Simulation).CreatedBy = n.GetObjectValue<EmailIdentity>(EmailIdentity.CreateFromDiscriminatorValue); } },
                {"createdDateTime", (o,n) => { (o as Simulation).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as Simulation).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as Simulation).DisplayName = n.GetStringValue(); } },
                {"isAutomated", (o,n) => { (o as Simulation).IsAutomated = n.GetBoolValue(); } },
                {"lastModifiedBy", (o,n) => { (o as Simulation).LastModifiedBy = n.GetObjectValue<EmailIdentity>(EmailIdentity.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", (o,n) => { (o as Simulation).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"launchDateTime", (o,n) => { (o as Simulation).LaunchDateTime = n.GetDateTimeOffsetValue(); } },
                {"payloadDeliveryPlatform", (o,n) => { (o as Simulation).PayloadDeliveryPlatform = n.GetEnumValue<PayloadDeliveryPlatform>(); } },
                {"report", (o,n) => { (o as Simulation).Report = n.GetObjectValue<SimulationReport>(SimulationReport.CreateFromDiscriminatorValue); } },
                {"status", (o,n) => { (o as Simulation).Status = n.GetEnumValue<SimulationStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<SimulationAttackTechnique>("attackTechnique", AttackTechnique);
            writer.WriteEnumValue<SimulationAttackType>("attackType", AttackType);
            writer.WriteStringValue("automationId", AutomationId);
            writer.WriteDateTimeOffsetValue("completionDateTime", CompletionDateTime);
            writer.WriteObjectValue<EmailIdentity>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isAutomated", IsAutomated);
            writer.WriteObjectValue<EmailIdentity>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteDateTimeOffsetValue("launchDateTime", LaunchDateTime);
            writer.WriteEnumValue<PayloadDeliveryPlatform>("payloadDeliveryPlatform", PayloadDeliveryPlatform);
            writer.WriteObjectValue<SimulationReport>("report", Report);
            writer.WriteEnumValue<SimulationStatus>("status", Status);
        }
    }
}
