using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Metric Time series data point</summary>
    public class MetricTimeSeriesDataPoint : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Time of the metric time series data point</summary>
        public DateTimeOffset? DateTime { get; set; }
        /// <summary>Value of the metric time series data point</summary>
        public long? Value { get; set; }
        /// <summary>
        /// Instantiates a new metricTimeSeriesDataPoint and sets the default values.
        /// </summary>
        public MetricTimeSeriesDataPoint() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static MetricTimeSeriesDataPoint CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MetricTimeSeriesDataPoint();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"dateTime", (o,n) => { (o as MetricTimeSeriesDataPoint).DateTime = n.GetDateTimeOffsetValue(); } },
                {"value", (o,n) => { (o as MetricTimeSeriesDataPoint).Value = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("dateTime", DateTime);
            writer.WriteLongValue("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
