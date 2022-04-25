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
    public partial interface ITabbedPage : IGenericMultiPage
    {
        PropertyValue<Microsoft.Maui.Graphics.Color>? BarBackgroundColor { get; set; }
        PropertyValue<Microsoft.Maui.Controls.Brush>? BarBackground { get; set; }
        PropertyValue<Microsoft.Maui.Graphics.Color>? BarTextColor { get; set; }
        PropertyValue<Microsoft.Maui.Graphics.Color>? UnselectedTabColor { get; set; }
        PropertyValue<Microsoft.Maui.Graphics.Color>? SelectedTabColor { get; set; }


    }

    public abstract partial class TabbedPage<T> : MultiPage<T, Microsoft.Maui.Controls.Page>, ITabbedPage where T : Microsoft.Maui.Controls.TabbedPage, new()
    {
        public TabbedPage()
        {

        }

        public TabbedPage(Action<T?> componentRefAction)
            : base(componentRefAction)
        {

        }

        PropertyValue<Microsoft.Maui.Graphics.Color>? ITabbedPage.BarBackgroundColor { get; set; }
        PropertyValue<Microsoft.Maui.Controls.Brush>? ITabbedPage.BarBackground { get; set; }
        PropertyValue<Microsoft.Maui.Graphics.Color>? ITabbedPage.BarTextColor { get; set; }
        PropertyValue<Microsoft.Maui.Graphics.Color>? ITabbedPage.UnselectedTabColor { get; set; }
        PropertyValue<Microsoft.Maui.Graphics.Color>? ITabbedPage.SelectedTabColor { get; set; }


        protected override void OnUpdate()
        {
            OnBeginUpdate();

            Validate.EnsureNotNull(NativeControl);
            var thisAsITabbedPage = (ITabbedPage)this;
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.TabbedPage.BarBackgroundColorProperty, thisAsITabbedPage.BarBackgroundColor);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.TabbedPage.BarBackgroundProperty, thisAsITabbedPage.BarBackground);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.TabbedPage.BarTextColorProperty, thisAsITabbedPage.BarTextColor);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.TabbedPage.UnselectedTabColorProperty, thisAsITabbedPage.UnselectedTabColor);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.TabbedPage.SelectedTabColorProperty, thisAsITabbedPage.SelectedTabColor);


            base.OnUpdate();

            OnEndUpdate();
        }


        partial void OnBeginUpdate();
        partial void OnEndUpdate();


    }

    public partial class TabbedPage : TabbedPage<Microsoft.Maui.Controls.TabbedPage>
    {
        public TabbedPage()
        {

        }

        public TabbedPage(Action<Microsoft.Maui.Controls.TabbedPage?> componentRefAction)
            : base(componentRefAction)
        {

        }
    }

    public static partial class TabbedPageExtensions
    {
        public static T BarBackgroundColor<T>(this T tabbedPage, Microsoft.Maui.Graphics.Color barBackgroundColor) where T : ITabbedPage
        {
            tabbedPage.BarBackgroundColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(barBackgroundColor);
            return tabbedPage;
        }

        public static T BarBackgroundColor<T>(this T tabbedPage, Func<Microsoft.Maui.Graphics.Color> barBackgroundColorFunc) where T : ITabbedPage
        {
            tabbedPage.BarBackgroundColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(barBackgroundColorFunc);
            return tabbedPage;
        }



        public static T BarBackground<T>(this T tabbedPage, Microsoft.Maui.Controls.Brush barBackground) where T : ITabbedPage
        {
            tabbedPage.BarBackground = new PropertyValue<Microsoft.Maui.Controls.Brush>(barBackground);
            return tabbedPage;
        }

        public static T BarBackground<T>(this T tabbedPage, Func<Microsoft.Maui.Controls.Brush> barBackgroundFunc) where T : ITabbedPage
        {
            tabbedPage.BarBackground = new PropertyValue<Microsoft.Maui.Controls.Brush>(barBackgroundFunc);
            return tabbedPage;
        }



        public static T BarTextColor<T>(this T tabbedPage, Microsoft.Maui.Graphics.Color barTextColor) where T : ITabbedPage
        {
            tabbedPage.BarTextColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(barTextColor);
            return tabbedPage;
        }

        public static T BarTextColor<T>(this T tabbedPage, Func<Microsoft.Maui.Graphics.Color> barTextColorFunc) where T : ITabbedPage
        {
            tabbedPage.BarTextColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(barTextColorFunc);
            return tabbedPage;
        }



        public static T UnselectedTabColor<T>(this T tabbedPage, Microsoft.Maui.Graphics.Color unselectedTabColor) where T : ITabbedPage
        {
            tabbedPage.UnselectedTabColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(unselectedTabColor);
            return tabbedPage;
        }

        public static T UnselectedTabColor<T>(this T tabbedPage, Func<Microsoft.Maui.Graphics.Color> unselectedTabColorFunc) where T : ITabbedPage
        {
            tabbedPage.UnselectedTabColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(unselectedTabColorFunc);
            return tabbedPage;
        }



        public static T SelectedTabColor<T>(this T tabbedPage, Microsoft.Maui.Graphics.Color selectedTabColor) where T : ITabbedPage
        {
            tabbedPage.SelectedTabColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(selectedTabColor);
            return tabbedPage;
        }

        public static T SelectedTabColor<T>(this T tabbedPage, Func<Microsoft.Maui.Graphics.Color> selectedTabColorFunc) where T : ITabbedPage
        {
            tabbedPage.SelectedTabColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(selectedTabColorFunc);
            return tabbedPage;
        }




    }
}
