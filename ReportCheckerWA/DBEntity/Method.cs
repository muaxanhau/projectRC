/*
 * Author: 
 * Created: 
 * Description: 
 */
using System;
using DBEntity.Models;
using System.Linq;
using System.Collections.Generic;

namespace DBEntity
{
    /// <summary>
    /// Description of DBMethod.
    /// </summary>
    public static class Method
    {
        public static bool loginUser(string username, string password)
        {
            try
            {
                var context = new Context();
                var result = context.Users.Where(p => p.Username == username.ToLower() && p.Password == password).FirstOrDefault();
                return result != null;
            }
            catch
            {
                return false;
            }
        }
        public static bool addUser(string username, string password)
        {
            try
            {
                var context = new Context();
                var isExist = context.Users.FirstOrDefault(p => p.Username == username) != null;
                if (isExist)
                {
                    return false;
                }
                context.Users.Add(new DBUser() { Username = username, Password = password });
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static List<DBUser> getAllUsers()
        {
            try
            {
                var context = new Context();
                var result = context.Users.Where(p => p.Username != "admin").ToList();
                return result;
            }
            catch
            {
                return null;
            }
        }
        public static bool removeUser(string username)
        {
            try
            {
                var context = new Context();
                var user = context.Users.FirstOrDefault(p => p.Username == username);
                context.Users.Remove(user);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static List<DBColor> getAllColors()
        {
            try
            {
                var context = new Context();
                var result = context.Colors.ToList();
                return result;
            }
            catch
            {
                return null;
            }
        }
        public static bool addDateAndItem(string name, string color, string size, int quantity)
        {
            try
            {
                var context = new Context();
                var itemByName = context.Items.FirstOrDefault(p => p.Name == name);
                if (itemByName == null)
                {
                    var item = new DBItem() { Name = name };
                    context.Items.Add(item);
                    itemByName = item;
                }

                var itemByColor = context.Colors.FirstOrDefault(p => p.Name == color);
                if (itemByColor == null)
                {
                    var colorC = new DBColor() { Name = color };
                    context.Colors.Add(colorC);
                    itemByColor = colorC;
                }

                var itemBySize = context.Sizes.FirstOrDefault(p => p.Name == size);
                if (itemBySize == null)
                {
                    var sizeC = new DBSize() { Name = size };
                    context.Sizes.Add(sizeC);
                    itemBySize = sizeC;
                }
                var date = DateTime.Now;
                context.DateAndListItems.Add(new DBDateAndListItem()
                {
                    Day = date.Day,
                    Month = date.Month,
                    Year = date.Year,
                    Item = itemByName,
                    Color = itemByColor,
                    Size = itemBySize,
                    Quantity = quantity
                });
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
