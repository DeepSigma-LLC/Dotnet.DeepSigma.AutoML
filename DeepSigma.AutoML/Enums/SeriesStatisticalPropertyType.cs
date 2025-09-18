using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSigma.AutoML.Enums
{
    /// <summary>
    /// Specifies the statistical property type of a time series.
    /// </summary>
    public enum SeriesStatisticalPropertyType
    {
        /// <summary>
        /// Ergodic refers to one in which every (reasonly large) sample is representative of the entire process.
        /// This is a weaker condition than stationarity which requires that these subsamples have equivalent statistical properties such as mean and variance.
        /// </summary>
        Ergodic,
        /// <summary>
        /// WeakStationarity (also known as second-order stationarity or covariance stationarity) refers to a property of a time series where its statistical properties, such as mean, variance, and autocovariance, remain constant over time.
        /// </summary>
        WeakStationarity,
        /// <summary>
        /// StrongStationarity (also known as strict stationarity) is a property of a time series where the joint distribution of any set of observations remains unchanged when shifted in time.
        /// </summary>
        StrongStationarity,
        /// <summary>
        /// NonStationarity refers to a time series that does not exhibit stationarity, meaning its statistical properties change over time such as trends, seasonality, or varying variance.
        /// </summary>
        NonStationarity
    }
}
