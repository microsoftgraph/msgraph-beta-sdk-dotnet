using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>A configuration entity for MEM features that utilize Data Processor Service for Windows (DPSW) data.</summary>
    public class DataProcessorServiceForWindowsFeaturesOnboarding : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Indicates whether the tenant has enabled MEM features utilizing Data Processor Service for Windows (DPSW) data. When TRUE, the tenant has enabled MEM features utilizing Data Processor Service for Windows (DPSW) data. When FALSE, the tenant has not enabled MEM features utilizing Data Processor Service for Windows (DPSW) data. Default value is FALSE.</summary>
        public bool? AreDataProcessorServiceForWindowsFeaturesEnabled {
            get { return BackingStore?.Get<bool?>("areDataProcessorServiceForWindowsFeaturesEnabled"); }
            set { BackingStore?.Set("areDataProcessorServiceForWindowsFeaturesEnabled", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Indicates whether the tenant has required Windows license. When TRUE, the tenant has the required Windows license. When FALSE, the tenant does not have the required Windows license. Default value is FALSE.</summary>
        public bool? HasValidWindowsLicense {
            get { return BackingStore?.Get<bool?>("hasValidWindowsLicense"); }
            set { BackingStore?.Set("hasValidWindowsLicense", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>
        /// Instantiates a new dataProcessorServiceForWindowsFeaturesOnboarding and sets the default values.
        /// </summary>
        public DataProcessorServiceForWindowsFeaturesOnboarding() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.dataProcessorServiceForWindowsFeaturesOnboarding";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DataProcessorServiceForWindowsFeaturesOnboarding CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DataProcessorServiceForWindowsFeaturesOnboarding();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"areDataProcessorServiceForWindowsFeaturesEnabled", n => { AreDataProcessorServiceForWindowsFeaturesEnabled = n.GetBoolValue(); } },
                {"hasValidWindowsLicense", n => { HasValidWindowsLicense = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("areDataProcessorServiceForWindowsFeaturesEnabled", AreDataProcessorServiceForWindowsFeaturesEnabled);
            writer.WriteBoolValue("hasValidWindowsLicense", HasValidWindowsLicense);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
