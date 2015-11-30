using System.Linq;
using data = NWT_Twitter.Data;
using model = NWT_Twitter.Models.Data;

namespace NWT_Twitter.Mappers
{
    public class UserMapper
    {
        public static model::User Map(data::User user)
        {
            return new model.User
            {
                Id = user.Id,
                Name = user.Name,
                Surname = user.Surname,
                Nickname = user.Nickname,
                Picture_URL = user.Picture_URL
            };
        }

        public static data::User Map(model::User user)
        {
            return new data.User
            {
                Id = user.Id,
                Name = user.Name,
                Surname = user.Surname,
                Nickname = user.Nickname,
                Picture_URL = user.Picture_URL
            };
        }
    }
}