// Copyright 2007 Castle Project - http://www.castleproject.org/
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;
using System.Text;
using MbUnit.Framework;

namespace Castle.Components.Scheduler.Tests.Utilities
{
    /// <summary>
    /// Assertions for job objects.
    /// </summary>
    public static class JobAssert
    {
        public static void AreEqual(Trigger expected, Trigger actual)
        {
            if (expected == null)
            {
                Assert.IsNull(actual);
                return;
            }

            Assert.IsNotNull(actual);
            Assert.IsInstanceOfType(expected.GetType(), actual);
            Assert.AreEqual(expected.IsActive, actual.IsActive);
            //Assert.AreEqual(expected.IsDirty, actual.IsDirty);
            Assert.AreEqual(expected.NextFireTime, actual.NextFireTime);
            Assert.AreEqual(expected.NextMisfireThreshold, actual.NextMisfireThreshold);
        }

        public static void AreEqual(JobExecutionDetails expected, JobExecutionDetails actual)
        {
            if (expected == null)
            {
                Assert.IsNull(actual);
                return;
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.SchedulerName, actual.SchedulerName);
            Assert.AreEqual(expected.StartTime, actual.StartTime);
            Assert.AreEqual(expected.EndTime, actual.EndTime);
            Assert.AreEqual(expected.StatusMessage, actual.StatusMessage);
            Assert.AreEqual(expected.Succeeded, actual.Succeeded);
        }

        public static void AreEqual(JobData expected, JobData actual)
        {
            if (expected == null)
            {
                Assert.IsNull(actual);
                return;
            }

            Assert.IsNotNull(actual);
            CollectionAssert.AreElementsEqual(expected.State, actual.State);
        }

        public static void AreEqual(JobSpec expected, JobSpec actual)
        {
            if (expected == null)
            {
                Assert.IsNull(actual);
                return;
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Description, actual.Description);
            Assert.AreEqual(expected.JobKey, actual.JobKey);
            AreEqual(expected.Trigger, actual.Trigger);
        }

        public static void AreEqual(JobDetails expected, JobDetails actual)
        {
            if (expected == null)
            {
                Assert.IsNull(actual);
                return;
            }

            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.CreationTime, actual.CreationTime);
            AreEqual(expected.JobSpec, actual.JobSpec);
            AreEqual(expected.JobData, actual.JobData);
            Assert.AreEqual(expected.JobState, actual.JobState);
            Assert.AreEqual(expected.NextTriggerFireTime, actual.NextTriggerFireTime);
            Assert.AreEqual(expected.NextTriggerMisfireThreshold, actual.NextTriggerMisfireThreshold);
            AreEqual(expected.LastJobExecutionDetails, actual.LastJobExecutionDetails);
        }
    }
}