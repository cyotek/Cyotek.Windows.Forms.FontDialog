using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace Cyotek.Windows.Forms.Demo
{
  // Cyotek ImageBox
  // Copyright (c) 2010-2015 Cyotek Ltd.
  // http://cyotek.com
  // http://cyotek.com/blog/tag/imagebox

  // Licensed under the MIT License. See license.txt for the full text.

  // If you use this control in your applications, attribution, donations or contributions are welcome.

  internal class EventsListBox : ListBox
  {
    #region Constructors

    public EventsListBox()
    {
      this.IntegralHeight = false;
    }

    #endregion

    #region Properties

    [DefaultValue(false)]
    public new bool IntegralHeight
    {
      get { return base.IntegralHeight; }
      set { base.IntegralHeight = value; }
    }

    #endregion

    #region Methods

    public void AddEvent(string eventName)
    {
      this.AddEvent(eventName, null);
    }

    public void AddEvent(string eventName, IDictionary<string, object> values)
    {
      this.AddEvent(null, eventName, values);
    }

    public void AddEvent(Control sender, string eventName)
    {
      this.AddEvent(sender, eventName, null);
    }

    public void AddEvent(Control sender, string eventName, IDictionary<string, object> values)
    {
      StringBuilder eventData;

      eventData = new StringBuilder();

      eventData.Append(DateTime.Now.ToLongTimeString());
      eventData.Append("\t");
      if (sender != null)
      {
        eventData.Append(sender.Name);
        eventData.Append(".");
      }
      eventData.Append(eventName);
      eventData.Append("(");

      if (values != null)
      {
        int index;

        index = 0;

        foreach (KeyValuePair<string, object> value in values)
        {
          eventData.AppendFormat("{0} = {1}", value.Key, value.Value);

          if (index < values.Count - 1)
          {
            eventData.Append(", ");
          }

          index++;
        }
      }
      eventData.Append(")");

      this.Items.Add(eventData.ToString());
      this.TopIndex = this.Items.Count - (this.ClientSize.Height / this.ItemHeight);
    }

    #endregion
  }
}
