using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceManagement.CertificateConnectorDetails.Item.MicrosoftGraphGetHealthMetricTimeSeries {
    public class GetHealthMetricTimeSeriesPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The timeSeries property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TimeSeriesParameter? TimeSeries {
            get { return BackingStore?.Get<TimeSeriesParameter?>("timeSeries"); }
            set { BackingStore?.Set("timeSeries", value); }
        }
#nullable restore
#else
        public TimeSeriesParameter TimeSeries {
            get { return BackingStore?.Get<TimeSeriesParameter>("timeSeries"); }
            set { BackingStore?.Set("timeSeries", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new getHealthMetricTimeSeriesPostRequestBody and sets the default values.
        /// </summary>
        public GetHealthMetricTimeSeriesPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static GetHealthMetricTimeSeriesPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GetHealthMetricTimeSeriesPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"timeSeries", n => { TimeSeries = n.GetObjectValue<TimeSeriesParameter>(TimeSeriesParameter.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<TimeSeriesParameter>("timeSeries", TimeSeries);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
