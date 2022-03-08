using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the userExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion property of the microsoft.graph.deviceManagement entity.</summary>
    public class UserExperienceAnalyticsAppHealthAppPerformanceByOSVersionCollectionResponse : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string NextLink { get; set; }
        public List<UserExperienceAnalyticsAppHealthAppPerformanceByOSVersion> Value { get; set; }
        /// <summary>
        /// Instantiates a new UserExperienceAnalyticsAppHealthAppPerformanceByOSVersionCollectionResponse and sets the default values.
        /// </summary>
        public UserExperienceAnalyticsAppHealthAppPerformanceByOSVersionCollectionResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UserExperienceAnalyticsAppHealthAppPerformanceByOSVersionCollectionResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsAppHealthAppPerformanceByOSVersionCollectionResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"@odata.nextLink", (o,n) => { (o as UserExperienceAnalyticsAppHealthAppPerformanceByOSVersionCollectionResponse).NextLink = n.GetStringValue(); } },
                {"value", (o,n) => { (o as UserExperienceAnalyticsAppHealthAppPerformanceByOSVersionCollectionResponse).Value = n.GetCollectionOfObjectValues<UserExperienceAnalyticsAppHealthAppPerformanceByOSVersion>(UserExperienceAnalyticsAppHealthAppPerformanceByOSVersion.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.nextLink", NextLink);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsAppHealthAppPerformanceByOSVersion>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
