// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Entity that represents the health thresholds of a health metric
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class MicrosoftTunnelHealthThreshold : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    {
        /// <summary>The threshold for being healthy based on default health status metrics: CPU usage healthy &lt; 50%, Memory usage healthy &lt; 50%, Disk space healthy &gt; 5GB, Latency healthy &lt; 10ms, health metrics can be customized. Read-only.</summary>
        public long? DefaultHealthyThreshold
        {
            get { return BackingStore?.Get<long?>("defaultHealthyThreshold"); }
            set { BackingStore?.Set("defaultHealthyThreshold", value); }
        }
        /// <summary>The threshold for being unhealthy based on default health status metrics: CPU usage unhealthy &gt; 75%, Memory usage unhealthy &gt; 75%, Disk space &lt; 3GB, Latency unhealthy &gt; 20ms, health metrics can be customized. Read-only.</summary>
        public long? DefaultUnhealthyThreshold
        {
            get { return BackingStore?.Get<long?>("defaultUnhealthyThreshold"); }
            set { BackingStore?.Set("defaultUnhealthyThreshold", value); }
        }
        /// <summary>The threshold for being healthy based on default health status metrics: CPU usage healthy &lt; 50%, Memory usage healthy &lt; 50%, Disk space healthy &gt; 5GB, Latency healthy &lt; 10ms, health metrics can be customized.</summary>
        public long? HealthyThreshold
        {
            get { return BackingStore?.Get<long?>("healthyThreshold"); }
            set { BackingStore?.Set("healthyThreshold", value); }
        }
        /// <summary>The threshold for being unhealthy based on default health status metrics: CPU usage unhealthy &gt; 75%, Memory usage unhealthy &gt; 75%, Disk space &lt; 3GB, Latency Unhealthy &gt; 20ms, health metrics can be customized.</summary>
        public long? UnhealthyThreshold
        {
            get { return BackingStore?.Get<long?>("unhealthyThreshold"); }
            set { BackingStore?.Set("unhealthyThreshold", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.MicrosoftTunnelHealthThreshold"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.MicrosoftTunnelHealthThreshold CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.MicrosoftTunnelHealthThreshold();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "defaultHealthyThreshold", n => { DefaultHealthyThreshold = n.GetLongValue(); } },
                { "defaultUnhealthyThreshold", n => { DefaultUnhealthyThreshold = n.GetLongValue(); } },
                { "healthyThreshold", n => { HealthyThreshold = n.GetLongValue(); } },
                { "unhealthyThreshold", n => { UnhealthyThreshold = n.GetLongValue(); } },
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
            writer.WriteLongValue("defaultHealthyThreshold", DefaultHealthyThreshold);
            writer.WriteLongValue("defaultUnhealthyThreshold", DefaultUnhealthyThreshold);
            writer.WriteLongValue("healthyThreshold", HealthyThreshold);
            writer.WriteLongValue("unhealthyThreshold", UnhealthyThreshold);
        }
    }
}
#pragma warning restore CS0618
