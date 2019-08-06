using System;
using System.CodeDom;
using FluentApi.Validators;
using FluentValidation.Attributes;

namespace FluentApi.Models
{
    [Validator(typeof(DeviceModelValidator))]
    public class DeviceModel
    {
        public string Name { get; set; }

        public int UserId { get; set; }
    }
}