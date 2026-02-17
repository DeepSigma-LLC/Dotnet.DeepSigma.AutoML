
namespace DeepSigma.AutoML.Enums.DeepLearning;

/// <summary>
/// The TransformerRandomnessSettingForTask enumeration defines different settings for controlling the randomness of transformer-based models based on specific tasks or use cases.
/// </summary>
public enum TransformerRandomnessSettingForTask
{
    /// <summary>
    /// Brainstorming sessions benefit from high randomness to encourage diverse ideas. 
    /// This setting allows for a wide range of possible outputs, fostering creativity and exploration of different concepts and perspectives during brainstorming activities.
    /// </summary>
    BrainstormingSession,
    /// <summary>
    /// Email generation typically requires more focused and coherent output, so lower randomness is preferred across both parameters. 
    /// This setting helps ensure that the generated emails are clear, concise, and relevant to the intended message, while still allowing for some degree of variation to avoid overly repetitive or formulaic responses.
    /// </summary>
    EmailGeneration,
    /// <summary>
    /// Creative writing can benefit from a mix of high sampling randomness but only the most probable tokens to sample from to balance creativity with coherence.
    /// </summary>
    CreativeWriting,
    /// <summary>
    /// Deterministic output with high probable predicted tokens. 
    /// Produces coherent output with a wider range of vocabulary, leading to outputs with linguistic variety.
    /// </summary>
    Translation
}

/// <summary>
///  The TransformerRandomnessSettingExtensions class provides extension methods for the TransformerRandomnessSetting enumeration, allowing for easy retrieval of temperature and top-p settings based on the specified randomness setting.
/// </summary>
public static class TransformerRandomnessSettingExtensions
{
    /// <summary>
    /// Returns the appropriate temperature and top-p settings for a given transformer randomness setting. 
    /// These settings are designed to optimize the output of transformer-based models for specific use cases, balancing creativity and coherence as needed.
    /// </summary>
    /// <param name="setting"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public static (Magnitude TemperatureSetting, Magnitude TopPSetting) GetTemperature(this TransformerRandomnessSettingForTask setting)
    {
        return setting switch
        {
            // Brainstorming sessions benefit from high randomness to encourage diverse ideas.
            TransformerRandomnessSettingForTask.BrainstormingSession => (Magnitude.High, Magnitude.High),
            // Email generation typically requires more focused and coherent output, so lower randomness is preferred across both parameters.
            TransformerRandomnessSettingForTask.EmailGeneration => (Magnitude.Low, Magnitude.Low),
            // Creative writing can benefit from a mix of high sampling randomness but only the most probable tokens to sample from to balance creativity with coherence.
            TransformerRandomnessSettingForTask.CreativeWriting => (Magnitude.High, Magnitude.Low),
            // Deterministic output with high probable predicted tokens. Produces coherent output with a wider range of vocabulary, leading to outputs with linguistic variety.
            TransformerRandomnessSettingForTask.Translation => (Magnitude.Low, Magnitude.High),
            _ => throw new ArgumentOutOfRangeException(nameof(setting), $"Unexpected value: {setting}")
        };
    }
}