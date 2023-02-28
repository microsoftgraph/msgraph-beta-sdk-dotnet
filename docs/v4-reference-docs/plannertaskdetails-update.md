---
title: "Update plannerTaskDetails"
description: "Update the properties of a **plannerTaskDetails** object."
ms.localizationpriority: medium
author: "TarkanSevilmis"
ms.prod: "planner"
doc_type: apiPageType
---

# Update plannertaskdetails

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of **plannerTaskDetails** object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Tasks.ReadWrite, Group.ReadWrite.All    |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Tasks.ReadWrite.All |

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
PATCH /planner/tasks/{id}/details
```

## Optional request headers
| Name       | Description|
|:-----------|:-----------|
| Authorization  | Bearer {token}. Required. |
| If-Match  | Last known ETag value for the **plannerTaskDetails** to be updated. Required.|

## Request body

In the request body, supply *only* the values for properties that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values.

The following table specifies the properties that can be updated.

| Property	   | Type	|Description|
|:---------------|:--------|:----------|
|checklist|[plannerChecklistItems](../resources/plannerchecklistitems.md)|The collection of checklist items on the task.|
|description|String|The description of the task.|
|notes|[itemBody](../resources/itembody.md)|Rich text description of the task. To be used by HTML-aware clients. For backwards compatibility, a plain-text version of the HTML description will be synced to the "description" field. If this field has not previously been set but "description" has been, the existing description will be synchronized to "notes" with minimal whitespace-preserving HTML markup. Setting both "description" and "notes" is an error and will result in an exception.|
|previewType|string|This sets the type of preview that shows up on the task. Possible values are: `automatic`, `noPreview`, `checklist`, `description`, `reference`. When set to `automatic` the displayed preview is chosen by the app viewing the task.|
|references|[plannerExternalReferences](../resources/plannerexternalreferences.md)|The collection of references on the task.|

## Response

If successful, this method returns a `204 No Content` response code and empty content. If the request specifies the `Prefer` header with `return=representation` preference, then this method returns a `200 OK` response code and an updated [plannerTaskDetails](../resources/plannertaskdetails.md) object in the response body.

This method can return any of the [HTTP status codes](/graph/errors). The most common errors that apps should handle for this method are the 400, 403, 404, 409, and 412 responses. For more information about these errors, see [Common Planner error conditions](../resources/planner-overview.md#common-planner-error-conditions).

## Example
### Request
The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_plannertaskdetails",
  "sampleKeys": ["gcrYAaAkgU2EQUvpkNNXLGQAGTtu"]
}-->
```http
PATCH https://graph.microsoft.com/beta/planner/tasks/gcrYAaAkgU2EQUvpkNNXLGQAGTtu/details
Content-type: application/json
Prefer: return=representation
If-Match: W/"JzEtVGFzayAgQEBAQEBAQEBAQEBAQEBAWCc="

