
namespace DeepSigma.AutoML.Enums.LLM;

/// <summary>
/// ChunkingMethod is an enumeration that defines various methods for dividing large text data into smaller, manageable chunks for processing by language models, particularly in scenarios where the input text exceeds the model's maximum token limit or when specific chunking strategies are required to preserve context and improve model performance.
/// </summary>
public enum ChunkingMethod
{
    /// <summary>
    /// SentenceBased chunking divides the text into chunks based on sentence boundaries, ensuring that each chunk contains complete sentences, which helps preserve the context and meaning of the text for language models.
    /// However, it may result in variable chunk sizes depending on the length of sentences, which can lead to some chunks being too small or too large for optimal processing by language models, especially if the sentences vary significantly in length.
    /// Additionally, sentence-based chunking may not always capture the full context of the text if sentences are too short or if important information is spread across multiple sentences, which can impact the performance of language models that rely on contextual understanding to generate accurate responses or perform tasks effectively.
    /// </summary>
    SentenceBased,
    /// <summary>
    /// ParagraphBased chunking divides the text into chunks based on paragraph boundaries, allowing for larger chunks of text that can capture more context and information while still maintaining logical divisions in the text, which can be beneficial for language models that require more context to generate accurate responses or perform tasks effectively.
    /// </summary>
    ParagraphBased,
    /// <summary>
    /// FixedSize chunking divides the text into chunks of a specified fixed size, regardless of sentence or paragraph boundaries, which can be useful for ensuring that each chunk fits within the token limit of language models and allows for consistent processing of text data.
    /// However, it may result in chunks that cut off sentences or paragraphs, potentially leading to loss of context and meaning in the text, which can impact the performance of language models that rely on contextual understanding to generate accurate responses or perform tasks effectively.
    /// </summary>
    FixedSize,
    /// <summary>
    /// OverlappingWindows chunking divides the text into overlapping chunks, where each chunk contains a specified number of tokens that overlap with the previous chunk, allowing for better preservation of context and information across chunk boundaries, which can be beneficial for language models that require more context to generate accurate responses or perform tasks effectively.
    /// However, it may result in increased computational overhead and memory usage due to the overlapping nature of the chunks, which can impact the efficiency of processing large text data with language models, especially if the overlap size is large or if the input text is significantly long.
    /// </summary>
    OverlappingWindows,
    /// <summary>
    /// SemanticBased chunking divides the text into chunks based on semantic boundaries, such as topic shifts or changes in meaning, allowing for more meaningful and contextually relevant chunks that can improve the performance of language models by providing them with coherent and contextually rich input.
    /// This method can be particularly beneficial for tasks that require understanding of the overall context or global structure of the input, such as machine translation or text summarization, where the relevant information may be distributed across the entire input sequence.
    /// However, it may require more complex algorithms and computational resources to identify semantic boundaries accurately, which can impact the efficiency of processing large text data with language models, especially if the input text is significantly long or if the semantic boundaries are not clearly defined.
    /// </summary>
    SemanticBased,
}
