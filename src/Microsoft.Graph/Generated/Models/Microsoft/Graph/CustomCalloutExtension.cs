using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class CustomCalloutExtension : Entity, IParsable {
        /// <summary>Configuration for securing the API call to the logic app. For example, using OAuth client credentials flow.</summary>
        public CustomExtensionAuthenticationConfiguration AuthenticationConfiguration { get; set; }
        /// <summary>HTTP connection settings that define how long Azure AD can wait for a connection to a logic app, how many times you can retry a timed-out connection and the exception scenarios when retries are allowed.</summary>
        public CustomExtensionClientConfiguration ClientConfiguration { get; set; }
        /// <summary>Description for the customCalloutExtension object.</summary>
        public string Description { get; set; }
        /// <summary>Display name for the customCalloutExtension object.</summary>
        public string DisplayName { get; set; }
        /// <summary>The type and details for configuring the endpoint to call the logic app's workflow.</summary>
        public CustomExtensionEndpointConfiguration EndpointConfiguration { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"authenticationConfiguration", (o,n) => { (o as CustomCalloutExtension).AuthenticationConfiguration = n.GetObjectValue<CustomExtensionAuthenticationConfiguration>(); } },
                {"clientConfiguration", (o,n) => { (o as CustomCalloutExtension).ClientConfiguration = n.GetObjectValue<CustomExtensionClientConfiguration>(); } },
                {"description", (o,n) => { (o as CustomCalloutExtension).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as CustomCalloutExtension).DisplayName = n.GetStringValue(); } },
                {"endpointConfiguration", (o,n) => { (o as CustomCalloutExtension).EndpointConfiguration = n.GetObjectValue<CustomExtensionEndpointConfiguration>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
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
