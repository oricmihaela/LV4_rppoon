using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;   //potrebna za Average()

namespace LV4_rppoon
{
    class Analyzer3rdParty
    {
        public double[] PerRowAverage(double[][] data)
        {
            int rowCount = data.Length;
            double[] results = new double[rowCount];
            for (int i = 0; i < rowCount; i++)
            {
                results[i] = data[i].Average();
            }
            return results;
        }

        //1. Zadatak
        public double[] PerColumnAverage(double[][] data)
        {
            int rowCount = data.Length;
            int columnCount = data[0].Length;
            double[] results = new double[columnCount];
            double sum;
            for(int j = 0; j < columnCount; j++)
            {
                sum = 0;
                for(int i = 0; i < rowCount; i++)
                {
                    sum += data[i][j];
                }
                results[j] = sum / rowCount;
            }
            return results;
        }
    }
}
