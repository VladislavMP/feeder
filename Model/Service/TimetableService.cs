using System;
using System.Collections.Generic;
using System.Text;
using Model.Entity;

namespace Model.Service
{
    class TimetableService
    {
        private IRepository<Timetable> _repository;

        public TimetableService(IRepository<Timetable> repository)
        {
            _repository = repository;
        }

    }
}
