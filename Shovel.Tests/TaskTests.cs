﻿using NUnit.Framework;
using ShovelPack.TaskActionConfig;
using ShovelPack.Tasks;

namespace Shovel.Tests
{
	[TestFixture]
	public class TaskTests
	{
		[Test]
		public void TaskWithNoPreExecutorDefinedDoesNotFail()
		{
			var task = new Task("task-with-no-action", null, new TaskActionFactory(null));
			task.Do(() => { });
			Assert.That(() => task.Run(), Throws.Nothing);
		}

		[Test]
		public void TaskWithNoActionDefinedDoesNotFail()
		{
			var task = new Task("task-with-no-action", t => { }, new TaskActionFactory(null));
			Assert.That(() => task.Run(), Throws.Nothing);
		}
	}
}