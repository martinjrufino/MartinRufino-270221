using MartinJRufino_20210227.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MartinJRufino_20210227.Manager.Interfaces
{
    public interface IDomainManager
    {
        Task<AlbumResponse> GetAllAlbums();
        Task<PhotoResponse> GetPhotos(int albumId);
        Task<CommentResponse> GetComments(int albumId);
    }
}
