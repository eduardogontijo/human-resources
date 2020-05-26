﻿using Human.Resources.Domain.Validators;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Human.Resources.Domain.Entities
{
    public class Employee : Entity<Employee>
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public int GenderId { get; set; }
        public Gender Gender { get; set; }

        public IEnumerable<EmployeeSkill> EmployeeSkills { get; set; }

        public override bool IsValid()
        {
            Validate();
            return ValidationResult.IsValid;
        }

        private void Validate()
        {
            ValidationResult = new EmployeeValidator().Validate(this);


            // Validações adicionais.

            ValidateGender();
        }

        private void ValidateGender()
        {
            if (Gender.IsValid()) return;

            foreach (var error in Gender.ValidationResult.Errors)
            {
                ValidationResult.Errors.Add(error);
            }
        }
    }
}