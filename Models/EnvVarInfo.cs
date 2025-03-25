using System;

public class EnvVarInfo
{
    public Guid Id { get; set; }
    public Guid ValueId { get; set; }
    public string DisplayName { get; set; }
    public string Description { get; set; }
    public bool DisplayName_modif { get; set; }
    public string SchemaName { get; set; }
    public int DataType { get; set; }
    public string DataType_formatted { get; set; }
    public string DefaultValue { get; set; }
    public bool DefaultValue_modif { get; set; }
    public string CurrentValue { get; set; }
    public bool CurrentValue_modif { get; set; }
}