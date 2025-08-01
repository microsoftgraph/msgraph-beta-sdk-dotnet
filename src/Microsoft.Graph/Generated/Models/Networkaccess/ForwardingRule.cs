// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models.Networkaccess
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class ForwardingRule : global::Microsoft.Graph.Beta.Models.Networkaccess.PolicyRule, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The action property</summary>
        public global::Microsoft.Graph.Beta.Models.Networkaccess.ForwardingRuleAction? Action
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Networkaccess.ForwardingRuleAction?>("action"); }
            set { BackingStore?.Set("action", value); }
        }
        /// <summary>The clientFallbackAction property</summary>
        public global::Microsoft.Graph.Beta.Models.Networkaccess.ClientFallbackAction? ClientFallbackAction
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Networkaccess.ClientFallbackAction?>("clientFallbackAction"); }
            set { BackingStore?.Set("clientFallbackAction", value); }
        }
        /// <summary>Destinations maintain a list of potential destinations and destination types that the user may access within the context of a network filtering policy. This includes IP addresses and fully qualified domain names (FQDNs)/URLs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Networkaccess.RuleDestination>? Destinations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Networkaccess.RuleDestination>?>("destinations"); }
            set { BackingStore?.Set("destinations", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Networkaccess.RuleDestination> Destinations
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Networkaccess.RuleDestination>>("destinations"); }
            set { BackingStore?.Set("destinations", value); }
        }
#endif
        /// <summary>The ruleType property</summary>
        public global::Microsoft.Graph.Beta.Models.Networkaccess.NetworkDestinationType? RuleType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Networkaccess.NetworkDestinationType?>("ruleType"); }
            set { BackingStore?.Set("ruleType", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.Networkaccess.ForwardingRule"/> and sets the default values.
        /// </summary>
        public ForwardingRule() : base()
        {
            OdataType = "#microsoft.graph.networkaccess.forwardingRule";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Networkaccess.ForwardingRule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.Networkaccess.ForwardingRule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.networkaccess.internetAccessForwardingRule" => new global::Microsoft.Graph.Beta.Models.Networkaccess.InternetAccessForwardingRule(),
                "#microsoft.graph.networkaccess.m365ForwardingRule" => new global::Microsoft.Graph.Beta.Models.Networkaccess.M365ForwardingRule(),
                "#microsoft.graph.networkaccess.privateAccessForwardingRule" => new global::Microsoft.Graph.Beta.Models.Networkaccess.PrivateAccessForwardingRule(),
                _ => new global::Microsoft.Graph.Beta.Models.Networkaccess.ForwardingRule(),
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
                { "action", n => { Action = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Networkaccess.ForwardingRuleAction>(); } },
                { "clientFallbackAction", n => { ClientFallbackAction = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Networkaccess.ClientFallbackAction>(); } },
                { "destinations", n => { Destinations = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Networkaccess.RuleDestination>(global::Microsoft.Graph.Beta.Models.Networkaccess.RuleDestination.CreateFromDiscriminatorValue)?.AsList(); } },
                { "ruleType", n => { RuleType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Networkaccess.NetworkDestinationType>(); } },
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
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Networkaccess.ForwardingRuleAction>("action", Action);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Networkaccess.ClientFallbackAction>("clientFallbackAction", ClientFallbackAction);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Networkaccess.RuleDestination>("destinations", Destinations);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Networkaccess.NetworkDestinationType>("ruleType", RuleType);
        }
    }
}
#pragma warning restore CS0618
