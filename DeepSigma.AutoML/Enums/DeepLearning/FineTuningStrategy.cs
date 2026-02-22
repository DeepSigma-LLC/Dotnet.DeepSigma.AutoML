
namespace DeepSigma.AutoML.Enums.DeepLearning;

/// <summary>
/// Fine-tuning strategies refer to the different approaches that can be used to adapt a pre-trained model to a specific task or dataset.
/// </summary>
public enum FineTuningStrategy
{
    /// <summary>
    /// Partial fine-tuning involves updating only a subset of the parameters of the pre-trained model during the training process.
    /// This approach allows the model to retain much of its pre-trained knowledge while still adapting to the new task, and it can be more efficient in terms of computational resources and training time compared to full fine-tuning.
    /// </summary>
    PartialFineTuning,
    /// <summary>
    /// Full fine-tuning involves updating all the parameters of the pre-trained model during the training process. 
    /// This approach allows the model to adapt fully to the new task, but it can be computationally expensive and may require a large amount of data to avoid overfitting.
    /// </summary>
    FullFineTuning,
    /// <summary>
    /// Parameter-efficient fine-tuning (PEFT) is a strategy that focuses on updating only a subset of the model's parameters, rather than all of them.
    /// This approach can be more efficient in terms of computational resources and can help prevent overfitting, especially when the available training data is limited.
    /// An adapter is a small neural network that is inserted into the pre-trained model, and only the parameters of the adapter are updated during fine-tuning.
    /// This allows the pre-trained model to retain its general knowledge while adapting to the specific task at hand, making it a popular choice for fine-tuning large language models and other deep learning architectures.
    /// </summary>
    /// <remarks>
    /// Research has shown that PEFT can achieve comparable performance to full fine-tuning while significantly reducing the number of parameters that need to be updated, making it an attractive option for many applications.
    /// For example, training only ~4% of the parameters of BERT can achieve 97% of the performance of full fine-tuning, demonstrating the efficiency of this approach.
    /// </remarks>
    ParameterEfficientFineTuningUsingAdapter,
    /// <summary>
    /// Low-Rank Adaptation (LoRA) is a specific type of parameter-efficient fine-tuning strategy that focuses on updating only a low-rank subset of the model's parameters.
    /// This approach is based on the idea that many of the parameters in a pre-trained model may be redundant or not essential for the specific task at hand, and that updating only a small subset of parameters can still allow the model to adapt effectively.
    /// To implement LoRA, a low-rank matrix is inserted into the pre-trained model, and only the parameters of this matrix are updated during fine-tuning.
    /// The weights of the low-rank matrix are then combined with the original parameters of the model to produce the final output, allowing the model to retain its general knowledge while adapting to the specific task.
    /// </summary>
    LORA,
    /// <summary>
    /// Quantized Low-Rank Adaptation (QLoRA) is an extension of the LoRA strategy that incorporates quantization techniques to further reduce the computational resources required for fine-tuning.
    /// In QLoRA, the low-rank matrix used in LoRA is quantized to reduce its memory footprint and computational requirements, making it even more efficient for fine-tuning large models.
    /// Instead of directly mapping higher precision to lower precision values, additional blocks are created that allow for quantizing similar weights. 
    /// This is particularly beneficial for large language models, where the number of parameters can be in the billions, as it allows for significant reductions in memory usage and computational costs while still achieving competitive performance on downstream tasks.
    /// </summary>
    QLoRA,
}
