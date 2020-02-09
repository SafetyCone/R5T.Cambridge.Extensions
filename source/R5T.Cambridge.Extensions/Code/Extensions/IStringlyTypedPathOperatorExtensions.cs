using System;

using R5T.Lombardy;


namespace R5T.Cambridge.Extensions
{
    public static class IStringlyTypedPathOperatorExtensions
    {
        public static string GetSolutionFileProjectFileRelativePath(this IStringlyTypedPathOperator stringlyTypedPathOperator, string solutionFilePath, string projectFilePath)
        {
            var solutionDirectoryPath = stringlyTypedPathOperator.GetDirectoryPathForFilePath(solutionFilePath);

            var projectFileRelativePath = stringlyTypedPathOperator.GetRelativePathDirectoryToFile(solutionDirectoryPath, projectFilePath);
            return projectFileRelativePath;
        }
    }
}
