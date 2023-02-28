---
title: "Create dataSource"
description: "Add additional data sources to a source collection."
author: "mahage-msft"
ms.localizationpriority: medium
ms.prod: "ediscovery"
doc_type: apiPageType
---

# Create dataSource

Namespace: microsoft.graph.ediscovery

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Add additional data sources to a source collection.

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
POST /compliance/ediscovery/cases/{caseId}/sourceCollections/{sourceCollectionId}/additionalSources
```

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body

In the request body, supply a JSON representation of the [dataSource](../resources/ediscovery-datasource.md) object.

The following table shows the properties that are required when you create the [dataSource](../resources/ediscovery-datasource.md).

>**Note:** Either **email** or **site** are required, not both. 

|Property|Type|Description|
|:---|:---|:---|
|email|string|SMTP address of the mailbox. To get the email address of a group, use [List groups](../api/group-list.md) or [Get group](../api/group-get.md). You can query by the name of the group using `$filter`; for example, `https://graph.microsoft.com/v1.0/groups?$filter=displayName eq 'secret group'&$select=mail,id,displayName`.|
|site|string|URL of the site; for example, `https://contoso.sharepoint.com/sites/HumanResources`. |

## Response

If successful, this method returns a `201 Created` response code and a [microsoft.graph.ediscovery.dataSource](../resources/ediscovery-datasource.md) object in the response body.

## Examples

### Example 1: Add a user or group mailbox to the additional sources

#### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_datasource_caseID_sourceCollectionID"
}
-->

``` http
POST https://graph.microsoft.com/beta/compliance/ediscovery/cases/15d80234-8320-4f10-96d0-d98d53ffdfc9/sourceCollections/39b0bafd920e4360995c62e18a5e8a49/additionalsources
Content-Type: application/json

{
    "@odata.type": "microsoft.graph.ediscovery.userSource",
    "email": "badguy@contoso.com"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var dataSource = new UserSource
{
	Email = "badguy@contoso.com"
};

await graphClient.Compliance.Ediscovery.Cases["{ediscovery.case-id}"].SourceCollections["{ediscovery.sourceCollection-id}"].AdditionalSources
	.Request()
	.AddAsync(dataSource);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

> **Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.ediscovery.dataSource"
}
-->

``` http
HTTP/1.1 201 Created
Content-Type: application/json

{
  "@odata.type": "microsoft.graph.ediscovery.dataSource",
  "id": "0fb67fc5-7fc5-0fb6-c57f-b60fc57fb60f",
  "displayName": "String",
  "createdDateTime": "String (timestamp)",
  "createdBy": {
    "@odata.type": "microsoft.graph.identitySet"
  }
}
```

### Example 2: Add a site or group site to additional sources

#### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "add_site_to_additional_sources"
}
-->

``` http
POST https://graph.microsoft.com/beta/compliance/ediscovery/cases/15d80234-8320-4f10-96d0-d98d53ffdfc9/sourceCollections/39b0bafd920e4360995c62e18a5e8a49/additionalsources
Content-Type: application/json

{
    "@odata.type": "microsoft.graph.ediscovery.siteSource",
    "site": {
        "webUrl": "https://contoso.sharepoint.com/sites/SecretSite"
    }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var dataSource = new SiteSource
{
	Site = new Site
	{
		WebUrl = "https://contoso.sharepoint.com/sites/SecretSite"
	}
};

await graphClient.Compliance.Ediscovery.Cases["{ediscovery.case-id}"].SourceCollections["{ediscovery.sourceCollection-id}"].AdditionalSources
	.Request()
	.AddAsync(dataSource);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

> **Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.ediscovery.dataSource"
}
-->

``` http
HTTP/1.1 201 Created
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#compliance/ediscovery/cases('15d80234-8320-4f10-96d0-d98d53ffdfc9')/sourceCollections('39b0bafd920e4360995c62e18a5e8a49')/additionalSources/$entity",
    "@odata.type": "#microsoft.graph.ediscovery.siteSource",
    "displayName": "Secret Site",
    "createdDateTime": "2021-08-11T23:35:02.33986Z",
    "id": "42393244-3838-4636-3437-453030334136",
    "createdBy": {
        "user": {
            "id": "798d8d23-2087-4e03-912e-c0d9db5cb5d2",
            "displayName": "Edisco Admin",
            "userPrincipalname": "ediscoadmin@contoso.com"
        }
    }
}
```
