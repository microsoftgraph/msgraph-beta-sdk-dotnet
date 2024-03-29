// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class ExternalUsersSelfServiceSignUpEventsFlow : AuthenticationEventsFlow, IParsable 
    {
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
        /// <summary>The configuration for what to invoke when attribution collection has started.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public OnAttributeCollectionStartHandler? OnAttributeCollectionStart {
            get { return BackingStore?.Get<OnAttributeCollectionStartHandler?>("onAttributeCollectionStart"); }
            set { BackingStore?.Set("onAttributeCollectionStart", value); }
        }
#nullable restore
#else
        public OnAttributeCollectionStartHandler OnAttributeCollectionStart {
            get { return BackingStore?.Get<OnAttributeCollectionStartHandler>("onAttributeCollectionStart"); }
            set { BackingStore?.Set("onAttributeCollectionStart", value); }
        }
#endif
        /// <summary>The configuration for what to invoke when attributes have been submitted at the end of attribution collection.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public OnAttributeCollectionSubmitHandler? OnAttributeCollectionSubmit {
            get { return BackingStore?.Get<OnAttributeCollectionSubmitHandler?>("onAttributeCollectionSubmit"); }
            set { BackingStore?.Set("onAttributeCollectionSubmit", value); }
        }
#nullable restore
#else
        public OnAttributeCollectionSubmitHandler OnAttributeCollectionSubmit {
            get { return BackingStore?.Get<OnAttributeCollectionSubmitHandler>("onAttributeCollectionSubmit"); }
            set { BackingStore?.Set("onAttributeCollectionSubmit", value); }
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
        /// Instantiates a new <see cref="ExternalUsersSelfServiceSignUpEventsFlow"/> and sets the default values.
        /// </summary>
        public ExternalUsersSelfServiceSignUpEventsFlow() : base()
        {
            OdataType = "#microsoft.graph.externalUsersSelfServiceSignUpEventsFlow";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ExternalUsersSelfServiceSignUpEventsFlow"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ExternalUsersSelfServiceSignUpEventsFlow CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExternalUsersSelfServiceSignUpEventsFlow();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"onAttributeCollection", n => { OnAttributeCollection = n.GetObjectValue<OnAttributeCollectionHandler>(OnAttributeCollectionHandler.CreateFromDiscriminatorValue); } },
                {"onAttributeCollectionStart", n => { OnAttributeCollectionStart = n.GetObjectValue<OnAttributeCollectionStartHandler>(OnAttributeCollectionStartHandler.CreateFromDiscriminatorValue); } },
                {"onAttributeCollectionSubmit", n => { OnAttributeCollectionSubmit = n.GetObjectValue<OnAttributeCollectionSubmitHandler>(OnAttributeCollectionSubmitHandler.CreateFromDiscriminatorValue); } },
                {"onAuthenticationMethodLoadStart", n => { OnAuthenticationMethodLoadStart = n.GetObjectValue<OnAuthenticationMethodLoadStartHandler>(OnAuthenticationMethodLoadStartHandler.CreateFromDiscriminatorValue); } },
                {"onInteractiveAuthFlowStart", n => { OnInteractiveAuthFlowStart = n.GetObjectValue<OnInteractiveAuthFlowStartHandler>(OnInteractiveAuthFlowStartHandler.CreateFromDiscriminatorValue); } },
                {"onUserCreateStart", n => { OnUserCreateStart = n.GetObjectValue<OnUserCreateStartHandler>(OnUserCreateStartHandler.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<OnAttributeCollectionHandler>("onAttributeCollection", OnAttributeCollection);
            writer.WriteObjectValue<OnAttributeCollectionStartHandler>("onAttributeCollectionStart", OnAttributeCollectionStart);
            writer.WriteObjectValue<OnAttributeCollectionSubmitHandler>("onAttributeCollectionSubmit", OnAttributeCollectionSubmit);
            writer.WriteObjectValue<OnAuthenticationMethodLoadStartHandler>("onAuthenticationMethodLoadStart", OnAuthenticationMethodLoadStart);
            writer.WriteObjectValue<OnInteractiveAuthFlowStartHandler>("onInteractiveAuthFlowStart", OnInteractiveAuthFlowStart);
            writer.WriteObjectValue<OnUserCreateStartHandler>("onUserCreateStart", OnUserCreateStart);
        }
    }
}
