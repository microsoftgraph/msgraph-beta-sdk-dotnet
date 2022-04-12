using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class UserExperienceAnalyticsBatteryHealthDeviceAppImpactCollectionResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The nextLink property</summary>
        public string NextLink { get; set; }
        /// <summary>The value property</summary>
        public List<UserExperienceAnalyticsBatteryHealthDeviceAppImpact> Value { get; set; }
        /// <summary>
        /// Instantiates a new UserExperienceAnalyticsBatteryHealthDeviceAppImpactCollectionResponse and sets the default values.
        /// </summary>
        public UserExperienceAnalyticsBatteryHealthDeviceAppImpactCollectionResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UserExperienceAnalyticsBatteryHealthDeviceAppImpactCollectionResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsBatteryHealthDeviceAppImpactCollectionResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.nextLink", n => { NextLink = n.GetStringValue(); } },
                {"value", n => { Value = n.GetCollectionOfObjectValues<UserExperienceAnalyticsBatteryHealthDeviceAppImpact>(UserExperienceAnalyticsBatteryHealthDeviceAppImpact.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.nextLink", NextLink);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsBatteryHealthDeviceAppImpact>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
