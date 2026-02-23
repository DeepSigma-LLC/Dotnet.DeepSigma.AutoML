
namespace DeepSigma.AutoML.Enums.Deployment;

/// <summary>
/// ETLPipelineType specifies the types of data integration processes, including ETL (Extract, Transform, Load) and ELT (Extract, Load, Transform), which are essential for managing and processing data in various data platforms and environments, each offering different approaches to data transformation and loading based on the capabilities of the target system and the requirements of the data processing workflow.
/// </summary>
public enum ETLPipelineType
{
    /// <summary>
    /// ETL (Extract, Transform, Load) is a data integration process that involves extracting data from various sources, transforming it into a suitable format for analysis or storage, and then loading it into a target system such as a data warehouse or database.
    /// The ETL approach allows for data cleansing, enrichment, and transformation before loading it into the target system, which can help ensure data quality and consistency.
    /// Additionally, ETL can be more suitable for traditional on-premises data platforms that may have limited processing capabilities, as it allows for the transformation step to be performed outside of the target system, reducing the computational load on the target system during the loading process.
    /// </summary>
    ETL,
    /// <summary>
    /// ELT (Extract, Load, Transform) is a data integration process that involves extracting data from various sources, loading it into a target system such as a data warehouse or database, and then transforming it within the target system using its processing capabilities.
    /// The ELT approach allows for more efficient processing of large volumes of data, as the transformation step can leverage the computational power of the target system, and it can also provide greater flexibility in terms of data transformation and analysis, as the data is available in its raw form within the target system before transformation.
    /// Additionally, ELT can be more suitable for modern cloud-based data platforms that are designed to handle large-scale data processing and storage, as it allows for more efficient use of resources and can take advantage of the scalability and performance capabilities of these platforms.
    /// </summary>
    ELT
}
