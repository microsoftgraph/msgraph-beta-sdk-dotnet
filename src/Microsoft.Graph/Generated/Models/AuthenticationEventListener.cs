// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class AuthenticationEventListener : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The identifier of the authenticationEventsFlow object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AuthenticationEventsFlowId
        {
            get { return BackingStore?.Get<string?>("authenticationEventsFlowId"); }
            set { BackingStore?.Set("authenticationEventsFlowId", value); }
        }
#nullable restore
#else
        public string AuthenticationEventsFlowId
        {
            get { return BackingStore?.Get<string>("authenticationEventsFlowId"); }
            set { BackingStore?.Set("authenticationEventsFlowId", value); }
        }
#endif
        /// <summary>The conditions on which this authenticationEventListener should trigger.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.AuthenticationConditions? Conditions
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AuthenticationConditions?>("conditions"); }
            set { BackingStore?.Set("conditions", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.AuthenticationConditions Conditions
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AuthenticationConditions>("conditions"); }
            set { BackingStore?.Set("conditions", value); }
        }
#endif
        /// <summary>The priority of this handler. Between 0 (lower priority) and 1000 (higher priority).</summary>
        public int? Priority
        {
            get { return BackingStore?.Get<int?>("priority"); }
            set { BackingStore?.Set("priority", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.AuthenticationEventListener"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.AuthenticationEventListener CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.onAttributeCollectionListener" => new global::Microsoft.Graph.Beta.Models.OnAttributeCollectionListener(),
                "#microsoft.graph.onAttributeCollectionStartListener" => new global::Microsoft.Graph.Beta.Models.OnAttributeCollectionStartListener(),
                "#microsoft.graph.onAttributeCollectionSubmitListener" => new global::Microsoft.Graph.Beta.Models.OnAttributeCollectionSubmitListener(),
                "#microsoft.graph.onAuthenticationMethodLoadStartListener" => new global::Microsoft.Graph.Beta.Models.OnAuthenticationMethodLoadStartListener(),
                "#microsoft.graph.onEmailOtpSendListener" => new global::Microsoft.Graph.Beta.Models.OnEmailOtpSendListener(),
                "#microsoft.graph.onInteractiveAuthFlowStartListener" => new global::Microsoft.Graph.Beta.Models.OnInteractiveAuthFlowStartListener(),
                "#microsoft.graph.onPhoneMethodLoadStartListener" => new global::Microsoft.Graph.Beta.Models.OnPhoneMethodLoadStartListener(),
                "#microsoft.graph.onTokenIssuanceStartListener" => new global::Microsoft.Graph.Beta.Models.OnTokenIssuanceStartListener(),
                "#microsoft.graph.onUserCreateStartListener" => new global::Microsoft.Graph.Beta.Models.OnUserCreateStartListener(),
                _ => new global::Microsoft.Graph.Beta.Models.AuthenticationEventListener(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "authenticationEventsFlowId", n => { AuthenticationEventsFlowId = n.GetStringValue(); } },
                { "conditions", n => { Conditions = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.AuthenticationConditions>(global::Microsoft.Graph.Beta.Models.AuthenticationConditions.CreateFromDiscriminatorValue); } },
                { "priority", n => { Priority = n.GetIntValue(); } },
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
            writer.WriteStringValue("authenticationEventsFlowId", AuthenticationEventsFlowId);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.AuthenticationConditions>("conditions", Conditions);
            writer.WriteIntValue("priority", Priority);
        }
    }
}
#pragma warning restore CS0618
