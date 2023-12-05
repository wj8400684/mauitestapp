using Microsoft.Maui.Controls.Shapes;

namespace mauitestapp.Extensions;

public static class PathIconExtensions
{
    private static readonly PathGeometryConverter GeometryConverter = new();

    public static readonly BindableProperty IconProperty =
        BindableProperty.CreateAttached("Icon", typeof(Geometry), typeof(PathIconExtensions), default(Geometry));

    public static Geometry GetIcon(BindableObject view)
    {
        return (Geometry)view.GetValue(IconProperty);
    }

    public static void SetIcon(BindableObject view, Geometry value)
    {
        view.SetValue(IconProperty, value);
    }
}