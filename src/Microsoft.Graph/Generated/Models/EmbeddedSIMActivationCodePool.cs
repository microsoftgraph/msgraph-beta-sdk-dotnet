using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class EmbeddedSIMActivationCodePool : Entity, IParsable {
        /// <summary>The total count of activation codes which belong to this pool.</summary>
        public int? ActivationCodeCount {
            get { return BackingStore?.Get<int?>("activationCodeCount"); }
            set { BackingStore?.Set("activationCodeCount", value); }
        }
        /// <summary>The activation codes which belong to this pool. This navigation property is used to post activation codes to Intune but cannot be used to read activation codes from Intune.</summary>
        public List<EmbeddedSIMActivationCode> ActivationCodes {
            get { return BackingStore?.Get<List<EmbeddedSIMActivationCode>>("activationCodes"); }
            set { BackingStore?.Set("activationCodes", value); }
        }
        /// <summary>Navigational property to a list of targets to which this pool is assigned.</summary>
        public List<EmbeddedSIMActivationCodePoolAssignment> Assignments {
            get { return BackingStore?.Get<List<EmbeddedSIMActivationCodePoolAssignment>>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
        /// <summary>The time the embedded SIM activation code pool was created. Generated service side.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Navigational property to a list of device states for this pool.</summary>
        public List<EmbeddedSIMDeviceState> DeviceStates {
            get { return BackingStore?.Get<List<EmbeddedSIMDeviceState>>("deviceStates"); }
            set { BackingStore?.Set("deviceStates", value); }
        }
        /// <summary>The admin defined name of the embedded SIM activation code pool.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The time the embedded SIM activation code pool was last modified. Updated service side.</summary>
        public DateTimeOffset? ModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("modifiedDateTime"); }
            set { BackingStore?.Set("modifiedDateTime", value); }
        }
        /// <summary>
        /// Instantiates a new EmbeddedSIMActivationCodePool and sets the default values.
        /// </summary>
        public EmbeddedSIMActivationCodePool() : base() {
            OdataType = "#microsoft.graph.embeddedSIMActivationCodePool";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EmbeddedSIMActivationCodePool CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EmbeddedSIMActivationCodePool();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activationCodeCount", n => { ActivationCodeCount = n.GetIntValue(); } },
                {"activationCodes", n => { ActivationCodes = n.GetCollectionOfObjectValues<EmbeddedSIMActivationCode>(EmbeddedSIMActivationCode.CreateFromDiscriminatorValue).ToList(); } },
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<EmbeddedSIMActivationCodePoolAssignment>(EmbeddedSIMActivationCodePoolAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deviceStates", n => { DeviceStates = n.GetCollectionOfObjectValues<EmbeddedSIMDeviceState>(EmbeddedSIMDeviceState.CreateFromDiscriminatorValue).ToList(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"modifiedDateTime", n => { ModifiedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("activationCodeCount", ActivationCodeCount);
            writer.WriteCollectionOfObjectValues<EmbeddedSIMActivationCode>("activationCodes", ActivationCodes);
            writer.WriteCollectionOfObjectValues<EmbeddedSIMActivationCodePoolAssignment>("assignments", Assignments);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<EmbeddedSIMDeviceState>("deviceStates", DeviceStates);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("modifiedDateTime", ModifiedDateTime);
        }
    }
}
