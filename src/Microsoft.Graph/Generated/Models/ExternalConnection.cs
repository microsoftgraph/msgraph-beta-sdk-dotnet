// <auto-generated/>
using Microsoft.Graph.Beta.Models.TeamsUserConfiguration;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class ExternalConnection : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The configuration property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.TeamsUserConfiguration.Configuration? Configuration
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TeamsUserConfiguration.Configuration?>("configuration"); }
            set { BackingStore?.Set("configuration", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.TeamsUserConfiguration.Configuration Configuration
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TeamsUserConfiguration.Configuration>("configuration"); }
            set { BackingStore?.Set("configuration", value); }
        }
#endif
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description
        {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description
        {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The groups property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.ExternalGroup>? Groups
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ExternalGroup>?>("groups"); }
            set { BackingStore?.Set("groups", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.ExternalGroup> Groups
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ExternalGroup>>("groups"); }
            set { BackingStore?.Set("groups", value); }
        }
#endif
        /// <summary>The items property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.ExternalItem>? Items
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ExternalItem>?>("items"); }
            set { BackingStore?.Set("items", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.ExternalItem> Items
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ExternalItem>>("items"); }
            set { BackingStore?.Set("items", value); }
        }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name
        {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name
        {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>The operations property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.ConnectionOperation>? Operations
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ConnectionOperation>?>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.ConnectionOperation> Operations
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ConnectionOperation>>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#endif
        /// <summary>The schema property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Schema? Schema
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Schema?>("schema"); }
            set { BackingStore?.Set("schema", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Schema Schema
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Schema>("schema"); }
            set { BackingStore?.Set("schema", value); }
        }
#endif
        /// <summary>The state property</summary>
        public Microsoft.Graph.Beta.Models.ConnectionState? State
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ConnectionState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.ExternalConnection"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.ExternalConnection CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.ExternalConnection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "configuration", n => { Configuration = n.GetObjectValue<Microsoft.Graph.Beta.Models.TeamsUserConfiguration.Configuration>(Microsoft.Graph.Beta.Models.TeamsUserConfiguration.Configuration.CreateFromDiscriminatorValue); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "groups", n => { Groups = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ExternalGroup>(Microsoft.Graph.Beta.Models.ExternalGroup.CreateFromDiscriminatorValue)?.ToList(); } },
                { "items", n => { Items = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ExternalItem>(Microsoft.Graph.Beta.Models.ExternalItem.CreateFromDiscriminatorValue)?.ToList(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "operations", n => { Operations = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ConnectionOperation>(Microsoft.Graph.Beta.Models.ConnectionOperation.CreateFromDiscriminatorValue)?.ToList(); } },
                { "schema", n => { Schema = n.GetObjectValue<Microsoft.Graph.Beta.Models.Schema>(Microsoft.Graph.Beta.Models.Schema.CreateFromDiscriminatorValue); } },
                { "state", n => { State = n.GetEnumValue<Microsoft.Graph.Beta.Models.ConnectionState>(); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.TeamsUserConfiguration.Configuration>("configuration", Configuration);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ExternalGroup>("groups", Groups);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ExternalItem>("items", Items);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ConnectionOperation>("operations", Operations);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Schema>("schema", Schema);
        }
    }
}
