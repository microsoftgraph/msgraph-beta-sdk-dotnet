using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CloudPcHealthCheckItem : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The additionalDetails property</summary>
        public string AdditionalDetails {
            get { return BackingStore?.Get<string>("additionalDetails"); }
            set { BackingStore?.Set("additionalDetails", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The displayName property</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The lastHealthCheckDateTime property</summary>
        public DateTimeOffset? LastHealthCheckDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastHealthCheckDateTime"); }
            set { BackingStore?.Set("lastHealthCheckDateTime", value); }
        }
        /// <summary>The result property</summary>
        public CloudPcConnectivityEventResult? Result {
            get { return BackingStore?.Get<CloudPcConnectivityEventResult?>("result"); }
            set { BackingStore?.Set("result", value); }
        }
        /// <summary>
        /// Instantiates a new cloudPcHealthCheckItem and sets the default values.
        /// </summary>
        public CloudPcHealthCheckItem() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CloudPcHealthCheckItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcHealthCheckItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"additionalDetails", n => { AdditionalDetails = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastHealthCheckDateTime", n => { LastHealthCheckDateTime = n.GetDateTimeOffsetValue(); } },
                {"result", n => { Result = n.GetEnumValue<CloudPcConnectivityEventResult>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("additionalDetails", AdditionalDetails);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastHealthCheckDateTime", LastHealthCheckDateTime);
            writer.WriteEnumValue<CloudPcConnectivityEventResult>("result", Result);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
