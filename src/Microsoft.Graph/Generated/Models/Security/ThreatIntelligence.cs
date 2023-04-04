using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public class ThreatIntelligence : Entity, IParsable {
        /// <summary>Refers to indicators of threat or compromise highlighted in an microsoft.graph.security.article.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ArticleIndicator>? ArticleIndicators {
            get { return BackingStore?.Get<List<ArticleIndicator>?>("articleIndicators"); }
            set { BackingStore?.Set("articleIndicators", value); }
        }
#nullable restore
#else
        public List<ArticleIndicator> ArticleIndicators {
            get { return BackingStore?.Get<List<ArticleIndicator>>("articleIndicators"); }
            set { BackingStore?.Set("articleIndicators", value); }
        }
#endif
        /// <summary>A list of article objects.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Article>? Articles {
            get { return BackingStore?.Get<List<Article>?>("articles"); }
            set { BackingStore?.Set("articles", value); }
        }
#nullable restore
#else
        public List<Article> Articles {
            get { return BackingStore?.Get<List<Article>>("articles"); }
            set { BackingStore?.Set("articles", value); }
        }
#endif
        /// <summary>Retrieve details about microsoft.graph.security.hostComponent objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<HostComponent>? HostComponents {
            get { return BackingStore?.Get<List<HostComponent>?>("hostComponents"); }
            set { BackingStore?.Set("hostComponents", value); }
        }
#nullable restore
#else
        public List<HostComponent> HostComponents {
            get { return BackingStore?.Get<List<HostComponent>>("hostComponents"); }
            set { BackingStore?.Set("hostComponents", value); }
        }
#endif
        /// <summary>Retrieve details about microsoft.graph.security.hostCookie objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<HostCookie>? HostCookies {
            get { return BackingStore?.Get<List<HostCookie>?>("hostCookies"); }
            set { BackingStore?.Set("hostCookies", value); }
        }
#nullable restore
#else
        public List<HostCookie> HostCookies {
            get { return BackingStore?.Get<List<HostCookie>>("hostCookies"); }
            set { BackingStore?.Set("hostCookies", value); }
        }
#endif
        /// <summary>Refers to microsoft.graph.security.host objects that Microsoft Threat Intelligence has observed.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Host>? Hosts {
            get { return BackingStore?.Get<List<Host>?>("hosts"); }
            set { BackingStore?.Set("hosts", value); }
        }
#nullable restore
#else
        public List<Host> Hosts {
            get { return BackingStore?.Get<List<Host>>("hosts"); }
            set { BackingStore?.Set("hosts", value); }
        }
#endif
        /// <summary>Retrieve details about microsoft.graph.security.hostTracker objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<HostTracker>? HostTrackers {
            get { return BackingStore?.Get<List<HostTracker>?>("hostTrackers"); }
            set { BackingStore?.Set("hostTrackers", value); }
        }
#nullable restore
#else
        public List<HostTracker> HostTrackers {
            get { return BackingStore?.Get<List<HostTracker>>("hostTrackers"); }
            set { BackingStore?.Set("hostTrackers", value); }
        }
#endif
        /// <summary>The intelligenceProfileIndicators property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IntelligenceProfileIndicator>? IntelligenceProfileIndicators {
            get { return BackingStore?.Get<List<IntelligenceProfileIndicator>?>("intelligenceProfileIndicators"); }
            set { BackingStore?.Set("intelligenceProfileIndicators", value); }
        }
#nullable restore
#else
        public List<IntelligenceProfileIndicator> IntelligenceProfileIndicators {
            get { return BackingStore?.Get<List<IntelligenceProfileIndicator>>("intelligenceProfileIndicators"); }
            set { BackingStore?.Set("intelligenceProfileIndicators", value); }
        }
#endif
        /// <summary>A list of intelligenceProfile objects.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IntelligenceProfile>? IntelProfiles {
            get { return BackingStore?.Get<List<IntelligenceProfile>?>("intelProfiles"); }
            set { BackingStore?.Set("intelProfiles", value); }
        }
#nullable restore
#else
        public List<IntelligenceProfile> IntelProfiles {
            get { return BackingStore?.Get<List<IntelligenceProfile>>("intelProfiles"); }
            set { BackingStore?.Set("intelProfiles", value); }
        }
