using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookMessengerLib;
namespace FmAPI
{
    class FBAccess
    {
        static void Main(string[] args)
        {
            MessengerAPI obj = new MessengerAPI("EAAiZApOi1Kb4BAGlGVA93ccXecvz74t9iG3o98VfbJBC1MkbZAX8k3a41LKAjTKdZATP0e7SQZCmY7sAsT8sbB2wctMob41bJwPlq2TW4I0E53BzE1CE9eeCcg0wrGhlCuJlr6HPkNJ0h40G36GKZBH0gv5oD7mNWWzesshhd8QZDZD");
            obj.SendTextMessageAsync(660746514005471, "Hello");
        }
    }
}