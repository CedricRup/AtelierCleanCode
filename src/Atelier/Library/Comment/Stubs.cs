using System;
using System.Collections;

namespace Library.Comment
{
   public class FileUploadException : Exception
    {
    }

    public class FileItem
    {
        public string GetString()
        {
            throw new NotImplementedException();
        }
    }

    public class DefaultFileItem    
    {
        public object GetFieldName()
        {
            throw new NotImplementedException();
        }
    }

    public class FileUpload
    {
        public FileUpload(DefaultFileItemFactory dfif)
        {
            throw new NotImplementedException();
        }

        public void SetSizeMax(object longValue)
        {
            throw new NotImplementedException();
        }

        public ArrayList ParseRequest(HttpServletRequest req)
        {
            throw new NotImplementedException();
        }
    }

    public class DefaultFileItemFactory
    {
    }

    public class FileUploadBase
    {
        public static bool IsMultipartContent(HttpServletRequest req)
        {
            throw new NotImplementedException();
        }

        public class SizeLimitExceededException : Exception
        {
        }
    }

    public class HttpServletRequest
    {
        public string GetParameter(string actionParameter)
        {
            throw new NotImplementedException();
        }
    }
}

