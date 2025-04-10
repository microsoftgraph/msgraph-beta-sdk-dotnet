// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models.DeviceManagement
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Monitoring : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The collection of records of alert events.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.DeviceManagement.AlertRecord>? AlertRecords
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DeviceManagement.AlertRecord>?>("alertRecords"); }
            set { BackingStore?.Set("alertRecords", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.DeviceManagement.AlertRecord> AlertRecords
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DeviceManagement.AlertRecord>>("alertRecords"); }
            set { BackingStore?.Set("alertRecords", value); }
        }
#endif
        /// <summary>The collection of alert rules.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.DeviceManagement.AlertRule>? AlertRules
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DeviceManagement.AlertRule>?>("alertRules"); }
            set { BackingStore?.Set("alertRules", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.DeviceManagement.AlertRule> AlertRules
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DeviceManagement.AlertRule>>("alertRules"); }
            set { BackingStore?.Set("alertRules", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.DeviceManagement.Monitoring"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.DeviceManagement.Monitoring CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.DeviceManagement.Monitoring();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "alertRecords", n => { AlertRecords = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.DeviceManagement.AlertRecord>(global::Microsoft.Graph.Beta.Models.DeviceManagement.AlertRecord.CreateFromDiscriminatorValue)?.AsList(); } },
                { "alertRules", n => { AlertRules = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.DeviceManagement.AlertRule>(global::Microsoft.Graph.Beta.Models.DeviceManagement.AlertRule.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.DeviceManagement.AlertRecord>("alertRecords", AlertRecords);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.DeviceManagement.AlertRule>("alertRules", AlertRules);
        }
    }
}
#pragma warning restore CS0618
