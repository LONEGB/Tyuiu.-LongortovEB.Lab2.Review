using Tyuiu._LongortovEB.Lab2.Review.V4.Lib;
using Xunit;

namespace Tyuiu._LongortovEB.Lab2.Review.V4.Test;

public class UnitTest1
{
    [Fact]
    public void CheckGetMassFunction()
    {
        DataService ds = new DataService();

        int startStep = 1;
        int stopStep = 3;

        double[][] result = ds.GetMassFunction(startStep, stopStep);

        double[][] true_value = new double[][]
        {
            new double[] { 1, 1.02 },
            new double[] { 2, -0.10 },
            new double[] { 3, -0.18 }
        };

        Assert.Equals(true_value, result);

    }
}