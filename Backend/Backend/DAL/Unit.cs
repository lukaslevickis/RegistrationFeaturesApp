using System;
using Backend.DAL.Collections;
using Backend.DAL.Repositories;

namespace Backend.DAL
{
    public class Unit
    {
        public MongoRepository<Option> _optionRepository;
        public MongoRepository<Question> _questionRepository;
        public MongoRepository<Registration> _registrationRepository;
        private readonly IMongoDbSettings _settings;

        public Unit(IMongoDbSettings settings)
        {
            _settings = settings;
        }

        public MongoRepository<Option> OptionRepository
        {
            get
            {
                if (this._optionRepository == null)
                {
                    this._optionRepository = new MongoRepository<Option>(_settings);
                }
                return _optionRepository;
            }
        }

        public MongoRepository<Question> QuestionRepository
        {
            get
            {
                if (this._questionRepository == null)
                {
                    this._questionRepository = new MongoRepository<Question>(_settings);
                }
                return _questionRepository;
            }
        }

        public MongoRepository<Registration> RegistrationRepository
        {
            get
            {
                if (this._registrationRepository == null)
                {
                    this._registrationRepository = new MongoRepository<Registration>(_settings);
                }
                return _registrationRepository;
            }
        }
    }
}
