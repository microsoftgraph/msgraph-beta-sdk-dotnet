using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class EducationOneRosterApiDataProvider : EducationSynchronizationDataProvider, IParsable {
        /// <summary>The connectionSettings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public EducationSynchronizationConnectionSettings? ConnectionSettings {
            get { return BackingStore?.Get<EducationSynchronizationConnectionSettings?>("connectionSettings"); }
            set { BackingStore?.Set("connectionSettings", value); }
        }
#else
        public EducationSynchronizationConnectionSettings ConnectionSettings {
            get { return BackingStore?.Get<EducationSynchronizationConnectionSettings>("connectionSettings"); }
            set { BackingStore?.Set("connectionSettings", value); }
        }
#endif
        /// <summary>The connectionUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? ConnectionUrl {
            get { return BackingStore?.Get<string?>("connectionUrl"); }
            set { BackingStore?.Set("connectionUrl", value); }
        }
#else
        public string ConnectionUrl {
            get { return BackingStore?.Get<string>("connectionUrl"); }
            set { BackingStore?.Set("connectionUrl", value); }
        }
#endif
        /// <summary>The customizations property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public EducationSynchronizationCustomizations? Customizations {
            get { return BackingStore?.Get<EducationSynchronizationCustomizations?>("customizations"); }
            set { BackingStore?.Set("customizations", value); }
        }
#else
        public EducationSynchronizationCustomizations Customizations {
            get { return BackingStore?.Get<EducationSynchronizationCustomizations>("customizations"); }
            set { BackingStore?.Set("customizations", value); }
        }
#endif
        /// <summary>The providerName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? ProviderName {
            get { return BackingStore?.Get<string?>("providerName"); }
            set { BackingStore?.Set("providerName", value); }
        }
#else
        public string ProviderName {
            get { return BackingStore?.Get<string>("providerName"); }
            set { BackingStore?.Set("providerName", value); }
        }
#endif
        /// <summary>The schoolsIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<string>? SchoolsIds {
            get { return BackingStore?.Get<List<string>?>("schoolsIds"); }
            set { BackingStore?.Set("schoolsIds", value); }
        }
#else
        public List<string> SchoolsIds {
            get { return BackingStore?.Get<List<string>>("schoolsIds"); }
            set { BackingStore?.Set("schoolsIds", value); }
        }
#endif
        /// <summary>The termIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<string>? TermIds {
            get { return BackingStore?.Get<List<string>?>("termIds"); }
            set { BackingStore?.Set("termIds", value); }
        }
#else
        public List<string> TermIds {
            get { return BackingStore?.Get<List<string>>("termIds"); }
            set { BackingStore?.Set("termIds", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new EducationOneRosterApiDataProvider and sets the default values.
        /// </summary>
        public EducationOneRosterApiDataProvider() : base() {
            OdataType = "#microsoft.graph.educationOneRosterApiDataProvider";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EducationOneRosterApiDataProvider CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationOneRosterApiDataProvider();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"connectionSettings", n => { ConnectionSettings = n.GetObjectValue<EducationSynchronizationConnectionSettings>(EducationSynchronizationConnectionSettings.CreateFromDiscriminatorValue); } },
                {"connectionUrl", n => { ConnectionUrl = n.GetStringValue(); } },
                {"customizations", n => { Customizations = n.GetObjectValue<EducationSynchronizationCustomizations>(EducationSynchronizationCustomizations.CreateFromDiscriminatorValue); } },
                {"providerName", n => { ProviderName = n.GetStringValue(); } },
                {"schoolsIds", n => { SchoolsIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"termIds", n => { TermIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<EducationSynchronizationConnectionSettings>("connectionSettings", ConnectionSettings);
            writer.WriteStringValue("connectionUrl", ConnectionUrl);
            writer.WriteObjectValue<EducationSynchronizationCustomizations>("customizations", Customizations);
            writer.WriteStringValue("providerName", ProviderName);
            writer.WriteCollectionOfPrimitiveValues<string>("schoolsIds", SchoolsIds);
            writer.WriteCollectionOfPrimitiveValues<string>("termIds", TermIds);
        }
    }
}
