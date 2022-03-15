using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the b2cUserFlows property of the microsoft.graph.identityContainer entity.</summary>
    public class B2cIdentityUserFlowCollectionResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string NextLink { get; set; }
        public List<B2cIdentityUserFlow> Value { get; set; }
        /// <summary>
        /// Instantiates a new B2cIdentityUserFlowCollectionResponse and sets the default values.
        /// </summary>
        public B2cIdentityUserFlowCollectionResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static B2cIdentityUserFlowCollectionResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new B2cIdentityUserFlowCollectionResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"@odata.nextLink", (o,n) => { (o as B2cIdentityUserFlowCollectionResponse).NextLink = n.GetStringValue(); } },
                {"value", (o,n) => { (o as B2cIdentityUserFlowCollectionResponse).Value = n.GetCollectionOfObjectValues<B2cIdentityUserFlow>(B2cIdentityUserFlow.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.nextLink", NextLink);
            writer.WriteCollectionOfObjectValues<B2cIdentityUserFlow>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
