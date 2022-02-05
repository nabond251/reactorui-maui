using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

using MauiReactor.Animations;
//using MauiReactor.Shapes;
using MauiReactor.Internals;

namespace MauiReactor
{
    public partial interface IDatePicker : IView
    {
        PropertyValue<string>? Format { get; set; }
        PropertyValue<System.DateTime>? Date { get; set; }
        PropertyValue<System.DateTime>? MinimumDate { get; set; }
        PropertyValue<System.DateTime>? MaximumDate { get; set; }
        PropertyValue<Microsoft.Maui.Graphics.Color>? TextColor { get; set; }
        PropertyValue<double>? CharacterSpacing { get; set; }
        PropertyValue<string>? FontFamily { get; set; }
        PropertyValue<double>? FontSize { get; set; }
        PropertyValue<Microsoft.Maui.Controls.FontAttributes>? FontAttributes { get; set; }
        PropertyValue<bool>? FontAutoScalingEnabled { get; set; }
        PropertyValue<Microsoft.Maui.TextTransform>? TextTransform { get; set; }

        Action? DateSelectedAction { get; set; }
        Action<object?, DateChangedEventArgs>? DateSelectedActionWithArgs { get; set; }

    }
    public partial class DatePicker<T> : View<T>, IDatePicker where T : Microsoft.Maui.Controls.DatePicker, new()
    {
        public DatePicker()
        {

        }

        public DatePicker(Action<T?> componentRefAction)
            : base(componentRefAction)
        {

        }

        PropertyValue<string>? IDatePicker.Format { get; set; }
        PropertyValue<System.DateTime>? IDatePicker.Date { get; set; }
        PropertyValue<System.DateTime>? IDatePicker.MinimumDate { get; set; }
        PropertyValue<System.DateTime>? IDatePicker.MaximumDate { get; set; }
        PropertyValue<Microsoft.Maui.Graphics.Color>? IDatePicker.TextColor { get; set; }
        PropertyValue<double>? IDatePicker.CharacterSpacing { get; set; }
        PropertyValue<string>? IDatePicker.FontFamily { get; set; }
        PropertyValue<double>? IDatePicker.FontSize { get; set; }
        PropertyValue<Microsoft.Maui.Controls.FontAttributes>? IDatePicker.FontAttributes { get; set; }
        PropertyValue<bool>? IDatePicker.FontAutoScalingEnabled { get; set; }
        PropertyValue<Microsoft.Maui.TextTransform>? IDatePicker.TextTransform { get; set; }

        Action? IDatePicker.DateSelectedAction { get; set; }
        Action<object?, DateChangedEventArgs>? IDatePicker.DateSelectedActionWithArgs { get; set; }

