using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.IdentityGovernance.EntitlementManagement.AccessPackageAssignmentResourceRoles {
    public class AccessPackageAssignmentResourceRolesResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string NextLink { get; set; }
        public List<AccessPackageAssignmentResourceRole> Value { get; set; }
        /// <summary>
        /// Instantiates a new accessPackageAssignmentResourceRolesResponse and sets the default values.
        /// </summary>
        public AccessPackageAssignmentResourceRolesResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AccessPackageAssignmentResourceRolesResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageAssignmentResourceRolesResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"@odata.nextLink", (o,n) => { (o as AccessPackageAssignmentResourceRolesResponse).NextLink = n.GetStringValue(); } },
                {"value", (o,n) => { (o as AccessPackageAssignmentResourceRolesResponse).Value = n.GetCollectionOfObjectValues<AccessPackageAssignmentResourceRole>(AccessPackageAssignmentResourceRole.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.nextLink", NextLink);
            writer.WriteCollectionOfObjectValues<AccessPackageAssignmentResourceRole>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
