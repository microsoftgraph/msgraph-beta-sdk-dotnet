// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models.Ediscovery
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Custodian : global::Microsoft.Graph.Beta.Models.Ediscovery.DataSourceContainer, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Date and time the custodian acknowledged a hold notification.</summary>
        public DateTimeOffset? AcknowledgedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("acknowledgedDateTime"); }
            set { BackingStore?.Set("acknowledgedDateTime", value); }
        }
        /// <summary>Identifies whether a custodian&apos;s sources were placed on hold during creation.</summary>
        public bool? ApplyHoldToSources
        {
            get { return BackingStore?.Get<bool?>("applyHoldToSources"); }
            set { BackingStore?.Set("applyHoldToSources", value); }
        }
        /// <summary>Email address of the custodian.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email
        {
            get { return BackingStore?.Get<string?>("email"); }
            set { BackingStore?.Set("email", value); }
        }
#nullable restore
#else
        public string Email
        {
            get { return BackingStore?.Get<string>("email"); }
            set { BackingStore?.Set("email", value); }
        }
#endif
        /// <summary>Data source entity for SharePoint sites associated with the custodian.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Ediscovery.SiteSource>? SiteSources
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Ediscovery.SiteSource>?>("siteSources"); }
            set { BackingStore?.Set("siteSources", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Ediscovery.SiteSource> SiteSources
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Ediscovery.SiteSource>>("siteSources"); }
            set { BackingStore?.Set("siteSources", value); }
        }
#endif
        /// <summary>Data source entity for groups associated with the custodian.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Ediscovery.UnifiedGroupSource>? UnifiedGroupSources
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Ediscovery.UnifiedGroupSource>?>("unifiedGroupSources"); }
            set { BackingStore?.Set("unifiedGroupSources", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Ediscovery.UnifiedGroupSource> UnifiedGroupSources
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Ediscovery.UnifiedGroupSource>>("unifiedGroupSources"); }
            set { BackingStore?.Set("unifiedGroupSources", value); }
        }
#endif
        /// <summary>Data source entity for a the custodian. This is the container for a custodian&apos;s mailbox and OneDrive for Business site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Ediscovery.UserSource>? UserSources
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Ediscovery.UserSource>?>("userSources"); }
            set { BackingStore?.Set("userSources", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Ediscovery.UserSource> UserSources
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Ediscovery.UserSource>>("userSources"); }
            set { BackingStore?.Set("userSources", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.Ediscovery.Custodian"/> and sets the default values.
        /// </summary>
        public Custodian() : base()
        {
            OdataType = "#microsoft.graph.ediscovery.custodian";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Ediscovery.Custodian"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.Ediscovery.Custodian CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.Ediscovery.Custodian();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "acknowledgedDateTime", n => { AcknowledgedDateTime = n.GetDateTimeOffsetValue(); } },
                { "applyHoldToSources", n => { ApplyHoldToSources = n.GetBoolValue(); } },
                { "email", n => { Email = n.GetStringValue(); } },
                { "siteSources", n => { SiteSources = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Ediscovery.SiteSource>(global::Microsoft.Graph.Beta.Models.Ediscovery.SiteSource.CreateFromDiscriminatorValue)?.AsList(); } },
                { "unifiedGroupSources", n => { UnifiedGroupSources = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Ediscovery.UnifiedGroupSource>(global::Microsoft.Graph.Beta.Models.Ediscovery.UnifiedGroupSource.CreateFromDiscriminatorValue)?.AsList(); } },
                { "userSources", n => { UserSources = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Ediscovery.UserSource>(global::Microsoft.Graph.Beta.Models.Ediscovery.UserSource.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteDateTimeOffsetValue("acknowledgedDateTime", AcknowledgedDateTime);
            writer.WriteBoolValue("applyHoldToSources", ApplyHoldToSources);
            writer.WriteStringValue("email", Email);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Ediscovery.SiteSource>("siteSources", SiteSources);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Ediscovery.UnifiedGroupSource>("unifiedGroupSources", UnifiedGroupSources);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Ediscovery.UserSource>("userSources", UserSources);
        }
    }
}
#pragma warning restore CS0618
