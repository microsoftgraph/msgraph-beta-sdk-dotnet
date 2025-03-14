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
    public partial class LogicAppTriggerEndpointConfiguration : global::Microsoft.Graph.Beta.Models.CustomExtensionEndpointConfiguration, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The name of the logic app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LogicAppWorkflowName
        {
            get { return BackingStore?.Get<string?>("logicAppWorkflowName"); }
            set { BackingStore?.Set("logicAppWorkflowName", value); }
        }
#nullable restore
#else
        public string LogicAppWorkflowName
        {
            get { return BackingStore?.Get<string>("logicAppWorkflowName"); }
            set { BackingStore?.Set("logicAppWorkflowName", value); }
        }
#endif
        /// <summary>The Azure resource group name for the logic app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceGroupName
        {
            get { return BackingStore?.Get<string?>("resourceGroupName"); }
            set { BackingStore?.Set("resourceGroupName", value); }
        }
#nullable restore
#else
        public string ResourceGroupName
        {
            get { return BackingStore?.Get<string>("resourceGroupName"); }
            set { BackingStore?.Set("resourceGroupName", value); }
        }
#endif
        /// <summary>Identifier of the Azure subscription for the logic app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubscriptionId
        {
            get { return BackingStore?.Get<string?>("subscriptionId"); }
            set { BackingStore?.Set("subscriptionId", value); }
        }
#nullable restore
#else
        public string SubscriptionId
        {
            get { return BackingStore?.Get<string>("subscriptionId"); }
            set { BackingStore?.Set("subscriptionId", value); }
        }
#endif
        /// <summary>The URL to the logic app endpoint that will be triggered. Only required for app-only token scenarios where app is creating a customCalloutExtension without a signed-in user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url
        {
            get { return BackingStore?.Get<string?>("url"); }
            set { BackingStore?.Set("url", value); }
        }
#nullable restore
#else
        public string Url
        {
            get { return BackingStore?.Get<string>("url"); }
            set { BackingStore?.Set("url", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.LogicAppTriggerEndpointConfiguration"/> and sets the default values.
        /// </summary>
        public LogicAppTriggerEndpointConfiguration() : base()
        {
            OdataType = "#microsoft.graph.logicAppTriggerEndpointConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.LogicAppTriggerEndpointConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.LogicAppTriggerEndpointConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.LogicAppTriggerEndpointConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "logicAppWorkflowName", n => { LogicAppWorkflowName = n.GetStringValue(); } },
                { "resourceGroupName", n => { ResourceGroupName = n.GetStringValue(); } },
                { "subscriptionId", n => { SubscriptionId = n.GetStringValue(); } },
                { "url", n => { Url = n.GetStringValue(); } },
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
            writer.WriteStringValue("logicAppWorkflowName", LogicAppWorkflowName);
            writer.WriteStringValue("resourceGroupName", ResourceGroupName);
            writer.WriteStringValue("subscriptionId", SubscriptionId);
            writer.WriteStringValue("url", Url);
        }
    }
}
#pragma warning restore CS0618
