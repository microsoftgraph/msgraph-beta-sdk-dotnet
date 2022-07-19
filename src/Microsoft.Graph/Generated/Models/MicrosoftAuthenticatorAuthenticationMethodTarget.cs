using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MicrosoftAuthenticatorAuthenticationMethodTarget : AuthenticationMethodTarget, IParsable {
        /// <summary>The authenticationMode property</summary>
        public MicrosoftAuthenticatorAuthenticationMode? AuthenticationMode {
            get { return BackingStore?.Get<MicrosoftAuthenticatorAuthenticationMode?>("authenticationMode"); }
            set { BackingStore?.Set("authenticationMode", value); }
        }
        /// <summary>The displayAppInformationRequiredState property</summary>
        public AdvancedConfigState? DisplayAppInformationRequiredState {
            get { return BackingStore?.Get<AdvancedConfigState?>("displayAppInformationRequiredState"); }
            set { BackingStore?.Set("displayAppInformationRequiredState", value); }
        }
        /// <summary>The numberMatchingRequiredState property</summary>
        public AdvancedConfigState? NumberMatchingRequiredState {
            get { return BackingStore?.Get<AdvancedConfigState?>("numberMatchingRequiredState"); }
            set { BackingStore?.Set("numberMatchingRequiredState", value); }
        }
        /// <summary>
        /// Instantiates a new MicrosoftAuthenticatorAuthenticationMethodTarget and sets the default values.
        /// </summary>
        public MicrosoftAuthenticatorAuthenticationMethodTarget() : base() {
            OdataType = "#microsoft.graph.microsoftAuthenticatorAuthenticationMethodTarget";
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
