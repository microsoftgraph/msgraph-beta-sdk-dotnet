using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to call the getHealthMetricTimeSeries method.</summary>
    public class CertificateConnectorHealthMetricValue : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Timestamp for this metric data-point.</summary>
        public DateTimeOffset? DateTime { get; set; }
        /// <summary>Count of failed requests/operations.</summary>
        public int? FailureCount { get; set; }
        /// <summary>Count of successful requests/operations.</summary>
        public int? SuccessCount { get; set; }
        /// <summary>
        /// Instantiates a new certificateConnectorHealthMetricValue and sets the default values.
        /// </summary>
        public CertificateConnectorHealthMetricValue() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CertificateConnectorHealthMetricValue CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CertificateConnectorHealthMetricValue();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"dateTime", (o,n) => { (o as CertificateConnectorHealthMetricValue).DateTime = n.GetDateTimeOffsetValue(); } },
                {"failureCount", (o,n) => { (o as CertificateConnectorHealthMetricValue).FailureCount = n.GetIntValue(); } },
                {"successCount", (o,n) => { (o as CertificateConnectorHealthMetricValue).SuccessCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("dateTime", DateTime);
            writer.WriteIntValue("failureCount", FailureCount);
            writer.WriteIntValue("successCount", SuccessCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
