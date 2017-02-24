# JsonTextView
A simple Xamarin.Forms element for displaying Json as a user-friendly label. 

## Features
- Splits camel cased naming into spaced readable words
- Allows for turning camel cased names to be upper-cased

## Missing Features
- Parse and render nested objects
- Allow for text color changes and style changes
- Allow for other configuration options

![JsonTextView](https://alexdunndev.files.wordpress.com/2017/02/xamagonjson.png?w=609&h=510&crop=1)

## Usage


**XAML**
```
<ContentPage
  ...
  xmlns:sp="clr-namespace:SPControls;assembly=SPControls"
  ...>
    <Grid>
      <sp:JsonTextView Json="{Binding JsonString}" />
    </Grid>
</ContentPage>
```
**or in C#**
```
...

var jsonTextView = new SPControls.JsonTextView();
jsonTextView.Json = jsonString;
...
```
