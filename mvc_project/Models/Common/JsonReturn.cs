using System.Collections.Generic;

namespace mvc_project.Models.Common
{
    public class JsonReturn
    {
        public int returnType { get; set; }

        public bool success { get; set; }

        public string errorMessage { get; set; }

        public object innerObject { get; set; }

        public long totalCount { get; set; }

        public static JsonReturn SuccessWithoutInnerObject()
        {
            return new JsonReturn
            {
                innerObject = null,
                errorMessage = "",
                success = true,
                returnType = (int) mvc_project.Models.Common.ReturnType.Ok,
                totalCount = 0
            };
        }

        public static JsonReturn SuccessWithInnerObject(object obj)
        {
            return new JsonReturn
            {
                innerObject = obj,
                errorMessage = "",
                success = true,
                returnType = (int) mvc_project.Models.Common.ReturnType.Ok,
                totalCount = 0
            };
        }

        public static JsonReturn ErrorWithSimpleMessage(string message)
        {
            return new JsonReturn
            {
                innerObject = null,
                errorMessage = message,
                success = false,
                returnType = (int) mvc_project.Models.Common.ReturnType.Error,
                totalCount = 0
            };
        }

        public static JsonReturn ErrorWithListMessage(
            string title, 
            List<string> messageList)
        {
            return new JsonReturn
            {
                innerObject = messageList,
                errorMessage = title,
                success = false,
                returnType = (int)mvc_project.Models.Common.ReturnType.Error,
                totalCount = 0
            };
        }

        public static JsonReturn Redirect(string url)
        {
            return new JsonReturn
            {
                innerObject = null,
                errorMessage = url,
                success = false,
                returnType = (int)mvc_project.Models.Common.ReturnType.Redirect,
                totalCount = 0
            };
        }

        public static JsonReturn SuccessWithPaginatedList(
            object list, 
            long totalCount)
        {
            return new JsonReturn
            {
                innerObject = list,
                errorMessage = "",
                success = true,
                returnType = (int) mvc_project.Models.Common.ReturnType.Ok,
                totalCount = totalCount
            };
        }
    }
}