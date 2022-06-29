using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementSettingCollectionConstraint : DeviceManagementConstraint, IParsable {
        /// <summary>The maximum number of elements in the collection</summary>
        public int? MaximumLength {
            get { return BackingStore?.Get<int?>(nameof(MaximumLength)); }
            set { BackingStore?.Set(nameof(MaximumLength), value); }
        }
        /// <summary>The minimum number of elements in the collection</summary>
        public int? MinimumLength {
            get { return BackingStore?.Get<int?>(nameof(MinimumLength)); }
            set { BackingStore?.Set(nameof(MinimumLength), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementSettingCollectionConstraint CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementSettingCollectionConstraint();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"maximumLength", n => { MaximumLength = n.GetIntValue(); } },
                {"minimumLength", n => { MinimumLength = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("maximumLength", MaximumLength);
            writer.WriteIntValue("minimumLength", MinimumLength);
        }
    }
}
