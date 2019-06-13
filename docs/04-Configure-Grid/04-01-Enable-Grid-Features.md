# Enable Grid features

igGird has many features which are in great demand especilly in making LOB application, for example sorting, filtering and grouping.

## Enable igGrid features

Open Views\\Home\\Index.cshtml. Enable listed features by adding array with feature's names to "features" option as below.

- Sorting
- Filtering
- Selection
- RowSelectors
- Hiding
- Resizing
- ColumnMoving
- GroupBy

Views\\Home\\Index.cshtml

```js
...
        $("#grid").igGrid({
            autoGenerateColumns: false,
            width: "100%",
            height: "600px",
            primaryKey: "orderId",
            dataSource: [],
            rowVirtualization: true,
            virtualizationMode: "continuous",
            columns: [
                { headerText: "Order ID", key: "orderId", dataType: "number", width: "120px" },
                { headerText: "Order Date", key: "orderDate", dataType: "date", width: "160px", format: "yyyy-MM-dd" },
                { headerText: "Company", key: "companyName", dataType: "string", width: "220px" },
                { headerText: "Sales Rep", key: "employeeName", dataType: "string", width: "160px" },
                { headerText: "Country", key: "shipCountry", dataType: "string", width: "140px" },
                { headerText: "Sales Amount", key: "salesAmount", dataType: "number", width: "150px", format: "currency" },
            ],
            // ↓↓↓ Added ↓↓↓
            features: [
                {
                    name: "Sorting",
                },
                {
                    name: "Filtering",
                },
                {
                    name: "Selection",
                },
                {
                    name: "RowSelectors",
                },
                {
                    name: "Hiding",
                },
                {
                    name: "Resizing",
                },
                {
                    name: "ColumnMoving",
                },
                {
                    name: "GroupBy",
                },
            ]
            // ↑↑↑ Added ↑↑↑
        });
...
```

## Note

igGrid has many features other than the ones used here, but some features can't be enabled at the same time. Check the feature compatibility matrix from the below link to see which ones can be enabled togather.

[igGrid feature compatibility matrix](https://www.igniteui.com/help/feature-compatibility-matrix(iggrid))

## Next
[03-02 Use Pivot Controls](03-02-Use-Pivot-Controls.md)
