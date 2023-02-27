---
title: "Create namedLocation"
description: "Create a new namedLocation."
ms.localizationpriority: medium
author: "davidspooner"
ms.prod: "identity-and-sign-in"
doc_type: apiPageType
---

# Create namedLocation

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [namedLocation](../resources/namedlocation.md) object. Named locations can be either [ipNamedLocation](../resources/ipnamedlocation.md) or [countryNamedLocation](../resources/countrynamedlocation.md) objects.

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
POST /identity/conditionalAccess/namedLocations
```

## Request headers

| Name          | Description   |
|:--------------|:--------------|
| Authorization | Bearer {token}. Required. |
| Content-Type  | application/json. Required. |

## Request body

In the request body, supply a JSON representation of an [ipNamedLocation](../resources/ipnamedlocation.md) or [countryNamedLocation](../resources/countrynamedlocation.md) object. You must specify the **@odata.type** of the derived type, that is, `#microsoft.graph.ipNamedLocation` for an [ipNamedLocation](../resources/ipnamedlocation.md) object or `#microsoft.graph.countryNamedLocation` for a [countryNamedLocation](../resources/countrynamedlocation.md) object.

The following table lists the properties that are required to create an [ipNamedLocation](../resources/ipnamedlocation.md) object.

| Property     | Type        | Description |
|:-------------|:------------|:------------|
|displayName|String|Human-readable name of the location. Required.|
|ipRanges|[ipRange](../resources/iprange.md) collection|List of IP address ranges in IPv4 CIDR format (e.g. 1.2.3.4/32) or any allowable IPv6 format from IETF RFC596. Required. The **@odata.type** of the ipRange is also required.|

The following table lists the properties that are required to create an [countryNamedLocation](../resources/countrynamedlocation.md) object.

| Property     | Type        | Description |
|:-------------|:------------|:------------|
|countriesAndRegions|String collection|List of countries and/or regions in two-letter format specified by ISO 3166-2. Required.|
|displayName|String|Human-readable name of the location. Required.|
## Response

If successful, this method returns a `201 Created`response code and a new [ipNamedLocation](../resources/ipnamedlocation.md) or [countryNamedLocation](../resources/countrynamedlocation.md) object in the response body.

## Examples

### Example 1: Create an ipNamedLocation

#### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_namedlocation_from_conditionalaccessroot_1"
}-->

```http
POST https://graph.microsoft.com/beta/identity/conditionalAccess/namedLocations
Content-type: application/json

{
    "@odata.type": "#microsoft.graph.ipNamedLocation",
    "displayName": "Untrusted IP named location",
    "isTrusted": false,
    "ipRanges": [
        {
            "@odata.type": "#microsoft.graph.iPv4CidrRange",
            "cidrAddress": "12.34.221.11/22"
        },
        {
            "@odata.type": "#microsoft.graph.iPv6CidrRange",
            "cidrAddress": "2001:0:9d38:90d6:0:0:0:0/63"
        }
    ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var namedLocation = new IpNamedLocation
{
	DisplayName = "Untrusted IP named location",
	IsTrusted = false,
	IpRanges = new List<IpRange>()
	{
		new IPv4CidrRange
		{
			CidrAddress = "12.34.221.11/22"
		},
		new IPv6CidrRange
		{
			CidrAddress = "2001:0:9d38:90d6:0:0:0:0/63"
		}
	}
};

await graphClient.Identity.ConditionalAccess.NamedLocations
	.Request()
	.AddAsync(namedLocation);

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
  "@odata.type": "microsoft.graph.namedLocation"
} -->

```http
HTTP/1.1 201 Created
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#namedLocations/$entity",
    "@odata.type": "#microsoft.graph.ipNamedLocation",
    "id": "0854951d-5fc0-4eb1-b392-9b2c9d7949c2",
    "displayName": "Untrusted IP named location",
    "modifiedDateTime": "2019-09-04T01:11:34.9387578Z",
    "createdDateTime": "2019-09-04T01:11:34.9387578Z",
    "isTrusted": false,
    "ipRanges": [
        {
            "@odata.type": "#microsoft.graph.iPv4CidrRange",
            "cidrAddress": "12.34.221.11/22"
        },
        {
            "@odata.type": "#microsoft.graph.iPv6CidrRange",
            "cidrAddress": "2001:0:9d38:90d6:0:0:0:0/63"
        }
    ]
}
```
### Example 2: Create a countryNamedLocation

#### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_namedlocation_from_conditionalaccessroot_2"
}-->

```http
POST https://graph.microsoft.com/beta/identity/conditionalAccess/namedLocations
Content-type: application/json

{
    "@odata.type": "#microsoft.graph.countryNamedLocation",
    "displayName": "Named location with unknown countries and regions",
    "countriesAndRegions": [
        "US",
        "GB"
    ],
    "includeUnknownCountriesAndRegions": true
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var namedLocation = new CountryNamedLocation
{
	DisplayName = "Named location with unknown countries and regions",
	CountriesAndRegions = new List<String>()
	{
		"US",
		"GB"
	},
	IncludeUnknownCountriesAndRegions = true
};

await graphClient.Identity.ConditionalAccess.NamedLocations
	.Request()
	.AddAsync(namedLocation);

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
  "@odata.type": "microsoft.graph.namedLocation"
} -->

```http
HTTP/1.1 201 Created
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#namedLocations/$entity",
    "@odata.type": "#microsoft.graph.countryNamedLocation",
    "id": "1c4427fd-0885-4a3d-8b23-09a899ffa959",
    "displayName": "Named location with unknown countries and regions",
    "modifiedDateTime": "2019-09-04T01:08:02.5249255Z",
    "createdDateTime": "2019-09-04T01:08:02.5249255Z",
    "countriesAndRegions": [
        "US",
        "GB"
    ],
    "includeUnknownCountriesAndRegions": true
}
```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "Create namedLocation",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->


