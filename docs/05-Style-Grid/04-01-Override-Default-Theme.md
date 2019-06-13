# Override default theme

Ignite UI controls have a default theme which is defined in infragistics.theme.css. You can change the styles by overriding the default theme.

## Change header color

Change the header color on igGrid.

Open wwwroot\\css\\site.css. Override ui-iggrid-header class to change the background to navy as below.

wwwroot\\css\\site.css

```css
...
/* ↓↓↓ Added ↓↓↓ */
.ui-iggrid-header {
    background-color: navy !important;
}
/* ↑↑↑ Added ↑↑↑ */
```

## Note

igGrid has many features other than the ones used here, but some features can't be enabled at the same time. Check the feature compatibility matrix from the below link to see which ones can be enabled togather.

[igGrid feature compatibility matrix](https://www.igniteui.com/help/feature-compatibility-matrix(iggrid))

## Next
[03-02 Use Pivot Controls](03-02-Use-Pivot-Controls.md)
