using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuthorizationUiLevel
{
    public static class UserAuthEvaluator
    {
        public static void EvaluateAuthForItem<T>(T view) where T: Form
        {
            //decide access to view
            var viewClaim = (string)view.Tag;
            if (!string.IsNullOrEmpty(viewClaim))
            {
                //look for the same claim in the user/role claims
                if (!DoesUserClaimAccess(viewClaim))
                {
                    MessageBox.Show("You are not authorized to view " + view.Name);
                    view.Close();
                }

                //get all buttons to evaluate disabling
                var buttons = view.Descendants<Button>().Where((x) => !string.IsNullOrEmpty((string)x.Tag));
                if (buttons.Count() > 0)
                {
                    //Iterate all buttons which needs to be claimed by user
                    foreach (var button in buttons)
                    {
                        //disable the button if the user does not claim them
                        if (!DoesUserClaimAccess((string)button.Tag)) button.Enabled = false;
                    }
                }
            }
        }

        private static bool DoesUserClaimAccess(string claim)
        {
            return !string.IsNullOrEmpty(AuthDetailModelSingleton.Claims.Find((x) => x == claim));
        }

        public static IEnumerable<T> Descendants<T>(this Control control) where T : class
        {
            foreach (Control child in control.Controls)
            {

                T childOfT = child as T;
                if (childOfT != null)
                {
                    yield return (T)childOfT;
                }

                if (child.HasChildren)
                {
                    foreach (T descendant in Descendants<T>(child))
                    {
                        yield return descendant;
                    }
                }
            }
        }
    }
}
