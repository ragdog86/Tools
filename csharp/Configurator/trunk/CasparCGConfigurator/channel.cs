﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Xml.Serialization;

namespace CasparCGConfigurator
{
    public class channel : INotifyPropertyChanged
    {
        private string _videomode;
        private BindingList<AConsumer> _consumers;

        public channel()
        {
            
            videomode = "PAL";
            consumers = new BindingList<AConsumer>();

        }

        [XmlElement(ElementName = "video-mode")]
        public string videomode
        {
            get { return _videomode; }
            set 
            {
                    _videomode = value;
                    NotifyChanged("videomode"); 
            }
        }

        [XmlArray("consumers")]
        [XmlArrayItem("decklink", Type = typeof(decklinkConsumer))]
        [XmlArrayItem("screen", Type = typeof(screenConsumer))]
        public BindingList<AConsumer> consumers
        {
            get { return _consumers; }
            set { _consumers = value; NotifyChanged("consumers");}
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }
}
