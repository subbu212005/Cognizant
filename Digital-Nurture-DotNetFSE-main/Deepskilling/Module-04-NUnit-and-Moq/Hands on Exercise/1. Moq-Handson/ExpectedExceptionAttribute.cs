using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using NUnit.Framework.Internal.Commands;
using System;

namespace PlayerManager.Tests
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class ExpectedExceptionAttribute : NUnitAttribute, IWrapTestMethod
    {
        private readonly Type _expectedException;

        public ExpectedExceptionAttribute(Type exceptionType)
        {
            _expectedException = exceptionType;
        }

        public TestCommand Wrap(TestCommand command)
        {
            return new ExpectedExceptionCommand(command, _expectedException);
        }
    }

    public class ExpectedExceptionCommand : TestCommand
    {
        private readonly TestCommand _innerCommand;
        private readonly Type _expectedType;

        public ExpectedExceptionCommand(TestCommand command, Type expectedType) : base(command.Test)
        {
            _innerCommand = command;
            _expectedType = expectedType;
        }

        public override TestResult Execute(TestExecutionContext context)
        {
            try
            {
                _innerCommand.Execute(context);
            }
            catch (Exception ex)
            {
                Exception actualException = ex;
                while (actualException.InnerException != null && 
                       (actualException is System.Reflection.TargetInvocationException || 
                        actualException.GetType().Name == "NUnitException" ||
                        (actualException.GetType().FullName?.StartsWith("NUnit") == true)))
                {
                    actualException = actualException.InnerException;
                }

                if (_expectedType.IsInstanceOfType(actualException))
                {
                    context.CurrentResult.SetResult(ResultState.Success);
                }
                else
                {
                    context.CurrentResult.SetResult(ResultState.Failure, $"Expected {_expectedType.Name} but caught {actualException.GetType().Name}.");
                }
                return context.CurrentResult;
            }

            context.CurrentResult.SetResult(ResultState.Failure, $"Expected {_expectedType.Name} but no exception was thrown.");
            return context.CurrentResult;
        }
    }
}
