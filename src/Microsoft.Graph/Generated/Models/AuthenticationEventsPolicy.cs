using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AuthenticationEventsPolicy : Entity, IParsable {
        /// <summary>A list of applicable actions to be taken on sign-up.</summary>
        public List<AuthenticationListener> OnSignupStart {
            get { return BackingStore?.Get<List<AuthenticationListener>>("onSignupStart"); }
            set { BackingStore?.Set("onSignupStart", value); }
        }
        /// <summary>
        /// Instantiates a new AuthenticationEventsPolicy and sets the default values.
        /// </summary>
        public AuthenticationEventsPolicy() : base() {
            OdataType = "#microsoft.graph.authenticationEventsPolicy";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AuthenticationEventsPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuthenticationEventsPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"onSignupStart", n => { OnSignupStart = n.GetCollectionOfObjectValues<AuthenticationListener>(AuthenticationListener.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AuthenticationListener>("onSignupStart", OnSignupStart);
        }
    }
}
