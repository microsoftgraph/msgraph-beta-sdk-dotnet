using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The user experience analytics Device not windows autopilot ready.</summary>
    public class UserExperienceAnalyticsNotAutopilotReadyDevice : Entity, IParsable {
        /// <summary>The intune device&apos;s autopilotProfileAssigned.</summary>
        public bool? AutoPilotProfileAssigned {
            get { return BackingStore?.Get<bool?>(nameof(AutoPilotProfileAssigned)); }
            set { BackingStore?.Set(nameof(AutoPilotProfileAssigned), value); }
        }
        /// <summary>The intune device&apos;s autopilotRegistered.</summary>
        public bool? AutoPilotRegistered {
            get { return BackingStore?.Get<bool?>(nameof(AutoPilotRegistered)); }
            set { BackingStore?.Set(nameof(AutoPilotRegistered), value); }
        }
        /// <summary>The intune device&apos;s azure Ad joinType.</summary>
        public string AzureAdJoinType {
            get { return BackingStore?.Get<string>(nameof(AzureAdJoinType)); }
            set { BackingStore?.Set(nameof(AzureAdJoinType), value); }
        }
        /// <summary>The intune device&apos;s azureAdRegistered.</summary>
        public bool? AzureAdRegistered {
            get { return BackingStore?.Get<bool?>(nameof(AzureAdRegistered)); }
            set { BackingStore?.Set(nameof(AzureAdRegistered), value); }
        }
        /// <summary>The intune device&apos;s name.</summary>
        public string DeviceName {
            get { return BackingStore?.Get<string>(nameof(DeviceName)); }
            set { BackingStore?.Set(nameof(DeviceName), value); }
        }
        /// <summary>The intune device&apos;s managed by.</summary>
        public string ManagedBy {
            get { return BackingStore?.Get<string>(nameof(ManagedBy)); }
            set { BackingStore?.Set(nameof(ManagedBy), value); }
        }
        /// <summary>The intune device&apos;s manufacturer.</summary>
        public string Manufacturer {
            get { return BackingStore?.Get<string>(nameof(Manufacturer)); }
            set { BackingStore?.Set(nameof(Manufacturer), value); }
        }
        /// <summary>The intune device&apos;s model.</summary>
        public string Model {
            get { return BackingStore?.Get<string>(nameof(Model)); }
            set { BackingStore?.Set(nameof(Model), value); }
        }
        /// <summary>The intune device&apos;s serial number.</summary>
        public string SerialNumber {
            get { return BackingStore?.Get<string>(nameof(SerialNumber)); }
            set { BackingStore?.Set(nameof(SerialNumber), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserExperienceAnalyticsNotAutopilotReadyDevice CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsNotAutopilotReadyDevice();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"autoPilotProfileAssigned", n => { AutoPilotProfileAssigned = n.GetBoolValue(); } },
                {"autoPilotRegistered", n => { AutoPilotRegistered = n.GetBoolValue(); } },
                {"azureAdJoinType", n => { AzureAdJoinType = n.GetStringValue(); } },
                {"azureAdRegistered", n => { AzureAdRegistered = n.GetBoolValue(); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"managedBy", n => { ManagedBy = n.GetStringValue(); } },
                {"manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                {"model", n => { Model = n.GetStringValue(); } },
                {"serialNumber", n => { SerialNumber = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("autoPilotProfileAssigned", AutoPilotProfileAssigned);
            writer.WriteBoolValue("autoPilotRegistered", AutoPilotRegistered);
            writer.WriteStringValue("azureAdJoinType", AzureAdJoinType);
            writer.WriteBoolValue("azureAdRegistered", AzureAdRegistered);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteStringValue("managedBy", ManagedBy);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("model", Model);
            writer.WriteStringValue("serialNumber", SerialNumber);
        }
    }
}
