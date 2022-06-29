using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementSettingAbstractImplementationConstraint : DeviceManagementConstraint, IParsable {
        /// <summary>List of value which means not configured for the setting</summary>
        public List<string> AllowedAbstractImplementationDefinitionIds {
            get { return BackingStore?.Get<List<string>>(nameof(AllowedAbstractImplementationDefinitionIds)); }
            set { BackingStore?.Set(nameof(AllowedAbstractImplementationDefinitionIds), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementSettingAbstractImplementationConstraint CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementSettingAbstractImplementationConstraint();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowedAbstractImplementationDefinitionIds", n => { AllowedAbstractImplementationDefinitionIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("allowedAbstractImplementationDefinitionIds", AllowedAbstractImplementationDefinitionIds);
        }
    }
}
