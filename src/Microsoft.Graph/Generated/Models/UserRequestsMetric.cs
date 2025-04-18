// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class UserRequestsMetric : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The appId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppId
        {
            get { return BackingStore?.Get<string?>("appId"); }
            set { BackingStore?.Set("appId", value); }
        }
#nullable restore
#else
        public string AppId
        {
            get { return BackingStore?.Get<string>("appId"); }
            set { BackingStore?.Set("appId", value); }
        }
#endif
        /// <summary>The browser property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Browser
        {
            get { return BackingStore?.Get<string?>("browser"); }
            set { BackingStore?.Set("browser", value); }
        }
#nullable restore
#else
        public string Browser
        {
            get { return BackingStore?.Get<string>("browser"); }
            set { BackingStore?.Set("browser", value); }
        }
#endif
        /// <summary>The country property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Country
        {
            get { return BackingStore?.Get<string?>("country"); }
            set { BackingStore?.Set("country", value); }
        }
#nullable restore
#else
        public string Country
        {
            get { return BackingStore?.Get<string>("country"); }
            set { BackingStore?.Set("country", value); }
        }
#endif
        /// <summary>The date of the user insight.</summary>
        public Date? FactDate
        {
            get { return BackingStore?.Get<Date?>("factDate"); }
            set { BackingStore?.Set("factDate", value); }
        }
        /// <summary>The identityProvider property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IdentityProvider
        {
            get { return BackingStore?.Get<string?>("identityProvider"); }
            set { BackingStore?.Set("identityProvider", value); }
        }
#nullable restore
#else
        public string IdentityProvider
        {
            get { return BackingStore?.Get<string>("identityProvider"); }
            set { BackingStore?.Set("identityProvider", value); }
        }
#endif
        /// <summary>The language property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Language
        {
            get { return BackingStore?.Get<string?>("language"); }
            set { BackingStore?.Set("language", value); }
        }
#nullable restore
#else
        public string Language
        {
            get { return BackingStore?.Get<string>("language"); }
            set { BackingStore?.Set("language", value); }
        }
#endif
        /// <summary>Number of requests to the tenant. Supports $filter (eq).</summary>
        public long? RequestCount
        {
            get { return BackingStore?.Get<long?>("requestCount"); }
            set { BackingStore?.Set("requestCount", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.UserRequestsMetric"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.UserRequestsMetric CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.UserRequestsMetric();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "appId", n => { AppId = n.GetStringValue(); } },
                { "browser", n => { Browser = n.GetStringValue(); } },
                { "country", n => { Country = n.GetStringValue(); } },
                { "factDate", n => { FactDate = n.GetDateValue(); } },
                { "identityProvider", n => { IdentityProvider = n.GetStringValue(); } },
                { "language", n => { Language = n.GetStringValue(); } },
                { "requestCount", n => { RequestCount = n.GetLongValue(); } },
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
            writer.WriteStringValue("appId", AppId);
            writer.WriteStringValue("browser", Browser);
            writer.WriteStringValue("country", Country);
            writer.WriteDateValue("factDate", FactDate);
            writer.WriteStringValue("identityProvider", IdentityProvider);
            writer.WriteStringValue("language", Language);
            writer.WriteLongValue("requestCount", RequestCount);
        }
    }
}
#pragma warning restore CS0618
