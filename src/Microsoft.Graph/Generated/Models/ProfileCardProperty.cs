using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Provides operations to manage the collection of accessReviewDecision entities.
    /// </summary>
    public class ProfileCardProperty : Entity, IParsable {
        /// <summary>Allows an administrator to set a custom display label for the directory property and localize it for the users in their tenant.</summary>
        public List<ProfileCardAnnotation> Annotations {
            get { return BackingStore?.Get<List<ProfileCardAnnotation>>("annotations"); }
            set { BackingStore?.Set("annotations", value); }
        }
        /// <summary>Identifies a profileCardProperty resource in Get, Update, or Delete operations. Allows an administrator to surface hidden Azure Active Directory (Azure AD) properties on the Microsoft 365 profile card within their tenant. When present, the Azure AD field referenced in this field will be visible to all users in your tenant on the contact pane of the profile card. Allowed values for this field are: UserPrincipalName, Fax, StreetAddress, PostalCode, StateOrProvince, Alias, CustomAttribute1,  CustomAttribute2, CustomAttribute3, CustomAttribute4, CustomAttribute5, CustomAttribute6, CustomAttribute7, CustomAttribute8, CustomAttribute9, CustomAttribute10, CustomAttribute11, CustomAttribute12, CustomAttribute13, CustomAttribute14, CustomAttribute15.</summary>
        public string DirectoryPropertyName {
            get { return BackingStore?.Get<string>("directoryPropertyName"); }
            set { BackingStore?.Set("directoryPropertyName", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ProfileCardProperty CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ProfileCardProperty();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"annotations", n => { Annotations = n.GetCollectionOfObjectValues<ProfileCardAnnotation>(ProfileCardAnnotation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"directoryPropertyName", n => { DirectoryPropertyName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ProfileCardAnnotation>("annotations", Annotations);
            writer.WriteStringValue("directoryPropertyName", DirectoryPropertyName);
        }
    }
}
