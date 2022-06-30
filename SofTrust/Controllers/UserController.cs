using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using SofTrust.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace SofTrust.Controllers
{
      [ApiController]
      [Route("api/[controller]")]
      public class UserController : Controller
      {
          private const string emailPattern = @"^[a-zA-Z0-9.!#$%&’*+/=?^_{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";
          private const string phonePattern = @"^((\+7|7|8)+([0-9]){10})$";
          ApplicationContext db;

          public UserController(ApplicationContext context)
          {
              db = context;
              //AddThemes();
          }

      [HttpPost]
      public Message Post(User user)
      {
          if(Validation(user))
          {
              Contact contact;
              if (CheckUser(user))
              {
                   contact = db.Contacts.First(p => p.name == user.name && p.email == user.mail && p.phoneNumber == user.phoneNumber);
              }
              else
              {
                   contact = new Contact(user.name, user.mail, user.phoneNumber);
                   db.Contacts.Add(contact);
                   db.SaveChanges();
              }
              Message msg = new Message(contact, user.selectedTheme, user.message);
              db.Messages.Add(msg);
              db.SaveChanges();
              return msg;
          }
          return null;
      }

      [HttpGet]
      public IEnumerable<Dictionary> GetDictionary()
      {
        var tmp = db.Dictionaries.ToList();
        return tmp;
      }

      [Route("/saveduser")]
      [HttpGet]
      public User GetSavedUser()
      {
            User infoUser = new User();
            List<Message> tmp = db.Messages.ToList();
            Message msg = tmp[tmp.Count - 1];
            infoUser.name = msg.Contact.name;
            infoUser.mail = msg.Contact.email;
            infoUser.phoneNumber = msg.Contact.phoneNumber;
            infoUser.selectedTheme = msg.DictionaryId;
            infoUser.message = msg.message;
            return infoUser;
      }
      
      private bool CheckUser(User searchUser)
      {
          bool flag = db.Contacts.Any(p => p.email == searchUser.mail && p.phoneNumber == searchUser.phoneNumber);
          return flag;
      }

      private bool Validation(User user)
      {
          return (Regex.IsMatch(user.phoneNumber, phonePattern, RegexOptions.IgnoreCase) && Regex.IsMatch(user.mail, emailPattern, RegexOptions.IgnoreCase) && (user.name != ""));
      }

      private void AddThemes()
      {
        db.Dictionaries.Add(new Dictionary("Technical Support"));
        db.Dictionaries.Add(new Dictionary("Sales"));
        db.Dictionaries.Add(new Dictionary("Other"));
        db.SaveChanges();
      }
    }
    
}
