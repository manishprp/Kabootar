using Microsoft.Maui.Controls;

namespace Kabootar
{
    public class ChatDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate FromMessageTemplate { get; set; }
        public DataTemplate ToMessageTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var ite = (ChatDataModel)item;
            if (ite.IsReceived)
                return FromMessageTemplate;
            return ToMessageTemplate;
        }
    }
}