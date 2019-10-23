/*
    Copyright 2019 Dennis Geller

    This file is part of FancyWaitIndicators.

    FancyWaitIndicators is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    FancyWaitIndicators is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with FancyWaitIndicators.  If not, see <https://www.gnu.org/licenses/>. */

using System.Windows;
using System.Windows.Controls;

namespace FancyWaitIndicators
{
    /// <summary>
    /// Логика взаимодействия для CircleWaitIndicator.xaml
    /// </summary>
    public partial class CircleWaitIndicator : UserControl
    {
        public CircleWaitIndicator()
        {
            InitializeComponent();
        }
        //------------------------------------------------------------------------------------------------------------------------------------
        public bool IsRunning
        {
            get { return (bool)GetValue(IsRunningProperty); }
            set { SetValue(IsRunningProperty, value); }
        }
        public static readonly DependencyProperty IsRunningProperty = DependencyProperty.Register("IsRunning", typeof(bool), typeof(CircleWaitIndicator), new PropertyMetadata(false));
        //------------------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------------------
    }
}
