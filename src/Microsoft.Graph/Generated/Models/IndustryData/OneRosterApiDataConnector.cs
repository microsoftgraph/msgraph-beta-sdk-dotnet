// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models.IndustryData
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class OneRosterApiDataConnector : global::Microsoft.Graph.Beta.Models.IndustryData.ApiDataConnector, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The API version of the OneRoster source. Example: 1.1, 1.2</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ApiVersion
        {
            get { return BackingStore?.Get<string?>("apiVersion"); }
            set { BackingStore?.Set("apiVersion", value); }
        }
#nullable restore
#else
        public string ApiVersion
        {
            get { return BackingStore?.Get<string>("apiVersion"); }
            set { BackingStore?.Set("apiVersion", value); }
        }
#endif
        /// <summary>Indicates whether the user specified to import optional contacts data.</summary>
        public bool? IsContactsEnabled
        {
            get { return BackingStore?.Get<bool?>("isContactsEnabled"); }
            set { BackingStore?.Set("isContactsEnabled", value); }
        }
        /// <summary>Indicates whether the user specified to import optional demographics data.</summary>
        public bool? IsDemographicsEnabled
        {
            get { return BackingStore?.Get<bool?>("isDemographicsEnabled"); }
            set { BackingStore?.Set("isDemographicsEnabled", value); }
        }
        /// <summary>Indicates whether the user specified to import optional flags data.</summary>
        public bool? IsFlagsEnabled
        {
            get { return BackingStore?.Get<bool?>("isFlagsEnabled"); }
            set { BackingStore?.Set("isFlagsEnabled", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.IndustryData.OneRosterApiDataConnector"/> and sets the default values.
        /// </summary>
        public OneRosterApiDataConnector() : base()
        {
            OdataType = "#microsoft.graph.industryData.oneRosterApiDataConnector";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.IndustryData.OneRosterApiDataConnector"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.IndustryData.OneRosterApiDataConnector CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.IndustryData.OneRosterApiDataConnector();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "apiVersion", n => { ApiVersion = n.GetStringValue(); } },
                { "isContactsEnabled", n => { IsContactsEnabled = n.GetBoolValue(); } },
                { "isDemographicsEnabled", n => { IsDemographicsEnabled = n.GetBoolValue(); } },
                { "isFlagsEnabled", n => { IsFlagsEnabled = n.GetBoolValue(); } },
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
            writer.WriteStringValue("apiVersion", ApiVersion);
            writer.WriteBoolValue("isContactsEnabled", IsContactsEnabled);
            writer.WriteBoolValue("isDemographicsEnabled", IsDemographicsEnabled);
            writer.WriteBoolValue("isFlagsEnabled", IsFlagsEnabled);
        }
    }
}
#pragma warning restore CS0618
