// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The WholeMetricConfiguration. </summary>
    public partial class MetricWholeSeriesDetectionCondition
    {
        /// <summary> Initializes a new instance of MetricWholeSeriesDetectionCondition. </summary>
        /// <param name="conditionOperator">
        /// condition operator
        ///
        /// should be specified when combining multiple detection conditions
        /// </param>
        /// <param name="smartDetectionCondition"></param>
        /// <param name="hardThresholdCondition"></param>
        /// <param name="changeThresholdCondition"></param>
        internal MetricWholeSeriesDetectionCondition(DetectionConditionOperator? conditionOperator, SmartDetectionCondition smartDetectionCondition, HardThresholdCondition hardThresholdCondition, ChangeThresholdCondition changeThresholdCondition)
        {
            ConditionOperator = conditionOperator;
            SmartDetectionCondition = smartDetectionCondition;
            HardThresholdCondition = hardThresholdCondition;
            ChangeThresholdCondition = changeThresholdCondition;
        }
    }
}
