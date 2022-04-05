using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementResourceAccessProfileBaseCollectionResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The nextLink property</summary>
        public string NextLink { get; set; }
        /// <summary>The value property</summary>
        public List<DeviceManagementResourceAccessProfileBase> Value { get; set; }
        /// <summary>
        /// Instantiates a new DeviceManagementResourceAccessProfileBaseCollectionResponse and sets the default values.
        /// </summary>
        public DeviceManagementResourceAccessProfileBaseCollectionResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceManagementResourceAccessProfileBaseCollectionResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementResourceAccessProfileBaseCollectionResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"@odata.nextLink", (o,n) => { (o as DeviceManagementResourceAccessProfileBaseCollectionResponse).NextLink = n.GetStringValue(); } },
                {"value", (o,n) => { (o as DeviceManagementResourceAccessProfileBaseCollectionResponse).Value = n.GetCollectionOfObjectValues<DeviceManagementResourceAccessProfileBase>(DeviceManagementResourceAccessProfileBase.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.nextLink", NextLink);
            writer.WriteCollectionOfObjectValues<DeviceManagementResourceAccessProfileBase>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
