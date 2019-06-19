# Apply style to a specific column

Ignite UI controls have a default theme which is defined in infragistics.theme.css. You can change the styles by overriding the default theme.

## Align to the right on salesAmount column

Open wwwroot\\css\\site.css. Put a new class to set text-align to the right.

wwwroot\\css\\site.css

```css
...
/* ↓↓↓ Added ↓↓↓ */
.number-cell {
    text-align: right;
}
/* ↑↑↑ Added ↑↑↑ */
```

In order to apply number-cell class to salesAmount column, you need to set columnCssClass on salesAmount column as below

```js
...
columns: [
    ...
    { headerText: "Sales Amount", key: "salesAmount", dataType: "number", width: "150px", format: "currency", columnCssClass: "number-cell" },
],
...
```

## Check the result

Run the app and check the result. If nothing changed, try clear the browser cache by hitting ctrl + F5.

![](../assets/05-02-01.png)

## Note

igGrid has many styles you can change. You can learn those styles in the default theme from below link. 

[igGrid feature compatibility matrix](https://www.igniteui.com/help/feature-compatibility-matrix(iggrid))

But the shortest path to find which class you should override to change styles is to use the inspector of browser.

![](../assets/05-02-02.png)

## Next
[03-02 Use Pivot Controls](03-02-Use-Pivot-Controls.md)
