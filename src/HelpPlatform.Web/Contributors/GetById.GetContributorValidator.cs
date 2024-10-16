﻿using FastEndpoints;
using FluentValidation;

namespace HelpPlatform.Web.Contributors;

/// <summary>
/// See: https://fast-endpoints.com/docs/validation
/// </summary>
public class GetContributorValidator : Validator<GetContributorByIdRequest> {
    public GetContributorValidator() {
        RuleFor(x => x.ContributorId)
            .GreaterThan(0);
    }
}