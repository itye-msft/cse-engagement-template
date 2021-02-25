// <copyright file="WeatherForecast.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace SampleNetApi
{
    using System;

    /// <summary>
    /// WeatherForecast.
    /// </summary>
    public class WeatherForecast
    {
        /// <summary>
        /// Gets or sets date.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets.
        /// </summary>
        public int TemperatureC { get; set; }

        /// <summary>
        /// Gets .
        /// </summary>
        public int TemperatureF => 32 + (int)(this.TemperatureC / 0.5556);

        /// <summary>
        /// Gets or sets.
        /// </summary>
        public string Summary { get; set; }
    }
}
