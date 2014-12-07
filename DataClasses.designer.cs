﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ASPNETDB")]
public partial class DataClassesDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertEvent(Event instance);
  partial void UpdateEvent(Event instance);
  partial void DeleteEvent(Event instance);
  partial void Insertappointment(appointment instance);
  partial void Updateappointment(appointment instance);
  partial void Deleteappointment(appointment instance);
  #endregion
	
	public DataClassesDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["apppointmentsConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<Event> Events
	{
		get
		{
			return this.GetTable<Event>();
		}
	}
	
	public System.Data.Linq.Table<appointment> appointments
	{
		get
		{
			return this.GetTable<appointment>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Events")]
public partial class Event : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _id;
	
	private string _text;
	
	private System.DateTime _start_date;
	
	private System.DateTime _end_date;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OntextChanging(string value);
    partial void OntextChanged();
    partial void Onstart_dateChanging(System.DateTime value);
    partial void Onstart_dateChanged();
    partial void Onend_dateChanging(System.DateTime value);
    partial void Onend_dateChanged();
    #endregion
	
	public Event()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int id
	{
		get
		{
			return this._id;
		}
		set
		{
			if ((this._id != value))
			{
				this.OnidChanging(value);
				this.SendPropertyChanging();
				this._id = value;
				this.SendPropertyChanged("id");
				this.OnidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_text", DbType="NVarChar(256) NOT NULL", CanBeNull=false)]
	public string text
	{
		get
		{
			return this._text;
		}
		set
		{
			if ((this._text != value))
			{
				this.OntextChanging(value);
				this.SendPropertyChanging();
				this._text = value;
				this.SendPropertyChanged("text");
				this.OntextChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_start_date", DbType="DateTime NOT NULL")]
	public System.DateTime start_date
	{
		get
		{
			return this._start_date;
		}
		set
		{
			if ((this._start_date != value))
			{
				this.Onstart_dateChanging(value);
				this.SendPropertyChanging();
				this._start_date = value;
				this.SendPropertyChanged("start_date");
				this.Onstart_dateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_end_date", DbType="DateTime NOT NULL")]
	public System.DateTime end_date
	{
		get
		{
			return this._end_date;
		}
		set
		{
			if ((this._end_date != value))
			{
				this.Onend_dateChanging(value);
				this.SendPropertyChanging();
				this._end_date = value;
				this.SendPropertyChanged("end_date");
				this.Onend_dateChanged();
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.appointments")]
public partial class appointment : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _appid;
	
	private string _username;
	
	private string _title;
	
	private string _text;
	
	private System.DateTime _appdate;
	
	private System.Nullable<System.DateTime> _addedon;
	
	private System.Nullable<int> _notifybeforehours;
	
	private string _dept;
	
	private string _advisor;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnappidChanging(int value);
    partial void OnappidChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OntitleChanging(string value);
    partial void OntitleChanged();
    partial void OntextChanging(string value);
    partial void OntextChanged();
    partial void OnappdateChanging(System.DateTime value);
    partial void OnappdateChanged();
    partial void OnaddedonChanging(System.Nullable<System.DateTime> value);
    partial void OnaddedonChanged();
    partial void OnnotifybeforehoursChanging(System.Nullable<int> value);
    partial void OnnotifybeforehoursChanged();
    partial void OndeptChanging(string value);
    partial void OndeptChanged();
    partial void OnadvisorChanging(string value);
    partial void OnadvisorChanged();
    #endregion
	
	public appointment()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_appid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int appid
	{
		get
		{
			return this._appid;
		}
		set
		{
			if ((this._appid != value))
			{
				this.OnappidChanging(value);
				this.SendPropertyChanging();
				this._appid = value;
				this.SendPropertyChanged("appid");
				this.OnappidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="NVarChar(256) NOT NULL", CanBeNull=false)]
	public string username
	{
		get
		{
			return this._username;
		}
		set
		{
			if ((this._username != value))
			{
				this.OnusernameChanging(value);
				this.SendPropertyChanging();
				this._username = value;
				this.SendPropertyChanged("username");
				this.OnusernameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_title", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
	public string title
	{
		get
		{
			return this._title;
		}
		set
		{
			if ((this._title != value))
			{
				this.OntitleChanging(value);
				this.SendPropertyChanging();
				this._title = value;
				this.SendPropertyChanged("title");
				this.OntitleChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_text", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
	public string text
	{
		get
		{
			return this._text;
		}
		set
		{
			if ((this._text != value))
			{
				this.OntextChanging(value);
				this.SendPropertyChanging();
				this._text = value;
				this.SendPropertyChanged("text");
				this.OntextChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_appdate", DbType="DateTime NOT NULL")]
	public System.DateTime appdate
	{
		get
		{
			return this._appdate;
		}
		set
		{
			if ((this._appdate != value))
			{
				this.OnappdateChanging(value);
				this.SendPropertyChanging();
				this._appdate = value;
				this.SendPropertyChanged("appdate");
				this.OnappdateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_addedon", DbType="DateTime")]
	public System.Nullable<System.DateTime> addedon
	{
		get
		{
			return this._addedon;
		}
		set
		{
			if ((this._addedon != value))
			{
				this.OnaddedonChanging(value);
				this.SendPropertyChanging();
				this._addedon = value;
				this.SendPropertyChanged("addedon");
				this.OnaddedonChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_notifybeforehours", DbType="Int")]
	public System.Nullable<int> notifybeforehours
	{
		get
		{
			return this._notifybeforehours;
		}
		set
		{
			if ((this._notifybeforehours != value))
			{
				this.OnnotifybeforehoursChanging(value);
				this.SendPropertyChanging();
				this._notifybeforehours = value;
				this.SendPropertyChanged("notifybeforehours");
				this.OnnotifybeforehoursChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dept", DbType="NChar(200)")]
	public string dept
	{
		get
		{
			return this._dept;
		}
		set
		{
			if ((this._dept != value))
			{
				this.OndeptChanging(value);
				this.SendPropertyChanging();
				this._dept = value;
				this.SendPropertyChanged("dept");
				this.OndeptChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_advisor", DbType="NVarChar(200)")]
	public string advisor
	{
		get
		{
			return this._advisor;
		}
		set
		{
			if ((this._advisor != value))
			{
				this.OnadvisorChanging(value);
				this.SendPropertyChanging();
				this._advisor = value;
				this.SendPropertyChanged("advisor");
				this.OnadvisorChanged();
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
#pragma warning restore 1591
