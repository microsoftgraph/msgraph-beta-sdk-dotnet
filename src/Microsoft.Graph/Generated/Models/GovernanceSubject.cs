using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class GovernanceSubject : Entity, IParsable {
        /// <summary>The display name of the subject.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The email address of the user subject. If the subject is in other types, it is empty.</summary>
        public string Email {
            get { return BackingStore?.Get<string>(nameof(Email)); }
            set { BackingStore?.Set(nameof(Email), value); }
        }
        /// <summary>The principal name of the user subject. If the subject is in other types, it is empty.</summary>
        public string PrincipalName {
            get { return BackingStore?.Get<string>(nameof(PrincipalName)); }
            set { BackingStore?.Set(nameof(PrincipalName), value); }
        }
        /// <summary>The type of the subject. The value can be User, Group, and ServicePrincipal.</summary>
        public string Type {
            get { return BackingStore?.Get<string>(nameof(Type)); }
            set { BackingStore?.Set(nameof(Type), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new GovernanceSubject CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GovernanceSubject();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"email", n => { Email = n.GetStringValue(); } },
                {"principalName", n => { PrincipalName = n.GetStringValue(); } },
                {"type", n => { Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("principalName", PrincipalName);
            writer.WriteStringValue("type", Type);
        }
    }
}
