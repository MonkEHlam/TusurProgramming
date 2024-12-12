using ObjectOrientedPractice.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractice.Services
{
    internal static class UserInputHadler
    {
        public static void HandleStringInput<T>(Action<T, string> prop, Action Updater, TextBoxBase tb, T obj)
        {
            try
            {
                prop(obj, tb.Text);
                Updater();
            }
            catch (ArgumentException err)
            {
                tb.BackColor = Color.Red;
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void HandleIntInput<T>(Action<T, int> prop, Action Updater, TextBoxBase tb, T obj)
        {
            try
            {
                prop(obj, int.Parse(tb.Text));
                Updater();
            }
            catch (ArgumentException err)
            {
                tb.BackColor = Color.Red;
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void HandleDoubleInput<T>(Action<T, int> prop, Action Updater, TextBoxBase tb, T obj)
        {
            try
            {
                prop(obj, int.Parse(tb.Text.Replace(",", ".")));
                Updater();
            }
            catch (ArgumentException err)
            {
                tb.BackColor = Color.Red;
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
