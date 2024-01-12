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
namespace MauiReactor;
public partial interface IPicker : IView
{
    object? TextColor { get; set; }

    object? CharacterSpacing { get; set; }

    object? Title { get; set; }

    object? TitleColor { get; set; }

    object? SelectedIndex { get; set; }

    object? FontFamily { get; set; }

    object? FontSize { get; set; }

    object? FontAttributes { get; set; }

    object? FontAutoScalingEnabled { get; set; }

    object? HorizontalTextAlignment { get; set; }

    object? VerticalTextAlignment { get; set; }

    Action? SelectedIndexChangedAction { get; set; }

    Action<object?, EventArgs>? SelectedIndexChangedActionWithArgs { get; set; }
}

public partial class Picker<T> : View<T>, IPicker where T : Microsoft.Maui.Controls.Picker, new()
{
    public Picker()
    {
    }

    public Picker(Action<T?> componentRefAction) : base(componentRefAction)
    {
    }

    object? IPicker.TextColor { get; set; }

    object? IPicker.CharacterSpacing { get; set; }

    object? IPicker.Title { get; set; }

    object? IPicker.TitleColor { get; set; }

    object? IPicker.SelectedIndex { get; set; }

    object? IPicker.FontFamily { get; set; }

    object? IPicker.FontSize { get; set; }

    object? IPicker.FontAttributes { get; set; }

    object? IPicker.FontAutoScalingEnabled { get; set; }

    object? IPicker.HorizontalTextAlignment { get; set; }

    object? IPicker.VerticalTextAlignment { get; set; }

    Action? IPicker.SelectedIndexChangedAction { get; set; }

    Action<object?, EventArgs>? IPicker.SelectedIndexChangedActionWithArgs { get; set; }

    internal override void Reset()
    {
        base.Reset();
        var thisAsIPicker = (IPicker)this;
        thisAsIPicker.TextColor = null;
        thisAsIPicker.CharacterSpacing = null;
        thisAsIPicker.Title = null;
        thisAsIPicker.TitleColor = null;
        thisAsIPicker.SelectedIndex = null;
        thisAsIPicker.FontFamily = null;
        thisAsIPicker.FontSize = null;
        thisAsIPicker.FontAttributes = null;
        thisAsIPicker.FontAutoScalingEnabled = null;
        thisAsIPicker.HorizontalTextAlignment = null;
        thisAsIPicker.VerticalTextAlignment = null;
        thisAsIPicker.SelectedIndexChangedAction = null;
        thisAsIPicker.SelectedIndexChangedActionWithArgs = null;
        OnReset();
    }

