using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceRestrictionAction : DlpActionInfo, IParsable {
        /// <summary>The message property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Message {
            get { return BackingStore?.Get<string?>("message"); }
            set { BackingStore?.Set("message", value); }
        }
#nullable restore
#else
        public string Message {
            get { return BackingStore?.Get<string>("message"); }
            set { BackingStore?.Set("message", value); }
        }
#endif
        /// <summary>The restrictionAction property</summary>
        public Microsoft.Graph.Beta.Models.RestrictionAction? RestrictionAction {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.RestrictionAction?>("restrictionAction"); }
            set { BackingStore?.Set("restrictionAction", value); }
        }
        /// <summary>The triggers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RestrictionTrigger?>? Triggers {
            get { return BackingStore?.Get<List<RestrictionTrigger?>?>("triggers"); }
            set { BackingStore?.Set("triggers", value); }
        }
#nullable restore
#else
        public List<RestrictionTrigger?> Triggers {
            get { return BackingStore?.Get<List<RestrictionTrigger?>>("triggers"); }
            set { BackingStore?.Set("triggers", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
                {"triggers", n => { Triggers = n.GetCollectionOfEnumValues<RestrictionTrigger>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("message", Message);
            writer.WriteEnumValue<RestrictionAction>("restrictionAction", RestrictionAction);
            writer.WriteCollectionOfEnumValues<RestrictionTrigger>("triggers", Triggers);
        }
    }
}
