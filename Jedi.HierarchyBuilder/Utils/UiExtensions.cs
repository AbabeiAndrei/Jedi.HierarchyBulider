using System;
using System.Linq;
using System.Windows.Forms;

namespace Jedi.HierarchyBuilder.Utils
{
    public static class UiExtensions
    {
        public static void WriteLine(this TextBox textBox, string text)
        {
            textBox.AppendText(text + Environment.NewLine);
        }

        public static TResult GetSelectedValue<TResult>(this ComboBox comboBox)
        {
            if(comboBox == null)
                throw new ArgumentNullException(nameof(comboBox));

            if (comboBox.SelectedValue is TResult)
                return (TResult) comboBox.SelectedValue;

            if(string.IsNullOrEmpty(comboBox.ValueMember))
                throw new Exception("Value memeber not setted");

            if (comboBox.SelectedItem == null)
                return default(TResult);

            return comboBox.SelectedItem.GetValue<TResult>(comboBox.ValueMember);
        }

        public static TResult GetSelectedItem<TResult>(this ComboBox comboBox)
        {
            if (comboBox == null)
                throw new ArgumentNullException(nameof(comboBox));

            if (comboBox.SelectedItem is TResult)
                return (TResult)comboBox.SelectedItem;

            return default(TResult);
        }

        public static void SetSelectedValue<TResult>(this ComboBox comboBox, TResult value)
        {
            if (comboBox == null)
                throw new ArgumentNullException(nameof(comboBox));

            var item = comboBox.Items.OfType<object>()
                               .Select((o, idx) => new {Obj = o, Index = idx})
                               .FirstOrDefault(a => Equals(a.Obj.GetValue<TResult>(comboBox.ValueMember), value));

            if (item != null)
                comboBox.SelectedIndex = item.Index;
        }
    }
}
