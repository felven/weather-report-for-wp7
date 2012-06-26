﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Weather
{
	public partial class CityTile : UserControl
	{
		public CityTile()
		{
			// 为初始化变量所必需
			InitializeComponent();
		}

	}
    public class CityTileData 
    {
        public string cityTemperature { get; set; }
        public string cityWeatherIcon { get; set; }
    }
}