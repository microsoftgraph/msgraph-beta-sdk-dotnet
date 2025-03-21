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
    public partial class IdentityFinding : global::Microsoft.Graph.Beta.Models.Finding, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The actionSummary property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.ActionSummary? ActionSummary
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ActionSummary?>("actionSummary"); }
            set { BackingStore?.Set("actionSummary", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.ActionSummary ActionSummary
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ActionSummary>("actionSummary"); }
            set { BackingStore?.Set("actionSummary", value); }
        }
#endif
        /// <summary>The identity property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.AuthorizationSystemIdentity? Identity
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AuthorizationSystemIdentity?>("identity"); }
            set { BackingStore?.Set("identity", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.AuthorizationSystemIdentity Identity
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AuthorizationSystemIdentity>("identity"); }
            set { BackingStore?.Set("identity", value); }
        }
#endif
        /// <summary>An identity&apos;s information details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.IdentityDetails? IdentityDetails
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.IdentityDetails?>("identityDetails"); }
            set { BackingStore?.Set("identityDetails", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.IdentityDetails IdentityDetails
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.IdentityDetails>("identityDetails"); }
            set { BackingStore?.Set("identityDetails", value); }
        }
#endif
        /// <summary>The permissionsCreepIndex property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.PermissionsCreepIndex? PermissionsCreepIndex
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.PermissionsCreepIndex?>("permissionsCreepIndex"); }
            set { BackingStore?.Set("permissionsCreepIndex", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.PermissionsCreepIndex PermissionsCreepIndex
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.PermissionsCreepIndex>("permissionsCreepIndex"); }
            set { BackingStore?.Set("permissionsCreepIndex", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.IdentityFinding"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.IdentityFinding CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.inactiveAwsResourceFinding" => new global::Microsoft.Graph.Beta.Models.InactiveAwsResourceFinding(),
                "#microsoft.graph.inactiveAwsRoleFinding" => new global::Microsoft.Graph.Beta.Models.InactiveAwsRoleFinding(),
                "#microsoft.graph.inactiveAzureServicePrincipalFinding" => new global::Microsoft.Graph.Beta.Models.InactiveAzureServicePrincipalFinding(),
                "#microsoft.graph.inactiveGcpServiceAccountFinding" => new global::Microsoft.Graph.Beta.Models.InactiveGcpServiceAccountFinding(),
                "#microsoft.graph.inactiveServerlessFunctionFinding" => new global::Microsoft.Graph.Beta.Models.InactiveServerlessFunctionFinding(),
                "#microsoft.graph.inactiveUserFinding" => new global::Microsoft.Graph.Beta.Models.InactiveUserFinding(),
                "#microsoft.graph.overprovisionedAwsResourceFinding" => new global::Microsoft.Graph.Beta.Models.OverprovisionedAwsResourceFinding(),
                "#microsoft.graph.overprovisionedAwsRoleFinding" => new global::Microsoft.Graph.Beta.Models.OverprovisionedAwsRoleFinding(),
                "#microsoft.graph.overprovisionedAzureServicePrincipalFinding" => new global::Microsoft.Graph.Beta.Models.OverprovisionedAzureServicePrincipalFinding(),
                "#microsoft.graph.overprovisionedGcpServiceAccountFinding" => new global::Microsoft.Graph.Beta.Models.OverprovisionedGcpServiceAccountFinding(),
                "#microsoft.graph.overprovisionedServerlessFunctionFinding" => new global::Microsoft.Graph.Beta.Models.OverprovisionedServerlessFunctionFinding(),
                "#microsoft.graph.overprovisionedUserFinding" => new global::Microsoft.Graph.Beta.Models.OverprovisionedUserFinding(),
                "#microsoft.graph.superAwsResourceFinding" => new global::Microsoft.Graph.Beta.Models.SuperAwsResourceFinding(),
                "#microsoft.graph.superAwsRoleFinding" => new global::Microsoft.Graph.Beta.Models.SuperAwsRoleFinding(),
                "#microsoft.graph.superAzureServicePrincipalFinding" => new global::Microsoft.Graph.Beta.Models.SuperAzureServicePrincipalFinding(),
                "#microsoft.graph.superGcpServiceAccountFinding" => new global::Microsoft.Graph.Beta.Models.SuperGcpServiceAccountFinding(),
                "#microsoft.graph.superServerlessFunctionFinding" => new global::Microsoft.Graph.Beta.Models.SuperServerlessFunctionFinding(),
                "#microsoft.graph.superUserFinding" => new global::Microsoft.Graph.Beta.Models.SuperUserFinding(),
                "#microsoft.graph.unenforcedMfaAwsUserFinding" => new global::Microsoft.Graph.Beta.Models.UnenforcedMfaAwsUserFinding(),
                _ => new global::Microsoft.Graph.Beta.Models.IdentityFinding(),
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
                { "actionSummary", n => { ActionSummary = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.ActionSummary>(global::Microsoft.Graph.Beta.Models.ActionSummary.CreateFromDiscriminatorValue); } },
                { "identity", n => { Identity = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.AuthorizationSystemIdentity>(global::Microsoft.Graph.Beta.Models.AuthorizationSystemIdentity.CreateFromDiscriminatorValue); } },
                { "identityDetails", n => { IdentityDetails = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.IdentityDetails>(global::Microsoft.Graph.Beta.Models.IdentityDetails.CreateFromDiscriminatorValue); } },
                { "permissionsCreepIndex", n => { PermissionsCreepIndex = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.PermissionsCreepIndex>(global::Microsoft.Graph.Beta.Models.PermissionsCreepIndex.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.ActionSummary>("actionSummary", ActionSummary);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.AuthorizationSystemIdentity>("identity", Identity);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.IdentityDetails>("identityDetails", IdentityDetails);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.PermissionsCreepIndex>("permissionsCreepIndex", PermissionsCreepIndex);
        }
    }
}
#pragma warning restore CS0618
