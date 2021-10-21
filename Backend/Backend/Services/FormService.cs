using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.DAL.Collections;
using Backend.DAL.Repositories;
using Backend.Models;

namespace Backend.Services
{
    public class FormService
    {
        private readonly MongoRepository _repository;

        public FormService(MongoRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Registration>> GetAsync()
        {
            return await _repository.GetAsync();
        }

        public async Task<Registration> GetByIdAsync(string id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public void Update(string id, Registration registration, FormModel formModel)
        {
            _repository.Update(id, itemIn: UpdateRegistration(registration, formModel));
        }

        public Registration UpdateRegistration(Registration registration, FormModel formModel)
        {
            Registration newRegistration = new Registration();
            foreach (var item in formModel.Form)
            {
                registration.Questions.Where(x => x.Id == item.QuestionId)
                                      .Select(a => a.AnswerId = item.AnswerId)
                                      .FirstOrDefault();

                newRegistration = registration;
            }

            return newRegistration;
        }
    }
}
