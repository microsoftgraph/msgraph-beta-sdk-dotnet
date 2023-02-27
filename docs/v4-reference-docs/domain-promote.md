---
title: "domain: promote"
description: "Promote a verified subdomain to the root domain."
author: "franqq"
ms.localizationpriority: medium
ms.prod: "directory-management"
doc_type: apiPageType
---

# domain: promote

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Promote a verified subdomain to the root domain. A verified domain has its **isVerified** property set to `true`.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions  |
|:--------------------|:-------------|
|Delegated (work or school account) | Domain.ReadWrite.All |
|Delegated (personal Microsoft account) | Not supported. |
|Application | Domain.ReadWrite.All |

The work or school account needs to belong to one of the following roles:

* Global Administrator
* Domain Name Administrator
* Partner Tier2 Support

## HTTP request

<!-- { "blockType": "ignored" } -->
```http
POST /domains/{id}/promote
```

> For {id}, specify the domain with its fully qualified domain name.

## Request headers

| Name       | Description|
|:---------------|:----------|
| Authorization  | Bearer {token}. Required.|
| Content-Type  | application/json |

## Request body

## Response

If successful, this call returns a `200 OK` response and a Boolean value that specifies the publishing status of the content type.

## Example

### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "domain_promote",
  "sampleKeys": ["contoso.com"]
}-->
```http
POST https://graph.microsoft.com/beta/domains/contoso.com/promote
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

await graphClient.Domains["{domain-id}"]
	.Promote()
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "string"
}
-->

```http
HTTP/1.1 200 OK
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#Edm.Boolean",
    "value": true
}
```
