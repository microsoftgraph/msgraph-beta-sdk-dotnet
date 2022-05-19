using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Photo : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Camera manufacturer. Read-only.</summary>
        public string CameraMake {
            get { return BackingStore?.Get<string>(nameof(CameraMake)); }
            set { BackingStore?.Set(nameof(CameraMake), value); }
        }
        /// <summary>Camera model. Read-only.</summary>
        public string CameraModel {
            get { return BackingStore?.Get<string>(nameof(CameraModel)); }
            set { BackingStore?.Set(nameof(CameraModel), value); }
        }
        /// <summary>The denominator for the exposure time fraction from the camera. Read-only.</summary>
        public double? ExposureDenominator {
            get { return BackingStore?.Get<double?>(nameof(ExposureDenominator)); }
            set { BackingStore?.Set(nameof(ExposureDenominator), value); }
        }
        /// <summary>The numerator for the exposure time fraction from the camera. Read-only.</summary>
        public double? ExposureNumerator {
            get { return BackingStore?.Get<double?>(nameof(ExposureNumerator)); }
            set { BackingStore?.Set(nameof(ExposureNumerator), value); }
        }
        /// <summary>The F-stop value from the camera. Read-only.</summary>
        public double? FNumber {
            get { return BackingStore?.Get<double?>(nameof(FNumber)); }
            set { BackingStore?.Set(nameof(FNumber), value); }
        }
        /// <summary>The focal length from the camera. Read-only.</summary>
        public double? FocalLength {
            get { return BackingStore?.Get<double?>(nameof(FocalLength)); }
            set { BackingStore?.Set(nameof(FocalLength), value); }
        }
        /// <summary>The ISO value from the camera. Read-only.</summary>
        public int? Iso {
            get { return BackingStore?.Get<int?>(nameof(Iso)); }
            set { BackingStore?.Set(nameof(Iso), value); }
        }
        /// <summary>The orientation value from the camera. Writable on OneDrive Personal.</summary>
        public int? Orientation {
            get { return BackingStore?.Get<int?>(nameof(Orientation)); }
            set { BackingStore?.Set(nameof(Orientation), value); }
        }
        /// <summary>The date and time the photo was taken in UTC time. Read-only.</summary>
        public DateTimeOffset? TakenDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(TakenDateTime)); }
            set { BackingStore?.Set(nameof(TakenDateTime), value); }
        }
        /// <summary>
        /// Instantiates a new photo and sets the default values.
        /// </summary>
        public Photo() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static Photo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Photo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"cameraMake", n => { CameraMake = n.GetStringValue(); } },
                {"cameraModel", n => { CameraModel = n.GetStringValue(); } },
                {"exposureDenominator", n => { ExposureDenominator = n.GetDoubleValue(); } },
                {"exposureNumerator", n => { ExposureNumerator = n.GetDoubleValue(); } },
                {"fNumber", n => { FNumber = n.GetDoubleValue(); } },
                {"focalLength", n => { FocalLength = n.GetDoubleValue(); } },
                {"iso", n => { Iso = n.GetIntValue(); } },
                {"orientation", n => { Orientation = n.GetIntValue(); } },
                {"takenDateTime", n => { TakenDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("cameraMake", CameraMake);
            writer.WriteStringValue("cameraModel", CameraModel);
            writer.WriteDoubleValue("exposureDenominator", ExposureDenominator);
            writer.WriteDoubleValue("exposureNumerator", ExposureNumerator);
            writer.WriteDoubleValue("fNumber", FNumber);
            writer.WriteDoubleValue("focalLength", FocalLength);
            writer.WriteIntValue("iso", Iso);
            writer.WriteIntValue("orientation", Orientation);
            writer.WriteDateTimeOffsetValue("takenDateTime", TakenDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
