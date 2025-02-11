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
    public partial class TeamTemplateDefinition : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Describes the audience the team template is available to. The possible values are: organization, user, public, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Beta.Models.TeamTemplateAudience? Audience
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.TeamTemplateAudience?>("audience"); }
            set { BackingStore?.Set("audience", value); }
        }
        /// <summary>The assigned categories for the team template.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Categories
        {
            get { return BackingStore?.Get<List<string>?>("categories"); }
            set { BackingStore?.Set("categories", value); }
        }
#nullable restore
#else
        public List<string> Categories
        {
            get { return BackingStore?.Get<List<string>>("categories"); }
            set { BackingStore?.Set("categories", value); }
        }
#endif
        /// <summary>A brief description of the team template as it will appear to the users in Microsoft Teams.</summary>
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
        /// <summary>The user defined name of the team template.</summary>
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
        /// <summary>The icon url for the team template.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IconUrl
        {
            get { return BackingStore?.Get<string?>("iconUrl"); }
            set { BackingStore?.Set("iconUrl", value); }
        }
#nullable restore
#else
        public string IconUrl
        {
            get { return BackingStore?.Get<string>("iconUrl"); }
            set { BackingStore?.Set("iconUrl", value); }
        }
#endif
        /// <summary>Language the template is available in.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LanguageTag
        {
            get { return BackingStore?.Get<string?>("languageTag"); }
            set { BackingStore?.Set("languageTag", value); }
        }
#nullable restore
#else
        public string LanguageTag
        {
            get { return BackingStore?.Get<string>("languageTag"); }
            set { BackingStore?.Set("languageTag", value); }
        }
#endif
        /// <summary>The identity of the user who last modified the team template.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.IdentitySet? LastModifiedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.IdentitySet?>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.IdentitySet LastModifiedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.IdentitySet>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#endif
        /// <summary>The date time of when the team template was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The templateId for the team template</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ParentTemplateId
        {
            get { return BackingStore?.Get<string?>("parentTemplateId"); }
            set { BackingStore?.Set("parentTemplateId", value); }
        }
#nullable restore
#else
        public string ParentTemplateId
        {
            get { return BackingStore?.Get<string>("parentTemplateId"); }
            set { BackingStore?.Set("parentTemplateId", value); }
        }
#endif
        /// <summary>The organization which published the team template.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PublisherName
        {
            get { return BackingStore?.Get<string?>("publisherName"); }
            set { BackingStore?.Set("publisherName", value); }
        }
#nullable restore
#else
        public string PublisherName
        {
            get { return BackingStore?.Get<string>("publisherName"); }
            set { BackingStore?.Set("publisherName", value); }
        }
#endif
        /// <summary>A short-description of the team template as it will appear to the users in Microsoft Teams.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ShortDescription
        {
            get { return BackingStore?.Get<string?>("shortDescription"); }
            set { BackingStore?.Set("shortDescription", value); }
        }
#nullable restore
#else
        public string ShortDescription
        {
            get { return BackingStore?.Get<string>("shortDescription"); }
            set { BackingStore?.Set("shortDescription", value); }
        }
#endif
        /// <summary>Collection of channel objects. A channel represents a topic, and therefore a logical isolation of discussion, within a team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.Team? TeamDefinition
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Team?>("teamDefinition"); }
            set { BackingStore?.Set("teamDefinition", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.Team TeamDefinition
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Team>("teamDefinition"); }
            set { BackingStore?.Set("teamDefinition", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.TeamTemplateDefinition"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.TeamTemplateDefinition CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.TeamTemplateDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "audience", n => { Audience = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.TeamTemplateAudience>(); } },
                { "categories", n => { Categories = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "iconUrl", n => { IconUrl = n.GetStringValue(); } },
                { "languageTag", n => { LanguageTag = n.GetStringValue(); } },
                { "lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.IdentitySet>(global::Microsoft.Graph.Beta.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "parentTemplateId", n => { ParentTemplateId = n.GetStringValue(); } },
                { "publisherName", n => { PublisherName = n.GetStringValue(); } },
                { "shortDescription", n => { ShortDescription = n.GetStringValue(); } },
                { "teamDefinition", n => { TeamDefinition = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.Team>(global::Microsoft.Graph.Beta.Models.Team.CreateFromDiscriminatorValue); } },
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
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.TeamTemplateAudience>("audience", Audience);
            writer.WriteCollectionOfPrimitiveValues<string>("categories", Categories);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("iconUrl", IconUrl);
            writer.WriteStringValue("languageTag", LanguageTag);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("parentTemplateId", ParentTemplateId);
            writer.WriteStringValue("publisherName", PublisherName);
            writer.WriteStringValue("shortDescription", ShortDescription);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.Team>("teamDefinition", TeamDefinition);
        }
    }
}
#pragma warning restore CS0618
