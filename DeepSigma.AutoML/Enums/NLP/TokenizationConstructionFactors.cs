
namespace DeepSigma.AutoML.Enums.NLP;

/// <summary>
/// TokenizationConstructionFactors is an enumeration that defines the various factors that can influence the construction of tokenization methods in natural language processing (NLP).
/// </summary>
public enum TokenizationConstructionFactors
{
    /// <summary>
    /// The tokenization method used to split text into tokens (e.g., Word, SubWord, Character, ByteToken).
    /// </summary>
    TokenizationMethod,
    /// <summary>
    /// The size of the vocabulary used for tokenization, which can affect the granularity of the tokens and the model's ability to capture nuances in language.
    /// </summary>
    VocabularySize,
     /// <summary>
    /// The use of special tokens (e.g., [S], [CLS], [SEP], [PAD]) to indicate the start and end of sequences, separate different segments of text, or pad shorter sequences to a fixed length.
    /// </summary>
    SpecialTokens,
    /// <summary>
    /// The handling of out-of-vocabulary (OOV) words, which can involve strategies such as using a special OOV token, subword tokenization, or character-level tokenization to represent rare or unseen words.
    /// </summary>
    OutOfVocabularyHandling,
    /// <summary>
    /// Training data and corpus characteristics, such as the size and diversity of the training data, which can influence the effectiveness of the tokenization method and the model's ability to generalize to new text.
    /// </summary>
    TrainingData
}
