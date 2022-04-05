using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceManagement.ResourceAccessProfiles.QueryByPlatformType {
    /// <summary>Provides operations to call the queryByPlatformType method.</summary>
    public class QueryByPlatformTypeRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The platformType property</summary>
        public PolicyPlatformType? PlatformType { get; set; }
        /// <summary>
        /// Instantiates a new queryByPlatformTypeRequestBody and sets the default values.
        /// </summary>
        public QueryByPlatformTypeRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static QueryByPlatformTypeRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new QueryByPlatformTypeRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"platformType", (o,n) => { (o as QueryByPlatformTypeRequestBody).PlatformType = n.GetEnumValue<PolicyPlatformType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<PolicyPlatformType>("platformType", PlatformType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
