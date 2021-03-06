﻿using System;
using JR.Cms.Conf;
using JR.Stand.Core.Framework.TaskBox;
using JR.Stand.Core.Framework.TaskBox.Toolkit;

namespace JR.Cms.Web
{
    internal class TaskClient : ITaskExecuteClient
    {
        public string ClientName => "taskClient";

        public void Execute(ITask task)
        {
            switch (task.TaskName)
            {
                case "gc_collect":
                    GC_Collect();
                    break;
            }

            task.SetState(this, TaskState.Ok, TaskMessage.Ok);
        }

        private void GC_Collect()
        {
            GC.Collect();
        }
    }

    public static class CmsTask
    {
        private static TaskService service;

        public static void Init()
        {
            return;
            service = new TaskService();
            service.Start(box =>
            {
                var taskClient = new TaskClient();
                box.OnNotifing += box_OnNotifing;
                box.OnTaskExecuting += taskClient.Execute;
            });

            RegisterDropMemoryTask();
        }

        private static void RegisterDropMemoryTask()
        {
            if (Settings.opti_gc_collect_interval <= 0)
                return;

            service.Sington.RegistContinuTasks(() =>
            {
                ITask task = new Task();
                task.TaskName = "gc_collect";
                return task;
            }, (client, task, message) => { }, Settings.opti_gc_collect_interval); //2小时
        }

        private static void box_OnNotifing(object data, string message)
        {
            if (message.StartsWith("[Crash]")) service.Stop();
        }
    }
}