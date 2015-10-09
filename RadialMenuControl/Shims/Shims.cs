﻿using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using RadialMenuControl.Components;
namespace RadialMenuControl.Shims
{
    public class CenterButtonShim
    {
        public Brush BorderBrush { get; set; }
        public Brush Background { get; set; }
        public object Content { get; set; }
        public double FontSize { get; set; }
        public double? Top { get; set; }
        public double? Left { get; set; }
    }

    public class Helpers
    {
        public static CenterButtonShim ButtonToShim(CenterButton input)
        {
            return new CenterButtonShim
            {
                BorderBrush = input.BorderBrush,
                Background = input.Background,
                Content = input.Content,
                FontSize = input.FontSize,
                Top = input.Top,
                Left = input.Left
            };
        }
    }
}