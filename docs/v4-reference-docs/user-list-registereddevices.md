---
title: "List registeredDevices"
description: "Get the list of user's registered devices."
ms.localizationpriority: medium
author: "yyuank"
ms.prod: "users"
doc_type: apiPageType
---

# List registeredDevices

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get the list of user's registered devices.
## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | User.Read, User.Read.All, User.ReadWrite.All, Directory.Read.All, Directory.ReadWrite.All    |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | User.Read.All, User.ReadWrite.All, Directory.Read.All, Directory.ReadWrite.All |


When an application queries a relationship that returns a directoryObject type collection, if it does not have permission to read a certain derived type (like device), members of that type are returned but with limited information. With this behaviour applications can request the least privileged permissions they need, rather than rely on the set of *Directory.** permissions. For details, see [Limited information returned for inaccessible member objects](/graph/permissions-overview#limited-information-returned-for-inaccessible-member-objects).

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
GET /me/registeredDevices
GET /users/{id | userPrincipalName}/registeredDevices
```
## Optional query parameters
This method supports the [OData Query Parameters](/graph/query-parameters) to help customize the response.
## Request headers
| Header       | Value |
|:---------------|:--------|
| Authorization  | Bearer {token}. Required.  |
| Accept  | application/json|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and collection of [directoryObject](../resources/directoryobject.md) objects in the response body.
## Example
##### Request
Here is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_registereddevices"
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/me/registeredDevices
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var registeredDevices = await graphClient.Me.RegisteredDevices
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

