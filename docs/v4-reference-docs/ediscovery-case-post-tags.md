---
title: "Create tag"
description: "Create a new tag object."
author: "mahage-msft"
ms.localizationpriority: medium
ms.prod: "ediscovery"
doc_type: apiPageType
---

# Create tag

Namespace: microsoft.graph.ediscovery

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new tag for the specified case.  The tags are used in review sets while reviewing content.

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
POST /compliance/ediscovery/cases/{caseId}/tags
```

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body

In the request body, supply a JSON representation of the [tag](../resources/ediscovery-tag.md) object.

The following table shows the properties that are required when you create the [tag](../resources/ediscovery-tag.md).

|Property|Type|Description|
|:---|:---|:---|
|childSelectability|[microsoft.graph.ediscovery.childSelectability](../resources/ediscovery-tag.md#childselectability-values)|Indicates whether a single or multiple child tags can be associated with a document. Possible values are: `One`, `Many`.  This value controls whether the UX presents the tags as checkboxes or a radio button group. Required.|
|displayName|String|Display name of the tag. Required.|

## Response

If successful, this method returns a `201 Created` response code and a [microsoft.graph.ediscovery.tag](../resources/ediscovery-tag.md) object in the response body.

## Examples

### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_tag_from_"
}
-->

``` http
POST https://graph.microsoft.com/beta/compliance/ediscovery/cases/47746044-fd0b-4a30-acfc-5272b691ba5b/tags
Content-Type: application/json

{
  "displayName":"Privileged",
  "description":"The document is privileged",
  "parent@odata.bind":"https://graph.microsoft.com/beta/compliance/ediscovery/cases/47746044-fd0b-4a30-acfc-5272b691ba5b/tags/98fdad78bbce4519b75474bc150575c3"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var tag = new Microsoft.Graph.Ediscovery.Tag
{
	DisplayName = "Privileged",
	Description = "The document is privileged",
	AdditionalData = new Dictionary<string, object>()
	{
		{"parent@odata.bind", "https://graph.microsoft.com/beta/compliance/ediscovery/cases/47746044-fd0b-4a30-acfc-5272b691ba5b/tags/98fdad78bbce4519b75474bc150575c3"}
	}
};

await graphClient.Compliance.Ediscovery.Cases["{ediscovery.case-id}"].Tags
	.Request()
	.AddAsync(tag);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.ediscovery.tag"
}
-->

``` http
HTTP/1.1 201 Created
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#compliance/ediscovery/cases/47746044-fd0b-4a30-acfc-5272b691ba5b/tags/$entity",
    "displayName": "Privileged",
    "description": "The document is privileged",
    "lastModifiedDateTime": "2021-01-12T01:01:09.0419153Z",
    "childSelectability": "One",
    "id": "0825ef81ade74095a3b3154a3c434c3e",
    "createdBy": {
        "user": {
            "id": "c1db6f13-332a-4d84-b111-914383ff9fc9",
            "displayName": null,
            "userPrincipalName": "admin@contoso.com"
        }
    }
}
```
