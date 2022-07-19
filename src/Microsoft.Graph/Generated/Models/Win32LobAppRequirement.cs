using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Base class to detect a Win32 App</summary>
    public class Win32LobAppRequirement : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The detection value</summary>
        public string DetectionValue {
            get { return BackingStore?.Get<string>("detectionValue"); }
            set { BackingStore?.Set("detectionValue", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>Contains properties for detection operator.</summary>
        public Win32LobAppDetectionOperator? Operator {
            get { return BackingStore?.Get<Win32LobAppDetectionOperator?>("operator"); }
            set { BackingStore?.Set("operator", value); }
        }
        /// <summary>
        /// Instantiates a new win32LobAppRequirement and sets the default values.
        /// </summary>
        public Win32LobAppRequirement() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.win32LobAppRequirement";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static Win32LobAppRequirement CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.win32LobAppFileSystemRequirement" => new Win32LobAppFileSystemRequirement(),
                "#microsoft.graph.win32LobAppPowerShellScriptRequirement" => new Win32LobAppPowerShellScriptRequirement(),
                "#microsoft.graph.win32LobAppRegistryRequirement" => new Win32LobAppRegistryRequirement(),
                _ => new Win32LobAppRequirement(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"detectionValue", n => { DetectionValue = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"operator", n => { Operator = n.GetEnumValue<Win32LobAppDetectionOperator>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("detectionValue", DetectionValue);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<Win32LobAppDetectionOperator>("operator", Operator);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
