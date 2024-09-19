using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Timers;
using System.ServiceProcess;

namespace ServerController
{
    public partial class MainForm : Form
    {
        private List<ScheduledTask> _tasks = new List<ScheduledTask>();
        private System.Timers.Timer _timer = new System.Timers.Timer(1000);

        public MainForm()
        {
            InitializeComponent();
            InitializeScheduler();
        }

        private void InitializeScheduler()
        {
            _timer.Elapsed += TimerElapsed;
            _timer.Start();
            LoadTasks();
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            var now = DateTime.Now;
            foreach (var task in _tasks)
            {
                if (task.ShouldExecute(now))
                {
                    RestartService(task.ServiceName);
                }
            }
        }

        private void RestartService(string serviceName)
        {
            try
            {
                var service = new ServiceController(serviceName);
                if (service.Status == ServiceControllerStatus.Running)
                {
                    service.Stop();
                    service.WaitForStatus(ServiceControllerStatus.Stopped);
                }
                service.Start();
                service.WaitForStatus(ServiceControllerStatus.Running);
                LogMessage($"服务 {serviceName} 已成功重启。");
            }
            catch (Exception ex)
            {
                LogMessage($"重新启动服务 {serviceName} 时出错：{ex.Message}。");
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var name = txtName.Text;
            var serviceName = txtServiceName.Text;
            var hour = int.Parse(txtHour.Text);
            var minute = int.Parse(txtMinute.Text);
            var second = int.Parse(txtSecond.Text);
            var selectedDay = cmbDayOfWeek.SelectedItem.ToString();

            // 尝试将字符串转换为 DayOfWeek 枚举
            Enum.TryParse(selectedDay, out DayOfWeek dayOfWeek);

            var task = new ScheduledTask
            {
                Name = name,
                ServiceName = serviceName,
                Time = new TimeSpan(hour, minute, second),
                DayOfWeek = dayOfWeek
            };

            _tasks.Add(task);
            UpdateTaskList();
            LogMessage($"添加的任务：{task}");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem is ScheduledTask selectedTask)
            {
                _tasks.Remove(selectedTask);
                UpdateTaskList();
                LogMessage($"已删除任务：{selectedTask}");
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveTasks();
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            LoadTasks();
            UpdateTaskList();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            _timer.Start();
            LogMessage("调度程序已启动。");
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            _timer.Stop();
            LogMessage("调度程序已停止。");
        }

        private void SaveTasks()
        {
            try
            {
                using (var writer = new StreamWriter("tasks.txt"))
                {
                    foreach (var task in _tasks)
                    {
                        writer.WriteLine($"{task.Name}|{task.ServiceName}|{task.Time.Hours}:{task.Time.Minutes}:{task.Time.Seconds}|{task.DayOfWeek}");
                    }
                }
                LogMessage("任务已保存到tasks.txt。");
            }
            catch (Exception ex)
            {
                LogMessage($"保存任务时出错：{ex.Message}");
            }
        }

        private void LoadTasks()
        {
            if (File.Exists("tasks.txt"))
            {
                _tasks.Clear();
                try
                {
                    using (var reader = new StreamReader("tasks.txt"))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            var parts = line.Split('|');
                            if (parts.Length == 4)
                            {
                                var name = parts[0];
                                var serviceName = parts[1];
                                var timeParts = parts[2].Split(':');
                                var time = new TimeSpan(int.Parse(timeParts[0]), int.Parse(timeParts[1]), int.Parse(timeParts[2]));
                                var dayOfWeek = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), parts[3]);

                                _tasks.Add(new ScheduledTask
                                {
                                    Name = name,
                                    ServiceName = serviceName,
                                    Time = time,
                                    DayOfWeek = dayOfWeek
                                });
                            }
                        }
                    }
                    LogMessage("从tasks.txt加载的任务。");
                }
                catch (Exception ex)
                {
                    LogMessage($"加载任务时出错：{ex.Message}");
                }
            }
        }

        private void UpdateTaskList()
        {
            lstTasks.Items.Clear();
            foreach (var task in _tasks)
            {
                lstTasks.Items.Add(task);
            }
        }

        private void LogMessage(string message)
        {
            txtLog.AppendText($"{DateTime.Now}: {message}{Environment.NewLine}");
        }
    }

    public class ScheduledTask
    {
        public string Name { get; set; }
        public string ServiceName { get; set; }
        public TimeSpan Time { get; set; }
        public DayOfWeek DayOfWeek { get; set; }

        public bool ShouldExecute(DateTime now)
        {
            return now.DayOfWeek == DayOfWeek && now.TimeOfDay >= Time && now.TimeOfDay < Time.Add(TimeSpan.FromSeconds(1));
        }

        public override string ToString()
        {
            return $"{Name} - {ServiceName} at {Time} on {DayOfWeek}";
        }
    }
}
