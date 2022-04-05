using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceManagement.UserExperienceAnalyticsResourcePerformance.SummarizeDeviceResourcePerformanceWithSummarizeBy {
    /// <summary>Provides operations to call the summarizeDeviceResourcePerformance method.</summary>
    public class SummarizeDeviceResourcePerformanceWithSummarizeByResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The value property</summary>
        public List<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsResourcePerformance> Value { get; set; }
        /// <summary>
        /// Instantiates a new summarizeDeviceResourcePerformanceWithSummarizeByResponse and sets the default values.
        /// </summary>
        public SummarizeDeviceResourcePerformanceWithSummarizeByResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SummarizeDeviceResourcePerformanceWithSummarizeByResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SummarizeDeviceResourcePerformanceWithSummarizeByResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"value", (o,n) => { (o as SummarizeDeviceResourcePerformanceWithSummarizeByResponse).Value = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsResourcePerformance>(Microsoft.Graph.Beta.Models.UserExperienceAnalyticsResourcePerformance.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsResourcePerformance>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
