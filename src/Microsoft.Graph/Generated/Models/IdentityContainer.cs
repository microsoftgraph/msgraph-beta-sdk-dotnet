// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class IdentityContainer : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Represents entry point for API connectors.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.IdentityApiConnector>? ApiConnectors
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.IdentityApiConnector>?>("apiConnectors"); }
            set { BackingStore?.Set("apiConnectors", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.IdentityApiConnector> ApiConnectors
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.IdentityApiConnector>>("apiConnectors"); }
            set { BackingStore?.Set("apiConnectors", value); }
        }
#endif
        /// <summary>The authenticationEventListeners property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.AuthenticationEventListener>? AuthenticationEventListeners
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AuthenticationEventListener>?>("authenticationEventListeners"); }
            set { BackingStore?.Set("authenticationEventListeners", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.AuthenticationEventListener> AuthenticationEventListeners
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AuthenticationEventListener>>("authenticationEventListeners"); }
            set { BackingStore?.Set("authenticationEventListeners", value); }
        }
#endif
        /// <summary>Represents the entry point for self-service sign-up and sign-in user flows in both Microsoft Entra workforce and external tenants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.AuthenticationEventsFlow>? AuthenticationEventsFlows
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AuthenticationEventsFlow>?>("authenticationEventsFlows"); }
            set { BackingStore?.Set("authenticationEventsFlows", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.AuthenticationEventsFlow> AuthenticationEventsFlows
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AuthenticationEventsFlow>>("authenticationEventsFlows"); }
            set { BackingStore?.Set("authenticationEventsFlows", value); }
        }
#endif
        /// <summary>Represents entry point for B2C identity userflows.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.B2cIdentityUserFlow>? B2cUserFlows
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.B2cIdentityUserFlow>?>("b2cUserFlows"); }
            set { BackingStore?.Set("b2cUserFlows", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.B2cIdentityUserFlow> B2cUserFlows
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.B2cIdentityUserFlow>>("b2cUserFlows"); }
            set { BackingStore?.Set("b2cUserFlows", value); }
        }
