using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Example logo and its size requirements</summary>
    public class OrganizationalMessageLogoGuide : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The asset name is the key for this specific logo. This is used to compute the required token when accessing the logoCdnUrl to fetch the logo</summary>
        public string AssetName {
            get { return BackingStore?.Get<string>("assetName"); }
            set { BackingStore?.Set("assetName", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The required size dimensions of the logo</summary>
        public OrganizationalMessageLogoDimensions Dimensions {
            get { return BackingStore?.Get<OrganizationalMessageLogoDimensions>("dimensions"); }
            set { BackingStore?.Set("dimensions", value); }
        }
        /// <summary>The url at which the logo resides</summary>
        public string LogoCdnUrl {
            get { return BackingStore?.Get<string>("logoCdnUrl"); }
            set { BackingStore?.Set("logoCdnUrl", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>
        /// Instantiates a new organizationalMessageLogoGuide and sets the default values.
        /// </summary>
        public OrganizationalMessageLogoGuide() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.organizationalMessageLogoGuide";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static OrganizationalMessageLogoGuide CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OrganizationalMessageLogoGuide();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"assetName", n => { AssetName = n.GetStringValue(); } },
                {"dimensions", n => { Dimensions = n.GetObjectValue<OrganizationalMessageLogoDimensions>(OrganizationalMessageLogoDimensions.CreateFromDiscriminatorValue); } },
                {"logoCdnUrl", n => { LogoCdnUrl = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("assetName", AssetName);
            writer.WriteObjectValue<OrganizationalMessageLogoDimensions>("dimensions", Dimensions);
            writer.WriteStringValue("logoCdnUrl", LogoCdnUrl);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
