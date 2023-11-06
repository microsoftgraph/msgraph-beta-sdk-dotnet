// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;

namespace Microsoft.Graph.Beta.Models;

public class PlannerChecklistItem: IAdditionalDataHolder, IBackedModel, IParsable
{
    /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
    public IDictionary<string, object> AdditionalData {
        get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
        set { BackingStore?.Set("additionalData", value); }
    }
    /// <summary>Stores model information.</summary>
    public IBackingStore BackingStore { get; private set; }
    /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? OdataType {
        get { return BackingStore?.Get<string?>("@odata.type"); }
        set { BackingStore?.Set("@odata.type", value); }
    }
#nullable restore
#else
    public string OdataType {
        get { return BackingStore?.Get<string>("@odata.type"); }
        set { BackingStore?.Set("@odata.type", value); }
    }
#endif
    /// <summary>Value is true if the item is checked and false otherwise.</summary>
    public bool? IsChecked {
        get { return BackingStore?.Get<bool>("isChecked"); }
        set { BackingStore?.Set("isChecked", value); }
    }
    /// <summary>Read-only. User ID by which this is last modified.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public IdentitySet? LastModifiedBy {
        get { return BackingStore?.Get<IdentitySet>("lastModifiedBy"); }
        set { BackingStore?.Set("lastModifiedBy", value); }
    }
#nullable restore
#else
    public IdentitySet LastModifiedBy {
        get { return BackingStore?.Get<IdentitySet>("lastModifiedBy"); }
        set { BackingStore?.Set("lastModifiedBy", value); }
    }
#endif
    /// <summary>Read-only. Date and time at which this is last modified. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
    public DateTimeOffset? LastModifiedDateTime {
        get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
        set { BackingStore?.Set("lastModifiedDateTime", value); }
    }
    /// <summary>Used to set the relative order of items in the checklist. The format is defined as outlined here..</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
    public string? OrderHint {
        get { return BackingStore?.Get<string?>("orderHint"); }
        set { BackingStore?.Set("orderHint", value); }
    }
#nullable restore
#else
    public string OrderHint {
        get { return BackingStore?.Get<string>("orderHint"); }
        set { BackingStore?.Set("orderHint", value); }
    }
#endif
    /// <summary>Title of the checklist item.</summary>
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
    /// <summary>
    /// Instantiates a new auditActivityInitiator and sets the default values.
    /// </summary>
    public PlannerChecklistItem() {
        BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
        AdditionalData = new Dictionary<string, object>();
        OdataType = "#microsoft.graph.plannerChecklistItem";
    }
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static PlannerChecklistItem CreateFromDiscriminatorValue(IParseNode parseNode) {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new PlannerChecklistItem();
    }
    /// <summary>
    /// The deserialization information for the current model
    /// </summary>
    public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
        return new Dictionary<string, Action<IParseNode>> {
            {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            {"isChecked", n => { IsChecked = n.GetBoolValue(); } },
            {"lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue(IdentitySet.CreateFromDiscriminatorValue); } },
            {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
            {"orderHint", n => { OrderHint = n.GetStringValue(); } },
            {"title", n => { Title = n.GetStringValue(); } },
        };
    }
    /// <summary>
    /// Serializes information the current object
    /// </summary>
    /// <param name="writer">Serialization writer to use to serialize this model</param>
    public void Serialize(ISerializationWriter writer) {
        _ = writer ?? throw new ArgumentNullException(nameof(writer));
        writer.WriteStringValue("@odata.type", OdataType);
        writer.WriteBoolValue("isChecked", IsChecked);
        writer.WriteObjectValue("lastModifiedBy", LastModifiedBy);
        writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
        writer.WriteStringValue("orderHint", OrderHint);
        writer.WriteStringValue("title", Title);
        writer.WriteAdditionalData(AdditionalData);
    }
}

[Obsolete("This class is obsolete due to incorrect naming. Use PlannerChecklistItem instead.")]
public class PlannerCheckListItem : PlannerChecklistItem
{
    /// <summary>
    /// Creates a new instance of the appropriate class based on discriminator value
    /// </summary>
    /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
    public static new PlannerCheckListItem CreateFromDiscriminatorValue(IParseNode parseNode) {
        _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
        return new PlannerCheckListItem();
    }
}
