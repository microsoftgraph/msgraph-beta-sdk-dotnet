// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates {
    public class KnownIssue : Microsoft.Graph.Beta.Models.Entity, IParsable 
    {
        /// <summary>The description of the particular known issue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The knownIssueHistories property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KnownIssueHistoryItem>? KnownIssueHistories {
            get { return BackingStore?.Get<List<KnownIssueHistoryItem>?>("knownIssueHistories"); }
            set { BackingStore?.Set("knownIssueHistories", value); }
        }
#nullable restore
#else
        public List<KnownIssueHistoryItem> KnownIssueHistories {
            get { return BackingStore?.Get<List<KnownIssueHistoryItem>>("knownIssueHistories"); }
            set { BackingStore?.Set("knownIssueHistories", value); }
        }
#endif
        /// <summary>The date and time when the known issue was last updated. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? LastUpdatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastUpdatedDateTime"); }
            set { BackingStore?.Set("lastUpdatedDateTime", value); }
        }
        /// <summary>Knowledge base article associated with the release when the known issue was first reported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KnowledgeBaseArticle? OriginatingKnowledgeBaseArticle {
            get { return BackingStore?.Get<KnowledgeBaseArticle?>("originatingKnowledgeBaseArticle"); }
            set { BackingStore?.Set("originatingKnowledgeBaseArticle", value); }
        }
#nullable restore
#else
        public KnowledgeBaseArticle OriginatingKnowledgeBaseArticle {
            get { return BackingStore?.Get<KnowledgeBaseArticle>("originatingKnowledgeBaseArticle"); }
            set { BackingStore?.Set("originatingKnowledgeBaseArticle", value); }
        }
#endif
        /// <summary>The date and time when the known issue was resolved or mitigated. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? ResolvedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("resolvedDateTime"); }
            set { BackingStore?.Set("resolvedDateTime", value); }
        }
        /// <summary>Knowledge base article associated with the release when the known issue was resolved or mitigated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KnowledgeBaseArticle? ResolvingKnowledgeBaseArticle {
            get { return BackingStore?.Get<KnowledgeBaseArticle?>("resolvingKnowledgeBaseArticle"); }
            set { BackingStore?.Set("resolvingKnowledgeBaseArticle", value); }
        }
#nullable restore
#else
        public KnowledgeBaseArticle ResolvingKnowledgeBaseArticle {
            get { return BackingStore?.Get<KnowledgeBaseArticle>("resolvingKnowledgeBaseArticle"); }
            set { BackingStore?.Set("resolvingKnowledgeBaseArticle", value); }
        }
#endif
        /// <summary>The safeguardHoldIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? SafeguardHoldIds {
            get { return BackingStore?.Get<List<int?>?>("safeguardHoldIds"); }
            set { BackingStore?.Set("safeguardHoldIds", value); }
        }
#nullable restore
#else
        public List<int?> SafeguardHoldIds {
            get { return BackingStore?.Get<List<int?>>("safeguardHoldIds"); }
            set { BackingStore?.Set("safeguardHoldIds", value); }
        }
#endif
        /// <summary>The date and time when the known issue was first reported. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? StartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
        /// <summary>The status property</summary>
        public WindowsReleaseHealthStatus? Status {
            get { return BackingStore?.Get<WindowsReleaseHealthStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>The title of the known issue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title {
            get { return BackingStore?.Get<string?>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#nullable restore
#else
        public string Title {
            get { return BackingStore?.Get<string>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#endif
        /// <summary>The URL to the known issue in the Windows Release Health dashboard on Microsoft 365 admin center.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebViewUrl {
            get { return BackingStore?.Get<string?>("webViewUrl"); }
            set { BackingStore?.Set("webViewUrl", value); }
        }
#nullable restore
#else
        public string WebViewUrl {
            get { return BackingStore?.Get<string>("webViewUrl"); }
            set { BackingStore?.Set("webViewUrl", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="KnownIssue"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new KnownIssue CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KnownIssue();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"description", n => { Description = n.GetStringValue(); } },
                {"knownIssueHistories", n => { KnownIssueHistories = n.GetCollectionOfObjectValues<KnownIssueHistoryItem>(KnownIssueHistoryItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"originatingKnowledgeBaseArticle", n => { OriginatingKnowledgeBaseArticle = n.GetObjectValue<KnowledgeBaseArticle>(KnowledgeBaseArticle.CreateFromDiscriminatorValue); } },
                {"resolvedDateTime", n => { ResolvedDateTime = n.GetDateTimeOffsetValue(); } },
                {"resolvingKnowledgeBaseArticle", n => { ResolvingKnowledgeBaseArticle = n.GetObjectValue<KnowledgeBaseArticle>(KnowledgeBaseArticle.CreateFromDiscriminatorValue); } },
                {"safeguardHoldIds", n => { SafeguardHoldIds = n.GetCollectionOfPrimitiveValues<int?>()?.ToList(); } },
                {"startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", n => { Status = n.GetEnumValue<WindowsReleaseHealthStatus>(); } },
                {"title", n => { Title = n.GetStringValue(); } },
                {"webViewUrl", n => { WebViewUrl = n.GetStringValue(); } },
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
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfObjectValues<KnownIssueHistoryItem>("knownIssueHistories", KnownIssueHistories);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteObjectValue<KnowledgeBaseArticle>("originatingKnowledgeBaseArticle", OriginatingKnowledgeBaseArticle);
            writer.WriteDateTimeOffsetValue("resolvedDateTime", ResolvedDateTime);
            writer.WriteObjectValue<KnowledgeBaseArticle>("resolvingKnowledgeBaseArticle", ResolvingKnowledgeBaseArticle);
            writer.WriteCollectionOfPrimitiveValues<int?>("safeguardHoldIds", SafeguardHoldIds);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteEnumValue<WindowsReleaseHealthStatus>("status", Status);
            writer.WriteStringValue("title", Title);
            writer.WriteStringValue("webViewUrl", WebViewUrl);
        }
    }
}
