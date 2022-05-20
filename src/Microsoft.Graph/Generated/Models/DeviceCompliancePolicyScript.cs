using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceCompliancePolicyScript : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Device compliance script Id.</summary>
        public string DeviceComplianceScriptId {
            get { return BackingStore?.Get<string>(nameof(DeviceComplianceScriptId)); }
            set { BackingStore?.Set(nameof(DeviceComplianceScriptId), value); }
        }
        /// <summary>Json of the rules.</summary>
        public byte[] RulesContent {
            get { return BackingStore?.Get<byte[]>(nameof(RulesContent)); }
            set { BackingStore?.Set(nameof(RulesContent), value); }
        }
        /// <summary>
        /// Instantiates a new deviceCompliancePolicyScript and sets the default values.
        /// </summary>
        public DeviceCompliancePolicyScript() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceCompliancePolicyScript CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceCompliancePolicyScript();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"deviceComplianceScriptId", n => { DeviceComplianceScriptId = n.GetStringValue(); } },
                {"rulesContent", n => { RulesContent = n.GetByteArrayValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("deviceComplianceScriptId", DeviceComplianceScriptId);
            writer.WriteByteArrayValue("rulesContent", RulesContent);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
