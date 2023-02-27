---
title: Update printConnector
description: Update the properties of a printConnector object.
author: braedenp-msft
ms.localizationpriority: medium
ms.prod: cloud-printing
doc_type: apiPageType
---

# Update printConnector

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the properties of a **printConnector** object.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

To use the Universal Print service, the user or app's tenant must have an active Universal Print subscription, in addition to the permissions listed in the following table. The signed in user must be a [Printer Administrator](/azure/active-directory/users-groups-roles/directory-assign-admin-roles#printer-administrator).

|Permission type | Permissions (from least to most privileged) |
|:---------------|:--------------------------------------------|
|Delegated (work or school account)| PrintConnector.ReadWrite.All |
|Delegated (personal Microsoft account)|Not Supported.|
|Application|Not Supported.|

## HTTP request
<!-- { "blockType": "ignored" } -->
```http
PATCH /print/connectors/{id}
```
## Request headers
| Name       | Description|
|:-----------|:-----------|
| Authorization | Bearer {token}. Required. |
| Content-type  | application/json. Required.|

## Request body
In the request body, supply the values for relevant fields that should be updated. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values. For best performance, don't include existing values that haven't changed.

| Property     | Type        | Description |
|:-------------|:------------|:------------|
|name|String|The name of the connector.|
|fullyQualifiedDomainName|String|The connector machine's hostname.|
|operatingSystem|String|The connector machine's operating system version.|
|appVersion|String|The connector's version.|
|location|[printerLocation](../resources/printerlocation.md)|The physical and/or organizational location of the connector.|

## Response
If successful, this method returns a `200 OK` response code and an updated [printConnector](../resources/printConnector.md) object in the response body.
## Example
##### Request
The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_connector"
}-->
```http
PATCH https://graph.microsoft.com/beta/print/connectors/{id}
Content-type: application/json

{
  "displayName": "ConnectorName",
  "fullyQualifiedDomainName": "CONNECTOR-MACHINE",
  "operatingSystem": "Microsoft Windows 10 Enterprise Insider Preview | 10.0.19555",
  "appVersion": "0.19.7338.23496",
  "location": {
    "latitude": 1.1,
    "longitude": 2.2,
    "altitudeInMeters": 3
  }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var printConnector = new PrintConnector
{
	DisplayName = "ConnectorName",
	FullyQualifiedDomainName = "CONNECTOR-MACHINE",
	OperatingSystem = "Microsoft Windows 10 Enterprise Insider Preview | 10.0.19555",
	AppVersion = "0.19.7338.23496",
	Location = new PrinterLocation
	{
		Latitude = 1.1,
		Longitude = 2.2,
		AltitudeInMeters = 3
	}
};

await graphClient.Print.Connectors["{printConnector-id}"]
	.Request()
	.UpdateAsync(printConnector);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

