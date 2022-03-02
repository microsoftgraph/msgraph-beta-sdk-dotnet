using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.TenantRelationships.DelegatedAdminCustomers.Item.ServiceManagementDetails {
    public class ServiceManagementDetailsResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string NextLink { get; set; }
        public List<DelegatedAdminServiceManagementDetail> Value { get; set; }
        /// <summary>
        /// Instantiates a new serviceManagementDetailsResponse and sets the default values.
        /// </summary>
        public ServiceManagementDetailsResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"@odata.nextLink", (o,n) => { (o as ServiceManagementDetailsResponse).NextLink = n.GetStringValue(); } },
                {"value", (o,n) => { (o as ServiceManagementDetailsResponse).Value = n.GetCollectionOfObjectValues<DelegatedAdminServiceManagementDetail>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.nextLink", NextLink);
            writer.WriteCollectionOfObjectValues<DelegatedAdminServiceManagementDetail>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
