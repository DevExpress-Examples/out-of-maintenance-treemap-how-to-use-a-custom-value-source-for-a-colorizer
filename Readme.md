<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/247052331/19.2.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T870712)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to: Use a Custom Value Source for a Colorizer

[Treemap colorizers](https://docs.devexpress.com/WindowsForms/115749/controls-and-libraries/treemap/colorizers) uses item values ([TreeMapItem.Value](https://docs.devexpress.com/WindowsForms/DevExpress.XtraTreeMap.TreeMapItem.Value), [TreeMapFlatDataAdapter.ValueDataMember](https://docs.devexpress.com/WindowsForms/DevExpress.XtraTreeMap.TreeMapFlatDataAdapter.ValueDataMember), or [HierarchicalDataMapping.ValueDataMember](https://docs.devexpress.com/WindowsForms/DevExpress.XtraTreeMap.HierarchicalDataMapping.ValueDataMember)) to determine colors. You can use the [TreeMapColorizerBase.ValueProvider](https://docs.devexpress.com/WindowsForms/DevExpress.XtraTreeMap.TreeMapColorizerBase.ValueProvider) property to specify a custom value source for a colorizer.

This example shows how to make the colorizer determine item colors based on the bound data source's "HPI" row values.
