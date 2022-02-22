using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class BookingCustomer : BookingPerson, IParsable {
        /// <summary>Addresses associated with the customer. The attribute type of physicalAddress is not supported in v1.0. Internally we map the addresses to the type others.</summary>
        public List<PhysicalAddress> Addresses { get; set; }
        /// <summary>Phone numbers associated with the customer, including home, business and mobile numbers.</summary>
        public List<Phone> Phones { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"addresses", (o,n) => { (o as BookingCustomer).Addresses = n.GetCollectionOfObjectValues<PhysicalAddress>().ToList(); } },
                {"phones", (o,n) => { (o as BookingCustomer).Phones = n.GetCollectionOfObjectValues<Phone>().ToList(); } },
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
