using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MicrosoftAuthenticatorAuthenticationMethodTarget : AuthenticationMethodTarget, IParsable {
        /// <summary>Determines which types of notifications can be used for sign-in. The possible values are: deviceBasedPush (passwordless only), push, and any.</summary>
        public MicrosoftAuthenticatorAuthenticationMode? AuthenticationMode {
            get { return BackingStore?.Get<MicrosoftAuthenticatorAuthenticationMode?>(nameof(AuthenticationMode)); }
            set { BackingStore?.Set(nameof(AuthenticationMode), value); }
        }
        /// <summary>Determines whether the user is shown additional context in their Authenticator app notification. In the body of the Authenticator notification, the user will be shown the app they are signing into along with the location that the authentication request originated from. Possible values are: enabled, disabled, default.</summary>
        public AdvancedConfigState? DisplayAppInformationRequiredState {
            get { return BackingStore?.Get<AdvancedConfigState?>(nameof(DisplayAppInformationRequiredState)); }
            set { BackingStore?.Set(nameof(DisplayAppInformationRequiredState), value); }
        }
        /// <summary>Requires number matching for MFA notifications. Value is ignored for phone sign-in notifications. Possible values are: enabled, disabled, default.</summary>
        public AdvancedConfigState? NumberMatchingRequiredState {
            get { return BackingStore?.Get<AdvancedConfigState?>(nameof(NumberMatchingRequiredState)); }
            set { BackingStore?.Set(nameof(NumberMatchingRequiredState), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MicrosoftAuthenticatorAuthenticationMethodTarget CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MicrosoftAuthenticatorAuthenticationMethodTarget();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"authenticationMode", n => { AuthenticationMode = n.GetEnumValue<MicrosoftAuthenticatorAuthenticationMode>(); } },
                {"displayAppInformationRequiredState", n => { DisplayAppInformationRequiredState = n.GetEnumValue<AdvancedConfigState>(); } },
                {"numberMatchingRequiredState", n => { NumberMatchingRequiredState = n.GetEnumValue<AdvancedConfigState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<MicrosoftAuthenticatorAuthenticationMode>("authenticationMode", AuthenticationMode);
            writer.WriteEnumValue<AdvancedConfigState>("displayAppInformationRequiredState", DisplayAppInformationRequiredState);
            writer.WriteEnumValue<AdvancedConfigState>("numberMatchingRequiredState", NumberMatchingRequiredState);
        }
    }
}
