﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CallCenter
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Database1")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertPRO(PRO instance);
    partial void UpdatePRO(PRO instance);
    partial void DeletePRO(PRO instance);
    partial void Insertuser(user instance);
    partial void Updateuser(user instance);
    partial void Deleteuser(user instance);
    partial void InsertTable(Table instance);
    partial void UpdateTable(Table instance);
    partial void DeleteTable(Table instance);
    partial void InsertRECORD(RECORD instance);
    partial void UpdateRECORD(RECORD instance);
    partial void DeleteRECORD(RECORD instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::CallCenter.Properties.Settings.Default.Database1ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<PRO> PROs
		{
			get
			{
				return this.GetTable<PRO>();
			}
		}
		
		public System.Data.Linq.Table<user> users
		{
			get
			{
				return this.GetTable<user>();
			}
		}
		
		public System.Data.Linq.Table<Table> Tables
		{
			get
			{
				return this.GetTable<Table>();
			}
		}
		
		public System.Data.Linq.Table<RECORD> RECORDs
		{
			get
			{
				return this.GetTable<RECORD>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PROS")]
	public partial class PRO : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _pid;
		
		private string _pname;
		
		private System.Nullable<int> _ptime;
		
		private string _puser;
		
		private System.Nullable<int> _pstatus;
		
		private EntityRef<user> _user;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnpidChanging(int value);
    partial void OnpidChanged();
    partial void OnpnameChanging(string value);
    partial void OnpnameChanged();
    partial void OnptimeChanging(System.Nullable<int> value);
    partial void OnptimeChanged();
    partial void OnpuserChanging(string value);
    partial void OnpuserChanged();
    partial void OnpstatusChanging(System.Nullable<int> value);
    partial void OnpstatusChanged();
    #endregion
		
		public PRO()
		{
			this._user = default(EntityRef<user>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int pid
		{
			get
			{
				return this._pid;
			}
			set
			{
				if ((this._pid != value))
				{
					this.OnpidChanging(value);
					this.SendPropertyChanging();
					this._pid = value;
					this.SendPropertyChanged("pid");
					this.OnpidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pname", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string pname
		{
			get
			{
				return this._pname;
			}
			set
			{
				if ((this._pname != value))
				{
					this.OnpnameChanging(value);
					this.SendPropertyChanging();
					this._pname = value;
					this.SendPropertyChanged("pname");
					this.OnpnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ptime", DbType="Int")]
		public System.Nullable<int> ptime
		{
			get
			{
				return this._ptime;
			}
			set
			{
				if ((this._ptime != value))
				{
					this.OnptimeChanging(value);
					this.SendPropertyChanging();
					this._ptime = value;
					this.SendPropertyChanged("ptime");
					this.OnptimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_puser", DbType="VarChar(255)")]
		public string puser
		{
			get
			{
				return this._puser;
			}
			set
			{
				if ((this._puser != value))
				{
					if (this._user.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnpuserChanging(value);
					this.SendPropertyChanging();
					this._puser = value;
					this.SendPropertyChanged("puser");
					this.OnpuserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pstatus", DbType="Int")]
		public System.Nullable<int> pstatus
		{
			get
			{
				return this._pstatus;
			}
			set
			{
				if ((this._pstatus != value))
				{
					this.OnpstatusChanging(value);
					this.SendPropertyChanging();
					this._pstatus = value;
					this.SendPropertyChanged("pstatus");
					this.OnpstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_PRO", Storage="_user", ThisKey="puser", OtherKey="UNAME", IsForeignKey=true)]
		public user user
		{
			get
			{
				return this._user.Entity;
			}
			set
			{
				user previousValue = this._user.Entity;
				if (((previousValue != value) 
							|| (this._user.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._user.Entity = null;
						previousValue.PROs.Remove(this);
					}
					this._user.Entity = value;
					if ((value != null))
					{
						value.PROs.Add(this);
						this._puser = value.UNAME;
					}
					else
					{
						this._puser = default(string);
					}
					this.SendPropertyChanged("user");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.users")]
	public partial class user : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _UNAME;
		
		private string _UPWD;
		
		private System.Nullable<int> _UPRI;
		
		private string _NAME;
		
		private string _GENDER;
		
		private string _MSTAT;
		
		private System.Nullable<System.DateTime> _DOB;
		
		private string _EMAIL;
		
		private string _COMPN;
		
		private System.Nullable<int> _Vacancy;
		
		private EntitySet<PRO> _PROs;
		
		private EntitySet<RECORD> _RECORDs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUNAMEChanging(string value);
    partial void OnUNAMEChanged();
    partial void OnUPWDChanging(string value);
    partial void OnUPWDChanged();
    partial void OnUPRIChanging(System.Nullable<int> value);
    partial void OnUPRIChanged();
    partial void OnNAMEChanging(string value);
    partial void OnNAMEChanged();
    partial void OnGENDERChanging(string value);
    partial void OnGENDERChanged();
    partial void OnMSTATChanging(string value);
    partial void OnMSTATChanged();
    partial void OnDOBChanging(System.Nullable<System.DateTime> value);
    partial void OnDOBChanged();
    partial void OnEMAILChanging(string value);
    partial void OnEMAILChanged();
    partial void OnCOMPNChanging(string value);
    partial void OnCOMPNChanged();
    partial void OnVacancyChanging(System.Nullable<int> value);
    partial void OnVacancyChanged();
    #endregion
		
		public user()
		{
			this._PROs = new EntitySet<PRO>(new Action<PRO>(this.attach_PROs), new Action<PRO>(this.detach_PROs));
			this._RECORDs = new EntitySet<RECORD>(new Action<RECORD>(this.attach_RECORDs), new Action<RECORD>(this.detach_RECORDs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UNAME", DbType="VarChar(255) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string UNAME
		{
			get
			{
				return this._UNAME;
			}
			set
			{
				if ((this._UNAME != value))
				{
					this.OnUNAMEChanging(value);
					this.SendPropertyChanging();
					this._UNAME = value;
					this.SendPropertyChanged("UNAME");
					this.OnUNAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UPWD", DbType="VarChar(255)")]
		public string UPWD
		{
			get
			{
				return this._UPWD;
			}
			set
			{
				if ((this._UPWD != value))
				{
					this.OnUPWDChanging(value);
					this.SendPropertyChanging();
					this._UPWD = value;
					this.SendPropertyChanged("UPWD");
					this.OnUPWDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UPRI", DbType="Int")]
		public System.Nullable<int> UPRI
		{
			get
			{
				return this._UPRI;
			}
			set
			{
				if ((this._UPRI != value))
				{
					this.OnUPRIChanging(value);
					this.SendPropertyChanging();
					this._UPRI = value;
					this.SendPropertyChanged("UPRI");
					this.OnUPRIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NAME", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string NAME
		{
			get
			{
				return this._NAME;
			}
			set
			{
				if ((this._NAME != value))
				{
					this.OnNAMEChanging(value);
					this.SendPropertyChanging();
					this._NAME = value;
					this.SendPropertyChanged("NAME");
					this.OnNAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GENDER", DbType="VarChar(8)")]
		public string GENDER
		{
			get
			{
				return this._GENDER;
			}
			set
			{
				if ((this._GENDER != value))
				{
					this.OnGENDERChanging(value);
					this.SendPropertyChanging();
					this._GENDER = value;
					this.SendPropertyChanged("GENDER");
					this.OnGENDERChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MSTAT", DbType="VarChar(50)")]
		public string MSTAT
		{
			get
			{
				return this._MSTAT;
			}
			set
			{
				if ((this._MSTAT != value))
				{
					this.OnMSTATChanging(value);
					this.SendPropertyChanging();
					this._MSTAT = value;
					this.SendPropertyChanged("MSTAT");
					this.OnMSTATChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DOB", DbType="Date")]
		public System.Nullable<System.DateTime> DOB
		{
			get
			{
				return this._DOB;
			}
			set
			{
				if ((this._DOB != value))
				{
					this.OnDOBChanging(value);
					this.SendPropertyChanging();
					this._DOB = value;
					this.SendPropertyChanged("DOB");
					this.OnDOBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EMAIL", DbType="VarChar(MAX)")]
		public string EMAIL
		{
			get
			{
				return this._EMAIL;
			}
			set
			{
				if ((this._EMAIL != value))
				{
					this.OnEMAILChanging(value);
					this.SendPropertyChanging();
					this._EMAIL = value;
					this.SendPropertyChanged("EMAIL");
					this.OnEMAILChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_COMPN", DbType="VarChar(MAX)")]
		public string COMPN
		{
			get
			{
				return this._COMPN;
			}
			set
			{
				if ((this._COMPN != value))
				{
					this.OnCOMPNChanging(value);
					this.SendPropertyChanging();
					this._COMPN = value;
					this.SendPropertyChanged("COMPN");
					this.OnCOMPNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Vacancy", DbType="Int")]
		public System.Nullable<int> Vacancy
		{
			get
			{
				return this._Vacancy;
			}
			set
			{
				if ((this._Vacancy != value))
				{
					this.OnVacancyChanging(value);
					this.SendPropertyChanging();
					this._Vacancy = value;
					this.SendPropertyChanged("Vacancy");
					this.OnVacancyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_PRO", Storage="_PROs", ThisKey="UNAME", OtherKey="puser")]
		public EntitySet<PRO> PROs
		{
			get
			{
				return this._PROs;
			}
			set
			{
				this._PROs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_RECORD", Storage="_RECORDs", ThisKey="UNAME", OtherKey="User")]
		public EntitySet<RECORD> RECORDs
		{
			get
			{
				return this._RECORDs;
			}
			set
			{
				this._RECORDs.Assign(value);
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
		
		private void attach_PROs(PRO entity)
		{
			this.SendPropertyChanging();
			entity.user = this;
		}
		
		private void detach_PROs(PRO entity)
		{
			this.SendPropertyChanging();
			entity.user = null;
		}
		
		private void attach_RECORDs(RECORD entity)
		{
			this.SendPropertyChanging();
			entity.user1 = this;
		}
		
		private void detach_RECORDs(RECORD entity)
		{
			this.SendPropertyChanging();
			entity.user1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Table]")]
	public partial class Table : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PR_ID;
		
		private string _USER_ID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPR_IDChanging(int value);
    partial void OnPR_IDChanged();
    partial void OnUSER_IDChanging(string value);
    partial void OnUSER_IDChanged();
    #endregion
		
		public Table()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PR_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int PR_ID
		{
			get
			{
				return this._PR_ID;
			}
			set
			{
				if ((this._PR_ID != value))
				{
					this.OnPR_IDChanging(value);
					this.SendPropertyChanging();
					this._PR_ID = value;
					this.SendPropertyChanged("PR_ID");
					this.OnPR_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_USER_ID", DbType="VarChar(255)")]
		public string USER_ID
		{
			get
			{
				return this._USER_ID;
			}
			set
			{
				if ((this._USER_ID != value))
				{
					this.OnUSER_IDChanging(value);
					this.SendPropertyChanging();
					this._USER_ID = value;
					this.SendPropertyChanged("USER_ID");
					this.OnUSER_IDChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.RECORDS")]
	public partial class RECORD : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _RecordID;
		
		private string _User;
		
		private string _PATH;
		
		private System.Nullable<int> _Duration;
		
		private System.Nullable<int> _PID;
		
		private EntityRef<user> _user1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRecordIDChanging(int value);
    partial void OnRecordIDChanged();
    partial void OnUserChanging(string value);
    partial void OnUserChanged();
    partial void OnPATHChanging(string value);
    partial void OnPATHChanged();
    partial void OnDurationChanging(System.Nullable<int> value);
    partial void OnDurationChanged();
    partial void OnPIDChanging(System.Nullable<int> value);
    partial void OnPIDChanged();
    #endregion
		
		public RECORD()
		{
			this._user1 = default(EntityRef<user>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RecordID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int RecordID
		{
			get
			{
				return this._RecordID;
			}
			set
			{
				if ((this._RecordID != value))
				{
					this.OnRecordIDChanging(value);
					this.SendPropertyChanging();
					this._RecordID = value;
					this.SendPropertyChanged("RecordID");
					this.OnRecordIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[User]", Storage="_User", DbType="VarChar(255)")]
		public string User
		{
			get
			{
				return this._User;
			}
			set
			{
				if ((this._User != value))
				{
					this.OnUserChanging(value);
					this.SendPropertyChanging();
					this._User = value;
					this.SendPropertyChanged("User");
					this.OnUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PATH", DbType="VarChar(MAX)")]
		public string PATH
		{
			get
			{
				return this._PATH;
			}
			set
			{
				if ((this._PATH != value))
				{
					this.OnPATHChanging(value);
					this.SendPropertyChanging();
					this._PATH = value;
					this.SendPropertyChanged("PATH");
					this.OnPATHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Duration", DbType="Int")]
		public System.Nullable<int> Duration
		{
			get
			{
				return this._Duration;
			}
			set
			{
				if ((this._Duration != value))
				{
					this.OnDurationChanging(value);
					this.SendPropertyChanging();
					this._Duration = value;
					this.SendPropertyChanged("Duration");
					this.OnDurationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PID", DbType="Int")]
		public System.Nullable<int> PID
		{
			get
			{
				return this._PID;
			}
			set
			{
				if ((this._PID != value))
				{
					this.OnPIDChanging(value);
					this.SendPropertyChanging();
					this._PID = value;
					this.SendPropertyChanged("PID");
					this.OnPIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_RECORD", Storage="_user1", ThisKey="User", OtherKey="UNAME", IsForeignKey=true)]
		public user user1
		{
			get
			{
				return this._user1.Entity;
			}
			set
			{
				user previousValue = this._user1.Entity;
				if (((previousValue != value) 
							|| (this._user1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._user1.Entity = null;
						previousValue.RECORDs.Remove(this);
					}
					this._user1.Entity = value;
					if ((value != null))
					{
						value.RECORDs.Add(this);
						this._User = value.UNAME;
					}
					else
					{
						this._User = default(string);
					}
					this.SendPropertyChanged("user1");
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
}
#pragma warning restore 1591