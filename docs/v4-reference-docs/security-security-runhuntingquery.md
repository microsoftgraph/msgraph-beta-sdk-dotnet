---
title: "security: runHuntingQuery"
description: "Run Hunting query API"
author: "BenAlfasi"
ms.localizationpriority: medium
ms.prod: "security"
doc_type: apiPageType
---

# security: runHuntingQuery
Namespace: microsoft.graph.security

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Queries a specified set of event, activity, or entity data supported by Microsoft 365 Defender to proactively look for specific threats in your environment.

This is the method for advanced hunting in Microsoft 365 Defender. This method includes a query in Kusto Query Language (KQL). It specifies a data table in the [advanced hunting schema](/microsoft-365/security/defender/advanced-hunting-schema-tables?view=o365-worldwide&preserve-view=true) and a piped sequence of operators to filter or search that data, and format the query output in specific ways. 

Find out more about [hunting for threats across devices, emails, apps, and identities](/microsoft-365/security/defender/advanced-hunting-query-emails-devices?view=o365-worldwide&preserve-view=true). Learn about [KQL](/azure/data-explorer/kusto/query/).

For information on using advanced hunting in the [Microsoft 365 Defender portal](/microsoft-365/security/defender/microsoft-365-defender-portal?view=o365-worldwide&preserve-view=true), see [Proactively hunt for threats with advanced hunting in Microsoft 365 Defender](/microsoft-365/security/defender/advanced-hunting-overview?view=o365-worldwide&preserve-view=true).

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|ThreatHunting.Read.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|ThreatHunting.Read.All|


## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
POST /security/runHuntingQuery
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body

In the request body, provide a JSON object for the parameter, `query`. 

| Parameter	   | Type	|Description|
|:---------------|:--------|:----------|
|query|String|The hunting query in Kusto Query Language (KQL). For more information on KQL syntax, see [KQL quick reference](/azure/data-explorer/kql-quick-reference).|

## Response

If successful, this action returns a `200 OK` response code and a [huntingQueryResults](../resources/security-huntingqueryresults.md) in the response body.

## Examples

### Request

This example specifies a KQL query which does the following:
- Looks into the [DeviceProcessEvents](/microsoft-365/security/defender/advanced-hunting-deviceprocessevents-table?view=o365-worldwide&preserve-view=true) table in the advanced hunting schema.
- Filters on the condition that the event is initiated by the powershell.exe process.
- Specifies the output of 3 columns from the same table for each row: `Timestamp`, `FileName`, `InitiatingProcessFileName`.
- Sorts the output by the `Timestamp` value.
- Limits the output to 2 records (2 rows).


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "security_runhuntingquery"
}
-->
``` http
POST https://graph.microsoft.com/beta/security/runHuntingQuery

{
    "query": "DeviceProcessEvents | where InitiatingProcessFileName =~ \"powershell.exe\" | project Timestamp, FileName, InitiatingProcessFileName | order by Timestamp desc | limit 2"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var query = "DeviceProcessEvents | where InitiatingProcessFileName =~ \"powershell.exe\" | project Timestamp, FileName, InitiatingProcessFileName | order by Timestamp desc | limit 2";

await graphClient.Security
	.RunHuntingQuery(query)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "@odata.type": "microsoft.graph.security.huntingQueryResults"
}
-->

``` http
HTTP/1.1 200 OK
Content-type: application/json

{
    "schema": [
        {
            "Name": "Timestamp",
            "Type": "DateTime"
        },
        {
            "Name": "FileName",
            "Type": "String"
        },
        {
            "Name": "InitiatingProcessFileName",
            "Type": "String"
        }
    ],
    "results": [
        {
            "Timestamp": "2020-08-30T06:38:35.7664356Z",
            "FileName": "conhost.exe",
            "InitiatingProcessFileName": "powershell.exe"
        },
        {
            "Timestamp": "2020-08-30T06:38:30.5163363Z",
            "FileName": "conhost.exe",
            "InitiatingProcessFileName": "powershell.exe"
        }
    ]
}
```
