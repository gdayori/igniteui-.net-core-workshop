# Add required resources for exporting Excel

To use the exporting-Excel functions, you need to add some resources regarding the Excel framework in Ignite UI as below.

Views\\Shared\\_Layout.cshtml. 

```html
...

    <script src="https://cdn-na.infragistics.com/igniteui/2019.1/latest/js/infragistics.core.js"></script>
    <script src="https://cdn-na.infragistics.com/igniteui/2019.1/latest/js/infragistics.lob.js"></script>
    <!-- ↓↓↓ Added ↓↓↓ -->
    <script src="https://jp.igniteui.com/js/external/FileSaver.js"></script>
    <script src="https://jp.igniteui.com/js/external/Blob.js"></script>
    <script src="https://cdn-na.infragistics.com/igniteui/2019.1/latest/js/infragistics.excel-bundled.js"></script>
    <script src="https://cdn-na.infragistics.com/igniteui/2019.1/latest/js/modules/infragistics.gridexcelexporter.js"></script>
    <!-- ↑↑↑ Added ↑↑↑ -->
</head>
...
```

## Note
FileSaver.js and Blob.js are OSS libraries which are not included in Ignite UI. You use that libraries to save Excel files created by Infragistics Excel Engine on the client(browser).

## Next
[03-02 Use Pivot Controls](03-02-Use-Pivot-Controls.md)
