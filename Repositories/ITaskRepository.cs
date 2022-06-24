using ToDo_Project_PAW.Models;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace ToDo_Project_PAW.Repositories
{
    public interface ITaskRepository
    {
        TaskModel Get(int taskId);
        IQueryable<TaskModel> GetAllActive();
        void Add(TaskModel task);
        void Update(int taskId, TaskModel task);
        void Delete(int taskId);



    }
}
