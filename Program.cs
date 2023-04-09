
// Anonymous Methods
MeasurementConverter converter = delegate (string measureFrom, string measuresTo, double valueFrom)
{
    double valueConverted = 0.0D;

    if (measureFrom == "m" && measuresTo == "cm")
    {
        valueConverted = valueFrom * 100;
    }
    else if (measureFrom == "cm" && measuresTo == "m")
    {
        valueConverted = valueFrom / 100;
    }

    Console.WriteLine($"Anonymous method: {valueFrom} {measureFrom} to {measuresTo} = {valueConverted} {measuresTo}");
};

// Lambda Expression
MeasurementConverter converterLambdaExpression = (string measureFrom, string measuresTo, double valueFrom) =>
{
    double valueConverted = 0.0D;

    if (measureFrom == "m" && measuresTo == "cm")
    {
        valueConverted = valueFrom * 100;
    }
    else if (measureFrom == "cm" && measuresTo == "m")
    {
        valueConverted = valueFrom / 100;
    }

    Console.WriteLine($"Lambda Expression: {valueFrom} {measureFrom} to {measuresTo} = {valueConverted} {measuresTo}");
};

converter("m", "cm", 10);

Console.WriteLine("\n");

converterLambdaExpression("cm", "m", 10);

Console.Read();

delegate void MeasurementConverter(string measureFrom, string measuresTo, double valueFrom);