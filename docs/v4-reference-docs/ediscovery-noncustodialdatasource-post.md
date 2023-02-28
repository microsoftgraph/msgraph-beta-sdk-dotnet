---
title: "Create noncustodialDataSource"
description: "Create a new noncustodialDataSource object."
author: "mahage-msft"
ms.localizationpriority: medium
ms.prod: "ediscovery"
doc_type: apiPageType
---

# Create noncustodialDataSource

Namespace: microsoft.graph.ediscovery

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [noncustodialDataSource](../resources/ediscovery-noncustodialdatasource.md) object.

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
POST /compliance/ediscovery/cases/{caseId}/noncustodialDataSources
```

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body

In the request body, supply a JSON representation of the [noncustodialDataSource](../resources/ediscovery-noncustodialdatasource.md) object.

The following table shows the properties that are required when you create the [noncustodialDataSource](../resources/ediscovery-noncustodialdatasource.md).

|Property|Type|Description|
|:---|:---|:---|
|applyHoldToSource|Boolean|Indicates if hold is applied to non-custodial data source (such as mailbox or site).|
|datasource|[microsoft.graph.ediscovery.dataSource](../resources/ediscovery-datasource.md)|Either a userSource or siteSource.  For userSource, use "dataSource" : { "@odata.type" : "microsoft.graph.ediscovery.userSource", "email" : "SMTP address"}.  For site source use "dataSource" : { "@odata.type" : "microsoft.graph.ediscovery.siteSource", "site@odata.bind" : "siteId" }, where siteId can be derived from the site URL, e.g. `https://contoso.sharepoint.com/sites/HumanResources`, the Microsoft Graph request would be `https://graph.microsoft.com/v1.0/sites/contoso.sharepoint.com:/sites/HumanResources`. The ID is the first GUID listed in the ID field.

## Response

If successful, this method returns a `201 Created` response code and a [noncustodialDataSource](../resources/ediscovery-noncustodialdatasource.md) object in the response body.

## Examples

### Example 1: Add a non-custodial data source user or group mailbox with an email

#### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_noncustodialdatasource_from_email"
}
-->

``` http
POST https://graph.microsoft.com/beta/compliance/ediscovery/cases/5b840b94-f821-4c4a-8cad-3a90062bf51a/noncustodialDataSources
Content-Type: application/json

{
    "applyHoldToSource" : true,
    "dataSource" : {
        "@odata.type" : "microsoft.graph.ediscovery.userSource",
        "email" : "adelev@contoso.com"
    }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var noncustodialDataSource = new Microsoft.Graph.Ediscovery.NoncustodialDataSource
{
	ApplyHoldToSource = true,
	DataSource = new UserSource
	{
		Email = "adelev@contoso.com"
	}
};

await graphClient.Compliance.Ediscovery.Cases["{ediscovery.case-id}"].NoncustodialDataSources
	.Request()
	.AddAsync(noncustodialDataSource);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.ediscovery.noncustodialDataSource"
}
-->

``` http
HTTP/1.1 201 Created
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#compliance/ediscovery/cases('5b840b94-f821-4c4a-8cad-3a90062bf51a')/noncustodialDataSources/$entity",
    "status": "0",
    "lastModifiedDateTime": "2021-02-19T07:02:45.7732516Z",
    "releasedDateTime": "0001-01-01T00:00:00Z",
    "id": "39374346363831303741353341373443",
    "displayName": null,
    "createdDateTime": "2021-02-19T07:02:45.4863718Z",
    "applyHoldToSource": true
}
```

### Example 2: Add a non-custodial data source site with a URL

#### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_noncustodialdatasource_from_siteurl"
}
-->

``` http
POST https://graph.microsoft.com/beta/compliance/ediscovery/cases/15d80234-8320-4f10-96d0-d98d53ffdfc9/noncustodialdatasources
Content-Type: application/json

{
    "applyHoldToSource": false,
    "dataSource": {
        "@odata.type": "microsoft.graph.ediscovery.siteSource",
        "site": {
            "webUrl": "https://contoso.sharepoint.com/sites/SecretSite"
        }
    }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var noncustodialDataSource = new Microsoft.Graph.Ediscovery.NoncustodialDataSource
{
	ApplyHoldToSource = false,
	DataSource = new SiteSource
	{
		Site = new Site
		{
			WebUrl = "https://contoso.sharepoint.com/sites/SecretSite"
		}
	}
};

await graphClient.Compliance.Ediscovery.Cases["{ediscovery.case-id}"].NoncustodialDataSources
	.Request()
	.AddAsync(noncustodialDataSource);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.ediscovery.noncustodialDataSource"
}
-->

``` http
HTTP/1.1 201 Created
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#compliance/ediscovery/cases('15d80234-8320-4f10-96d0-d98d53ffdfc9')/noncustodialDataSources/$entity",
    "status": "Active",
    "lastModifiedDateTime": "2021-08-11T22:43:45.1079425Z",
    "releasedDateTime": "0001-01-01T00:00:00Z",
    "id": "35393843394546413031353146334134",
    "displayName": "Secret Site",
    "createdDateTime": "2021-08-11T22:43:45.0189955Z",
    "applyHoldToSource": false
}
```
