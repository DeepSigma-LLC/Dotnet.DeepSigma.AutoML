using DeepSigma.AutoML.Enums;


namespace DeepSigma.AutoML.Models;

public class Model
{
    public string Name { get; set; }
    public string Description { get; set; }
    public ModelMemoryLengthType MemoryLengthType { get; set; }
    public SeriesStatisticalPropertyType RequiredStationarityType { get; set; }
    public ModelLearningType ModelLearningType { get; set; }
    public ModelMemoryType ModelMemoryType { get; set; }
    public bool MultitaskLearning { get; set; }
}
