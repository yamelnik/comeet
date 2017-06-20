using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface IDbHandler
    {
        User GetUser(Guid userId);

        IEnumerable<Tag> GetTagsByUser(Guid userId);

        IEnumerable<Tag> GetAllTags();

        IEnumerable<User> GetUsersByTags(IEnumerable<Tag> tags);

        IEnumerable<User> GetUsersByString(string str);

        IEnumerable<User> GetAllUsers();

        Tag GetTag(string category, string value);

        IEnumerable<Tag> GetAllTagsInCategory(string categoryName);

        void AddNewTag(Tag newTag);

        void AddNewUser(User newUser);

        void AddTagToUser(Guid userId, Tag newTag);

        void UpdateUser(Guid userId, User newUser);
    }
}