        protected override void OnUpdate()
        {
            OnBeginUpdate();

            Validate.EnsureNotNull(NativeControl);
            var thisAsIDatePicker = (IDatePicker)this;
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.DatePicker.FormatProperty, thisAsIDatePicker.Format);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.DatePicker.DateProperty, thisAsIDatePicker.Date);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.DatePicker.MinimumDateProperty, thisAsIDatePicker.MinimumDate);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.DatePicker.MaximumDateProperty, thisAsIDatePicker.MaximumDate);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.DatePicker.TextColorProperty, thisAsIDatePicker.TextColor);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.DatePicker.CharacterSpacingProperty, thisAsIDatePicker.CharacterSpacing);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.DatePicker.FontFamilyProperty, thisAsIDatePicker.FontFamily);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.DatePicker.FontSizeProperty, thisAsIDatePicker.FontSize);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.DatePicker.FontAttributesProperty, thisAsIDatePicker.FontAttributes);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.DatePicker.FontAutoScalingEnabledProperty, thisAsIDatePicker.FontAutoScalingEnabled);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.DatePicker.TextTransformProperty, thisAsIDatePicker.TextTransform);


            base.OnUpdate();

            OnEndUpdate();
        }

        protected override void OnAnimate()
        {
            Validate.EnsureNotNull(NativeControl);
            var thisAsIDatePicker = (IDatePicker)this;

            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.DatePicker.CharacterSpacingProperty, thisAsIDatePicker.CharacterSpacing);
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.DatePicker.FontSizeProperty, thisAsIDatePicker.FontSize);

            base.OnAnimate();
        }

        partial void OnBeginUpdate();
        partial void OnEndUpdate();

        protected override void OnAttachNativeEvents()
        {
            Validate.EnsureNotNull(NativeControl);

            var thisAsIDatePicker = (IDatePicker)this;
            if (thisAsIDatePicker.DateSelectedAction != null || thisAsIDatePicker.DateSelectedActionWithArgs != null)
            {
                NativeControl.DateSelected += NativeControl_DateSelected;
            }

            base.OnAttachNativeEvents();
        }

        private void NativeControl_DateSelected(object? sender, DateChangedEventArgs e)
        {
            var thisAsIDatePicker = (IDatePicker)this;
            thisAsIDatePicker.DateSelectedAction?.Invoke();
            thisAsIDatePicker.DateSelectedActionWithArgs?.Invoke(sender, e);
        }

        protected override void OnDetachNativeEvents()
        {
            if (NativeControl != null)
            {
                NativeControl.DateSelected -= NativeControl_DateSelected;
            }

            base.OnDetachNativeEvents();
        }

    }

    public partial class DatePicker : DatePicker<Microsoft.Maui.Controls.DatePicker>
    {
        public DatePicker()
        {

        }

        public DatePicker(Action<Microsoft.Maui.Controls.DatePicker?> componentRefAction)
            : base(componentRefAction)
        {

        }
    }

    public static partial class DatePickerExtensions
    {
        public static T Format<T>(this T datePicker, string format) where T : IDatePicker
        {
            datePicker.Format = new PropertyValue<string>(format);
            return datePicker;
        }

        public static T Format<T>(this T datePicker, Func<string> formatFunc) where T : IDatePicker
        {
            datePicker.Format = new PropertyValue<string>(formatFunc);
            return datePicker;
        }



        public static T Date<T>(this T datePicker, System.DateTime date) where T : IDatePicker
        {
            datePicker.Date = new PropertyValue<System.DateTime>(date);
            return datePicker;
        }

        public static T Date<T>(this T datePicker, Func<System.DateTime> dateFunc) where T : IDatePicker
        {
            datePicker.Date = new PropertyValue<System.DateTime>(dateFunc);
            return datePicker;
        }



        public static T MinimumDate<T>(this T datePicker, System.DateTime minimumDate) where T : IDatePicker
        {
            datePicker.MinimumDate = new PropertyValue<System.DateTime>(minimumDate);
            return datePicker;
        }

        public static T MinimumDate<T>(this T datePicker, Func<System.DateTime> minimumDateFunc) where T : IDatePicker
        {
            datePicker.MinimumDate = new PropertyValue<System.DateTime>(minimumDateFunc);
            return datePicker;
        }



        public static T MaximumDate<T>(this T datePicker, System.DateTime maximumDate) where T : IDatePicker
        {
            datePicker.MaximumDate = new PropertyValue<System.DateTime>(maximumDate);
            return datePicker;
        }

        public static T MaximumDate<T>(this T datePicker, Func<System.DateTime> maximumDateFunc) where T : IDatePicker
        {
            datePicker.MaximumDate = new PropertyValue<System.DateTime>(maximumDateFunc);
            return datePicker;
        }



        public static T TextColor<T>(this T datePicker, Microsoft.Maui.Graphics.Color textColor) where T : IDatePicker
        {
            datePicker.TextColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(textColor);
            return datePicker;
        }

        public static T TextColor<T>(this T datePicker, Func<Microsoft.Maui.Graphics.Color> textColorFunc) where T : IDatePicker
        {
            datePicker.TextColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(textColorFunc);
            return datePicker;
        }



        public static T CharacterSpacing<T>(this T datePicker, double characterSpacing, RxDoubleAnimation? customAnimation = null) where T : IDatePicker
        {
            datePicker.CharacterSpacing = new PropertyValue<double>(characterSpacing);
            datePicker.AppendAnimatable(Microsoft.Maui.Controls.DatePicker.CharacterSpacingProperty, customAnimation ?? new RxDoubleAnimation(characterSpacing), v => datePicker.CharacterSpacing = new PropertyValue<double>(v.CurrentValue()));
            return datePicker;
        }

        public static T CharacterSpacing<T>(this T datePicker, Func<double> characterSpacingFunc) where T : IDatePicker
        {
            datePicker.CharacterSpacing = new PropertyValue<double>(characterSpacingFunc);
            return datePicker;
        }



        public static T FontFamily<T>(this T datePicker, string fontFamily) where T : IDatePicker
        {
            datePicker.FontFamily = new PropertyValue<string>(fontFamily);
            return datePicker;
        }

        public static T FontFamily<T>(this T datePicker, Func<string> fontFamilyFunc) where T : IDatePicker
        {
            datePicker.FontFamily = new PropertyValue<string>(fontFamilyFunc);
            return datePicker;
        }



        public static T FontSize<T>(this T datePicker, double fontSize, RxDoubleAnimation? customAnimation = null) where T : IDatePicker
        {
            datePicker.FontSize = new PropertyValue<double>(fontSize);
            datePicker.AppendAnimatable(Microsoft.Maui.Controls.DatePicker.FontSizeProperty, customAnimation ?? new RxDoubleAnimation(fontSize), v => datePicker.FontSize = new PropertyValue<double>(v.CurrentValue()));
            return datePicker;
        }

        public static T FontSize<T>(this T datePicker, Func<double> fontSizeFunc) where T : IDatePicker
        {
            datePicker.FontSize = new PropertyValue<double>(fontSizeFunc);
            return datePicker;
        }


        public static T FontSize<T>(this T datePicker, NamedSize size) where T : IDatePicker
        {
            datePicker.FontSize = new PropertyValue<double>(Device.GetNamedSize(size, typeof(DatePicker)));
            return datePicker;
        }

        public static T FontAttributes<T>(this T datePicker, Microsoft.Maui.Controls.FontAttributes fontAttributes) where T : IDatePicker
        {
            datePicker.FontAttributes = new PropertyValue<Microsoft.Maui.Controls.FontAttributes>(fontAttributes);
            return datePicker;
        }

        public static T FontAttributes<T>(this T datePicker, Func<Microsoft.Maui.Controls.FontAttributes> fontAttributesFunc) where T : IDatePicker
        {
            datePicker.FontAttributes = new PropertyValue<Microsoft.Maui.Controls.FontAttributes>(fontAttributesFunc);
            return datePicker;
        }



        public static T FontAutoScalingEnabled<T>(this T datePicker, bool fontAutoScalingEnabled) where T : IDatePicker
        {
            datePicker.FontAutoScalingEnabled = new PropertyValue<bool>(fontAutoScalingEnabled);
            return datePicker;
        }

        public static T FontAutoScalingEnabled<T>(this T datePicker, Func<bool> fontAutoScalingEnabledFunc) where T : IDatePicker
        {
            datePicker.FontAutoScalingEnabled = new PropertyValue<bool>(fontAutoScalingEnabledFunc);
            return datePicker;
        }



        public static T TextTransform<T>(this T datePicker, Microsoft.Maui.TextTransform textTransform) where T : IDatePicker
        {
            datePicker.TextTransform = new PropertyValue<Microsoft.Maui.TextTransform>(textTransform);
            return datePicker;
        }

        public static T TextTransform<T>(this T datePicker, Func<Microsoft.Maui.TextTransform> textTransformFunc) where T : IDatePicker
        {
            datePicker.TextTransform = new PropertyValue<Microsoft.Maui.TextTransform>(textTransformFunc);
            return datePicker;
        }




        public static T OnDateSelected<T>(this T datePicker, Action dateSelectedAction) where T : IDatePicker
        {
            datePicker.DateSelectedAction = dateSelectedAction;
            return datePicker;
        }

        public static T OnDateSelected<T>(this T datePicker, Action<object?, DateChangedEventArgs> dateSelectedActionWithArgs) where T : IDatePicker
        {
            datePicker.DateSelectedActionWithArgs = dateSelectedActionWithArgs;
            return datePicker;
        }
    }
}