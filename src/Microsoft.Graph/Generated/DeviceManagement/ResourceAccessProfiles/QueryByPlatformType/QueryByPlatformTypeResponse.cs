using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.DeviceManagement.ResourceAccessProfiles.QueryByPlatformType {
    /// <summary>Provides operations to call the queryByPlatformType method.</summary>
    public class QueryByPlatformTypeResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The value property</summary>
        public List<DeviceManagementResourceAccessProfileBase> Value { get; set; }
        /// <summary>
        /// Instantiates a new queryByPlatformTypeResponse and sets the default values.
        /// </summary>
        public QueryByPlatformTypeResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static QueryByPlatformTypeResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new QueryByPlatformTypeResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"value", (o,n) => { (o as QueryByPlatformTypeResponse).Value = n.GetCollectionOfObjectValues<DeviceManagementResourceAccessProfileBase>(DeviceManagementResourceAccessProfileBase.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<DeviceManagementResourceAccessProfileBase>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
