using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ProtectOnlineMeetingAction : LabelActionBase, IParsable {
        /// <summary>The allowedForwarders property</summary>
        public OnlineMeetingForwarders? AllowedForwarders {
            get { return BackingStore?.Get<OnlineMeetingForwarders?>("allowedForwarders"); }
            set { BackingStore?.Set("allowedForwarders", value); }
        }
        /// <summary>The allowedPresenters property</summary>
        public OnlineMeetingPresenters? AllowedPresenters {
            get { return BackingStore?.Get<OnlineMeetingPresenters?>("allowedPresenters"); }
            set { BackingStore?.Set("allowedPresenters", value); }
        }
        /// <summary>The isCopyToClipboardEnabled property</summary>
        public bool? IsCopyToClipboardEnabled {
            get { return BackingStore?.Get<bool?>("isCopyToClipboardEnabled"); }
            set { BackingStore?.Set("isCopyToClipboardEnabled", value); }
        }
        /// <summary>The isLobbyEnabled property</summary>
        public bool? IsLobbyEnabled {
            get { return BackingStore?.Get<bool?>("isLobbyEnabled"); }
            set { BackingStore?.Set("isLobbyEnabled", value); }
        }
        /// <summary>The lobbyBypassSettings property</summary>
        public Microsoft.Graph.Beta.Models.LobbyBypassSettings LobbyBypassSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.LobbyBypassSettings>("lobbyBypassSettings"); }
            set { BackingStore?.Set("lobbyBypassSettings", value); }
        }
        /// <summary>
        /// Instantiates a new ProtectOnlineMeetingAction and sets the default values.
        /// </summary>
        public ProtectOnlineMeetingAction() : base() {
            OdataType = "#microsoft.graph.protectOnlineMeetingAction";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ProtectOnlineMeetingAction CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ProtectOnlineMeetingAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowedForwarders", n => { AllowedForwarders = n.GetEnumValue<OnlineMeetingForwarders>(); } },
                {"allowedPresenters", n => { AllowedPresenters = n.GetEnumValue<OnlineMeetingPresenters>(); } },
                {"isCopyToClipboardEnabled", n => { IsCopyToClipboardEnabled = n.GetBoolValue(); } },
                {"isLobbyEnabled", n => { IsLobbyEnabled = n.GetBoolValue(); } },
                {"lobbyBypassSettings", n => { LobbyBypassSettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.LobbyBypassSettings>(Microsoft.Graph.Beta.Models.LobbyBypassSettings.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<OnlineMeetingForwarders>("allowedForwarders", AllowedForwarders);
            writer.WriteEnumValue<OnlineMeetingPresenters>("allowedPresenters", AllowedPresenters);
            writer.WriteBoolValue("isCopyToClipboardEnabled", IsCopyToClipboardEnabled);
            writer.WriteBoolValue("isLobbyEnabled", IsLobbyEnabled);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.LobbyBypassSettings>("lobbyBypassSettings", LobbyBypassSettings);
        }
    }
}
