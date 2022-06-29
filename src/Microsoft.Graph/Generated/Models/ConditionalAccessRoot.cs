using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ConditionalAccessRoot : Entity, IParsable {
        /// <summary>Read-only. Nullable. Returns a collection of the specified authentication context class references.</summary>
        public List<AuthenticationContextClassReference> AuthenticationContextClassReferences {
            get { return BackingStore?.Get<List<AuthenticationContextClassReference>>(nameof(AuthenticationContextClassReferences)); }
            set { BackingStore?.Set(nameof(AuthenticationContextClassReferences), value); }
        }
        /// <summary>Read-only. Nullable. Returns a collection of the specified named locations.</summary>
        public List<NamedLocation> NamedLocations {
            get { return BackingStore?.Get<List<NamedLocation>>(nameof(NamedLocations)); }
            set { BackingStore?.Set(nameof(NamedLocations), value); }
        }
        /// <summary>Read-only. Nullable. Returns a collection of the specified Conditional Access policies.</summary>
        public List<ConditionalAccessPolicy> Policies {
            get { return BackingStore?.Get<List<ConditionalAccessPolicy>>(nameof(Policies)); }
            set { BackingStore?.Set(nameof(Policies), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ConditionalAccessRoot CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConditionalAccessRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"authenticationContextClassReferences", n => { AuthenticationContextClassReferences = n.GetCollectionOfObjectValues<AuthenticationContextClassReference>(AuthenticationContextClassReference.CreateFromDiscriminatorValue).ToList(); } },
                {"namedLocations", n => { NamedLocations = n.GetCollectionOfObjectValues<NamedLocation>(NamedLocation.CreateFromDiscriminatorValue).ToList(); } },
                {"policies", n => { Policies = n.GetCollectionOfObjectValues<ConditionalAccessPolicy>(ConditionalAccessPolicy.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AuthenticationContextClassReference>("authenticationContextClassReferences", AuthenticationContextClassReferences);
            writer.WriteCollectionOfObjectValues<NamedLocation>("namedLocations", NamedLocations);
            writer.WriteCollectionOfObjectValues<ConditionalAccessPolicy>("policies", Policies);
        }
    }
}
