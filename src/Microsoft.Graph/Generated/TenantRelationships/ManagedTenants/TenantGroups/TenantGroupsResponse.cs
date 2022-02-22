using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraph.Models.Microsoft.Graph.ManagedTenants;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.TenantRelationships.ManagedTenants.TenantGroups {
    public class TenantGroupsResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string NextLink { get; set; }
        public List<TenantGroup> Value { get; set; }
        /// <summary>
        /// Instantiates a new tenantGroupsResponse and sets the default values.
        /// </summary>
        public TenantGroupsResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"@odata.nextLink", (o,n) => { (o as TenantGroupsResponse).NextLink = n.GetStringValue(); } },
                {"value", (o,n) => { (o as TenantGroupsResponse).Value = n.GetCollectionOfObjectValues<TenantGroup>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.nextLink", NextLink);
            writer.WriteCollectionOfObjectValues<TenantGroup>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
