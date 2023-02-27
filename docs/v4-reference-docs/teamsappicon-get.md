---
title: "Get teamsAppIcon"
description: "Retrieve an icon associated with a specific definition of a Teams app."
ms.localizationpriority: medium
author: "jecha"
ms.prod: "microsoft-teams"
doc_type: "apiPageType"
---

# Get teamsAppIcon

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Retrieve a [Teams app icon](../resources/teamsappicon.md) associated with a specific [definition](../resources/teamsappdefinition.md) of an [app](../resources/teamsapp.md).

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission Type                        | Permissions (from least to most privileged)                      |
| :------------------------------------- | :--------------------------------------------------------------- |
| Delegated (work or school account)     | AppCatalog.Read.All, AppCatalog.ReadWrite.All, AppCatalog.Submit |
| Delegated (personal Microsoft account) | Not supported.                                                   |
| Application                            | AppCatalog.Read.All, AppCatalog.ReadWrite.All                    |

## HTTP request

**Get color icon of a Teams app definition**

<!-- { "blockType": "ignored" } -->
```http
GET /appCatalogs/teamsApps/{teams-app-id}/appDefinitions/{app-definition-id}/colorIcon
```

**Get outline icon of a Teams app definition**

<!-- { "blockType": "ignored" } -->
```http
GET /appCatalogs/teamsApps/{teams-app-id}/appDefinitions/{app-definition-id}/outlineIcon
```

## Optional query parameters

This operation supports the `$select` and `$expand` [OData query parameters](/graph/query-parameters) to customize the response.

## Request headers

| Header           | Value                      |
| :--------------- | :------------------------- |
| Authorization    | Bearer {token}. Required.  |

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a [teamsAppIcon](../resources/teamsappicon.md) object in the response body.

## Examples

### Example 1: Get color icon of a *custom* Teams app

#### Request

The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_teamsappicon_coloricon_customapp",
  "sampleKeys": ["5a31d4f7-a11d-4052-96eb-1b40786a2a78", "NWEzMWQ0ZjctYTExZC00MDUyLTk2ZWItMWI0MDc4NmEyYTc4IyM2LjAuNSMjUHVibGlzaGVk"]
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/appCatalogs/teamsApps/5a31d4f7-a11d-4052-96eb-1b40786a2a78/appDefinitions/NWEzMWQ0ZjctYTExZC00MDUyLTk2ZWItMWI0MDc4NmEyYTc4IyM2LjAuNSMjUHVibGlzaGVk/colorIcon
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var teamsAppIcon = await graphClient.AppCatalogs.TeamsApps["{teamsApp-id}"].AppDefinitions["{teamsAppDefinition-id}"].ColorIcon
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following example shows the response for an organizational app. 
> **Note**: Accessing the actual [image of the custom app's icon](teamworkhostedcontent-get.md) requires a Microsoft Graph token to be set on the request.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.teamsAppIcon"
} -->
```http
HTTP/1.1 200 OK
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#appCatalogs/teamsApps('5a31d4f7-a11d-4052-96eb-1b40786a2a78')/appDefinitions('NWEzMWQ0ZjctYTExZC00MDUyLTk2ZWItMWI0MDc4NmEyYTc4IyM2LjAuNSMjUHVibGlzaGVk')/colorIcon/$entity",
    "id": "aHR0cHM6Ly91cy1hcGkuYXNtLnNreXBlLmNvbS92MS9vYmplY3RzLzAtd3VzLWQ0LWQwOGVkNTQ2MjQ2MTliNTc4OGIwMWUzODNlMWVjYzU3L3ZpZXdzL2ltZ3BzaF9mdWxsc2l6ZQ==",
    "webUrl": "https://graph.microsoft.com/beta/appCatalogs/teamsApps/5a31d4f7-a11d-4052-96eb-1b40786a2a78/appDefinitions/NWEzMWQ0ZjctYTExZC00MDUyLTk2ZWItMWI0MDc4NmEyYTc4IyM2LjAuNSMjUHVibGlzaGVk/colorIcon/hostedContent/$value"
}
```

### Example 2: Get outline icon of a *custom* Teams app

#### Request

The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_teamsappicon_outlineicon_customapp",
  "sampleKeys": ["5a31d4f7-a11d-4052-96eb-1b40786a2a78", "NWEzMWQ0ZjctYTExZC00MDUyLTk2ZWItMWI0MDc4NmEyYTc4IyM2LjAuNSMjUHVibGlzaGVk"]
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/appCatalogs/teamsApps/5a31d4f7-a11d-4052-96eb-1b40786a2a78/appDefinitions/NWEzMWQ0ZjctYTExZC00MDUyLTk2ZWItMWI0MDc4NmEyYTc4IyM2LjAuNSMjUHVibGlzaGVk/outlineIcon
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var teamsAppIcon = await graphClient.AppCatalogs.TeamsApps["{teamsApp-id}"].AppDefinitions["{teamsAppDefinition-id}"].OutlineIcon
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following example shows the response for an organizational app. 
> **Note**:  Accessing the actual [image of the custom app's icon](teamworkhostedcontent-get.md) requires a Microsoft Graph token to be set on the request.


<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.teamsAppIcon"
} -->
```http
HTTP/1.1 200 OK
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#appCatalogs/teamsApps('5a31d4f7-a11d-4052-96eb-1b40786a2a78')/appDefinitions('NWEzMWQ0ZjctYTExZC00MDUyLTk2ZWItMWI0MDc4NmEyYTc4IyM2LjAuNSMjUHVibGlzaGVk')/outlineIcon/$entity",
    "id": "aHR0cHM6Ly91cy1hcGkuYXNtLnNreXBlLmNvbS92MS9vYmplY3RzLzAtd3VzLWQ0LWIxYzU0Mzg0NGE5ZmFjY2Y2YWI4NDdkNWY0NTU0ZGU0L3ZpZXdzL2ltZ3BzaF9mdWxsc2l6ZQ==",
    "webUrl": "https://graph.microsoft.com/beta/appCatalogs/teamsApps/5a31d4f7-a11d-4052-96eb-1b40786a2a78/appDefinitions/NWEzMWQ0ZjctYTExZC00MDUyLTk2ZWItMWI0MDc4NmEyYTc4IyM2LjAuNSMjUHVibGlzaGVk/outlineIcon/hostedContent/$value"
}
```