#endif
        /// <summary>Retrieve details about microsoft.graph.security.passiveDnsRecord objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PassiveDnsRecord>? PassiveDnsRecords {
            get { return BackingStore?.Get<List<PassiveDnsRecord>?>("passiveDnsRecords"); }
            set { BackingStore?.Set("passiveDnsRecords", value); }
        }
#nullable restore
#else
        public List<PassiveDnsRecord> PassiveDnsRecords {
            get { return BackingStore?.Get<List<PassiveDnsRecord>>("passiveDnsRecords"); }
            set { BackingStore?.Set("passiveDnsRecords", value); }
        }
#endif
        /// <summary>Retrieve details about microsoft.graph.security.vulnerabilities.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Vulnerability>? Vulnerabilities {
            get { return BackingStore?.Get<List<Vulnerability>?>("vulnerabilities"); }
            set { BackingStore?.Set("vulnerabilities", value); }
        }
#nullable restore
#else
        public List<Vulnerability> Vulnerabilities {
            get { return BackingStore?.Get<List<Vulnerability>>("vulnerabilities"); }
            set { BackingStore?.Set("vulnerabilities", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ThreatIntelligence CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ThreatIntelligence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"articleIndicators", n => { ArticleIndicators = n.GetCollectionOfObjectValues<ArticleIndicator>(ArticleIndicator.CreateFromDiscriminatorValue)?.ToList(); } },
                {"articles", n => { Articles = n.GetCollectionOfObjectValues<Article>(Article.CreateFromDiscriminatorValue)?.ToList(); } },
                {"hostComponents", n => { HostComponents = n.GetCollectionOfObjectValues<HostComponent>(HostComponent.CreateFromDiscriminatorValue)?.ToList(); } },
                {"hostCookies", n => { HostCookies = n.GetCollectionOfObjectValues<HostCookie>(HostCookie.CreateFromDiscriminatorValue)?.ToList(); } },
                {"hosts", n => { Hosts = n.GetCollectionOfObjectValues<Host>(Host.CreateFromDiscriminatorValue)?.ToList(); } },
                {"hostTrackers", n => { HostTrackers = n.GetCollectionOfObjectValues<HostTracker>(HostTracker.CreateFromDiscriminatorValue)?.ToList(); } },
                {"intelligenceProfileIndicators", n => { IntelligenceProfileIndicators = n.GetCollectionOfObjectValues<IntelligenceProfileIndicator>(IntelligenceProfileIndicator.CreateFromDiscriminatorValue)?.ToList(); } },
                {"intelProfiles", n => { IntelProfiles = n.GetCollectionOfObjectValues<IntelligenceProfile>(IntelligenceProfile.CreateFromDiscriminatorValue)?.ToList(); } },
                {"passiveDnsRecords", n => { PassiveDnsRecords = n.GetCollectionOfObjectValues<PassiveDnsRecord>(PassiveDnsRecord.CreateFromDiscriminatorValue)?.ToList(); } },
                {"vulnerabilities", n => { Vulnerabilities = n.GetCollectionOfObjectValues<Vulnerability>(Vulnerability.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ArticleIndicator>("articleIndicators", ArticleIndicators);
            writer.WriteCollectionOfObjectValues<Article>("articles", Articles);
            writer.WriteCollectionOfObjectValues<HostComponent>("hostComponents", HostComponents);
            writer.WriteCollectionOfObjectValues<HostCookie>("hostCookies", HostCookies);
            writer.WriteCollectionOfObjectValues<Host>("hosts", Hosts);
            writer.WriteCollectionOfObjectValues<HostTracker>("hostTrackers", HostTrackers);
            writer.WriteCollectionOfObjectValues<IntelligenceProfileIndicator>("intelligenceProfileIndicators", IntelligenceProfileIndicators);
            writer.WriteCollectionOfObjectValues<IntelligenceProfile>("intelProfiles", IntelProfiles);
            writer.WriteCollectionOfObjectValues<PassiveDnsRecord>("passiveDnsRecords", PassiveDnsRecords);
            writer.WriteCollectionOfObjectValues<Vulnerability>("vulnerabilities", Vulnerabilities);
        }
    }
}
