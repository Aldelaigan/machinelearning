﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;

namespace Microsoft.ML.Trainers.Ensemble
{
    public delegate void SignatureModelCombiner(PredictionKind kind);

    /// <summary>
    /// An interface that combines multiple predictors into a single predictor.
    /// </summary>
    public interface IModelCombiner
    {
        IPredictor CombineModels(IEnumerable<IPredictor> models);
    }
}
