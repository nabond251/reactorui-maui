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
    public partial interface IBaseMenuItem : IElement
    {


    }

    public abstract partial class BaseMenuItem<T> : Element<T>, IBaseMenuItem where T : Microsoft.Maui.Controls.BaseMenuItem, new()
    {
        protected BaseMenuItem()
        {

        }

        protected BaseMenuItem(Action<T?> componentRefAction)
            : base(componentRefAction)
        {

        }



        protected override void OnUpdate()
        {
            OnBeginUpdate();

            base.OnUpdate();

            OnEndUpdate();
        }


        partial void OnBeginUpdate();
        partial void OnEndUpdate();


    }


    public static partial class BaseMenuItemExtensions
    {

    }
}
