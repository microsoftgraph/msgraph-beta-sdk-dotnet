---
title: "List childTags"
description: "Get a list of child [tag] objects associated with a tag."
author: "mahage-msft"
ms.localizationpriority: medium
ms.prod: "ediscovery"
doc_type: apiPageType
---

# List childTags

Namespace: microsoft.graph.ediscovery

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get a list of child [tag](../resources/ediscovery-tag.md) objects associated with a tag.

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
GET /compliance/ediscovery/cases/{caseId}/tags/{tagId}/childTags
```

## Optional query parameters

This method supports some of the OData query parameters to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [microsoft.graph.ediscovery.tag](../resources/ediscovery-tag.md) objects in the response body.

## Examples

### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_tag_2"
}
-->

``` http
GET https://graph.microsoft.com/beta/compliance/ediscovery/cases/47746044-fd0b-4a30-acfc-5272b691ba5b/tags/e54b3f535b434a9a8743b84e34c00504/childTags
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var childTags = await graphClient.Compliance.Ediscovery.Cases["{ediscovery.case-id}"].Tags["{ediscovery.tag-id}"].ChildTags
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "Collection(microsoft.graph.ediscovery.tag)"
}
-->

``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#Collection(microsoft.graph.ediscovery.tag)",
    "value": [
        {
            "displayName": "Yes",
            "description": "The document is responsive",
            "lastModifiedDateTime": "2021-01-11T19:32:22.4091161Z",
            "childSelectability": "One",
            "id": "081ff31e7324423186e01b549efe7033",
            "createdBy": {
                "user": {
                    "id": "c1db6f13-332a-4d84-b111-914383ff9fc9",
                    "displayName": "EDisco Admin",
                    "userPrincipalName": "admin@contoso.com"
                }
            },
            "childTags": []
        },
        {
            "displayName": "No",
            "description": "The document is not responsive",
            "lastModifiedDateTime": "2021-01-11T19:32:21.5693878Z",
            "childSelectability": "One",
            "id": "61624e6c96a64ccea40e0d2c48e23e16",
            "createdBy": {
                "user": {
                    "id": "c1db6f13-332a-4d84-b111-914383ff9fc9",
                    "displayName": "EDisco Admin",
                    "userPrincipalName": "admin@contoso.com"
                }
            },
            "childTags": []
        }
    ]
}
```
