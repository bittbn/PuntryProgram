﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PuntryProgram
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="PuntryDB")]
	public partial class DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Определения метода расширяемости
    partial void OnCreated();
    partial void InsertAccessLevels(AccessLevels instance);
    partial void UpdateAccessLevels(AccessLevels instance);
    partial void DeleteAccessLevels(AccessLevels instance);
    partial void InsertUsers(Users instance);
    partial void UpdateUsers(Users instance);
    partial void DeleteUsers(Users instance);
    partial void InsertFavoriteFiles(FavoriteFiles instance);
    partial void UpdateFavoriteFiles(FavoriteFiles instance);
    partial void DeleteFavoriteFiles(FavoriteFiles instance);
    partial void InsertFileChanges(FileChanges instance);
    partial void UpdateFileChanges(FileChanges instance);
    partial void DeleteFileChanges(FileChanges instance);
    partial void InsertFiles(Files instance);
    partial void UpdateFiles(Files instance);
    partial void DeleteFiles(Files instance);
    partial void InsertStatusFile(StatusFile instance);
    partial void UpdateStatusFile(StatusFile instance);
    partial void DeleteStatusFile(StatusFile instance);
    #endregion
		
		public DataClassesDataContext() : 
				base(global::PuntryProgram.Properties.Settings.Default.PuntryDBAzureConnection, mappingSource)
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
		
		public System.Data.Linq.Table<AccessLevels> AccessLevels
		{
			get
			{
				return this.GetTable<AccessLevels>();
			}
		}
		
		public System.Data.Linq.Table<Users> Users
		{
			get
			{
				return this.GetTable<Users>();
			}
		}
		
		public System.Data.Linq.Table<FavoriteFiles> FavoriteFiles
		{
			get
			{
				return this.GetTable<FavoriteFiles>();
			}
		}
		
		public System.Data.Linq.Table<FileChanges> FileChanges
		{
			get
			{
				return this.GetTable<FileChanges>();
			}
		}
		
		public System.Data.Linq.Table<Files> Files
		{
			get
			{
				return this.GetTable<Files>();
			}
		}
		
		public System.Data.Linq.Table<StatusFile> StatusFile
		{
			get
			{
				return this.GetTable<StatusFile>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AccessLevels")]
	public partial class AccessLevels : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private EntitySet<Users> _Users;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    #endregion
		
		public AccessLevels()
		{
			this._Users = new EntitySet<Users>(new Action<Users>(this.attach_Users), new Action<Users>(this.detach_Users));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(50)")]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AccessLevels_Users", Storage="_Users", ThisKey="id", OtherKey="level_id")]
		public EntitySet<Users> Users
		{
			get
			{
				return this._Users;
			}
			set
			{
				this._Users.Assign(value);
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
		
		private void attach_Users(Users entity)
		{
			this.SendPropertyChanging();
			entity.AccessLevels = this;
		}
		
		private void detach_Users(Users entity)
		{
			this.SendPropertyChanging();
			entity.AccessLevels = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class Users : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private string _surname;
		
		private string _login;
		
		private System.Nullable<System.Guid> _password;
		
		private System.Data.Linq.Binary _image;
		
		private System.Nullable<System.DateTime> _datetime_at;
		
		private System.Nullable<int> _level_id;
		
		private bool _root;
		
		private EntitySet<FavoriteFiles> _FavoriteFiles;
		
		private EntitySet<FileChanges> _FileChanges;
		
		private EntitySet<Files> _Files;
		
		private EntityRef<AccessLevels> _AccessLevels;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnsurnameChanging(string value);
    partial void OnsurnameChanged();
    partial void OnloginChanging(string value);
    partial void OnloginChanged();
    partial void OnpasswordChanging(System.Nullable<System.Guid> value);
    partial void OnpasswordChanged();
    partial void OnimageChanging(System.Data.Linq.Binary value);
    partial void OnimageChanged();
    partial void Ondatetime_atChanging(System.Nullable<System.DateTime> value);
    partial void Ondatetime_atChanged();
    partial void Onlevel_idChanging(System.Nullable<int> value);
    partial void Onlevel_idChanged();
    partial void OnrootChanging(bool value);
    partial void OnrootChanged();
    #endregion
		
		public Users()
		{
			this._FavoriteFiles = new EntitySet<FavoriteFiles>(new Action<FavoriteFiles>(this.attach_FavoriteFiles), new Action<FavoriteFiles>(this.detach_FavoriteFiles));
			this._FileChanges = new EntitySet<FileChanges>(new Action<FileChanges>(this.attach_FileChanges), new Action<FileChanges>(this.detach_FileChanges));
			this._Files = new EntitySet<Files>(new Action<Files>(this.attach_Files), new Action<Files>(this.detach_Files));
			this._AccessLevels = default(EntityRef<AccessLevels>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(50)")]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_surname", DbType="NVarChar(50)")]
		public string surname
		{
			get
			{
				return this._surname;
			}
			set
			{
				if ((this._surname != value))
				{
					this.OnsurnameChanging(value);
					this.SendPropertyChanging();
					this._surname = value;
					this.SendPropertyChanged("surname");
					this.OnsurnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_login", DbType="NVarChar(50)")]
		public string login
		{
			get
			{
				return this._login;
			}
			set
			{
				if ((this._login != value))
				{
					this.OnloginChanging(value);
					this.SendPropertyChanging();
					this._login = value;
					this.SendPropertyChanged("login");
					this.OnloginChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="UniqueIdentifier")]
		public System.Nullable<System.Guid> password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_image", DbType="VarBinary(MAX)", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary image
		{
			get
			{
				return this._image;
			}
			set
			{
				if ((this._image != value))
				{
					this.OnimageChanging(value);
					this.SendPropertyChanging();
					this._image = value;
					this.SendPropertyChanged("image");
					this.OnimageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_datetime_at", DbType="DateTime")]
		public System.Nullable<System.DateTime> datetime_at
		{
			get
			{
				return this._datetime_at;
			}
			set
			{
				if ((this._datetime_at != value))
				{
					this.Ondatetime_atChanging(value);
					this.SendPropertyChanging();
					this._datetime_at = value;
					this.SendPropertyChanged("datetime_at");
					this.Ondatetime_atChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_level_id", DbType="Int")]
		public System.Nullable<int> level_id
		{
			get
			{
				return this._level_id;
			}
			set
			{
				if ((this._level_id != value))
				{
					if (this._AccessLevels.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onlevel_idChanging(value);
					this.SendPropertyChanging();
					this._level_id = value;
					this.SendPropertyChanged("level_id");
					this.Onlevel_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_root", DbType="Bit NOT NULL")]
		public bool root
		{
			get
			{
				return this._root;
			}
			set
			{
				if ((this._root != value))
				{
					this.OnrootChanging(value);
					this.SendPropertyChanging();
					this._root = value;
					this.SendPropertyChanged("root");
					this.OnrootChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Users_FavoriteFiles", Storage="_FavoriteFiles", ThisKey="id", OtherKey="user_id")]
		public EntitySet<FavoriteFiles> FavoriteFiles
		{
			get
			{
				return this._FavoriteFiles;
			}
			set
			{
				this._FavoriteFiles.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Users_FileChanges", Storage="_FileChanges", ThisKey="id", OtherKey="user_id")]
		public EntitySet<FileChanges> FileChanges
		{
			get
			{
				return this._FileChanges;
			}
			set
			{
				this._FileChanges.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Users_Files", Storage="_Files", ThisKey="id", OtherKey="user_id")]
		public EntitySet<Files> Files
		{
			get
			{
				return this._Files;
			}
			set
			{
				this._Files.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AccessLevels_Users", Storage="_AccessLevels", ThisKey="level_id", OtherKey="id", IsForeignKey=true)]
		public AccessLevels AccessLevels
		{
			get
			{
				return this._AccessLevels.Entity;
			}
			set
			{
				AccessLevels previousValue = this._AccessLevels.Entity;
				if (((previousValue != value) 
							|| (this._AccessLevels.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._AccessLevels.Entity = null;
						previousValue.Users.Remove(this);
					}
					this._AccessLevels.Entity = value;
					if ((value != null))
					{
						value.Users.Add(this);
						this._level_id = value.id;
					}
					else
					{
						this._level_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("AccessLevels");
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
		
		private void attach_FavoriteFiles(FavoriteFiles entity)
		{
			this.SendPropertyChanging();
			entity.Users = this;
		}
		
		private void detach_FavoriteFiles(FavoriteFiles entity)
		{
			this.SendPropertyChanging();
			entity.Users = null;
		}
		
		private void attach_FileChanges(FileChanges entity)
		{
			this.SendPropertyChanging();
			entity.Users = this;
		}
		
		private void detach_FileChanges(FileChanges entity)
		{
			this.SendPropertyChanging();
			entity.Users = null;
		}
		
		private void attach_Files(Files entity)
		{
			this.SendPropertyChanging();
			entity.Users = this;
		}
		
		private void detach_Files(Files entity)
		{
			this.SendPropertyChanging();
			entity.Users = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.FavoriteFiles")]
	public partial class FavoriteFiles : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private System.Nullable<int> _file_id;
		
		private System.Nullable<int> _user_id;
		
		private EntityRef<Users> _Users;
		
		private EntityRef<Files> _Files;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onfile_idChanging(System.Nullable<int> value);
    partial void Onfile_idChanged();
    partial void Onuser_idChanging(System.Nullable<int> value);
    partial void Onuser_idChanged();
    #endregion
		
		public FavoriteFiles()
		{
			this._Users = default(EntityRef<Users>);
			this._Files = default(EntityRef<Files>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_file_id", DbType="Int")]
		public System.Nullable<int> file_id
		{
			get
			{
				return this._file_id;
			}
			set
			{
				if ((this._file_id != value))
				{
					if (this._Files.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onfile_idChanging(value);
					this.SendPropertyChanging();
					this._file_id = value;
					this.SendPropertyChanged("file_id");
					this.Onfile_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_id", DbType="Int")]
		public System.Nullable<int> user_id
		{
			get
			{
				return this._user_id;
			}
			set
			{
				if ((this._user_id != value))
				{
					if (this._Users.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onuser_idChanging(value);
					this.SendPropertyChanging();
					this._user_id = value;
					this.SendPropertyChanged("user_id");
					this.Onuser_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Users_FavoriteFiles", Storage="_Users", ThisKey="user_id", OtherKey="id", IsForeignKey=true)]
		public Users Users
		{
			get
			{
				return this._Users.Entity;
			}
			set
			{
				Users previousValue = this._Users.Entity;
				if (((previousValue != value) 
							|| (this._Users.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Users.Entity = null;
						previousValue.FavoriteFiles.Remove(this);
					}
					this._Users.Entity = value;
					if ((value != null))
					{
						value.FavoriteFiles.Add(this);
						this._user_id = value.id;
					}
					else
					{
						this._user_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Users");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Files_FavoriteFiles", Storage="_Files", ThisKey="file_id", OtherKey="id", IsForeignKey=true)]
		public Files Files
		{
			get
			{
				return this._Files.Entity;
			}
			set
			{
				Files previousValue = this._Files.Entity;
				if (((previousValue != value) 
							|| (this._Files.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Files.Entity = null;
						previousValue.FavoriteFiles.Remove(this);
					}
					this._Files.Entity = value;
					if ((value != null))
					{
						value.FavoriteFiles.Add(this);
						this._file_id = value.id;
					}
					else
					{
						this._file_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Files");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.FileChanges")]
	public partial class FileChanges : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _comment;
		
		private System.Nullable<System.DateTime> _datetime_up;
		
		private System.Nullable<int> _file_id;
		
		private System.Nullable<int> _user_id;
		
		private EntityRef<Users> _Users;
		
		private EntityRef<Files> _Files;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OncommentChanging(string value);
    partial void OncommentChanged();
    partial void Ondatetime_upChanging(System.Nullable<System.DateTime> value);
    partial void Ondatetime_upChanged();
    partial void Onfile_idChanging(System.Nullable<int> value);
    partial void Onfile_idChanged();
    partial void Onuser_idChanging(System.Nullable<int> value);
    partial void Onuser_idChanged();
    #endregion
		
		public FileChanges()
		{
			this._Users = default(EntityRef<Users>);
			this._Files = default(EntityRef<Files>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_comment", DbType="NVarChar(250)")]
		public string comment
		{
			get
			{
				return this._comment;
			}
			set
			{
				if ((this._comment != value))
				{
					this.OncommentChanging(value);
					this.SendPropertyChanging();
					this._comment = value;
					this.SendPropertyChanged("comment");
					this.OncommentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_datetime_up", DbType="DateTime")]
		public System.Nullable<System.DateTime> datetime_up
		{
			get
			{
				return this._datetime_up;
			}
			set
			{
				if ((this._datetime_up != value))
				{
					this.Ondatetime_upChanging(value);
					this.SendPropertyChanging();
					this._datetime_up = value;
					this.SendPropertyChanged("datetime_up");
					this.Ondatetime_upChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_file_id", DbType="Int")]
		public System.Nullable<int> file_id
		{
			get
			{
				return this._file_id;
			}
			set
			{
				if ((this._file_id != value))
				{
					if (this._Files.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onfile_idChanging(value);
					this.SendPropertyChanging();
					this._file_id = value;
					this.SendPropertyChanged("file_id");
					this.Onfile_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_id", DbType="Int")]
		public System.Nullable<int> user_id
		{
			get
			{
				return this._user_id;
			}
			set
			{
				if ((this._user_id != value))
				{
					if (this._Users.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onuser_idChanging(value);
					this.SendPropertyChanging();
					this._user_id = value;
					this.SendPropertyChanged("user_id");
					this.Onuser_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Users_FileChanges", Storage="_Users", ThisKey="user_id", OtherKey="id", IsForeignKey=true)]
		public Users Users
		{
			get
			{
				return this._Users.Entity;
			}
			set
			{
				Users previousValue = this._Users.Entity;
				if (((previousValue != value) 
							|| (this._Users.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Users.Entity = null;
						previousValue.FileChanges.Remove(this);
					}
					this._Users.Entity = value;
					if ((value != null))
					{
						value.FileChanges.Add(this);
						this._user_id = value.id;
					}
					else
					{
						this._user_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Users");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Files_FileChanges", Storage="_Files", ThisKey="file_id", OtherKey="id", IsForeignKey=true)]
		public Files Files
		{
			get
			{
				return this._Files.Entity;
			}
			set
			{
				Files previousValue = this._Files.Entity;
				if (((previousValue != value) 
							|| (this._Files.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Files.Entity = null;
						previousValue.FileChanges.Remove(this);
					}
					this._Files.Entity = value;
					if ((value != null))
					{
						value.FileChanges.Add(this);
						this._file_id = value.id;
					}
					else
					{
						this._file_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Files");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Files")]
	public partial class Files : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private string _comment;
		
		private System.Data.Linq.Binary _data;
		
		private string _extension;
		
		private System.Nullable<int> _size;
		
		private bool _archive;
		
		private System.Nullable<int> _status_file_id;
		
		private System.Nullable<int> _user_id;
		
		private EntitySet<FavoriteFiles> _FavoriteFiles;
		
		private EntitySet<FileChanges> _FileChanges;
		
		private EntityRef<Users> _Users;
		
		private EntityRef<StatusFile> _StatusFile;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OncommentChanging(string value);
    partial void OncommentChanged();
    partial void OndataChanging(System.Data.Linq.Binary value);
    partial void OndataChanged();
    partial void OnextensionChanging(string value);
    partial void OnextensionChanged();
    partial void OnsizeChanging(System.Nullable<int> value);
    partial void OnsizeChanged();
    partial void OnarchiveChanging(bool value);
    partial void OnarchiveChanged();
    partial void Onstatus_file_idChanging(System.Nullable<int> value);
    partial void Onstatus_file_idChanged();
    partial void Onuser_idChanging(System.Nullable<int> value);
    partial void Onuser_idChanged();
    #endregion
		
		public Files()
		{
			this._FavoriteFiles = new EntitySet<FavoriteFiles>(new Action<FavoriteFiles>(this.attach_FavoriteFiles), new Action<FavoriteFiles>(this.detach_FavoriteFiles));
			this._FileChanges = new EntitySet<FileChanges>(new Action<FileChanges>(this.attach_FileChanges), new Action<FileChanges>(this.detach_FileChanges));
			this._Users = default(EntityRef<Users>);
			this._StatusFile = default(EntityRef<StatusFile>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(50)")]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_comment", DbType="NVarChar(250)")]
		public string comment
		{
			get
			{
				return this._comment;
			}
			set
			{
				if ((this._comment != value))
				{
					this.OncommentChanging(value);
					this.SendPropertyChanging();
					this._comment = value;
					this.SendPropertyChanged("comment");
					this.OncommentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_data", DbType="VarBinary(MAX)", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary data
		{
			get
			{
				return this._data;
			}
			set
			{
				if ((this._data != value))
				{
					this.OndataChanging(value);
					this.SendPropertyChanging();
					this._data = value;
					this.SendPropertyChanged("data");
					this.OndataChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_extension", DbType="NVarChar(20)")]
		public string extension
		{
			get
			{
				return this._extension;
			}
			set
			{
				if ((this._extension != value))
				{
					this.OnextensionChanging(value);
					this.SendPropertyChanging();
					this._extension = value;
					this.SendPropertyChanged("extension");
					this.OnextensionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_size", DbType="Int")]
		public System.Nullable<int> size
		{
			get
			{
				return this._size;
			}
			set
			{
				if ((this._size != value))
				{
					this.OnsizeChanging(value);
					this.SendPropertyChanging();
					this._size = value;
					this.SendPropertyChanged("size");
					this.OnsizeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_archive", DbType="Bit NOT NULL")]
		public bool archive
		{
			get
			{
				return this._archive;
			}
			set
			{
				if ((this._archive != value))
				{
					this.OnarchiveChanging(value);
					this.SendPropertyChanging();
					this._archive = value;
					this.SendPropertyChanged("archive");
					this.OnarchiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status_file_id", DbType="Int")]
		public System.Nullable<int> status_file_id
		{
			get
			{
				return this._status_file_id;
			}
			set
			{
				if ((this._status_file_id != value))
				{
					if (this._StatusFile.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onstatus_file_idChanging(value);
					this.SendPropertyChanging();
					this._status_file_id = value;
					this.SendPropertyChanged("status_file_id");
					this.Onstatus_file_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_id", DbType="Int")]
		public System.Nullable<int> user_id
		{
			get
			{
				return this._user_id;
			}
			set
			{
				if ((this._user_id != value))
				{
					if (this._Users.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onuser_idChanging(value);
					this.SendPropertyChanging();
					this._user_id = value;
					this.SendPropertyChanged("user_id");
					this.Onuser_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Files_FavoriteFiles", Storage="_FavoriteFiles", ThisKey="id", OtherKey="file_id")]
		public EntitySet<FavoriteFiles> FavoriteFiles
		{
			get
			{
				return this._FavoriteFiles;
			}
			set
			{
				this._FavoriteFiles.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Files_FileChanges", Storage="_FileChanges", ThisKey="id", OtherKey="file_id")]
		public EntitySet<FileChanges> FileChanges
		{
			get
			{
				return this._FileChanges;
			}
			set
			{
				this._FileChanges.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Users_Files", Storage="_Users", ThisKey="user_id", OtherKey="id", IsForeignKey=true)]
		public Users Users
		{
			get
			{
				return this._Users.Entity;
			}
			set
			{
				Users previousValue = this._Users.Entity;
				if (((previousValue != value) 
							|| (this._Users.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Users.Entity = null;
						previousValue.Files.Remove(this);
					}
					this._Users.Entity = value;
					if ((value != null))
					{
						value.Files.Add(this);
						this._user_id = value.id;
					}
					else
					{
						this._user_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Users");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="StatusFile_Files", Storage="_StatusFile", ThisKey="status_file_id", OtherKey="id", IsForeignKey=true)]
		public StatusFile StatusFile
		{
			get
			{
				return this._StatusFile.Entity;
			}
			set
			{
				StatusFile previousValue = this._StatusFile.Entity;
				if (((previousValue != value) 
							|| (this._StatusFile.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._StatusFile.Entity = null;
						previousValue.Files.Remove(this);
					}
					this._StatusFile.Entity = value;
					if ((value != null))
					{
						value.Files.Add(this);
						this._status_file_id = value.id;
					}
					else
					{
						this._status_file_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("StatusFile");
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
		
		private void attach_FavoriteFiles(FavoriteFiles entity)
		{
			this.SendPropertyChanging();
			entity.Files = this;
		}
		
		private void detach_FavoriteFiles(FavoriteFiles entity)
		{
			this.SendPropertyChanging();
			entity.Files = null;
		}
		
		private void attach_FileChanges(FileChanges entity)
		{
			this.SendPropertyChanging();
			entity.Files = this;
		}
		
		private void detach_FileChanges(FileChanges entity)
		{
			this.SendPropertyChanging();
			entity.Files = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.StatusFile")]
	public partial class StatusFile : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private EntitySet<Files> _Files;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    #endregion
		
		public StatusFile()
		{
			this._Files = new EntitySet<Files>(new Action<Files>(this.attach_Files), new Action<Files>(this.detach_Files));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(50)")]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="StatusFile_Files", Storage="_Files", ThisKey="id", OtherKey="status_file_id")]
		public EntitySet<Files> Files
		{
			get
			{
				return this._Files;
			}
			set
			{
				this._Files.Assign(value);
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
		
		private void attach_Files(Files entity)
		{
			this.SendPropertyChanging();
			entity.StatusFile = this;
		}
		
		private void detach_Files(Files entity)
		{
			this.SendPropertyChanging();
			entity.StatusFile = null;
		}
	}
}
#pragma warning restore 1591
