using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.DataClassification.ExactMatchDataStores.Item.Lookup {
    /// <summary>Provides operations to call the lookup method.</summary>
    public class LookupRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The key property</summary>
        public string Key { get; set; }
        /// <summary>The resultColumnNames property</summary>
        public List<string> ResultColumnNames { get; set; }
        /// <summary>The values property</summary>
        public List<string> Values { get; set; }
        /// <summary>
        /// Instantiates a new lookupRequestBody and sets the default values.
        /// </summary>
        public LookupRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static LookupRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new LookupRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"key", (o,n) => { (o as LookupRequestBody).Key = n.GetStringValue(); } },
                {"resultColumnNames", (o,n) => { (o as LookupRequestBody).ResultColumnNames = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"values", (o,n) => { (o as LookupRequestBody).Values = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("key", Key);
            writer.WriteCollectionOfPrimitiveValues<string>("resultColumnNames", ResultColumnNames);
            writer.WriteCollectionOfPrimitiveValues<string>("values", Values);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
