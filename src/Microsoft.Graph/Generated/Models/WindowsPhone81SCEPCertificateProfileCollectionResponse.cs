using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsPhone81SCEPCertificateProfileCollectionResponse : BaseCollectionPaginationCountResponse, IParsable {
        /// <summary>The value property</summary>
        public List<WindowsPhone81SCEPCertificateProfile> Value {
            get { return BackingStore?.Get<List<WindowsPhone81SCEPCertificateProfile>>("value"); }
            set { BackingStore?.Set("value", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsPhone81SCEPCertificateProfileCollectionResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsPhone81SCEPCertificateProfileCollectionResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"value", n => { Value = n.GetCollectionOfObjectValues<WindowsPhone81SCEPCertificateProfile>(WindowsPhone81SCEPCertificateProfile.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<WindowsPhone81SCEPCertificateProfile>("value", Value);
        }
    }
}
