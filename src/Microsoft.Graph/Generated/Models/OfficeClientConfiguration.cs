using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class OfficeClientConfiguration : Entity, IParsable {
        /// <summary>The list of group assignments for the policy.</summary>
        public List<OfficeClientConfigurationAssignment> Assignments { get; set; }
        /// <summary>List of office Client check-in status.</summary>
        public List<OfficeClientCheckinStatus> CheckinStatuses { get; set; }
        /// <summary>Not yet documented</summary>
        public string Description { get; set; }
        /// <summary>Admin provided description of the office client configuration policy.</summary>
        public string DisplayName { get; set; }
        /// <summary>Policy settings JSON string in binary format, these values cannot be changed by the user.</summary>
        public byte[] PolicyPayload { get; set; }
        /// <summary>Priority value should be unique value for each policy under a tenant and will be used for conflict resolution, lower values mean priority is high.</summary>
        public int? Priority { get; set; }
        /// <summary>User check-in summary for the policy.</summary>
        public OfficeUserCheckinSummary UserCheckinSummary { get; set; }
        /// <summary>Preference settings JSON string in binary format, these values can be overridden by the user.</summary>
        public byte[] UserPreferencePayload { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new OfficeClientConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OfficeClientConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<OfficeClientConfigurationAssignment>(OfficeClientConfigurationAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"checkinStatuses", n => { CheckinStatuses = n.GetCollectionOfObjectValues<OfficeClientCheckinStatus>(OfficeClientCheckinStatus.CreateFromDiscriminatorValue).ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"policyPayload", n => { PolicyPayload = n.GetByteArrayValue(); } },
                {"priority", n => { Priority = n.GetIntValue(); } },
                {"userCheckinSummary", n => { UserCheckinSummary = n.GetObjectValue<OfficeUserCheckinSummary>(OfficeUserCheckinSummary.CreateFromDiscriminatorValue); } },
                {"userPreferencePayload", n => { UserPreferencePayload = n.GetByteArrayValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<OfficeClientConfigurationAssignment>("assignments", Assignments);
            writer.WriteCollectionOfObjectValues<OfficeClientCheckinStatus>("checkinStatuses", CheckinStatuses);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteByteArrayValue("policyPayload", PolicyPayload);
            writer.WriteIntValue("priority", Priority);
            writer.WriteObjectValue<OfficeUserCheckinSummary>("userCheckinSummary", UserCheckinSummary);
            writer.WriteByteArrayValue("userPreferencePayload", UserPreferencePayload);
        }
    }
}
