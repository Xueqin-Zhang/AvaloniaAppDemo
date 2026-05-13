using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Mixins;
using Avalonia.Controls.Primitives;

namespace AvaloniaAppDemo.Controls;

public class XTag : TemplatedControl
{
    public static readonly StyledProperty<string> ContentProperty = AvaloniaProperty.Register<XTag, string>(
        nameof(ContentProperty));

    public string Content
    {
        get => GetValue(ContentProperty);
        set => SetValue(ContentProperty, value);
    }
}