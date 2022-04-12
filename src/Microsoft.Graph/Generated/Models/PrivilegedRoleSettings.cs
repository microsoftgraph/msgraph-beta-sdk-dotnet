using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PrivilegedRoleSettings : Entity, IParsable {
        /// <summary>true if the approval is required when activate the role. false if the approval is not required when activate the role.</summary>
        public bool? ApprovalOnElevation { get; set; }
        /// <summary>List of Approval ids, if approval is required for activation.</summary>
        public List<string> ApproverIds { get; set; }
        /// <summary>The duration when the role is activated.</summary>
        public TimeSpan? ElevationDuration { get; set; }
        /// <summary>true if mfaOnElevation is configurable. false if mfaOnElevation is not configurable.</summary>
        public bool? IsMfaOnElevationConfigurable { get; set; }
        /// <summary>Internal used only.</summary>
        public bool? LastGlobalAdmin { get; set; }
        /// <summary>Maximal duration for the activated role.</summary>
        public TimeSpan? MaxElavationDuration { get; set; }
        /// <summary>true if MFA is required to activate the role. false if MFA is not required to activate the role.</summary>
        public bool? MfaOnElevation { get; set; }
        /// <summary>Minimal duration for the activated role.</summary>
        public TimeSpan? MinElevationDuration { get; set; }
        /// <summary>true if send notification to the end user when the role is activated. false if do not send notification when the role is activated.</summary>
        public bool? NotificationToUserOnElevation { get; set; }
        /// <summary>true if the ticketing information is required when activate the role. false if the ticketing information is not required when activate the role.</summary>
        public bool? TicketingInfoOnElevation { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new PrivilegedRoleSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrivilegedRoleSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"approvalOnElevation", n => { ApprovalOnElevation = n.GetBoolValue(); } },
                {"approverIds", n => { ApproverIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"elevationDuration", n => { ElevationDuration = n.GetTimeSpanValue(); } },
                {"isMfaOnElevationConfigurable", n => { IsMfaOnElevationConfigurable = n.GetBoolValue(); } },
                {"lastGlobalAdmin", n => { LastGlobalAdmin = n.GetBoolValue(); } },
                {"maxElavationDuration", n => { MaxElavationDuration = n.GetTimeSpanValue(); } },
                {"mfaOnElevation", n => { MfaOnElevation = n.GetBoolValue(); } },
                {"minElevationDuration", n => { MinElevationDuration = n.GetTimeSpanValue(); } },
                {"notificationToUserOnElevation", n => { NotificationToUserOnElevation = n.GetBoolValue(); } },
                {"ticketingInfoOnElevation", n => { TicketingInfoOnElevation = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("approvalOnElevation", ApprovalOnElevation);
            writer.WriteCollectionOfPrimitiveValues<string>("approverIds", ApproverIds);
            writer.WriteTimeSpanValue("elevationDuration", ElevationDuration);
            writer.WriteBoolValue("isMfaOnElevationConfigurable", IsMfaOnElevationConfigurable);
            writer.WriteBoolValue("lastGlobalAdmin", LastGlobalAdmin);
            writer.WriteTimeSpanValue("maxElavationDuration", MaxElavationDuration);
            writer.WriteBoolValue("mfaOnElevation", MfaOnElevation);
            writer.WriteTimeSpanValue("minElevationDuration", MinElevationDuration);
            writer.WriteBoolValue("notificationToUserOnElevation", NotificationToUserOnElevation);
            writer.WriteBoolValue("ticketingInfoOnElevation", TicketingInfoOnElevation);
        }
    }
}
