using System;

using R5T.Lombardy;


namespace R5T.Cambridge.Extensions
{
    public static class IStringlyTypedPathOperatorExtensions
    {
        /// <summary>
        /// Performs special solution directory path-relative formatting.
        /// </summary>
        public static string GetSolutionFileProjectFileRelativePath(this IStringlyTypedPathOperator stringlyTypedPathOperator, string solutionFilePath, string projectFilePath)
        {
            var solutionDirectoryPath = stringlyTypedPathOperator.GetDirectoryPathForFilePath(solutionFilePath);

            var projectFileRelativePath = stringlyTypedPathOperator.GetRelativePathDirectoryToFile(solutionDirectoryPath, projectFilePath);
            return projectFileRelativePath;
        }

        /// <summary>
        /// Performs special solution directory path-relative formatting.
        /// </summary>
        public static string GetProjectFilePath(this IStringlyTypedPathOperator stringlyTypedPathOperator, string solutionFilePath, string projectFileRelativePath)
        {
            var solutionFileDirectoryPath = stringlyTypedPathOperator.GetDirectoryPathForFilePath(solutionFilePath);

            var projectFilePath = stringlyTypedPathOperator.Combine(solutionFileDirectoryPath, projectFileRelativePath);
            return projectFilePath;
        }
    }
}
