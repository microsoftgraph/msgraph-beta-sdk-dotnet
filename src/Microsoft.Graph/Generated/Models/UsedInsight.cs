// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class UsedInsight : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Information about when the item was last viewed or modified by the user. Read only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.UsageDetails? LastUsed
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.UsageDetails?>("lastUsed"); }
            set { BackingStore?.Set("lastUsed", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.UsageDetails LastUsed
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.UsageDetails>("lastUsed"); }
            set { BackingStore?.Set("lastUsed", value); }
        }
#endif
        /// <summary>Used for navigating to the item that was used. For file attachments, the type is fileAttachment. For linked attachments, the type is driveItem.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Entity? Resource
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Entity?>("resource"); }
            set { BackingStore?.Set("resource", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Entity Resource
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Entity>("resource"); }
            set { BackingStore?.Set("resource", value); }
        }
#endif
        /// <summary>Reference properties of the used document, such as the url and type of the document. Read-only</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.ResourceReference? ResourceReference
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ResourceReference?>("resourceReference"); }
            set { BackingStore?.Set("resourceReference", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.ResourceReference ResourceReference
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ResourceReference>("resourceReference"); }
            set { BackingStore?.Set("resourceReference", value); }
        }
#endif
        /// <summary>Properties that you can use to visualize the document in your experience. Read-only</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.ResourceVisualization? ResourceVisualization
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ResourceVisualization?>("resourceVisualization"); }
            set { BackingStore?.Set("resourceVisualization", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.ResourceVisualization ResourceVisualization
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ResourceVisualization>("resourceVisualization"); }
            set { BackingStore?.Set("resourceVisualization", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.UsedInsight"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.UsedInsight CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.UsedInsight();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "lastUsed", n => { LastUsed = n.GetObjectValue<Microsoft.Graph.Beta.Models.UsageDetails>(Microsoft.Graph.Beta.Models.UsageDetails.CreateFromDiscriminatorValue); } },
                { "resource", n => { Resource = n.GetObjectValue<Microsoft.Graph.Beta.Models.Entity>(Microsoft.Graph.Beta.Models.Entity.CreateFromDiscriminatorValue); } },
                { "resourceReference", n => { ResourceReference = n.GetObjectValue<Microsoft.Graph.Beta.Models.ResourceReference>(Microsoft.Graph.Beta.Models.ResourceReference.CreateFromDiscriminatorValue); } },
                { "resourceVisualization", n => { ResourceVisualization = n.GetObjectValue<Microsoft.Graph.Beta.Models.ResourceVisualization>(Microsoft.Graph.Beta.Models.ResourceVisualization.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.UsageDetails>("lastUsed", LastUsed);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Entity>("resource", Resource);
        }
    }
}
