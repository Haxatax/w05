using w05.EndPoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System.ComponentModel;
using System.Windows;
using System.Numerics;

namespace w05
{
    internal class MainWindowViewModel : ObservableRecipient
    {
        public RestCollection<Chatmessage> Messages { get; set; }

        private string textmessage;

        public string TextMessage
        {
            get { return textmessage; }
            set
            {
                if (value != null)
                {
                    SetProperty(ref textmessage, value);
                    OnPropertyChanged();                    
                }
            }
        }
        private string username;

        public string UserName
        {
            get { return username; }
            set
            {
                if (value != null)
                {
                    SetProperty(ref username, value);
                    OnPropertyChanged();
                }
            }
        }
        public ICommand SendMessageCommand { get; set; }
        public MainWindowViewModel()
        {
            if (!IsInDesignMode)
            {
                Messages = new RestCollection<Chatmessage>("http://localhost:5091/", "swagger"); //,"hub"
                SendMessageCommand = new RelayCommand(() =>
                {
                    Messages.Add(new Chatmessage()
                    {
                        Name = UserName,
                        Datamessage = TextMessage
                    });
                });
            }
        }
        public static bool IsInDesignMode
        {
            get
            {
                var prop = DesignerProperties.IsInDesignModeProperty;
                return (bool)DependencyPropertyDescriptor.FromProperty(prop, typeof(FrameworkElement)).Metadata.DefaultValue;
            }
        }
    }
}
