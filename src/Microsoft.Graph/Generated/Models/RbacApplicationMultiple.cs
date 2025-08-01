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
    public partial class RbacApplicationMultiple : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The resourceNamespaces property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.UnifiedRbacResourceNamespace>? ResourceNamespaces
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.UnifiedRbacResourceNamespace>?>("resourceNamespaces"); }
            set { BackingStore?.Set("resourceNamespaces", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.UnifiedRbacResourceNamespace> ResourceNamespaces
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.UnifiedRbacResourceNamespace>>("resourceNamespaces"); }
            set { BackingStore?.Set("resourceNamespaces", value); }
        }
#endif
        /// <summary>The roleAssignments property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.UnifiedRoleAssignmentMultiple>? RoleAssignments
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.UnifiedRoleAssignmentMultiple>?>("roleAssignments"); }
            set { BackingStore?.Set("roleAssignments", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.UnifiedRoleAssignmentMultiple> RoleAssignments
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.UnifiedRoleAssignmentMultiple>>("roleAssignments"); }
            set { BackingStore?.Set("roleAssignments", value); }
        }
#endif
        /// <summary>The roleDefinitions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.UnifiedRoleDefinition>? RoleDefinitions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.UnifiedRoleDefinition>?>("roleDefinitions"); }
            set { BackingStore?.Set("roleDefinitions", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.UnifiedRoleDefinition> RoleDefinitions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.UnifiedRoleDefinition>>("roleDefinitions"); }
            set { BackingStore?.Set("roleDefinitions", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.RbacApplicationMultiple"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.RbacApplicationMultiple CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.unifiedRbacApplicationMultiple" => new global::Microsoft.Graph.Beta.Models.UnifiedRbacApplicationMultiple(),
                _ => new global::Microsoft.Graph.Beta.Models.RbacApplicationMultiple(),
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
                { "resourceNamespaces", n => { ResourceNamespaces = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.UnifiedRbacResourceNamespace>(global::Microsoft.Graph.Beta.Models.UnifiedRbacResourceNamespace.CreateFromDiscriminatorValue)?.AsList(); } },
                { "roleAssignments", n => { RoleAssignments = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.UnifiedRoleAssignmentMultiple>(global::Microsoft.Graph.Beta.Models.UnifiedRoleAssignmentMultiple.CreateFromDiscriminatorValue)?.AsList(); } },
                { "roleDefinitions", n => { RoleDefinitions = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.UnifiedRoleDefinition>(global::Microsoft.Graph.Beta.Models.UnifiedRoleDefinition.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.UnifiedRbacResourceNamespace>("resourceNamespaces", ResourceNamespaces);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.UnifiedRoleAssignmentMultiple>("roleAssignments", RoleAssignments);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.UnifiedRoleDefinition>("roleDefinitions", RoleDefinitions);
        }
    }
}
#pragma warning restore CS0618
