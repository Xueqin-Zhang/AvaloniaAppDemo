using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;

namespace AvaloniaAppDemo;

public class IconButton : Button
{
    public static readonly StyledProperty<string> IconProperty = AvaloniaProperty.Register<IconButton, string>(nameof(IconProperty));

    public string Icon
    {
        get => this.GetValue(IconProperty);
        set => SetValue(IconProperty, value);
    }
}