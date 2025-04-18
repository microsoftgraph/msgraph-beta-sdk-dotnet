// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class EducationalActivityDetail : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Shortened name of the degree or program (example: PhD, MBA)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Abbreviation
        {
            get { return BackingStore?.Get<string?>("abbreviation"); }
            set { BackingStore?.Set("abbreviation", value); }
        }
#nullable restore
#else
        public string Abbreviation
        {
            get { return BackingStore?.Get<string>("abbreviation"); }
            set { BackingStore?.Set("abbreviation", value); }
        }
#endif
        /// <summary>Extracurricular activities undertaken alongside the program.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Activities
        {
            get { return BackingStore?.Get<List<string>?>("activities"); }
            set { BackingStore?.Set("activities", value); }
        }
#nullable restore
#else
        public List<string> Activities
        {
            get { return BackingStore?.Get<List<string>>("activities"); }
            set { BackingStore?.Set("activities", value); }
        }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Any awards or honors associated with the program.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Awards
        {
            get { return BackingStore?.Get<List<string>?>("awards"); }
            set { BackingStore?.Set("awards", value); }
        }
#nullable restore
#else
        public List<string> Awards
        {
            get { return BackingStore?.Get<List<string>>("awards"); }
            set { BackingStore?.Set("awards", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Short description of the program provided by the user.</summary>
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
        /// <summary>Long-form name of the program that the user provided.</summary>
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
        /// <summary>Majors and minors associated with the program. (if applicable)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? FieldsOfStudy
        {
            get { return BackingStore?.Get<List<string>?>("fieldsOfStudy"); }
            set { BackingStore?.Set("fieldsOfStudy", value); }
        }
#nullable restore
#else
        public List<string> FieldsOfStudy
        {
            get { return BackingStore?.Get<List<string>>("fieldsOfStudy"); }
            set { BackingStore?.Set("fieldsOfStudy", value); }
        }
#endif
        /// <summary>The final grade, class, GPA, or score.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Grade
        {
            get { return BackingStore?.Get<string?>("grade"); }
            set { BackingStore?.Set("grade", value); }
        }
#nullable restore
#else
        public string Grade
        {
            get { return BackingStore?.Get<string>("grade"); }
            set { BackingStore?.Set("grade", value); }
        }
#endif
        /// <summary>More notes the user provided.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Notes
        {
            get { return BackingStore?.Get<string?>("notes"); }
            set { BackingStore?.Set("notes", value); }
        }
#nullable restore
#else
        public string Notes
        {
            get { return BackingStore?.Get<string>("notes"); }
            set { BackingStore?.Set("notes", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Link to the degree or program page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebUrl
        {
            get { return BackingStore?.Get<string?>("webUrl"); }
            set { BackingStore?.Set("webUrl", value); }
        }
#nullable restore
#else
        public string WebUrl
        {
            get { return BackingStore?.Get<string>("webUrl"); }
            set { BackingStore?.Set("webUrl", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.EducationalActivityDetail"/> and sets the default values.
        /// </summary>
        public EducationalActivityDetail()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.EducationalActivityDetail"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.EducationalActivityDetail CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.EducationalActivityDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "abbreviation", n => { Abbreviation = n.GetStringValue(); } },
                { "activities", n => { Activities = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "awards", n => { Awards = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "fieldsOfStudy", n => { FieldsOfStudy = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "grade", n => { Grade = n.GetStringValue(); } },
                { "notes", n => { Notes = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "webUrl", n => { WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("abbreviation", Abbreviation);
            writer.WriteCollectionOfPrimitiveValues<string>("activities", Activities);
            writer.WriteCollectionOfPrimitiveValues<string>("awards", Awards);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfPrimitiveValues<string>("fieldsOfStudy", FieldsOfStudy);
            writer.WriteStringValue("grade", Grade);
            writer.WriteStringValue("notes", Notes);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("webUrl", WebUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
