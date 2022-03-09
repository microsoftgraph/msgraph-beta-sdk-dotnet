using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the collection of bookingBusiness entities.</summary>
    public class BookingCustomer : BookingPerson, IParsable {
        /// <summary>Addresses associated with the customer. The attribute type of physicalAddress is not supported in v1.0. Internally we map the addresses to the type others.</summary>
        public List<PhysicalAddress> Addresses { get; set; }
        /// <summary>Phone numbers associated with the customer, including home, business and mobile numbers.</summary>
        public List<Phone> Phones { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new BookingCustomer CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BookingCustomer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"addresses", (o,n) => { (o as BookingCustomer).Addresses = n.GetCollectionOfObjectValues<PhysicalAddress>(PhysicalAddress.CreateFromDiscriminatorValue).ToList(); } },
                {"phones", (o,n) => { (o as BookingCustomer).Phones = n.GetCollectionOfObjectValues<Phone>(Phone.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<PhysicalAddress>("addresses", Addresses);
            writer.WriteCollectionOfObjectValues<Phone>("phones", Phones);
        }
    }
}