### Example 3: Get color icon of a *store* Teams app

#### Request

The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_teamsappicon_outlineicon_publicapp_color_icon",
  "sampleKeys": ["95de633a-083e-42f5-b444-a4295d8e9314", "OTVkZTYzM2EtMDgzZS00MmY1LWI0NDQtYTQyOTVkOGU5MzE0IyMxLjAuNSMjUHVibGlzaGVk"]
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/appCatalogs/teamsApps/95de633a-083e-42f5-b444-a4295d8e9314/appDefinitions/OTVkZTYzM2EtMDgzZS00MmY1LWI0NDQtYTQyOTVkOGU5MzE0IyMxLjAuNSMjUHVibGlzaGVk/colorIcon/
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var teamsAppIcon = await graphClient.AppCatalogs.TeamsApps["{teamsApp-id}"].AppDefinitions["{teamsAppDefinition-id}"].ColorIcon
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following example shows the response for a store app.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.teamsAppIcon"
} -->
```http
HTTP/1.1 200 OK
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#appCatalogs/teamsApps('95de633a-083e-42f5-b444-a4295d8e9314')/appDefinitions('OTVkZTYzM2EtMDgzZS00MmY1LWI0NDQtYTQyOTVkOGU5MzE0IyMxLjAuNSMjUHVibGlzaGVk')/colorIcon/$entity",
    "id": "aHR0cHM6Ly9zdGF0aWNzLnRlYW1zLmNkbi5vZmZpY2UubmV0L2V2ZXJncmVlbi1hc3NldHMvYXBwcy85NWRlNjMzYS0wODNlLTQyZjUtYjQ0NC1hNDI5NWQ4ZTkzMTRfbGFyZ2VJbWFnZS5wbmc/dj0xLjAuNQ==",
    "webUrl": "https://statics.teams.cdn.office.net/evergreen-assets/apps/95de633a-083e-42f5-b444-a4295d8e9314_largeImage.png?v=1.0.5"
}
```

### Example 4: Get outline icon of a *store* Teams app

#### Request

The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "get_teamsappicon_outlineicon_publicapp_outline_icon",
  "sampleKeys": ["95de633a-083e-42f5-b444-a4295d8e9314", "OTVkZTYzM2EtMDgzZS00MmY1LWI0NDQtYTQyOTVkOGU5MzE0IyMxLjAuNSMjUHVibGlzaGVk"]
}-->
```msgraph-interactive
GET https://graph.microsoft.com/beta/appCatalogs/teamsApps/95de633a-083e-42f5-b444-a4295d8e9314/appDefinitions/OTVkZTYzM2EtMDgzZS00MmY1LWI0NDQtYTQyOTVkOGU5MzE0IyMxLjAuNSMjUHVibGlzaGVk/outlineIcon/
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var teamsAppIcon = await graphClient.AppCatalogs.TeamsApps["{teamsApp-id}"].AppDefinitions["{teamsAppDefinition-id}"].OutlineIcon
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following example shows the response for a store app.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.teamsAppIcon"
} -->
```http
HTTP/1.1 200 OK
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#appCatalogs/teamsApps('95de633a-083e-42f5-b444-a4295d8e9314')/appDefinitions('OTVkZTYzM2EtMDgzZS00MmY1LWI0NDQtYTQyOTVkOGU5MzE0IyMxLjAuNSMjUHVibGlzaGVk')/outlineIcon/$entity",
    "id": "aHR0cHM6Ly9zdGF0aWNzLnRlYW1zLmNkbi5vZmZpY2UubmV0L2V2ZXJncmVlbi1hc3NldHMvYXBwcy85NWRlNjMzYS0wODNlLTQyZjUtYjQ0NC1hNDI5NWQ4ZTkzMTRfc21hbGxJbWFnZS5wbmc/dj0xLjAuNQ==",
    "webUrl": "https://statics.teams.cdn.office.net/evergreen-assets/apps/95de633a-083e-42f5-b444-a4295d8e9314_smallImage.png?v=1.0.5"
}
```

## See also

- [Get hosted content in app's icon](teamworkhostedcontent-get.md)
- [List apps in catalog](appcatalogs-list-teamsapps.md)
