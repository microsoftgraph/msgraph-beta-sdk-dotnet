using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PhysicalAddress : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The city.</summary>
        public string City {
            get { return BackingStore?.Get<string>(nameof(City)); }
            set { BackingStore?.Set(nameof(City), value); }
        }
        /// <summary>The country or region. It&apos;s a free-format string value, for example, &apos;United States&apos;.</summary>
        public string CountryOrRegion {
            get { return BackingStore?.Get<string>(nameof(CountryOrRegion)); }
            set { BackingStore?.Set(nameof(CountryOrRegion), value); }
        }
        /// <summary>The postal code.</summary>
        public string PostalCode {
            get { return BackingStore?.Get<string>(nameof(PostalCode)); }
            set { BackingStore?.Set(nameof(PostalCode), value); }
        }
        /// <summary>The post office box number.</summary>
        public string PostOfficeBox {
            get { return BackingStore?.Get<string>(nameof(PostOfficeBox)); }
            set { BackingStore?.Set(nameof(PostOfficeBox), value); }
        }
        /// <summary>The state.</summary>
        public string State {
            get { return BackingStore?.Get<string>(nameof(State)); }
            set { BackingStore?.Set(nameof(State), value); }
        }
        /// <summary>The street.</summary>
        public string Street {
            get { return BackingStore?.Get<string>(nameof(Street)); }
            set { BackingStore?.Set(nameof(Street), value); }
        }
        /// <summary>The type of address. Possible values are: unknown, home, business, other.</summary>
        public PhysicalAddressType? Type {
            get { return BackingStore?.Get<PhysicalAddressType?>(nameof(Type)); }
            set { BackingStore?.Set(nameof(Type), value); }
        }
        /// <summary>
        /// Instantiates a new physicalAddress and sets the default values.
        /// </summary>
        public PhysicalAddress() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static PhysicalAddress CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PhysicalAddress();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"city", n => { City = n.GetStringValue(); } },
                {"countryOrRegion", n => { CountryOrRegion = n.GetStringValue(); } },
                {"postalCode", n => { PostalCode = n.GetStringValue(); } },
                {"postOfficeBox", n => { PostOfficeBox = n.GetStringValue(); } },
                {"state", n => { State = n.GetStringValue(); } },
                {"street", n => { Street = n.GetStringValue(); } },
                {"type", n => { Type = n.GetEnumValue<PhysicalAddressType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("city", City);
            writer.WriteStringValue("countryOrRegion", CountryOrRegion);
            writer.WriteStringValue("postalCode", PostalCode);
            writer.WriteStringValue("postOfficeBox", PostOfficeBox);
            writer.WriteStringValue("state", State);
            writer.WriteStringValue("street", Street);
            writer.WriteEnumValue<PhysicalAddressType>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
