# Get started with Ignite UI

In order to use Ignite UI controls in you app, you need to load Ignite UI resources as well as jQuery. 

## Add resources

Open Views\\Shared\\_Layout.cshtml. jQuery files are already loaded by default so you need to add js and css resources for Ignite UI in the head section as below.

```html
...
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>NorthwindView</title>

    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" rel="stylesheet">
    <link rel="stylesheet" href="~/css/site.css" />
    <!-- ↓↓↓ Added ↓↓↓ -->
    <link href="https://cdn-na.infragistics.com/igniteui/2019.1/latest/css/themes/infragistics/infragistics.theme.css" rel="stylesheet" />
    <link href="https://cdn-na.infragistics.com/igniteui/2019.1/latest/css/structure/infragistics.css" rel="stylesheet" />
    <!-- ↑↑↑ Added ↑↑↑ -->
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
    <script src="https://ajax.aspnetcdn.com/ajax/modernizr/modernizr-2.8.3.js"></script>
    <script src="https://code.jquery.com/jquery-3.3.1.min.js"></script>
    <script src="https://code.jquery.com/ui/1.12.0/jquery-ui.min.js"></script>
    <!-- ↓↓↓ Added ↓↓↓ -->
    <script src="https://cdn-na.infragistics.com/igniteui/2019.1/latest/js/infragistics.core.js"></script>
    <script src="https://cdn-na.infragistics.com/igniteui/2019.1/latest/js/infragistics.lob.js"></script>
    <!-- ↑↑↑ Added ↑↑↑ -->
</head>
...
```

## Note

In this workshop you loaded a bundle resource named lob.js. It's easy to load with a single line of code, but it's not a light file because it contains resources for all LOB controls like grid, editors and etc.

If you really care the loaded file size you can load minimum files requred to the controls you use in the application. You can learn more about the Ignite UI resources from below links.

[JavaScript Files in Ignite UI](https://www.igniteui.com/help/deployment-guide-javascript-files)

[Adding Required Resources Manually](https://www.igniteui.com/help/adding-the-required-resources-for-netadvantage-for-jquery)

[Adding Required Resources Automatically with the Infragistics Loader](https://www.igniteui.com/help/using-infragistics-loader)

## Next
[03-02 Use DatePicker](03-02-Use-DatePicker.md)
