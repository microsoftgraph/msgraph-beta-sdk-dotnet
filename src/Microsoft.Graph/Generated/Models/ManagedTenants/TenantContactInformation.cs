using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public class TenantContactInformation : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The email address for the contact. Optional</summary>
        public string Email { get; set; }
        /// <summary>The name for the contact. Required.</summary>
        public string Name { get; set; }
        /// <summary>The notes associated with the contact. Optional</summary>
        public string Notes { get; set; }
        /// <summary>The phone number for the contact. Optional.</summary>
        public string Phone { get; set; }
        /// <summary>The title for the contact. Required.</summary>
        public string Title { get; set; }
        /// <summary>
        /// Instantiates a new tenantContactInformation and sets the default values.
        /// </summary>
        public TenantContactInformation() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TenantContactInformation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TenantContactInformation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"email", n => { Email = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"notes", n => { Notes = n.GetStringValue(); } },
                {"phone", n => { Phone = n.GetStringValue(); } },
                {"title", n => { Title = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("notes", Notes);
            writer.WriteStringValue("phone", Phone);
            writer.WriteStringValue("title", Title);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
