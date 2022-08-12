using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Contains the required size dimensions of a logo</summary>
    public class OrganizationalMessageLogoDimensions : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Maximum height of the logo</summary>
        public int? MaxHeight {
            get { return BackingStore?.Get<int?>("maxHeight"); }
            set { BackingStore?.Set("maxHeight", value); }
        }
        /// <summary>Maximum width of the logo</summary>
        public int? MaxWidth {
            get { return BackingStore?.Get<int?>("maxWidth"); }
            set { BackingStore?.Set("maxWidth", value); }
        }
        /// <summary>Minimum height of the logo</summary>
        public int? MinHeight {
            get { return BackingStore?.Get<int?>("minHeight"); }
            set { BackingStore?.Set("minHeight", value); }
        }
        /// <summary>Minimum width of the logo</summary>
        public int? MinWidth {
            get { return BackingStore?.Get<int?>("minWidth"); }
            set { BackingStore?.Set("minWidth", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>
        /// Instantiates a new organizationalMessageLogoDimensions and sets the default values.
        /// </summary>
        public OrganizationalMessageLogoDimensions() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.organizationalMessageLogoDimensions";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static OrganizationalMessageLogoDimensions CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OrganizationalMessageLogoDimensions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"maxHeight", n => { MaxHeight = n.GetIntValue(); } },
                {"maxWidth", n => { MaxWidth = n.GetIntValue(); } },
                {"minHeight", n => { MinHeight = n.GetIntValue(); } },
                {"minWidth", n => { MinWidth = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("maxHeight", MaxHeight);
            writer.WriteIntValue("maxWidth", MaxWidth);
            writer.WriteIntValue("minHeight", MinHeight);
            writer.WriteIntValue("minWidth", MinWidth);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