#endif
        /// <summary>Represents entry point for B2X and self-service sign-up identity userflows.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.B2xIdentityUserFlow>? B2xUserFlows
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.B2xIdentityUserFlow>?>("b2xUserFlows"); }
            set { BackingStore?.Set("b2xUserFlows", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.B2xIdentityUserFlow> B2xUserFlows
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.B2xIdentityUserFlow>>("b2xUserFlows"); }
            set { BackingStore?.Set("b2xUserFlows", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>the entry point for the Conditional Access (CA) object model.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.ConditionalAccessRoot? ConditionalAccess
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ConditionalAccessRoot?>("conditionalAccess"); }
            set { BackingStore?.Set("conditionalAccess", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.ConditionalAccessRoot ConditionalAccess
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ConditionalAccessRoot>("conditionalAccess"); }
            set { BackingStore?.Set("conditionalAccess", value); }
        }
#endif
        /// <summary>Represents entry point for continuous access evaluation policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.ContinuousAccessEvaluationPolicy? ContinuousAccessEvaluationPolicy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ContinuousAccessEvaluationPolicy?>("continuousAccessEvaluationPolicy"); }
            set { BackingStore?.Set("continuousAccessEvaluationPolicy", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.ContinuousAccessEvaluationPolicy ContinuousAccessEvaluationPolicy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ContinuousAccessEvaluationPolicy>("continuousAccessEvaluationPolicy"); }
            set { BackingStore?.Set("continuousAccessEvaluationPolicy", value); }
        }
#endif
        /// <summary>The customAuthenticationExtensions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.CustomAuthenticationExtension>? CustomAuthenticationExtensions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.CustomAuthenticationExtension>?>("customAuthenticationExtensions"); }
            set { BackingStore?.Set("customAuthenticationExtensions", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.CustomAuthenticationExtension> CustomAuthenticationExtensions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.CustomAuthenticationExtension>>("customAuthenticationExtensions"); }
            set { BackingStore?.Set("customAuthenticationExtensions", value); }
        }
#endif
        /// <summary>Represents entry point for identity provider base.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.IdentityProviderBase>? IdentityProviders
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.IdentityProviderBase>?>("identityProviders"); }
            set { BackingStore?.Set("identityProviders", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.IdentityProviderBase> IdentityProviders
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.IdentityProviderBase>>("identityProviders"); }
            set { BackingStore?.Set("identityProviders", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Represents entry point for Microsoft Entra product changes and planned new features.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ChangeItemBase>? ProductChanges
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ChangeItemBase>?>("productChanges"); }
            set { BackingStore?.Set("productChanges", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ChangeItemBase> ProductChanges
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ChangeItemBase>>("productChanges"); }
            set { BackingStore?.Set("productChanges", value); }
        }
#endif
        /// <summary>Represents entry point for identity userflow attributes.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.IdentityUserFlowAttribute>? UserFlowAttributes
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.IdentityUserFlowAttribute>?>("userFlowAttributes"); }
            set { BackingStore?.Set("userFlowAttributes", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.IdentityUserFlowAttribute> UserFlowAttributes
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.IdentityUserFlowAttribute>>("userFlowAttributes"); }
            set { BackingStore?.Set("userFlowAttributes", value); }
        }
#endif
        /// <summary>The userFlows property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.IdentityUserFlow>? UserFlows
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.IdentityUserFlow>?>("userFlows"); }
            set { BackingStore?.Set("userFlows", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.IdentityUserFlow> UserFlows
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.IdentityUserFlow>>("userFlows"); }
            set { BackingStore?.Set("userFlows", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.IdentityContainer"/> and sets the default values.
        /// </summary>
        public IdentityContainer()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.IdentityContainer"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.IdentityContainer CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.IdentityContainer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "apiConnectors", n => { ApiConnectors = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.IdentityApiConnector>(global::Microsoft.Graph.Beta.Models.IdentityApiConnector.CreateFromDiscriminatorValue)?.AsList(); } },
                { "authenticationEventListeners", n => { AuthenticationEventListeners = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AuthenticationEventListener>(global::Microsoft.Graph.Beta.Models.AuthenticationEventListener.CreateFromDiscriminatorValue)?.AsList(); } },
                { "authenticationEventsFlows", n => { AuthenticationEventsFlows = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AuthenticationEventsFlow>(global::Microsoft.Graph.Beta.Models.AuthenticationEventsFlow.CreateFromDiscriminatorValue)?.AsList(); } },
                { "b2cUserFlows", n => { B2cUserFlows = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.B2cIdentityUserFlow>(global::Microsoft.Graph.Beta.Models.B2cIdentityUserFlow.CreateFromDiscriminatorValue)?.AsList(); } },
                { "b2xUserFlows", n => { B2xUserFlows = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.B2xIdentityUserFlow>(global::Microsoft.Graph.Beta.Models.B2xIdentityUserFlow.CreateFromDiscriminatorValue)?.AsList(); } },
                { "conditionalAccess", n => { ConditionalAccess = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.ConditionalAccessRoot>(global::Microsoft.Graph.Beta.Models.ConditionalAccessRoot.CreateFromDiscriminatorValue); } },
                { "continuousAccessEvaluationPolicy", n => { ContinuousAccessEvaluationPolicy = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.ContinuousAccessEvaluationPolicy>(global::Microsoft.Graph.Beta.Models.ContinuousAccessEvaluationPolicy.CreateFromDiscriminatorValue); } },
                { "customAuthenticationExtensions", n => { CustomAuthenticationExtensions = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.CustomAuthenticationExtension>(global::Microsoft.Graph.Beta.Models.CustomAuthenticationExtension.CreateFromDiscriminatorValue)?.AsList(); } },
                { "identityProviders", n => { IdentityProviders = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.IdentityProviderBase>(global::Microsoft.Graph.Beta.Models.IdentityProviderBase.CreateFromDiscriminatorValue)?.AsList(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "productChanges", n => { ProductChanges = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ChangeItemBase>(global::Microsoft.Graph.Beta.Models.ChangeItemBase.CreateFromDiscriminatorValue)?.AsList(); } },
                { "userFlowAttributes", n => { UserFlowAttributes = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.IdentityUserFlowAttribute>(global::Microsoft.Graph.Beta.Models.IdentityUserFlowAttribute.CreateFromDiscriminatorValue)?.AsList(); } },
                { "userFlows", n => { UserFlows = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.IdentityUserFlow>(global::Microsoft.Graph.Beta.Models.IdentityUserFlow.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.IdentityApiConnector>("apiConnectors", ApiConnectors);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AuthenticationEventListener>("authenticationEventListeners", AuthenticationEventListeners);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AuthenticationEventsFlow>("authenticationEventsFlows", AuthenticationEventsFlows);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.B2cIdentityUserFlow>("b2cUserFlows", B2cUserFlows);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.B2xIdentityUserFlow>("b2xUserFlows", B2xUserFlows);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.ConditionalAccessRoot>("conditionalAccess", ConditionalAccess);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.ContinuousAccessEvaluationPolicy>("continuousAccessEvaluationPolicy", ContinuousAccessEvaluationPolicy);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.CustomAuthenticationExtension>("customAuthenticationExtensions", CustomAuthenticationExtensions);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.IdentityProviderBase>("identityProviders", IdentityProviders);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ChangeItemBase>("productChanges", ProductChanges);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.IdentityUserFlowAttribute>("userFlowAttributes", UserFlowAttributes);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.IdentityUserFlow>("userFlows", UserFlows);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
