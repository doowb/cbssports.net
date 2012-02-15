using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CBSSportsDotNet.Requests
{
    public interface ICbsRequest
    {
        string Url { get; set; }
        ICbsRequestParameters RequestParameters { get; set; }
    }
}
