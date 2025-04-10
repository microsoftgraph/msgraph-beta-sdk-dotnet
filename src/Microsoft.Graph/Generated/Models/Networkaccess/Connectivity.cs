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
    public partial class Connectivity : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The locations for connectivity. DEPRECATED AND TO BE RETIRED SOON. Use the remoteNetwork relationship and its associated APIs instead.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Networkaccess.BranchSite>? Branches
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Networkaccess.BranchSite>?>("branches"); }
            set { BackingStore?.Set("branches", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Networkaccess.BranchSite> Branches
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Networkaccess.BranchSite>>("branches"); }
            set { BackingStore?.Set("branches", value); }
        }
#endif
        /// <summary>The locations, such as branches, that are connected to Global Secure Access services through an IPsec tunnel.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Networkaccess.RemoteNetwork>? RemoteNetworks
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Networkaccess.RemoteNetwork>?>("remoteNetworks"); }
            set { BackingStore?.Set("remoteNetworks", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Networkaccess.RemoteNetwork> RemoteNetworks
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Networkaccess.RemoteNetwork>>("remoteNetworks"); }
            set { BackingStore?.Set("remoteNetworks", value); }
        }
#endif
        /// <summary>The webCategories property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Networkaccess.WebCategory>? WebCategories
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Networkaccess.WebCategory>?>("webCategories"); }
            set { BackingStore?.Set("webCategories", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Networkaccess.WebCategory> WebCategories
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Networkaccess.WebCategory>>("webCategories"); }
            set { BackingStore?.Set("webCategories", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Networkaccess.Connectivity"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.Networkaccess.Connectivity CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.Networkaccess.Connectivity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "branches", n => { Branches = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Networkaccess.BranchSite>(global::Microsoft.Graph.Beta.Models.Networkaccess.BranchSite.CreateFromDiscriminatorValue)?.AsList(); } },
                { "remoteNetworks", n => { RemoteNetworks = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Networkaccess.RemoteNetwork>(global::Microsoft.Graph.Beta.Models.Networkaccess.RemoteNetwork.CreateFromDiscriminatorValue)?.AsList(); } },
                { "webCategories", n => { WebCategories = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Networkaccess.WebCategory>(global::Microsoft.Graph.Beta.Models.Networkaccess.WebCategory.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Networkaccess.BranchSite>("branches", Branches);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Networkaccess.RemoteNetwork>("remoteNetworks", RemoteNetworks);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Networkaccess.WebCategory>("webCategories", WebCategories);
        }
    }
}
#pragma warning restore CS0618
