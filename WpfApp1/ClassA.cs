
using System;
using System.ComponentModel;

namespace WpfApp1
{
    public class ClassA : INotifyPropertyChanged
    {
        private static string label = "静态字符";
        public static string myLabel
        {
            get { return label; }
            set
            {
                label = value;
                StaticPropertyChanged?.Invoke(null, new PropertyChangedEventArgs(nameof(myLabel)));//异步更新静态属性
            }
        }
        public static event EventHandler<PropertyChangedEventArgs> StaticPropertyChanged;//静态事件处理属性更改

        private  string str = "非静态字符";
        public  string myString
        {
            get { return str; }
            set
            {
                str = value;
                OnPropertyChanged("myString");//异步更新非静态属性
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;//非静态属性更改
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
