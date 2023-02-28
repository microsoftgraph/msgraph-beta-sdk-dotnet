using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CloudPcCrossCloudGovernmentOrganizationMapping : Entity, IParsable {
        /// <summary>The tenant ID in the Azure Government cloud corresponding to the GCC tenant in the public cloud. Currently, 1:1 mappings are supported, so this collection can only contain one tenant ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? OrganizationIdsInUSGovCloud {
            get { return BackingStore?.Get<List<string>?>("organizationIdsInUSGovCloud"); }
            set { BackingStore?.Set("organizationIdsInUSGovCloud", value); }
        }
#nullable restore
#else
        public List<string> OrganizationIdsInUSGovCloud {
            get { return BackingStore?.Get<List<string>>("organizationIdsInUSGovCloud"); }
            set { BackingStore?.Set("organizationIdsInUSGovCloud", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CloudPcCrossCloudGovernmentOrganizationMapping CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcCrossCloudGovernmentOrganizationMapping();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"organizationIdsInUSGovCloud", n => { OrganizationIdsInUSGovCloud = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("organizationIdsInUSGovCloud", OrganizationIdsInUSGovCloud);
        }
    }
}
