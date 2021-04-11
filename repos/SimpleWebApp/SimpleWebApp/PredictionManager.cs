using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWebApp
{
    public class PredictionManager
    {
        private List<string> predictions;
        public PredictionManager()
        {
            predictions = new List<string>() { "11", "12", "13"};

        }
        public string GetRandomPrediction()
        {
            Random r = new Random();
            return predictions[r.Next(0,predictions.Count)];
        }
        public void AddPrediction(string prediction)
        {
            predictions.Add(prediction);
        }
    }
}
