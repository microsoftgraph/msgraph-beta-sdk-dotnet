using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class OfficeClientConfiguration : Entity, IParsable {
        /// <summary>The list of group assignments for the policy.</summary>
        public List<OfficeClientConfigurationAssignment> Assignments {
            get { return BackingStore?.Get<List<OfficeClientConfigurationAssignment>>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
        /// <summary>List of office Client check-in status.</summary>
        public List<OfficeClientCheckinStatus> CheckinStatuses {
            get { return BackingStore?.Get<List<OfficeClientCheckinStatus>>("checkinStatuses"); }
            set { BackingStore?.Set("checkinStatuses", value); }
        }
        /// <summary>Not yet documented</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>Admin provided description of the office client configuration policy.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>Policy settings JSON string in binary format, these values cannot be changed by the user.</summary>
        public byte[] PolicyPayload {
            get { return BackingStore?.Get<byte[]>("policyPayload"); }
            set { BackingStore?.Set("policyPayload", value); }
        }
        /// <summary>Priority value should be unique value for each policy under a tenant and will be used for conflict resolution, lower values mean priority is high.</summary>
        public int? Priority {
            get { return BackingStore?.Get<int?>("priority"); }
            set { BackingStore?.Set("priority", value); }
        }
        /// <summary>User check-in summary for the policy.</summary>
        public OfficeUserCheckinSummary UserCheckinSummary {
            get { return BackingStore?.Get<OfficeUserCheckinSummary>("userCheckinSummary"); }
            set { BackingStore?.Set("userCheckinSummary", value); }
        }
        /// <summary>Preference settings JSON string in binary format, these values can be overridden by the user.</summary>
        public byte[] UserPreferencePayload {
            get { return BackingStore?.Get<byte[]>("userPreferencePayload"); }
            set { BackingStore?.Set("userPreferencePayload", value); }
        }
        /// <summary>
        /// Instantiates a new OfficeClientConfiguration and sets the default values.
        /// </summary>
        public OfficeClientConfiguration() : base() {
            OdataType = "#microsoft.graph.officeClientConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new OfficeClientConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.windowsOfficeClientConfiguration" => new WindowsOfficeClientConfiguration(),
                "#microsoft.graph.windowsOfficeClientSecurityConfiguration" => new WindowsOfficeClientSecurityConfiguration(),
                _ => new OfficeClientConfiguration(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<OfficeClientConfigurationAssignment>(OfficeClientConfigurationAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"checkinStatuses", n => { CheckinStatuses = n.GetCollectionOfObjectValues<OfficeClientCheckinStatus>(OfficeClientCheckinStatus.CreateFromDiscriminatorValue)?.ToList(); } },
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
