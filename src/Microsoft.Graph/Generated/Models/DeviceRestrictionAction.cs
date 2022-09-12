using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceRestrictionAction : DlpActionInfo, IParsable {
        /// <summary>The message property</summary>
        public string Message {
            get { return BackingStore?.Get<string>("message"); }
            set { BackingStore?.Set("message", value); }
        }
        /// <summary>The restrictionAction property</summary>
        public Microsoft.Graph.Beta.Models.RestrictionAction? RestrictionAction {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.RestrictionAction?>("restrictionAction"); }
            set { BackingStore?.Set("restrictionAction", value); }
        }
        /// <summary>The triggers property</summary>
        public List<string> Triggers {
            get { return BackingStore?.Get<List<string>>("triggers"); }
            set { BackingStore?.Set("triggers", value); }
        }
        /// <summary>
        /// Instantiates a new DeviceRestrictionAction and sets the default values.
        /// </summary>
        public DeviceRestrictionAction() : base() {
            OdataType = "#microsoft.graph.deviceRestrictionAction";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceRestrictionAction CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceRestrictionAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"message", n => { Message = n.GetStringValue(); } },
                {"restrictionAction", n => { RestrictionAction = n.GetEnumValue<RestrictionAction>(); } },
                {"triggers", n => { Triggers = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("message", Message);
            writer.WriteEnumValue<RestrictionAction>("restrictionAction", RestrictionAction);
            writer.WriteCollectionOfPrimitiveValues<string>("triggers", Triggers);
        }
    }
}
