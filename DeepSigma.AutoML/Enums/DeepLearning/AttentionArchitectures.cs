namespace DeepSigma.AutoML.Enums.DeepLearning;

/// <summary>
/// AttentionArchitectures is an enumeration that defines different types of attention architectures used in natural language processing (NLP) and machine learning models, particularly in transformer-based architectures.
/// </summary>
public enum AttentionArchitectures
{
    /// <summary>
    /// MultiHeadAttention is an attention architecture that allows the model to attend to multiple subspaces of the input data simultaneously, enabling it to capture different types of relationships and dependencies between tokens in the input sequence.
    /// </summary>
    MultiHeadAttention,
    /// <summary>
    /// MultiQueryAttention is an attention architecture that allows the model to attend to multiple queries simultaneously, enabling it to capture different types of relationships and dependencies between tokens in the input sequence while reducing the computational complexity compared to multi-head attention.
    /// However, it may not capture as rich and diverse relationships between tokens as multi-head attention, as it shares attention weights across multiple queries, which can limit the model's ability to learn distinct representations for different queries and may lead to suboptimal performance on certain tasks that require more nuanced understanding of the input data.
    /// </summary>
    MultiQueryAttention,
    /// <summary>
    /// GroupedQueryAttention is an attention architecture that allows the model to attend to groups of queries simultaneously, enabling it to capture different types of relationships and dependencies between tokens in the input sequence while further reducing the computational complexity compared to multi-query attention by grouping queries together and sharing attention weights within each group.
    /// Grouped query attention is particularly effective for tasks that require capturing complex relationships between tokens while maintaining computational efficiency, such as language modeling and machine translation, where the input sequences can be long and the number of queries can be large.
    /// It can be seen as a compromise between multi-head attention and multi-query attention, providing a balance between capturing rich relationships between tokens and reducing computational complexity, making it a popular choice for transformer-based architectures in NLP tasks.
    /// </summary>
    GroupedQueryAttention,
    
}
