using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MartinJRufino_20210227.Model.Response
{
    public class AlbumResponse
    {
        public AlbumResponse(List<Album> albumLst)
        {
            this.albumLst = albumLst;
        }

        public List<Album> albumLst { get; set; }
    }
}
