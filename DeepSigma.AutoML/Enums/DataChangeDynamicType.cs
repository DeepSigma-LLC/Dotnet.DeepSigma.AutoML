
namespace DeepSigma.AutoML.Enums;

/// <summary>
/// Specifies how the data value may change over time.
/// </summary>
public enum DataChangeDynamicType
{
    /// <summary>
    /// Data value will not change over time.
    /// </summary>
    Static,
    /// <summary>
    /// Data value may change (increase or decrease) over time.
    /// </summary>
    Dyanmic,
    /// <summary>
    /// Data value will remain static or raise over time.
    /// </summary>
    Floating,
    /// <summary>
    /// Data value will remain static or fall over time. 
    /// </summary>
    Sinking
}
