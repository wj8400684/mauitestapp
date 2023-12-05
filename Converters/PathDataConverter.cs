using System.Globalization;
using Microsoft.Maui.Controls.Shapes;

namespace mauitestapp.Converters;

internal sealed class PathDataConverter : IValueConverter
{
    private static readonly  PathGeometryConverter GeometryConverter = new();

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is null)
            return null;
        
        return (Geometry)GeometryConverter.ConvertFromInvariantString((string)value);
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}