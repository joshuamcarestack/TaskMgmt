﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskMgmt.DataAccess.Models;

namespace TaskMgmt.DataAccess.Repositories
{
    public interface ITaskRepository
    {
        public Task<IEnumerable<ProjectTask>> GetAll();
        public Task<ProjectTask> GetById(int Id);
        public Task Add(ProjectTask task);


    }
}
