---
title: "List memberOf"
description: "Get groups or administrative units that this device is a direct member of. This operation is not transitive."
author: "myra-ramdenbourg"
ms.localizationpriority: medium
ms.prod: "directory-management"
doc_type: apiPageType
---

# List memberOf

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get [groups](../resources/group.md) and [administrative units](../resources/administrativeunit.md) that the device is a direct member of. This operation is not transitive.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | Device.Read.All, Directory.Read.All, Directory.ReadWrite.All    |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | Device.Read.All, Device.ReadWrite.All, Directory.Read.All, Directory.ReadWrite.All |


When an application queries a relationship that returns a directoryObject type collection, if it does not have permission to read a certain derived type (like device), members of that type are returned but with limited information. With this behaviour applications can request the least privileged permissions they need, rather than rely on the set of *Directory.** permissions. For details, see [Limited information returned for inaccessible member objects](/graph/permissions-overview#limited-information-returned-for-inaccessible-member-objects).

## HTTP request

You can address the device using either its **id** or **deviceId**.
<!-- { "blockType": "ignored" } -->
```http
GET /devices/{id}/memberOf
GET /devices(deviceId='{deviceId}')/memberOf
```
## Optional query parameters

This method supports the `$search`, `$count`, and `$filter` [OData query parameters](/graph/query-parameters) to help customize the response. OData cast is also enabled, for example, you can cast to get just the directoryRoles the device is a member of. You can use `$search` on the **displayName** and **description** properties.

Some queries are supported only when you use the **ConsistencyLevel** header set to `eventual` and `$count`. For more information, see [Advanced query capabilities on Azure AD directory objects](/graph/aad-advanced-queries).

## Request headers
| Header       | Value |
|:---------------|:--------|
| Authorization  | Bearer {token}. Required.  |
| ConsistencyLevel | eventual. This header and `$count` are required when using `$search`, OData cast parameters, or in specific usage of `$filter`. For more information about the use of **ConsistencyLevel** and `$count`, see [Advanced query capabilities on Azure AD directory objects](/graph/aad-advanced-queries). |

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and collection of [directoryObject](../resources/directoryobject.md) objects in the response body.

## Examples

### Example 1: Get groups that the device is a direct member of

#### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_device_memberof"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/devices/{id}/memberOf
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var memberOf = await graphClient.Devices["{device-id}"].MemberOf
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response. 
> **Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.directoryObject",
  "isCollection": true
} -->
```http
HTTP/1.1 200 OK
Content-type: application/json

{
  "value": [
    {
      "@odata.type": "#microsoft.graph.group",
      "id": "id-value",
      "createdDateTime": null,
      "description": "All users at the company",
      "displayName": "All Users",
      "groupTypes": [],
      "mailEnabled": false,
      "securityEnabled": true,
    }
  ]
}
```

### Example 2: Get only a count of all memberships

#### Request

The following is an example of the request.

<!-- {
  "blockType": "ignored",
  "name": "get_count_only"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/devices/{id}/memberOf/$count
ConsistencyLevel: eventual
```

#### Response

The following is an example of the response.

<!-- {
  "blockType": "response",
  "truncated": true
} -->
```http
HTTP/1.1 200 OK
Content-type: text/plain

394
```


### Example 3: Use OData cast and $search to get membership with display names that contain the letters 'Video' including a count of returned objects

#### Request

The following is an example of the request. 

<!-- {
  "blockType": "ignored",
  "name": "get_video_count"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/devices/{id}/memberOf/microsoft.graph.group?$count=true&$orderBy=displayName&$search="displayName:Video"
ConsistencyLevel: eventual
```

#### Response

The following is an example of the response.
>**Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.directoryObject",
  "isCollection": true
} -->
```http
HTTP/1.1 200 OK
Content-type: application/json

{
  "@odata.context":"https://graph.microsoft.com/beta/$metadata#directoryObjects",
  "@odata.count":1396,
  "value":[
    {
      "displayName":"SFA Videos",
      "mail":"SFAVideos@service.contoso.com",
      "mailNickname":"SFAVideos"
    }
  ]
}
```

### Example 4: Use OData cast and $filter to get membership with a display name that starts with the letter 'A' including a count of returned objects

#### Request

The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_devices_memberof_startswith"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/devices/{id}/memberOf/microsoft.graph.group?$count=true&$orderBy=displayName&$filter=startswith(displayName, 'A')
ConsistencyLevel: eventual
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var queryOptions = new List<QueryOption>()
{
	new QueryOption("$count", "true")
};

var group = await graphClient.Devices["{device-id}"].MemberOf
	.Request( queryOptions )
	.Header("ConsistencyLevel","eventual")
	.Filter("startswith(displayName, 'A')")
	.OrderBy("displayName")
	.GetAsync();

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
  "@odata.type": "microsoft.graph.directoryObject",
  "isCollection": true
} -->
```http
HTTP/1.1 200 OK
Content-type: application/json

{
  "@odata.context":"https://graph.microsoft.com/beta/$metadata#directoryObjects",
  "@odata.count":76,
  "value":[
    {
      "displayName":"AAD Contoso Videos",
      "mail":"AADContosoVideos@contoso.com",
      "mailEnabled":true,
      "mailNickname":"AADContoso_Videos",
      "securityEnabled":true
    }
  ]
}
```
<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "List memberOf",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->


