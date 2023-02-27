---
title: "Update learningContent"
description: "Update the properties of a learningContent object."
author: "malabikaroy"
ms.localizationpriority: medium
ms.prod: "employee-learning"
doc_type: apiPageType
---

# Update learningContent
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the specified [learningContent](../resources/learningcontent.md) resource.

Used by a [learning provider](../resources/learningprovider.md) to ingest or update the metadata for their content in Viva Learning. If the specified learning content doesn't yet exist for the specified provider, this operation creates the metadata for the new content. Otherwise, this operation replaces the metadata of the existing content.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|Not supported.|
|Delegated (personal Microsoft account)|Not supported.|
|Application|LearningContent.ReadWrite.All|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->

For a specific learning content based on its ID (primary key):
``` http
PATCH /employeeExperience/learningProviders/{learningProviderId}/learningContents/{learningContentId}
```

For a specific learning content based on its external ID (secondary key):
``` http
PATCH /employeeExperience/learningProviders/{learningProviderId}/learningContents(externalId='{externalId}') 
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply *only* the values for properties that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values.

The following table specifies the properties that can be updated.


|Property|Type|Description|
|:---|:---|:---|
|additionalTags|String collection|Keywords, topics, and other tags associated with the learning content. Optional.|
|contentWebUrl|String|The content web URL for the learning content. Required.|
|contributors|String collection|The authors, creators, or contributors of the learning content. Optional.|
|createdDateTime|DateTimeOffset|The date when the learning content was created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is `2014-01-01T00:00:00Z`. Optional.|
|description|String|The description or summary for the learning content. Optional.|
|duration|Duration|The duration of the learning content in seconds. The value is represented in ISO 8601 format for durations. Optional.|
|externalId|String|Unique external content ID for the learning content. Required.|
|format|String|The format of the learning content. For example, `Course`, `Video`, `Book`, `Book Summary`, `Audiobook Summary`. Optional.|
|isActive|Boolean|Indicates whether the content is active or not. Inactive content will not show up in the UI. The default value is `true`. Optional.|
|isPremium|Boolean|Indicates whether the learning content requires the user to sign-in on the learning provider platform or not. The default value is `false`. Optional.|
|isSearchable|Boolean|Indicates whether the learning content is searchable or not. The default value is `true`. Optional.|
|languageTag|String|The language of the learning content, for example, `en-us` or `fr-fr`. Required.|
|lastModifiedDateTime|DateTimeOffset|The date when the learning content was last modified. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is `2014-01-01T00:00:00Z`. Optional.|
|numberOfPages|Int32|The number of pages of the learning content, for example, 9. Optional.|
|skillTags|String collection|The skills tags associated with the learning content. Optional.|
|sourceName|String|The source name of the learning content, such as `LinkedIn Learning` or `Coursera`. Optional.|
|thumbnailWebUrl|String|The URL of learning content thumbnail image. Optional.|
|title|String|The title of the learning content. Required.|

## Response

If successful, this method returns a `202 Accepted` response code and an updated [learningContent](../resources/learningcontent.md) object in the response body.

## Examples

### Example 1: Update the metadata of a learning content based on its ID

The following example shows a request that updates the metadata of a learning content based on its ID (primary key).

#### Request
The following example shows the request.

<!-- {
  "blockType": "request",
  "name": "update_learningcontent_id",
  "sampleKeys": ["13727311-e7bb-470d-8b20-6a23d9030d70", "77029588-a660-46b6-ba58-3ce4d21d5678"]
}
-->
``` http
PATCH /employeeExperience/learningProviders/13727311-e7bb-470d-8b20-6a23d9030d70/learningContents/77029588-a660-46b6-ba58-3ce4d21d5678
Content-Type: application/json

