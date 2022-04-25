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
    public partial interface ILayout : IView
    {
        PropertyValue<bool>? IsClippedToBounds { get; set; }
        PropertyValue<Microsoft.Maui.Thickness>? Padding { get; set; }
        PropertyValue<bool>? CascadeInputTransparent { get; set; }


    }

    public abstract partial class Layout<T> : View<T>, ILayout where T : Microsoft.Maui.Controls.Layout, new()
    {
        protected Layout()
        {

        }

        protected Layout(Action<T?> componentRefAction)
            : base(componentRefAction)
        {

        }

        PropertyValue<bool>? ILayout.IsClippedToBounds { get; set; }
        PropertyValue<Microsoft.Maui.Thickness>? ILayout.Padding { get; set; }
        PropertyValue<bool>? ILayout.CascadeInputTransparent { get; set; }


        protected override void OnUpdate()
        {
            OnBeginUpdate();

            Validate.EnsureNotNull(NativeControl);
            var thisAsILayout = (ILayout)this;
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Layout.IsClippedToBoundsProperty, thisAsILayout.IsClippedToBounds);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Layout.PaddingProperty, thisAsILayout.Padding);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Layout.CascadeInputTransparentProperty, thisAsILayout.CascadeInputTransparent);


            base.OnUpdate();

            OnEndUpdate();
        }

        protected override void OnAnimate()
        {
            Validate.EnsureNotNull(NativeControl);
            var thisAsILayout = (ILayout)this;

            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Layout.PaddingProperty, thisAsILayout.Padding);

            base.OnAnimate();
        }

        partial void OnBeginUpdate();
        partial void OnEndUpdate();


    }


    public static partial class LayoutExtensions
    {
        public static T IsClippedToBounds<T>(this T layout, bool isClippedToBounds) where T : ILayout
        {
            layout.IsClippedToBounds = new PropertyValue<bool>(isClippedToBounds);
            return layout;
        }

        public static T IsClippedToBounds<T>(this T layout, Func<bool> isClippedToBoundsFunc) where T : ILayout
        {
            layout.IsClippedToBounds = new PropertyValue<bool>(isClippedToBoundsFunc);
            return layout;
        }



        public static T Padding<T>(this T layout, Microsoft.Maui.Thickness padding, RxThicknessAnimation? customAnimation = null) where T : ILayout
        {
            layout.Padding = new PropertyValue<Microsoft.Maui.Thickness>(padding);
            layout.AppendAnimatable(Microsoft.Maui.Controls.Layout.PaddingProperty, customAnimation ?? new RxSimpleThicknessAnimation(padding), v => layout.Padding = new PropertyValue<Microsoft.Maui.Thickness>(v.CurrentValue()));
            return layout;
        }

        public static T Padding<T>(this T layout, Func<Microsoft.Maui.Thickness> paddingFunc) where T : ILayout
        {
            layout.Padding = new PropertyValue<Microsoft.Maui.Thickness>(paddingFunc);
            return layout;
        }
        public static T Padding<T>(this T layout, double leftRight, double topBottom) where T : ILayout
        {
            layout.Padding = new PropertyValue<Microsoft.Maui.Thickness>(new Thickness(leftRight, topBottom));
            return layout;
        }
        public static T Padding<T>(this T layout, double uniformSize) where T : ILayout
        {
            layout.Padding = new PropertyValue<Microsoft.Maui.Thickness>(new Thickness(uniformSize));
            return layout;
        }
        public static T Padding<T>(this T layout, double left, double top, double right, double bottom) where T : ILayout
        {
            layout.Padding = new PropertyValue<Microsoft.Maui.Thickness>(new Thickness(left, top, right, bottom));
            return layout;
        }



        public static T CascadeInputTransparent<T>(this T layout, bool cascadeInputTransparent) where T : ILayout
        {
            layout.CascadeInputTransparent = new PropertyValue<bool>(cascadeInputTransparent);
            return layout;
        }

        public static T CascadeInputTransparent<T>(this T layout, Func<bool> cascadeInputTransparentFunc) where T : ILayout
        {
            layout.CascadeInputTransparent = new PropertyValue<bool>(cascadeInputTransparentFunc);
            return layout;
        }




    }
}
