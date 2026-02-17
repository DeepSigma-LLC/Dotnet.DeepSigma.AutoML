

namespace DeepSigma.AutoML.Enums.NLP;

/// <summary>
/// LanguageAIModel is an enumeration that defines the different types of language AI models used in natural language processing (NLP) and machine learning.
/// </summary>
public enum LanguageAIModel
{
    /// <summary>
    /// BagOfWords is a simple and traditional approach to representing text data in natural language processing (NLP).
    /// In this model, text is represented as a "bag" of its words, disregarding grammar and word order but keeping track of the frequency of each word.
    /// It is often used for tasks like text classification and sentiment analysis, where the presence or absence of certain words can be indicative of the overall meaning or sentiment of the text.
    /// It was developed in the year 954 and has been widely used in NLP applications for many years. 
    /// However, it has limitations in capturing the semantic meaning and context of text, which has led to the development of more advanced models like Word2Vec and transformer-based models.
    /// </summary>
    BagOfWords,
    /// <summary>
    /// Word2Vec is a more advanced language model that was developed in 2013 by a team of researchers at Google led by Tomas Mikolov.
    /// Word2Vec is a neural network-based model that learns to represent words as dense vectors in a continuous vector space, capturing semantic relationships between words based on their co-occurrence in large text corpus.
    /// </summary>
    Word2Vec,
    /// <summary>
    /// GloVe (Global Vectors for Word Representation) is a language model developed by researchers at Stanford University in 2014.
    /// GloVe is a count-based model that learns word embeddings by factorizing a word co-occurrence matrix, capturing both local and global statistical information about word relationships in a text corpus.
    /// </summary>
    GloVe,
    /// <summary>
    /// FastText is a language model developed by Facebook's AI Research (FAIR) lab in 2016.
    /// FastText is an extension of the Word2Vec model that represents words as bags of character n-grams, allowing it to capture subword information and handle out-of-vocabulary words more effectively.
    /// </summary>
    FastText,
    /// <summary>
    /// BERT (Bidirectional Encoder Representations from Transformers) is a transformer-based language model developed by Google in 2018.
    /// BERT is designed to understand the context of words in a sentence by processing text bidirectionally, meaning it considers both the left and right context of a word when generating its representation.
    /// Previous language models typically processed text in a unidirectional manner, either from left to right or right to left, which limited their ability to capture the full context of a word.
    /// BERT is a representation model that can be fine-tuned for various NLP tasks, such as text classification, question answering, and named entity recognition, making it a powerful tool for natural language understanding and generation.
    /// Note: It is an encoder-only model, which means it focuses on understanding and representing the input text rather than generating new text. 
    /// There is no decoder, as BERT is primarily designed for representation tasks rather than generation tasks.
    /// However, BERT can be extended with additional layers or components to enable text generation capabilities (aka Transfer Learning), but its core architecture is focused on encoding and understanding text rather than generating it.
    /// This model is not autoregressive, meaning it does not generate text one token at a time based on previously generated tokens. 
    /// Instead, it processes the entire input text simultaneously to capture the context and relationships between words.
    /// </summary>
    BERT,
    /// <summary>
    /// Transformer is a language model architecture that was introduced in the paper "Attention is All You Need" by Vaswani et al. in 2017.
    /// The transformer architecture is based on self-attention mechanisms, which allow it to capture long-range dependencies in text and process input sequences in parallel, making it highly efficient for training on large datasets.
    /// The model is designed to handle sequential data, such as text, and has been widely adopted in various NLP tasks, including machine translation, text summarization, and language generation.
    /// The model is autoregressive, meaning it generates text one token at a time, using the previously generated tokens as context for generating the next token.
    /// </summary>
    Transformer,
}
