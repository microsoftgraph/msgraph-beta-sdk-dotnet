using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class ExternalUsersSelfServiceSignUpEventsFlow : AuthenticationEventsFlow, IParsable {
        /// <summary>The configuration for what to invoke when attributes are ready to be collected from the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public OnAttributeCollectionHandler? OnAttributeCollection {
            get { return BackingStore?.Get<OnAttributeCollectionHandler?>("onAttributeCollection"); }
            set { BackingStore?.Set("onAttributeCollection", value); }
        }
#nullable restore
#else
        public OnAttributeCollectionHandler OnAttributeCollection {
            get { return BackingStore?.Get<OnAttributeCollectionHandler>("onAttributeCollection"); }
            set { BackingStore?.Set("onAttributeCollection", value); }
        }
#endif
        /// <summary>Required. The configuration for what to invoke when authentication methods are ready to be presented to the user. Must have at least one identity provider linked.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public OnAuthenticationMethodLoadStartHandler? OnAuthenticationMethodLoadStart {
            get { return BackingStore?.Get<OnAuthenticationMethodLoadStartHandler?>("onAuthenticationMethodLoadStart"); }
            set { BackingStore?.Set("onAuthenticationMethodLoadStart", value); }
        }
#nullable restore
#else
        public OnAuthenticationMethodLoadStartHandler OnAuthenticationMethodLoadStart {
            get { return BackingStore?.Get<OnAuthenticationMethodLoadStartHandler>("onAuthenticationMethodLoadStart"); }
            set { BackingStore?.Set("onAuthenticationMethodLoadStart", value); }
        }
#endif
        /// <summary>Required. The configuration for what to invoke when an authentication flow is ready to be initiated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public OnInteractiveAuthFlowStartHandler? OnInteractiveAuthFlowStart {
            get { return BackingStore?.Get<OnInteractiveAuthFlowStartHandler?>("onInteractiveAuthFlowStart"); }
            set { BackingStore?.Set("onInteractiveAuthFlowStart", value); }
        }
#nullable restore
#else
        public OnInteractiveAuthFlowStartHandler OnInteractiveAuthFlowStart {
            get { return BackingStore?.Get<OnInteractiveAuthFlowStartHandler>("onInteractiveAuthFlowStart"); }
            set { BackingStore?.Set("onInteractiveAuthFlowStart", value); }
        }
#endif
        /// <summary>The configuration for what to invoke during user creation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public OnUserCreateStartHandler? OnUserCreateStart {
            get { return BackingStore?.Get<OnUserCreateStartHandler?>("onUserCreateStart"); }
            set { BackingStore?.Set("onUserCreateStart", value); }
        }
#nullable restore
#else
        public OnUserCreateStartHandler OnUserCreateStart {
            get { return BackingStore?.Get<OnUserCreateStartHandler>("onUserCreateStart"); }
            set { BackingStore?.Set("onUserCreateStart", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new externalUsersSelfServiceSignUpEventsFlow and sets the default values.
        /// </summary>
        public ExternalUsersSelfServiceSignUpEventsFlow() : base() {
            OdataType = "#microsoft.graph.externalUsersSelfServiceSignUpEventsFlow";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ExternalUsersSelfServiceSignUpEventsFlow CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExternalUsersSelfServiceSignUpEventsFlow();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"onAttributeCollection", n => { OnAttributeCollection = n.GetObjectValue<OnAttributeCollectionHandler>(OnAttributeCollectionHandler.CreateFromDiscriminatorValue); } },
                {"onAuthenticationMethodLoadStart", n => { OnAuthenticationMethodLoadStart = n.GetObjectValue<OnAuthenticationMethodLoadStartHandler>(OnAuthenticationMethodLoadStartHandler.CreateFromDiscriminatorValue); } },
                {"onInteractiveAuthFlowStart", n => { OnInteractiveAuthFlowStart = n.GetObjectValue<OnInteractiveAuthFlowStartHandler>(OnInteractiveAuthFlowStartHandler.CreateFromDiscriminatorValue); } },
                {"onUserCreateStart", n => { OnUserCreateStart = n.GetObjectValue<OnUserCreateStartHandler>(OnUserCreateStartHandler.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<OnAttributeCollectionHandler>("onAttributeCollection", OnAttributeCollection);
            writer.WriteObjectValue<OnAuthenticationMethodLoadStartHandler>("onAuthenticationMethodLoadStart", OnAuthenticationMethodLoadStart);
            writer.WriteObjectValue<OnInteractiveAuthFlowStartHandler>("onInteractiveAuthFlowStart", OnInteractiveAuthFlowStart);
            writer.WriteObjectValue<OnUserCreateStartHandler>("onUserCreateStart", OnUserCreateStart);
        }
    }
}
