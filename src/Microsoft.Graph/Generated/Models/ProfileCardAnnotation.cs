using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ProfileCardAnnotation : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>If present, the value of this field is used by the profile card as the default property label in the experience (for example, &apos;Cost Center&apos;).</summary>
        public string DisplayName { get; set; }
        /// <summary>Each resource in this collection represents the localized value of the attribute name for a given language, used as the default label for that locale. For example, a user with a no-NB client gets &apos;Kostnads Senter&apos; as the attribute label, rather than &apos;Cost Center.&apos;</summary>
        public List<DisplayNameLocalization> Localizations { get; set; }
        /// <summary>
        /// Instantiates a new profileCardAnnotation and sets the default values.
        /// </summary>
        public ProfileCardAnnotation() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ProfileCardAnnotation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ProfileCardAnnotation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"localizations", n => { Localizations = n.GetCollectionOfObjectValues<DisplayNameLocalization>(DisplayNameLocalization.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<DisplayNameLocalization>("localizations", Localizations);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
