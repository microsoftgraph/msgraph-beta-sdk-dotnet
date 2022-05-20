using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the security singleton.</summary>
    public class Simulation : Entity, IParsable {
        /// <summary>The social engineering technique used in the attack simulation and training campaign. Supports $filter and $orderby. Possible values are: unknown, credentialHarvesting, attachmentMalware, driveByUrl, linkInAttachment, linkToMalwareFile, unknownFutureValue. For more information on the types of social engineering attack techniques, see simulations.</summary>
        public SimulationAttackTechnique? AttackTechnique {
            get { return BackingStore?.Get<SimulationAttackTechnique?>(nameof(AttackTechnique)); }
            set { BackingStore?.Set(nameof(AttackTechnique), value); }
        }
        /// <summary>Attack type of the attack simulation and training campaign. Supports $filter and $orderby. Possible values are: unknown, social, cloud, endpoint, unknownFutureValue.</summary>
        public SimulationAttackType? AttackType {
            get { return BackingStore?.Get<SimulationAttackType?>(nameof(AttackType)); }
            set { BackingStore?.Set(nameof(AttackType), value); }
        }
        /// <summary>Unique identifier for the attack simulation automation.</summary>
        public string AutomationId {
            get { return BackingStore?.Get<string>(nameof(AutomationId)); }
            set { BackingStore?.Set(nameof(AutomationId), value); }
        }
        /// <summary>Date and time of completion of the attack simulation and training campaign. Supports $filter and $orderby.</summary>
        public DateTimeOffset? CompletionDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CompletionDateTime)); }
            set { BackingStore?.Set(nameof(CompletionDateTime), value); }
        }
        /// <summary>Identity of the user who created the attack simulation and training campaign.</summary>
        public EmailIdentity CreatedBy {
            get { return BackingStore?.Get<EmailIdentity>(nameof(CreatedBy)); }
            set { BackingStore?.Set(nameof(CreatedBy), value); }
        }
        /// <summary>Date and time of creation of the attack simulation and training campaign.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>Description of the attack simulation and training campaign.</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>Display name of the attack simulation and training campaign. Supports $filter and $orderby.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>Flag representing if the attack simulation and training campaign was created from a simulation automation flow. Supports $filter and $orderby.</summary>
        public bool? IsAutomated {
            get { return BackingStore?.Get<bool?>(nameof(IsAutomated)); }
            set { BackingStore?.Set(nameof(IsAutomated), value); }
        }
        /// <summary>Identity of the user who most recently modified the attack simulation and training campaign.</summary>
        public EmailIdentity LastModifiedBy {
            get { return BackingStore?.Get<EmailIdentity>(nameof(LastModifiedBy)); }
            set { BackingStore?.Set(nameof(LastModifiedBy), value); }
        }
        /// <summary>Date and time of the most recent modification of the attack simulation and training campaign.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(LastModifiedDateTime), value); }
        }
        /// <summary>Date and time of the launch/start of the attack simulation and training campaign. Supports $filter and $orderby.</summary>
        public DateTimeOffset? LaunchDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LaunchDateTime)); }
            set { BackingStore?.Set(nameof(LaunchDateTime), value); }
        }
        /// <summary>Method of delivery of the phishing payload used in the attack simulation and training campaign. Possible values are: unknown, sms, email, teams, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.PayloadDeliveryPlatform? PayloadDeliveryPlatform {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PayloadDeliveryPlatform?>(nameof(PayloadDeliveryPlatform)); }
            set { BackingStore?.Set(nameof(PayloadDeliveryPlatform), value); }
        }
        /// <summary>Report of the attack simulation and training campaign.</summary>
        public SimulationReport Report {
            get { return BackingStore?.Get<SimulationReport>(nameof(Report)); }
            set { BackingStore?.Set(nameof(Report), value); }
        }
        /// <summary>Status of the attack simulation and training campaign. Supports $filter and $orderby. Possible values are: unknown, draft, running, scheduled, succeeded, failed, cancelled, excluded, unknownFutureValue.</summary>
        public SimulationStatus? Status {
            get { return BackingStore?.Get<SimulationStatus?>(nameof(Status)); }
            set { BackingStore?.Set(nameof(Status), value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"attackTechnique", n => { AttackTechnique = n.GetEnumValue<SimulationAttackTechnique>(); } },
                {"attackType", n => { AttackType = n.GetEnumValue<SimulationAttackType>(); } },
                {"automationId", n => { AutomationId = n.GetStringValue(); } },
                {"completionDateTime", n => { CompletionDateTime = n.GetDateTimeOffsetValue(); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<EmailIdentity>(EmailIdentity.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"isAutomated", n => { IsAutomated = n.GetBoolValue(); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<EmailIdentity>(EmailIdentity.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"launchDateTime", n => { LaunchDateTime = n.GetDateTimeOffsetValue(); } },
                {"payloadDeliveryPlatform", n => { PayloadDeliveryPlatform = n.GetEnumValue<PayloadDeliveryPlatform>(); } },
                {"report", n => { Report = n.GetObjectValue<SimulationReport>(SimulationReport.CreateFromDiscriminatorValue); } },
                {"status", n => { Status = n.GetEnumValue<SimulationStatus>(); } },
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
