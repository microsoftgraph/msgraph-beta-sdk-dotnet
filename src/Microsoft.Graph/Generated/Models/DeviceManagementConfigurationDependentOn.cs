using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementConfigurationDependentOn : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Identifier of parent setting/ parent setting option dependent on</summary>
        public string DependentOn {
            get { return BackingStore?.Get<string>(nameof(DependentOn)); }
            set { BackingStore?.Set(nameof(DependentOn), value); }
        }
        /// <summary>Identifier of parent setting/ parent setting id dependent on</summary>
        public string ParentSettingId {
            get { return BackingStore?.Get<string>(nameof(ParentSettingId)); }
            set { BackingStore?.Set(nameof(ParentSettingId), value); }
        }
        /// <summary>
        /// Instantiates a new deviceManagementConfigurationDependentOn and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationDependentOn() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceManagementConfigurationDependentOn CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationDependentOn();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"dependentOn", n => { DependentOn = n.GetStringValue(); } },
                {"parentSettingId", n => { ParentSettingId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("dependentOn", DependentOn);
            writer.WriteStringValue("parentSettingId", ParentSettingId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
