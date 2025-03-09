using AdvancedProgramming.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdvancedProgramming.Logic
{
    // TODO: Single Responsibility Principle (SRP)
    // La clase TaskGenerator solo se encarga de generar tareas, sin preocuparse por otras responsabilidades
    public class TaskGenerator
    {
        public IEnumerable<TaskViewModel> GetTasks()
        {
            return new List<TaskViewModel>
        {
            new TaskViewModel
            {   Id = 1, Name = "Task 1", Description = "Description of task 1", Status = "Pending", DueDate = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd"), CreatedAt = DateTime.Now.ToString("yyyy-MM-dd")},
            new TaskViewModel
            {   Id = 2, Name = "Task 2", Description = "Description of task 2", Status = "Completed", DueDate = DateTime.Now.AddDays(2).ToString("yyyy-MM-dd"), CreatedAt = DateTime.Now.ToString("yyyy-MM-dd") },
        };
        }
    }
} 