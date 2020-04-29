using System;
using System.Collections.Generic;
using System.Text;

namespace LV4_rppoon
{
    class Adapter : IAnalytics
    {
        private Analyzer3rdParty analyticsService;
        public Adapter(Analyzer3rdParty service)
        {
            this.analyticsService = service;
        }

        //1. Zadatak
        private double[][] ConvertData(Dataset dataset)
        {
            
            int rowCount = dataset.GetData().Count;
            double[][] result = new double[rowCount][];
            int columnCount = dataset.GetData()[0].Count;
            for(int i = 0; i < rowCount; i++)
            {
                result[i] = new double[columnCount];
            }
            for(int i = 0; i < rowCount; i++)
            {
                for(int j = 0; j < columnCount; j++)
                {
                    result[i][j] = dataset.GetData()[i][j]; 
                }
            }
            return result;
        }
        public double[] CalculateAveragePerColumn(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analyticsService.PerColumnAverage(data);
        }
        public double[] CalculateAveragePerRow(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analyticsService.PerRowAverage(data);
        }
    }
}