{
  "previewType": "noPreview",
  "references": {
    "http%3A//developer%2Emicrosoft%2Ecom":{
      "@odata.type": "microsoft.graph.plannerExternalReference",
      "alias": "Documentation",
      "previewPriority": " !",
      "type": "Other"
    },
    "https%3A//developer%2Emicrosoft%2Ecom/graph/graph-explorer":{
      "@odata.type": "microsoft.graph.plannerExternalReference",
      "previewPriority": "  !!",
    },
    "http%3A//www%2Ebing%2Ecom": null
  },
  "checklist": {
    "95e27074-6c4a-447a-aa24-9d718a0b86fa":{
      "@odata.type": "microsoft.graph.plannerChecklistItem",
      "title": "Update task details",
      "isChecked": true
    },
    "d280ed1a-9f6b-4f9c-a962-fb4d00dc50ff":{
      "@odata.type": "microsoft.graph.plannerChecklistItem",
      "isChecked": true,
    },
    "a93c93c5-10a6-4167-9551-8bafa09967a7": null
  },
  "description": "Updated task details properties:\nUpdated checklist:Sub items\nUpdated references:Related links"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var plannerTaskDetails = new PlannerTaskDetails
{
	PreviewType = PlannerPreviewType.NoPreview,
	References = new PlannerExternalReferences
	{
		AdditionalData = new Dictionary<string, object>()
		{
			{"http%3A//developer%2Emicrosoft%2Ecom", "{\"@odata.type\":\"microsoft.graph.plannerExternalReference\",\"alias\":\"Documentation\",\"previewPriority\":\" !\",\"type\":\"Other\"}"},
			{"https%3A//developer%2Emicrosoft%2Ecom/graph/graph-explorer", "{\"@odata.type\":\"microsoft.graph.plannerExternalReference\",\"previewPriority\":\"  !!\"}"},
			{"http%3A//www%2Ebing%2Ecom", "null"}
		}
	},
	Checklist = new PlannerChecklistItems
	{
		AdditionalData = new Dictionary<string, object>()
		{
			{"95e27074-6c4a-447a-aa24-9d718a0b86fa", "{\"@odata.type\":\"microsoft.graph.plannerChecklistItem\",\"title\":\"Update task details\",\"isChecked\":true}"},
			{"d280ed1a-9f6b-4f9c-a962-fb4d00dc50ff", "{\"@odata.type\":\"microsoft.graph.plannerChecklistItem\",\"isChecked\":true}"},
			{"a93c93c5-10a6-4167-9551-8bafa09967a7", "null"}
		}
	},
	Description = "Updated task details properties:\nUpdated checklist:Sub items\nUpdated references:Related links"
};

await graphClient.Planner.Tasks["{plannerTask-id}"].Details
	.Request()
	.Header("Prefer","return=representation")
	.Header("If-Match","W/\"JzEtVGFzayAgQEBAQEBAQEBAQEBAQEBAWCc=\"")
	.UpdateAsync(plannerTaskDetails);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
The following is an example of the response. 
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.plannerTaskDetails"
} -->
```http
HTTP/1.1 200 OK
Content-type: application/json

{
  "description": "Updated task details properties:\nUpdated checklist:Sub items\nUpdated references:Related links",
  "notes": {
    "content": "<div style=\"white-space:pre-wrap\">Updated task details properties:\nUpdated checklist:Sub items\nUpdated references:Related links</div>",
    "contentType": "html"
  },
  "previewType": "automatic",
  "references": {
    "https%3A//developer%2Emicrosoft%2Ecom/graph/graph-explorer": {
      "@odata.type": "#microsoft.graph.plannerExternalReference",
      "alias": "Graph Explorer",
      "type": "Other",
      "previewPriority": "8599273",
      "lastModifiedBy": {
        "user": {
          "id": "fbab97d0-4932-4511-b675-204639209557"
        }
      },
      "lastModifiedDateTime": "2017-04-24T22:52:29.814Z"
    },
    "http%3A//developer%2Emicrosoft%2Ecom": {
      "@odata.type": "#microsoft.graph.plannerExternalReference",
      "alias": "Documentation",
      "type": "Other",
      "previewPriority": "90727736",
      "lastModifiedBy": {
        "user": {
          "id": "fbab97d0-4932-4511-b675-204639209557"
        }
      },
      "lastModifiedDateTime": "2017-04-24T22:52:29.814Z"
    }
  },
  "checklist": {
    "d280ed1a-9f6b-4f9c-a962-fb4d00dc50ff": {
      "@odata.type": "#microsoft.graph.plannerChecklistItem",
      "isChecked": true,
      "title": "Try reading task details",
      "orderHint": "a93c93c5^",
      "lastModifiedBy": {
        "user": {
          "id": "fbab97d0-4932-4511-b675-204639209557"
        }
      },
      "lastModifiedDateTime": "2017-04-24T22:52:29.814Z"
    },
    "95e27074-6c4a-447a-aa24-9d718a0b86f": {
      "@odata.type": "#microsoft.graph.plannerChecklistItem",
      "isChecked": true,
      "title": "Update task details",
      "orderHint": "8587094707721254251P]",
      "lastModifiedBy": {
        "user": {
          "id": "fbab97d0-4932-4511-b675-204639209557"
        }
      },
      "lastModifiedDateTime": "2017-04-24T22:52:29.814Z"
    }
  },
  "id": "gcrYAaAkgU2EQUvpkNNXLGQAGTtu"
}
```

<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "Update plannertaskdetails",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->

