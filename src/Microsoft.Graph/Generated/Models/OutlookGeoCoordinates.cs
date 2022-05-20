using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class OutlookGeoCoordinates : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>The accuracy of the latitude and longitude. As an example, the accuracy can be measured in meters, such as the latitude and longitude are accurate to within 50 meters.</summary>
        public double? Accuracy {
            get { return BackingStore?.Get<double?>(nameof(Accuracy)); }
            set { BackingStore?.Set(nameof(Accuracy), value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>The altitude of the location.</summary>
        public double? Altitude {
            get { return BackingStore?.Get<double?>(nameof(Altitude)); }
            set { BackingStore?.Set(nameof(Altitude), value); }
        }
        /// <summary>The accuracy of the altitude.</summary>
        public double? AltitudeAccuracy {
            get { return BackingStore?.Get<double?>(nameof(AltitudeAccuracy)); }
            set { BackingStore?.Set(nameof(AltitudeAccuracy), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The latitude of the location.</summary>
        public double? Latitude {
            get { return BackingStore?.Get<double?>(nameof(Latitude)); }
            set { BackingStore?.Set(nameof(Latitude), value); }
        }
        /// <summary>The longitude of the location.</summary>
        public double? Longitude {
            get { return BackingStore?.Get<double?>(nameof(Longitude)); }
            set { BackingStore?.Set(nameof(Longitude), value); }
        }
        /// <summary>
        /// Instantiates a new outlookGeoCoordinates and sets the default values.
        /// </summary>
        public OutlookGeoCoordinates() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static OutlookGeoCoordinates CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OutlookGeoCoordinates();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"accuracy", n => { Accuracy = n.GetDoubleValue(); } },
                {"altitude", n => { Altitude = n.GetDoubleValue(); } },
                {"altitudeAccuracy", n => { AltitudeAccuracy = n.GetDoubleValue(); } },
                {"latitude", n => { Latitude = n.GetDoubleValue(); } },
                {"longitude", n => { Longitude = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("accuracy", Accuracy);
            writer.WriteDoubleValue("altitude", Altitude);
            writer.WriteDoubleValue("altitudeAccuracy", AltitudeAccuracy);
            writer.WriteDoubleValue("latitude", Latitude);
            writer.WriteDoubleValue("longitude", Longitude);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
