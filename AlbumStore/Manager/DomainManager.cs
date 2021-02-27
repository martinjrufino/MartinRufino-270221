using MartinJRufino_20210227.Manager.Interfaces;
using MartinJRufino_20210227.Model;
using MartinJRufino_20210227.Model.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MartinJRufino_20210227.Manager
{
    public class DomainManager : IDomainManager
    {
        public async Task<AlbumResponse> GetAllAlbums()
        {
            List<Album> albumLst;

            using (var client = new HttpClient())
            {
                var content = await client.GetStringAsync("https://jsonplaceholder.typicode.com/albums");
                albumLst = JsonConvert.DeserializeObject<List<Album>>(content);
            }

            return new AlbumResponse(albumLst);
        }

        public async Task<PhotoResponse> GetPhotos(int albumId)
        {
            List<Photo> photoLst;

            using (var client = new HttpClient())
            {
                var baseUrl = "https://jsonplaceholder.typicode.com/photos?albumId=";
                var url = string.Concat(baseUrl, albumId);
                var content = await client.GetStringAsync(url);
                photoLst = JsonConvert.DeserializeObject<List<Photo>>(content);
            }

            return new PhotoResponse(photoLst);
        }

        public async Task<CommentResponse> GetComments(int albumId)
        {
            List<Comment> albumLst;

            using (var client = new HttpClient())
            {
                var baseUrl = "https://jsonplaceholder.typicode.com/comments?postId=";
                var url = string.Concat(baseUrl, albumId);
                var content = await client.GetStringAsync(url);
                albumLst = JsonConvert.DeserializeObject<List<Comment>>(content);
            }

            return new CommentResponse(albumLst);
        }
    }
}
