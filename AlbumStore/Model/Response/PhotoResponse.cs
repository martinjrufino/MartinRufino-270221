using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MartinJRufino_20210227.Model.Response
{
    public class PhotoResponse
    {
        public PhotoResponse(List<Photo> photoLst)
        {
            this.photoLst = photoLst;
        }

        public List<Photo> photoLst { get; set; }
    }
}
