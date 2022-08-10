using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Contains statistics into how the organizational message was interacted with by clients</summary>
    public class OrganizationalMessageInsights : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The number of times this message was clicked on</summary>
        public int? Clicks {
            get { return BackingStore?.Get<int?>("clicks"); }
            set { BackingStore?.Set("clicks", value); }
        }
        /// <summary>The number of times this message was dismissed by a user. This may not be collected for some surfaces and will be null</summary>
        public int? Dismisses {
            get { return BackingStore?.Get<int?>("dismisses"); }
            set { BackingStore?.Set("dismisses", value); }
        }
        /// <summary>The number of times this message was shown to all clients</summary>
        public int? Impressions {
            get { return BackingStore?.Get<int?>("impressions"); }
            set { BackingStore?.Set("impressions", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>
        /// Instantiates a new organizationalMessageInsights and sets the default values.
        /// </summary>
        public OrganizationalMessageInsights() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.organizationalMessageInsights";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static OrganizationalMessageInsights CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OrganizationalMessageInsights();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"clicks", n => { Clicks = n.GetIntValue(); } },
                {"dismisses", n => { Dismisses = n.GetIntValue(); } },
                {"impressions", n => { Impressions = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("clicks", Clicks);
            writer.WriteIntValue("dismisses", Dismisses);
            writer.WriteIntValue("impressions", Impressions);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
