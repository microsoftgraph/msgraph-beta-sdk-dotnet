using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class SubjectRightsRequestEnumeratedMailboxLocation : SubjectRightsRequestMailboxLocation, IParsable {
        /// <summary>Collection of mailboxes that should be included in the search. Includes the UPN (user principal name) of each mailbox, for example, Monica.Thompson@contoso.com.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Upns {
            get { return BackingStore?.Get<List<string>?>("upns"); }
            set { BackingStore?.Set("upns", value); }
        }
#nullable restore
#else
        public List<string> Upns {
            get { return BackingStore?.Get<List<string>>("upns"); }
            set { BackingStore?.Set("upns", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new SubjectRightsRequestEnumeratedMailboxLocation and sets the default values.
        /// </summary>
        public SubjectRightsRequestEnumeratedMailboxLocation() : base() {
            OdataType = "#microsoft.graph.subjectRightsRequestEnumeratedMailboxLocation";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SubjectRightsRequestEnumeratedMailboxLocation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SubjectRightsRequestEnumeratedMailboxLocation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"upns", n => { Upns = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("upns", Upns);
        }
    }
}
