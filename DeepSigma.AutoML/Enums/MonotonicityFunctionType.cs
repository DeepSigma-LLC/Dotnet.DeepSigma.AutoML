using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSigma.AutoML.Enums;

/// <summary>
/// Specifies the type of function based on its monotonicity properties.
/// </summary>
public enum MonotonicityFunctionType
{
    /// <summary>
    /// MonotonicNonStrict functions are those that consistently increase or remain constant over their entire domain. 
    /// In other words, as the input values increase, the output values either stay the same or increase, but they never decrease. 
    /// </summary>
    MonotonicNonStrict,
    /// <summary>
    /// MonotonicStrict functions are those that consistently increase over their entire domain without any flat or constant intervals.
    /// </summary>
    MonotonicStrict,
    /// <summary>
    /// Non-monotonic functions do not exhibit a consistent increase or decrease over their entire domain. Instead, they may have multiple peaks and valleys, meaning that the function can increase in some intervals and decrease in others without any specific order or pattern.
    /// </summary>
    NonMonotonic,
}
