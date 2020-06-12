using FluentValidation;
using JurisTempus.Data.Entities;
using JurisTempus.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace JurisTempus.Validators
{
  public class CaseViewModelIValidator : AbstractValidator<CaseViewModel>
  {

    public CaseViewModelIValidator()
    {
      RuleFor(c => c.FileNumber).NotEmpty()
        .Matches(@"^\d{10}$")
        .WithMessage("File number must be 10 digits, bitch.");

      RuleFor(c => c.Status)
        .IsInEnum()
        .NotEqual(CaseStatus.Invalid)
        .WithMessage("CaseStatus");
    }

  }
}