{
    "title": "Manage classes, resources, assessment, and planning in Microsoft Teams with Beedle",
    "description": "A module to guide users through the various teaching and learning enhancements that Beedle provides within Microsoft Teams, with many examples of everyday application.",
    "contentWebUrl": "https://learn.microsoft.com/learn/modules/manage-classes-resources-assessment-planning-beedle/",
    "sourceName": "MsLearn",
    "thumbnailWebUrl": "https://syndetics.com/index.aspx?isbn=9783319672175/LC.GIF",
    "languageTag": "en-us",
    "numberOfPages": 9,
    "duration": "PT20M",
    "format": "Book",
    "createdDateTime": "2018-01-01T00:00:00Z",
    "lastModifiedDateTime": "2021-04-01T04:26:06.1995367Z",
    "contributors": ["Scott Simpson"],
    "additionalTags": [
        "Create private or public teams",
        "Add members to teams"
    ],
    "skillTags": [
        "Create teams",
        "Teams channels",
        "Teams members"
    ],
    "isActive": true,
    "isPremium": false,
    "isSearchable": true
}
```

#### Response
The following example shows the response.
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.learningContent"
}
-->
``` http
HTTP/1.1 202 Accepted
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#learningProviders('13727311-e7bb-470d-8b20-6a23d9030d70')/learningContents/$entity",
    "id": "77029588-a660-46b6-ba58-3ce4d21d5678",
    "externalId": "LP4471",
    "title": "Manage classes, resources, assessment, and planning in Microsoft Teams with Beedle",
    "description": "A module to guide users through the various teaching and learning enhancements that Beedle provides within Microsoft Teams, with many examples of everyday application.",
    "contentWebUrl": "https://learn.microsoft.com/learn/modules/manage-classes-resources-assessment-planning-beedle/",
    "sourceName": "MsLearn",
    "thumbnailWebUrl": "https://syndetics.com/index.aspx?isbn=9783319672175/LC.GIF",
    "languageTag": "en-us",
    "numberOfPages": 9,
    "duration": "PT20M",
    "format": "Book",
    "createdDateTime": "2018-01-01T00:00:00",
    "lastModifiedDateTime": "2021-04-01T04:26:06.1995367Z",
    "contributors": [
      "Lina Wagner",
      "Lisa Richter"
    ],
    "additionalTags": [
        "Create private or public teams",
        "Add members to teams"
    ],
    "skillTags": [
        "Create teams",
        "Teams channels",
        "Teams members"
    ],
    "isActive": true,
    "isPremium": false,
    "isSearchable": true
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var learningContent = new LearningContent
{
	Title = "Manage classes, resources, assessment, and planning in Microsoft Teams with Beedle",
	Description = "A module to guide users through the various teaching and learning enhancements that Beedle provides within Microsoft Teams, with many examples of everyday application.",
	ContentWebUrl = "https://learn.microsoft.com/learn/modules/manage-classes-resources-assessment-planning-beedle/",
	SourceName = "MsLearn",
	ThumbnailWebUrl = "https://syndetics.com/index.aspx?isbn=9783319672175/LC.GIF",
	LanguageTag = "en-us",
	NumberOfPages = 9,
	Duration = new Duration("PT20M"),
	Format = "Book",
	CreatedDateTime = DateTimeOffset.Parse("2018-01-01T00:00:00"),
	LastModifiedDateTime = DateTimeOffset.Parse("2021-04-01T04:26:06.1995367Z"),
	Contributor = "Scott Simpson",
	AdditionalTags = new List<String>()
	{
		"Create private or public teams",
		"Add members to teams"
	},
	SkillTags = new List<String>()
	{
		"Create teams",
		"Teams channels",
		"Teams members"
	},
	IsActive = true,
	IsPremium = false,
	IsSearchable = true
};

await graphClient.EmployeeExperience.LearningProviders["{learningProvider-id}"].LearningContents["{learningContent-id}"]
	.Request()
	.UpdateAsync(learningContent);

```



 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
The following example shows the response.
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.learningContent"
}
-->
``` http
HTTP/1.1 202 Accepted
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#learningProviders('13727311-e7bb-470d-8b20-6a23d9030d70')/learningContents/$entity",
    "id": "77029588-a660-46b6-ba58-3ce4d21d5678",
    "externalId": "LP4471",
    "title": "Manage classes, resources, assessment, and planning in Microsoft Teams with Beedle",
    "description": "A module to guide users through the various teaching and learning enhancements that Beedle provides within Microsoft Teams, with many examples of everyday application.",
    "contentWebUrl": "https://learn.microsoft.com/learn/modules/manage-classes-resources-assessment-planning-beedle/",
    "sourceName": "MsLearn",
    "thumbnailWebUrl": "https://syndetics.com/index.aspx?isbn=9783319672175/LC.GIF",
    "languageTag": "en-us",
    "numberOfPages": 9,
    "duration": "PT20M",
    "format": "Book",
    "createdDateTime": "2018-01-01T00:00:00",
    "lastModifiedDateTime": "2021-04-01T04:26:06.1995367Z",
    "contributors": [
        "Lina Wagner",
        "Lisa Richter"
    ],
    "additionalTags": [
        "Create private or public teams",
        "Add members to teams"
    ],
    "skillTags": [
        "Create teams",
        "Teams channels",
        "Teams members"
    ],
    "isActive": true,
    "isPremium": false,
    "isSearchable": true
}
```
