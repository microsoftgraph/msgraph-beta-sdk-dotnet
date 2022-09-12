using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class EducationIdentityMatchingConfiguration : EducationIdentitySynchronizationConfiguration, IParsable {
        /// <summary>Mapping between the user account and the options to use to uniquely identify the user to update.</summary>
        public List<EducationIdentityMatchingOptions> MatchingOptions {
            get { return BackingStore?.Get<List<EducationIdentityMatchingOptions>>("matchingOptions"); }
            set { BackingStore?.Set("matchingOptions", value); }
        }
        /// <summary>
        /// Instantiates a new EducationIdentityMatchingConfiguration and sets the default values.
        /// </summary>
        public EducationIdentityMatchingConfiguration() : base() {
            OdataType = "#microsoft.graph.educationIdentityMatchingConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EducationIdentityMatchingConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationIdentityMatchingConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"matchingOptions", n => { MatchingOptions = n.GetCollectionOfObjectValues<EducationIdentityMatchingOptions>(EducationIdentityMatchingOptions.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<EducationIdentityMatchingOptions>("matchingOptions", MatchingOptions);
        }
    }
}
