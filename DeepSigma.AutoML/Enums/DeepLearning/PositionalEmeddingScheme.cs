
namespace DeepSigma.AutoML.Enums.DeepLearning;

/// <summary>
/// PositionalEmeddingScheme is an enumeration that defines the different types of positional embedding schemes used in deep learning models, particularly in transformer-based architectures for natural language processing (NLP) and other sequence modeling tasks.
/// </summary>
public enum PositionalEmeddingScheme
{
    /// <summary>
    /// RotaryPositionalEmedding is a positional embedding scheme that encodes the position of tokens in a sequence using a combination of sine and cosine functions, allowing the model to capture the relative positions of tokens in the input sequence while maintaining computational efficiency and flexibility in handling variable-length sequences.
    /// </summary>
    RotaryPositionalEmedding,
    /// <summary>
    /// AbsolutePositionalEmedding is a positional embedding scheme that encodes the position of tokens in a sequence using fixed, pre-defined vectors based on their absolute positions in the input sequence, allowing the model to capture the positional information of tokens but may not be as effective in capturing relative positions or handling variable-length sequences compared to other schemes like rotary positional embedding.
    /// </summary>
    AbsolutePositionalEmedding,
    /// <summary>
    /// Represents a relative positional embedding used to encode the relative positions of elements within a sequence.
    /// </summary>
    RelativePositionalEmedding,
    /// <summary>
    /// LearnablePositionalEmedding is a positional embedding scheme where the position of tokens in a sequence is encoded using learnable parameters that are optimized during the training process, allowing the model to adaptively learn the most effective positional representations for the specific task and dataset, potentially leading to improved performance compared to fixed positional embedding schemes.
    /// </summary>
    LearnablePositionalEmedding,
    /// <summary>
    /// SinusoidalPositionalEmedding is a positional embedding scheme that encodes the position of tokens in a sequence using a combination of sine and cosine functions with different frequencies, allowing the model to capture both absolute and relative positional information while maintaining computational efficiency and flexibility in handling variable-length sequences, making it a popular choice for transformer-based architectures in NLP tasks.
    /// </summary>
    SinusoidalPositionalEmedding
}
