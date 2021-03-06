//*********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the Microsoft Public License.
// THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
// IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
// PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
//
//*********************************************************

using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using OrientationCS;

namespace SDKTemplate
{
    public partial class MainPage : Page
    {
        public const string FEATURE_NAME = "Orientation Sensor";

        List<Scenario> scenarios = new List<Scenario>
        {
            new Scenario() { Title = "Data Events", ClassType = typeof(OrientationCS.Scenario1_DataEvents) },
            new Scenario() { Title = "Polling", ClassType = typeof(OrientationCS.Scenario2_Polling) },
            new Scenario() { Title = "Calibration", ClassType = typeof(OrientationCS.Scenario3_Calibration) }
        };
    }

    public class Scenario
    {
        public string Title { get; set; }
        public Type ClassType { get; set; }
    }
}
