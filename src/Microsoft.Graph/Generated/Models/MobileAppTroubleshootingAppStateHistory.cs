using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MobileAppTroubleshootingAppStateHistory : MobileAppTroubleshootingHistoryItem, IParsable {
        /// <summary>Action type for Intune Application. Possible values are: unknown, installCommandSent, installed, uninstalled, userRequestedInstall.</summary>
        public MobileAppActionType? ActionType {
            get { return BackingStore?.Get<MobileAppActionType?>(nameof(ActionType)); }
            set { BackingStore?.Set(nameof(ActionType), value); }
        }
        /// <summary>Error code for the failure, empty if no failure.</summary>
        public string ErrorCode {
            get { return BackingStore?.Get<string>(nameof(ErrorCode)); }
            set { BackingStore?.Set(nameof(ErrorCode), value); }
        }
        /// <summary>Status of the item. Possible values are: unknown, success, fail, scriptError, pending, notApplicable.</summary>
        public Microsoft.Graph.Beta.Models.RunState? RunState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.RunState?>(nameof(RunState)); }
            set { BackingStore?.Set(nameof(RunState), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MobileAppTroubleshootingAppStateHistory CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MobileAppTroubleshootingAppStateHistory();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"actionType", n => { ActionType = n.GetEnumValue<MobileAppActionType>(); } },
                {"errorCode", n => { ErrorCode = n.GetStringValue(); } },
                {"runState", n => { RunState = n.GetEnumValue<RunState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<MobileAppActionType>("actionType", ActionType);
            writer.WriteStringValue("errorCode", ErrorCode);
            writer.WriteEnumValue<RunState>("runState", RunState);
        }
    }
}
