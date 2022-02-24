using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class RelatedPerson : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Name of the person.</summary>
        public string DisplayName { get; set; }
        /// <summary>Possible values are: manager, colleague, directReport, dotLineReport, assistant, dotLineManager, alternateContact, friend, spouse, sibling, child, parent, sponsor, emergencyContact, other, unknownFutureValue.</summary>
        public PersonRelationship? Relationship { get; set; }
        /// <summary>Email address or reference to person within organization.</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// Instantiates a new relatedPerson and sets the default values.
        /// </summary>
        public RelatedPerson() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"displayName", (o,n) => { (o as RelatedPerson).DisplayName = n.GetStringValue(); } },
                {"relationship", (o,n) => { (o as RelatedPerson).Relationship = n.GetEnumValue<PersonRelationship>(); } },
                {"userPrincipalName", (o,n) => { (o as RelatedPerson).UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<PersonRelationship>("relationship", Relationship);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
