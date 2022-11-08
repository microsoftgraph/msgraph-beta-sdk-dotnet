using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AlterationResponse : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>Defines the original user query string.</summary>
        public string OriginalQueryString {
            get { return BackingStore?.Get<string>("originalQueryString"); }
            set { BackingStore?.Set("originalQueryString", value); }
        }
        /// <summary>Defines the details of alteration information for the spelling correction.</summary>
        public SearchAlteration QueryAlteration {
            get { return BackingStore?.Get<SearchAlteration>("queryAlteration"); }
            set { BackingStore?.Set("queryAlteration", value); }
        }
        /// <summary>Defines the type of the spelling correction. Possible values are suggestion, modification.</summary>
        public SearchAlterationType? QueryAlterationType {
            get { return BackingStore?.Get<SearchAlterationType?>("queryAlterationType"); }
            set { BackingStore?.Set("queryAlterationType", value); }
        }
        /// <summary>
        /// Instantiates a new alterationResponse and sets the default values.
        /// </summary>
        public AlterationResponse() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.alterationResponse";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AlterationResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AlterationResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"originalQueryString", n => { OriginalQueryString = n.GetStringValue(); } },
                {"queryAlteration", n => { QueryAlteration = n.GetObjectValue<SearchAlteration>(SearchAlteration.CreateFromDiscriminatorValue); } },
                {"queryAlterationType", n => { QueryAlterationType = n.GetEnumValue<SearchAlterationType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("originalQueryString", OriginalQueryString);
            writer.WriteObjectValue<SearchAlteration>("queryAlteration", QueryAlteration);
            writer.WriteEnumValue<SearchAlterationType>("queryAlterationType", QueryAlterationType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
