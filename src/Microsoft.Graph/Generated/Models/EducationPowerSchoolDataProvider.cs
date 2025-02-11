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
    public partial class EducationPowerSchoolDataProvider : global::Microsoft.Graph.Beta.Models.EducationSynchronizationDataProvider, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The allowTeachersInMultipleSchools property</summary>
        public bool? AllowTeachersInMultipleSchools
        {
            get { return BackingStore?.Get<bool?>("allowTeachersInMultipleSchools"); }
            set { BackingStore?.Set("allowTeachersInMultipleSchools", value); }
        }
        /// <summary>The clientId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientId
        {
            get { return BackingStore?.Get<string?>("clientId"); }
            set { BackingStore?.Set("clientId", value); }
        }
#nullable restore
#else
        public string ClientId
        {
            get { return BackingStore?.Get<string>("clientId"); }
            set { BackingStore?.Set("clientId", value); }
        }
#endif
        /// <summary>The clientSecret property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientSecret
        {
            get { return BackingStore?.Get<string?>("clientSecret"); }
            set { BackingStore?.Set("clientSecret", value); }
        }
#nullable restore
#else
        public string ClientSecret
        {
            get { return BackingStore?.Get<string>("clientSecret"); }
            set { BackingStore?.Set("clientSecret", value); }
        }
#endif
        /// <summary>The connectionUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConnectionUrl
        {
            get { return BackingStore?.Get<string?>("connectionUrl"); }
            set { BackingStore?.Set("connectionUrl", value); }
        }
#nullable restore
#else
        public string ConnectionUrl
        {
            get { return BackingStore?.Get<string>("connectionUrl"); }
            set { BackingStore?.Set("connectionUrl", value); }
        }
#endif
        /// <summary>The customizations property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.EducationSynchronizationCustomizations? Customizations
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.EducationSynchronizationCustomizations?>("customizations"); }
            set { BackingStore?.Set("customizations", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.EducationSynchronizationCustomizations Customizations
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.EducationSynchronizationCustomizations>("customizations"); }
            set { BackingStore?.Set("customizations", value); }
        }
#endif
        /// <summary>The schoolsIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SchoolsIds
        {
            get { return BackingStore?.Get<List<string>?>("schoolsIds"); }
            set { BackingStore?.Set("schoolsIds", value); }
        }
#nullable restore
#else
        public List<string> SchoolsIds
        {
            get { return BackingStore?.Get<List<string>>("schoolsIds"); }
            set { BackingStore?.Set("schoolsIds", value); }
        }
#endif
        /// <summary>The schoolYear property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SchoolYear
        {
            get { return BackingStore?.Get<string?>("schoolYear"); }
            set { BackingStore?.Set("schoolYear", value); }
        }
#nullable restore
#else
        public string SchoolYear
        {
            get { return BackingStore?.Get<string>("schoolYear"); }
            set { BackingStore?.Set("schoolYear", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.EducationPowerSchoolDataProvider"/> and sets the default values.
        /// </summary>
        public EducationPowerSchoolDataProvider() : base()
        {
            OdataType = "#microsoft.graph.educationPowerSchoolDataProvider";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.EducationPowerSchoolDataProvider"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.EducationPowerSchoolDataProvider CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.EducationPowerSchoolDataProvider();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "allowTeachersInMultipleSchools", n => { AllowTeachersInMultipleSchools = n.GetBoolValue(); } },
                { "clientId", n => { ClientId = n.GetStringValue(); } },
                { "clientSecret", n => { ClientSecret = n.GetStringValue(); } },
                { "connectionUrl", n => { ConnectionUrl = n.GetStringValue(); } },
                { "customizations", n => { Customizations = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.EducationSynchronizationCustomizations>(global::Microsoft.Graph.Beta.Models.EducationSynchronizationCustomizations.CreateFromDiscriminatorValue); } },
                { "schoolYear", n => { SchoolYear = n.GetStringValue(); } },
                { "schoolsIds", n => { SchoolsIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
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
            writer.WriteBoolValue("allowTeachersInMultipleSchools", AllowTeachersInMultipleSchools);
            writer.WriteStringValue("clientId", ClientId);
            writer.WriteStringValue("clientSecret", ClientSecret);
            writer.WriteStringValue("connectionUrl", ConnectionUrl);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.EducationSynchronizationCustomizations>("customizations", Customizations);
            writer.WriteCollectionOfPrimitiveValues<string>("schoolsIds", SchoolsIds);
            writer.WriteStringValue("schoolYear", SchoolYear);
        }
    }
}
#pragma warning restore CS0618
