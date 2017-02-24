# JsonTextView
A simple Xamarin.Forms element for displaying Json as a user-friendly label.

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
