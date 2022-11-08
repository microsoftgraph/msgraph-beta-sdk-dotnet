using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.Models.IdentityGovernance;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class CustomCalloutExtension : Entity, IParsable {
        /// <summary>Configuration for securing the API call to the logic app. For example, using OAuth client credentials flow.</summary>
        public CustomExtensionAuthenticationConfiguration AuthenticationConfiguration {
            get { return BackingStore?.Get<CustomExtensionAuthenticationConfiguration>("authenticationConfiguration"); }
            set { BackingStore?.Set("authenticationConfiguration", value); }
        }
        /// <summary>HTTP connection settings that define how long Azure AD can wait for a connection to a logic app, how many times you can retry a timed-out connection and the exception scenarios when retries are allowed.</summary>
        public CustomExtensionClientConfiguration ClientConfiguration {
            get { return BackingStore?.Get<CustomExtensionClientConfiguration>("clientConfiguration"); }
            set { BackingStore?.Set("clientConfiguration", value); }
        }
        /// <summary>Description for the customCalloutExtension object.</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>Display name for the customCalloutExtension object.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The type and details for configuring the endpoint to call the logic app&apos;s workflow.</summary>
        public CustomExtensionEndpointConfiguration EndpointConfiguration {
            get { return BackingStore?.Get<CustomExtensionEndpointConfiguration>("endpointConfiguration"); }
            set { BackingStore?.Set("endpointConfiguration", value); }
        }
        /// <summary>
        /// Instantiates a new customCalloutExtension and sets the default values.
        /// </summary>
        public CustomCalloutExtension() : base() {
            OdataType = "#microsoft.graph.customCalloutExtension";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CustomCalloutExtension CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.customAccessPackageWorkflowExtension" => new CustomAccessPackageWorkflowExtension(),
                "#microsoft.graph.customAuthenticationExtension" => new CustomAuthenticationExtension(),
                "#microsoft.graph.identityGovernance.customTaskExtension" => new CustomTaskExtension(),
                "#microsoft.graph.onTokenIssuanceStartCustomExtension" => new OnTokenIssuanceStartCustomExtension(),
                _ => new CustomCalloutExtension(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"authenticationConfiguration", n => { AuthenticationConfiguration = n.GetObjectValue<CustomExtensionAuthenticationConfiguration>(CustomExtensionAuthenticationConfiguration.CreateFromDiscriminatorValue); } },
                {"clientConfiguration", n => { ClientConfiguration = n.GetObjectValue<CustomExtensionClientConfiguration>(CustomExtensionClientConfiguration.CreateFromDiscriminatorValue); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"endpointConfiguration", n => { EndpointConfiguration = n.GetObjectValue<CustomExtensionEndpointConfiguration>(CustomExtensionEndpointConfiguration.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<CustomExtensionAuthenticationConfiguration>("authenticationConfiguration", AuthenticationConfiguration);
            writer.WriteObjectValue<CustomExtensionClientConfiguration>("clientConfiguration", ClientConfiguration);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<CustomExtensionEndpointConfiguration>("endpointConfiguration", EndpointConfiguration);
        }
    }
}
