using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DomainRegistrant : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The countryOrRegionCode property</summary>
        public string CountryOrRegionCode {
            get { return BackingStore?.Get<string>("countryOrRegionCode"); }
            set { BackingStore?.Set("countryOrRegionCode", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The organization property</summary>
        public string Organization {
            get { return BackingStore?.Get<string>("organization"); }
            set { BackingStore?.Set("organization", value); }
        }
        /// <summary>The url property</summary>
        public string Url {
            get { return BackingStore?.Get<string>("url"); }
            set { BackingStore?.Set("url", value); }
        }
        /// <summary>The vendor property</summary>
        public string Vendor {
            get { return BackingStore?.Get<string>("vendor"); }
            set { BackingStore?.Set("vendor", value); }
        }
        /// <summary>
        /// Instantiates a new domainRegistrant and sets the default values.
        /// </summary>
        public DomainRegistrant() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DomainRegistrant CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DomainRegistrant();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"countryOrRegionCode", n => { CountryOrRegionCode = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"organization", n => { Organization = n.GetStringValue(); } },
                {"url", n => { Url = n.GetStringValue(); } },
                {"vendor", n => { Vendor = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("countryOrRegionCode", CountryOrRegionCode);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("organization", Organization);
            writer.WriteStringValue("url", Url);
            writer.WriteStringValue("vendor", Vendor);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
