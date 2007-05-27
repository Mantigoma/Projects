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
using Castle.Core.Logging;
using Castle.MicroKernel;
using MbUnit.Framework;
using Rhino.Mocks;

namespace Castle.Components.Scheduler.Tests.UnitTests
{
    [TestFixture]
    [TestsOn(typeof(ComponentJobFactory))]
    [Author("Jeff Brown", "jeff@ingenio.com")]
    public class ComponentJobFactoryTest : BaseUnitTest
    {
        private IKernel kernel;
        private ComponentJobFactory factory;

        public override void SetUp()
        {
            base.SetUp();

            kernel = Mocks.CreateMock<IKernel>();
            factory = new ComponentJobFactory(kernel);
        }

        [Test]
        public void GetJobCallsResolve()
        {
            IJob job = Mocks.CreateMock<IJob>();
            Expect.Call(kernel.Resolve("job.key", typeof(IJob))).Return(job);
            Mocks.ReplayAll();

            Assert.AreSame(job, factory.GetJob("job.key"));
        }

        [Test]
        [ExpectedException(typeof(SchedulerException))]
        public void GetJobWrapsExceptions()
        {
            Expect.Call(kernel.Resolve("job.key", typeof(IJob))).Throw(new Exception("Oh no!"));
            Mocks.ReplayAll();

            factory.GetJob("job.key");
        }
    }
}