﻿using ENode.Commanding;
using ENode.Infrastructure;
using Forum.Commands.Accounts;
using Forum.Commands.Posts;
using Forum.Commands.Replies;
using Forum.Commands.Sections;

namespace Forum.Domain.Tests
{
    public class CommandTypeCodeProvider : AbstractTypeCodeProvider, ICommandTypeCodeProvider
    {
        public CommandTypeCodeProvider()
        {
            RegisterType<RegisterNewAccountCommand>(100);
            RegisterType<ConfirmAccountCommand>(101);
            RegisterType<RejectAccountCommand>(102);

            RegisterType<CreateSectionCommand>(200);
            RegisterType<ChangeSectionNameCommand>(201);

            RegisterType<CreatePostCommand>(300);
            RegisterType<UpdatePostCommand>(301);

            RegisterType<CreateReplyCommand>(400);
            RegisterType<ChangeReplyBodyCommand>(401);
        }
    }
}
