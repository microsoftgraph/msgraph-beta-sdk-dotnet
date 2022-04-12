using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DelegatedAdminAccessContainer : IAdditionalDataHolder, IParsable {
        /// <summary>The identifier of the access container (for example, a security group). For &apos;securityGroup&apos; access containers, this must be a valid ID of an Azure AD security group in the Microsoft partner&apos;s tenant.</summary>
        public string AccessContainerId { get; set; }
        /// <summary>The type of access container (for example, security group) that will be assigned one or more roles through a delegated admin relationship. The possible values are: securityGroup, unknownFutureValue.</summary>
        public DelegatedAdminAccessContainerType? AccessContainerType { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>
        /// Instantiates a new delegatedAdminAccessContainer and sets the default values.
        /// </summary>
        public DelegatedAdminAccessContainer() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DelegatedAdminAccessContainer CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DelegatedAdminAccessContainer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"accessContainerId", n => { AccessContainerId = n.GetStringValue(); } },
                {"accessContainerType", n => { AccessContainerType = n.GetEnumValue<DelegatedAdminAccessContainerType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("accessContainerId", AccessContainerId);
            writer.WriteEnumValue<DelegatedAdminAccessContainerType>("accessContainerType", AccessContainerType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
