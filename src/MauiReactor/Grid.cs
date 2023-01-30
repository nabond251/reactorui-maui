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
namespace MauiReactor
{
    public partial interface IGrid : ILayout
    {
        PropertyValue<double>? RowSpacing { get; set; }

        PropertyValue<double>? ColumnSpacing { get; set; }
    }

    public partial class Grid<T> : Layout<T>, IGrid where T : Microsoft.Maui.Controls.Grid, new()
    {
        public Grid()
        {
        }

        public Grid(Action<T?> componentRefAction) : base(componentRefAction)
        {
        }

        PropertyValue<double>? IGrid.RowSpacing { get; set; }

        PropertyValue<double>? IGrid.ColumnSpacing { get; set; }

        protected override void OnUpdate()
        {
            OnBeginUpdate();
            Validate.EnsureNotNull(NativeControl);
            var thisAsIGrid = (IGrid)this;
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Grid.RowSpacingProperty, thisAsIGrid.RowSpacing);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Grid.ColumnSpacingProperty, thisAsIGrid.ColumnSpacing);
            base.OnUpdate();
            OnEndUpdate();
        }

        protected override void OnAnimate()
        {
            Validate.EnsureNotNull(NativeControl);
            var thisAsIGrid = (IGrid)this;
            AnimateProperty(Microsoft.Maui.Controls.Grid.RowSpacingProperty, thisAsIGrid.RowSpacing);
            AnimateProperty(Microsoft.Maui.Controls.Grid.ColumnSpacingProperty, thisAsIGrid.ColumnSpacing);
            base.OnAnimate();
        }

        partial void OnBeginUpdate();
        partial void OnEndUpdate();
    }

    public partial class Grid : Grid<Microsoft.Maui.Controls.Grid>
    {
        public Grid()
        {
        }

        public Grid(Action<Microsoft.Maui.Controls.Grid?> componentRefAction) : base(componentRefAction)
        {
        }
    }

    public static partial class GridExtensions
    {
        public static T RowSpacing<T>(this T grid, double rowSpacing, RxDoubleAnimation? customAnimation = null)
            where T : IGrid
        {
            grid.RowSpacing = new PropertyValue<double>(rowSpacing);
            grid.AppendAnimatable(Microsoft.Maui.Controls.Grid.RowSpacingProperty, customAnimation ?? new RxDoubleAnimation(rowSpacing), v => grid.RowSpacing = new PropertyValue<double>(v.CurrentValue()));
            return grid;
        }

        public static T RowSpacing<T>(this T grid, Func<double> rowSpacingFunc)
            where T : IGrid
        {
            grid.RowSpacing = new PropertyValue<double>(rowSpacingFunc);
            return grid;
        }

        public static T ColumnSpacing<T>(this T grid, double columnSpacing, RxDoubleAnimation? customAnimation = null)
            where T : IGrid
        {
            grid.ColumnSpacing = new PropertyValue<double>(columnSpacing);
            grid.AppendAnimatable(Microsoft.Maui.Controls.Grid.ColumnSpacingProperty, customAnimation ?? new RxDoubleAnimation(columnSpacing), v => grid.ColumnSpacing = new PropertyValue<double>(v.CurrentValue()));
            return grid;
        }

        public static T ColumnSpacing<T>(this T grid, Func<double> columnSpacingFunc)
            where T : IGrid
        {
            grid.ColumnSpacing = new PropertyValue<double>(columnSpacingFunc);
            return grid;
        }
    }
}