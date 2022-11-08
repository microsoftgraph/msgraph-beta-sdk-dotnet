using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Represents one item in the list of freeze periods for Android Device Owner system updates</summary>
    public class AndroidDeviceOwnerSystemUpdateFreezePeriod : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The day of the end date of the freeze period. Valid values 1 to 31</summary>
        public int? EndDay {
            get { return BackingStore?.Get<int?>("endDay"); }
            set { BackingStore?.Set("endDay", value); }
        }
        /// <summary>The month of the end date of the freeze period. Valid values 1 to 12</summary>
        public int? EndMonth {
            get { return BackingStore?.Get<int?>("endMonth"); }
            set { BackingStore?.Set("endMonth", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The day of the start date of the freeze period. Valid values 1 to 31</summary>
        public int? StartDay {
            get { return BackingStore?.Get<int?>("startDay"); }
            set { BackingStore?.Set("startDay", value); }
        }
        /// <summary>The month of the start date of the freeze period. Valid values 1 to 12</summary>
        public int? StartMonth {
            get { return BackingStore?.Get<int?>("startMonth"); }
            set { BackingStore?.Set("startMonth", value); }
        }
        /// <summary>
        /// Instantiates a new androidDeviceOwnerSystemUpdateFreezePeriod and sets the default values.
        /// </summary>
        public AndroidDeviceOwnerSystemUpdateFreezePeriod() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.androidDeviceOwnerSystemUpdateFreezePeriod";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AndroidDeviceOwnerSystemUpdateFreezePeriod CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidDeviceOwnerSystemUpdateFreezePeriod();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"endDay", n => { EndDay = n.GetIntValue(); } },
                {"endMonth", n => { EndMonth = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"startDay", n => { StartDay = n.GetIntValue(); } },
                {"startMonth", n => { StartMonth = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("endDay", EndDay);
            writer.WriteIntValue("endMonth", EndMonth);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("startDay", StartDay);
            writer.WriteIntValue("startMonth", StartMonth);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
