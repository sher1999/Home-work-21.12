using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class PostService
    {
        public List<Post> posts;
        public List<Post> GetPosts()
        {
            return posts;
        }

        public void AddPost(Post post)
        {
            posts.Add(post);
        }
        public void UpdatePost(Post post)
        {

        }
        public void Delete(int id)
        {

        }
    }
}
