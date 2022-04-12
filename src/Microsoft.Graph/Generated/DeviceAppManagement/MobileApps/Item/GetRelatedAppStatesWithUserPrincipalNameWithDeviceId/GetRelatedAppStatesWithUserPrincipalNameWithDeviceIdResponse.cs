using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.Item.GetRelatedAppStatesWithUserPrincipalNameWithDeviceId {
    /// <summary>Provides operations to call the getRelatedAppStates method.</summary>
    public class GetRelatedAppStatesWithUserPrincipalNameWithDeviceIdResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The value property</summary>
        public List<MobileAppRelationshipState> Value { get; set; }
        /// <summary>
        /// Instantiates a new getRelatedAppStatesWithUserPrincipalNameWithDeviceIdResponse and sets the default values.
        /// </summary>
        public GetRelatedAppStatesWithUserPrincipalNameWithDeviceIdResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static GetRelatedAppStatesWithUserPrincipalNameWithDeviceIdResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GetRelatedAppStatesWithUserPrincipalNameWithDeviceIdResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"value", n => { Value = n.GetCollectionOfObjectValues<MobileAppRelationshipState>(MobileAppRelationshipState.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<MobileAppRelationshipState>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
