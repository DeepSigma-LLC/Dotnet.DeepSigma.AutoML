
namespace DeepSigma.AutoML.Enums.NLP;

/// <summary>
/// TokenizationMethod is an enumeration that defines the different methods of tokenization used in natural language processing (NLP) and machine learning.
/// </summary>
public enum TokenizationMethod
{
    /// <summary>
    /// Word-level tokenization involves splitting text into individual words as tokens. 
    /// This is a common and straightforward method of tokenization that is widely used in many NLP applications. 
    /// However, it can lead to issues such as out-of-vocabulary (OOV) words, where the model encounters words that were not present in the training data, and it may not capture subword information or morphological variations effectively.
    /// </summary>
    Word,
    /// <summary>
    /// Represents a segment or component of a word, such as a prefix, suffix, or root.
    /// </summary>
    /// <remarks>Use this type to model or manipulate parts of words in linguistic or text processing
    /// scenarios. The specific meaning of a subword may depend on the context in which it is used.</remarks>
    SubWord,
    /// <summary>
    /// Character-level tokenization involves splitting text into individual characters as tokens. 
    /// This method can capture fine-grained details of the text and is particularly useful for languages with complex morphology or for tasks that require a high level of granularity, such as language modeling or character-level language generation. 
    /// However, it can also lead to longer sequences and increased computational complexity compared to word-level or subword tokenization.
    /// </summary>
    Character,
    /// <summary>
    /// Byte Pair Encoding (BPE) is a subword tokenization method that iteratively merges the most frequent pairs of characters or character sequences in a corpus to create a vocabulary of subword units.
    /// </summary>
    BytePairEncoding,
}
