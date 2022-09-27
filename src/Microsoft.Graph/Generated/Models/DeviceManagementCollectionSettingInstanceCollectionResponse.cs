using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementCollectionSettingInstanceCollectionResponse : BaseCollectionPaginationCountResponse, IParsable {
        /// <summary>The value property</summary>
        public List<DeviceManagementCollectionSettingInstance> Value {
            get { return BackingStore?.Get<List<DeviceManagementCollectionSettingInstance>>("value"); }
            set { BackingStore?.Set("value", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementCollectionSettingInstanceCollectionResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementCollectionSettingInstanceCollectionResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"value", n => { Value = n.GetCollectionOfObjectValues<DeviceManagementCollectionSettingInstance>(DeviceManagementCollectionSettingInstance.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DeviceManagementCollectionSettingInstance>("value", Value);
        }
    }
}
