// <auto-generated />
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

using MauiReactor.Animations;
using MauiReactor.Shapes;
using MauiReactor.Internals;

#nullable enable

namespace MauiReactor.Shapes
{
    public partial interface IPolygon : Shapes.IShape
    {
        PropertyValue<Microsoft.Maui.Controls.PointCollection>? Points { get; set; }
        PropertyValue<Microsoft.Maui.Controls.Shapes.FillRule>? FillRule { get; set; }


    }

    public sealed partial class Polygon : Shapes.Shape<Microsoft.Maui.Controls.Shapes.Polygon>, IPolygon
    {
        public Polygon()
        {

        }

        public Polygon(Action<Microsoft.Maui.Controls.Shapes.Polygon?> componentRefAction)
            : base(componentRefAction)
        {

        }

        PropertyValue<Microsoft.Maui.Controls.PointCollection>? IPolygon.Points { get; set; }
        PropertyValue<Microsoft.Maui.Controls.Shapes.FillRule>? IPolygon.FillRule { get; set; }


        protected override void OnUpdate()
        {
            OnBeginUpdate();

            Validate.EnsureNotNull(NativeControl);
            var thisAsIPolygon = (IPolygon)this;
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shapes.Polygon.PointsProperty, thisAsIPolygon.Points);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shapes.Polygon.FillRuleProperty, thisAsIPolygon.FillRule);


            base.OnUpdate();

            OnEndUpdate();
        }


        partial void OnBeginUpdate();
        partial void OnEndUpdate();


    }


    public static partial class PolygonExtensions
    {
        public static T Points<T>(this T polygon, Microsoft.Maui.Controls.PointCollection points) where T : IPolygon
        {
            polygon.Points = new PropertyValue<Microsoft.Maui.Controls.PointCollection>(points);
            return polygon;
        }

        public static T Points<T>(this T polygon, Func<Microsoft.Maui.Controls.PointCollection> pointsFunc) where T : IPolygon
        {
            polygon.Points = new PropertyValue<Microsoft.Maui.Controls.PointCollection>(pointsFunc);
            return polygon;
        }



        public static T FillRule<T>(this T polygon, Microsoft.Maui.Controls.Shapes.FillRule fillRule) where T : IPolygon
        {
            polygon.FillRule = new PropertyValue<Microsoft.Maui.Controls.Shapes.FillRule>(fillRule);
            return polygon;
        }

        public static T FillRule<T>(this T polygon, Func<Microsoft.Maui.Controls.Shapes.FillRule> fillRuleFunc) where T : IPolygon
        {
            polygon.FillRule = new PropertyValue<Microsoft.Maui.Controls.Shapes.FillRule>(fillRuleFunc);
            return polygon;
        }




    }
}