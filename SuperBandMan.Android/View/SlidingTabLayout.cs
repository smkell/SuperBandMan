using System;
using Android.Content;
using Android.Runtime;
using Android.Util;
using Android.Widget;

namespace SuperBandMan.Android.View
{
    public class SlidingTabLayout : HorizontalScrollView
    {
        protected SlidingTabLayout(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        public SlidingTabLayout(Context context) : this(context, null)
        {
        }

        public SlidingTabLayout(Context context, IAttributeSet attrs) : base(context, attrs)
        {
        }

        public SlidingTabLayout(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
        }

        public SlidingTabLayout(Context context, IAttributeSet attrs, int defStyleAttr, int defStyleRes) : base(context, attrs, defStyleAttr, defStyleRes)
        {
        }
    }
}