    partial void OnReset();
    protected override void OnUpdate()
    {
        OnBeginUpdate();
        Validate.EnsureNotNull(NativeControl);
        var thisAsIPicker = (IPicker)this;
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Picker.TextColorProperty, thisAsIPicker.TextColor);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Picker.CharacterSpacingProperty, thisAsIPicker.CharacterSpacing);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Picker.TitleProperty, thisAsIPicker.Title);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Picker.TitleColorProperty, thisAsIPicker.TitleColor);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Picker.SelectedIndexProperty, thisAsIPicker.SelectedIndex);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Picker.FontFamilyProperty, thisAsIPicker.FontFamily);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Picker.FontSizeProperty, thisAsIPicker.FontSize);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Picker.FontAttributesProperty, thisAsIPicker.FontAttributes);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Picker.FontAutoScalingEnabledProperty, thisAsIPicker.FontAutoScalingEnabled);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Picker.HorizontalTextAlignmentProperty, thisAsIPicker.HorizontalTextAlignment);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Picker.VerticalTextAlignmentProperty, thisAsIPicker.VerticalTextAlignment);
        base.OnUpdate();
        OnEndUpdate();
    }

    protected override void OnAnimate()
    {
        OnBeginAnimate();
        var thisAsIPicker = (IPicker)this;
        AnimateProperty(Microsoft.Maui.Controls.Picker.CharacterSpacingProperty, thisAsIPicker.CharacterSpacing);
        AnimateProperty(Microsoft.Maui.Controls.Picker.FontSizeProperty, thisAsIPicker.FontSize);
        base.OnAnimate();
        OnEndAnimate();
    }

    partial void OnBeginUpdate();
    partial void OnEndUpdate();
    partial void OnBeginAnimate();
    partial void OnEndAnimate();
    partial void OnAttachingNativeEvents();
    partial void OnDetachingNativeEvents();
    protected override void OnAttachNativeEvents()
    {
        Validate.EnsureNotNull(NativeControl);
        var thisAsIPicker = (IPicker)this;
        if (thisAsIPicker.SelectedIndexChangedAction != null || thisAsIPicker.SelectedIndexChangedActionWithArgs != null)
        {
            NativeControl.SelectedIndexChanged += NativeControl_SelectedIndexChanged;
        }

        OnAttachingNativeEvents();
        base.OnAttachNativeEvents();
    }

    private void NativeControl_SelectedIndexChanged(object? sender, EventArgs e)
    {
        var thisAsIPicker = (IPicker)this;
        thisAsIPicker.SelectedIndexChangedAction?.Invoke();
        thisAsIPicker.SelectedIndexChangedActionWithArgs?.Invoke(sender, e);
    }

    protected override void OnDetachNativeEvents()
    {
        if (NativeControl != null)
        {
            NativeControl.SelectedIndexChanged -= NativeControl_SelectedIndexChanged;
        }

        OnDetachingNativeEvents();
        base.OnDetachNativeEvents();
    }
}

public partial class Picker : Picker<Microsoft.Maui.Controls.Picker>
{
    public Picker()
    {
    }

    public Picker(Action<Microsoft.Maui.Controls.Picker?> componentRefAction) : base(componentRefAction)
    {
    }
}

public static partial class PickerExtensions
{
    public static T TextColor<T>(this T picker, Microsoft.Maui.Graphics.Color textColor)
        where T : IPicker
    {
        picker.TextColor = textColor;
        return picker;
    }

    public static T TextColor<T>(this T picker, Func<Microsoft.Maui.Graphics.Color> textColorFunc)
        where T : IPicker
    {
        picker.TextColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(textColorFunc);
        return picker;
    }

    public static T CharacterSpacing<T>(this T picker, double characterSpacing, RxDoubleAnimation? customAnimation = null)
        where T : IPicker
    {
        picker.CharacterSpacing = characterSpacing;
        picker.AppendAnimatable(Microsoft.Maui.Controls.Picker.CharacterSpacingProperty, customAnimation ?? new RxDoubleAnimation(characterSpacing), v => picker.CharacterSpacing = ((RxDoubleAnimation)v).CurrentValue());
        return picker;
    }

    public static T CharacterSpacing<T>(this T picker, Func<double> characterSpacingFunc)
        where T : IPicker
    {
        picker.CharacterSpacing = new PropertyValue<double>(characterSpacingFunc);
        return picker;
    }

    public static T Title<T>(this T picker, string title)
        where T : IPicker
    {
        picker.Title = title;
        return picker;
    }

    public static T Title<T>(this T picker, Func<string> titleFunc)
        where T : IPicker
    {
        picker.Title = new PropertyValue<string>(titleFunc);
        return picker;
    }

    public static T TitleColor<T>(this T picker, Microsoft.Maui.Graphics.Color titleColor)
        where T : IPicker
    {
        picker.TitleColor = titleColor;
        return picker;
    }

    public static T TitleColor<T>(this T picker, Func<Microsoft.Maui.Graphics.Color> titleColorFunc)
        where T : IPicker
    {
        picker.TitleColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(titleColorFunc);
        return picker;
    }

    public static T SelectedIndex<T>(this T picker, int selectedIndex)
        where T : IPicker
    {
        picker.SelectedIndex = selectedIndex;
        return picker;
    }

