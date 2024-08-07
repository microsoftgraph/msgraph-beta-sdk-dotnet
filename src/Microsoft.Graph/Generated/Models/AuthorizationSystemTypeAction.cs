// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class AuthorizationSystemTypeAction : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The type of action allowed in the authorization system&apos;s service. The possible values are: delete, read, unknownFutureValue. Supports $filter and (eq).</summary>
        public Microsoft.Graph.Beta.Models.AuthorizationSystemActionType? ActionType
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AuthorizationSystemActionType?>("actionType"); }
            set { BackingStore?.Set("actionType", value); }
        }
        /// <summary>The display name of an action. Read-only. Supports $filter and (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalId
        {
            get { return BackingStore?.Get<string?>("externalId"); }
            set { BackingStore?.Set("externalId", value); }
        }
#nullable restore
#else
        public string ExternalId
        {
            get { return BackingStore?.Get<string>("externalId"); }
            set { BackingStore?.Set("externalId", value); }
        }
#endif
        /// <summary>The resource types in the authorization system&apos;s service where the action can be performed. Supports $filter and (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ResourceTypes
        {
            get { return BackingStore?.Get<List<string>?>("resourceTypes"); }
            set { BackingStore?.Set("resourceTypes", value); }
        }
#nullable restore
#else
        public List<string> ResourceTypes
        {
            get { return BackingStore?.Get<List<string>>("resourceTypes"); }
            set { BackingStore?.Set("resourceTypes", value); }
        }
#endif
        /// <summary>The severity property</summary>
        public Microsoft.Graph.Beta.Models.AuthorizationSystemActionSeverity? Severity
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AuthorizationSystemActionSeverity?>("severity"); }
            set { BackingStore?.Set("severity", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.AuthorizationSystemTypeAction"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.AuthorizationSystemTypeAction CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.awsAuthorizationSystemTypeAction" => new Microsoft.Graph.Beta.Models.AwsAuthorizationSystemTypeAction(),
                "#microsoft.graph.azureAuthorizationSystemTypeAction" => new Microsoft.Graph.Beta.Models.AzureAuthorizationSystemTypeAction(),
                "#microsoft.graph.gcpAuthorizationSystemTypeAction" => new Microsoft.Graph.Beta.Models.GcpAuthorizationSystemTypeAction(),
                _ => new Microsoft.Graph.Beta.Models.AuthorizationSystemTypeAction(),
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
                { "actionType", n => { ActionType = n.GetEnumValue<Microsoft.Graph.Beta.Models.AuthorizationSystemActionType>(); } },
                { "externalId", n => { ExternalId = n.GetStringValue(); } },
                { "resourceTypes", n => { ResourceTypes = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "severity", n => { Severity = n.GetEnumValue<Microsoft.Graph.Beta.Models.AuthorizationSystemActionSeverity>(); } },
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
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.AuthorizationSystemActionType>("actionType", ActionType);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteCollectionOfPrimitiveValues<string>("resourceTypes", ResourceTypes);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.AuthorizationSystemActionSeverity>("severity", Severity);
        }
    }
}
