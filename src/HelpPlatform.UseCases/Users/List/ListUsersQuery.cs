﻿using Ardalis.Result;
using HelpPlatform.SharedKernel;

namespace HelpPlatform.UseCases.Users.List;

public record ListUsersQuery(int? Skip, int? Take) : IQuery<Result<IEnumerable<UserDto>>>;