    public static T SelectedIndex<T>(this T picker, Func<int> selectedIndexFunc)
        where T : IPicker
    {
        picker.SelectedIndex = new PropertyValue<int>(selectedIndexFunc);
        return picker;
    }

    public static T FontFamily<T>(this T picker, string fontFamily)
        where T : IPicker
    {
        picker.FontFamily = fontFamily;
        return picker;
    }

    public static T FontFamily<T>(this T picker, Func<string> fontFamilyFunc)
        where T : IPicker
    {
        picker.FontFamily = new PropertyValue<string>(fontFamilyFunc);
        return picker;
    }

    public static T FontSize<T>(this T picker, double fontSize, RxDoubleAnimation? customAnimation = null)
        where T : IPicker
    {
        picker.FontSize = fontSize;
        picker.AppendAnimatable(Microsoft.Maui.Controls.Picker.FontSizeProperty, customAnimation ?? new RxDoubleAnimation(fontSize), v => picker.FontSize = ((RxDoubleAnimation)v).CurrentValue());
        return picker;
    }

    public static T FontSize<T>(this T picker, Func<double> fontSizeFunc)
        where T : IPicker
    {
        picker.FontSize = new PropertyValue<double>(fontSizeFunc);
        return picker;
    }

    public static T FontAttributes<T>(this T picker, Microsoft.Maui.Controls.FontAttributes fontAttributes)
        where T : IPicker
    {
        picker.FontAttributes = fontAttributes;
        return picker;
    }

    public static T FontAttributes<T>(this T picker, Func<Microsoft.Maui.Controls.FontAttributes> fontAttributesFunc)
        where T : IPicker
    {
        picker.FontAttributes = new PropertyValue<Microsoft.Maui.Controls.FontAttributes>(fontAttributesFunc);
        return picker;
    }

    public static T FontAutoScalingEnabled<T>(this T picker, bool fontAutoScalingEnabled)
        where T : IPicker
    {
        picker.FontAutoScalingEnabled = fontAutoScalingEnabled;
        return picker;
    }

    public static T FontAutoScalingEnabled<T>(this T picker, Func<bool> fontAutoScalingEnabledFunc)
        where T : IPicker
    {
        picker.FontAutoScalingEnabled = new PropertyValue<bool>(fontAutoScalingEnabledFunc);
        return picker;
    }

    public static T HorizontalTextAlignment<T>(this T picker, Microsoft.Maui.TextAlignment horizontalTextAlignment)
        where T : IPicker
    {
        picker.HorizontalTextAlignment = horizontalTextAlignment;
        return picker;
    }

    public static T HorizontalTextAlignment<T>(this T picker, Func<Microsoft.Maui.TextAlignment> horizontalTextAlignmentFunc)
        where T : IPicker
    {
        picker.HorizontalTextAlignment = new PropertyValue<Microsoft.Maui.TextAlignment>(horizontalTextAlignmentFunc);
        return picker;
    }

    public static T VerticalTextAlignment<T>(this T picker, Microsoft.Maui.TextAlignment verticalTextAlignment)
        where T : IPicker
    {
        picker.VerticalTextAlignment = verticalTextAlignment;
        return picker;
    }

    public static T VerticalTextAlignment<T>(this T picker, Func<Microsoft.Maui.TextAlignment> verticalTextAlignmentFunc)
        where T : IPicker
    {
        picker.VerticalTextAlignment = new PropertyValue<Microsoft.Maui.TextAlignment>(verticalTextAlignmentFunc);
        return picker;
    }

    public static T OnSelectedIndexChanged<T>(this T picker, Action? selectedIndexChangedAction)
        where T : IPicker
    {
        picker.SelectedIndexChangedAction = selectedIndexChangedAction;
        return picker;
    }

    public static T OnSelectedIndexChanged<T>(this T picker, Action<object?, EventArgs>? selectedIndexChangedActionWithArgs)
        where T : IPicker
    {
        picker.SelectedIndexChangedActionWithArgs = selectedIndexChangedActionWithArgs;
        return picker;
    }
}