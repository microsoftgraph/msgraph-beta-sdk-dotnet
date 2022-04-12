using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ExactDataMatchStoreColumn : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The ignoredDelimiters property</summary>
        public List<string> IgnoredDelimiters { get; set; }
        /// <summary>The isCaseInsensitive property</summary>
        public bool? IsCaseInsensitive { get; set; }
        /// <summary>The isSearchable property</summary>
        public bool? IsSearchable { get; set; }
        /// <summary>The name property</summary>
        public string Name { get; set; }
        /// <summary>
        /// Instantiates a new exactDataMatchStoreColumn and sets the default values.
        /// </summary>
        public ExactDataMatchStoreColumn() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ExactDataMatchStoreColumn CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExactDataMatchStoreColumn();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"ignoredDelimiters", n => { IgnoredDelimiters = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"isCaseInsensitive", n => { IsCaseInsensitive = n.GetBoolValue(); } },
                {"isSearchable", n => { IsSearchable = n.GetBoolValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("ignoredDelimiters", IgnoredDelimiters);
            writer.WriteBoolValue("isCaseInsensitive", IsCaseInsensitive);
            writer.WriteBoolValue("isSearchable", IsSearchable);
            writer.WriteStringValue("name", Name);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
