using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Backend.DAL;
using Backend.DAL.Collections;
using Backend.DAL.Repositories;

namespace Backend.Services
{
    public class FormService
    {
        private readonly Unit _unit;

        public FormService(Unit unit)
        {
            _unit = unit;
        }

        public Task<List<Option>> GetAsync()
        {
            return _unit.OptionRepository.GetAsync();
        }
    }
}
