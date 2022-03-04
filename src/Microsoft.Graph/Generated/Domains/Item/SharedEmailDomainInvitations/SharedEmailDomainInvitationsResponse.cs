using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Domains.Item.SharedEmailDomainInvitations {
    public class SharedEmailDomainInvitationsResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string NextLink { get; set; }
        public List<SharedEmailDomainInvitation> Value { get; set; }
        /// <summary>
        /// Instantiates a new sharedEmailDomainInvitationsResponse and sets the default values.
        /// </summary>
        public SharedEmailDomainInvitationsResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SharedEmailDomainInvitationsResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SharedEmailDomainInvitationsResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"@odata.nextLink", (o,n) => { (o as SharedEmailDomainInvitationsResponse).NextLink = n.GetStringValue(); } },
                {"value", (o,n) => { (o as SharedEmailDomainInvitationsResponse).Value = n.GetCollectionOfObjectValues<SharedEmailDomainInvitation>(SharedEmailDomainInvitation.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.nextLink", NextLink);
            writer.WriteCollectionOfObjectValues<SharedEmailDomainInvitation>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
