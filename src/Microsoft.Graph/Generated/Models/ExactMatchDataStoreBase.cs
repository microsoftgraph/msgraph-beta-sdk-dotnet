// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class ExactMatchDataStoreBase : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The columns property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.ExactDataMatchStoreColumn>? Columns
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ExactDataMatchStoreColumn>?>("columns"); }
            set { BackingStore?.Set("columns", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.ExactDataMatchStoreColumn> Columns
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ExactDataMatchStoreColumn>>("columns"); }
            set { BackingStore?.Set("columns", value); }
        }
#endif
        /// <summary>The dataLastUpdatedDateTime property</summary>
        public DateTimeOffset? DataLastUpdatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("dataLastUpdatedDateTime"); }
            set { BackingStore?.Set("dataLastUpdatedDateTime", value); }
        }
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
        /// <summary>The displayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.ExactMatchDataStoreBase"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.ExactMatchDataStoreBase CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.exactMatchDataStore" => new Microsoft.Graph.Beta.Models.ExactMatchDataStore(),
                _ => new Microsoft.Graph.Beta.Models.ExactMatchDataStoreBase(),
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
                { "columns", n => { Columns = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ExactDataMatchStoreColumn>(Microsoft.Graph.Beta.Models.ExactDataMatchStoreColumn.CreateFromDiscriminatorValue)?.ToList(); } },
                { "dataLastUpdatedDateTime", n => { DataLastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
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
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ExactDataMatchStoreColumn>("columns", Columns);
            writer.WriteDateTimeOffsetValue("dataLastUpdatedDateTime", DataLastUpdatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
        }
    }
}
