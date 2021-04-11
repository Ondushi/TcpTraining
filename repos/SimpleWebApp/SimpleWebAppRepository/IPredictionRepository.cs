using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWebApp
{
    interface IPredictionRepository
    {
        void SavePrediction(Prediction prediction);
    }
}
