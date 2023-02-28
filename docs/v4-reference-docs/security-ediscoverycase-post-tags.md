---
title: "Create tags"
description: "Create a new ediscoveryReviewTag object."
author: "SeunginLyu"
ms.localizationpriority: medium
ms.prod: "ediscovery"
doc_type: "apiPageType"
---

# Create tags
Namespace: microsoft.graph.security

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [ediscoveryReviewTag](../resources/security-ediscoveryreviewtag.md) object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|eDiscovery.Read.All, eDiscovery.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|Not supported.|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
POST /security/cases/ediscoveryCases/{ediscoveryCaseId}/tags
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body
In the request body, supply a JSON representation of the [ediscoveryReviewTag](../resources/security-ediscoveryreviewtag.md) object.

You can specify the following properties when you create an **ediscoveryReviewTag**.

|Property|Type|Description|
|:---|:---|:---|
|displayName|String|Display name of the tag. Required.|
|description|String|Description of the tag. Optional.|
|childSelectability|microsoft.graph.security.childSelectability|This value controls whether the UX presents the tags as checkboxes or a radio button group. The possible values are: `One`, `Many`. Required.|

## Response

If successful, this method returns a `201 Created` response code and an [microsoft.graph.security.ediscoveryReviewTag](../resources/security-ediscoveryreviewtag.md) object in the response body.

## Examples

### Example 1: Create a tag
#### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_ediscoveryreviewtag_selectibility_many"
}
-->
``` http
POST https://graph.microsoft.com/beta/security/cases/ediscoveryCases/58399dff-cebe-478f-b1af-d3227f1fd645/tags

{
    "displayName": "My tag API",
    "description": "Use Graph API to create tags",
    "childSelectability": "Many"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var ediscoveryReviewTag = new Microsoft.Graph.Security.EdiscoveryReviewTag
{
	DisplayName = "My tag API",
	Description = "Use Graph API to create tags",
	ChildSelectability = Microsoft.Graph.Security.ChildSelectability.Many
};

await graphClient.Security.Cases.EdiscoveryCases["{security.ediscoveryCase-id}"].Tags
	.Request()
	.AddAsync(ediscoveryReviewTag);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
The following is an example of the response.
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.security.ediscoveryReviewTag"
}
-->
``` http
HTTP/1.1 201 Created
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#security/cases/ediscoveryCases('58399dff-cebe-478f-b1af-d3227f1fd645')/tags/$entity",
    "displayName": "My tag API",
    "description": "Use Graph API to create tags",
    "lastModifiedDateTime": "2022-05-23T19:58:26.1573076Z",
    "childSelectability": "Many",
    "id": "7c6cc351-fb90-431f-8562-1b607a3144a4",
    "createdBy": {
        "user": {
            "id": "c25c3914-f9f7-43ee-9cba-a25377e0cec6",
            "displayName": "MOD Administrator",
            "userPrincipalName": "admin@M365x809305.onmicrosoft.com"
        },
        "application": {
            "id": "de8bc8b5-d9f9-48b1-a8ad-b748da725064",
            "displayName": "Graph Explorer"
        }
    }
}
```

### Example 2: Create a tag with a parent
#### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_tqag_with_a_parent"
}
-->
``` http
POST https://graph.microsoft.com/beta/security/cases/ediscoveryCases/58399dff-cebe-478f-b1af-d3227f1fd645/tags

{
    "displayName": "My tag API",
    "description": "Use Graph API to create tags",
    "childSelectability": "Many",
    "parent@odata.bind":""
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var ediscoveryReviewTag = new Microsoft.Graph.Security.EdiscoveryReviewTag
{
	DisplayName = "My tag API",
	Description = "Use Graph API to create tags",
	ChildSelectability = Microsoft.Graph.Security.ChildSelectability.Many,
	AdditionalData = new Dictionary<string, object>()
	{
		{"parent@odata.bind", ""}
	}
};

await graphClient.Security.Cases.EdiscoveryCases["{security.ediscoveryCase-id}"].Tags
	.Request()
	.AddAsync(ediscoveryReviewTag);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
The following is an example of the response.
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.security.ediscoveryReviewTag"
}
-->
``` http
HTTP/1.1 201 Created
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#security/cases/ediscoveryCases('58399dff-cebe-478f-b1af-d3227f1fd645')/tags/$entity",
    "displayName": "My tag API",
    "description": "Use Graph API to create tags",
    "lastModifiedDateTime": "2022-05-23T19:58:26.1573076Z",
    "childSelectability": "Many",
    "id": "7c6cc351-fb90-431f-8562-1b607a3144a4",
    "createdBy": {
        "user": {
            "id": "c25c3914-f9f7-43ee-9cba-a25377e0cec6",
            "displayName": "MOD Administrator",
            "userPrincipalName": "admin@M365x809305.onmicrosoft.com"
        },
        "application": {
            "id": "de8bc8b5-d9f9-48b1-a8ad-b748da725064",
            "displayName": "Graph Explorer"
        }
    }
}
```
