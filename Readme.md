# How to: Use a Custom Value Source for a Colorizer

[Treemap colorizers](https://docs.devexpress.com/WindowsForms/115749/controls-and-libraries/treemap/colorizers) uses item values ([TreeMapItem.Value](https://docs.devexpress.com/WindowsForms/DevExpress.XtraTreeMap.TreeMapItem.Value), [TreeMapFlatDataAdapter.ValueDataMember](https://docs.devexpress.com/WindowsForms/DevExpress.XtraTreeMap.TreeMapFlatDataAdapter.ValueDataMember), or [HierarchicalDataMapping.ValueDataMember](https://docs.devexpress.com/WindowsForms/DevExpress.XtraTreeMap.HierarchicalDataMapping.ValueDataMember)) to determine colors. You can use the [TreeMapColorizerBase.ValueProvider](https://docs.devexpress.com/WindowsForms/DevExpress.XtraTreeMap.TreeMapColorizerBase.ValueProvider) property to specify a custom value source for a colorizer.

This example shows how to make the colorizer determine item colors based on the bound data source's "HPI" row values.