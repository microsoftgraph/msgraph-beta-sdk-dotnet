---
title: "Create authoredNote"
description: "Create a new authoredNote object."
author: "skadam-msft"
ms.localizationpriority: medium
ms.prod: "compliance"
doc_type: apiPageType
---

# Create authoredNote
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [authoredNote](../resources/authorednote.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|SubjectRightsRequest.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|Not supported.|

## HTTP request

> [!CAUTION]
> The subject rights request API under the `/privacy` node is deprecated and will stop returning data on March 30, 2025. Please use the new path under `/security`.
<!-- {
  "blockType": "ignored"
}
-->
``` http
POST /security/subjectRightsRequests/{subjectRightsRequestId}/notes
POST /privacy/subjectRightsRequests/{subjectRightsRequestId}/notes
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the [authoredNote](../resources/authorednote.md) object.

The following table shows the properties that are required when you create the [authoredNote](../resources/authorednote.md).

|Property|Type|Description|
|:---|:---|:---|
|content|[microsoft.graph.itemBody](../resources/itembody.md)|The note content for the request.|


## Response

If successful, this method returns a `201 Created` response code and an [authoredNote](../resources/authorednote.md) object in the response body.

## Examples

### Request

The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_authorednote_from_"
}
-->
``` http
POST https://graph.microsoft.com/beta/privacy/subjectRightsRequests/{subjectRightsRequestId}/notes
Content-Type: application/json

{
    "content": {
        "content": "Please take a look at the files tagged with follow up",
        "contentType": "text"
    }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var authoredNote = new AuthoredNote
{
	Content = new ItemBody
	{
		Content = "Please take a look at the files tagged with follow up",
		ContentType = BodyType.Text
	}
};

await graphClient.Privacy.SubjectRightsRequests["{subjectRightsRequest-id}"].Notes
	.Request()
	.AddAsync(authoredNote);

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
  "@odata.type": "microsoft.graph.authoredNote"
}
-->
``` http
HTTP/1.1 201 Created
Content-Type: application/json

{
    "id": "D450C4F9-CC18-4784-9406-9372F4E05F7B",
    "createdDateTime": "2022-05-10T22:42:28Z",
    "author": {
        "user": {
            "id": "1B761ED2-AA7E-4D82-9CF5-C09D737B6167",
            "displayName": "srradmin@contoso.com"
        }
    },
    "content": {
        "content": "Please take a look at the files tagged with follow up",
        "contentType": "text"
    }
}
```

