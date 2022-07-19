using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class SubjectRightsRequestEnumeratedSiteLocation : SubjectRightsRequestSiteLocation, IParsable {
        /// <summary>Collection of site URLs that should be included. Includes the URL of each site, for example, https://www.contoso.com/site1.</summary>
        public List<string> Urls {
            get { return BackingStore?.Get<List<string>>("urls"); }
            set { BackingStore?.Set("urls", value); }
        }
        /// <summary>
        /// Instantiates a new SubjectRightsRequestEnumeratedSiteLocation and sets the default values.
        /// </summary>
        public SubjectRightsRequestEnumeratedSiteLocation() : base() {
            OdataType = "#microsoft.graph.subjectRightsRequestEnumeratedSiteLocation";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SubjectRightsRequestEnumeratedSiteLocation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SubjectRightsRequestEnumeratedSiteLocation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"urls", n => { Urls = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("urls", Urls);
        }
    }
}
