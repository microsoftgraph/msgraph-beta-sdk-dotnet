---
title: "Update countryNamedlocation"
description: "Update the properties of a countryNamedLocation object."
ms.localizationpriority: medium
author: "dkershaw10"
ms.prod: "identity-and-sign-in"
doc_type: apiPageType
---

# Update countryNamedLocation

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of a [countryNamedLocation](../resources/countryNamedLocation.md) object.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
|:---------------------------------------|:--------------------------------------------|
| Delegated (work or school account)     | Policy.Read.All and Policy.ReadWrite.ConditionalAccess |
| Delegated (personal Microsoft account) | Not supported. |
| Application                            | Policy.Read.All and Policy.ReadWrite.ConditionalAccess |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
PATCH /identity/conditionalAccess/namedLocations/{id}
```

## Request headers

| Name       | Description|
|:-----------|:-----------|
| Authorization | Bearer {token}. Required. |
| Content-type  | application/json. Required. |

## Request body

In the request body, supply the values for relevant fields that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values. For best performance, don't include existing values that haven't changed.

You must specify the **@odata.type** as `#microsoft.graph.countryNamedLocation`.

| Property     | Type        | Description |
|:-------------|:------------|:------------|
|countriesAndRegions|String collection|List of countries and/or regions in two-letter format specified by ISO 3166-2.|
|displayName|String|Human-readable name of the location.|
|includeUnknownCountriesAndRegions|Boolean|The value is `true` if IP addresses that don't map to a country or region should be included in the named location.|

## Response

If successful, this method returns a `204 No Content` response code. It does not return anything in the response body.

## Examples

### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_countrynamedlocation"
}-->

```http
PATCH https://graph.microsoft.com/beta/identity/conditionalAccess/namedLocations/1c4427fd-0885-4a3d-8b23-09a899ffa959
Content-type: application/json

{
    "@odata.type": "#microsoft.graph.countryNamedLocation",
    "displayName": "Updated named location without unknown countries and regions",
    "countriesAndRegions": [
        "CA",
        "IN"
    ],
    "includeUnknownCountriesAndRegions": false
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var namedLocation = new CountryNamedLocation
{
	DisplayName = "Updated named location without unknown countries and regions",
	CountriesAndRegions = new List<String>()
	{
		"CA",
		"IN"
	},
	IncludeUnknownCountriesAndRegions = false
};

await graphClient.Identity.ConditionalAccess.NamedLocations["{namedLocation-id}"]
	.Request()
	.UpdateAsync(namedLocation);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

<!-- {
  "blockType": "response"
} -->

```http
HTTP/1.1 204 No Content
```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "Update countrynamedlocation",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->


