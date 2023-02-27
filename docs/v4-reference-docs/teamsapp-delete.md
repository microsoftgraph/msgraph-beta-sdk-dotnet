---
title: "Delete teamsApp"
description: "Remove a Teams app from an organization's app catalog (the tenant app catalog). "
ms.localizationpriority: medium
author: "nkramer"
ms.prod: "microsoft-teams"
doc_type: apiPageType
---

# Delete teamsApp

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

<!-- markdownlint-disable MD001 -->

Delete an [app](../resources/teamsapp.md) from an organization's app catalog (the tenant app catalog). To delete an app, the **distributionMethod** property for the app must be set to `organization`.

You can also use this API to remove a submitted app from the review process.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

>**Note:** Only global administrators can call this API. 

| Permission Type                        | Permissions (from least to most privileged)|
|:----------------------------------     |:-------------|
| Delegated (work or school account) | AppCatalog.Submit, AppCatalog.ReadWrite.All, Directory.ReadWrite.All** |
| Delegated (personal Microsoft account) | Not supported.|
| Application                            | Not supported. |

> **Note**: Permissions marked with ** are supported only for backward compatibility. We recommend that you update your solutions to use an alternative permission listed in the previous table and avoid using these permissions going forward.

## HTTP request

<!-- { "blockType": "ignored" } -->

To delete an app from the app catalog:

```http
DELETE /appCatalogs/teamsApps/{id}
```

To delete an app that has been submitted but has not been approved:

```http
DELETE appCatalogs/teamsApps/{appId}/appDefinitions/{appDefinitionId}
```

## Request headers

| Header        | Value           |
|:--------------|:--------------  |
| Authorization | Bearer {token}. Required.  |

## Request body

Do not supply a request body for this method.

>**Note:** Use the ID returned from the [List published apps](./appcatalogs-list-teamsapps.md) call to reference the app you'd like to delete. Do not use the ID from the manifest of the zip app package.

## Response

If successful, this method returns a `204 No Content` response code. It does not return anything in the response body.

## Example

### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "delete_teamsapp"
}-->

```http
DELETE https://graph.microsoft.com/beta/appCatalogs/teamsApps/06805b9e-77e3-4b93-ac81-525eb87513b8
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.AppCatalogs.TeamsApps["{teamsApp-id}"]
	.Request()
	.DeleteAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

<!-- {
  "blockType": "response"
} -->

```http
HTTP/1.1 204 No Content
```
