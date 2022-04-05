using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class SecurityBaselineSettingStateCollectionResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The nextLink property</summary>
        public string NextLink { get; set; }
        /// <summary>The value property</summary>
        public List<SecurityBaselineSettingState> Value { get; set; }
        /// <summary>
        /// Instantiates a new SecurityBaselineSettingStateCollectionResponse and sets the default values.
        /// </summary>
        public SecurityBaselineSettingStateCollectionResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SecurityBaselineSettingStateCollectionResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SecurityBaselineSettingStateCollectionResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"@odata.nextLink", (o,n) => { (o as SecurityBaselineSettingStateCollectionResponse).NextLink = n.GetStringValue(); } },
                {"value", (o,n) => { (o as SecurityBaselineSettingStateCollectionResponse).Value = n.GetCollectionOfObjectValues<SecurityBaselineSettingState>(SecurityBaselineSettingState.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.nextLink", NextLink);
            writer.WriteCollectionOfObjectValues<SecurityBaselineSettingState>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
