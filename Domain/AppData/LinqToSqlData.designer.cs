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

namespace Domain.AppData
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="TinyUrl")]
	public partial class LinqToSqlDataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAspNetUser(AspNetUser instance);
    partial void UpdateAspNetUser(AspNetUser instance);
    partial void DeleteAspNetUser(AspNetUser instance);
    partial void InsertAspNetUserRole(AspNetUserRole instance);
    partial void UpdateAspNetUserRole(AspNetUserRole instance);
    partial void DeleteAspNetUserRole(AspNetUserRole instance);
    partial void InsertAspNetUserLogin(AspNetUserLogin instance);
    partial void UpdateAspNetUserLogin(AspNetUserLogin instance);
    partial void DeleteAspNetUserLogin(AspNetUserLogin instance);
    partial void InsertAspNetUserClaim(AspNetUserClaim instance);
    partial void UpdateAspNetUserClaim(AspNetUserClaim instance);
    partial void DeleteAspNetUserClaim(AspNetUserClaim instance);
    partial void InsertAspNetRole(AspNetRole instance);
    partial void UpdateAspNetRole(AspNetRole instance);
    partial void DeleteAspNetRole(AspNetRole instance);
    partial void InsertTinyUrl(TinyUrl instance);
    partial void UpdateTinyUrl(TinyUrl instance);
    partial void DeleteTinyUrl(TinyUrl instance);
    #endregion
		
		public LinqToSqlDataDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["TinyUrlConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToSqlDataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToSqlDataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToSqlDataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToSqlDataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<AspNetUser> AspNetUsers
		{
			get
			{
				return this.GetTable<AspNetUser>();
			}
		}
		
		public System.Data.Linq.Table<AspNetUserRole> AspNetUserRoles
		{
			get
			{
				return this.GetTable<AspNetUserRole>();
			}
		}
		
		public System.Data.Linq.Table<AspNetUserLogin> AspNetUserLogins
		{
			get
			{
				return this.GetTable<AspNetUserLogin>();
			}
		}
		
		public System.Data.Linq.Table<AspNetUserClaim> AspNetUserClaims
		{
			get
			{
				return this.GetTable<AspNetUserClaim>();
			}
		}
		
		public System.Data.Linq.Table<AspNetRole> AspNetRoles
		{
			get
			{
				return this.GetTable<AspNetRole>();
			}
		}
		
		public System.Data.Linq.Table<TinyUrl> TinyUrls
		{
			get
			{
				return this.GetTable<TinyUrl>();
			}
		}
		
		public System.Data.Linq.Table<MostRecentTinyUrl> MostRecentTinyUrls
		{
			get
			{
				return this.GetTable<MostRecentTinyUrl>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AspNetUsers")]
	public partial class AspNetUser : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Id;
		
		private string _Email;
		
		private bool _EmailConfirmed;
		
		private string _PasswordHash;
		
		private string _SecurityStamp;
		
		private string _PhoneNumber;
		
		private bool _PhoneNumberConfirmed;
		
		private bool _TwoFactorEnabled;
		
		private System.Nullable<System.DateTime> _LockoutEndDateUtc;
		
		private bool _LockoutEnabled;
		
		private int _AccessFailedCount;
		
		private string _UserName;
		
		private EntitySet<AspNetUserRole> _AspNetUserRoles;
		
		private EntitySet<AspNetUserLogin> _AspNetUserLogins;
		
		private EntitySet<AspNetUserClaim> _AspNetUserClaims;
		
		private EntitySet<TinyUrl> _TinyUrls;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(string value);
    partial void OnIdChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnEmailConfirmedChanging(bool value);
    partial void OnEmailConfirmedChanged();
    partial void OnPasswordHashChanging(string value);
    partial void OnPasswordHashChanged();
    partial void OnSecurityStampChanging(string value);
    partial void OnSecurityStampChanged();
    partial void OnPhoneNumberChanging(string value);
    partial void OnPhoneNumberChanged();
    partial void OnPhoneNumberConfirmedChanging(bool value);
    partial void OnPhoneNumberConfirmedChanged();
    partial void OnTwoFactorEnabledChanging(bool value);
    partial void OnTwoFactorEnabledChanged();
    partial void OnLockoutEndDateUtcChanging(System.Nullable<System.DateTime> value);
    partial void OnLockoutEndDateUtcChanged();
    partial void OnLockoutEnabledChanging(bool value);
    partial void OnLockoutEnabledChanged();
    partial void OnAccessFailedCountChanging(int value);
    partial void OnAccessFailedCountChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    #endregion
		
		public AspNetUser()
		{
			this._AspNetUserRoles = new EntitySet<AspNetUserRole>(new Action<AspNetUserRole>(this.attach_AspNetUserRoles), new Action<AspNetUserRole>(this.detach_AspNetUserRoles));
			this._AspNetUserLogins = new EntitySet<AspNetUserLogin>(new Action<AspNetUserLogin>(this.attach_AspNetUserLogins), new Action<AspNetUserLogin>(this.detach_AspNetUserLogins));
			this._AspNetUserClaims = new EntitySet<AspNetUserClaim>(new Action<AspNetUserClaim>(this.attach_AspNetUserClaims), new Action<AspNetUserClaim>(this.detach_AspNetUserClaims));
			this._TinyUrls = new EntitySet<TinyUrl>(new Action<TinyUrl>(this.attach_TinyUrls), new Action<TinyUrl>(this.detach_TinyUrls));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="NVarChar(128) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(256)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmailConfirmed", DbType="Bit NOT NULL")]
		public bool EmailConfirmed
		{
			get
			{
				return this._EmailConfirmed;
			}
			set
			{
				if ((this._EmailConfirmed != value))
				{
					this.OnEmailConfirmedChanging(value);
					this.SendPropertyChanging();
					this._EmailConfirmed = value;
					this.SendPropertyChanged("EmailConfirmed");
					this.OnEmailConfirmedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PasswordHash", DbType="NVarChar(MAX)")]
		public string PasswordHash
		{
			get
			{
				return this._PasswordHash;
			}
			set
			{
				if ((this._PasswordHash != value))
				{
					this.OnPasswordHashChanging(value);
					this.SendPropertyChanging();
					this._PasswordHash = value;
					this.SendPropertyChanged("PasswordHash");
					this.OnPasswordHashChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SecurityStamp", DbType="NVarChar(MAX)")]
		public string SecurityStamp
		{
			get
			{
				return this._SecurityStamp;
			}
			set
			{
				if ((this._SecurityStamp != value))
				{
					this.OnSecurityStampChanging(value);
					this.SendPropertyChanging();
					this._SecurityStamp = value;
					this.SendPropertyChanged("SecurityStamp");
					this.OnSecurityStampChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNumber", DbType="NVarChar(MAX)")]
		public string PhoneNumber
		{
			get
			{
				return this._PhoneNumber;
			}
			set
			{
				if ((this._PhoneNumber != value))
				{
					this.OnPhoneNumberChanging(value);
					this.SendPropertyChanging();
					this._PhoneNumber = value;
					this.SendPropertyChanged("PhoneNumber");
					this.OnPhoneNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNumberConfirmed", DbType="Bit NOT NULL")]
		public bool PhoneNumberConfirmed
		{
			get
			{
				return this._PhoneNumberConfirmed;
			}
			set
			{
				if ((this._PhoneNumberConfirmed != value))
				{
					this.OnPhoneNumberConfirmedChanging(value);
					this.SendPropertyChanging();
					this._PhoneNumberConfirmed = value;
					this.SendPropertyChanged("PhoneNumberConfirmed");
					this.OnPhoneNumberConfirmedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TwoFactorEnabled", DbType="Bit NOT NULL")]
		public bool TwoFactorEnabled
		{
			get
			{
				return this._TwoFactorEnabled;
			}
			set
			{
				if ((this._TwoFactorEnabled != value))
				{
					this.OnTwoFactorEnabledChanging(value);
					this.SendPropertyChanging();
					this._TwoFactorEnabled = value;
					this.SendPropertyChanged("TwoFactorEnabled");
					this.OnTwoFactorEnabledChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LockoutEndDateUtc", DbType="DateTime")]
		public System.Nullable<System.DateTime> LockoutEndDateUtc
		{
			get
			{
				return this._LockoutEndDateUtc;
			}
			set
			{
				if ((this._LockoutEndDateUtc != value))
				{
					this.OnLockoutEndDateUtcChanging(value);
					this.SendPropertyChanging();
					this._LockoutEndDateUtc = value;
					this.SendPropertyChanged("LockoutEndDateUtc");
					this.OnLockoutEndDateUtcChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LockoutEnabled", DbType="Bit NOT NULL")]
		public bool LockoutEnabled
		{
			get
			{
				return this._LockoutEnabled;
			}
			set
			{
				if ((this._LockoutEnabled != value))
				{
					this.OnLockoutEnabledChanging(value);
					this.SendPropertyChanging();
					this._LockoutEnabled = value;
					this.SendPropertyChanged("LockoutEnabled");
					this.OnLockoutEnabledChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccessFailedCount", DbType="Int NOT NULL")]
		public int AccessFailedCount
		{
			get
			{
				return this._AccessFailedCount;
			}
			set
			{
				if ((this._AccessFailedCount != value))
				{
					this.OnAccessFailedCountChanging(value);
					this.SendPropertyChanging();
					this._AccessFailedCount = value;
					this.SendPropertyChanged("AccessFailedCount");
					this.OnAccessFailedCountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NVarChar(256) NOT NULL", CanBeNull=false)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AspNetUser_AspNetUserRole", Storage="_AspNetUserRoles", ThisKey="Id", OtherKey="UserId")]
		public EntitySet<AspNetUserRole> AspNetUserRoles
		{
			get
			{
				return this._AspNetUserRoles;
			}
			set
			{
				this._AspNetUserRoles.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AspNetUser_AspNetUserLogin", Storage="_AspNetUserLogins", ThisKey="Id", OtherKey="UserId")]
		public EntitySet<AspNetUserLogin> AspNetUserLogins
		{
			get
			{
				return this._AspNetUserLogins;
			}
			set
			{
				this._AspNetUserLogins.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AspNetUser_AspNetUserClaim", Storage="_AspNetUserClaims", ThisKey="Id", OtherKey="UserId")]
		public EntitySet<AspNetUserClaim> AspNetUserClaims
		{
			get
			{
				return this._AspNetUserClaims;
			}
			set
			{
				this._AspNetUserClaims.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AspNetUser_TinyUrl", Storage="_TinyUrls", ThisKey="Id", OtherKey="AspNetUsersID")]
		public EntitySet<TinyUrl> TinyUrls
		{
			get
			{
				return this._TinyUrls;
			}
			set
			{
				this._TinyUrls.Assign(value);
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
		
		private void attach_AspNetUserRoles(AspNetUserRole entity)
		{
			this.SendPropertyChanging();
			entity.AspNetUser = this;
		}
		
		private void detach_AspNetUserRoles(AspNetUserRole entity)
		{
			this.SendPropertyChanging();
			entity.AspNetUser = null;
		}
		
		private void attach_AspNetUserLogins(AspNetUserLogin entity)
		{
			this.SendPropertyChanging();
			entity.AspNetUser = this;
		}
		
		private void detach_AspNetUserLogins(AspNetUserLogin entity)
		{
			this.SendPropertyChanging();
			entity.AspNetUser = null;
		}
		
		private void attach_AspNetUserClaims(AspNetUserClaim entity)
		{
			this.SendPropertyChanging();
			entity.AspNetUser = this;
		}
		
		private void detach_AspNetUserClaims(AspNetUserClaim entity)
		{
			this.SendPropertyChanging();
			entity.AspNetUser = null;
		}
		
		private void attach_TinyUrls(TinyUrl entity)
		{
			this.SendPropertyChanging();
			entity.AspNetUser = this;
		}
		
		private void detach_TinyUrls(TinyUrl entity)
		{
			this.SendPropertyChanging();
			entity.AspNetUser = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AspNetUserRoles")]
	public partial class AspNetUserRole : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _UserId;
		
		private string _RoleId;
		
		private EntityRef<AspNetUser> _AspNetUser;
		
		private EntityRef<AspNetRole> _AspNetRole;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIdChanging(string value);
    partial void OnUserIdChanged();
    partial void OnRoleIdChanging(string value);
    partial void OnRoleIdChanged();
    #endregion
		
		public AspNetUserRole()
		{
			this._AspNetUser = default(EntityRef<AspNetUser>);
			this._AspNetRole = default(EntityRef<AspNetRole>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="NVarChar(128) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					if (this._AspNetUser.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoleId", DbType="NVarChar(128) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string RoleId
		{
			get
			{
				return this._RoleId;
			}
			set
			{
				if ((this._RoleId != value))
				{
					if (this._AspNetRole.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRoleIdChanging(value);
					this.SendPropertyChanging();
					this._RoleId = value;
					this.SendPropertyChanged("RoleId");
					this.OnRoleIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AspNetUser_AspNetUserRole", Storage="_AspNetUser", ThisKey="UserId", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public AspNetUser AspNetUser
		{
			get
			{
				return this._AspNetUser.Entity;
			}
			set
			{
				AspNetUser previousValue = this._AspNetUser.Entity;
				if (((previousValue != value) 
							|| (this._AspNetUser.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._AspNetUser.Entity = null;
						previousValue.AspNetUserRoles.Remove(this);
					}
					this._AspNetUser.Entity = value;
					if ((value != null))
					{
						value.AspNetUserRoles.Add(this);
						this._UserId = value.Id;
					}
					else
					{
						this._UserId = default(string);
					}
					this.SendPropertyChanged("AspNetUser");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AspNetRole_AspNetUserRole", Storage="_AspNetRole", ThisKey="RoleId", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public AspNetRole AspNetRole
		{
			get
			{
				return this._AspNetRole.Entity;
			}
			set
			{
				AspNetRole previousValue = this._AspNetRole.Entity;
				if (((previousValue != value) 
							|| (this._AspNetRole.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._AspNetRole.Entity = null;
						previousValue.AspNetUserRoles.Remove(this);
					}
					this._AspNetRole.Entity = value;
					if ((value != null))
					{
						value.AspNetUserRoles.Add(this);
						this._RoleId = value.Id;
					}
					else
					{
						this._RoleId = default(string);
					}
					this.SendPropertyChanged("AspNetRole");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AspNetUserLogins")]
	public partial class AspNetUserLogin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _LoginProvider;
		
		private string _ProviderKey;
		
		private string _UserId;
		
		private EntityRef<AspNetUser> _AspNetUser;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnLoginProviderChanging(string value);
    partial void OnLoginProviderChanged();
    partial void OnProviderKeyChanging(string value);
    partial void OnProviderKeyChanged();
    partial void OnUserIdChanging(string value);
    partial void OnUserIdChanged();
    #endregion
		
		public AspNetUserLogin()
		{
			this._AspNetUser = default(EntityRef<AspNetUser>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoginProvider", DbType="NVarChar(128) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string LoginProvider
		{
			get
			{
				return this._LoginProvider;
			}
			set
			{
				if ((this._LoginProvider != value))
				{
					this.OnLoginProviderChanging(value);
					this.SendPropertyChanging();
					this._LoginProvider = value;
					this.SendPropertyChanged("LoginProvider");
					this.OnLoginProviderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProviderKey", DbType="NVarChar(128) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ProviderKey
		{
			get
			{
				return this._ProviderKey;
			}
			set
			{
				if ((this._ProviderKey != value))
				{
					this.OnProviderKeyChanging(value);
					this.SendPropertyChanging();
					this._ProviderKey = value;
					this.SendPropertyChanged("ProviderKey");
					this.OnProviderKeyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="NVarChar(128) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					if (this._AspNetUser.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AspNetUser_AspNetUserLogin", Storage="_AspNetUser", ThisKey="UserId", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public AspNetUser AspNetUser
		{
			get
			{
				return this._AspNetUser.Entity;
			}
			set
			{
				AspNetUser previousValue = this._AspNetUser.Entity;
				if (((previousValue != value) 
							|| (this._AspNetUser.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._AspNetUser.Entity = null;
						previousValue.AspNetUserLogins.Remove(this);
					}
					this._AspNetUser.Entity = value;
					if ((value != null))
					{
						value.AspNetUserLogins.Add(this);
						this._UserId = value.Id;
					}
					else
					{
						this._UserId = default(string);
					}
					this.SendPropertyChanged("AspNetUser");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AspNetUserClaims")]
	public partial class AspNetUserClaim : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _UserId;
		
		private string _ClaimType;
		
		private string _ClaimValue;
		
		private EntityRef<AspNetUser> _AspNetUser;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnUserIdChanging(string value);
    partial void OnUserIdChanged();
    partial void OnClaimTypeChanging(string value);
    partial void OnClaimTypeChanged();
    partial void OnClaimValueChanging(string value);
    partial void OnClaimValueChanged();
    #endregion
		
		public AspNetUserClaim()
		{
			this._AspNetUser = default(EntityRef<AspNetUser>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="NVarChar(128) NOT NULL", CanBeNull=false)]
		public string UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					if (this._AspNetUser.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClaimType", DbType="NVarChar(MAX)")]
		public string ClaimType
		{
			get
			{
				return this._ClaimType;
			}
			set
			{
				if ((this._ClaimType != value))
				{
					this.OnClaimTypeChanging(value);
					this.SendPropertyChanging();
					this._ClaimType = value;
					this.SendPropertyChanged("ClaimType");
					this.OnClaimTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClaimValue", DbType="NVarChar(MAX)")]
		public string ClaimValue
		{
			get
			{
				return this._ClaimValue;
			}
			set
			{
				if ((this._ClaimValue != value))
				{
					this.OnClaimValueChanging(value);
					this.SendPropertyChanging();
					this._ClaimValue = value;
					this.SendPropertyChanged("ClaimValue");
					this.OnClaimValueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AspNetUser_AspNetUserClaim", Storage="_AspNetUser", ThisKey="UserId", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public AspNetUser AspNetUser
		{
			get
			{
				return this._AspNetUser.Entity;
			}
			set
			{
				AspNetUser previousValue = this._AspNetUser.Entity;
				if (((previousValue != value) 
							|| (this._AspNetUser.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._AspNetUser.Entity = null;
						previousValue.AspNetUserClaims.Remove(this);
					}
					this._AspNetUser.Entity = value;
					if ((value != null))
					{
						value.AspNetUserClaims.Add(this);
						this._UserId = value.Id;
					}
					else
					{
						this._UserId = default(string);
					}
					this.SendPropertyChanged("AspNetUser");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AspNetRoles")]
	public partial class AspNetRole : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Id;
		
		private string _Name;
		
		private EntitySet<AspNetUserRole> _AspNetUserRoles;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(string value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public AspNetRole()
		{
			this._AspNetUserRoles = new EntitySet<AspNetUserRole>(new Action<AspNetUserRole>(this.attach_AspNetUserRoles), new Action<AspNetUserRole>(this.detach_AspNetUserRoles));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="NVarChar(128) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(256) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AspNetRole_AspNetUserRole", Storage="_AspNetUserRoles", ThisKey="Id", OtherKey="RoleId")]
		public EntitySet<AspNetUserRole> AspNetUserRoles
		{
			get
			{
				return this._AspNetUserRoles;
			}
			set
			{
				this._AspNetUserRoles.Assign(value);
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
		
		private void attach_AspNetUserRoles(AspNetUserRole entity)
		{
			this.SendPropertyChanging();
			entity.AspNetRole = this;
		}
		
		private void detach_AspNetUserRoles(AspNetUserRole entity)
		{
			this.SendPropertyChanging();
			entity.AspNetRole = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TinyUrls")]
	public partial class TinyUrl : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _TinyUrlString;
		
		private string _UrlString;
		
		private string _AspNetUsersID;
		
		private EntityRef<AspNetUser> _AspNetUser;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTinyUrlStringChanging(string value);
    partial void OnTinyUrlStringChanged();
    partial void OnUrlStringChanging(string value);
    partial void OnUrlStringChanged();
    partial void OnAspNetUsersIDChanging(string value);
    partial void OnAspNetUsersIDChanged();
    #endregion
		
		public TinyUrl()
		{
			this._AspNetUser = default(EntityRef<AspNetUser>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TinyUrlString", DbType="VarChar(30) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string TinyUrlString
		{
			get
			{
				return this._TinyUrlString;
			}
			set
			{
				if ((this._TinyUrlString != value))
				{
					this.OnTinyUrlStringChanging(value);
					this.SendPropertyChanging();
					this._TinyUrlString = value;
					this.SendPropertyChanged("TinyUrlString");
					this.OnTinyUrlStringChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UrlString", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string UrlString
		{
			get
			{
				return this._UrlString;
			}
			set
			{
				if ((this._UrlString != value))
				{
					this.OnUrlStringChanging(value);
					this.SendPropertyChanging();
					this._UrlString = value;
					this.SendPropertyChanged("UrlString");
					this.OnUrlStringChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AspNetUsersID", DbType="NVarChar(128) NOT NULL", CanBeNull=false)]
		public string AspNetUsersID
		{
			get
			{
				return this._AspNetUsersID;
			}
			set
			{
				if ((this._AspNetUsersID != value))
				{
					if (this._AspNetUser.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAspNetUsersIDChanging(value);
					this.SendPropertyChanging();
					this._AspNetUsersID = value;
					this.SendPropertyChanged("AspNetUsersID");
					this.OnAspNetUsersIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AspNetUser_TinyUrl", Storage="_AspNetUser", ThisKey="AspNetUsersID", OtherKey="Id", IsForeignKey=true)]
		public AspNetUser AspNetUser
		{
			get
			{
				return this._AspNetUser.Entity;
			}
			set
			{
				AspNetUser previousValue = this._AspNetUser.Entity;
				if (((previousValue != value) 
							|| (this._AspNetUser.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._AspNetUser.Entity = null;
						previousValue.TinyUrls.Remove(this);
					}
					this._AspNetUser.Entity = value;
					if ((value != null))
					{
						value.TinyUrls.Add(this);
						this._AspNetUsersID = value.Id;
					}
					else
					{
						this._AspNetUsersID = default(string);
					}
					this.SendPropertyChanged("AspNetUser");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MostRecentTinyUrl")]
	public partial class MostRecentTinyUrl
	{
		
		private string _AsciiValue;
		
		private string _TinyUrlString;
		
		public MostRecentTinyUrl()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AsciiValue", DbType="VarChar(2000)")]
		public string AsciiValue
		{
			get
			{
				return this._AsciiValue;
			}
			set
			{
				if ((this._AsciiValue != value))
				{
					this._AsciiValue = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TinyUrlString", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string TinyUrlString
		{
			get
			{
				return this._TinyUrlString;
			}
			set
			{
				if ((this._TinyUrlString != value))
				{
					this._TinyUrlString = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
